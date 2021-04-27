
namespace cbhk_editor.EntitySpawner
{
    partial class entity_potion
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.amplifier_box = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.duration_box = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.effect_id_box = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.effect_tab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amplifier_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duration_box)).BeginInit();
            this.SuspendLayout();
            // 
            // effect_tab
            // 
            this.effect_tab.Controls.Add(this.tabPage2);
            this.effect_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.effect_tab.Location = new System.Drawing.Point(0, 0);
            this.effect_tab.Name = "effect_tab";
            this.effect_tab.SelectedIndex = 0;
            this.effect_tab.Size = new System.Drawing.Size(458, 56);
            this.effect_tab.TabIndex = 36;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage2.Controls.Add(this.amplifier_box);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.duration_box);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.effect_id_box);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(450, 30);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "第1项";
            // 
            // amplifier_box
            // 
            this.amplifier_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.amplifier_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.amplifier_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amplifier_box.ForeColor = System.Drawing.Color.White;
            this.amplifier_box.Location = new System.Drawing.Point(349, 7);
            this.amplifier_box.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.amplifier_box.Name = "amplifier_box";
            this.amplifier_box.Size = new System.Drawing.Size(51, 17);
            this.amplifier_box.TabIndex = 35;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(287, 7);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 34;
            this.label19.Text = "amplifier:";
            // 
            // duration_box
            // 
            this.duration_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.duration_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.duration_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.duration_box.ForeColor = System.Drawing.Color.White;
            this.duration_box.Location = new System.Drawing.Point(224, 7);
            this.duration_box.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.duration_box.Name = "duration_box";
            this.duration_box.Size = new System.Drawing.Size(51, 17);
            this.duration_box.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(168, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 12);
            this.label18.TabIndex = 3;
            this.label18.Text = "duration:";
            // 
            // effect_id_box
            // 
            this.effect_id_box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.effect_id_box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.effect_id_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.effect_id_box.ForeColor = System.Drawing.Color.White;
            this.effect_id_box.FormattingEnabled = true;
            this.effect_id_box.Location = new System.Drawing.Point(23, 4);
            this.effect_id_box.Name = "effect_id_box";
            this.effect_id_box.Size = new System.Drawing.Size(139, 20);
            this.effect_id_box.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "ID:";
            // 
            // entity_potion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.effect_tab);
            this.Name = "entity_potion";
            this.Size = new System.Drawing.Size(458, 56);
            this.effect_tab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amplifier_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duration_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown amplifier_box;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown duration_box;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox effect_id_box;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TabControl effect_tab;
    }
}
