
namespace cbhk_editor.LootTableSpawner.condition_components.SubComponents
{
    partial class stats_page
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
            this.stats_tab = new System.Windows.Forms.TabControl();
            this.page = new System.Windows.Forms.TabPage();
            this.max_value_box = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.min_value_box = new System.Windows.Forms.NumericUpDown();
            this.id_box = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.type_box = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.stats_tab.SuspendLayout();
            this.page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_value_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_value_box)).BeginInit();
            this.SuspendLayout();
            // 
            // stats_tab
            // 
            this.stats_tab.Controls.Add(this.page);
            this.stats_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stats_tab.ItemSize = new System.Drawing.Size(15, 18);
            this.stats_tab.Location = new System.Drawing.Point(0, 0);
            this.stats_tab.Name = "stats_tab";
            this.stats_tab.SelectedIndex = 0;
            this.stats_tab.Size = new System.Drawing.Size(630, 52);
            this.stats_tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.stats_tab.TabIndex = 1;
            // 
            // page
            // 
            this.page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.page.Controls.Add(this.max_value_box);
            this.page.Controls.Add(this.label13);
            this.page.Controls.Add(this.label12);
            this.page.Controls.Add(this.min_value_box);
            this.page.Controls.Add(this.id_box);
            this.page.Controls.Add(this.label11);
            this.page.Controls.Add(this.type_box);
            this.page.Controls.Add(this.label10);
            this.page.Location = new System.Drawing.Point(4, 22);
            this.page.Name = "page";
            this.page.Padding = new System.Windows.Forms.Padding(3);
            this.page.Size = new System.Drawing.Size(622, 26);
            this.page.TabIndex = 0;
            this.page.Text = "1";
            // 
            // max_value_box
            // 
            this.max_value_box.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.max_value_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.max_value_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.max_value_box.ForeColor = System.Drawing.Color.White;
            this.max_value_box.Location = new System.Drawing.Point(493, 1);
            this.max_value_box.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.max_value_box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.max_value_box.Name = "max_value_box";
            this.max_value_box.Size = new System.Drawing.Size(128, 21);
            this.max_value_box.TabIndex = 26;
            this.max_value_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(465, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 25;
            this.label13.Text = "max:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(311, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 24;
            this.label12.Text = "min:";
            // 
            // min_value_box
            // 
            this.min_value_box.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.min_value_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.min_value_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.min_value_box.ForeColor = System.Drawing.Color.White;
            this.min_value_box.Location = new System.Drawing.Point(340, 1);
            this.min_value_box.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.min_value_box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.min_value_box.Name = "min_value_box";
            this.min_value_box.Size = new System.Drawing.Size(125, 21);
            this.min_value_box.TabIndex = 23;
            this.min_value_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // id_box
            // 
            this.id_box.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.id_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.id_box.ForeColor = System.Drawing.Color.White;
            this.id_box.Location = new System.Drawing.Point(203, 0);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(109, 21);
            this.id_box.TabIndex = 22;
            this.id_box.TextChanged += new System.EventHandler(this.id_box_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(182, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "ID:";
            // 
            // type_box
            // 
            this.type_box.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.type_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.type_box.ForeColor = System.Drawing.Color.White;
            this.type_box.FormattingEnabled = true;
            this.type_box.Items.AddRange(new object[] {
            "minecraft:custom",
            "minecraft:crafted",
            "minecraft:used",
            "minecraft:broken",
            "minecraft:mined",
            "minecraft:killed",
            "minecraft:picked_up",
            "minecraft:dropped",
            "minecraft:killed_by"});
            this.type_box.Location = new System.Drawing.Point(34, 0);
            this.type_box.Name = "type_box";
            this.type_box.Size = new System.Drawing.Size(143, 20);
            this.type_box.TabIndex = 2;
            this.type_box.SelectedIndexChanged += new System.EventHandler(this.type_box_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "类型:";
            // 
            // stats_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.stats_tab);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "stats_page";
            this.Size = new System.Drawing.Size(630, 52);
            this.stats_tab.ResumeLayout(false);
            this.page.ResumeLayout(false);
            this.page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_value_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_value_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage page;
        private System.Windows.Forms.NumericUpDown max_value_box;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown min_value_box;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox type_box;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TabControl stats_tab;
    }
}
