using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicrosoftPaintClone
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeSubMenuPanel.Visible = true;
            viewSubMenuPanel.Visible = false;
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewSubMenuPanel.Visible = true;
            homeSubMenuPanel.Visible = false;
        }
    }
}
