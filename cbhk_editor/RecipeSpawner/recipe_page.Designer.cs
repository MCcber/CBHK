
namespace cbhk_editor.RecipeSpawner
{
    partial class recipe_page
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
            this.recipe_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.recipe_table = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.recipe_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reward_xp = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.firing_time = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.recipe_count = new System.Windows.Forms.NumericUpDown();
            this.recipe_result = new System.Windows.Forms.ComboBox();
            this.group_name = new System.Windows.Forms.TextBox();
            this.recipe_content = new System.Windows.Forms.TableLayoutPanel();
            this.key9 = new System.Windows.Forms.TextBox();
            this.key8 = new System.Windows.Forms.TextBox();
            this.key7 = new System.Windows.Forms.TextBox();
            this.key6 = new System.Windows.Forms.TextBox();
            this.key5 = new System.Windows.Forms.TextBox();
            this.key4 = new System.Windows.Forms.TextBox();
            this.key3 = new System.Windows.Forms.TextBox();
            this.key2 = new System.Windows.Forms.TextBox();
            this.key1 = new System.Windows.Forms.TextBox();
            this.recipe_value_tab = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.key_tag = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.key_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.recipe_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.recipe_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reward_xp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firing_time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipe_count)).BeginInit();
            this.recipe_content.SuspendLayout();
            this.recipe_value_tab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // recipe_tab
            // 
            this.recipe_tab.Controls.Add(this.tabPage1);
            this.recipe_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipe_tab.Location = new System.Drawing.Point(0, 0);
            this.recipe_tab.Name = "recipe_tab";
            this.recipe_tab.SelectedIndex = 0;
            this.recipe_tab.Size = new System.Drawing.Size(449, 257);
            this.recipe_tab.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.recipe_table);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(441, 231);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "recipe.json";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // recipe_table
            // 
            this.recipe_table.BackColor = System.Drawing.Color.Gray;
            this.recipe_table.ColumnCount = 4;
            this.recipe_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.recipe_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.recipe_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.recipe_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.recipe_table.Controls.Add(this.label1, 0, 0);
            this.recipe_table.Controls.Add(this.recipe_type, 1, 0);
            this.recipe_table.Controls.Add(this.label2, 2, 0);
            this.recipe_table.Controls.Add(this.reward_xp, 3, 0);
            this.recipe_table.Controls.Add(this.label3, 2, 1);
            this.recipe_table.Controls.Add(this.firing_time, 3, 1);
            this.recipe_table.Controls.Add(this.label4, 2, 2);
            this.recipe_table.Controls.Add(this.label5, 2, 3);
            this.recipe_table.Controls.Add(this.label6, 2, 4);
            this.recipe_table.Controls.Add(this.recipe_count, 3, 2);
            this.recipe_table.Controls.Add(this.recipe_result, 3, 3);
            this.recipe_table.Controls.Add(this.group_name, 3, 4);
            this.recipe_table.Controls.Add(this.recipe_content, 0, 1);
            this.recipe_table.Controls.Add(this.recipe_value_tab, 0, 5);
            this.recipe_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipe_table.ForeColor = System.Drawing.Color.White;
            this.recipe_table.Location = new System.Drawing.Point(3, 3);
            this.recipe_table.Name = "recipe_table";
            this.recipe_table.RowCount = 6;
            this.recipe_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.recipe_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.recipe_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.recipe_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.recipe_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.recipe_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.recipe_table.Size = new System.Drawing.Size(435, 225);
            this.recipe_table.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "模式:";
            // 
            // recipe_type
            // 
            this.recipe_type.BackColor = System.Drawing.Color.Gray;
            this.recipe_type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipe_type.ForeColor = System.Drawing.Color.White;
            this.recipe_type.FormattingEnabled = true;
            this.recipe_type.Items.AddRange(new object[] {
            "blasting高炉",
            "campfire_cooking营火",
            "crafting_shaped工作台(有序)",
            "crafting_shapeless工作台(无序)",
            "smelting熔炉",
            "smoking烟熏炉",
            "stonecutting切石机"});
            this.recipe_type.Location = new System.Drawing.Point(53, 3);
            this.recipe_type.Name = "recipe_type";
            this.recipe_type.Size = new System.Drawing.Size(173, 20);
            this.recipe_type.TabIndex = 1;
            this.recipe_type.Text = "crafting_shaped工作台(有序)";
            this.recipe_type.SelectedIndexChanged += new System.EventHandler(this.recipe_type_SelectedIndexChanged);
            this.recipe_type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.recipe_type_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "奖励经验值:";
            // 
            // reward_xp
            // 
            this.reward_xp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.reward_xp.BackColor = System.Drawing.Color.Gray;
            this.reward_xp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reward_xp.Enabled = false;
            this.reward_xp.ForeColor = System.Drawing.Color.White;
            this.reward_xp.Location = new System.Drawing.Point(311, 4);
            this.reward_xp.Name = "reward_xp";
            this.reward_xp.Size = new System.Drawing.Size(120, 17);
            this.reward_xp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "烧制时间:";
            // 
            // firing_time
            // 
            this.firing_time.BackColor = System.Drawing.Color.Gray;
            this.firing_time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firing_time.Enabled = false;
            this.firing_time.ForeColor = System.Drawing.Color.White;
            this.firing_time.Location = new System.Drawing.Point(311, 29);
            this.firing_time.Name = "firing_time";
            this.firing_time.Size = new System.Drawing.Size(120, 17);
            this.firing_time.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "数量:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "结果:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "组标识符:";
            // 
            // recipe_count
            // 
            this.recipe_count.BackColor = System.Drawing.Color.Gray;
            this.recipe_count.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recipe_count.ForeColor = System.Drawing.Color.White;
            this.recipe_count.Location = new System.Drawing.Point(311, 56);
            this.recipe_count.Name = "recipe_count";
            this.recipe_count.Size = new System.Drawing.Size(120, 17);
            this.recipe_count.TabIndex = 9;
            // 
            // recipe_result
            // 
            this.recipe_result.BackColor = System.Drawing.Color.Gray;
            this.recipe_result.ForeColor = System.Drawing.Color.White;
            this.recipe_result.FormattingEnabled = true;
            this.recipe_result.Location = new System.Drawing.Point(311, 83);
            this.recipe_result.Name = "recipe_result";
            this.recipe_result.Size = new System.Drawing.Size(121, 20);
            this.recipe_result.TabIndex = 10;
            // 
            // group_name
            // 
            this.group_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.group_name.BackColor = System.Drawing.Color.Gray;
            this.group_name.ForeColor = System.Drawing.Color.White;
            this.group_name.Location = new System.Drawing.Point(311, 110);
            this.group_name.Name = "group_name";
            this.group_name.Size = new System.Drawing.Size(121, 21);
            this.group_name.TabIndex = 11;
            // 
            // recipe_content
            // 
            this.recipe_content.ColumnCount = 3;
            this.recipe_table.SetColumnSpan(this.recipe_content, 2);
            this.recipe_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.recipe_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.recipe_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.recipe_content.Controls.Add(this.key9, 2, 2);
            this.recipe_content.Controls.Add(this.key8, 1, 2);
            this.recipe_content.Controls.Add(this.key7, 0, 2);
            this.recipe_content.Controls.Add(this.key6, 2, 1);
            this.recipe_content.Controls.Add(this.key5, 1, 1);
            this.recipe_content.Controls.Add(this.key4, 0, 1);
            this.recipe_content.Controls.Add(this.key3, 2, 0);
            this.recipe_content.Controls.Add(this.key2, 1, 0);
            this.recipe_content.Controls.Add(this.key1, 0, 0);
            this.recipe_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipe_content.Location = new System.Drawing.Point(3, 29);
            this.recipe_content.Name = "recipe_content";
            this.recipe_content.RowCount = 3;
            this.recipe_table.SetRowSpan(this.recipe_content, 4);
            this.recipe_content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.recipe_content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.recipe_content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.recipe_content.Size = new System.Drawing.Size(223, 103);
            this.recipe_content.TabIndex = 12;
            // 
            // key9
            // 
            this.key9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.key9.BackColor = System.Drawing.Color.Gray;
            this.key9.ForeColor = System.Drawing.Color.White;
            this.key9.Location = new System.Drawing.Point(161, 77);
            this.key9.Name = "key9";
            this.key9.Size = new System.Drawing.Size(58, 21);
            this.key9.TabIndex = 8;
            // 
            // key8
            // 
            this.key8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.key8.BackColor = System.Drawing.Color.Gray;
            this.key8.ForeColor = System.Drawing.Color.White;
            this.key8.Location = new System.Drawing.Point(82, 77);
            this.key8.Name = "key8";
            this.key8.Size = new System.Drawing.Size(58, 21);
            this.key8.TabIndex = 7;
            // 
            // key7
            // 
            this.key7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.key7.BackColor = System.Drawing.Color.Gray;
            this.key7.ForeColor = System.Drawing.Color.White;
            this.key7.Location = new System.Drawing.Point(3, 77);
            this.key7.Name = "key7";
            this.key7.Size = new System.Drawing.Size(58, 21);
            this.key7.TabIndex = 6;
            // 
            // key6
            // 
            this.key6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.key6.BackColor = System.Drawing.Color.Gray;
            this.key6.ForeColor = System.Drawing.Color.White;
            this.key6.Location = new System.Drawing.Point(161, 43);
            this.key6.Name = "key6";
            this.key6.Size = new System.Drawing.Size(58, 21);
            this.key6.TabIndex = 5;
            // 
            // key5
            // 
            this.key5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.key5.BackColor = System.Drawing.Color.Gray;
            this.key5.ForeColor = System.Drawing.Color.White;
            this.key5.Location = new System.Drawing.Point(82, 43);
            this.key5.Name = "key5";
            this.key5.Size = new System.Drawing.Size(58, 21);
            this.key5.TabIndex = 4;
            // 
            // key4
            // 
            this.key4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.key4.BackColor = System.Drawing.Color.Gray;
            this.key4.ForeColor = System.Drawing.Color.White;
            this.key4.Location = new System.Drawing.Point(3, 43);
            this.key4.Name = "key4";
            this.key4.Size = new System.Drawing.Size(58, 21);
            this.key4.TabIndex = 3;
            // 
            // key3
            // 
            this.key3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.key3.BackColor = System.Drawing.Color.Gray;
            this.key3.ForeColor = System.Drawing.Color.White;
            this.key3.Location = new System.Drawing.Point(161, 7);
            this.key3.Name = "key3";
            this.key3.Size = new System.Drawing.Size(58, 21);
            this.key3.TabIndex = 2;
            // 
            // key2
            // 
            this.key2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.key2.BackColor = System.Drawing.Color.Gray;
            this.key2.ForeColor = System.Drawing.Color.White;
            this.key2.Location = new System.Drawing.Point(82, 7);
            this.key2.Name = "key2";
            this.key2.Size = new System.Drawing.Size(58, 21);
            this.key2.TabIndex = 1;
            // 
            // key1
            // 
            this.key1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.key1.BackColor = System.Drawing.Color.Gray;
            this.key1.ForeColor = System.Drawing.Color.White;
            this.key1.Location = new System.Drawing.Point(3, 7);
            this.key1.Name = "key1";
            this.key1.Size = new System.Drawing.Size(58, 21);
            this.key1.TabIndex = 0;
            // 
            // recipe_value_tab
            // 
            this.recipe_table.SetColumnSpan(this.recipe_value_tab, 4);
            this.recipe_value_tab.Controls.Add(this.tabPage2);
            this.recipe_value_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipe_value_tab.Location = new System.Drawing.Point(3, 138);
            this.recipe_value_tab.Name = "recipe_value_tab";
            this.recipe_value_tab.SelectedIndex = 0;
            this.recipe_value_tab.Size = new System.Drawing.Size(429, 84);
            this.recipe_value_tab.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.key_tag);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.key_id);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(421, 58);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "槽位:1";
            // 
            // key_tag
            // 
            this.key_tag.BackColor = System.Drawing.Color.Gray;
            this.key_tag.ForeColor = System.Drawing.Color.White;
            this.key_tag.Location = new System.Drawing.Point(30, 30);
            this.key_tag.Name = "key_tag";
            this.key_tag.Size = new System.Drawing.Size(388, 21);
            this.key_tag.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tag:";
            // 
            // key_id
            // 
            this.key_id.BackColor = System.Drawing.Color.Gray;
            this.key_id.ForeColor = System.Drawing.Color.White;
            this.key_id.Location = new System.Drawing.Point(30, 0);
            this.key_id.Name = "key_id";
            this.key_id.Size = new System.Drawing.Size(388, 21);
            this.key_id.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID:";
            // 
            // recipe_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.recipe_tab);
            this.Name = "recipe_page";
            this.Size = new System.Drawing.Size(449, 257);
            this.recipe_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.recipe_table.ResumeLayout(false);
            this.recipe_table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reward_xp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firing_time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipe_count)).EndInit();
            this.recipe_content.ResumeLayout(false);
            this.recipe_content.PerformLayout();
            this.recipe_value_tab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel recipe_table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox recipe_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown reward_xp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown firing_time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown recipe_count;
        private System.Windows.Forms.ComboBox recipe_result;
        private System.Windows.Forms.TextBox group_name;
        private System.Windows.Forms.TableLayoutPanel recipe_content;
        private System.Windows.Forms.TextBox key9;
        private System.Windows.Forms.TextBox key8;
        private System.Windows.Forms.TextBox key7;
        private System.Windows.Forms.TextBox key6;
        private System.Windows.Forms.TextBox key5;
        private System.Windows.Forms.TextBox key4;
        private System.Windows.Forms.TextBox key3;
        private System.Windows.Forms.TextBox key2;
        private System.Windows.Forms.TextBox key1;
        private System.Windows.Forms.TabControl recipe_value_tab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox key_tag;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox key_id;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TabControl recipe_tab;
    }
}
