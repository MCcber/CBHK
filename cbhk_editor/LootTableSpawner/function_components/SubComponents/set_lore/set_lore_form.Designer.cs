
namespace cbhk_editor.LootTableSpawner.function_components.SubComponents.set_lore
{
    partial class set_lore_form
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
            this.set_lore_title_menu = new System.Windows.Forms.MenuStrip();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.lore_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.set_lore_title_menu.SuspendLayout();
            this.lore_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // set_lore_title_menu
            // 
            this.set_lore_title_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑EToolStripMenuItem});
            this.set_lore_title_menu.Location = new System.Drawing.Point(0, 0);
            this.set_lore_title_menu.Name = "set_lore_title_menu";
            this.set_lore_title_menu.Size = new System.Drawing.Size(543, 25);
            this.set_lore_title_menu.TabIndex = 0;
            this.set_lore_title_menu.Text = "menuStrip1";
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add,
            this.delete,
            this.clear});
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.编辑EToolStripMenuItem.Text = "编辑&E";
            // 
            // add
            // 
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(180, 22);
            this.add.Text = "添加";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(180, 22);
            this.delete.Text = "删除";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // clear
            // 
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(180, 22);
            this.clear.Text = "清空";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // lore_tab
            // 
            this.lore_tab.Controls.Add(this.tabPage1);
            this.lore_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lore_tab.ItemSize = new System.Drawing.Size(15, 15);
            this.lore_tab.Location = new System.Drawing.Point(0, 25);
            this.lore_tab.Name = "lore_tab";
            this.lore_tab.SelectedIndex = 0;
            this.lore_tab.Size = new System.Drawing.Size(543, 286);
            this.lore_tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.lore_tab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 19);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(535, 263);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1";
            // 
            // set_lore_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(543, 311);
            this.Controls.Add(this.lore_tab);
            this.Controls.Add(this.set_lore_title_menu);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.set_lore_title_menu;
            this.Name = "set_lore_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置描述";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.set_lore_form_FormClosing);
            this.set_lore_title_menu.ResumeLayout(false);
            this.set_lore_title_menu.PerformLayout();
            this.lore_tab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip set_lore_title_menu;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.ToolStripMenuItem clear;
        private System.Windows.Forms.TabControl lore_tab;
        private System.Windows.Forms.TabPage tabPage1;
    }
}