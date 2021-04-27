
namespace cbhk_editor.WrittrenBookSpawner
{
    partial class page
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
            this.page_tab = new System.Windows.Forms.TabControl();
            this.page_area = new System.Windows.Forms.TabPage();
            this.sentence_page = new System.Windows.Forms.TabControl();
            this.sentence_area = new System.Windows.Forms.TabPage();
            this.sentence_content = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sentence_property_tab = new System.Windows.Forms.TabControl();
            this.font_property = new System.Windows.Forms.TabPage();
            this.font_table = new System.Windows.Forms.TableLayoutPanel();
            this.font_property_box = new System.Windows.Forms.CheckedListBox();
            this.font_color_box = new System.Windows.Forms.CheckedListBox();
            this.click_event_tab = new System.Windows.Forms.TabPage();
            this.page_index = new System.Windows.Forms.NumericUpDown();
            this.change_page = new System.Windows.Forms.RadioButton();
            this.url_box = new System.Windows.Forms.TextBox();
            this.open_url = new System.Windows.Forms.RadioButton();
            this.command_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.run_btn = new System.Windows.Forms.RadioButton();
            this.suggest_btn = new System.Windows.Forms.RadioButton();
            this.hover_event_tab = new System.Windows.Forms.TabPage();
            this.display_box = new System.Windows.Forms.TextBox();
            this.show_entity = new System.Windows.Forms.RadioButton();
            this.show_item = new System.Windows.Forms.RadioButton();
            this.show_text = new System.Windows.Forms.RadioButton();
            this.insert_text_tab = new System.Windows.Forms.TabPage();
            this.insert_box = new System.Windows.Forms.TextBox();
            this.page_tab.SuspendLayout();
            this.page_area.SuspendLayout();
            this.sentence_page.SuspendLayout();
            this.sentence_area.SuspendLayout();
            this.sentence_property_tab.SuspendLayout();
            this.font_property.SuspendLayout();
            this.font_table.SuspendLayout();
            this.click_event_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.page_index)).BeginInit();
            this.hover_event_tab.SuspendLayout();
            this.insert_text_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // page_tab
            // 
            this.page_tab.Controls.Add(this.page_area);
            this.page_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_tab.Location = new System.Drawing.Point(0, 0);
            this.page_tab.Name = "page_tab";
            this.page_tab.SelectedIndex = 0;
            this.page_tab.Size = new System.Drawing.Size(408, 288);
            this.page_tab.TabIndex = 2;
            // 
            // page_area
            // 
            this.page_area.BackColor = System.Drawing.Color.Gray;
            this.page_area.Controls.Add(this.sentence_page);
            this.page_area.Location = new System.Drawing.Point(4, 22);
            this.page_area.Name = "page_area";
            this.page_area.Padding = new System.Windows.Forms.Padding(3);
            this.page_area.Size = new System.Drawing.Size(400, 262);
            this.page_area.TabIndex = 0;
            this.page_area.Text = "第1页";
            // 
            // sentence_page
            // 
            this.sentence_page.Controls.Add(this.sentence_area);
            this.sentence_page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sentence_page.Location = new System.Drawing.Point(3, 3);
            this.sentence_page.Name = "sentence_page";
            this.sentence_page.SelectedIndex = 0;
            this.sentence_page.Size = new System.Drawing.Size(394, 256);
            this.sentence_page.TabIndex = 0;
            // 
            // sentence_area
            // 
            this.sentence_area.BackColor = System.Drawing.Color.Gray;
            this.sentence_area.Controls.Add(this.sentence_content);
            this.sentence_area.Controls.Add(this.label1);
            this.sentence_area.Controls.Add(this.sentence_property_tab);
            this.sentence_area.Location = new System.Drawing.Point(4, 22);
            this.sentence_area.Name = "sentence_area";
            this.sentence_area.Padding = new System.Windows.Forms.Padding(3);
            this.sentence_area.Size = new System.Drawing.Size(386, 230);
            this.sentence_area.TabIndex = 0;
            this.sentence_area.Text = "第1句";
            // 
            // sentence_content
            // 
            this.sentence_content.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sentence_content.Location = new System.Drawing.Point(39, 0);
            this.sentence_content.Name = "sentence_content";
            this.sentence_content.Size = new System.Drawing.Size(346, 21);
            this.sentence_content.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "内容:";
            // 
            // sentence_property_tab
            // 
            this.sentence_property_tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sentence_property_tab.Controls.Add(this.font_property);
            this.sentence_property_tab.Controls.Add(this.click_event_tab);
            this.sentence_property_tab.Controls.Add(this.hover_event_tab);
            this.sentence_property_tab.Controls.Add(this.insert_text_tab);
            this.sentence_property_tab.Location = new System.Drawing.Point(0, 22);
            this.sentence_property_tab.Name = "sentence_property_tab";
            this.sentence_property_tab.SelectedIndex = 0;
            this.sentence_property_tab.Size = new System.Drawing.Size(385, 209);
            this.sentence_property_tab.TabIndex = 2;
            // 
            // font_property
            // 
            this.font_property.BackColor = System.Drawing.Color.Gray;
            this.font_property.Controls.Add(this.font_table);
            this.font_property.Location = new System.Drawing.Point(4, 22);
            this.font_property.Name = "font_property";
            this.font_property.Padding = new System.Windows.Forms.Padding(3);
            this.font_property.Size = new System.Drawing.Size(377, 183);
            this.font_property.TabIndex = 0;
            this.font_property.Text = "字体属性";
            // 
            // font_table
            // 
            this.font_table.ColumnCount = 2;
            this.font_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.font_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.font_table.Controls.Add(this.font_property_box, 0, 0);
            this.font_table.Controls.Add(this.font_color_box, 1, 0);
            this.font_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.font_table.Location = new System.Drawing.Point(3, 3);
            this.font_table.Name = "font_table";
            this.font_table.RowCount = 2;
            this.font_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.font_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.font_table.Size = new System.Drawing.Size(371, 177);
            this.font_table.TabIndex = 2;
            // 
            // font_property_box
            // 
            this.font_property_box.BackColor = System.Drawing.Color.Gray;
            this.font_property_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.font_property_box.ForeColor = System.Drawing.Color.White;
            this.font_property_box.FormattingEnabled = true;
            this.font_property_box.Items.AddRange(new object[] {
            "bold",
            "italic",
            "underlined",
            "strikethrough",
            "obfuscated"});
            this.font_property_box.Location = new System.Drawing.Point(3, 3);
            this.font_property_box.Name = "font_property_box";
            this.font_table.SetRowSpan(this.font_property_box, 2);
            this.font_property_box.Size = new System.Drawing.Size(179, 171);
            this.font_property_box.TabIndex = 0;
            // 
            // font_color_box
            // 
            this.font_color_box.BackColor = System.Drawing.Color.Gray;
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
            this.font_color_box.Location = new System.Drawing.Point(188, 3);
            this.font_color_box.Name = "font_color_box";
            this.font_table.SetRowSpan(this.font_color_box, 2);
            this.font_color_box.Size = new System.Drawing.Size(180, 171);
            this.font_color_box.TabIndex = 1;
            this.font_color_box.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Font_color_box_ItemCheck);
            // 
            // click_event_tab
            // 
            this.click_event_tab.BackColor = System.Drawing.Color.Gray;
            this.click_event_tab.Controls.Add(this.page_index);
            this.click_event_tab.Controls.Add(this.change_page);
            this.click_event_tab.Controls.Add(this.url_box);
            this.click_event_tab.Controls.Add(this.open_url);
            this.click_event_tab.Controls.Add(this.command_box);
            this.click_event_tab.Controls.Add(this.label2);
            this.click_event_tab.Controls.Add(this.run_btn);
            this.click_event_tab.Controls.Add(this.suggest_btn);
            this.click_event_tab.Location = new System.Drawing.Point(4, 22);
            this.click_event_tab.Name = "click_event_tab";
            this.click_event_tab.Size = new System.Drawing.Size(377, 183);
            this.click_event_tab.TabIndex = 1;
            this.click_event_tab.Text = "点击事件";
            // 
            // page_index
            // 
            this.page_index.Enabled = false;
            this.page_index.ForeColor = System.Drawing.Color.White;
            this.page_index.Location = new System.Drawing.Point(52, 50);
            this.page_index.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.page_index.Name = "page_index";
            this.page_index.Size = new System.Drawing.Size(75, 21);
            this.page_index.TabIndex = 7;
            // 
            // change_page
            // 
            this.change_page.AutoSize = true;
            this.change_page.ForeColor = System.Drawing.Color.White;
            this.change_page.Location = new System.Drawing.Point(3, 51);
            this.change_page.Name = "change_page";
            this.change_page.Size = new System.Drawing.Size(53, 16);
            this.change_page.TabIndex = 6;
            this.change_page.Text = "换页:";
            this.change_page.UseVisualStyleBackColor = true;
            this.change_page.Click += new System.EventHandler(this.Change_page_Click);
            // 
            // url_box
            // 
            this.url_box.Enabled = false;
            this.url_box.ForeColor = System.Drawing.Color.White;
            this.url_box.Location = new System.Drawing.Point(73, 24);
            this.url_box.Name = "url_box";
            this.url_box.Size = new System.Drawing.Size(100, 21);
            this.url_box.TabIndex = 5;
            // 
            // open_url
            // 
            this.open_url.AutoSize = true;
            this.open_url.ForeColor = System.Drawing.Color.White;
            this.open_url.Location = new System.Drawing.Point(3, 25);
            this.open_url.Name = "open_url";
            this.open_url.Size = new System.Drawing.Size(77, 16);
            this.open_url.TabIndex = 4;
            this.open_url.Text = "打开链接:";
            this.open_url.UseVisualStyleBackColor = true;
            this.open_url.Click += new System.EventHandler(this.Open_url_Click);
            // 
            // command_box
            // 
            this.command_box.Enabled = false;
            this.command_box.ForeColor = System.Drawing.Color.White;
            this.command_box.Location = new System.Drawing.Point(207, 2);
            this.command_box.Name = "command_box";
            this.command_box.Size = new System.Drawing.Size(100, 21);
            this.command_box.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(150, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "指令内容:";
            // 
            // run_btn
            // 
            this.run_btn.AutoSize = true;
            this.run_btn.ForeColor = System.Drawing.Color.White;
            this.run_btn.Location = new System.Drawing.Point(73, 3);
            this.run_btn.Name = "run_btn";
            this.run_btn.Size = new System.Drawing.Size(71, 16);
            this.run_btn.TabIndex = 1;
            this.run_btn.Text = "运行命令";
            this.run_btn.UseVisualStyleBackColor = true;
            this.run_btn.Click += new System.EventHandler(this.Run_btn_Click);
            // 
            // suggest_btn
            // 
            this.suggest_btn.AutoSize = true;
            this.suggest_btn.ForeColor = System.Drawing.Color.White;
            this.suggest_btn.Location = new System.Drawing.Point(3, 3);
            this.suggest_btn.Name = "suggest_btn";
            this.suggest_btn.Size = new System.Drawing.Size(71, 16);
            this.suggest_btn.TabIndex = 0;
            this.suggest_btn.Text = "建议命令";
            this.suggest_btn.UseVisualStyleBackColor = true;
            this.suggest_btn.Click += new System.EventHandler(this.Suggest_btn_Click);
            // 
            // hover_event_tab
            // 
            this.hover_event_tab.BackColor = System.Drawing.Color.Gray;
            this.hover_event_tab.Controls.Add(this.display_box);
            this.hover_event_tab.Controls.Add(this.show_entity);
            this.hover_event_tab.Controls.Add(this.show_item);
            this.hover_event_tab.Controls.Add(this.show_text);
            this.hover_event_tab.Location = new System.Drawing.Point(4, 22);
            this.hover_event_tab.Name = "hover_event_tab";
            this.hover_event_tab.Size = new System.Drawing.Size(377, 183);
            this.hover_event_tab.TabIndex = 2;
            this.hover_event_tab.Text = "悬浮事件";
            // 
            // display_box
            // 
            this.display_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.display_box.BackColor = System.Drawing.Color.Gray;
            this.display_box.ForeColor = System.Drawing.Color.DarkGray;
            this.display_box.Location = new System.Drawing.Point(0, 17);
            this.display_box.Multiline = true;
            this.display_box.Name = "display_box";
            this.display_box.Size = new System.Drawing.Size(377, 171);
            this.display_box.TabIndex = 4;
            this.display_box.Text = "值";
            // 
            // show_entity
            // 
            this.show_entity.AutoSize = true;
            this.show_entity.ForeColor = System.Drawing.Color.White;
            this.show_entity.Location = new System.Drawing.Point(157, 3);
            this.show_entity.Name = "show_entity";
            this.show_entity.Size = new System.Drawing.Size(71, 16);
            this.show_entity.TabIndex = 2;
            this.show_entity.TabStop = true;
            this.show_entity.Text = "显示实体";
            this.show_entity.UseVisualStyleBackColor = true;
            // 
            // show_item
            // 
            this.show_item.AutoSize = true;
            this.show_item.ForeColor = System.Drawing.Color.White;
            this.show_item.Location = new System.Drawing.Point(80, 3);
            this.show_item.Name = "show_item";
            this.show_item.Size = new System.Drawing.Size(71, 16);
            this.show_item.TabIndex = 1;
            this.show_item.TabStop = true;
            this.show_item.Text = "显示物品";
            this.show_item.UseVisualStyleBackColor = true;
            // 
            // show_text
            // 
            this.show_text.AutoSize = true;
            this.show_text.ForeColor = System.Drawing.Color.White;
            this.show_text.Location = new System.Drawing.Point(3, 3);
            this.show_text.Name = "show_text";
            this.show_text.Size = new System.Drawing.Size(71, 16);
            this.show_text.TabIndex = 0;
            this.show_text.TabStop = true;
            this.show_text.Text = "显示文本";
            this.show_text.UseVisualStyleBackColor = true;
            // 
            // insert_text_tab
            // 
            this.insert_text_tab.BackColor = System.Drawing.Color.Gray;
            this.insert_text_tab.Controls.Add(this.insert_box);
            this.insert_text_tab.Location = new System.Drawing.Point(4, 22);
            this.insert_text_tab.Name = "insert_text_tab";
            this.insert_text_tab.Size = new System.Drawing.Size(377, 183);
            this.insert_text_tab.TabIndex = 3;
            this.insert_text_tab.Text = "插入文本";
            // 
            // insert_box
            // 
            this.insert_box.BackColor = System.Drawing.Color.Gray;
            this.insert_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insert_box.ForeColor = System.Drawing.Color.DarkGray;
            this.insert_box.Location = new System.Drawing.Point(0, 0);
            this.insert_box.Multiline = true;
            this.insert_box.Name = "insert_box";
            this.insert_box.Size = new System.Drawing.Size(377, 183);
            this.insert_box.TabIndex = 0;
            this.insert_box.Text = "值";
            // 
            // page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.page_tab);
            this.Name = "page";
            this.Size = new System.Drawing.Size(408, 288);
            this.page_tab.ResumeLayout(false);
            this.page_area.ResumeLayout(false);
            this.sentence_page.ResumeLayout(false);
            this.sentence_area.ResumeLayout(false);
            this.sentence_area.PerformLayout();
            this.sentence_property_tab.ResumeLayout(false);
            this.font_property.ResumeLayout(false);
            this.font_table.ResumeLayout(false);
            this.click_event_tab.ResumeLayout(false);
            this.click_event_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.page_index)).EndInit();
            this.hover_event_tab.ResumeLayout(false);
            this.hover_event_tab.PerformLayout();
            this.insert_text_tab.ResumeLayout(false);
            this.insert_text_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage page_area;
        private System.Windows.Forms.TabControl sentence_page;
        private System.Windows.Forms.TabPage sentence_area;
        private System.Windows.Forms.TextBox sentence_content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage font_property;
        private System.Windows.Forms.TableLayoutPanel font_table;
        private System.Windows.Forms.TabPage click_event_tab;
        private System.Windows.Forms.NumericUpDown page_index;
        private System.Windows.Forms.RadioButton change_page;
        private System.Windows.Forms.TextBox url_box;
        private System.Windows.Forms.RadioButton open_url;
        private System.Windows.Forms.TextBox command_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton run_btn;
        private System.Windows.Forms.RadioButton suggest_btn;
        private System.Windows.Forms.TabPage hover_event_tab;
        private System.Windows.Forms.TextBox display_box;
        private System.Windows.Forms.RadioButton show_entity;
        private System.Windows.Forms.RadioButton show_item;
        private System.Windows.Forms.RadioButton show_text;
        private System.Windows.Forms.TabPage insert_text_tab;
        private System.Windows.Forms.TextBox insert_box;
        public System.Windows.Forms.TabControl page_tab;
        public System.Windows.Forms.CheckedListBox font_color_box;
        public System.Windows.Forms.TabControl sentence_property_tab;
        public System.Windows.Forms.CheckedListBox font_property_box;
    }
}
