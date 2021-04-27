
namespace cbhk_editor.VillagerSpawner
{
    partial class villager_spawner
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
            this.villager_title_menu = new System.Windows.Forms.MenuStrip();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_villager_title_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_villager_title_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_villager_title_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.add_transaction_title_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_transaction_title_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_transaction_title_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.生成返回RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_spawn = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_return = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.villager_tab = new System.Windows.Forms.TabControl();
            this.villager_rclick_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.add_villager = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_villager = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_villager = new System.Windows.Forms.ToolStripMenuItem();
            this.add_transaction = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_transaction = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_transaction = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.villager_title_menu.SuspendLayout();
            this.villager_tab.SuspendLayout();
            this.villager_rclick_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // villager_title_menu
            // 
            this.villager_title_menu.BackColor = System.Drawing.Color.Transparent;
            this.villager_title_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑EToolStripMenuItem,
            this.生成返回RToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.villager_title_menu.Location = new System.Drawing.Point(0, 0);
            this.villager_title_menu.Name = "villager_title_menu";
            this.villager_title_menu.Size = new System.Drawing.Size(602, 25);
            this.villager_title_menu.TabIndex = 0;
            this.villager_title_menu.Text = "menuStrip1";
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_villager_title_menu,
            this.delete_villager_title_menu,
            this.clear_villager_title_menu,
            this.add_transaction_title_menu,
            this.delete_transaction_title_menu,
            this.clear_transaction_title_menu});
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.编辑EToolStripMenuItem.Text = "编辑&E";
            // 
            // add_villager_title_menu
            // 
            this.add_villager_title_menu.Name = "add_villager_title_menu";
            this.add_villager_title_menu.Size = new System.Drawing.Size(124, 22);
            this.add_villager_title_menu.Text = "新建村民";
            this.add_villager_title_menu.Click += new System.EventHandler(this.add_villager_title_menu_Click);
            // 
            // delete_villager_title_menu
            // 
            this.delete_villager_title_menu.Name = "delete_villager_title_menu";
            this.delete_villager_title_menu.Size = new System.Drawing.Size(124, 22);
            this.delete_villager_title_menu.Text = "删除村民";
            this.delete_villager_title_menu.Click += new System.EventHandler(this.delete_villager_title_menu_Click);
            // 
            // clear_villager_title_menu
            // 
            this.clear_villager_title_menu.Name = "clear_villager_title_menu";
            this.clear_villager_title_menu.Size = new System.Drawing.Size(124, 22);
            this.clear_villager_title_menu.Text = "清空村民";
            this.clear_villager_title_menu.Click += new System.EventHandler(this.clear_villager_title_menu_Click);
            // 
            // add_transaction_title_menu
            // 
            this.add_transaction_title_menu.Name = "add_transaction_title_menu";
            this.add_transaction_title_menu.Size = new System.Drawing.Size(124, 22);
            this.add_transaction_title_menu.Text = "新建交易";
            this.add_transaction_title_menu.Click += new System.EventHandler(this.add_transaction_title_menu_Click);
            // 
            // delete_transaction_title_menu
            // 
            this.delete_transaction_title_menu.Name = "delete_transaction_title_menu";
            this.delete_transaction_title_menu.Size = new System.Drawing.Size(124, 22);
            this.delete_transaction_title_menu.Text = "删除交易";
            this.delete_transaction_title_menu.Click += new System.EventHandler(this.delete_transaction_title_menu_Click);
            // 
            // clear_transaction_title_menu
            // 
            this.clear_transaction_title_menu.Name = "clear_transaction_title_menu";
            this.clear_transaction_title_menu.Size = new System.Drawing.Size(124, 22);
            this.clear_transaction_title_menu.Text = "清空交易";
            this.clear_transaction_title_menu.Click += new System.EventHandler(this.clear_transaction_title_menu_Click);
            // 
            // 生成返回RToolStripMenuItem
            // 
            this.生成返回RToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.click_to_spawn,
            this.click_to_return});
            this.生成返回RToolStripMenuItem.Name = "生成返回RToolStripMenuItem";
            this.生成返回RToolStripMenuItem.Size = new System.Drawing.Size(81, 21);
            this.生成返回RToolStripMenuItem.Text = "生成-返回&R";
            // 
            // click_to_spawn
            // 
            this.click_to_spawn.Name = "click_to_spawn";
            this.click_to_spawn.Size = new System.Drawing.Size(100, 22);
            this.click_to_spawn.Text = "生成";
            this.click_to_spawn.Click += new System.EventHandler(this.click_to_spawn_Click);
            // 
            // click_to_return
            // 
            this.click_to_return.Name = "click_to_return";
            this.click_to_return.Size = new System.Drawing.Size(100, 22);
            this.click_to_return.Text = "返回";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(160, 22);
            this.about.Text = "关于村民生成器";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // villager_tab
            // 
            this.villager_tab.ContextMenuStrip = this.villager_rclick_menu;
            this.villager_tab.Controls.Add(this.tabPage1);
            this.villager_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.villager_tab.Location = new System.Drawing.Point(0, 25);
            this.villager_tab.Name = "villager_tab";
            this.villager_tab.SelectedIndex = 0;
            this.villager_tab.Size = new System.Drawing.Size(602, 396);
            this.villager_tab.TabIndex = 1;
            // 
            // villager_rclick_menu
            // 
            this.villager_rclick_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_villager,
            this.delete_villager,
            this.clear_villager,
            this.add_transaction,
            this.delete_transaction,
            this.clear_transaction});
            this.villager_rclick_menu.Name = "villager_rclick_menu";
            this.villager_rclick_menu.Size = new System.Drawing.Size(125, 136);
            // 
            // add_villager
            // 
            this.add_villager.Name = "add_villager";
            this.add_villager.Size = new System.Drawing.Size(124, 22);
            this.add_villager.Text = "新建村民";
            this.add_villager.Click += new System.EventHandler(this.add_villager_Click);
            // 
            // delete_villager
            // 
            this.delete_villager.Name = "delete_villager";
            this.delete_villager.Size = new System.Drawing.Size(124, 22);
            this.delete_villager.Text = "删除村民";
            this.delete_villager.Click += new System.EventHandler(this.delete_villager_Click);
            // 
            // clear_villager
            // 
            this.clear_villager.Name = "clear_villager";
            this.clear_villager.Size = new System.Drawing.Size(124, 22);
            this.clear_villager.Text = "清空村民";
            this.clear_villager.Click += new System.EventHandler(this.clear_villager_Click);
            // 
            // add_transaction
            // 
            this.add_transaction.Name = "add_transaction";
            this.add_transaction.Size = new System.Drawing.Size(124, 22);
            this.add_transaction.Text = "新建交易";
            this.add_transaction.Click += new System.EventHandler(this.add_transaction_Click);
            // 
            // delete_transaction
            // 
            this.delete_transaction.Name = "delete_transaction";
            this.delete_transaction.Size = new System.Drawing.Size(124, 22);
            this.delete_transaction.Text = "删除交易";
            this.delete_transaction.Click += new System.EventHandler(this.delete_transaction_Click);
            // 
            // clear_transaction
            // 
            this.clear_transaction.Name = "clear_transaction";
            this.clear_transaction.Size = new System.Drawing.Size(124, 22);
            this.clear_transaction.Text = "清空交易";
            this.clear_transaction.Click += new System.EventHandler(this.clear_transaction_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(594, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "第1个";
            // 
            // villager_spawner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(602, 421);
            this.Controls.Add(this.villager_tab);
            this.Controls.Add(this.villager_title_menu);
            this.MainMenuStrip = this.villager_title_menu;
            this.MaximizeBox = false;
            this.Name = "villager_spawner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "村民生成器";
            this.villager_title_menu.ResumeLayout(false);
            this.villager_title_menu.PerformLayout();
            this.villager_tab.ResumeLayout(false);
            this.villager_rclick_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip villager_title_menu;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_villager_title_menu;
        private System.Windows.Forms.ToolStripMenuItem delete_villager_title_menu;
        private System.Windows.Forms.ToolStripMenuItem clear_villager_title_menu;
        private System.Windows.Forms.ToolStripMenuItem add_transaction_title_menu;
        private System.Windows.Forms.ToolStripMenuItem delete_transaction_title_menu;
        private System.Windows.Forms.ToolStripMenuItem clear_transaction_title_menu;
        private System.Windows.Forms.TabControl villager_tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ContextMenuStrip villager_rclick_menu;
        private System.Windows.Forms.ToolStripMenuItem add_villager;
        private System.Windows.Forms.ToolStripMenuItem delete_villager;
        private System.Windows.Forms.ToolStripMenuItem clear_villager;
        private System.Windows.Forms.ToolStripMenuItem add_transaction;
        private System.Windows.Forms.ToolStripMenuItem delete_transaction;
        private System.Windows.Forms.ToolStripMenuItem clear_transaction;
        private System.Windows.Forms.ToolStripMenuItem 生成返回RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem click_to_spawn;
        private System.Windows.Forms.ToolStripMenuItem click_to_return;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about;
    }
}