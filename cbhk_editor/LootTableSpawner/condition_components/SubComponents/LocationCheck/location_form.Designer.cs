
namespace cbhk_editor.LootTableSpawner.condition_components.SubComponents
{
    partial class location_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(location_form));
            this.location_title_menu = new System.Windows.Forms.MenuStrip();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.方块谓词ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_block = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_block = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_block = new System.Windows.Forms.ToolStripMenuItem();
            this.流体谓词 = new System.Windows.Forms.ToolStripMenuItem();
            this.add_fluid = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_fluid = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_fluid = new System.Windows.Forms.ToolStripMenuItem();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.set_z = new System.Windows.Forms.Button();
            this.set_light = new System.Windows.Forms.Button();
            this.set_x = new System.Windows.Forms.Button();
            this.max_value_box = new System.Windows.Forms.TextBox();
            this.dimension_box = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.biome_box = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.feature_box = new System.Windows.Forms.ComboBox();
            this.block_area = new System.Windows.Forms.GroupBox();
            this.block_tab = new System.Windows.Forms.TabControl();
            this.fluid_area = new System.Windows.Forms.GroupBox();
            this.fluid_tab = new System.Windows.Forms.TabControl();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.min_value_box = new System.Windows.Forms.TextBox();
            this.set_y = new System.Windows.Forms.Button();
            this.location_title_menu.SuspendLayout();
            this.table.SuspendLayout();
            this.block_area.SuspendLayout();
            this.fluid_area.SuspendLayout();
            this.SuspendLayout();
            // 
            // location_title_menu
            // 
            this.location_title_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.location_title_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑EToolStripMenuItem});
            this.location_title_menu.Location = new System.Drawing.Point(0, 0);
            this.location_title_menu.Name = "location_title_menu";
            this.location_title_menu.Size = new System.Drawing.Size(411, 25);
            this.location_title_menu.TabIndex = 0;
            this.location_title_menu.Text = "menuStrip1";
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.方块谓词ToolStripMenuItem,
            this.流体谓词});
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.编辑EToolStripMenuItem.Text = "编辑&E";
            // 
            // 方块谓词ToolStripMenuItem
            // 
            this.方块谓词ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_block,
            this.delete_block,
            this.clear_block});
            this.方块谓词ToolStripMenuItem.Name = "方块谓词ToolStripMenuItem";
            this.方块谓词ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.方块谓词ToolStripMenuItem.Text = "方块谓词";
            // 
            // add_block
            // 
            this.add_block.Name = "add_block";
            this.add_block.Size = new System.Drawing.Size(100, 22);
            this.add_block.Text = "添加";
            this.add_block.Click += new System.EventHandler(this.add_block_Click);
            // 
            // delete_block
            // 
            this.delete_block.Name = "delete_block";
            this.delete_block.Size = new System.Drawing.Size(100, 22);
            this.delete_block.Text = "删除";
            this.delete_block.Click += new System.EventHandler(this.delete_block_Click);
            // 
            // clear_block
            // 
            this.clear_block.Name = "clear_block";
            this.clear_block.Size = new System.Drawing.Size(100, 22);
            this.clear_block.Text = "清空";
            this.clear_block.Click += new System.EventHandler(this.clear_block_Click);
            // 
            // 流体谓词
            // 
            this.流体谓词.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_fluid,
            this.delete_fluid,
            this.clear_fluid});
            this.流体谓词.Name = "流体谓词";
            this.流体谓词.Size = new System.Drawing.Size(124, 22);
            this.流体谓词.Text = "流体谓词";
            // 
            // add_fluid
            // 
            this.add_fluid.Name = "add_fluid";
            this.add_fluid.Size = new System.Drawing.Size(100, 22);
            this.add_fluid.Text = "添加";
            this.add_fluid.Click += new System.EventHandler(this.add_fluid_Click);
            // 
            // delete_fluid
            // 
            this.delete_fluid.Name = "delete_fluid";
            this.delete_fluid.Size = new System.Drawing.Size(100, 22);
            this.delete_fluid.Text = "删除";
            this.delete_fluid.Click += new System.EventHandler(this.delete_fluid_Click);
            // 
            // clear_fluid
            // 
            this.clear_fluid.Name = "clear_fluid";
            this.clear_fluid.Size = new System.Drawing.Size(100, 22);
            this.clear_fluid.Text = "清空";
            this.clear_fluid.Click += new System.EventHandler(this.clear_fluid_Click);
            // 
            // table
            // 
            this.table.ColumnCount = 4;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.table.Controls.Add(this.set_z, 0, 6);
            this.table.Controls.Add(this.set_light, 0, 6);
            this.table.Controls.Add(this.set_x, 0, 5);
            this.table.Controls.Add(this.max_value_box, 3, 4);
            this.table.Controls.Add(this.dimension_box, 1, 1);
            this.table.Controls.Add(this.label2, 0, 1);
            this.table.Controls.Add(this.label1, 0, 0);
            this.table.Controls.Add(this.biome_box, 1, 0);
            this.table.Controls.Add(this.label3, 0, 2);
            this.table.Controls.Add(this.feature_box, 1, 2);
            this.table.Controls.Add(this.block_area, 0, 3);
            this.table.Controls.Add(this.fluid_area, 2, 3);
            this.table.Controls.Add(this.label8, 0, 4);
            this.table.Controls.Add(this.label9, 2, 4);
            this.table.Controls.Add(this.min_value_box, 1, 4);
            this.table.Controls.Add(this.set_y, 2, 5);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.ForeColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 25);
            this.table.Name = "table";
            this.table.RowCount = 7;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.table.Size = new System.Drawing.Size(411, 324);
            this.table.TabIndex = 1;
            // 
            // set_z
            // 
            this.set_z.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_z.BackgroundImage")));
            this.set_z.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_z, 2);
            this.set_z.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_z.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_z.FlatAppearance.BorderSize = 0;
            this.set_z.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_z.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_z.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_z.Location = new System.Drawing.Point(3, 300);
            this.set_z.Name = "set_z";
            this.set_z.Size = new System.Drawing.Size(205, 21);
            this.set_z.TabIndex = 15;
            this.set_z.Text = "设置到Z轴";
            this.set_z.UseVisualStyleBackColor = true;
            // 
            // set_light
            // 
            this.set_light.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_light.BackgroundImage")));
            this.set_light.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_light, 2);
            this.set_light.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_light.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_light.FlatAppearance.BorderSize = 0;
            this.set_light.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_light.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_light.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_light.Location = new System.Drawing.Point(214, 300);
            this.set_light.Name = "set_light";
            this.set_light.Size = new System.Drawing.Size(194, 21);
            this.set_light.TabIndex = 14;
            this.set_light.Text = "设置到光亮度";
            this.set_light.UseVisualStyleBackColor = true;
            // 
            // set_x
            // 
            this.set_x.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_x.BackgroundImage")));
            this.set_x.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_x, 2);
            this.set_x.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_x.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_x.FlatAppearance.BorderSize = 0;
            this.set_x.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_x.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_x.Location = new System.Drawing.Point(3, 272);
            this.set_x.Name = "set_x";
            this.set_x.Size = new System.Drawing.Size(205, 22);
            this.set_x.TabIndex = 12;
            this.set_x.Text = "设置到X轴";
            this.set_x.UseVisualStyleBackColor = true;
            // 
            // max_value_box
            // 
            this.max_value_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.max_value_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.max_value_box.ForeColor = System.Drawing.Color.White;
            this.max_value_box.Location = new System.Drawing.Point(269, 245);
            this.max_value_box.Name = "max_value_box";
            this.max_value_box.Size = new System.Drawing.Size(139, 21);
            this.max_value_box.TabIndex = 11;
            // 
            // dimension_box
            // 
            this.dimension_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.SetColumnSpan(this.dimension_box, 3);
            this.dimension_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dimension_box.ForeColor = System.Drawing.Color.White;
            this.dimension_box.FormattingEnabled = true;
            this.dimension_box.Items.AddRange(new object[] {
            "minecraft:overworld",
            "minecraft:the_end",
            "minecraft:nether"});
            this.dimension_box.Location = new System.Drawing.Point(70, 29);
            this.dimension_box.Name = "dimension_box";
            this.dimension_box.Size = new System.Drawing.Size(338, 20);
            this.dimension_box.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "维度:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "生物群系:";
            // 
            // biome_box
            // 
            this.biome_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.SetColumnSpan(this.biome_box, 3);
            this.biome_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.biome_box.ForeColor = System.Drawing.Color.White;
            this.biome_box.FormattingEnabled = true;
            this.biome_box.Location = new System.Drawing.Point(70, 3);
            this.biome_box.Name = "biome_box";
            this.biome_box.Size = new System.Drawing.Size(338, 20);
            this.biome_box.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "结构:";
            // 
            // feature_box
            // 
            this.feature_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.SetColumnSpan(this.feature_box, 3);
            this.feature_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feature_box.ForeColor = System.Drawing.Color.White;
            this.feature_box.FormattingEnabled = true;
            this.feature_box.Location = new System.Drawing.Point(70, 57);
            this.feature_box.Name = "feature_box";
            this.feature_box.Size = new System.Drawing.Size(338, 20);
            this.feature_box.TabIndex = 5;
            // 
            // block_area
            // 
            this.table.SetColumnSpan(this.block_area, 2);
            this.block_area.Controls.Add(this.block_tab);
            this.block_area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.block_area.ForeColor = System.Drawing.Color.White;
            this.block_area.Location = new System.Drawing.Point(3, 86);
            this.block_area.Name = "block_area";
            this.block_area.Size = new System.Drawing.Size(205, 153);
            this.block_area.TabIndex = 6;
            this.block_area.TabStop = false;
            this.block_area.Text = "方块谓词";
            // 
            // block_tab
            // 
            this.block_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.block_tab.ItemSize = new System.Drawing.Size(15, 15);
            this.block_tab.Location = new System.Drawing.Point(3, 17);
            this.block_tab.Name = "block_tab";
            this.block_tab.SelectedIndex = 0;
            this.block_tab.Size = new System.Drawing.Size(199, 133);
            this.block_tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.block_tab.TabIndex = 0;
            // 
            // fluid_area
            // 
            this.table.SetColumnSpan(this.fluid_area, 2);
            this.fluid_area.Controls.Add(this.fluid_tab);
            this.fluid_area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluid_area.ForeColor = System.Drawing.Color.White;
            this.fluid_area.Location = new System.Drawing.Point(214, 86);
            this.fluid_area.Name = "fluid_area";
            this.fluid_area.Size = new System.Drawing.Size(194, 153);
            this.fluid_area.TabIndex = 7;
            this.fluid_area.TabStop = false;
            this.fluid_area.Text = "流体谓词";
            // 
            // fluid_tab
            // 
            this.fluid_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluid_tab.ItemSize = new System.Drawing.Size(15, 15);
            this.fluid_tab.Location = new System.Drawing.Point(3, 17);
            this.fluid_tab.Name = "fluid_tab";
            this.fluid_tab.SelectedIndex = 0;
            this.fluid_tab.Size = new System.Drawing.Size(188, 133);
            this.fluid_tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.fluid_tab.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "最小值:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "最大值:";
            // 
            // min_value_box
            // 
            this.min_value_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.min_value_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.min_value_box.ForeColor = System.Drawing.Color.White;
            this.min_value_box.Location = new System.Drawing.Point(70, 245);
            this.min_value_box.Name = "min_value_box";
            this.min_value_box.Size = new System.Drawing.Size(138, 21);
            this.min_value_box.TabIndex = 10;
            // 
            // set_y
            // 
            this.set_y.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_y.BackgroundImage")));
            this.set_y.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_y, 2);
            this.set_y.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_y.FlatAppearance.BorderSize = 0;
            this.set_y.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_y.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_y.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_y.Location = new System.Drawing.Point(214, 272);
            this.set_y.Name = "set_y";
            this.set_y.Size = new System.Drawing.Size(194, 22);
            this.set_y.TabIndex = 13;
            this.set_y.Text = "设置到Y轴";
            this.set_y.UseVisualStyleBackColor = true;
            // 
            // location_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(411, 349);
            this.Controls.Add(this.table);
            this.Controls.Add(this.location_title_menu);
            this.MainMenuStrip = this.location_title_menu;
            this.MaximizeBox = false;
            this.Name = "location_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置位置谓词";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.location_form_FormClosing);
            this.location_title_menu.ResumeLayout(false);
            this.location_title_menu.PerformLayout();
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.block_area.ResumeLayout(false);
            this.fluid_area.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip location_title_menu;
        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Button set_z;
        private System.Windows.Forms.Button set_light;
        private System.Windows.Forms.Button set_x;
        private System.Windows.Forms.TextBox max_value_box;
        private System.Windows.Forms.ComboBox dimension_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox biome_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox feature_box;
        private System.Windows.Forms.GroupBox block_area;
        private System.Windows.Forms.TabControl block_tab;
        private System.Windows.Forms.GroupBox fluid_area;
        private System.Windows.Forms.TabControl fluid_tab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox min_value_box;
        private System.Windows.Forms.Button set_y;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 方块谓词ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 流体谓词;
        private System.Windows.Forms.ToolStripMenuItem add_block;
        private System.Windows.Forms.ToolStripMenuItem delete_block;
        private System.Windows.Forms.ToolStripMenuItem clear_block;
        private System.Windows.Forms.ToolStripMenuItem add_fluid;
        private System.Windows.Forms.ToolStripMenuItem delete_fluid;
        private System.Windows.Forms.ToolStripMenuItem clear_fluid;
    }
}