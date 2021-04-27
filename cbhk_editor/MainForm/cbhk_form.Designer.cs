
namespace cbhk_editor.MainForm
{
    partial class Cbhk_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cbhk_form));
            this.cbhk_notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.cbhk_nofity_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.open_cbhk = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_cbhk = new System.Windows.Forms.ToolStripMenuItem();
            this.user_head_box = new System.Windows.Forms.PictureBox();
            this.cbhk_title_menu = new System.Windows.Forms.MenuStrip();
            this.cb_class = new System.Windows.Forms.ToolStripMenuItem();
            this.新手教程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新手进阶ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.more = new System.Windows.Forms.ToolStripMenuItem();
            this.进群交流ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.反馈BugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于编辑器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setting = new System.Windows.Forms.ToolStripMenuItem();
            this.start_up_setting = new System.Windows.Forms.ToolStripMenuItem();
            this.个性化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_tab = new System.Windows.Forms.TabControl();
            this.link_page = new System.Windows.Forms.TabPage();
            this.tool_page = new System.Windows.Forms.TabPage();
            this.spawners_button_area = new System.Windows.Forms.TableLayoutPanel();
            this.links_playing = new System.Windows.Forms.Timer(this.components);
            this.link_tip = new System.Windows.Forms.ToolTip(this.components);
            this.cbhk_nofity_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_head_box)).BeginInit();
            this.cbhk_title_menu.SuspendLayout();
            this.main_tab.SuspendLayout();
            this.tool_page.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbhk_notify
            // 
            this.cbhk_notify.ContextMenuStrip = this.cbhk_nofity_menu;
            this.cbhk_notify.Text = "notifyIcon1";
            this.cbhk_notify.Visible = true;
            // 
            // cbhk_nofity_menu
            // 
            this.cbhk_nofity_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open_cbhk,
            this.exit_cbhk});
            this.cbhk_nofity_menu.Name = "cbhk_nofity_menu";
            this.cbhk_nofity_menu.Size = new System.Drawing.Size(166, 48);
            // 
            // open_cbhk
            // 
            this.open_cbhk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("open_cbhk.BackgroundImage")));
            this.open_cbhk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.open_cbhk.Font = new System.Drawing.Font("Minecraft AE", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.open_cbhk.ForeColor = System.Drawing.Color.White;
            this.open_cbhk.Name = "open_cbhk";
            this.open_cbhk.Size = new System.Drawing.Size(165, 22);
            this.open_cbhk.Text = "打开命令管家";
            this.open_cbhk.Click += new System.EventHandler(this.Open_cbhk_Click);
            // 
            // exit_cbhk
            // 
            this.exit_cbhk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_cbhk.BackgroundImage")));
            this.exit_cbhk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_cbhk.Font = new System.Drawing.Font("Minecraft AE", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exit_cbhk.ForeColor = System.Drawing.Color.White;
            this.exit_cbhk.Name = "exit_cbhk";
            this.exit_cbhk.Size = new System.Drawing.Size(165, 22);
            this.exit_cbhk.Text = "退出";
            this.exit_cbhk.Click += new System.EventHandler(this.Exit_cbhk_Click);
            // 
            // user_head_box
            // 
            this.user_head_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.user_head_box.BackColor = System.Drawing.Color.Gray;
            this.user_head_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.user_head_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_head_box.Location = new System.Drawing.Point(704, 0);
            this.user_head_box.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.user_head_box.Name = "user_head_box";
            this.user_head_box.Size = new System.Drawing.Size(80, 80);
            this.user_head_box.TabIndex = 0;
            this.user_head_box.TabStop = false;
            // 
            // cbhk_title_menu
            // 
            this.cbhk_title_menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbhk_title_menu.AutoSize = false;
            this.cbhk_title_menu.BackColor = System.Drawing.Color.Black;
            this.cbhk_title_menu.Dock = System.Windows.Forms.DockStyle.None;
            this.cbhk_title_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cb_class,
            this.more,
            this.setting});
            this.cbhk_title_menu.Location = new System.Drawing.Point(-2, 0);
            this.cbhk_title_menu.Name = "cbhk_title_menu";
            this.cbhk_title_menu.Padding = new System.Windows.Forms.Padding(22, 4, 0, 4);
            this.cbhk_title_menu.Size = new System.Drawing.Size(706, 80);
            this.cbhk_title_menu.TabIndex = 1;
            this.cbhk_title_menu.Text = "menuStrip1";
            // 
            // cb_class
            // 
            this.cb_class.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cb_class.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新手教程ToolStripMenuItem,
            this.新手进阶ToolStripMenuItem});
            this.cb_class.Font = new System.Drawing.Font("Minecraft AE", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_class.ForeColor = System.Drawing.Color.White;
            this.cb_class.Name = "cb_class";
            this.cb_class.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.cb_class.Size = new System.Drawing.Size(168, 72);
            this.cb_class.Text = "指令教程&A";
            // 
            // 新手教程ToolStripMenuItem
            // 
            this.新手教程ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.新手教程ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.新手教程ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.新手教程ToolStripMenuItem.Name = "新手教程ToolStripMenuItem";
            this.新手教程ToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.新手教程ToolStripMenuItem.Text = "新手教程";
            this.新手教程ToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // 新手进阶ToolStripMenuItem
            // 
            this.新手进阶ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.新手进阶ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.新手进阶ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.新手进阶ToolStripMenuItem.Name = "新手进阶ToolStripMenuItem";
            this.新手进阶ToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.新手进阶ToolStripMenuItem.Text = "新手进阶";
            // 
            // more
            // 
            this.more.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.more.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.进群交流ToolStripMenuItem,
            this.反馈BugToolStripMenuItem,
            this.关于编辑器ToolStripMenuItem});
            this.more.Font = new System.Drawing.Font("Minecraft AE", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.more.ForeColor = System.Drawing.Color.White;
            this.more.Name = "more";
            this.more.Size = new System.Drawing.Size(108, 72);
            this.more.Text = "更多&F";
            // 
            // 进群交流ToolStripMenuItem
            // 
            this.进群交流ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.进群交流ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.进群交流ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.进群交流ToolStripMenuItem.Name = "进群交流ToolStripMenuItem";
            this.进群交流ToolStripMenuItem.Size = new System.Drawing.Size(266, 34);
            this.进群交流ToolStripMenuItem.Text = "进群交流";
            this.进群交流ToolStripMenuItem.Click += new System.EventHandler(this.进群交流ToolStripMenuItem_Click);
            // 
            // 反馈BugToolStripMenuItem
            // 
            this.反馈BugToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.反馈BugToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.反馈BugToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.反馈BugToolStripMenuItem.Name = "反馈BugToolStripMenuItem";
            this.反馈BugToolStripMenuItem.Size = new System.Drawing.Size(266, 34);
            this.反馈BugToolStripMenuItem.Text = "反馈Bug";
            this.反馈BugToolStripMenuItem.Click += new System.EventHandler(this.反馈BugToolStripMenuItem_Click);
            // 
            // 关于编辑器ToolStripMenuItem
            // 
            this.关于编辑器ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.关于编辑器ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.关于编辑器ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.关于编辑器ToolStripMenuItem.Name = "关于编辑器ToolStripMenuItem";
            this.关于编辑器ToolStripMenuItem.Size = new System.Drawing.Size(266, 34);
            this.关于编辑器ToolStripMenuItem.Text = "关于编辑器";
            this.关于编辑器ToolStripMenuItem.Click += new System.EventHandler(this.关于编辑器ToolStripMenuItem_Click);
            // 
            // setting
            // 
            this.setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.setting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.start_up_setting,
            this.个性化ToolStripMenuItem});
            this.setting.Font = new System.Drawing.Font("Minecraft AE", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setting.ForeColor = System.Drawing.Color.White;
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(108, 72);
            this.setting.Text = "设置&S";
            // 
            // start_up_setting
            // 
            this.start_up_setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.start_up_setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.start_up_setting.ForeColor = System.Drawing.Color.White;
            this.start_up_setting.Name = "start_up_setting";
            this.start_up_setting.Size = new System.Drawing.Size(206, 34);
            this.start_up_setting.Text = "启动项";
            this.start_up_setting.Click += new System.EventHandler(this.start_up_setting_click);
            // 
            // 个性化ToolStripMenuItem
            // 
            this.个性化ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.个性化ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.个性化ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.个性化ToolStripMenuItem.Name = "个性化ToolStripMenuItem";
            this.个性化ToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.个性化ToolStripMenuItem.Text = "个性化";
            this.个性化ToolStripMenuItem.Click += new System.EventHandler(this.个性化ToolStripMenuItem_Click);
            // 
            // main_tab
            // 
            this.main_tab.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.main_tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_tab.Controls.Add(this.link_page);
            this.main_tab.Controls.Add(this.tool_page);
            this.main_tab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_tab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.main_tab.ItemSize = new System.Drawing.Size(50, 50);
            this.main_tab.Location = new System.Drawing.Point(-2, 79);
            this.main_tab.Multiline = true;
            this.main_tab.Name = "main_tab";
            this.main_tab.SelectedIndex = 0;
            this.main_tab.Size = new System.Drawing.Size(790, 547);
            this.main_tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.main_tab.TabIndex = 3;
            this.main_tab.SelectedIndexChanged += new System.EventHandler(this.Main_tab_SelectedIndexChanged);
            // 
            // link_page
            // 
            this.link_page.BackColor = System.Drawing.Color.Gray;
            this.link_page.Cursor = System.Windows.Forms.Cursors.Default;
            this.link_page.ForeColor = System.Drawing.Color.Gray;
            this.link_page.Location = new System.Drawing.Point(54, 4);
            this.link_page.Name = "link_page";
            this.link_page.Padding = new System.Windows.Forms.Padding(3);
            this.link_page.Size = new System.Drawing.Size(732, 539);
            this.link_page.TabIndex = 1;
            // 
            // tool_page
            // 
            this.tool_page.AutoScroll = true;
            this.tool_page.BackColor = System.Drawing.Color.Gray;
            this.tool_page.Controls.Add(this.spawners_button_area);
            this.tool_page.Cursor = System.Windows.Forms.Cursors.Default;
            this.tool_page.ForeColor = System.Drawing.Color.Transparent;
            this.tool_page.Location = new System.Drawing.Point(54, 4);
            this.tool_page.Name = "tool_page";
            this.tool_page.Size = new System.Drawing.Size(732, 539);
            this.tool_page.TabIndex = 2;
            // 
            // spawners_button_area
            // 
            this.spawners_button_area.AutoScroll = true;
            this.spawners_button_area.ColumnCount = 1;
            this.spawners_button_area.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.spawners_button_area.Cursor = System.Windows.Forms.Cursors.Default;
            this.spawners_button_area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spawners_button_area.Location = new System.Drawing.Point(0, 0);
            this.spawners_button_area.Name = "spawners_button_area";
            this.spawners_button_area.RowCount = 1;
            this.spawners_button_area.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.spawners_button_area.Size = new System.Drawing.Size(732, 539);
            this.spawners_button_area.TabIndex = 0;
            // 
            // links_playing
            // 
            this.links_playing.Enabled = true;
            this.links_playing.Interval = 3000;
            this.links_playing.Tick += new System.EventHandler(this.Links_playing_Tick);
            // 
            // Cbhk_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 627);
            this.Controls.Add(this.main_tab);
            this.Controls.Add(this.user_head_box);
            this.Controls.Add(this.cbhk_title_menu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Minecraft AE", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.cbhk_title_menu;
            this.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.MinimumSize = new System.Drawing.Size(800, 666);
            this.Name = "Cbhk_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "命令管家";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cbhk_form_FormClosing);
            this.Load += new System.EventHandler(this.Cbhk_form_Load);
            this.ResizeEnd += new System.EventHandler(this.Cbhk_form_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Cbhk_form_SizeChanged);
            this.cbhk_nofity_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.user_head_box)).EndInit();
            this.cbhk_title_menu.ResumeLayout(false);
            this.cbhk_title_menu.PerformLayout();
            this.main_tab.ResumeLayout(false);
            this.tool_page.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon cbhk_notify;
        private System.Windows.Forms.PictureBox user_head_box;
        private System.Windows.Forms.MenuStrip cbhk_title_menu;
        private System.Windows.Forms.ToolStripMenuItem cb_class;
        private System.Windows.Forms.ToolStripMenuItem more;
        private System.Windows.Forms.ToolStripMenuItem setting;
        private System.Windows.Forms.ToolStripMenuItem 新手教程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新手进阶ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 进群交流ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 反馈BugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于编辑器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem start_up_setting;
        private System.Windows.Forms.ToolStripMenuItem 个性化ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cbhk_nofity_menu;
        private System.Windows.Forms.TabControl main_tab;
        private System.Windows.Forms.TabPage link_page;
        private System.Windows.Forms.TabPage tool_page;
        private System.Windows.Forms.TableLayoutPanel spawners_button_area;
        private System.Windows.Forms.ToolStripMenuItem open_cbhk;
        private System.Windows.Forms.ToolStripMenuItem exit_cbhk;
        private System.Windows.Forms.Timer links_playing;
        private System.Windows.Forms.ToolTip link_tip;
    }
}