using DevComponents.DotNetBar;
using Dotnetbar.UCs;
using System;
using System.Windows.Forms;

namespace Dotnetbar
{
    public partial class FrmDotnetbar : Form
    {
        public FrmDotnetbar()
        {
            InitializeComponent();
        }

        private void tabControl1_TabItemClose(object sender, DevComponents.DotNetBar.TabStripActionEventArgs e)
        {
            if (tabControl1.SelectedTabIndex != 0)
                if (MessageBox.Show("Bạn có muốn đóng tab " + tabControl1.SelectedTab.Text, "Đóng tab", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    tabControl1.Tabs.Remove(tabControl1.SelectedTab);
        }

        private void addNewTab(string strTabName, UserControl ucContent)
        {
            //-----------If exist tabpage then exit---------------
            foreach (TabItem tabPage in tabControl1.Tabs)
                if (tabPage.Text == strTabName)
                {
                    tabControl1.SelectedTab = tabPage;
                    return;
                }
            //-------------------------Clear Tab Before---------------
            if (tabControl1.Tabs.Count > 1)
                tabControl1.Tabs.RemoveAt(1);

            TabControlPanel newTabPanel = new DevComponents.DotNetBar.TabControlPanel();
            TabItem newTabPage = new TabItem(this.components);
            newTabPage.ImageIndex = 0;
            //newTabPage.MouseDown += new System.Windows.Forms.MouseEventHandler(tabControl1_TabItemClose);
            newTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            newTabPanel.Location = new System.Drawing.Point(0, 26);
            newTabPanel.Name = "panel" + strTabName;
            newTabPanel.Padding = new System.Windows.Forms.Padding(1);
            newTabPanel.Size = new System.Drawing.Size(1230, 384);
            newTabPanel.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            newTabPanel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            newTabPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            newTabPanel.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            newTabPanel.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            newTabPanel.Style.GradientAngle = 90;
            newTabPanel.TabIndex = 2;
            newTabPanel.TabItem = newTabPage;
            //-------------New  tab page---------------------
            Random ran = new Random();
            newTabPage.Name = strTabName + ran.Next(100000) + ran.Next(22342);
            newTabPage.AttachedControl = newTabPanel;
            newTabPage.Text = strTabName;
            ucContent.Dock = DockStyle.Fill;
            newTabPanel.Controls.Add(ucContent);
            //------------add Tab page to Tab control-------------
            tabControl1.Controls.Add(newTabPanel);
            tabControl1.Tabs.Add(newTabPage);
            tabControl1.SelectedTab = newTabPage;
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            var ucBai2 = new UCs.UCBai2();
            addNewTab("Bài 2.1", ucBai2);
        }

        private void đóngTabNàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTabIndex != 0)
                if (MessageBox.Show("Bạn có muốn đóng tab " + tabControl1.SelectedTab.Text, "Đóng tab", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    tabControl1.Tabs.Remove(tabControl1.SelectedTab);
        }

        private void đóngCácTabKhácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = tabControl1.Tabs.Count - 1; i > 0; i--)
            {
                if (tabControl1.SelectedTabIndex != i)
                    tabControl1.Tabs.RemoveAt(i);
            }
            tabControl1.Refresh();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            addNewTab("Phục vụ", new UCTestControlNangCao());
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            addNewTab("Dùng control", new UCControlNangCao2());
        }
    }
}