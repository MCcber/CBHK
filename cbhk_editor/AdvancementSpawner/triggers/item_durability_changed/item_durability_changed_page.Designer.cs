
namespace cbhk_editor.AdvancementSpawner.triggers.item_durability_changed
{
    partial class item_durability_changed_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(item_durability_changed_page));
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.set_durability = new System.Windows.Forms.Button();
            this.set_delta = new System.Windows.Forms.Button();
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
            this.table.Controls.Add(this.set_durability, 2, 2);
            this.table.Controls.Add(this.set_delta, 0, 2);
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
            this.table.TabIndex = 8;
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
            this.set_durability.Location = new System.Drawing.Point(276, 82);
            this.set_durability.Name = "set_durability";
            this.set_durability.Size = new System.Drawing.Size(260, 36);
            this.set_durability.TabIndex = 19;
            this.set_durability.Text = "设置到剩余耐久度";
            this.set_durability.UseVisualStyleBackColor = true;
            // 
            // set_delta
            // 
            this.set_delta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_delta.BackgroundImage")));
            this.set_delta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_delta, 2);
            this.set_delta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_delta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_delta.FlatAppearance.BorderSize = 0;
            this.set_delta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_delta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_delta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_delta.Location = new System.Drawing.Point(3, 82);
            this.set_delta.Name = "set_delta";
            this.set_delta.Size = new System.Drawing.Size(267, 36);
            this.set_delta.TabIndex = 18;
            this.set_delta.Text = "设置到耐久度差值";
            this.set_delta.UseVisualStyleBackColor = true;
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
            // item_durability_changed_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.Name = "item_durability_changed_page";
            this.Size = new System.Drawing.Size(539, 372);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_value_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_value_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Button set_durability;
        private System.Windows.Forms.Button set_delta;
        private System.Windows.Forms.NumericUpDown max_value_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button set_item;
        private System.Windows.Forms.Button set_player;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown min_value_box;
    }
}
