using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunnyRust
{
    public partial class PlayerControl : UserControl
    {
        public PlayerControl()
        {
            InitializeComponent();
        }

        private void PlayerControl_Load(object sender, EventArgs e)
        {
            ListWear.View = View.List;
            ListWear.LabelEdit = false;
            ListWear.FullRowSelect = true;
        }
    }
}
