
namespace cbhk_editor.LootTableSpawner.function_components.SubComponents.set_lore
{
    partial class set_lore_page
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
            this.lore_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lore_text_box = new System.Windows.Forms.TextBox();
            this.font_property_box = new System.Windows.Forms.CheckedListBox();
            this.font_color_box = new System.Windows.Forms.CheckedListBox();
            this.lore_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // lore_tab
            // 
            this.lore_tab.Controls.Add(this.tabPage1);
            this.lore_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lore_tab.ItemSize = new System.Drawing.Size(15, 15);
            this.lore_tab.Location = new System.Drawing.Point(0, 0);
            this.lore_tab.Name = "lore_tab";
            this.lore_tab.SelectedIndex = 0;
            this.lore_tab.Size = new System.Drawing.Size(535, 263);
            this.lore_tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.lore_tab.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage1.Controls.Add(this.table);
            this.tabPage1.Location = new System.Drawing.Point(4, 19);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(527, 240);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1";
            // 
            // table
            // 
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 255F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.table.Controls.Add(this.label1, 0, 0);
            this.table.Controls.Add(this.lore_text_box, 1, 0);
            this.table.Controls.Add(this.font_property_box, 0, 1);
            this.table.Controls.Add(this.font_color_box, 1, 1);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.ForeColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(3, 3);
            this.table.Name = "table";
            this.table.RowCount = 2;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.table.Size = new System.Drawing.Size(521, 234);
            this.table.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "描述文本:";
            // 
            // lore_text_box
            // 
            this.lore_text_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lore_text_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lore_text_box.ForeColor = System.Drawing.Color.White;
            this.lore_text_box.Location = new System.Drawing.Point(258, 3);
            this.lore_text_box.Name = "lore_text_box";
            this.lore_text_box.Size = new System.Drawing.Size(260, 21);
            this.lore_text_box.TabIndex = 5;
            // 
            // font_property_box
            // 
            this.font_property_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.font_property_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.font_property_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.font_property_box.ForeColor = System.Drawing.Color.White;
            this.font_property_box.FormattingEnabled = true;
            this.font_property_box.Items.AddRange(new object[] {
            "Bold",
            "Italic",
            "underlined",
            "strikethrough",
            "obfuscated"});
            this.font_property_box.Location = new System.Drawing.Point(3, 29);
            this.font_property_box.Name = "font_property_box";
            this.font_property_box.Size = new System.Drawing.Size(249, 202);
            this.font_property_box.TabIndex = 6;
            // 
            // font_color_box
            // 
            this.font_color_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.font_color_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.font_color_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.font_color_box.ForeColor = System.Drawing.Color.White;
            this.font_color_box.FormattingEnabled = true;
            this.font_color_box.Items.AddRange(new object[] {
            "aqua",
            "black",
            "blue",
            "dark_aqua",
            "dark_blue",
            "dark_gray",
            "dark_green",
            "dark_purple",
            "dark_red",
            "gold",
            "gray",
            "green",
            "light_purple",
            "red",
            "white",
            "yellow"});
            this.font_color_box.Location = new System.Drawing.Point(258, 29);
            this.font_color_box.Name = "font_color_box";
            this.font_color_box.Size = new System.Drawing.Size(260, 202);
            this.font_color_box.TabIndex = 7;
            this.font_color_box.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.font_color_box_ItemCheck);
            // 
            // set_lore_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lore_tab);
            this.Name = "set_lore_page";
            this.Size = new System.Drawing.Size(535, 263);
            this.lore_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabControl lore_tab;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lore_text_box;
        public System.Windows.Forms.CheckedListBox font_property_box;
        public System.Windows.Forms.CheckedListBox font_color_box;
    }
}
