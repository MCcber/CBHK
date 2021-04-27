
namespace cbhk_editor.LootTableSpawner.condition_components
{
    partial class location_check
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
            this.offsetZ = new System.Windows.Forms.TextBox();
            this.offsetY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.set_location_check = new System.Windows.Forms.Button();
            this.offsetX = new System.Windows.Forms.TextBox();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 384F));
            this.table.Controls.Add(this.offsetZ, 1, 2);
            this.table.Controls.Add(this.offsetY, 1, 1);
            this.table.Controls.Add(this.label2, 0, 1);
            this.table.Controls.Add(this.label1, 0, 0);
            this.table.Controls.Add(this.label3, 0, 2);
            this.table.Controls.Add(this.set_location_check, 0, 3);
            this.table.Controls.Add(this.offsetX, 1, 0);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 5;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.table.Size = new System.Drawing.Size(444, 243);
            this.table.TabIndex = 0;
            // 
            // offsetZ
            // 
            this.offsetZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.offsetZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.offsetZ.ForeColor = System.Drawing.Color.White;
            this.offsetZ.Location = new System.Drawing.Point(63, 57);
            this.offsetZ.Name = "offsetZ";
            this.offsetZ.Size = new System.Drawing.Size(378, 21);
            this.offsetZ.TabIndex = 9;
            // 
            // offsetY
            // 
            this.offsetY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.offsetY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.offsetY.ForeColor = System.Drawing.Color.White;
            this.offsetY.Location = new System.Drawing.Point(63, 31);
            this.offsetY.Name = "offsetY";
            this.offsetY.Size = new System.Drawing.Size(378, 21);
            this.offsetY.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "offsetY:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "offsetX:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "offsetZ:";
            // 
            // set_location_check
            // 
            this.set_location_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.SetColumnSpan(this.set_location_check, 2);
            this.set_location_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_location_check.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_location_check.FlatAppearance.BorderSize = 0;
            this.set_location_check.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_location_check.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_location_check.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.set_location_check.Location = new System.Drawing.Point(3, 88);
            this.set_location_check.Name = "set_location_check";
            this.table.SetRowSpan(this.set_location_check, 2);
            this.set_location_check.Size = new System.Drawing.Size(438, 152);
            this.set_location_check.TabIndex = 6;
            this.set_location_check.Text = "设置位置谓词";
            this.set_location_check.UseVisualStyleBackColor = false;
            this.set_location_check.Click += new System.EventHandler(this.set_location_check_Click);
            // 
            // offsetX
            // 
            this.offsetX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.offsetX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.offsetX.ForeColor = System.Drawing.Color.White;
            this.offsetX.Location = new System.Drawing.Point(63, 3);
            this.offsetX.Name = "offsetX";
            this.offsetX.Size = new System.Drawing.Size(378, 21);
            this.offsetX.TabIndex = 7;
            // 
            // location_check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.table);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "location_check";
            this.Size = new System.Drawing.Size(444, 243);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button set_location_check;
        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.TextBox offsetZ;
        private System.Windows.Forms.TextBox offsetY;
        private System.Windows.Forms.TextBox offsetX;
    }
}
