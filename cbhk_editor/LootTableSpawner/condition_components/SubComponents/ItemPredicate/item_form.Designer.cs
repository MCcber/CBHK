
namespace cbhk_editor.LootTableSpawner.condition_components.SubComponents.ItemPredicate
{
    partial class item_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(item_form));
            this.item_title_menu = new System.Windows.Forms.MenuStrip();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_enchant = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_enchant = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_enchant = new System.Windows.Forms.ToolStripMenuItem();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.set_durability = new System.Windows.Forms.Button();
            this.max_box = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.enchant_area = new System.Windows.Forms.GroupBox();
            this.enchant_tab = new System.Windows.Forms.TabControl();
            this.item_id_box = new System.Windows.Forms.ComboBox();
            this.nbt_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.potion_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tag_box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.min_box = new System.Windows.Forms.NumericUpDown();
            this.set_count = new System.Windows.Forms.Button();
            this.item_title_menu.SuspendLayout();
            this.table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_box)).BeginInit();
            this.enchant_area.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min_box)).BeginInit();
            this.SuspendLayout();
            // 
            // item_title_menu
            // 
            this.item_title_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.item_title_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑EToolStripMenuItem});
            this.item_title_menu.Location = new System.Drawing.Point(0, 0);
            this.item_title_menu.Name = "item_title_menu";
            this.item_title_menu.Size = new System.Drawing.Size(442, 25);
            this.item_title_menu.TabIndex = 0;
            this.item_title_menu.Text = "menuStrip1";
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_enchant,
            this.delete_enchant,
            this.clear_enchant});
            this.编辑EToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.编辑EToolStripMenuItem.Text = "编辑&E";
            // 
            // add_enchant
            // 
            this.add_enchant.Name = "add_enchant";
            this.add_enchant.Size = new System.Drawing.Size(124, 22);
            this.add_enchant.Text = "添加附魔";
            this.add_enchant.Click += new System.EventHandler(this.add_enchant_Click);
            // 
            // delete_enchant
            // 
            this.delete_enchant.Name = "delete_enchant";
            this.delete_enchant.Size = new System.Drawing.Size(124, 22);
            this.delete_enchant.Text = "删除附魔";
            this.delete_enchant.Click += new System.EventHandler(this.delete_enchant_Click);
            // 
            // clear_enchant
            // 
            this.clear_enchant.Name = "clear_enchant";
            this.clear_enchant.Size = new System.Drawing.Size(124, 22);
            this.clear_enchant.Text = "清空附魔";
            this.clear_enchant.Click += new System.EventHandler(this.clear_enchant_Click);
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 4;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.table.Controls.Add(this.set_durability, 2, 1);
            this.table.Controls.Add(this.max_box, 3, 0);
            this.table.Controls.Add(this.label2, 2, 0);
            this.table.Controls.Add(this.enchant_area, 0, 2);
            this.table.Controls.Add(this.item_id_box, 3, 2);
            this.table.Controls.Add(this.nbt_box, 3, 3);
            this.table.Controls.Add(this.label6, 2, 3);
            this.table.Controls.Add(this.label5, 2, 2);
            this.table.Controls.Add(this.potion_box, 3, 4);
            this.table.Controls.Add(this.label7, 2, 4);
            this.table.Controls.Add(this.tag_box, 3, 5);
            this.table.Controls.Add(this.label8, 2, 5);
            this.table.Controls.Add(this.label1, 0, 0);
            this.table.Controls.Add(this.min_box, 1, 0);
            this.table.Controls.Add(this.set_count, 0, 1);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.ForeColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 25);
            this.table.Name = "table";
            this.table.RowCount = 6;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.Size = new System.Drawing.Size(442, 152);
            this.table.TabIndex = 2;
            // 
            // set_durability
            // 
            this.set_durability.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_durability.BackgroundImage")));
            this.set_durability.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_durability, 2);
            this.set_durability.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_durability.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_durability.FlatAppearance.BorderSize = 0;
            this.set_durability.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_durability.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_durability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_durability.Location = new System.Drawing.Point(229, 29);
            this.set_durability.Name = "set_durability";
            this.set_durability.Size = new System.Drawing.Size(210, 21);
            this.set_durability.TabIndex = 18;
            this.set_durability.Text = "设置到耐久";
            this.set_durability.UseVisualStyleBackColor = true;
            // 
            // max_box
            // 
            this.max_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.max_box.ForeColor = System.Drawing.Color.White;
            this.max_box.Location = new System.Drawing.Point(289, 3);
            this.max_box.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.max_box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.max_box.Name = "max_box";
            this.max_box.Size = new System.Drawing.Size(150, 21);
            this.max_box.TabIndex = 16;
            this.max_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "最大值:";
            // 
            // enchant_area
            // 
            this.table.SetColumnSpan(this.enchant_area, 2);
            this.enchant_area.Controls.Add(this.enchant_tab);
            this.enchant_area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enchant_area.ForeColor = System.Drawing.Color.White;
            this.enchant_area.Location = new System.Drawing.Point(3, 56);
            this.enchant_area.Name = "enchant_area";
            this.table.SetRowSpan(this.enchant_area, 4);
            this.enchant_area.Size = new System.Drawing.Size(220, 93);
            this.enchant_area.TabIndex = 4;
            this.enchant_area.TabStop = false;
            this.enchant_area.Text = "附魔列表";
            // 
            // enchant_tab
            // 
            this.enchant_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enchant_tab.ItemSize = new System.Drawing.Size(15, 15);
            this.enchant_tab.Location = new System.Drawing.Point(3, 17);
            this.enchant_tab.Name = "enchant_tab";
            this.enchant_tab.SelectedIndex = 0;
            this.enchant_tab.Size = new System.Drawing.Size(214, 73);
            this.enchant_tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.enchant_tab.TabIndex = 0;
            // 
            // item_id_box
            // 
            this.item_id_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.item_id_box.ForeColor = System.Drawing.Color.White;
            this.item_id_box.FormattingEnabled = true;
            this.item_id_box.Location = new System.Drawing.Point(289, 56);
            this.item_id_box.Name = "item_id_box";
            this.item_id_box.Size = new System.Drawing.Size(150, 20);
            this.item_id_box.TabIndex = 6;
            // 
            // nbt_box
            // 
            this.nbt_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nbt_box.ForeColor = System.Drawing.Color.White;
            this.nbt_box.Location = new System.Drawing.Point(289, 82);
            this.nbt_box.Name = "nbt_box";
            this.nbt_box.Size = new System.Drawing.Size(150, 21);
            this.nbt_box.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "NBT:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "物品ID:";
            // 
            // potion_box
            // 
            this.potion_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.potion_box.ForeColor = System.Drawing.Color.White;
            this.potion_box.Location = new System.Drawing.Point(289, 107);
            this.potion_box.Name = "potion_box";
            this.potion_box.Size = new System.Drawing.Size(150, 21);
            this.potion_box.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "potion:";
            // 
            // tag_box
            // 
            this.tag_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tag_box.ForeColor = System.Drawing.Color.White;
            this.tag_box.Location = new System.Drawing.Point(289, 132);
            this.tag_box.Name = "tag_box";
            this.tag_box.Size = new System.Drawing.Size(150, 21);
            this.tag_box.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "tag:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "最小值:";
            // 
            // min_box
            // 
            this.min_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.min_box.ForeColor = System.Drawing.Color.White;
            this.min_box.Location = new System.Drawing.Point(71, 3);
            this.min_box.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.min_box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.min_box.Name = "min_box";
            this.min_box.Size = new System.Drawing.Size(152, 21);
            this.min_box.TabIndex = 14;
            this.min_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // set_count
            // 
            this.set_count.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_count.BackgroundImage")));
            this.set_count.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_count, 2);
            this.set_count.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_count.FlatAppearance.BorderSize = 0;
            this.set_count.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_count.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_count.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_count.Location = new System.Drawing.Point(3, 29);
            this.set_count.Name = "set_count";
            this.set_count.Size = new System.Drawing.Size(220, 21);
            this.set_count.TabIndex = 17;
            this.set_count.Text = "设置到数量";
            this.set_count.UseVisualStyleBackColor = true;
            // 
            // item_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 177);
            this.Controls.Add(this.table);
            this.Controls.Add(this.item_title_menu);
            this.MainMenuStrip = this.item_title_menu;
            this.MaximizeBox = false;
            this.Name = "item_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物品谓词";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.item_form_FormClosing);
            this.item_title_menu.ResumeLayout(false);
            this.item_title_menu.PerformLayout();
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_box)).EndInit();
            this.enchant_area.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.min_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip item_title_menu;
        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.TextBox potion_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox item_id_box;
        private System.Windows.Forms.GroupBox enchant_area;
        private System.Windows.Forms.TabControl enchant_tab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nbt_box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tag_box;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_enchant;
        private System.Windows.Forms.ToolStripMenuItem delete_enchant;
        private System.Windows.Forms.ToolStripMenuItem clear_enchant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown min_box;
        private System.Windows.Forms.NumericUpDown max_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button set_count;
        private System.Windows.Forms.Button set_durability;
    }
}