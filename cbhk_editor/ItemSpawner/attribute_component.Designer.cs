
namespace cbhk_editor.ItemSpawner
{
    partial class attribute_component
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
            this.item_attribute_tab = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.attribute_slot = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.attribute_operation = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.attribute_value = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.attribute_name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.attribute_id = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.item_attribute_tab.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // item_attribute_tab
            // 
            this.item_attribute_tab.Controls.Add(this.tabPage3);
            this.item_attribute_tab.Location = new System.Drawing.Point(0, 0);
            this.item_attribute_tab.Name = "item_attribute_tab";
            this.item_attribute_tab.SelectedIndex = 0;
            this.item_attribute_tab.Size = new System.Drawing.Size(571, 92);
            this.item_attribute_tab.TabIndex = 19;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage3.Controls.Add(this.attribute_slot);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.attribute_operation);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.attribute_value);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.attribute_name);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.attribute_id);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(563, 66);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "第1个属性";
            // 
            // attribute_slot
            // 
            this.attribute_slot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.attribute_slot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.attribute_slot.ForeColor = System.Drawing.Color.White;
            this.attribute_slot.FormattingEnabled = true;
            this.attribute_slot.Items.AddRange(new object[] {
            "全部",
            "主手mainhand",
            "副手offhand",
            "头部head",
            "胸部chest",
            "腿部legs",
            "脚部feet"});
            this.attribute_slot.Location = new System.Drawing.Point(44, 32);
            this.attribute_slot.Name = "attribute_slot";
            this.attribute_slot.Size = new System.Drawing.Size(121, 20);
            this.attribute_slot.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 12);
            this.label14.TabIndex = 8;
            this.label14.Text = "Slot:";
            // 
            // attribute_operation
            // 
            this.attribute_operation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.attribute_operation.Dock = System.Windows.Forms.DockStyle.Left;
            this.attribute_operation.ForeColor = System.Drawing.Color.White;
            this.attribute_operation.FormattingEnabled = true;
            this.attribute_operation.Items.AddRange(new object[] {
            "numerical value",
            "percentage"});
            this.attribute_operation.Location = new System.Drawing.Point(488, 3);
            this.attribute_operation.Name = "attribute_operation";
            this.attribute_operation.Size = new System.Drawing.Size(72, 20);
            this.attribute_operation.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Left;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(423, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 6;
            this.label13.Text = "Operation:";
            // 
            // attribute_value
            // 
            this.attribute_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.attribute_value.Dock = System.Windows.Forms.DockStyle.Left;
            this.attribute_value.ForeColor = System.Drawing.Color.White;
            this.attribute_value.Location = new System.Drawing.Point(323, 3);
            this.attribute_value.Name = "attribute_value";
            this.attribute_value.Size = new System.Drawing.Size(100, 21);
            this.attribute_value.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(282, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "Value:";
            // 
            // attribute_name
            // 
            this.attribute_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.attribute_name.Dock = System.Windows.Forms.DockStyle.Left;
            this.attribute_name.ForeColor = System.Drawing.Color.White;
            this.attribute_name.Location = new System.Drawing.Point(182, 3);
            this.attribute_name.Name = "attribute_name";
            this.attribute_name.Size = new System.Drawing.Size(100, 21);
            this.attribute_name.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Left;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(147, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "Name:";
            // 
            // attribute_id
            // 
            this.attribute_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.attribute_id.Dock = System.Windows.Forms.DockStyle.Left;
            this.attribute_id.ForeColor = System.Drawing.Color.White;
            this.attribute_id.FormattingEnabled = true;
            this.attribute_id.Location = new System.Drawing.Point(26, 3);
            this.attribute_id.Name = "attribute_id";
            this.attribute_id.Size = new System.Drawing.Size(121, 20);
            this.attribute_id.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "id:";
            // 
            // attribute_component
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.item_attribute_tab);
            this.Name = "attribute_component";
            this.Size = new System.Drawing.Size(572, 93);
            this.item_attribute_tab.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox attribute_slot;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox attribute_operation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox attribute_value;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox attribute_name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox attribute_id;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TabControl item_attribute_tab;
    }
}
