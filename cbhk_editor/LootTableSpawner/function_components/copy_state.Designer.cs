
namespace cbhk_editor.LootTableSpawner.function_components
{
    partial class copy_state
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
            this.block_id_box = new System.Windows.Forms.ComboBox();
            this.property_list_box = new System.Windows.Forms.CheckedListBox();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 417F));
            this.table.Controls.Add(this.label1, 0, 0);
            this.table.Controls.Add(this.block_id_box, 1, 0);
            this.table.Controls.Add(this.property_list_box, 0, 1);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.ForeColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 2;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.table.Size = new System.Drawing.Size(471, 186);
            this.table.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "方块ID:";
            // 
            // block_id_box
            // 
            this.block_id_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.block_id_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.block_id_box.ForeColor = System.Drawing.Color.White;
            this.block_id_box.FormattingEnabled = true;
            this.block_id_box.Location = new System.Drawing.Point(57, 3);
            this.block_id_box.Name = "block_id_box";
            this.block_id_box.Size = new System.Drawing.Size(411, 20);
            this.block_id_box.TabIndex = 1;
            this.block_id_box.TextChanged += new System.EventHandler(this.block_id_box_TextChanged);
            // 
            // property_list_box
            // 
            this.property_list_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.SetColumnSpan(this.property_list_box, 2);
            this.property_list_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.property_list_box.ForeColor = System.Drawing.Color.White;
            this.property_list_box.FormattingEnabled = true;
            this.property_list_box.Location = new System.Drawing.Point(3, 31);
            this.property_list_box.Name = "property_list_box";
            this.property_list_box.Size = new System.Drawing.Size(465, 152);
            this.property_list_box.TabIndex = 2;
            this.property_list_box.SelectedIndexChanged += new System.EventHandler(this.property_list_box_SelectedIndexChanged);
            // 
            // copy_state
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.Name = "copy_state";
            this.Size = new System.Drawing.Size(471, 186);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox block_id_box;
        private System.Windows.Forms.CheckedListBox property_list_box;
        public System.Windows.Forms.TableLayoutPanel table;
    }
}
