
namespace cbhk_editor.LootTableSpawner.function_components
{
    partial class set_contents
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
            this.content_area = new System.Windows.Forms.GroupBox();
            this.content_box = new System.Windows.Forms.TextBox();
            this.table.SuspendLayout();
            this.content_area.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 1;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.table.Controls.Add(this.content_area, 0, 0);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.ForeColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.table.Size = new System.Drawing.Size(553, 320);
            this.table.TabIndex = 0;
            // 
            // content_area
            // 
            this.content_area.Controls.Add(this.content_box);
            this.content_area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_area.ForeColor = System.Drawing.Color.White;
            this.content_area.Location = new System.Drawing.Point(3, 3);
            this.content_area.Name = "content_area";
            this.content_area.Size = new System.Drawing.Size(547, 314);
            this.content_area.TabIndex = 0;
            this.content_area.TabStop = false;
            this.content_area.Text = "容器内容";
            // 
            // content_box
            // 
            this.content_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.content_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.content_box.Location = new System.Drawing.Point(3, 17);
            this.content_box.Multiline = true;
            this.content_box.Name = "content_box";
            this.content_box.Size = new System.Drawing.Size(541, 294);
            this.content_box.TabIndex = 0;
            this.content_box.Text = "格式:{...},{...}";
            this.content_box.TextChanged += new System.EventHandler(this.content_box_TextChanged);
            // 
            // set_contents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.Name = "set_contents";
            this.Size = new System.Drawing.Size(553, 320);
            this.table.ResumeLayout(false);
            this.content_area.ResumeLayout(false);
            this.content_area.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox content_area;
        private System.Windows.Forms.TextBox content_box;
        public System.Windows.Forms.TableLayoutPanel table;
    }
}
