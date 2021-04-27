
namespace cbhk_editor.LootTableSpawner.function_components
{
    partial class set_count
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
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.min_value_box = new System.Windows.Forms.NumericUpDown();
            this.max_value_box = new System.Windows.Forms.NumericUpDown();
            this.table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min_value_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_value_box)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 5;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.table.Controls.Add(this.label2, 1, 0);
            this.table.Controls.Add(this.label1, 0, 0);
            this.table.Controls.Add(this.label3, 3, 0);
            this.table.Controls.Add(this.min_value_box, 2, 0);
            this.table.Controls.Add(this.max_value_box, 4, 0);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 2;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.table.Size = new System.Drawing.Size(559, 326);
            this.table.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "最小值:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "设置物品堆叠数量:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "最小值:";
            // 
            // min_value_box
            // 
            this.min_value_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.min_value_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.min_value_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.min_value_box.ForeColor = System.Drawing.Color.White;
            this.min_value_box.Location = new System.Drawing.Point(171, 6);
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
            this.min_value_box.Size = new System.Drawing.Size(120, 17);
            this.min_value_box.TabIndex = 3;
            this.min_value_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // max_value_box
            // 
            this.max_value_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.max_value_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.max_value_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.max_value_box.ForeColor = System.Drawing.Color.White;
            this.max_value_box.Location = new System.Drawing.Point(354, 6);
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
            this.max_value_box.Size = new System.Drawing.Size(120, 17);
            this.max_value_box.TabIndex = 4;
            this.max_value_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // set_count
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "set_count";
            this.Size = new System.Drawing.Size(559, 326);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min_value_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_value_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown min_value_box;
        private System.Windows.Forms.NumericUpDown max_value_box;
        public System.Windows.Forms.TableLayoutPanel table;
    }
}
