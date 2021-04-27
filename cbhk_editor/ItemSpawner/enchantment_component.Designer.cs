
namespace cbhk_editor.ItemSpawner
{
    partial class enchantment_component
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
            this.item_enchantment_tab = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.enchantment_level = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.enchantment_id = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.item_enchantment_tab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enchantment_level)).BeginInit();
            this.SuspendLayout();
            // 
            // item_enchantment_tab
            // 
            this.item_enchantment_tab.Controls.Add(this.tabPage2);
            this.item_enchantment_tab.Location = new System.Drawing.Point(0, 0);
            this.item_enchantment_tab.Name = "item_enchantment_tab";
            this.item_enchantment_tab.SelectedIndex = 0;
            this.item_enchantment_tab.Size = new System.Drawing.Size(571, 52);
            this.item_enchantment_tab.TabIndex = 18;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage2.Controls.Add(this.enchantment_level);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.enchantment_id);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(563, 26);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "第1个附魔";
            // 
            // enchantment_level
            // 
            this.enchantment_level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.enchantment_level.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enchantment_level.Dock = System.Windows.Forms.DockStyle.Left;
            this.enchantment_level.ForeColor = System.Drawing.Color.White;
            this.enchantment_level.Location = new System.Drawing.Point(188, 3);
            this.enchantment_level.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.enchantment_level.Name = "enchantment_level";
            this.enchantment_level.Size = new System.Drawing.Size(120, 17);
            this.enchantment_level.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(147, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "level:";
            // 
            // enchantment_id
            // 
            this.enchantment_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.enchantment_id.Dock = System.Windows.Forms.DockStyle.Left;
            this.enchantment_id.ForeColor = System.Drawing.Color.White;
            this.enchantment_id.FormattingEnabled = true;
            this.enchantment_id.Location = new System.Drawing.Point(26, 3);
            this.enchantment_id.Name = "enchantment_id";
            this.enchantment_id.Size = new System.Drawing.Size(121, 20);
            this.enchantment_id.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "id:";
            // 
            // enchantment_component
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.item_enchantment_tab);
            this.Name = "enchantment_component";
            this.Size = new System.Drawing.Size(572, 52);
            this.item_enchantment_tab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enchantment_level)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown enchantment_level;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox enchantment_id;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TabControl item_enchantment_tab;
    }
}
