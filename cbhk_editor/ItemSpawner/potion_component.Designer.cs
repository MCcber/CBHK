
namespace cbhk_editor.ItemSpawner
{
    partial class potion_component
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
            this.item_potion_tab = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.potioin_second = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.potion_amplifier = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.potion_id = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.item_potion_tab.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.potioin_second)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potion_amplifier)).BeginInit();
            this.SuspendLayout();
            // 
            // item_potion_tab
            // 
            this.item_potion_tab.Controls.Add(this.tabPage4);
            this.item_potion_tab.Enabled = false;
            this.item_potion_tab.Location = new System.Drawing.Point(0, 0);
            this.item_potion_tab.Name = "item_potion_tab";
            this.item_potion_tab.SelectedIndex = 0;
            this.item_potion_tab.Size = new System.Drawing.Size(571, 47);
            this.item_potion_tab.TabIndex = 20;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage4.Controls.Add(this.potioin_second);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.potion_amplifier);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.potion_id);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(563, 21);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "第1个药水效果";
            // 
            // potioin_second
            // 
            this.potioin_second.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.potioin_second.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.potioin_second.ForeColor = System.Drawing.Color.White;
            this.potioin_second.Location = new System.Drawing.Point(194, 4);
            this.potioin_second.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.potioin_second.Name = "potioin_second";
            this.potioin_second.Size = new System.Drawing.Size(59, 17);
            this.potioin_second.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(151, 5);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 12);
            this.label19.TabIndex = 4;
            this.label19.Text = "second:";
            // 
            // potion_amplifier
            // 
            this.potion_amplifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.potion_amplifier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.potion_amplifier.ForeColor = System.Drawing.Color.White;
            this.potion_amplifier.Location = new System.Drawing.Point(318, 4);
            this.potion_amplifier.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.potion_amplifier.Name = "potion_amplifier";
            this.potion_amplifier.Size = new System.Drawing.Size(59, 17);
            this.potion_amplifier.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(253, 4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 2;
            this.label18.Text = "amplifier:";
            // 
            // potion_id
            // 
            this.potion_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.potion_id.ForeColor = System.Drawing.Color.White;
            this.potion_id.FormattingEnabled = true;
            this.potion_id.Location = new System.Drawing.Point(26, 1);
            this.potion_id.Name = "potion_id";
            this.potion_id.Size = new System.Drawing.Size(121, 20);
            this.potion_id.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(6, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "id:";
            // 
            // potion_component
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.item_potion_tab);
            this.Name = "potion_component";
            this.Size = new System.Drawing.Size(572, 48);
            this.item_potion_tab.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.potioin_second)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potion_amplifier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.NumericUpDown potioin_second;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown potion_amplifier;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox potion_id;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TabControl item_potion_tab;
    }
}
