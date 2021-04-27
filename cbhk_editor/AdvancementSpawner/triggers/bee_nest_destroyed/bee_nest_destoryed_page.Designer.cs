
namespace cbhk_editor.AdvancementSpawner.triggers.bee_nest_destroyed
{
    partial class bee_nest_destoryed_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bee_nest_destoryed_page));
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.id_box = new System.Windows.Forms.ComboBox();
            this.set_item = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bees_count_box = new System.Windows.Forms.NumericUpDown();
            this.set_player = new System.Windows.Forms.Button();
            this.table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bees_count_box)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 4;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 226F));
            this.table.Controls.Add(this.label1, 0, 0);
            this.table.Controls.Add(this.id_box, 1, 0);
            this.table.Controls.Add(this.set_item, 2, 0);
            this.table.Controls.Add(this.label2, 0, 1);
            this.table.Controls.Add(this.bees_count_box, 2, 1);
            this.table.Controls.Add(this.set_player, 3, 0);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.ForeColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 3;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.table.Size = new System.Drawing.Size(539, 372);
            this.table.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "方块ID:";
            // 
            // id_box
            // 
            this.id_box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.id_box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.id_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.id_box.ForeColor = System.Drawing.Color.White;
            this.id_box.FormattingEnabled = true;
            this.id_box.Items.AddRange(new object[] {
            "minecraft:beehive",
            "minecraft:bee_nest"});
            this.id_box.Location = new System.Drawing.Point(58, 3);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(121, 20);
            this.id_box.TabIndex = 1;
            this.id_box.Text = "minecraft:beehive";
            this.id_box.TextChanged += new System.EventHandler(this.id_box_TextChanged);
            this.id_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_box_KeyPress);
            // 
            // set_item
            // 
            this.set_item.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_item.BackgroundImage")));
            this.set_item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.set_item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_item.FlatAppearance.BorderSize = 0;
            this.set_item.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_item.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_item.Location = new System.Drawing.Point(188, 3);
            this.set_item.Name = "set_item";
            this.set_item.Size = new System.Drawing.Size(122, 22);
            this.set_item.TabIndex = 2;
            this.set_item.Text = "设置物品谓词";
            this.set_item.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.table.SetColumnSpan(this.label2, 2);
            this.label2.Location = new System.Drawing.Point(81, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "num_bees_inside:";
            // 
            // bees_count_box
            // 
            this.bees_count_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bees_count_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bees_count_box.ForeColor = System.Drawing.Color.White;
            this.bees_count_box.Location = new System.Drawing.Point(188, 31);
            this.bees_count_box.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.bees_count_box.Name = "bees_count_box";
            this.bees_count_box.Size = new System.Drawing.Size(120, 17);
            this.bees_count_box.TabIndex = 4;
            this.bees_count_box.ValueChanged += new System.EventHandler(this.bees_count_box_ValueChanged);
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
            this.set_player.Location = new System.Drawing.Point(316, 3);
            this.set_player.Name = "set_player";
            this.set_player.Size = new System.Drawing.Size(220, 22);
            this.set_player.TabIndex = 5;
            this.set_player.Tag = "\"player\":[]";
            this.set_player.Text = "设置玩家数据";
            this.set_player.UseVisualStyleBackColor = true;
            // 
            // bee_nest_destoryed_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.Name = "bee_nest_destoryed_page";
            this.Size = new System.Drawing.Size(539, 372);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bees_count_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox id_box;
        private System.Windows.Forms.Button set_item;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown bees_count_box;
        private System.Windows.Forms.Button set_player;
        public System.Windows.Forms.TableLayoutPanel table;
    }
}
