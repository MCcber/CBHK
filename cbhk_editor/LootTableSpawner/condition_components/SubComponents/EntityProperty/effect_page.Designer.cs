
namespace cbhk_editor.LootTableSpawner.condition_components.SubComponents
{
    partial class effect_page
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
            this.effect_tab = new System.Windows.Forms.TabControl();
            this.page = new System.Windows.Forms.TabPage();
            this.duration_box = new System.Windows.Forms.NumericUpDown();
            this.amplifier_box = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.effect_id_box = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.effect_tab.SuspendLayout();
            this.page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duration_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplifier_box)).BeginInit();
            this.SuspendLayout();
            // 
            // effect_tab
            // 
            this.effect_tab.Controls.Add(this.page);
            this.effect_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.effect_tab.ItemSize = new System.Drawing.Size(15, 15);
            this.effect_tab.Location = new System.Drawing.Point(0, 0);
            this.effect_tab.Name = "effect_tab";
            this.effect_tab.SelectedIndex = 0;
            this.effect_tab.Size = new System.Drawing.Size(163, 85);
            this.effect_tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.effect_tab.TabIndex = 1;
            // 
            // page
            // 
            this.page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.page.Controls.Add(this.duration_box);
            this.page.Controls.Add(this.amplifier_box);
            this.page.Controls.Add(this.label6);
            this.page.Controls.Add(this.label5);
            this.page.Controls.Add(this.effect_id_box);
            this.page.Controls.Add(this.label2);
            this.page.Location = new System.Drawing.Point(4, 19);
            this.page.Name = "page";
            this.page.Padding = new System.Windows.Forms.Padding(3);
            this.page.Size = new System.Drawing.Size(155, 62);
            this.page.TabIndex = 0;
            this.page.Text = "1";
            // 
            // duration_box
            // 
            this.duration_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.duration_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.duration_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.duration_box.ForeColor = System.Drawing.Color.White;
            this.duration_box.Location = new System.Drawing.Point(69, 41);
            this.duration_box.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.duration_box.Name = "duration_box";
            this.duration_box.Size = new System.Drawing.Size(86, 21);
            this.duration_box.TabIndex = 11;
            // 
            // amplifier_box
            // 
            this.amplifier_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.amplifier_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.amplifier_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amplifier_box.ForeColor = System.Drawing.Color.White;
            this.amplifier_box.Location = new System.Drawing.Point(69, 22);
            this.amplifier_box.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.amplifier_box.Name = "amplifier_box";
            this.amplifier_box.Size = new System.Drawing.Size(86, 21);
            this.amplifier_box.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "duration:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "amplifier:";
            // 
            // effect_id_box
            // 
            this.effect_id_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.effect_id_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.effect_id_box.ForeColor = System.Drawing.Color.White;
            this.effect_id_box.FormattingEnabled = true;
            this.effect_id_box.Location = new System.Drawing.Point(25, 0);
            this.effect_id_box.Name = "effect_id_box";
            this.effect_id_box.Size = new System.Drawing.Size(130, 20);
            this.effect_id_box.TabIndex = 7;
            this.effect_id_box.SelectedIndexChanged += new System.EventHandler(this.effect_id_box_SelectedIndexChanged);
            this.effect_id_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.effect_id_box_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID:";
            // 
            // effect_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.effect_tab);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "effect_page";
            this.Size = new System.Drawing.Size(163, 85);
            this.effect_tab.ResumeLayout(false);
            this.page.ResumeLayout(false);
            this.page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duration_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplifier_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage page;
        private System.Windows.Forms.NumericUpDown duration_box;
        private System.Windows.Forms.NumericUpDown amplifier_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox effect_id_box;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TabControl effect_tab;
    }
}
