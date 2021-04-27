
namespace cbhk_editor.SkillSpawner.EventsCompnents
{
    partial class SpreadTeleport
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
            this.label1 = new System.Windows.Forms.Label();
            this.spreadDistance = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.maxRange = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.under = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spreadDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.under)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "距离:";
            // 
            // spreadDistance
            // 
            this.spreadDistance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.spreadDistance.ForeColor = System.Drawing.Color.White;
            this.spreadDistance.Location = new System.Drawing.Point(30, 0);
            this.spreadDistance.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.spreadDistance.Name = "spreadDistance";
            this.spreadDistance.Size = new System.Drawing.Size(120, 21);
            this.spreadDistance.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(153, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "最大范围:";
            // 
            // maxRange
            // 
            this.maxRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.maxRange.ForeColor = System.Drawing.Color.White;
            this.maxRange.Location = new System.Drawing.Point(212, 0);
            this.maxRange.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.maxRange.Name = "maxRange";
            this.maxRange.Size = new System.Drawing.Size(120, 21);
            this.maxRange.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "在";
            // 
            // under
            // 
            this.under.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.under.ForeColor = System.Drawing.Color.White;
            this.under.Location = new System.Drawing.Point(30, 28);
            this.under.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.under.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.under.Name = "under";
            this.under.Size = new System.Drawing.Size(120, 21);
            this.under.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(153, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "高度下";
            // 
            // SpreadTeleport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.under);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxRange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spreadDistance);
            this.Controls.Add(this.label1);
            this.Name = "SpreadTeleport";
            this.Size = new System.Drawing.Size(333, 47);
            ((System.ComponentModel.ISupportInitialize)(this.spreadDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.under)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown spreadDistance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown maxRange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown under;
        private System.Windows.Forms.Label label4;
    }
}
