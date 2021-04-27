
namespace cbhk_editor.AdvancementSpawner.triggers.inventory_changed
{
    partial class inventory_changed_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventory_changed_page));
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.set_occupied = new System.Windows.Forms.Button();
            this.set_full = new System.Windows.Forms.Button();
            this.set_empty = new System.Windows.Forms.Button();
            this.max_value_box = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.set_item = new System.Windows.Forms.Button();
            this.set_player = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.min_value_box = new System.Windows.Forms.NumericUpDown();
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
            this.table.Controls.Add(this.set_occupied, 0, 3);
            this.table.Controls.Add(this.set_full, 2, 2);
            this.table.Controls.Add(this.set_empty, 0, 2);
            this.table.Controls.Add(this.max_value_box, 3, 1);
            this.table.Controls.Add(this.label2, 2, 1);
            this.table.Controls.Add(this.set_item, 0, 0);
            this.table.Controls.Add(this.set_player, 2, 0);
            this.table.Controls.Add(this.label1, 0, 1);
            this.table.Controls.Add(this.min_value_box, 1, 1);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.ForeColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 5;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.table.Size = new System.Drawing.Size(539, 372);
            this.table.TabIndex = 7;
            // 
            // set_occupied
            // 
            this.set_occupied.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_occupied.BackgroundImage")));
            this.set_occupied.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_occupied, 2);
            this.set_occupied.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_occupied.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_occupied.FlatAppearance.BorderSize = 0;
            this.set_occupied.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_occupied.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_occupied.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_occupied.Location = new System.Drawing.Point(3, 124);
            this.set_occupied.Name = "set_occupied";
            this.set_occupied.Size = new System.Drawing.Size(267, 35);
            this.set_occupied.TabIndex = 20;
            this.set_occupied.Text = "设置到已使用槽位数量";
            this.set_occupied.UseVisualStyleBackColor = true;
            // 
            // set_full
            // 
            this.set_full.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_full.BackgroundImage")));
            this.set_full.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_full, 2);
            this.set_full.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_full.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_full.FlatAppearance.BorderSize = 0;
            this.set_full.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_full.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_full.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_full.Location = new System.Drawing.Point(276, 82);
            this.set_full.Name = "set_full";
            this.set_full.Size = new System.Drawing.Size(260, 36);
            this.set_full.TabIndex = 19;
            this.set_full.Text = "设置到满槽数量";
            this.set_full.UseVisualStyleBackColor = true;
            // 
            // set_empty
            // 
            this.set_empty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_empty.BackgroundImage")));
            this.set_empty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_empty, 2);
            this.set_empty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_empty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_empty.FlatAppearance.BorderSize = 0;
            this.set_empty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_empty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_empty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_empty.Location = new System.Drawing.Point(3, 82);
            this.set_empty.Name = "set_empty";
            this.set_empty.Size = new System.Drawing.Size(267, 36);
            this.set_empty.TabIndex = 18;
            this.set_empty.Text = "设置到空槽数量";
            this.set_empty.UseVisualStyleBackColor = true;
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
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "最大值:";
            // 
            // set_item
            // 
            this.set_item.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_item.BackgroundImage")));
            this.set_item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_item, 2);
            this.set_item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_item.FlatAppearance.BorderSize = 0;
            this.set_item.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_item.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_item.Location = new System.Drawing.Point(3, 3);
            this.set_item.Name = "set_item";
            this.set_item.Size = new System.Drawing.Size(267, 43);
            this.set_item.TabIndex = 12;
            this.set_item.Text = "设置物品数据";
            this.set_item.UseVisualStyleBackColor = true;
            // 
            // set_player
            // 
            this.set_player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_player.BackgroundImage")));
            this.set_player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_player, 2);
            this.set_player.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_player.FlatAppearance.BorderSize = 0;
            this.set_player.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_player.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_player.Location = new System.Drawing.Point(276, 3);
            this.set_player.Name = "set_player";
            this.set_player.Size = new System.Drawing.Size(260, 43);
            this.set_player.TabIndex = 13;
            this.set_player.Tag = "player:[]";
            this.set_player.Text = "设置玩家数据";
            this.set_player.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "最小值:";
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
            this.min_value_box.TabIndex = 15;
            this.min_value_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // inventory_changed_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.Name = "inventory_changed_page";
            this.Size = new System.Drawing.Size(539, 372);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_value_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_value_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Button set_item;
        private System.Windows.Forms.Button set_player;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown min_value_box;
        private System.Windows.Forms.NumericUpDown max_value_box;
        private System.Windows.Forms.Button set_empty;
        private System.Windows.Forms.Button set_occupied;
        private System.Windows.Forms.Button set_full;
    }
}
