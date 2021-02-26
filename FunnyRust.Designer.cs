namespace FunnyRust
{
    partial class FunnyRust
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.worldView = new System.Windows.Forms.TreeView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.filterText = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.TabControl();
            this.treeTab = new System.Windows.Forms.TabPage();
            this.lootTab = new System.Windows.Forms.TabPage();
            this.addLootFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lootFilters = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lootFilter = new System.Windows.Forms.TextBox();
            this.playerTab = new System.Windows.Forms.TabPage();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.lootList = new System.Windows.Forms.ListView();
            this.tabs.SuspendLayout();
            this.treeTab.SuspendLayout();
            this.lootTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // worldView
            // 
            this.worldView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.worldView.Location = new System.Drawing.Point(6, 35);
            this.worldView.Name = "worldView";
            this.worldView.Size = new System.Drawing.Size(795, 391);
            this.worldView.TabIndex = 0;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(6, 6);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // filterText
            // 
            this.filterText.Location = new System.Drawing.Point(513, 9);
            this.filterText.Name = "filterText";
            this.filterText.Size = new System.Drawing.Size(207, 20);
            this.filterText.TabIndex = 5;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(726, 6);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 23);
            this.filterButton.TabIndex = 6;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.treeTab);
            this.tabs.Controls.Add(this.lootTab);
            this.tabs.Controls.Add(this.playerTab);
            this.tabs.Location = new System.Drawing.Point(12, 27);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(815, 458);
            this.tabs.TabIndex = 7;
            // 
            // treeTab
            // 
            this.treeTab.Controls.Add(this.refreshButton);
            this.treeTab.Controls.Add(this.worldView);
            this.treeTab.Controls.Add(this.filterButton);
            this.treeTab.Controls.Add(this.filterText);
            this.treeTab.Location = new System.Drawing.Point(4, 22);
            this.treeTab.Name = "treeTab";
            this.treeTab.Padding = new System.Windows.Forms.Padding(3);
            this.treeTab.Size = new System.Drawing.Size(807, 432);
            this.treeTab.TabIndex = 0;
            this.treeTab.Text = "Tree View";
            this.treeTab.UseVisualStyleBackColor = true;
            // 
            // lootTab
            // 
            this.lootTab.Controls.Add(this.lootList);
            this.lootTab.Controls.Add(this.addLootFilter);
            this.lootTab.Controls.Add(this.label2);
            this.lootTab.Controls.Add(this.lootFilters);
            this.lootTab.Controls.Add(this.label1);
            this.lootTab.Controls.Add(this.lootFilter);
            this.lootTab.Location = new System.Drawing.Point(4, 22);
            this.lootTab.Name = "lootTab";
            this.lootTab.Padding = new System.Windows.Forms.Padding(3);
            this.lootTab.Size = new System.Drawing.Size(807, 432);
            this.lootTab.TabIndex = 1;
            this.lootTab.Text = "Loot";
            this.lootTab.UseVisualStyleBackColor = true;
            // 
            // addLootFilter
            // 
            this.addLootFilter.Location = new System.Drawing.Point(752, 405);
            this.addLootFilter.Name = "addLootFilter";
            this.addLootFilter.Size = new System.Drawing.Size(49, 21);
            this.addLootFilter.TabIndex = 5;
            this.addLootFilter.Text = "Add";
            this.addLootFilter.UseVisualStyleBackColor = true;
            this.addLootFilter.Click += new System.EventHandler(this.addLootFilter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filters";
            // 
            // lootFilters
            // 
            this.lootFilters.FormattingEnabled = true;
            this.lootFilters.Location = new System.Drawing.Point(626, 22);
            this.lootFilters.Name = "lootFilters";
            this.lootFilters.Size = new System.Drawing.Size(175, 355);
            this.lootFilters.TabIndex = 3;
            this.lootFilters.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lootFilters_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(627, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "New filter";
            // 
            // lootFilter
            // 
            this.lootFilter.Location = new System.Drawing.Point(627, 405);
            this.lootFilter.Name = "lootFilter";
            this.lootFilter.Size = new System.Drawing.Size(119, 20);
            this.lootFilter.TabIndex = 1;
            // 
            // playerTab
            // 
            this.playerTab.AutoScroll = true;
            this.playerTab.Location = new System.Drawing.Point(4, 22);
            this.playerTab.Name = "playerTab";
            this.playerTab.Padding = new System.Windows.Forms.Padding(3);
            this.playerTab.Size = new System.Drawing.Size(807, 432);
            this.playerTab.TabIndex = 2;
            this.playerTab.Text = "Players";
            this.playerTab.UseVisualStyleBackColor = true;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(752, 12);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonRefreshLoot_Click);
            // 
            // lootList
            // 
            this.lootList.HideSelection = false;
            this.lootList.Location = new System.Drawing.Point(6, 6);
            this.lootList.Name = "lootList";
            this.lootList.Size = new System.Drawing.Size(615, 419);
            this.lootList.TabIndex = 6;
            this.lootList.UseCompatibleStateImageBehavior = false;
            // 
            // FunnyRust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 497);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.tabs);
            this.Name = "FunnyRust";
            this.Text = "Funny Rust";
            this.Load += new System.EventHandler(this.FunnyRust_Load);
            this.tabs.ResumeLayout(false);
            this.treeTab.ResumeLayout(false);
            this.treeTab.PerformLayout();
            this.lootTab.ResumeLayout(false);
            this.lootTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView worldView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox filterText;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage treeTab;
        private System.Windows.Forms.TabPage lootTab;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TabPage playerTab;
        private System.Windows.Forms.Button addLootFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lootFilters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lootFilter;
        private System.Windows.Forms.ListView lootList;
    }
}

