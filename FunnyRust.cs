using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunnyRust
{
    public partial class FunnyRust : Form
    {
        private FileSystemWatcher watcher;
        private Entity worldEntity;
        private Dictionary<string, int> lootTable = new Dictionary<string, int>();

        public FunnyRust()
        {
            InitializeComponent();
        }

        void PopulateNode(TreeNode parentNode, List<Entity> entities)
        {
            foreach(var entity in entities)
            {
                if (entity.Name.Length < 3)
                    continue;

                if (entity.Parent != null)
                {
                    if (filterText.Text.Length > 1 && !entity.Name.Contains(filterText.Text) && entity.Parent.Parent == null)
                        continue;

                    //if (entity.Parent.Parent == null && entity.Children.Count < 7)
                        //continue;
                }

                var node = new TreeNode(entity.Name);
                parentNode.Nodes.Add(node);
                PopulateNode(node, entity.Children);
            }
        }

        private void LoadData()
        {
            var info = new DirectoryInfo(@"C:\Program Files (x86)\Steam\steamapps\common\Rust\diagnostics\").GetDirectories()
.OrderByDescending(d => d.LastWriteTimeUtc).First();

            var path = $"{info.FullName}\\GameObject.Hierarchy.txt";
            var parser = new EntityParser();
            worldEntity = parser.Parse(File.ReadAllLines(path));
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            TreeNode worldNode = new TreeNode("World");
            PopulateNode(worldNode, worldEntity.Children);
            worldView.Nodes.Add(worldNode);
        }

        private void FunnyRust_Load(object sender, EventArgs e)
        {
            watcher = new FileSystemWatcher(@"C:\Program Files (x86)\Steam\steamapps\common\Rust\diagnostics");
            watcher.Created += Watcher_Created;
            watcher.EnableRaisingEvents = true;

            ReloadLootFilters();

            lootList.View = View.List;
            lootList.LabelEdit = false;
            lootList.FullRowSelect = true;
        }

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            worldView.BeginInvoke((MethodInvoker)delegate
           {
               Thread.Sleep(5000);
               LoadData();
               LoadLoot();
               LoadPlayers();
           });
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            if (worldEntity == null)
                return;

            worldView.Nodes.Clear();
            TreeNode worldNode = new TreeNode("World");
            PopulateNode(worldNode, worldEntity.Children);
            worldView.Nodes.Add(worldNode);
            worldView.ExpandAll();
        }

        private void buttonRefreshLoot_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadLoot();
            LoadPlayers();
        }

        private void LoadPlayers()
        {
            var players = PlayerParser.Parse(worldEntity.Children).Players;

            PlayerControl previousControl = null;
            foreach(var player in players)
            {
                var playerControl = new PlayerControl();
                playerControl.HeldWeapon.Text = player.HeldWeapon;

                foreach(var wear in player.Wear)
                {
                    playerControl.ListWear.Items.Add(wear);
                }

                playerControl.Left = 10;
                playerControl.Top = 10;

                if (previousControl != null)
                {
                    playerControl.Top = previousControl.Top + previousControl.Height + 10;
                }

                playerTab.Controls.Add(playerControl);
                previousControl = playerControl;
            }
        }

        private void LoadLoot()
        {
            ReloadLootFilters();

            lootList.Items.Clear();
            var info = new DirectoryInfo(@"C:\Program Files (x86)\Steam\steamapps\common\Rust\diagnostics\").GetDirectories()
.OrderByDescending(d => d.LastWriteTimeUtc).First();

            var path = $"{info.FullName}\\GameObject.Count.txt";

            var filters = File.ReadAllLines("lootfilters.txt");

            var newLootTable = new Dictionary<string, int>();

            foreach(var entity in worldEntity.Children)
            {
                bool contains = false;
                foreach (var filter in filters)
                {
                    if (entity.Name.Contains(filter))
                    {
                        contains = true;
                    }
                }

                if (contains)
                {
                    if (newLootTable.ContainsKey(entity.Name))
                    {
                        newLootTable[entity.Name]++;
                    }
                    else
                    {
                        newLootTable.Add(entity.Name, 1);
                    }
                }
            }

            foreach(var line in File.ReadAllLines(path))
            {
            }

            foreach(var loot in newLootTable)
            {
                var difference = 0;
                if (lootTable.ContainsKey(loot.Key))
                {
                    difference = lootTable[loot.Key] - loot.Value;
                }

                if (difference != 0)
                {
                    var sign = Math.Sign(difference);

                    if (sign > 0)
                    {
                        var item = new ListViewItem($"{loot.Value} (+{difference}): {loot.Key}");
                        item.BackColor = Color.LightGreen;
                        lootList.Items.Add(item);
                    }
                    else
                    {
                        var item = new ListViewItem($"{loot.Value} (-{difference}): {loot.Key}");
                        item.BackColor = Color.DarkRed;
                        lootList.Items.Add(item);
                    }
                }
                else
                {
                    var item = new ListViewItem($"{loot.Value}: {FixLootName(loot.Key)}");
                    lootList.Items.Add(item);
                }
            }

            lootTable = newLootTable;
        }

        private void addLootFilter_Click(object sender, EventArgs e)
        {
            File.AppendAllText("lootfilters.txt", lootFilter.Text + '\n');
            lootFilter.Text = "";
            ReloadLootFilters();
        }

        private void ReloadLootFilters()
        {
            if (!File.Exists("lootfilters.txt"))
            {
                File.WriteAllText("lootfilters.txt", "");
            }

            lootFilters.Items.Clear();
            foreach (var line in File.ReadAllLines("lootfilters.txt"))
            {
                lootFilters.Items.Add(line);
            }
        }

        private void lootFilters_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                lootFilters.Items.Remove(lootFilters.SelectedItem);
            }

            File.WriteAllText("lootfilters.txt", "");
            foreach (var filter in lootFilters.Items)
            {
                File.AppendAllText("lootfilters.txt", filter.ToString() + '\n');
            }

            ReloadLootFilters();
        }

        private string FixLootName(string name)
        {
            return name
                .Replace(".prefab", "")
                .Replace("assets", "");
        }

        private void lootList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
