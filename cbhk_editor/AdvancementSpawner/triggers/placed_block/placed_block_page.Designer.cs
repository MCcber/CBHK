
namespace cbhk_editor.AdvancementSpawner.triggers.placed_block
{
    partial class placed_block_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(placed_block_page));
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.set_item = new System.Windows.Forms.Button();
            this.set_player = new System.Windows.Forms.Button();
            this.set_location = new System.Windows.Forms.Button();
            this.set_block = new System.Windows.Forms.Button();
            this.table.SuspendLayout();
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
            this.table.Controls.Add(this.set_item, 0, 2);
            this.table.Controls.Add(this.set_player, 0, 0);
            this.table.Controls.Add(this.set_location, 0, 1);
            this.table.Controls.Add(this.set_block, 0, 3);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.ForeColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 5;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.Size = new System.Drawing.Size(539, 372);
            this.table.TabIndex = 13;
            // 
            // set_item
            // 
            this.set_item.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_item.BackgroundImage")));
            this.set_item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_item, 4);
            this.set_item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_item.FlatAppearance.BorderSize = 0;
            this.set_item.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_item.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_item.Location = new System.Drawing.Point(3, 102);
            this.set_item.Name = "set_item";
            this.set_item.Size = new System.Drawing.Size(533, 42);
            this.set_item.TabIndex = 20;
            this.set_item.Text = "设置物品数据";
            this.set_item.UseVisualStyleBackColor = true;
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
            // set_location
            // 
            this.set_location.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_location.BackgroundImage")));
            this.set_location.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_location, 4);
            this.set_location.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_location.FlatAppearance.BorderSize = 0;
            this.set_location.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_location.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_location.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_location.Location = new System.Drawing.Point(3, 52);
            this.set_location.Name = "set_location";
            this.set_location.Size = new System.Drawing.Size(533, 44);
            this.set_location.TabIndex = 18;
            this.set_location.Text = "设置位置数据";
            this.set_location.UseVisualStyleBackColor = true;
            // 
            // set_block
            // 
            this.set_block.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_block.BackgroundImage")));
            this.set_block.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_block, 4);
            this.set_block.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_block.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_block.FlatAppearance.BorderSize = 0;
            this.set_block.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_block.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_block.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_block.Location = new System.Drawing.Point(3, 150);
            this.set_block.Name = "set_block";
            this.set_block.Size = new System.Drawing.Size(533, 40);
            this.set_block.TabIndex = 21;
            this.set_block.Text = "设置方块数据";
            this.set_block.UseVisualStyleBackColor = true;
            this.set_block.Click += new System.EventHandler(this.set_block_Click);
            // 
            // placed_block_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.Name = "placed_block_page";
            this.Size = new System.Drawing.Size(539, 372);
            this.table.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Button set_location;
        private System.Windows.Forms.Button set_player;
        private System.Windows.Forms.Button set_item;
        private System.Windows.Forms.Button set_block;
    }
}
