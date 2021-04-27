
namespace cbhk_editor.AdvancementSpawner.triggers.player_hurt_entity
{
    partial class player_hurt_entity_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(player_hurt_entity_page));
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.set_player = new System.Windows.Forms.Button();
            this.set_damage = new System.Windows.Forms.Button();
            this.set_entity = new System.Windows.Forms.Button();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 4;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.table.Controls.Add(this.set_player, 0, 0);
            this.table.Controls.Add(this.set_damage, 0, 1);
            this.table.Controls.Add(this.set_entity, 0, 2);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.ForeColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 4;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.table.Size = new System.Drawing.Size(539, 372);
            this.table.TabIndex = 15;
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
            // set_damage
            // 
            this.set_damage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_damage.BackgroundImage")));
            this.set_damage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_damage, 4);
            this.set_damage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_damage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_damage.FlatAppearance.BorderSize = 0;
            this.set_damage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_damage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_damage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_damage.Location = new System.Drawing.Point(3, 52);
            this.set_damage.Name = "set_damage";
            this.set_damage.Size = new System.Drawing.Size(533, 43);
            this.set_damage.TabIndex = 14;
            this.set_damage.Text = "设置伤害数据";
            this.set_damage.UseVisualStyleBackColor = true;
            // 
            // set_entity
            // 
            this.set_entity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_entity.BackgroundImage")));
            this.set_entity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_entity, 4);
            this.set_entity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_entity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_entity.FlatAppearance.BorderSize = 0;
            this.set_entity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_entity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_entity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_entity.Location = new System.Drawing.Point(3, 101);
            this.set_entity.Name = "set_entity";
            this.set_entity.Size = new System.Drawing.Size(533, 46);
            this.set_entity.TabIndex = 15;
            this.set_entity.Text = "设置被伤害实体";
            this.set_entity.UseVisualStyleBackColor = true;
            // 
            // player_hurt_entity_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.Name = "player_hurt_entity_page";
            this.Size = new System.Drawing.Size(539, 372);
            this.table.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Button set_player;
        private System.Windows.Forms.Button set_damage;
        private System.Windows.Forms.Button set_entity;
    }
}
