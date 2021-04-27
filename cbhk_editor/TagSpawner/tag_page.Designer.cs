
namespace cbhk_editor.TagSpawner
{
    partial class Tag_page
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tag_page));
            this.id_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tag_file = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NeedReplace = new System.Windows.Forms.CheckBox();
            this.search_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reverse_select = new System.Windows.Forms.Button();
            this.select_all = new System.Windows.Forms.Button();
            this.id_list_box = new System.Windows.Forms.CheckedListBox();
            this.id_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_tab
            // 
            this.id_tab.Controls.Add(this.tabPage1);
            this.id_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.id_tab.Location = new System.Drawing.Point(0, 0);
            this.id_tab.Name = "id_tab";
            this.id_tab.SelectedIndex = 0;
            this.id_tab.Size = new System.Drawing.Size(568, 444);
            this.id_tab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.tag_file);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.NeedReplace);
            this.tabPage1.Controls.Add(this.search_box);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.reverse_select);
            this.tabPage1.Controls.Add(this.select_all);
            this.tabPage1.Controls.Add(this.id_list_box);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(560, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1号标签文件";
            // 
            // tag_file
            // 
            this.tag_file.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tag_file.Location = new System.Drawing.Point(382, 392);
            this.tag_file.Name = "tag_file";
            this.tag_file.Size = new System.Drawing.Size(100, 21);
            this.tag_file.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(336, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "文件名:";
            // 
            // NeedReplace
            // 
            this.NeedReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NeedReplace.AutoSize = true;
            this.NeedReplace.ForeColor = System.Drawing.Color.White;
            this.NeedReplace.Location = new System.Drawing.Point(485, 395);
            this.NeedReplace.Name = "NeedReplace";
            this.NeedReplace.Size = new System.Drawing.Size(72, 16);
            this.NeedReplace.TabIndex = 5;
            this.NeedReplace.Text = "是否覆盖";
            this.NeedReplace.UseVisualStyleBackColor = true;
            // 
            // search_box
            // 
            this.search_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.search_box.Location = new System.Drawing.Point(260, 392);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(72, 21);
            this.search_box.TabIndex = 4;
            this.search_box.TextChanged += new System.EventHandler(this.Search_box_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(225, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "搜索:";
            // 
            // reverse_select
            // 
            this.reverse_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reverse_select.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reverse_select.BackgroundImage")));
            this.reverse_select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reverse_select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reverse_select.FlatAppearance.BorderSize = 0;
            this.reverse_select.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.reverse_select.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.reverse_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reverse_select.ForeColor = System.Drawing.Color.White;
            this.reverse_select.Location = new System.Drawing.Point(112, 389);
            this.reverse_select.Name = "reverse_select";
            this.reverse_select.Size = new System.Drawing.Size(111, 27);
            this.reverse_select.TabIndex = 2;
            this.reverse_select.Text = "反选";
            this.reverse_select.UseVisualStyleBackColor = true;
            this.reverse_select.Click += new System.EventHandler(this.Reverse_select_Click);
            // 
            // select_all
            // 
            this.select_all.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.select_all.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("select_all.BackgroundImage")));
            this.select_all.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.select_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.select_all.FlatAppearance.BorderSize = 0;
            this.select_all.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.select_all.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.select_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_all.ForeColor = System.Drawing.Color.White;
            this.select_all.Location = new System.Drawing.Point(1, 389);
            this.select_all.Name = "select_all";
            this.select_all.Size = new System.Drawing.Size(111, 27);
            this.select_all.TabIndex = 1;
            this.select_all.Text = "全选";
            this.select_all.UseVisualStyleBackColor = true;
            this.select_all.Click += new System.EventHandler(this.Select_all_Click);
            // 
            // id_list_box
            // 
            this.id_list_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.id_list_box.FormattingEnabled = true;
            this.id_list_box.Location = new System.Drawing.Point(0, 0);
            this.id_list_box.Name = "id_list_box";
            this.id_list_box.Size = new System.Drawing.Size(560, 388);
            this.id_list_box.TabIndex = 0;
            // 
            // Tag_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.id_tab);
            this.Name = "Tag_page";
            this.Size = new System.Drawing.Size(568, 444);
            this.id_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tag_file;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox NeedReplace;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reverse_select;
        private System.Windows.Forms.Button select_all;
        public System.Windows.Forms.CheckedListBox id_list_box;
        public System.Windows.Forms.TabControl id_tab;
    }
}
