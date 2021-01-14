using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListviewTreeview
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lvBan.SelectedItems.Count > 0)
            {
                var selected = lvBan.SelectedItems[0];
                lvBan.Items.Remove(selected);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trvTang.SelectedNode != null)
            {
                trvTang.Nodes.Remove(trvTang.SelectedNode);
            }
        }

        private void trvTang_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (trvTang.SelectedNode != null)
            {
                var selected = trvTang.SelectedNode;
                MessageBox.Show(selected.Text);
            }
        }

        private void lvBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBan.SelectedItems.Count > 0)
            {
                var selected = lvBan.SelectedItems[0];
                MessageBox.Show(selected.Text);
            }
        }
    }
}