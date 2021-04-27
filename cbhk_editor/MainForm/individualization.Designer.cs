
namespace cbhk_editor.MainForm
{
    partial class individualization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(individualization));
            this.indiviTabControl = new System.Windows.Forms.TabControl();
            this.first_page = new System.Windows.Forms.TabPage();
            this.indivi_area = new System.Windows.Forms.TableLayoutPanel();
            this.diy_info = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.load_link = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.link_speed = new System.Windows.Forms.NumericUpDown();
            this.load_font = new System.Windows.Forms.Button();
            this.reset_font = new System.Windows.Forms.Button();
            this.clear_links = new System.Windows.Forms.Button();
            this.auto_start = new System.Windows.Forms.CheckBox();
            this.second_page = new System.Windows.Forms.TabPage();
            this.startup_area = new System.Windows.Forms.TableLayoutPanel();
            this.set_music = new System.Windows.Forms.Button();
            this.clear_music = new System.Windows.Forms.Button();
            this.cbhk_visible = new System.Windows.Forms.ComboBox();
            this.close_to_notify = new System.Windows.Forms.CheckBox();
            this.check_update = new System.Windows.Forms.CheckBox();
            this.setting_tips = new System.Windows.Forms.ToolTip(this.components);
            this.indiviTabControl.SuspendLayout();
            this.first_page.SuspendLayout();
            this.indivi_area.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.link_speed)).BeginInit();
            this.second_page.SuspendLayout();
            this.startup_area.SuspendLayout();
            this.SuspendLayout();
            // 
            // indiviTabControl
            // 
            this.indiviTabControl.Controls.Add(this.first_page);
            this.indiviTabControl.Controls.Add(this.second_page);
            this.indiviTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.indiviTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.indiviTabControl.Location = new System.Drawing.Point(0, 0);
            this.indiviTabControl.Name = "indiviTabControl";
            this.indiviTabControl.SelectedIndex = 0;
            this.indiviTabControl.Size = new System.Drawing.Size(432, 98);
            this.indiviTabControl.TabIndex = 0;
            this.indiviTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.IndiviTabControl_DrawItem);
            // 
            // first_page
            // 
            this.first_page.AutoScroll = true;
            this.first_page.Controls.Add(this.indivi_area);
            this.first_page.Location = new System.Drawing.Point(4, 22);
            this.first_page.Name = "first_page";
            this.first_page.Padding = new System.Windows.Forms.Padding(3);
            this.first_page.Size = new System.Drawing.Size(424, 72);
            this.first_page.TabIndex = 0;
            this.first_page.Text = "个性化";
            this.first_page.UseVisualStyleBackColor = true;
            // 
            // indivi_area
            // 
            this.indivi_area.BackColor = System.Drawing.Color.Black;
            this.indivi_area.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.indivi_area.ColumnCount = 3;
            this.indivi_area.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.indivi_area.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.indivi_area.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.indivi_area.Controls.Add(this.diy_info, 2, 2);
            this.indivi_area.Controls.Add(this.label1, 0, 0);
            this.indivi_area.Controls.Add(this.load_link, 0, 1);
            this.indivi_area.Controls.Add(this.label2, 2, 0);
            this.indivi_area.Controls.Add(this.link_speed, 1, 0);
            this.indivi_area.Controls.Add(this.load_font, 1, 1);
            this.indivi_area.Controls.Add(this.reset_font, 2, 1);
            this.indivi_area.Controls.Add(this.clear_links, 0, 2);
            this.indivi_area.Controls.Add(this.auto_start, 1, 2);
            this.indivi_area.Location = new System.Drawing.Point(3, 3);
            this.indivi_area.Name = "indivi_area";
            this.indivi_area.RowCount = 3;
            this.indivi_area.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.indivi_area.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.indivi_area.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.indivi_area.Size = new System.Drawing.Size(418, 101);
            this.indivi_area.TabIndex = 0;
            // 
            // diy_info
            // 
            this.diy_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diy_info.Location = new System.Drawing.Point(243, 69);
            this.diy_info.Name = "diy_info";
            this.diy_info.Size = new System.Drawing.Size(184, 21);
            this.diy_info.TabIndex = 8;
            this.diy_info.Text = "自定义标题信息(文本)";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "主页轮播图播放速度:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // load_link
            // 
            this.load_link.BackColor = System.Drawing.Color.Transparent;
            this.load_link.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.load_link.Dock = System.Windows.Forms.DockStyle.Fill;
            this.load_link.ForeColor = System.Drawing.Color.White;
            this.load_link.Image = ((System.Drawing.Image)(resources.GetObject("load_link.Image")));
            this.load_link.Location = new System.Drawing.Point(4, 36);
            this.load_link.Name = "load_link";
            this.load_link.Size = new System.Drawing.Size(121, 26);
            this.load_link.TabIndex = 3;
            this.load_link.Text = "导入主页链接";
            this.load_link.UseVisualStyleBackColor = false;
            this.load_link.Click += new System.EventHandler(this.Load_link_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(243, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "(单位:秒)";
            // 
            // link_speed
            // 
            this.link_speed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.link_speed.Location = new System.Drawing.Point(132, 6);
            this.link_speed.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.link_speed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.link_speed.Name = "link_speed";
            this.link_speed.Size = new System.Drawing.Size(78, 21);
            this.link_speed.TabIndex = 1;
            this.link_speed.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // load_font
            // 
            this.load_font.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.load_font.Dock = System.Windows.Forms.DockStyle.Fill;
            this.load_font.ForeColor = System.Drawing.Color.White;
            this.load_font.Image = ((System.Drawing.Image)(resources.GetObject("load_font.Image")));
            this.load_font.Location = new System.Drawing.Point(132, 36);
            this.load_font.Name = "load_font";
            this.load_font.Size = new System.Drawing.Size(104, 26);
            this.load_font.TabIndex = 4;
            this.load_font.Text = "导入自定义字体";
            this.load_font.UseVisualStyleBackColor = true;
            this.load_font.Click += new System.EventHandler(this.Load_font_Click);
            // 
            // reset_font
            // 
            this.reset_font.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reset_font.ForeColor = System.Drawing.Color.White;
            this.reset_font.Image = ((System.Drawing.Image)(resources.GetObject("reset_font.Image")));
            this.reset_font.Location = new System.Drawing.Point(243, 36);
            this.reset_font.Name = "reset_font";
            this.reset_font.Size = new System.Drawing.Size(184, 26);
            this.reset_font.TabIndex = 5;
            this.reset_font.Text = "重置字体";
            this.reset_font.UseVisualStyleBackColor = true;
            this.reset_font.Click += new System.EventHandler(this.Reset_font_Click);
            // 
            // clear_links
            // 
            this.clear_links.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clear_links.BackgroundImage")));
            this.clear_links.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clear_links.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clear_links.ForeColor = System.Drawing.Color.White;
            this.clear_links.Location = new System.Drawing.Point(4, 69);
            this.clear_links.Name = "clear_links";
            this.clear_links.Size = new System.Drawing.Size(121, 28);
            this.clear_links.TabIndex = 6;
            this.clear_links.Text = "清空链接";
            this.clear_links.UseVisualStyleBackColor = true;
            this.clear_links.Click += new System.EventHandler(this.Clear_links_Click);
            // 
            // auto_start
            // 
            this.auto_start.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.auto_start.AutoSize = true;
            this.auto_start.ForeColor = System.Drawing.Color.White;
            this.auto_start.Location = new System.Drawing.Point(132, 75);
            this.auto_start.Name = "auto_start";
            this.auto_start.Size = new System.Drawing.Size(72, 16);
            this.auto_start.TabIndex = 7;
            this.auto_start.Text = "开机自启";
            this.auto_start.UseVisualStyleBackColor = true;
            // 
            // second_page
            // 
            this.second_page.AutoScroll = true;
            this.second_page.Controls.Add(this.startup_area);
            this.second_page.ForeColor = System.Drawing.Color.White;
            this.second_page.Location = new System.Drawing.Point(4, 22);
            this.second_page.Name = "second_page";
            this.second_page.Size = new System.Drawing.Size(424, 72);
            this.second_page.TabIndex = 1;
            this.second_page.Text = "启动项";
            this.second_page.UseVisualStyleBackColor = true;
            // 
            // startup_area
            // 
            this.startup_area.BackColor = System.Drawing.Color.Black;
            this.startup_area.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.startup_area.ColumnCount = 2;
            this.startup_area.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.startup_area.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.startup_area.Controls.Add(this.set_music, 0, 0);
            this.startup_area.Controls.Add(this.clear_music, 1, 0);
            this.startup_area.Controls.Add(this.cbhk_visible, 0, 1);
            this.startup_area.Controls.Add(this.close_to_notify, 1, 1);
            this.startup_area.Controls.Add(this.check_update, 0, 2);
            this.startup_area.Location = new System.Drawing.Point(0, 0);
            this.startup_area.Name = "startup_area";
            this.startup_area.RowCount = 3;
            this.startup_area.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.startup_area.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.startup_area.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.startup_area.Size = new System.Drawing.Size(407, 144);
            this.startup_area.TabIndex = 0;
            // 
            // set_music
            // 
            this.set_music.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_music.BackgroundImage")));
            this.set_music.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.set_music.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_music.Location = new System.Drawing.Point(4, 4);
            this.set_music.Name = "set_music";
            this.set_music.Size = new System.Drawing.Size(203, 67);
            this.set_music.TabIndex = 0;
            this.set_music.Text = "设置启动时的音乐";
            this.set_music.UseVisualStyleBackColor = true;
            this.set_music.Click += new System.EventHandler(this.Set_music_Click);
            // 
            // clear_music
            // 
            this.clear_music.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clear_music.BackgroundImage")));
            this.clear_music.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clear_music.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clear_music.Location = new System.Drawing.Point(214, 4);
            this.clear_music.Name = "clear_music";
            this.clear_music.Size = new System.Drawing.Size(202, 67);
            this.clear_music.TabIndex = 1;
            this.clear_music.Text = "清除启动时的音乐";
            this.clear_music.UseVisualStyleBackColor = true;
            this.clear_music.Click += new System.EventHandler(this.Clear_music_Click);
            // 
            // cbhk_visible
            // 
            this.cbhk_visible.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbhk_visible.FormattingEnabled = true;
            this.cbhk_visible.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cbhk_visible.Location = new System.Drawing.Point(4, 79);
            this.cbhk_visible.Name = "cbhk_visible";
            this.cbhk_visible.Size = new System.Drawing.Size(60, 20);
            this.cbhk_visible.TabIndex = 3;
            // 
            // close_to_notify
            // 
            this.close_to_notify.AutoSize = true;
            this.close_to_notify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.close_to_notify.Location = new System.Drawing.Point(214, 78);
            this.close_to_notify.Name = "close_to_notify";
            this.close_to_notify.Size = new System.Drawing.Size(202, 22);
            this.close_to_notify.TabIndex = 4;
            this.close_to_notify.Text = "关闭后缩小到托盘";
            this.close_to_notify.UseVisualStyleBackColor = true;
            // 
            // check_update
            // 
            this.check_update.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.check_update.AutoSize = true;
            this.check_update.Location = new System.Drawing.Point(4, 115);
            this.check_update.Name = "check_update";
            this.check_update.Size = new System.Drawing.Size(96, 16);
            this.check_update.TabIndex = 5;
            this.check_update.Text = "自动检测更新";
            this.check_update.UseVisualStyleBackColor = true;
            // 
            // individualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 98);
            this.Controls.Add(this.indiviTabControl);
            this.Name = "individualization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Individualization_FormClosing);
            this.indiviTabControl.ResumeLayout(false);
            this.first_page.ResumeLayout(false);
            this.indivi_area.ResumeLayout(false);
            this.indivi_area.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.link_speed)).EndInit();
            this.second_page.ResumeLayout(false);
            this.startup_area.ResumeLayout(false);
            this.startup_area.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl indiviTabControl;
        public System.Windows.Forms.TabPage first_page;
        private System.Windows.Forms.TableLayoutPanel indivi_area;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button load_link;
        private System.Windows.Forms.Button reset_font;
        public System.Windows.Forms.NumericUpDown link_speed;
        public System.Windows.Forms.Button load_font;
        private System.Windows.Forms.TabPage second_page;
        private System.Windows.Forms.TableLayoutPanel startup_area;
        private System.Windows.Forms.Button clear_music;
        public System.Windows.Forms.ComboBox cbhk_visible;
        public System.Windows.Forms.Button set_music;
        private System.Windows.Forms.ToolTip setting_tips;
        public System.Windows.Forms.CheckBox close_to_notify;
        public System.Windows.Forms.CheckBox check_update;
        private System.Windows.Forms.Button clear_links;
        public System.Windows.Forms.TextBox diy_info;
        public System.Windows.Forms.CheckBox auto_start;
    }
}