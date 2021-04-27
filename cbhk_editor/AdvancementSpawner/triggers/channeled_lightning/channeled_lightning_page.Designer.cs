
namespace cbhk_editor.AdvancementSpawner.triggers.channeled_lightning
{
    partial class channeled_lightning_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(channeled_lightning_page));
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.set_player = new System.Windows.Forms.Button();
            this.set_victims = new System.Windows.Forms.Button();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 268F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table.Controls.Add(this.set_player, 1, 0);
            this.table.Controls.Add(this.set_victims, 0, 0);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 2;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
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
            this.set_player.Location = new System.Drawing.Point(271, 3);
            this.set_player.Name = "set_player";
            this.set_player.Size = new System.Drawing.Size(265, 26);
            this.set_player.TabIndex = 7;
            this.set_player.Tag = "\"player\":[]";
            this.set_player.Text = "设置玩家数据";
            this.set_player.UseVisualStyleBackColor = true;
            // 
            // set_victims
            // 
            this.set_victims.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_victims.BackgroundImage")));
            this.set_victims.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.set_victims.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_victims.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_victims.FlatAppearance.BorderSize = 0;
            this.set_victims.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_victims.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_victims.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_victims.Location = new System.Drawing.Point(3, 3);
            this.set_victims.Name = "set_victims";
            this.set_victims.Size = new System.Drawing.Size(262, 26);
            this.set_victims.TabIndex = 8;
            this.set_victims.Text = "设置被雷击实体数据";
            this.set_victims.UseVisualStyleBackColor = true;
            // 
            // channeled_lightning_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.table);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "channeled_lightning_page";
            this.Size = new System.Drawing.Size(539, 372);
            this.table.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Button set_player;
        private System.Windows.Forms.Button set_victims;
    }
}
