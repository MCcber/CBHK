
namespace cbhk_editor.LootTableSpawner.condition_components
{
    partial class time_check
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
            this.label1 = new System.Windows.Forms.Label();
            this.time_value_box = new System.Windows.Forms.NumericUpDown();
            this.table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.time_value_box)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.432433F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.56757F));
            this.table.Controls.Add(this.label1, 0, 0);
            this.table.Controls.Add(this.time_value_box, 1, 0);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.Size = new System.Drawing.Size(444, 243);
            this.table.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "值:";
            // 
            // time_value_box
            // 
            this.time_value_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.time_value_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.time_value_box.ForeColor = System.Drawing.Color.White;
            this.time_value_box.Location = new System.Drawing.Point(36, 111);
            this.time_value_box.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.time_value_box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.time_value_box.Name = "time_value_box";
            this.time_value_box.Size = new System.Drawing.Size(405, 21);
            this.time_value_box.TabIndex = 1;
            this.time_value_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.time_value_box.ValueChanged += new System.EventHandler(this.time_value_box_ValueChanged);
            // 
            // time_check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.table);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "time_check";
            this.Size = new System.Drawing.Size(444, 243);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.time_value_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown time_value_box;
    }
}
