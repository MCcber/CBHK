
namespace cbhk_editor.LootTableSpawner.function_components
{
    partial class set_loot_table
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
            this.lt_seed_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lt_id_box = new System.Windows.Forms.TextBox();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 479F));
            this.table.Controls.Add(this.lt_seed_box, 1, 1);
            this.table.Controls.Add(this.label2, 0, 1);
            this.table.Controls.Add(this.label1, 0, 0);
            this.table.Controls.Add(this.lt_id_box, 1, 0);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 3;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.table.Size = new System.Drawing.Size(559, 326);
            this.table.TabIndex = 0;
            // 
            // lt_seed_box
            // 
            this.lt_seed_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lt_seed_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lt_seed_box.ForeColor = System.Drawing.Color.White;
            this.lt_seed_box.Location = new System.Drawing.Point(83, 32);
            this.lt_seed_box.Name = "lt_seed_box";
            this.lt_seed_box.Size = new System.Drawing.Size(473, 21);
            this.lt_seed_box.TabIndex = 3;
            this.lt_seed_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lt_seed_box_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "种子:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "战利品表ID:";
            // 
            // lt_id_box
            // 
            this.lt_id_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lt_id_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lt_id_box.ForeColor = System.Drawing.Color.White;
            this.lt_id_box.Location = new System.Drawing.Point(83, 3);
            this.lt_id_box.Name = "lt_id_box";
            this.lt_id_box.Size = new System.Drawing.Size(473, 21);
            this.lt_id_box.TabIndex = 1;
            // 
            // set_loot_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.table);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "set_loot_table";
            this.Size = new System.Drawing.Size(559, 326);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lt_id_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lt_seed_box;
    }
}
