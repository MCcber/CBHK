
namespace cbhk_editor.AdvancementSpawner.triggers.nether_travel
{
    partial class nether_travel_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nether_travel_page));
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.set_absolute = new System.Windows.Forms.Button();
            this.max_value_box = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.min_value_box = new System.Windows.Forms.NumericUpDown();
            this.set_player = new System.Windows.Forms.Button();
            this.set_horizontal = new System.Windows.Forms.Button();
            this.set_x = new System.Windows.Forms.Button();
            this.set_y = new System.Windows.Forms.Button();
            this.set_z = new System.Windows.Forms.Button();
            this.table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_value_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_value_box)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 4;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.table.Controls.Add(this.set_absolute, 0, 2);
            this.table.Controls.Add(this.max_value_box, 3, 1);
            this.table.Controls.Add(this.label1, 0, 1);
            this.table.Controls.Add(this.label2, 2, 1);
            this.table.Controls.Add(this.min_value_box, 1, 1);
            this.table.Controls.Add(this.set_player, 0, 0);
            this.table.Controls.Add(this.set_horizontal, 0, 3);
            this.table.Controls.Add(this.set_x, 0, 4);
            this.table.Controls.Add(this.set_y, 0, 5);
            this.table.Controls.Add(this.set_z, 0, 6);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.ForeColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 8;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.table.Size = new System.Drawing.Size(539, 372);
            this.table.TabIndex = 12;
            // 
            // set_absolute
            // 
            this.set_absolute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_absolute.BackgroundImage")));
            this.set_absolute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_absolute, 4);
            this.set_absolute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_absolute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_absolute.FlatAppearance.BorderSize = 0;
            this.set_absolute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_absolute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_absolute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_absolute.Location = new System.Drawing.Point(3, 79);
            this.set_absolute.Name = "set_absolute";
            this.set_absolute.Size = new System.Drawing.Size(533, 39);
            this.set_absolute.TabIndex = 18;
            this.set_absolute.Text = "设置到绝对距离";
            this.set_absolute.UseVisualStyleBackColor = true;
            // 
            // max_value_box
            // 
            this.max_value_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.max_value_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.max_value_box.ForeColor = System.Drawing.Color.White;
            this.max_value_box.Location = new System.Drawing.Point(332, 52);
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
            this.max_value_box.Size = new System.Drawing.Size(204, 21);
            this.max_value_box.TabIndex = 17;
            this.max_value_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "最小值:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "最大值:";
            // 
            // min_value_box
            // 
            this.min_value_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.min_value_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.min_value_box.ForeColor = System.Drawing.Color.White;
            this.min_value_box.Location = new System.Drawing.Point(58, 52);
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
            this.min_value_box.Size = new System.Drawing.Size(212, 21);
            this.min_value_box.TabIndex = 16;
            this.min_value_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // set_player
            // 
            this.set_player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_player.BackgroundImage")));
            this.set_player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_player, 4);
            this.set_player.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_player.FlatAppearance.BorderSize = 0;
            this.set_player.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_player.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_player.Location = new System.Drawing.Point(3, 3);
            this.set_player.Name = "set_player";
            this.set_player.Size = new System.Drawing.Size(533, 43);
            this.set_player.TabIndex = 13;
            this.set_player.Tag = "player:[]";
            this.set_player.Text = "设置玩家数据";
            this.set_player.UseVisualStyleBackColor = true;
            // 
            // set_horizontal
            // 
            this.set_horizontal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_horizontal.BackgroundImage")));
            this.set_horizontal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_horizontal, 4);
            this.set_horizontal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_horizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_horizontal.FlatAppearance.BorderSize = 0;
            this.set_horizontal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_horizontal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_horizontal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_horizontal.Location = new System.Drawing.Point(3, 124);
            this.set_horizontal.Name = "set_horizontal";
            this.set_horizontal.Size = new System.Drawing.Size(533, 40);
            this.set_horizontal.TabIndex = 19;
            this.set_horizontal.Text = "设置到相对距离";
            this.set_horizontal.UseVisualStyleBackColor = true;
            // 
            // set_x
            // 
            this.set_x.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_x.BackgroundImage")));
            this.set_x.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_x, 4);
            this.set_x.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_x.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_x.FlatAppearance.BorderSize = 0;
            this.set_x.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_x.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_x.Location = new System.Drawing.Point(3, 170);
            this.set_x.Name = "set_x";
            this.set_x.Size = new System.Drawing.Size(533, 40);
            this.set_x.TabIndex = 20;
            this.set_x.Text = "设置到X距离";
            this.set_x.UseVisualStyleBackColor = true;
            // 
            // set_y
            // 
            this.set_y.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_y.BackgroundImage")));
            this.set_y.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_y, 4);
            this.set_y.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_y.FlatAppearance.BorderSize = 0;
            this.set_y.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_y.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_y.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_y.Location = new System.Drawing.Point(3, 216);
            this.set_y.Name = "set_y";
            this.set_y.Size = new System.Drawing.Size(533, 37);
            this.set_y.TabIndex = 21;
            this.set_y.Text = "设置到Y距离";
            this.set_y.UseVisualStyleBackColor = true;
            // 
            // set_z
            // 
            this.set_z.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_z.BackgroundImage")));
            this.set_z.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_z, 4);
            this.set_z.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_z.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_z.FlatAppearance.BorderSize = 0;
            this.set_z.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_z.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_z.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_z.Location = new System.Drawing.Point(3, 259);
            this.set_z.Name = "set_z";
            this.set_z.Size = new System.Drawing.Size(533, 34);
            this.set_z.TabIndex = 22;
            this.set_z.Text = "设置到Z距离";
            this.set_z.UseVisualStyleBackColor = true;
            // 
            // nether_travel_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.Name = "nether_travel_page";
            this.Size = new System.Drawing.Size(539, 372);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_value_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_value_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Button set_absolute;
        private System.Windows.Forms.NumericUpDown max_value_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown min_value_box;
        private System.Windows.Forms.Button set_player;
        private System.Windows.Forms.Button set_horizontal;
        private System.Windows.Forms.Button set_x;
        private System.Windows.Forms.Button set_y;
        private System.Windows.Forms.Button set_z;
    }
}
