
namespace cbhk_editor.LootTableSpawner.condition_components
{
    partial class weather_check
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
            this.thundering = new System.Windows.Forms.CheckBox();
            this.raining = new System.Windows.Forms.CheckBox();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.27027F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.72973F));
            this.table.Controls.Add(this.thundering, 1, 0);
            this.table.Controls.Add(this.raining, 0, 0);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.ForeColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.40329F));
            this.table.Size = new System.Drawing.Size(444, 243);
            this.table.TabIndex = 0;
            // 
            // thundering
            // 
            this.thundering.AutoSize = true;
            this.thundering.Location = new System.Drawing.Point(92, 3);
            this.thundering.Name = "thundering";
            this.thundering.Size = new System.Drawing.Size(72, 16);
            this.thundering.TabIndex = 1;
            this.thundering.Text = "是否打雷";
            this.thundering.UseVisualStyleBackColor = true;
            // 
            // raining
            // 
            this.raining.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.raining.AutoSize = true;
            this.raining.Location = new System.Drawing.Point(8, 3);
            this.raining.Name = "raining";
            this.raining.Size = new System.Drawing.Size(72, 16);
            this.raining.TabIndex = 0;
            this.raining.Text = "是否下雨";
            this.raining.UseVisualStyleBackColor = true;
            // 
            // weather_check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.Name = "weather_check";
            this.Size = new System.Drawing.Size(444, 243);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.CheckBox raining;
        private System.Windows.Forms.CheckBox thundering;
    }
}
