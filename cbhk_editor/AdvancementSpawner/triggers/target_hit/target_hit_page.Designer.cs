
namespace cbhk_editor.AdvancementSpawner.triggers.target_hit
{
    partial class target_hit_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(target_hit_page));
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.set_player = new System.Windows.Forms.Button();
            this.set_shooter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.set_projectile = new System.Windows.Forms.ComboBox();
            this.signal_strength_box = new System.Windows.Forms.NumericUpDown();
            this.table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signal_strength_box)).BeginInit();
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
            this.table.Controls.Add(this.label2, 0, 3);
            this.table.Controls.Add(this.set_player, 0, 0);
            this.table.Controls.Add(this.set_shooter, 0, 1);
            this.table.Controls.Add(this.label1, 0, 2);
            this.table.Controls.Add(this.set_projectile, 1, 2);
            this.table.Controls.Add(this.signal_strength_box, 1, 3);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.ForeColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 6;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.table.Size = new System.Drawing.Size(539, 372);
            this.table.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "红石信号强度:";
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
            // set_shooter
            // 
            this.set_shooter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_shooter.BackgroundImage")));
            this.set_shooter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.set_shooter, 4);
            this.set_shooter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_shooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_shooter.FlatAppearance.BorderSize = 0;
            this.set_shooter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_shooter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_shooter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_shooter.Location = new System.Drawing.Point(3, 52);
            this.set_shooter.Name = "set_shooter";
            this.set_shooter.Size = new System.Drawing.Size(533, 41);
            this.set_shooter.TabIndex = 14;
            this.set_shooter.Text = "设置射击者";
            this.set_shooter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "设置弹射物:";
            // 
            // set_projectile
            // 
            this.set_projectile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.set_projectile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.set_projectile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.SetColumnSpan(this.set_projectile, 3);
            this.set_projectile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_projectile.ForeColor = System.Drawing.Color.White;
            this.set_projectile.FormattingEnabled = true;
            this.set_projectile.Location = new System.Drawing.Point(94, 99);
            this.set_projectile.Name = "set_projectile";
            this.set_projectile.Size = new System.Drawing.Size(442, 20);
            this.set_projectile.TabIndex = 16;
            // 
            // signal_strength_box
            // 
            this.signal_strength_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.signal_strength_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signal_strength_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signal_strength_box.ForeColor = System.Drawing.Color.White;
            this.signal_strength_box.Location = new System.Drawing.Point(94, 125);
            this.signal_strength_box.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.signal_strength_box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.signal_strength_box.Name = "signal_strength_box";
            this.signal_strength_box.Size = new System.Drawing.Size(176, 17);
            this.signal_strength_box.TabIndex = 19;
            this.signal_strength_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.signal_strength_box.ValueChanged += new System.EventHandler(this.signal_strength_box_ValueChanged);
            // 
            // target_hit_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.Name = "target_hit_page";
            this.Size = new System.Drawing.Size(539, 372);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signal_strength_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Button set_player;
        private System.Windows.Forms.Button set_shooter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox set_projectile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown signal_strength_box;
    }
}
