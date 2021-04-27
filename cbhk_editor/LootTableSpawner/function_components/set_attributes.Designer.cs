
namespace cbhk_editor.LootTableSpawner.function_components
{
    partial class set_attributes
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
            this.set_attribute_btn = new System.Windows.Forms.Button();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 1;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.table.Controls.Add(this.set_attribute_btn, 0, 0);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.ForeColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.Size = new System.Drawing.Size(559, 326);
            this.table.TabIndex = 0;
            // 
            // set_attribute_btn
            // 
            this.set_attribute_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.set_attribute_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_attribute_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_attribute_btn.FlatAppearance.BorderSize = 0;
            this.set_attribute_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_attribute_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_attribute_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_attribute_btn.Location = new System.Drawing.Point(3, 3);
            this.set_attribute_btn.Name = "set_attribute_btn";
            this.set_attribute_btn.Size = new System.Drawing.Size(553, 320);
            this.set_attribute_btn.TabIndex = 0;
            this.set_attribute_btn.Text = "设置属性";
            this.set_attribute_btn.UseVisualStyleBackColor = false;
            this.set_attribute_btn.Click += new System.EventHandler(this.set_attribute_btn_Click);
            // 
            // set_attributes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.Name = "set_attributes";
            this.Size = new System.Drawing.Size(559, 326);
            this.table.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel table;
        public System.Windows.Forms.Button set_attribute_btn;
    }
}
