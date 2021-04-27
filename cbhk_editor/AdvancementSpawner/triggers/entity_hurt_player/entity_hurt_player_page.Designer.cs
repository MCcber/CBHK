﻿
namespace cbhk_editor.AdvancementSpawner.triggers.entity_hurt_player
{
    partial class entity_hurt_player_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(entity_hurt_player_page));
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.set_player = new System.Windows.Forms.Button();
            this.set_damage_type = new System.Windows.Forms.Button();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.table.Controls.Add(this.set_player, 0, 0);
            this.table.Controls.Add(this.set_damage_type, 1, 0);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.ForeColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 2;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.table.Size = new System.Drawing.Size(539, 372);
            this.table.TabIndex = 2;
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
            this.set_player.Size = new System.Drawing.Size(267, 43);
            this.set_player.TabIndex = 12;
            this.set_player.Tag = "player:[]";
            this.set_player.Text = "设置玩家数据";
            this.set_player.UseVisualStyleBackColor = true;
            // 
            // set_damage_type
            // 
            this.set_damage_type.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_damage_type.BackgroundImage")));
            this.set_damage_type.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.set_damage_type.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_damage_type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_damage_type.FlatAppearance.BorderSize = 0;
            this.set_damage_type.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_damage_type.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_damage_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_damage_type.Location = new System.Drawing.Point(276, 3);
            this.set_damage_type.Name = "set_damage_type";
            this.set_damage_type.Size = new System.Drawing.Size(260, 43);
            this.set_damage_type.TabIndex = 13;
            this.set_damage_type.Text = "设置伤害数据";
            this.set_damage_type.UseVisualStyleBackColor = true;
            // 
            // entity_hurt_player_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.Name = "entity_hurt_player_page";
            this.Size = new System.Drawing.Size(539, 372);
            this.table.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Button set_player;
        private System.Windows.Forms.Button set_damage_type;
    }
}
