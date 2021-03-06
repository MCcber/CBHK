
namespace cbhk_editor.AdvancementSpawner.triggers.fishing_rod_hooked
{
    partial class fishing_rod_hooked_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fishing_rod_hooked_page));
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.set_entity = new System.Windows.Forms.Button();
            this.set_player = new System.Windows.Forms.Button();
            this.set_item = new System.Windows.Forms.Button();
            this.set_rod = new System.Windows.Forms.Button();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.table.Controls.Add(this.set_entity, 0, 0);
            this.table.Controls.Add(this.set_player, 1, 0);
            this.table.Controls.Add(this.set_item, 0, 1);
            this.table.Controls.Add(this.set_rod, 1, 1);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.ForeColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 3;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.Size = new System.Drawing.Size(539, 372);
            this.table.TabIndex = 5;
            // 
            // set_entity
            // 
            this.set_entity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_entity.BackgroundImage")));
            this.set_entity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.set_entity.Text = "设置被拉的实体";
            this.set_entity.UseVisualStyleBackColor = true;
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
            this.set_player.Location = new System.Drawing.Point(276, 3);
            this.set_player.Name = "set_player";
            this.set_player.Size = new System.Drawing.Size(260, 43);
            this.set_player.TabIndex = 13;
            this.set_player.Tag = "player:[]";
            this.set_player.Text = "设置玩家数据";
            this.set_player.UseVisualStyleBackColor = true;
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
            this.set_item.Location = new System.Drawing.Point(3, 52);
            this.set_item.Name = "set_item";
            this.set_item.Size = new System.Drawing.Size(267, 47);
            this.set_item.TabIndex = 14;
            this.set_item.Text = "设置被取得的物品";
            this.set_item.UseVisualStyleBackColor = true;
            // 
            // set_rod
            // 
            this.set_rod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_rod.BackgroundImage")));
            this.set_rod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.set_rod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_rod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_rod.FlatAppearance.BorderSize = 0;
            this.set_rod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_rod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_rod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_rod.Location = new System.Drawing.Point(276, 52);
            this.set_rod.Name = "set_rod";
            this.set_rod.Size = new System.Drawing.Size(260, 47);
            this.set_rod.TabIndex = 15;
            this.set_rod.Text = "设置使用的钓竿";
            this.set_rod.UseVisualStyleBackColor = true;
            // 
            // fishing_rod_hooked_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.Name = "fishing_rod_hooked_page";
            this.Size = new System.Drawing.Size(539, 372);
            this.table.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Button set_entity;
        private System.Windows.Forms.Button set_player;
        private System.Windows.Forms.Button set_item;
        private System.Windows.Forms.Button set_rod;
    }
}
