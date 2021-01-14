
namespace ListviewTreeview
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Tầng 1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Tầng 2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Tầng 3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Tầng 4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Tầng 5");
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Vip 2", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Vip 1", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bàn 1",
            "200",
            "Chiếc"}, 4);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Bàn 2", 4);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Bàn 3", 4);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Bàn 4", 4);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Bàn 5", 4);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Bàn 6", 4);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Bàn 7", 4);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Bàn 8", 4);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.trvTang = new System.Windows.Forms.TreeView();
            this.lvBan = new System.Windows.Forms.ListView();
            this.imageTreeview = new System.Windows.Forms.ImageList(this.components);
            this.imageListview = new System.Windows.Forms.ImageList(this.components);
            this.header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmenuTreeview = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenuListview = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenuTreeview.SuspendLayout();
            this.cmenuListview.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvTang
            // 
            this.trvTang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trvTang.ContextMenuStrip = this.cmenuTreeview;
            this.trvTang.FullRowSelect = true;
            this.trvTang.ImageIndex = 0;
            this.trvTang.ImageList = this.imageTreeview;
            this.trvTang.Location = new System.Drawing.Point(12, 12);
            this.trvTang.Name = "trvTang";
            treeNode1.Name = "Node4";
            treeNode1.Text = "Tầng 1";
            treeNode2.Name = "Node5";
            treeNode2.Text = "Tầng 2";
            treeNode3.Name = "Node6";
            treeNode3.Text = "Tầng 3";
            treeNode4.Name = "Node7";
            treeNode4.Text = "Tầng 4";
            treeNode5.Name = "Node8";
            treeNode5.Text = "Tầng 5";
            this.trvTang.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.trvTang.SelectedImageKey = "home_red.png";
            this.trvTang.Size = new System.Drawing.Size(228, 484);
            this.trvTang.TabIndex = 0;
            this.trvTang.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvTang_AfterSelect);
            // 
            // lvBan
            // 
            this.lvBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvBan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.header,
            this.columnHeader1,
            this.columnHeader2});
            this.lvBan.ContextMenuStrip = this.cmenuListview;
            this.lvBan.FullRowSelect = true;
            listViewGroup1.Header = "Vip 2";
            listViewGroup1.Name = "Vip 2";
            listViewGroup2.Header = "Vip 1";
            listViewGroup2.Name = "listViewGroup2";
            this.lvBan.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lvBan.HideSelection = false;
            listViewItem1.Group = listViewGroup2;
            listViewItem2.Group = listViewGroup2;
            listViewItem3.Group = listViewGroup2;
            listViewItem4.Group = listViewGroup1;
            listViewItem5.Group = listViewGroup1;
            listViewItem6.Group = listViewGroup1;
            listViewItem7.Group = listViewGroup1;
            listViewItem8.Group = listViewGroup1;
            this.lvBan.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.lvBan.LargeImageList = this.imageListview;
            this.lvBan.Location = new System.Drawing.Point(257, 15);
            this.lvBan.Name = "lvBan";
            this.lvBan.Size = new System.Drawing.Size(593, 480);
            this.lvBan.SmallImageList = this.imageListview;
            this.lvBan.TabIndex = 1;
            this.lvBan.UseCompatibleStateImageBehavior = false;
            this.lvBan.View = System.Windows.Forms.View.Details;
            this.lvBan.SelectedIndexChanged += new System.EventHandler(this.lvBan_SelectedIndexChanged);
            // 
            // imageTreeview
            // 
            this.imageTreeview.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageTreeview.ImageStream")));
            this.imageTreeview.TransparentColor = System.Drawing.Color.Transparent;
            this.imageTreeview.Images.SetKeyName(0, "Home.png");
            this.imageTreeview.Images.SetKeyName(1, "home_red.png");
            // 
            // imageListview
            // 
            this.imageListview.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListview.ImageStream")));
            this.imageListview.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListview.Images.SetKeyName(0, "Mic.png");
            this.imageListview.Images.SetKeyName(1, "microphone.ico");
            this.imageListview.Images.SetKeyName(2, "microphone.png");
            this.imageListview.Images.SetKeyName(3, "microsoft_excel.png");
            this.imageListview.Images.SetKeyName(4, "microsoft_office_word.png");
            this.imageListview.Images.SetKeyName(5, "microsoft_word.ico");
            // 
            // header
            // 
            this.header.Text = "Bàn ";
            this.header.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giá tiền";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Đơn vị tính";
            this.columnHeader1.Width = 160;
            // 
            // cmenuTreeview
            // 
            this.cmenuTreeview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.cmenuTreeview.Name = "cmenuTreeview";
            this.cmenuTreeview.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // cmenuListview
            // 
            this.cmenuListview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem1});
            this.cmenuListview.Name = "cmenuListview";
            this.cmenuListview.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 508);
            this.Controls.Add(this.lvBan);
            this.Controls.Add(this.trvTang);
            this.Name = "FrmMain";
            this.Text = "Demo Listview and Treeview";
            this.cmenuTreeview.ResumeLayout(false);
            this.cmenuListview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvTang;
        private System.Windows.Forms.ImageList imageTreeview;
        private System.Windows.Forms.ListView lvBan;
        private System.Windows.Forms.ImageList imageListview;
        public System.Windows.Forms.ColumnHeader header;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip cmenuTreeview;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmenuListview;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
    }
}

