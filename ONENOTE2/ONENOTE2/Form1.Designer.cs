namespace ONENOTE2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("快速笔记页");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("快速笔记", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.top_menuStrip = new System.Windows.Forms.MenuStrip();
            this.file_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastOperation_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextOperation_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tabControl = new System.Windows.Forms.TabControl();
            this.start_tabpage = new System.Windows.Forms.TabPage();
            this.insert_toolStrip = new System.Windows.Forms.ToolStrip();
            this.font_toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.fontsize_toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.insert_tabPage = new System.Windows.Forms.TabPage();
            this.start_toolStrip = new System.Windows.Forms.ToolStrip();
            this.left_tabControl = new System.Windows.Forms.TabControl();
            this.contents_tabPage = new System.Windows.Forms.TabPage();
            this.addnotepage_label = new System.Windows.Forms.Label();
            this.addknowbank_label = new System.Windows.Forms.Label();
            this.list_treeView = new System.Windows.Forms.TreeView();
            this.search_tabPage = new System.Windows.Forms.TabPage();
            this.history_tabPage = new System.Windows.Forms.TabPage();
            this.note_tabControl = new System.Windows.Forms.TabControl();
            this.bold_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.inclines_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.underline_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fontcolor_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pictureinsert_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fileinsret_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.musicinsert_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.urlinsert_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.top_menuStrip.SuspendLayout();
            this.menu_tabControl.SuspendLayout();
            this.start_tabpage.SuspendLayout();
            this.insert_toolStrip.SuspendLayout();
            this.insert_tabPage.SuspendLayout();
            this.start_toolStrip.SuspendLayout();
            this.left_tabControl.SuspendLayout();
            this.contents_tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_menuStrip
            // 
            this.top_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_ToolStripMenuItem,
            this.save_ToolStripMenuItem,
            this.lastOperation_ToolStripMenuItem,
            this.nextOperation_ToolStripMenuItem});
            this.top_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.top_menuStrip.Name = "top_menuStrip";
            this.top_menuStrip.Size = new System.Drawing.Size(862, 25);
            this.top_menuStrip.TabIndex = 0;
            this.top_menuStrip.Text = "menuStrip1";
            // 
            // file_ToolStripMenuItem
            // 
            this.file_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入ToolStripMenuItem,
            this.导出ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.file_ToolStripMenuItem.Name = "file_ToolStripMenuItem";
            this.file_ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.file_ToolStripMenuItem.Text = "文件";
            // 
            // 导入ToolStripMenuItem
            // 
            this.导入ToolStripMenuItem.Name = "导入ToolStripMenuItem";
            this.导入ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.导入ToolStripMenuItem.Text = "导入";
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.导出ToolStripMenuItem.Text = "导出";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // save_ToolStripMenuItem
            // 
            this.save_ToolStripMenuItem.Name = "save_ToolStripMenuItem";
            this.save_ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.save_ToolStripMenuItem.Text = "保存";
            this.save_ToolStripMenuItem.Click += new System.EventHandler(this.save_ToolStripMenuItem_Click);
            // 
            // lastOperation_ToolStripMenuItem
            // 
            this.lastOperation_ToolStripMenuItem.Name = "lastOperation_ToolStripMenuItem";
            this.lastOperation_ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.lastOperation_ToolStripMenuItem.Text = "上一次";
            // 
            // nextOperation_ToolStripMenuItem
            // 
            this.nextOperation_ToolStripMenuItem.Name = "nextOperation_ToolStripMenuItem";
            this.nextOperation_ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.nextOperation_ToolStripMenuItem.Text = "下一次";
            // 
            // menu_tabControl
            // 
            this.menu_tabControl.Controls.Add(this.start_tabpage);
            this.menu_tabControl.Controls.Add(this.insert_tabPage);
            this.menu_tabControl.Location = new System.Drawing.Point(200, 0);
            this.menu_tabControl.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.menu_tabControl.Name = "menu_tabControl";
            this.menu_tabControl.SelectedIndex = 0;
            this.menu_tabControl.Size = new System.Drawing.Size(662, 59);
            this.menu_tabControl.TabIndex = 1;
            // 
            // start_tabpage
            // 
            this.start_tabpage.Controls.Add(this.insert_toolStrip);
            this.start_tabpage.Location = new System.Drawing.Point(4, 22);
            this.start_tabpage.Name = "start_tabpage";
            this.start_tabpage.Padding = new System.Windows.Forms.Padding(3);
            this.start_tabpage.Size = new System.Drawing.Size(654, 33);
            this.start_tabpage.TabIndex = 0;
            this.start_tabpage.Text = "开始";
            this.start_tabpage.UseVisualStyleBackColor = true;
            // 
            // insert_toolStrip
            // 
            this.insert_toolStrip.GripMargin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.insert_toolStrip.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.insert_toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.font_toolStripComboBox,
            this.fontsize_toolStripComboBox,
            this.bold_toolStripButton,
            this.inclines_toolStripButton,
            this.underline_toolStripButton,
            this.fontcolor_toolStripButton});
            this.insert_toolStrip.Location = new System.Drawing.Point(3, 3);
            this.insert_toolStrip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.insert_toolStrip.Name = "insert_toolStrip";
            this.insert_toolStrip.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.insert_toolStrip.Size = new System.Drawing.Size(648, 29);
            this.insert_toolStrip.TabIndex = 0;
            this.insert_toolStrip.Text = "toolStrip2";
            // 
            // font_toolStripComboBox
            // 
            this.font_toolStripComboBox.DropDownWidth = 121;
            this.font_toolStripComboBox.Items.AddRange(new object[] {
            "宋体",
            "黑体"});
            this.font_toolStripComboBox.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.font_toolStripComboBox.Name = "font_toolStripComboBox";
            this.font_toolStripComboBox.Size = new System.Drawing.Size(80, 29);
            this.font_toolStripComboBox.Text = "宋体";
            this.font_toolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.font_toolStripComboBox_SelectedIndexChanged);
            // 
            // fontsize_toolStripComboBox
            // 
            this.fontsize_toolStripComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "10.5",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "18",
            "20",
            "22",
            "24"});
            this.fontsize_toolStripComboBox.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.fontsize_toolStripComboBox.Name = "fontsize_toolStripComboBox";
            this.fontsize_toolStripComboBox.Size = new System.Drawing.Size(80, 29);
            this.fontsize_toolStripComboBox.Text = "11";
            this.fontsize_toolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.fontsize_toolStripComboBox_SelectedIndexChanged);
            // 
            // insert_tabPage
            // 
            this.insert_tabPage.Controls.Add(this.start_toolStrip);
            this.insert_tabPage.Location = new System.Drawing.Point(4, 22);
            this.insert_tabPage.Name = "insert_tabPage";
            this.insert_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.insert_tabPage.Size = new System.Drawing.Size(654, 33);
            this.insert_tabPage.TabIndex = 1;
            this.insert_tabPage.Text = "插入";
            this.insert_tabPage.UseVisualStyleBackColor = true;
            // 
            // start_toolStrip
            // 
            this.start_toolStrip.ImageScalingSize = new System.Drawing.Size(50, 20);
            this.start_toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pictureinsert_toolStripButton,
            this.fileinsret_toolStripButton,
            this.musicinsert_toolStripButton,
            this.urlinsert_toolStripButton});
            this.start_toolStrip.Location = new System.Drawing.Point(3, 3);
            this.start_toolStrip.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.start_toolStrip.Name = "start_toolStrip";
            this.start_toolStrip.Size = new System.Drawing.Size(648, 27);
            this.start_toolStrip.TabIndex = 0;
            this.start_toolStrip.Text = "toolStrip1";
            // 
            // left_tabControl
            // 
            this.left_tabControl.Controls.Add(this.contents_tabPage);
            this.left_tabControl.Controls.Add(this.search_tabPage);
            this.left_tabControl.Controls.Add(this.history_tabPage);
            this.left_tabControl.ItemSize = new System.Drawing.Size(59, 20);
            this.left_tabControl.Location = new System.Drawing.Point(0, 46);
            this.left_tabControl.Margin = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.left_tabControl.Name = "left_tabControl";
            this.left_tabControl.SelectedIndex = 0;
            this.left_tabControl.Size = new System.Drawing.Size(180, 408);
            this.left_tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.left_tabControl.TabIndex = 2;
            // 
            // contents_tabPage
            // 
            this.contents_tabPage.Controls.Add(this.addnotepage_label);
            this.contents_tabPage.Controls.Add(this.addknowbank_label);
            this.contents_tabPage.Controls.Add(this.list_treeView);
            this.contents_tabPage.Location = new System.Drawing.Point(4, 24);
            this.contents_tabPage.Name = "contents_tabPage";
            this.contents_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.contents_tabPage.Size = new System.Drawing.Size(172, 380);
            this.contents_tabPage.TabIndex = 0;
            this.contents_tabPage.Text = "目录";
            this.contents_tabPage.UseVisualStyleBackColor = true;
            // 
            // addnotepage_label
            // 
            this.addnotepage_label.AutoSize = true;
            this.addnotepage_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addnotepage_label.Location = new System.Drawing.Point(107, 365);
            this.addnotepage_label.Name = "addnotepage_label";
            this.addnotepage_label.Size = new System.Drawing.Size(65, 12);
            this.addnotepage_label.TabIndex = 2;
            this.addnotepage_label.Text = "添加笔记页";
            this.addnotepage_label.Click += new System.EventHandler(this.addnotepage_label_Click);
            // 
            // addknowbank_label
            // 
            this.addknowbank_label.AutoSize = true;
            this.addknowbank_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addknowbank_label.Location = new System.Drawing.Point(3, 365);
            this.addknowbank_label.Name = "addknowbank_label";
            this.addknowbank_label.Size = new System.Drawing.Size(65, 12);
            this.addknowbank_label.TabIndex = 1;
            this.addknowbank_label.Text = "添加知识库";
            this.addknowbank_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // list_treeView
            // 
            this.list_treeView.Location = new System.Drawing.Point(0, 0);
            this.list_treeView.Name = "list_treeView";
            treeNode3.Name = "节点1";
            treeNode3.Text = "快速笔记页";
            treeNode4.Name = "节点0";
            treeNode4.Text = "快速笔记";
            this.list_treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.list_treeView.Size = new System.Drawing.Size(172, 362);
            this.list_treeView.TabIndex = 0;
            this.list_treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.list_treeView_NodeMouseClick);
            // 
            // search_tabPage
            // 
            this.search_tabPage.Location = new System.Drawing.Point(4, 24);
            this.search_tabPage.Name = "search_tabPage";
            this.search_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.search_tabPage.Size = new System.Drawing.Size(172, 380);
            this.search_tabPage.TabIndex = 1;
            this.search_tabPage.Text = "搜索";
            this.search_tabPage.UseVisualStyleBackColor = true;
            // 
            // history_tabPage
            // 
            this.history_tabPage.Location = new System.Drawing.Point(4, 24);
            this.history_tabPage.Name = "history_tabPage";
            this.history_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.history_tabPage.Size = new System.Drawing.Size(172, 380);
            this.history_tabPage.TabIndex = 2;
            this.history_tabPage.Text = "历史";
            this.history_tabPage.UseVisualStyleBackColor = true;
            // 
            // note_tabControl
            // 
            this.note_tabControl.Location = new System.Drawing.Point(180, 65);
            this.note_tabControl.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.note_tabControl.MinimumSize = new System.Drawing.Size(400, 400);
            this.note_tabControl.Name = "note_tabControl";
            this.note_tabControl.SelectedIndex = 0;
            this.note_tabControl.Size = new System.Drawing.Size(682, 400);
            this.note_tabControl.TabIndex = 3;
            // 
            // bold_toolStripButton
            // 
            this.bold_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bold_toolStripButton.Image = global::ONENOTE2.Properties.Resources.加粗图标;
            this.bold_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bold_toolStripButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.bold_toolStripButton.Name = "bold_toolStripButton";
            this.bold_toolStripButton.Size = new System.Drawing.Size(29, 29);
            this.bold_toolStripButton.Text = "加粗";
            this.bold_toolStripButton.Click += new System.EventHandler(this.bold_toolStripButton_Click);
            // 
            // inclines_toolStripButton
            // 
            this.inclines_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inclines_toolStripButton.Image = global::ONENOTE2.Properties.Resources.斜体图标;
            this.inclines_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inclines_toolStripButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.inclines_toolStripButton.Name = "inclines_toolStripButton";
            this.inclines_toolStripButton.Size = new System.Drawing.Size(29, 29);
            this.inclines_toolStripButton.Text = "斜体";
            this.inclines_toolStripButton.Click += new System.EventHandler(this.inclines_toolStripButton_Click);
            // 
            // underline_toolStripButton
            // 
            this.underline_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underline_toolStripButton.Image = global::ONENOTE2.Properties.Resources.下划线图标;
            this.underline_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underline_toolStripButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.underline_toolStripButton.Name = "underline_toolStripButton";
            this.underline_toolStripButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.underline_toolStripButton.Size = new System.Drawing.Size(29, 29);
            this.underline_toolStripButton.Text = "下划线";
            this.underline_toolStripButton.Click += new System.EventHandler(this.underline_toolStripButton_Click);
            // 
            // fontcolor_toolStripButton
            // 
            this.fontcolor_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fontcolor_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("fontcolor_toolStripButton.Image")));
            this.fontcolor_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontcolor_toolStripButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.fontcolor_toolStripButton.Name = "fontcolor_toolStripButton";
            this.fontcolor_toolStripButton.Size = new System.Drawing.Size(23, 29);
            this.fontcolor_toolStripButton.Text = "A";
            this.fontcolor_toolStripButton.ToolTipText = "字体颜色";
            this.fontcolor_toolStripButton.Click += new System.EventHandler(this.fontcolor_toolStripButton_Click);
            // 
            // pictureinsert_toolStripButton
            // 
            this.pictureinsert_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pictureinsert_toolStripButton.Image = global::ONENOTE2.Properties.Resources.插入图片图标;
            this.pictureinsert_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pictureinsert_toolStripButton.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.pictureinsert_toolStripButton.Name = "pictureinsert_toolStripButton";
            this.pictureinsert_toolStripButton.Size = new System.Drawing.Size(54, 27);
            this.pictureinsert_toolStripButton.Text = "toolStripButton1";
            this.pictureinsert_toolStripButton.Click += new System.EventHandler(this.pictrueinsert_toolStripButton_Click);
            // 
            // fileinsret_toolStripButton
            // 
            this.fileinsret_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fileinsret_toolStripButton.Image = global::ONENOTE2.Properties.Resources.插入文件图标;
            this.fileinsret_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileinsret_toolStripButton.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.fileinsret_toolStripButton.Name = "fileinsret_toolStripButton";
            this.fileinsret_toolStripButton.Size = new System.Drawing.Size(54, 27);
            this.fileinsret_toolStripButton.Text = "toolStripButton2";
            this.fileinsret_toolStripButton.Click += new System.EventHandler(this.fileinsert_toolStripButton_Click);
            // 
            // musicinsert_toolStripButton
            // 
            this.musicinsert_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.musicinsert_toolStripButton.Image = global::ONENOTE2.Properties.Resources.插入音频图标;
            this.musicinsert_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.musicinsert_toolStripButton.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.musicinsert_toolStripButton.Name = "musicinsert_toolStripButton";
            this.musicinsert_toolStripButton.Size = new System.Drawing.Size(54, 27);
            this.musicinsert_toolStripButton.Text = "toolStripButton3";
            this.musicinsert_toolStripButton.Click += new System.EventHandler(this.musicinsert_toolStripButton_Click);
            // 
            // urlinsert_toolStripButton
            // 
            this.urlinsert_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.urlinsert_toolStripButton.Image = global::ONENOTE2.Properties.Resources.插入链接图标;
            this.urlinsert_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.urlinsert_toolStripButton.Name = "urlinsert_toolStripButton";
            this.urlinsert_toolStripButton.Size = new System.Drawing.Size(54, 24);
            this.urlinsert_toolStripButton.Text = "toolStripButton4";
            this.urlinsert_toolStripButton.Click += new System.EventHandler(this.urlinsert_toolStripButton_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.note_tabControl);
            this.Controls.Add(this.left_tabControl);
            this.Controls.Add(this.menu_tabControl);
            this.Controls.Add(this.top_menuStrip);
            this.MainMenuStrip = this.top_menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.top_menuStrip.ResumeLayout(false);
            this.top_menuStrip.PerformLayout();
            this.menu_tabControl.ResumeLayout(false);
            this.start_tabpage.ResumeLayout(false);
            this.start_tabpage.PerformLayout();
            this.insert_toolStrip.ResumeLayout(false);
            this.insert_toolStrip.PerformLayout();
            this.insert_tabPage.ResumeLayout(false);
            this.insert_tabPage.PerformLayout();
            this.start_toolStrip.ResumeLayout(false);
            this.start_toolStrip.PerformLayout();
            this.left_tabControl.ResumeLayout(false);
            this.contents_tabPage.ResumeLayout(false);
            this.contents_tabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip top_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem file_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem save_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastOperation_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextOperation_ToolStripMenuItem;
        private System.Windows.Forms.TabControl menu_tabControl;
        private System.Windows.Forms.TabPage start_tabpage;
        private System.Windows.Forms.TabPage insert_tabPage;
        private System.Windows.Forms.TabControl left_tabControl;
        private System.Windows.Forms.TabPage contents_tabPage;
        private System.Windows.Forms.TabPage search_tabPage;
        private System.Windows.Forms.TabPage history_tabPage;
        private System.Windows.Forms.TabControl note_tabControl;
        private System.Windows.Forms.ToolStrip start_toolStrip;
        private System.Windows.Forms.ToolStripButton pictureinsert_toolStripButton;
        private System.Windows.Forms.ToolStripButton fileinsret_toolStripButton;
        private System.Windows.Forms.ToolStripButton musicinsert_toolStripButton;
        private System.Windows.Forms.ToolStripButton urlinsert_toolStripButton;
        private System.Windows.Forms.ToolStrip insert_toolStrip;
        private System.Windows.Forms.ToolStripComboBox font_toolStripComboBox;
        private System.Windows.Forms.ToolStripComboBox fontsize_toolStripComboBox;
        private System.Windows.Forms.ToolStripButton bold_toolStripButton;
        private System.Windows.Forms.ToolStripButton inclines_toolStripButton;
        private System.Windows.Forms.ToolStripButton underline_toolStripButton;
        private System.Windows.Forms.ToolStripButton fontcolor_toolStripButton;
        private System.Windows.Forms.Label addknowbank_label;
        private System.Windows.Forms.Label addnotepage_label;
        public System.Windows.Forms.TreeView list_treeView;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

