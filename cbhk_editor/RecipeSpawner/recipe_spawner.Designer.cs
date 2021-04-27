
namespace cbhk_editor.RecipeSpawner
{
    partial class recipe_spawner
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
            this.recipe_title_menu = new System.Windows.Forms.MenuStrip();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_recipe_title_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_recipe_title_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_recipe_title_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.生成返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_spawn = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_return = new System.Windows.Forms.ToolStripMenuItem();
            this.版本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version1_12 = new System.Windows.Forms.ToolStripMenuItem();
            this.version1_13 = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.recipe_tab = new System.Windows.Forms.TabControl();
            this.recipe_rclick_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.add_recipe = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_recipe = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_recipe = new System.Windows.Forms.ToolStripMenuItem();
            this.rename = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.recipe_title_menu.SuspendLayout();
            this.recipe_tab.SuspendLayout();
            this.recipe_rclick_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // recipe_title_menu
            // 
            this.recipe_title_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑EToolStripMenuItem,
            this.生成返回ToolStripMenuItem,
            this.版本ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.recipe_title_menu.Location = new System.Drawing.Point(0, 0);
            this.recipe_title_menu.Name = "recipe_title_menu";
            this.recipe_title_menu.Size = new System.Drawing.Size(459, 25);
            this.recipe_title_menu.TabIndex = 0;
            this.recipe_title_menu.Text = "menuStrip1";
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_recipe_title_menu,
            this.delete_recipe_title_menu,
            this.clear_recipe_title_menu});
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.编辑EToolStripMenuItem.Text = "编辑&E";
            // 
            // add_recipe_title_menu
            // 
            this.add_recipe_title_menu.Name = "add_recipe_title_menu";
            this.add_recipe_title_menu.Size = new System.Drawing.Size(180, 22);
            this.add_recipe_title_menu.Text = "新建配方";
            this.add_recipe_title_menu.Click += new System.EventHandler(this.add_recipe_title_menu_Click);
            // 
            // delete_recipe_title_menu
            // 
            this.delete_recipe_title_menu.Name = "delete_recipe_title_menu";
            this.delete_recipe_title_menu.Size = new System.Drawing.Size(180, 22);
            this.delete_recipe_title_menu.Text = "删除配方";
            this.delete_recipe_title_menu.Click += new System.EventHandler(this.delete_recipe_title_menu_Click);
            // 
            // clear_recipe_title_menu
            // 
            this.clear_recipe_title_menu.Name = "clear_recipe_title_menu";
            this.clear_recipe_title_menu.Size = new System.Drawing.Size(180, 22);
            this.clear_recipe_title_menu.Text = "清空配方";
            this.clear_recipe_title_menu.Click += new System.EventHandler(this.clear_recipe_title_menu_Click);
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
            this.version1_12.Click += new System.EventHandler(this.version1_12_Click);
            // 
            // version1_13
            // 
            this.version1_13.Checked = true;
            this.version1_13.CheckOnClick = true;
            this.version1_13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.version1_13.Name = "version1_13";
            this.version1_13.Size = new System.Drawing.Size(180, 22);
            this.version1_13.Text = "1.13及以上";
            this.version1_13.Click += new System.EventHandler(this.version1_13_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.帮助ToolStripMenuItem.Text = "帮助&H";
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(180, 22);
            this.about.Text = "关于配方生成器";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // recipe_tab
            // 
            this.recipe_tab.ContextMenuStrip = this.recipe_rclick_menu;
            this.recipe_tab.Controls.Add(this.tabPage1);
            this.recipe_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipe_tab.Location = new System.Drawing.Point(0, 25);
            this.recipe_tab.Name = "recipe_tab";
            this.recipe_tab.SelectedIndex = 0;
            this.recipe_tab.Size = new System.Drawing.Size(459, 257);
            this.recipe_tab.TabIndex = 1;
            // 
            // recipe_rclick_menu
            // 
            this.recipe_rclick_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_recipe,
            this.delete_recipe,
            this.clear_recipe,
            this.rename});
            this.recipe_rclick_menu.Name = "recipe_rclick_menu";
            this.recipe_rclick_menu.Size = new System.Drawing.Size(125, 92);
            // 
            // add_recipe
            // 
            this.add_recipe.Name = "add_recipe";
            this.add_recipe.Size = new System.Drawing.Size(124, 22);
            this.add_recipe.Text = "新建配方";
            this.add_recipe.Click += new System.EventHandler(this.add_recipe_Click);
            // 
            // delete_recipe
            // 
            this.delete_recipe.Name = "delete_recipe";
            this.delete_recipe.Size = new System.Drawing.Size(124, 22);
            this.delete_recipe.Text = "删除配方";
            this.delete_recipe.Click += new System.EventHandler(this.delete_recipe_Click);
            // 
            // clear_recipe
            // 
            this.clear_recipe.Name = "clear_recipe";
            this.clear_recipe.Size = new System.Drawing.Size(124, 22);
            this.clear_recipe.Text = "清空配方";
            this.clear_recipe.Click += new System.EventHandler(this.clear_recipe_Click);
            // 
            // rename
            // 
            this.rename.Name = "rename";
            this.rename.Size = new System.Drawing.Size(124, 22);
            this.rename.Text = "重命名";
            this.rename.Click += new System.EventHandler(this.rename_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(451, 231);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "recipe.json";
            // 
            // recipe_spawner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 282);
            this.Controls.Add(this.recipe_tab);
            this.Controls.Add(this.recipe_title_menu);
            this.MainMenuStrip = this.recipe_title_menu;
            this.MaximizeBox = false;
            this.Name = "recipe_spawner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配方生成器";
            this.recipe_title_menu.ResumeLayout(false);
            this.recipe_title_menu.PerformLayout();
            this.recipe_tab.ResumeLayout(false);
            this.recipe_rclick_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip recipe_title_menu;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_recipe_title_menu;
        private System.Windows.Forms.ToolStripMenuItem delete_recipe_title_menu;
        private System.Windows.Forms.ToolStripMenuItem clear_recipe_title_menu;
        private System.Windows.Forms.ToolStripMenuItem 生成返回ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem click_to_spawn;
        private System.Windows.Forms.ToolStripMenuItem click_to_return;
        private System.Windows.Forms.ToolStripMenuItem 版本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem version1_12;
        private System.Windows.Forms.ToolStripMenuItem version1_13;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.TabControl recipe_tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ContextMenuStrip recipe_rclick_menu;
        private System.Windows.Forms.ToolStripMenuItem add_recipe;
        private System.Windows.Forms.ToolStripMenuItem delete_recipe;
        private System.Windows.Forms.ToolStripMenuItem clear_recipe;
        private System.Windows.Forms.ToolStripMenuItem rename;
    }
}