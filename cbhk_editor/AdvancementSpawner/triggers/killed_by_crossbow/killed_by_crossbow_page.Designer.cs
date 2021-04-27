
namespace cbhk_editor.AdvancementSpawner.triggers.killed_by_crossbow
{
    partial class killed_by_crossbow_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(killed_by_crossbow_page));
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.set_unique_entity_types = new System.Windows.Forms.Button();
            this.max_value_box = new System.Windows.Forms.NumericUpDown();
            this.set_entity = new System.Windows.Forms.Button();
            this.set_player = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.table.Controls.Add(this.set_unique_entity_types, 0, 2);
            this.table.Controls.Add(this.max_value_box, 3, 1);
            this.table.Controls.Add(this.set_entity, 0, 0);
            this.table.Controls.Add(this.set_player, 2, 0);
            this.table.Controls.Add(this.label1, 0, 1);
            this.table.Controls.Add(this.label2, 2, 1);
            this.table.Controls.Add(this.min_value_box, 1, 1);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.ForeColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 4;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.Size = new System.Drawing.Size(539, 372);
            this.table.TabIndex = 10;
            // 
            // set_unique_entity_types
            // 
            this.set_unique_entity_types.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_unique_entity_types.BackgroundImage")));
            this.set_unique_entity_types.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_unique_entity_types, 4);
            this.set_unique_entity_types.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_unique_entity_types.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_unique_entity_types.FlatAppearance.BorderSize = 0;
            this.set_unique_entity_types.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_unique_entity_types.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_unique_entity_types.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_unique_entity_types.Location = new System.Drawing.Point(3, 79);
            this.set_unique_entity_types.Name = "set_unique_entity_types";
            this.set_unique_entity_types.Size = new System.Drawing.Size(533, 39);
            this.set_unique_entity_types.TabIndex = 18;
            this.set_unique_entity_types.Text = "设置到杀死实体种类数";
            this.set_unique_entity_types.UseVisualStyleBackColor = true;
            this.set_unique_entity_types.Click += new System.EventHandler(this.set_unique_entity_types_Click);
            // 
            // max_value_box
            // 
            this.max_value_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.max_value_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.max_value_box.Size = new System.Drawing.Size(204, 17);
            this.max_value_box.TabIndex = 17;
            this.max_value_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // set_entity
            // 
            this.set_entity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_entity.BackgroundImage")));
            this.set_entity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_entity, 2);
            this.set_entity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_entity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_entity.FlatAppearance.BorderSize = 0;
            this.set_entity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_entity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_entity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_entity.Location = new System.Drawing.Point(3, 3);
            this.set_entity.Name = "set_entity";
            this.set_entity.Size = new System.Drawing.Size(267, 43);
            this.set_entity.TabIndex = 12;
            this.set_entity.Text = "设置被杀死的实体列表";
            this.set_entity.UseVisualStyleBackColor = true;
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
            this.min_value_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.min_value_box.Size = new System.Drawing.Size(212, 17);
            this.min_value_box.TabIndex = 16;
            this.min_value_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // killed_by_crossbow_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.Name = "killed_by_crossbow_page";
            this.Size = new System.Drawing.Size(539, 372);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_value_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_value_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Button set_entity;
        private System.Windows.Forms.Button set_player;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown max_value_box;
        private System.Windows.Forms.NumericUpDown min_value_box;
        private System.Windows.Forms.Button set_unique_entity_types;
    }
}
