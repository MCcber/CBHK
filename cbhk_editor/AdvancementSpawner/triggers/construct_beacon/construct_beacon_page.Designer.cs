
namespace cbhk_editor.AdvancementSpawner.triggers.construct_beacon
{
    partial class construct_beacon_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(construct_beacon_page));
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.max_value_box = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.set_player = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.min_value_box = new System.Windows.Forms.NumericUpDown();
            this.table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_value_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_value_box)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 6;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.table.Controls.Add(this.max_value_box, 5, 0);
            this.table.Controls.Add(this.label2, 2, 0);
            this.table.Controls.Add(this.set_player, 0, 0);
            this.table.Controls.Add(this.label1, 1, 0);
            this.table.Controls.Add(this.label3, 4, 0);
            this.table.Controls.Add(this.min_value_box, 3, 0);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 2;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.table.Size = new System.Drawing.Size(539, 372);
            this.table.TabIndex = 0;
            // 
            // max_value_box
            // 
            this.max_value_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.max_value_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.max_value_box.ForeColor = System.Drawing.Color.White;
            this.max_value_box.Location = new System.Drawing.Point(412, 3);
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
            this.max_value_box.Size = new System.Drawing.Size(124, 21);
            this.max_value_box.TabIndex = 13;
            this.max_value_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "最小值:";
            // 
            // set_player
            // 
            this.set_player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_player.BackgroundImage")));
            this.set_player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.set_player.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_player.FlatAppearance.BorderSize = 0;
            this.set_player.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_player.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_player.Location = new System.Drawing.Point(3, 3);
            this.set_player.Name = "set_player";
            this.set_player.Size = new System.Drawing.Size(97, 26);
            this.set_player.TabIndex = 8;
            this.set_player.Tag = "\"player\":[]";
            this.set_player.Text = "设置玩家数据";
            this.set_player.UseVisualStyleBackColor = true;
            this.set_player.Click += new System.EventHandler(this.set_player_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "信标层数:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "最大值:";
            // 
            // min_value_box
            // 
            this.min_value_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.min_value_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.min_value_box.ForeColor = System.Drawing.Color.White;
            this.min_value_box.Location = new System.Drawing.Point(230, 3);
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
            this.min_value_box.Size = new System.Drawing.Size(104, 21);
            this.min_value_box.TabIndex = 12;
            this.min_value_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // construct_beacon_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.table);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "construct_beacon_page";
            this.Size = new System.Drawing.Size(539, 372);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_value_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_value_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Button set_player;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown min_value_box;
        private System.Windows.Forms.NumericUpDown max_value_box;
    }
}
