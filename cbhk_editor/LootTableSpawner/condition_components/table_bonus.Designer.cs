
namespace cbhk_editor.LootTableSpawner.condition_components
{
    partial class table_bonus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(table_bonus));
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.enchant_id = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chance_box = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 3;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 317F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.table.Controls.Add(this.label1, 0, 0);
            this.table.Controls.Add(this.enchant_id, 1, 0);
            this.table.Controls.Add(this.label2, 0, 1);
            this.table.Controls.Add(this.chance_box, 1, 1);
            this.table.Controls.Add(this.add, 2, 1);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.ForeColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 2;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.table.Size = new System.Drawing.Size(444, 243);
            this.table.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "附魔ID:";
            // 
            // enchant_id
            // 
            this.enchant_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.enchant_id.ForeColor = System.Drawing.Color.White;
            this.enchant_id.FormattingEnabled = true;
            this.enchant_id.Location = new System.Drawing.Point(68, 3);
            this.enchant_id.Name = "enchant_id";
            this.enchant_id.Size = new System.Drawing.Size(311, 20);
            this.enchant_id.TabIndex = 1;
            this.enchant_id.SelectedIndexChanged += new System.EventHandler(this.enchant_id_SelectedIndexChanged);
            this.enchant_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enchant_id_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "附魔概率:";
            // 
            // chance_box
            // 
            this.chance_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.chance_box.ForeColor = System.Drawing.Color.White;
            this.chance_box.FormattingEnabled = true;
            this.chance_box.Location = new System.Drawing.Point(68, 29);
            this.chance_box.Name = "chance_box";
            this.chance_box.Size = new System.Drawing.Size(311, 20);
            this.chance_box.TabIndex = 3;
            this.chance_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chance_box_KeyPress);
            // 
            // add
            // 
            this.add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add.BackgroundImage")));
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.Location = new System.Drawing.Point(385, 29);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(56, 23);
            this.add.TabIndex = 4;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // table_bonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.Name = "table_bonus";
            this.Size = new System.Drawing.Size(444, 243);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox enchant_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox chance_box;
        private System.Windows.Forms.Button add;
    }
}
