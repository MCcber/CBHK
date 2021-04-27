
namespace cbhk_editor.TagSpawner
{
    partial class tag_spawner
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
            this.id_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tag_title_menu = new System.Windows.Forms.MenuStrip();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_tag_title_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.remove_tag_title_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_tag_title_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.生成返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_spawn = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_return = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about_tag_spawner = new System.Windows.Forms.ToolStripMenuItem();
            this.tag_rclick_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.add_tag = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_tag = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_tag = new System.Windows.Forms.ToolStripMenuItem();
            this.id_tab.SuspendLayout();
            this.tag_title_menu.SuspendLayout();
            this.tag_rclick_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_tab
            // 
            this.id_tab.Controls.Add(this.tabPage1);
            this.id_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.id_tab.Location = new System.Drawing.Point(0, 25);
            this.id_tab.Name = "id_tab";
            this.id_tab.SelectedIndex = 0;
            this.id_tab.Size = new System.Drawing.Size(576, 410);
            this.id_tab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(568, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1号标签文件";
            // 
            // tag_title_menu
            // 
            this.tag_title_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tag_title_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑EToolStripMenuItem,
            this.生成返回ToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.tag_title_menu.Location = new System.Drawing.Point(0, 0);
            this.tag_title_menu.Name = "tag_title_menu";
            this.tag_title_menu.Size = new System.Drawing.Size(576, 25);
            this.tag_title_menu.TabIndex = 1;
            this.tag_title_menu.Text = "menuStrip1";
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_tag_title_menu,
            this.remove_tag_title_menu,
            this.clear_tag_title_menu});
            this.编辑EToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.编辑EToolStripMenuItem.Text = "编辑&E";
            // 
            // add_tag_title_menu
            // 
            this.add_tag_title_menu.Name = "add_tag_title_menu";
            this.add_tag_title_menu.Size = new System.Drawing.Size(180, 22);
            this.add_tag_title_menu.Text = "新建标签";
            this.add_tag_title_menu.Click += new System.EventHandler(this.Add_tag_title_menu_Click);
            // 
            // remove_tag_title_menu
            // 
            this.remove_tag_title_menu.Name = "remove_tag_title_menu";
            this.remove_tag_title_menu.Size = new System.Drawing.Size(180, 22);
            this.remove_tag_title_menu.Text = "删除标签";
            this.remove_tag_title_menu.Click += new System.EventHandler(this.Remove_tag_title_menu_Click);
            // 
            // clear_tag_title_menu
            // 
            this.clear_tag_title_menu.Name = "clear_tag_title_menu";
            this.clear_tag_title_menu.Size = new System.Drawing.Size(180, 22);
            this.clear_tag_title_menu.Text = "删除所有标签";
            this.clear_tag_title_menu.Click += new System.EventHandler(this.Clear_tag_title_menu_Click);
            // 
            // 生成返回ToolStripMenuItem
            // 
            this.生成返回ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.click_to_spawn,
            this.click_to_return});
            this.生成返回ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.生成返回ToolStripMenuItem.Name = "生成返回ToolStripMenuItem";
            this.生成返回ToolStripMenuItem.Size = new System.Drawing.Size(81, 21);
            this.生成返回ToolStripMenuItem.Text = "生成-返回&R";
            // 
            // click_to_spawn
            // 
            this.click_to_spawn.Name = "click_to_spawn";
            this.click_to_spawn.Size = new System.Drawing.Size(180, 22);
            this.click_to_spawn.Text = "生成";
            this.click_to_spawn.Click += new System.EventHandler(this.Click_to_spawn_Click);
            // 
            // click_to_return
            // 
            this.click_to_return.Name = "click_to_return";
            this.click_to_return.Size = new System.Drawing.Size(180, 22);
            this.click_to_return.Text = "返回";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about_tag_spawner});
            this.帮助HToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.帮助HToolStripMenuItem.Text = "帮助&H";
            // 
            // about_tag_spawner
            // 
            this.about_tag_spawner.Name = "about_tag_spawner";
            this.about_tag_spawner.Size = new System.Drawing.Size(180, 22);
            this.about_tag_spawner.Text = "关于本生成器";
            this.about_tag_spawner.Click += new System.EventHandler(this.About_tag_spawner_Click);
            // 
            // tag_rclick_menu
            // 
            this.tag_rclick_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_tag,
            this.delete_tag,
            this.clear_tag});
            this.tag_rclick_menu.Name = "tag_rclick_menu";
            this.tag_rclick_menu.Size = new System.Drawing.Size(125, 70);
            // 
            // add_tag
            // 
            this.add_tag.Name = "add_tag";
            this.add_tag.Size = new System.Drawing.Size(124, 22);
            this.add_tag.Text = "添加标签";
            this.add_tag.Click += new System.EventHandler(this.Add_tag_Click);
            // 
            // delete_tag
            // 
            this.delete_tag.Name = "delete_tag";
            this.delete_tag.Size = new System.Drawing.Size(124, 22);
            this.delete_tag.Text = "删除标签";
            this.delete_tag.Click += new System.EventHandler(this.Delete_tag_Click);
            // 
            // clear_tag
            // 
            this.clear_tag.Name = "clear_tag";
            this.clear_tag.Size = new System.Drawing.Size(124, 22);
            this.clear_tag.Text = "清空标签";
            this.clear_tag.Click += new System.EventHandler(this.Clear_tag_Click);
            // 
            // tag_spawner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(576, 435);
            this.ContextMenuStrip = this.tag_rclick_menu;
            this.Controls.Add(this.id_tab);
            this.Controls.Add(this.tag_title_menu);
            this.MainMenuStrip = this.tag_title_menu;
            this.Name = "tag_spawner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "标签生成器";
            this.id_tab.ResumeLayout(false);
            this.tag_title_menu.ResumeLayout(false);
            this.tag_title_menu.PerformLayout();
            this.tag_rclick_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl id_tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MenuStrip tag_title_menu;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_tag_title_menu;
        private System.Windows.Forms.ToolStripMenuItem remove_tag_title_menu;
        private System.Windows.Forms.ToolStripMenuItem clear_tag_title_menu;
        private System.Windows.Forms.ToolStripMenuItem 生成返回ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem click_to_spawn;
        private System.Windows.Forms.ToolStripMenuItem click_to_return;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about_tag_spawner;
        private System.Windows.Forms.ContextMenuStrip tag_rclick_menu;
        private System.Windows.Forms.ToolStripMenuItem add_tag;
        private System.Windows.Forms.ToolStripMenuItem delete_tag;
        private System.Windows.Forms.ToolStripMenuItem clear_tag;
    }
}