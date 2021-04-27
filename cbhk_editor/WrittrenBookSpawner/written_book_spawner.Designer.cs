
namespace cbhk_editor.WrittrenBookSpawner
{
    partial class written_book_spawner
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
            this.writtenbook_title_menu = new System.Windows.Forms.MenuStrip();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_page_title_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.add_sentence_title_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_page_title_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_sentence_title_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_page_title_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_sentence_title_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.生成返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_spawn = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_return = new System.Windows.Forms.ToolStripMenuItem();
            this.标题ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.title_box = new System.Windows.Forms.ToolStripTextBox();
            this.作者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auchor_box = new System.Windows.Forms.ToolStripTextBox();
            this.版本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version1_12 = new System.Windows.Forms.ToolStripMenuItem();
            this.version1_13 = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.page_tab = new System.Windows.Forms.TabControl();
            this.writtenbook_rclick_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.add_page_rclick_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.add_sentence_rclick_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_page_rclick_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_sentence_rclick_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_page_rclick_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_sentence_rclick_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.writtenbook_title_menu.SuspendLayout();
            this.page_tab.SuspendLayout();
            this.writtenbook_rclick_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // writtenbook_title_menu
            // 
            this.writtenbook_title_menu.BackColor = System.Drawing.Color.Transparent;
            this.writtenbook_title_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑ToolStripMenuItem,
            this.生成返回ToolStripMenuItem,
            this.标题ToolStripMenuItem,
            this.作者ToolStripMenuItem,
            this.版本ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.writtenbook_title_menu.Location = new System.Drawing.Point(0, 0);
            this.writtenbook_title_menu.Name = "writtenbook_title_menu";
            this.writtenbook_title_menu.Size = new System.Drawing.Size(420, 25);
            this.writtenbook_title_menu.TabIndex = 0;
            this.writtenbook_title_menu.Text = "menuStrip1";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_page_title_menu,
            this.add_sentence_title_menu,
            this.delete_page_title_menu,
            this.delete_sentence_title_menu,
            this.clear_page_title_menu,
            this.clear_sentence_title_menu});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.编辑ToolStripMenuItem.Text = "编辑&E";
            // 
            // add_page_title_menu
            // 
            this.add_page_title_menu.Name = "add_page_title_menu";
            this.add_page_title_menu.Size = new System.Drawing.Size(124, 22);
            this.add_page_title_menu.Text = "新建页";
            this.add_page_title_menu.Click += new System.EventHandler(this.Add_page_title_menu_Click);
            // 
            // add_sentence_title_menu
            // 
            this.add_sentence_title_menu.Name = "add_sentence_title_menu";
            this.add_sentence_title_menu.Size = new System.Drawing.Size(124, 22);
            this.add_sentence_title_menu.Text = "新建句子";
            this.add_sentence_title_menu.Click += new System.EventHandler(this.Add_sentence_title_menu_Click);
            // 
            // delete_page_title_menu
            // 
            this.delete_page_title_menu.Name = "delete_page_title_menu";
            this.delete_page_title_menu.Size = new System.Drawing.Size(124, 22);
            this.delete_page_title_menu.Text = "删除页";
            this.delete_page_title_menu.Click += new System.EventHandler(this.Delete_page_title_menu_Click);
            // 
            // delete_sentence_title_menu
            // 
            this.delete_sentence_title_menu.Name = "delete_sentence_title_menu";
            this.delete_sentence_title_menu.Size = new System.Drawing.Size(124, 22);
            this.delete_sentence_title_menu.Text = "删除句子";
            this.delete_sentence_title_menu.Click += new System.EventHandler(this.Delete_sentence_title_menu_Click);
            // 
            // clear_page_title_menu
            // 
            this.clear_page_title_menu.Name = "clear_page_title_menu";
            this.clear_page_title_menu.Size = new System.Drawing.Size(124, 22);
            this.clear_page_title_menu.Text = "清空页";
            this.clear_page_title_menu.Click += new System.EventHandler(this.Clear_page_title_menu_Click);
            // 
            // clear_sentence_title_menu
            // 
            this.clear_sentence_title_menu.Name = "clear_sentence_title_menu";
            this.clear_sentence_title_menu.Size = new System.Drawing.Size(124, 22);
            this.clear_sentence_title_menu.Text = "清空句子";
            this.clear_sentence_title_menu.Click += new System.EventHandler(this.Clear_sentence_title_menu_Click);
            // 
            // 生成返回ToolStripMenuItem
            // 
            this.生成返回ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.click_to_spawn,
            this.click_to_return});
            this.生成返回ToolStripMenuItem.Name = "生成返回ToolStripMenuItem";
            this.生成返回ToolStripMenuItem.Size = new System.Drawing.Size(81, 21);
            this.生成返回ToolStripMenuItem.Text = "生成-返回&R";
            // 
            // click_to_spawn
            // 
            this.click_to_spawn.Name = "click_to_spawn";
            this.click_to_spawn.Size = new System.Drawing.Size(100, 22);
            this.click_to_spawn.Text = "生成";
            this.click_to_spawn.Click += new System.EventHandler(this.Click_to_spawn_Click);
            // 
            // click_to_return
            // 
            this.click_to_return.Name = "click_to_return";
            this.click_to_return.Size = new System.Drawing.Size(100, 22);
            this.click_to_return.Text = "返回";
            // 
            // 标题ToolStripMenuItem
            // 
            this.标题ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.title_box});
            this.标题ToolStripMenuItem.Name = "标题ToolStripMenuItem";
            this.标题ToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.标题ToolStripMenuItem.Text = "标题&T";
            // 
            // title_box
            // 
            this.title_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title_box.Name = "title_box";
            this.title_box.Size = new System.Drawing.Size(100, 16);
            // 
            // 作者ToolStripMenuItem
            // 
            this.作者ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auchor_box});
            this.作者ToolStripMenuItem.Name = "作者ToolStripMenuItem";
            this.作者ToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.作者ToolStripMenuItem.Text = "作者&A";
            // 
            // auchor_box
            // 
            this.auchor_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.auchor_box.Name = "auchor_box";
            this.auchor_box.Size = new System.Drawing.Size(100, 16);
            // 
            // 版本ToolStripMenuItem
            // 
            this.版本ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.version1_12,
            this.version1_13});
            this.版本ToolStripMenuItem.Name = "版本ToolStripMenuItem";
            this.版本ToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.版本ToolStripMenuItem.Text = "版本&V";
            // 
            // version1_12
            // 
            this.version1_12.CheckOnClick = true;
            this.version1_12.Name = "version1_12";
            this.version1_12.Size = new System.Drawing.Size(180, 22);
            this.version1_12.Text = "1.12及以下";
            this.version1_12.Click += new System.EventHandler(this.Version1_12_Click);
            // 
            // version1_13
            // 
            this.version1_13.Checked = true;
            this.version1_13.CheckOnClick = true;
            this.version1_13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.version1_13.Name = "version1_13";
            this.version1_13.Size = new System.Drawing.Size(180, 22);
            this.version1_13.Text = "1.13及以上";
            this.version1_13.Click += new System.EventHandler(this.Version1_13_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.帮助ToolStripMenuItem.Text = "帮助&H";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(148, 22);
            this.About.Text = "关于本生成器";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // page_tab
            // 
            this.page_tab.ContextMenuStrip = this.writtenbook_rclick_menu;
            this.page_tab.Controls.Add(this.tabPage1);
            this.page_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_tab.Location = new System.Drawing.Point(0, 25);
            this.page_tab.Name = "page_tab";
            this.page_tab.SelectedIndex = 0;
            this.page_tab.Size = new System.Drawing.Size(420, 348);
            this.page_tab.TabIndex = 3;
            // 
            // writtenbook_rclick_menu
            // 
            this.writtenbook_rclick_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_page_rclick_menu,
            this.add_sentence_rclick_menu,
            this.delete_page_rclick_menu,
            this.delete_sentence_rclick_menu,
            this.clear_page_rclick_menu,
            this.clear_sentence_rclick_menu});
            this.writtenbook_rclick_menu.Name = "writtenbook_rclick_menu";
            this.writtenbook_rclick_menu.Size = new System.Drawing.Size(125, 136);
            // 
            // add_page_rclick_menu
            // 
            this.add_page_rclick_menu.Name = "add_page_rclick_menu";
            this.add_page_rclick_menu.Size = new System.Drawing.Size(124, 22);
            this.add_page_rclick_menu.Text = "新建页";
            this.add_page_rclick_menu.Click += new System.EventHandler(this.Add_page_rclick_menu_Click);
            // 
            // add_sentence_rclick_menu
            // 
            this.add_sentence_rclick_menu.Name = "add_sentence_rclick_menu";
            this.add_sentence_rclick_menu.Size = new System.Drawing.Size(124, 22);
            this.add_sentence_rclick_menu.Text = "新建句子";
            this.add_sentence_rclick_menu.Click += new System.EventHandler(this.Add_sentence_rclick_menu_Click);
            // 
            // delete_page_rclick_menu
            // 
            this.delete_page_rclick_menu.Name = "delete_page_rclick_menu";
            this.delete_page_rclick_menu.Size = new System.Drawing.Size(124, 22);
            this.delete_page_rclick_menu.Text = "删除页";
            this.delete_page_rclick_menu.Click += new System.EventHandler(this.Delete_page_rclick_menu_Click);
            // 
            // delete_sentence_rclick_menu
            // 
            this.delete_sentence_rclick_menu.Name = "delete_sentence_rclick_menu";
            this.delete_sentence_rclick_menu.Size = new System.Drawing.Size(124, 22);
            this.delete_sentence_rclick_menu.Text = "删除句子";
            this.delete_sentence_rclick_menu.Click += new System.EventHandler(this.Delete_sentence_rclick_menu_Click);
            // 
            // clear_page_rclick_menu
            // 
            this.clear_page_rclick_menu.Name = "clear_page_rclick_menu";
            this.clear_page_rclick_menu.Size = new System.Drawing.Size(124, 22);
            this.clear_page_rclick_menu.Text = "清空页";
            this.clear_page_rclick_menu.Click += new System.EventHandler(this.Clear_page_rclick_menu_Click);
            // 
            // clear_sentence_rclick_menu
            // 
            this.clear_sentence_rclick_menu.Name = "clear_sentence_rclick_menu";
            this.clear_sentence_rclick_menu.Size = new System.Drawing.Size(124, 22);
            this.clear_sentence_rclick_menu.Text = "清空句子";
            this.clear_sentence_rclick_menu.Click += new System.EventHandler(this.Clear_sentence_rclick_menu_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(412, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "第1页";
            // 
            // written_book_spawner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(420, 373);
            this.Controls.Add(this.page_tab);
            this.Controls.Add(this.writtenbook_title_menu);
            this.MainMenuStrip = this.writtenbook_title_menu;
            this.Name = "written_book_spawner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成书生成器";
            this.writtenbook_title_menu.ResumeLayout(false);
            this.writtenbook_title_menu.PerformLayout();
            this.page_tab.ResumeLayout(false);
            this.writtenbook_rclick_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip writtenbook_title_menu;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成返回ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_page_title_menu;
        private System.Windows.Forms.ToolStripMenuItem add_sentence_title_menu;
        private System.Windows.Forms.ToolStripMenuItem delete_page_title_menu;
        private System.Windows.Forms.ToolStripMenuItem delete_sentence_title_menu;
        private System.Windows.Forms.ToolStripMenuItem clear_page_title_menu;
        private System.Windows.Forms.ToolStripMenuItem clear_sentence_title_menu;
        private System.Windows.Forms.ToolStripMenuItem click_to_spawn;
        private System.Windows.Forms.ToolStripMenuItem click_to_return;
        private System.Windows.Forms.ToolStripMenuItem 版本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem version1_12;
        private System.Windows.Forms.ToolStripMenuItem version1_13;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem 标题ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox title_box;
        private System.Windows.Forms.ToolStripMenuItem 作者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox auchor_box;
        public System.Windows.Forms.TabControl page_tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ContextMenuStrip writtenbook_rclick_menu;
        private System.Windows.Forms.ToolStripMenuItem add_page_rclick_menu;
        private System.Windows.Forms.ToolStripMenuItem add_sentence_rclick_menu;
        private System.Windows.Forms.ToolStripMenuItem delete_page_rclick_menu;
        private System.Windows.Forms.ToolStripMenuItem delete_sentence_rclick_menu;
        private System.Windows.Forms.ToolStripMenuItem clear_page_rclick_menu;
        private System.Windows.Forms.ToolStripMenuItem clear_sentence_rclick_menu;
    }
}