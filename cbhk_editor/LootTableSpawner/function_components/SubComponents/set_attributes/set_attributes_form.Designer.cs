
namespace cbhk_editor.LootTableSpawner.function_components.SubComponents.set_attributes
{
    partial class set_attributes_form
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
            this.attribute_title_menu = new System.Windows.Forms.MenuStrip();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.attribute_tab = new System.Windows.Forms.TabControl();
            this.attribute_title_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // attribute_title_menu
            // 
            this.attribute_title_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑EToolStripMenuItem});
            this.attribute_title_menu.Location = new System.Drawing.Point(0, 0);
            this.attribute_title_menu.Name = "attribute_title_menu";
            this.attribute_title_menu.Size = new System.Drawing.Size(387, 25);
            this.attribute_title_menu.TabIndex = 0;
            this.attribute_title_menu.Text = "menuStrip1";
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
            this.add.Size = new System.Drawing.Size(100, 22);
            this.add.Text = "添加";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 22);
            this.delete.Text = "删除";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // clear
            // 
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(100, 22);
            this.clear.Text = "清空";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // attribute_tab
            // 
            this.attribute_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attribute_tab.ItemSize = new System.Drawing.Size(15, 15);
            this.attribute_tab.Location = new System.Drawing.Point(0, 25);
            this.attribute_tab.Name = "attribute_tab";
            this.attribute_tab.SelectedIndex = 0;
            this.attribute_tab.Size = new System.Drawing.Size(387, 164);
            this.attribute_tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.attribute_tab.TabIndex = 1;
            // 
            // set_attributes_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(387, 189);
            this.Controls.Add(this.attribute_tab);
            this.Controls.Add(this.attribute_title_menu);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.attribute_title_menu;
            this.Name = "set_attributes_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置属性";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.set_attributes_form_FormClosing);
            this.attribute_title_menu.ResumeLayout(false);
            this.attribute_title_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip attribute_title_menu;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.ToolStripMenuItem clear;
        private System.Windows.Forms.TabControl attribute_tab;
    }
}