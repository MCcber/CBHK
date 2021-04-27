
namespace cbhk_editor.LootTableSpawner.function_components
{
    partial class enchant_with_levels
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(enchant_with_levels));
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.treasure = new System.Windows.Forms.CheckBox();
            this.min_value_box = new System.Windows.Forms.NumericUpDown();
            this.max_value_box = new System.Windows.Forms.NumericUpDown();
            this.set_level = new System.Windows.Forms.Button();
            this.table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min_value_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_value_box)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 4;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.table.Controls.Add(this.label2, 2, 0);
            this.table.Controls.Add(this.label1, 0, 0);
            this.table.Controls.Add(this.treasure, 0, 2);
            this.table.Controls.Add(this.min_value_box, 1, 0);
            this.table.Controls.Add(this.max_value_box, 3, 0);
            this.table.Controls.Add(this.set_level, 0, 1);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.ForeColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 4;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.table.Size = new System.Drawing.Size(447, 195);
            this.table.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "最大值:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "最小值:";
            // 
            // treasure
            // 
            this.treasure.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.treasure.AutoSize = true;
            this.treasure.Location = new System.Drawing.Point(3, 64);
            this.treasure.Name = "treasure";
            this.treasure.Size = new System.Drawing.Size(96, 16);
            this.treasure.TabIndex = 2;
            this.treasure.Text = "允许宝藏附魔";
            this.treasure.UseVisualStyleBackColor = true;
            // 
            // min_value_box
            // 
            this.min_value_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.min_value_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.min_value_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.min_value_box.ForeColor = System.Drawing.Color.White;
            this.min_value_box.Location = new System.Drawing.Point(119, 3);
            this.min_value_box.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.min_value_box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.min_value_box.Name = "min_value_box";
            this.min_value_box.Size = new System.Drawing.Size(104, 17);
            this.min_value_box.TabIndex = 4;
            this.min_value_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // max_value_box
            // 
            this.max_value_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.max_value_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.max_value_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.max_value_box.ForeColor = System.Drawing.Color.White;
            this.max_value_box.Location = new System.Drawing.Point(345, 3);
            this.max_value_box.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.max_value_box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.max_value_box.Name = "max_value_box";
            this.max_value_box.Size = new System.Drawing.Size(99, 17);
            this.max_value_box.TabIndex = 5;
            this.max_value_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // set_level
            // 
            this.set_level.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_level.BackgroundImage")));
            this.set_level.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_level, 4);
            this.set_level.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_level.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_level.FlatAppearance.BorderSize = 0;
            this.set_level.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_level.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_level.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_level.Location = new System.Drawing.Point(3, 25);
            this.set_level.Name = "set_level";
            this.set_level.Size = new System.Drawing.Size(441, 31);
            this.set_level.TabIndex = 7;
            this.set_level.Text = "设置到经验";
            this.set_level.UseVisualStyleBackColor = true;
            this.set_level.Click += new System.EventHandler(this.set_level_Click);
            // 
            // enchant_with_levels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.Name = "enchant_with_levels";
            this.Size = new System.Drawing.Size(447, 195);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min_value_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_value_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.CheckBox treasure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown min_value_box;
        private System.Windows.Forms.NumericUpDown max_value_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button set_level;
    }
}
