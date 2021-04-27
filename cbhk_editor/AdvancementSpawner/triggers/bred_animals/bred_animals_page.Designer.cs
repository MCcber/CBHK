
namespace cbhk_editor.AdvancementSpawner.triggers.bred_animals
{
    partial class bred_animals_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bred_animals_page));
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.set_player = new System.Windows.Forms.Button();
            this.set_parent = new System.Windows.Forms.Button();
            this.set_partner = new System.Windows.Forms.Button();
            this.set_child = new System.Windows.Forms.Button();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 5;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.table.Controls.Add(this.set_player, 0, 0);
            this.table.Controls.Add(this.set_parent, 1, 0);
            this.table.Controls.Add(this.set_partner, 2, 0);
            this.table.Controls.Add(this.set_child, 3, 0);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 2;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.table.Size = new System.Drawing.Size(539, 372);
            this.table.TabIndex = 0;
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
            this.set_player.Size = new System.Drawing.Size(87, 24);
            this.set_player.TabIndex = 6;
            this.set_player.Tag = "\"player\":[]";
            this.set_player.Text = "设置玩家数据";
            this.set_player.UseVisualStyleBackColor = true;
            // 
            // set_parent
            // 
            this.set_parent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_parent.BackgroundImage")));
            this.set_parent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.set_parent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_parent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_parent.FlatAppearance.BorderSize = 0;
            this.set_parent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_parent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_parent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_parent.Location = new System.Drawing.Point(96, 3);
            this.set_parent.Name = "set_parent";
            this.set_parent.Size = new System.Drawing.Size(102, 24);
            this.set_parent.TabIndex = 7;
            this.set_parent.Text = "设置父或母数据";
            this.set_parent.UseVisualStyleBackColor = true;
            // 
            // set_partner
            // 
            this.set_partner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_partner.BackgroundImage")));
            this.set_partner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.set_partner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_partner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_partner.FlatAppearance.BorderSize = 0;
            this.set_partner.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_partner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_partner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_partner.Location = new System.Drawing.Point(204, 3);
            this.set_partner.Name = "set_partner";
            this.set_partner.Size = new System.Drawing.Size(100, 24);
            this.set_partner.TabIndex = 8;
            this.set_partner.Text = "设置配偶数据";
            this.set_partner.UseVisualStyleBackColor = true;
            // 
            // set_child
            // 
            this.set_child.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_child.BackgroundImage")));
            this.set_child.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.set_child.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_child.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_child.FlatAppearance.BorderSize = 0;
            this.set_child.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_child.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_child.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_child.Location = new System.Drawing.Point(310, 3);
            this.set_child.Name = "set_child";
            this.set_child.Size = new System.Drawing.Size(101, 24);
            this.set_child.TabIndex = 9;
            this.set_child.Text = "设置孩子数据";
            this.set_child.UseVisualStyleBackColor = true;
            // 
            // bred_animals_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.table);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "bred_animals_page";
            this.Size = new System.Drawing.Size(539, 372);
            this.table.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Button set_player;
        private System.Windows.Forms.Button set_parent;
        private System.Windows.Forms.Button set_partner;
        private System.Windows.Forms.Button set_child;
    }
}
