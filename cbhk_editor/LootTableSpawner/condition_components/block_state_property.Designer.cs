
namespace cbhk_editor.LootTableSpawner.condition_components
{
    partial class block_state_property
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(block_state_property));
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.property_box = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.block_id = new System.Windows.Forms.ComboBox();
            this.update = new System.Windows.Forms.Button();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 362F));
            this.table.Controls.Add(this.property_box, 1, 1);
            this.table.Controls.Add(this.label1, 0, 0);
            this.table.Controls.Add(this.block_id, 1, 0);
            this.table.Controls.Add(this.update, 0, 1);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.ForeColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 2;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.table.Size = new System.Drawing.Size(444, 243);
            this.table.TabIndex = 0;
            // 
            // property_box
            // 
            this.property_box.AutoScroll = true;
            this.property_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.property_box.Location = new System.Drawing.Point(85, 26);
            this.property_box.Name = "property_box";
            this.property_box.Size = new System.Drawing.Size(356, 214);
            this.property_box.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // block_id
            // 
            this.block_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.block_id.ForeColor = System.Drawing.Color.White;
            this.block_id.FormattingEnabled = true;
            this.block_id.Location = new System.Drawing.Point(85, 3);
            this.block_id.Name = "block_id";
            this.block_id.Size = new System.Drawing.Size(356, 20);
            this.block_id.TabIndex = 2;
            this.block_id.TextChanged += new System.EventHandler(this.block_id_TextChanged);
            this.block_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.block_id_KeyDown);
            // 
            // update
            // 
            this.update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update.BackgroundImage")));
            this.update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Location = new System.Drawing.Point(3, 26);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 4;
            this.update.Text = "更新属性";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // block_state_property
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.Name = "block_state_property";
            this.Size = new System.Drawing.Size(444, 243);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox block_id;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Panel property_box;
        public System.Windows.Forms.TableLayoutPanel table;
    }
}
