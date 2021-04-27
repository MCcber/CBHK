
namespace cbhk_editor.LootTableSpawner.function_components.SubComponents.copy_nbt
{
    partial class copy_nbt_form
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
            this.copy_nbt_title_menu = new System.Windows.Forms.MenuStrip();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.source_box = new System.Windows.Forms.ComboBox();
            this.ops_area = new System.Windows.Forms.GroupBox();
            this.ops_tab = new System.Windows.Forms.TabControl();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.copy_nbt_title_menu.SuspendLayout();
            this.table.SuspendLayout();
            this.ops_area.SuspendLayout();
            this.SuspendLayout();
            // 
            // copy_nbt_title_menu
            // 
            this.copy_nbt_title_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.copy_nbt_title_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑EToolStripMenuItem});
            this.copy_nbt_title_menu.Location = new System.Drawing.Point(0, 0);
            this.copy_nbt_title_menu.Name = "copy_nbt_title_menu";
            this.copy_nbt_title_menu.Size = new System.Drawing.Size(390, 25);
            this.copy_nbt_title_menu.TabIndex = 0;
            this.copy_nbt_title_menu.Text = "menuStrip1";
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 440F));
            this.table.Controls.Add(this.label1, 0, 0);
            this.table.Controls.Add(this.source_box, 1, 0);
            this.table.Controls.Add(this.ops_area, 0, 1);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.ForeColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 25);
            this.table.Name = "table";
            this.table.RowCount = 3;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.table.Size = new System.Drawing.Size(390, 195);
            this.table.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "复制源:";
            // 
            // source_box
            // 
            this.source_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.source_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.source_box.ForeColor = System.Drawing.Color.White;
            this.source_box.FormattingEnabled = true;
            this.source_box.Items.AddRange(new object[] {
            "this死亡实体",
            "killer击杀者实体",
            "killer_player击杀者玩家",
            "block_entity被破坏的方块实体"});
            this.source_box.Location = new System.Drawing.Point(59, 3);
            this.source_box.Name = "source_box";
            this.source_box.Size = new System.Drawing.Size(308, 20);
            this.source_box.TabIndex = 1;
            // 
            // ops_area
            // 
            this.table.SetColumnSpan(this.ops_area, 2);
            this.ops_area.Controls.Add(this.ops_tab);
            this.ops_area.ForeColor = System.Drawing.Color.White;
            this.ops_area.Location = new System.Drawing.Point(3, 29);
            this.ops_area.Name = "ops_area";
            this.table.SetRowSpan(this.ops_area, 2);
            this.ops_area.Size = new System.Drawing.Size(385, 163);
            this.ops_area.TabIndex = 2;
            this.ops_area.TabStop = false;
            this.ops_area.Text = "复制操作";
            // 
            // ops_tab
            // 
            this.ops_tab.ItemSize = new System.Drawing.Size(15, 15);
            this.ops_tab.Location = new System.Drawing.Point(3, 17);
            this.ops_tab.Name = "ops_tab";
            this.ops_tab.SelectedIndex = 0;
            this.ops_tab.Size = new System.Drawing.Size(377, 139);
            this.ops_tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.ops_tab.TabIndex = 0;
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add,
            this.delete,
            this.clear});
            this.编辑EToolStripMenuItem.ForeColor = System.Drawing.Color.White;
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
            // copy_nbt_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(390, 220);
            this.Controls.Add(this.table);
            this.Controls.Add(this.copy_nbt_title_menu);
            this.MainMenuStrip = this.copy_nbt_title_menu;
            this.Name = "copy_nbt_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置NBT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.copy_nbt_form_FormClosing);
            this.copy_nbt_title_menu.ResumeLayout(false);
            this.copy_nbt_title_menu.PerformLayout();
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ops_area.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip copy_nbt_title_menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox source_box;
        private System.Windows.Forms.GroupBox ops_area;
        private System.Windows.Forms.TabControl ops_tab;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.ToolStripMenuItem clear;
        public System.Windows.Forms.TableLayoutPanel table;
    }
}