
namespace cbhk_editor.SkillSpawner.EventsCompnents
{
    partial class GetEffect
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
            this.effect_id = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.second)).BeginInit();
            this.SuspendLayout();
            // 
            // effect_id
            // 
            this.effect_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.effect_id.ForeColor = System.Drawing.Color.White;
            this.effect_id.FormattingEnabled = true;
            this.effect_id.Location = new System.Drawing.Point(0, 0);
            this.effect_id.Name = "effect_id";
            this.effect_id.Size = new System.Drawing.Size(139, 20);
            this.effect_id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(142, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "效果";
            // 
            // level
            // 
            this.level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.level.ForeColor = System.Drawing.Color.White;
            this.level.Location = new System.Drawing.Point(234, 1);
            this.level.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(40, 21);
            this.level.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(277, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "级";
            // 
            // second
            // 
            this.second.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.second.ForeColor = System.Drawing.Color.White;
            this.second.Location = new System.Drawing.Point(172, 0);
            this.second.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(42, 21);
            this.second.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(216, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "秒";
            // 
            // GetEffect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.second);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.level);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.effect_id);
            this.Name = "GetEffect";
            this.Size = new System.Drawing.Size(294, 21);
            ((System.ComponentModel.ISupportInitialize)(this.level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.second)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox effect_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown level;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown second;
        private System.Windows.Forms.Label label3;
    }
}
