
namespace cbhk_editor.LootTableSpawner.function_components
{
    partial class exploration_map
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
            this.search_radius_box = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.decoration_box = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.destination_box = new System.Windows.Forms.ComboBox();
            this.zoom_box = new System.Windows.Forms.NumericUpDown();
            this.skip_existing_chunks_box = new System.Windows.Forms.CheckBox();
            this.table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_radius_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoom_box)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 458F));
            this.table.Controls.Add(this.search_radius_box, 1, 3);
            this.table.Controls.Add(this.label4, 0, 3);
            this.table.Controls.Add(this.label3, 0, 2);
            this.table.Controls.Add(this.decoration_box, 1, 1);
            this.table.Controls.Add(this.label2, 0, 1);
            this.table.Controls.Add(this.label1, 0, 0);
            this.table.Controls.Add(this.destination_box, 1, 0);
            this.table.Controls.Add(this.zoom_box, 1, 2);
            this.table.Controls.Add(this.skip_existing_chunks_box, 1, 4);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 6;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.table.Size = new System.Drawing.Size(559, 326);
            this.table.TabIndex = 0;
            // 
            // search_radius_box
            // 
            this.search_radius_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.search_radius_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_radius_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_radius_box.ForeColor = System.Drawing.Color.White;
            this.search_radius_box.Location = new System.Drawing.Point(104, 70);
            this.search_radius_box.Name = "search_radius_box";
            this.search_radius_box.Size = new System.Drawing.Size(452, 17);
            this.search_radius_box.TabIndex = 7;
            this.search_radius_box.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "搜索的区块半径:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "地图缩放等级:";
            // 
            // decoration_box
            // 
            this.decoration_box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.decoration_box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.decoration_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.decoration_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decoration_box.ForeColor = System.Drawing.Color.White;
            this.decoration_box.FormattingEnabled = true;
            this.decoration_box.Location = new System.Drawing.Point(104, 23);
            this.decoration_box.Name = "decoration_box";
            this.decoration_box.Size = new System.Drawing.Size(452, 20);
            this.decoration_box.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "图标:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "结构ID:";
            // 
            // destination_box
            // 
            this.destination_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.destination_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.destination_box.ForeColor = System.Drawing.Color.White;
            this.destination_box.FormattingEnabled = true;
            this.destination_box.Location = new System.Drawing.Point(104, 3);
            this.destination_box.Name = "destination_box";
            this.destination_box.Size = new System.Drawing.Size(452, 20);
            this.destination_box.TabIndex = 1;
            // 
            // zoom_box
            // 
            this.zoom_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.zoom_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zoom_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zoom_box.ForeColor = System.Drawing.Color.White;
            this.zoom_box.Location = new System.Drawing.Point(104, 46);
            this.zoom_box.Name = "zoom_box";
            this.zoom_box.Size = new System.Drawing.Size(452, 17);
            this.zoom_box.TabIndex = 5;
            this.zoom_box.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // skip_existing_chunks_box
            // 
            this.skip_existing_chunks_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.skip_existing_chunks_box.AutoSize = true;
            this.skip_existing_chunks_box.Checked = true;
            this.skip_existing_chunks_box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skip_existing_chunks_box.Location = new System.Drawing.Point(104, 91);
            this.skip_existing_chunks_box.Name = "skip_existing_chunks_box";
            this.skip_existing_chunks_box.Size = new System.Drawing.Size(168, 16);
            this.skip_existing_chunks_box.TabIndex = 8;
            this.skip_existing_chunks_box.Text = "是否不在已生成的区块搜索";
            this.skip_existing_chunks_box.UseVisualStyleBackColor = true;
            // 
            // exploration_map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "exploration_map";
            this.Size = new System.Drawing.Size(559, 326);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_radius_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoom_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox destination_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox decoration_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown zoom_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown search_radius_box;
        private System.Windows.Forms.CheckBox skip_existing_chunks_box;
    }
}
