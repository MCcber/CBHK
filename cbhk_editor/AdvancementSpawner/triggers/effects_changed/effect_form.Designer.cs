
namespace cbhk_editor.AdvancementSpawner.triggers.effects_changed
{
    partial class effect_form
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
            this.effect_title_menu = new System.Windows.Forms.MenuStrip();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.effect_tab = new System.Windows.Forms.TabControl();
            this.effect_title_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // effect_title_menu
            // 
            this.effect_title_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑EToolStripMenuItem});
            this.effect_title_menu.Location = new System.Drawing.Point(0, 0);
            this.effect_title_menu.Name = "effect_title_menu";
            this.effect_title_menu.Size = new System.Drawing.Size(210, 25);
            this.effect_title_menu.TabIndex = 0;
            this.effect_title_menu.Text = "menuStrip1";
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
            // effect_tab
            // 
            this.effect_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.effect_tab.ItemSize = new System.Drawing.Size(15, 15);
            this.effect_tab.Location = new System.Drawing.Point(0, 25);
            this.effect_tab.Name = "effect_tab";
            this.effect_tab.SelectedIndex = 0;
            this.effect_tab.Size = new System.Drawing.Size(210, 127);
            this.effect_tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.effect_tab.TabIndex = 1;
            // 
            // effect_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 152);
            this.Controls.Add(this.effect_tab);
            this.Controls.Add(this.effect_title_menu);
            this.MainMenuStrip = this.effect_title_menu;
            this.Name = "effect_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置药水效果";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.effect_form_FormClosing);
            this.effect_title_menu.ResumeLayout(false);
            this.effect_title_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip effect_title_menu;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.ToolStripMenuItem clear;
        public System.Windows.Forms.TabControl effect_tab;
    }
}