
namespace cbhk_editor.FireWorkSpawner
{
    partial class firework_spawner
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
            this.firework_title_menu = new System.Windows.Forms.MenuStrip();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_firework_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_firework_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_firework_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.random_style_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.生成返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_spawn = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_return = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.firework_tab = new System.Windows.Forms.TabControl();
            this.firework_rclick_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.add_firework = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_firework = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_firework = new System.Windows.Forms.ToolStripMenuItem();
            this.random_style = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.firework_title_menu.SuspendLayout();
            this.firework_tab.SuspendLayout();
            this.firework_rclick_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // firework_title_menu
            // 
            this.firework_title_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.firework_title_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑EToolStripMenuItem,
            this.生成返回ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.firework_title_menu.Location = new System.Drawing.Point(0, 0);
            this.firework_title_menu.Name = "firework_title_menu";
            this.firework_title_menu.Size = new System.Drawing.Size(429, 25);
            this.firework_title_menu.TabIndex = 0;
            this.firework_title_menu.Text = "menuStrip1";
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_firework_menu,
            this.delete_firework_menu,
            this.clear_firework_menu,
            this.random_style_menu});
            this.编辑EToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.编辑EToolStripMenuItem.Text = "编辑&E";
            // 
            // add_firework_menu
            // 
            this.add_firework_menu.Name = "add_firework_menu";
            this.add_firework_menu.Size = new System.Drawing.Size(180, 22);
            this.add_firework_menu.Text = "新建烟花火箭";
            this.add_firework_menu.Click += new System.EventHandler(this.add_firework_menu_Click);
            // 
            // delete_firework_menu
            // 
            this.delete_firework_menu.Name = "delete_firework_menu";
            this.delete_firework_menu.Size = new System.Drawing.Size(180, 22);
            this.delete_firework_menu.Text = "删除烟花火箭";
            this.delete_firework_menu.Click += new System.EventHandler(this.delete_firework_menu_Click);
            // 
            // clear_firework_menu
            // 
            this.clear_firework_menu.Name = "clear_firework_menu";
            this.clear_firework_menu.Size = new System.Drawing.Size(180, 22);
            this.clear_firework_menu.Text = "清空烟花火箭";
            this.clear_firework_menu.Click += new System.EventHandler(this.clear_firework_menu_Click);
            // 
            // random_style_menu
            // 
            this.random_style_menu.Name = "random_style_menu";
            this.random_style_menu.Size = new System.Drawing.Size(180, 22);
            this.random_style_menu.Text = "随机当前样式";
            this.random_style_menu.Click += new System.EventHandler(this.random_style_menu_Click);
            // 
            // 生成返回ToolStripMenuItem
            // 
            this.生成返回ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.click_to_spawn,
            this.click_to_return});
            this.生成返回ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.生成返回ToolStripMenuItem.Name = "生成返回ToolStripMenuItem";
            this.生成返回ToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.生成返回ToolStripMenuItem.Text = "生成-返回";
            // 
            // click_to_spawn
            // 
            this.click_to_spawn.Name = "click_to_spawn";
            this.click_to_spawn.Size = new System.Drawing.Size(180, 22);
            this.click_to_spawn.Text = "生成";
            this.click_to_spawn.Click += new System.EventHandler(this.click_to_spawn_Click);
            // 
            // click_to_return
            // 
            this.click_to_return.Name = "click_to_return";
            this.click_to_return.Size = new System.Drawing.Size(180, 22);
            this.click_to_return.Text = "返回";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about});
            this.关于ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(184, 22);
            this.about.Text = "关于烟花火箭生成器";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // firework_tab
            // 
            this.firework_tab.ContextMenuStrip = this.firework_rclick_menu;
            this.firework_tab.Controls.Add(this.tabPage1);
            this.firework_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firework_tab.Location = new System.Drawing.Point(0, 25);
            this.firework_tab.Name = "firework_tab";
            this.firework_tab.SelectedIndex = 0;
            this.firework_tab.Size = new System.Drawing.Size(429, 337);
            this.firework_tab.TabIndex = 1;
            // 
            // firework_rclick_menu
            // 
            this.firework_rclick_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_firework,
            this.delete_firework,
            this.clear_firework,
            this.random_style});
            this.firework_rclick_menu.Name = "firework_rclick_menu";
            this.firework_rclick_menu.Size = new System.Drawing.Size(149, 92);
            // 
            // add_firework
            // 
            this.add_firework.Name = "add_firework";
            this.add_firework.Size = new System.Drawing.Size(148, 22);
            this.add_firework.Text = "新建烟花火箭";
            this.add_firework.Click += new System.EventHandler(this.add_firework_Click);
            // 
            // delete_firework
            // 
            this.delete_firework.Name = "delete_firework";
            this.delete_firework.Size = new System.Drawing.Size(148, 22);
            this.delete_firework.Text = "删除烟花火箭";
            this.delete_firework.Click += new System.EventHandler(this.delete_firework_Click);
            // 
            // clear_firework
            // 
            this.clear_firework.Name = "clear_firework";
            this.clear_firework.Size = new System.Drawing.Size(148, 22);
            this.clear_firework.Text = "清空烟花火箭";
            this.clear_firework.Click += new System.EventHandler(this.clear_firework_Click);
            // 
            // random_style
            // 
            this.random_style.Name = "random_style";
            this.random_style.Size = new System.Drawing.Size(148, 22);
            this.random_style.Text = "随机当前样式";
            this.random_style.Click += new System.EventHandler(this.random_style_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(421, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "第1个";
            // 
            // firework_spawner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(429, 362);
            this.Controls.Add(this.firework_tab);
            this.Controls.Add(this.firework_title_menu);
            this.MainMenuStrip = this.firework_title_menu;
            this.Name = "firework_spawner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "烟花生成器";
            this.firework_title_menu.ResumeLayout(false);
            this.firework_title_menu.PerformLayout();
            this.firework_tab.ResumeLayout(false);
            this.firework_rclick_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip firework_title_menu;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_firework_menu;
        private System.Windows.Forms.ToolStripMenuItem delete_firework_menu;
        private System.Windows.Forms.ToolStripMenuItem clear_firework_menu;
        private System.Windows.Forms.ToolStripMenuItem 生成返回ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem click_to_spawn;
        private System.Windows.Forms.ToolStripMenuItem click_to_return;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.TabControl firework_tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ContextMenuStrip firework_rclick_menu;
        private System.Windows.Forms.ToolStripMenuItem add_firework;
        private System.Windows.Forms.ToolStripMenuItem delete_firework;
        private System.Windows.Forms.ToolStripMenuItem clear_firework;
        private System.Windows.Forms.ToolStripMenuItem random_style_menu;
        private System.Windows.Forms.ToolStripMenuItem random_style;
    }
}