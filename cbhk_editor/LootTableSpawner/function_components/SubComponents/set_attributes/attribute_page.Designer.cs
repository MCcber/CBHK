
namespace cbhk_editor.LootTableSpawner.function_components.SubComponents.set_attributes
{
    partial class attribute_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(attribute_page));
            this.attribute_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.slot_box = new System.Windows.Forms.ComboBox();
            this.operation_box = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id_box = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.min_value_box = new System.Windows.Forms.TextBox();
            this.max_value_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.add_slot = new System.Windows.Forms.Button();
            this.attribute_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // attribute_tab
            // 
            this.attribute_tab.Controls.Add(this.tabPage1);
            this.attribute_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attribute_tab.ItemSize = new System.Drawing.Size(15, 15);
            this.attribute_tab.Location = new System.Drawing.Point(0, 0);
            this.attribute_tab.Name = "attribute_tab";
            this.attribute_tab.SelectedIndex = 0;
            this.attribute_tab.Size = new System.Drawing.Size(387, 164);
            this.attribute_tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.attribute_tab.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage1.Controls.Add(this.table);
            this.tabPage1.Location = new System.Drawing.Point(4, 19);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(379, 141);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1";
            // 
            // table
            // 
            this.table.ColumnCount = 5;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.table.Controls.Add(this.slot_box, 1, 4);
            this.table.Controls.Add(this.operation_box, 1, 2);
            this.table.Controls.Add(this.label3, 0, 2);
            this.table.Controls.Add(this.label1, 0, 0);
            this.table.Controls.Add(this.name_box, 1, 0);
            this.table.Controls.Add(this.label2, 0, 1);
            this.table.Controls.Add(this.id_box, 1, 1);
            this.table.Controls.Add(this.label4, 0, 3);
            this.table.Controls.Add(this.label5, 1, 3);
            this.table.Controls.Add(this.label6, 3, 3);
            this.table.Controls.Add(this.min_value_box, 2, 3);
            this.table.Controls.Add(this.max_value_box, 4, 3);
            this.table.Controls.Add(this.label7, 0, 4);
            this.table.Controls.Add(this.add_slot, 3, 4);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.ForeColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(3, 3);
            this.table.Name = "table";
            this.table.RowCount = 6;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.table.Size = new System.Drawing.Size(373, 135);
            this.table.TabIndex = 0;
            // 
            // slot_box
            // 
            this.slot_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.SetColumnSpan(this.slot_box, 2);
            this.slot_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slot_box.ForeColor = System.Drawing.Color.White;
            this.slot_box.FormattingEnabled = true;
            this.slot_box.Items.AddRange(new object[] {
            "mainhand",
            "offhand",
            "feet",
            "legs",
            "chest",
            "head"});
            this.slot_box.Location = new System.Drawing.Point(68, 111);
            this.slot_box.Name = "slot_box";
            this.slot_box.Size = new System.Drawing.Size(149, 20);
            this.slot_box.TabIndex = 12;
            this.slot_box.SelectedIndexChanged += new System.EventHandler(this.slot_box_SelectedIndexChanged);
            // 
            // operation_box
            // 
            this.operation_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.SetColumnSpan(this.operation_box, 4);
            this.operation_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operation_box.ForeColor = System.Drawing.Color.White;
            this.operation_box.FormattingEnabled = true;
            this.operation_box.Items.AddRange(new object[] {
            "addition",
            "multiply_base",
            "multiply_total"});
            this.operation_box.Location = new System.Drawing.Point(68, 57);
            this.operation_box.Name = "operation_box";
            this.operation_box.Size = new System.Drawing.Size(302, 20);
            this.operation_box.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "数值模式:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "属性名:";
            // 
            // name_box
            // 
            this.name_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.SetColumnSpan(this.name_box, 4);
            this.name_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_box.ForeColor = System.Drawing.Color.White;
            this.name_box.Location = new System.Drawing.Point(68, 3);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(302, 21);
            this.name_box.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "属性ID:";
            // 
            // id_box
            // 
            this.id_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.SetColumnSpan(this.id_box, 4);
            this.id_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.id_box.ForeColor = System.Drawing.Color.White;
            this.id_box.FormattingEnabled = true;
            this.id_box.Location = new System.Drawing.Point(68, 30);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(302, 20);
            this.id_box.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "数值:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "最小值:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "最大值:";
            // 
            // min_value_box
            // 
            this.min_value_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.min_value_box.ForeColor = System.Drawing.Color.White;
            this.min_value_box.Location = new System.Drawing.Point(121, 83);
            this.min_value_box.Name = "min_value_box";
            this.min_value_box.Size = new System.Drawing.Size(96, 21);
            this.min_value_box.TabIndex = 9;
            // 
            // max_value_box
            // 
            this.max_value_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.max_value_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.max_value_box.ForeColor = System.Drawing.Color.White;
            this.max_value_box.Location = new System.Drawing.Point(277, 83);
            this.max_value_box.Name = "max_value_box";
            this.max_value_box.Size = new System.Drawing.Size(93, 21);
            this.max_value_box.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "生效槽位:";
            // 
            // add_slot
            // 
            this.add_slot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_slot.BackgroundImage")));
            this.add_slot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table.SetColumnSpan(this.add_slot, 2);
            this.add_slot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_slot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_slot.FlatAppearance.BorderSize = 0;
            this.add_slot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.add_slot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.add_slot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_slot.Location = new System.Drawing.Point(223, 111);
            this.add_slot.Name = "add_slot";
            this.add_slot.Size = new System.Drawing.Size(147, 23);
            this.add_slot.TabIndex = 13;
            this.add_slot.Text = "添加";
            this.add_slot.UseVisualStyleBackColor = true;
            this.add_slot.Click += new System.EventHandler(this.add_slot_Click);
            // 
            // attribute_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.attribute_tab);
            this.Name = "attribute_page";
            this.Size = new System.Drawing.Size(387, 164);
            this.attribute_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.ComboBox slot_box;
        private System.Windows.Forms.ComboBox operation_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox id_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox min_value_box;
        private System.Windows.Forms.TextBox max_value_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button add_slot;
        public System.Windows.Forms.TabControl attribute_tab;
    }
}
