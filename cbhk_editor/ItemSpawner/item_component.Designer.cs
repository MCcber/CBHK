
namespace cbhk_editor.ItemSpawner
{
    partial class item_component
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(item_component));
            this.item_tab = new System.Windows.Forms.TabControl();
            this.item_page = new System.Windows.Forms.TabPage();
            this.item_page_table = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.item_id = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.item_count = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.item_data = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.item_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.item_lore = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.item_custom_tag = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.item_display_style = new System.Windows.Forms.ComboBox();
            this.click_to_spawn_uid = new System.Windows.Forms.Button();
            this.item_uid = new System.Windows.Forms.TextBox();
            this.unbreakable = new System.Windows.Forms.CheckBox();
            this.item_potion_tab = new System.Windows.Forms.TabControl();
            this.potion_page = new System.Windows.Forms.TabPage();
            this.potioin_second = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.potion_amplifier = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.potion_id = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.item_attribute_tab = new System.Windows.Forms.TabControl();
            this.attribute_page = new System.Windows.Forms.TabPage();
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
            this.label15 = new System.Windows.Forms.Label();
            this.can_place = new System.Windows.Forms.ComboBox();
            this.add_place = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.can_destory = new System.Windows.Forms.ComboBox();
            this.add_destory = new System.Windows.Forms.Button();
            this.item_enchantment_tab = new System.Windows.Forms.TabControl();
            this.enchantment_page = new System.Windows.Forms.TabPage();
            this.enchantment_level = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.enchantment_id = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.item_tab.SuspendLayout();
            this.item_page.SuspendLayout();
            this.item_page_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_data)).BeginInit();
            this.item_potion_tab.SuspendLayout();
            this.potion_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.potioin_second)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potion_amplifier)).BeginInit();
            this.item_attribute_tab.SuspendLayout();
            this.attribute_page.SuspendLayout();
            this.item_enchantment_tab.SuspendLayout();
            this.enchantment_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enchantment_level)).BeginInit();
            this.SuspendLayout();
            // 
            // item_tab
            // 
            this.item_tab.Controls.Add(this.item_page);
            this.item_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.item_tab.Location = new System.Drawing.Point(0, 0);
            this.item_tab.Name = "item_tab";
            this.item_tab.SelectedIndex = 0;
            this.item_tab.Size = new System.Drawing.Size(591, 370);
            this.item_tab.TabIndex = 2;
            // 
            // item_page
            // 
            this.item_page.BackColor = System.Drawing.Color.Gray;
            this.item_page.Controls.Add(this.item_page_table);
            this.item_page.ForeColor = System.Drawing.Color.White;
            this.item_page.Location = new System.Drawing.Point(4, 22);
            this.item_page.Name = "item_page";
            this.item_page.Padding = new System.Windows.Forms.Padding(3);
            this.item_page.Size = new System.Drawing.Size(583, 344);
            this.item_page.TabIndex = 0;
            this.item_page.Text = "第1个物品";
            // 
            // item_page_table
            // 
            this.item_page_table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.item_page_table.ColumnCount = 6;
            this.item_page_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.item_page_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.item_page_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.item_page_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.item_page_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.item_page_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.item_page_table.Controls.Add(this.label1, 0, 0);
            this.item_page_table.Controls.Add(this.item_id, 1, 0);
            this.item_page_table.Controls.Add(this.label2, 2, 0);
            this.item_page_table.Controls.Add(this.item_count, 3, 0);
            this.item_page_table.Controls.Add(this.label3, 4, 0);
            this.item_page_table.Controls.Add(this.item_data, 5, 0);
            this.item_page_table.Controls.Add(this.label4, 0, 1);
            this.item_page_table.Controls.Add(this.item_name, 1, 1);
            this.item_page_table.Controls.Add(this.label5, 2, 1);
            this.item_page_table.Controls.Add(this.item_lore, 3, 1);
            this.item_page_table.Controls.Add(this.label6, 0, 2);
            this.item_page_table.Controls.Add(this.item_custom_tag, 1, 2);
            this.item_page_table.Controls.Add(this.label7, 2, 2);
            this.item_page_table.Controls.Add(this.item_display_style, 3, 2);
            this.item_page_table.Controls.Add(this.click_to_spawn_uid, 4, 2);
            this.item_page_table.Controls.Add(this.item_uid, 5, 2);
            this.item_page_table.Controls.Add(this.unbreakable, 4, 1);
            this.item_page_table.Controls.Add(this.item_potion_tab, 0, 6);
            this.item_page_table.Controls.Add(this.item_attribute_tab, 0, 5);
            this.item_page_table.Controls.Add(this.label15, 0, 3);
            this.item_page_table.Controls.Add(this.can_place, 1, 3);
            this.item_page_table.Controls.Add(this.add_place, 2, 3);
            this.item_page_table.Controls.Add(this.label16, 3, 3);
            this.item_page_table.Controls.Add(this.can_destory, 4, 3);
            this.item_page_table.Controls.Add(this.add_destory, 5, 3);
            this.item_page_table.Controls.Add(this.item_enchantment_tab, 0, 4);
            this.item_page_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.item_page_table.Location = new System.Drawing.Point(3, 3);
            this.item_page_table.Name = "item_page_table";
            this.item_page_table.RowCount = 7;
            this.item_page_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.item_page_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.item_page_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.item_page_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.item_page_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.item_page_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.item_page_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.item_page_table.Size = new System.Drawing.Size(577, 338);
            this.item_page_table.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "id:";
            // 
            // item_id
            // 
            this.item_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.item_id.Dock = System.Windows.Forms.DockStyle.Left;
            this.item_id.ForeColor = System.Drawing.Color.White;
            this.item_id.FormattingEnabled = true;
            this.item_id.Location = new System.Drawing.Point(81, 3);
            this.item_id.Name = "item_id";
            this.item_id.Size = new System.Drawing.Size(143, 20);
            this.item_id.TabIndex = 1;
            this.item_id.TextChanged += new System.EventHandler(this.item_id_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(254, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "数量;";
            // 
            // item_count
            // 
            this.item_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.item_count.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.item_count.Dock = System.Windows.Forms.DockStyle.Left;
            this.item_count.ForeColor = System.Drawing.Color.White;
            this.item_count.Location = new System.Drawing.Point(295, 3);
            this.item_count.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.item_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.item_count.Name = "item_count";
            this.item_count.Size = new System.Drawing.Size(96, 17);
            this.item_count.TabIndex = 3;
            this.item_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(468, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "数据值:";
            // 
            // item_data
            // 
            this.item_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.item_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.item_data.ForeColor = System.Drawing.Color.White;
            this.item_data.Location = new System.Drawing.Point(521, 3);
            this.item_data.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.item_data.Name = "item_data";
            this.item_data.Size = new System.Drawing.Size(53, 17);
            this.item_data.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "显示名称:";
            // 
            // item_name
            // 
            this.item_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.item_name.Dock = System.Windows.Forms.DockStyle.Left;
            this.item_name.ForeColor = System.Drawing.Color.White;
            this.item_name.Location = new System.Drawing.Point(81, 30);
            this.item_name.Name = "item_name";
            this.item_name.Size = new System.Drawing.Size(143, 21);
            this.item_name.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(254, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "简介:";
            // 
            // item_lore
            // 
            this.item_lore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.item_lore.Dock = System.Windows.Forms.DockStyle.Left;
            this.item_lore.ForeColor = System.Drawing.Color.White;
            this.item_lore.Location = new System.Drawing.Point(295, 30);
            this.item_lore.Name = "item_lore";
            this.item_lore.Size = new System.Drawing.Size(96, 21);
            this.item_lore.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "自定义标签:";
            // 
            // item_custom_tag
            // 
            this.item_custom_tag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.item_custom_tag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.item_custom_tag.ForeColor = System.Drawing.Color.White;
            this.item_custom_tag.Location = new System.Drawing.Point(81, 58);
            this.item_custom_tag.Multiline = true;
            this.item_custom_tag.Name = "item_custom_tag";
            this.item_custom_tag.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.item_custom_tag.Size = new System.Drawing.Size(143, 42);
            this.item_custom_tag.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(230, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "信息隐藏:";
            // 
            // item_display_style
            // 
            this.item_display_style.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.item_display_style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.item_display_style.ForeColor = System.Drawing.Color.White;
            this.item_display_style.FormattingEnabled = true;
            this.item_display_style.Items.AddRange(new object[] {
            "全部显示",
            "隐藏附魔",
            "隐藏自定义属性",
            "隐藏附魔和自定义属性",
            "隐藏unbreakable",
            "隐藏can_destroy",
            "隐藏can_placeon",
            "隐藏大部分信息",
            "只显示名称和简介"});
            this.item_display_style.Location = new System.Drawing.Point(295, 69);
            this.item_display_style.Name = "item_display_style";
            this.item_display_style.Size = new System.Drawing.Size(96, 20);
            this.item_display_style.TabIndex = 14;
            // 
            // click_to_spawn_uid
            // 
            this.click_to_spawn_uid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.click_to_spawn_uid.BackColor = System.Drawing.Color.Transparent;
            this.click_to_spawn_uid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("click_to_spawn_uid.BackgroundImage")));
            this.click_to_spawn_uid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.click_to_spawn_uid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.click_to_spawn_uid.FlatAppearance.BorderSize = 0;
            this.click_to_spawn_uid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.click_to_spawn_uid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.click_to_spawn_uid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.click_to_spawn_uid.ForeColor = System.Drawing.Color.White;
            this.click_to_spawn_uid.Location = new System.Drawing.Point(397, 67);
            this.click_to_spawn_uid.Name = "click_to_spawn_uid";
            this.click_to_spawn_uid.Size = new System.Drawing.Size(118, 23);
            this.click_to_spawn_uid.TabIndex = 15;
            this.click_to_spawn_uid.Text = "随机UID:";
            this.click_to_spawn_uid.UseVisualStyleBackColor = false;
            this.click_to_spawn_uid.Click += new System.EventHandler(this.click_to_spawn_uid_Click);
            // 
            // item_uid
            // 
            this.item_uid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.item_uid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.item_uid.ForeColor = System.Drawing.Color.White;
            this.item_uid.Location = new System.Drawing.Point(521, 68);
            this.item_uid.Name = "item_uid";
            this.item_uid.Size = new System.Drawing.Size(53, 21);
            this.item_uid.TabIndex = 16;
            // 
            // unbreakable
            // 
            this.unbreakable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.unbreakable.AutoSize = true;
            this.unbreakable.ForeColor = System.Drawing.Color.White;
            this.unbreakable.Location = new System.Drawing.Point(443, 33);
            this.unbreakable.Name = "unbreakable";
            this.unbreakable.Size = new System.Drawing.Size(72, 16);
            this.unbreakable.TabIndex = 12;
            this.unbreakable.Text = "无法破坏";
            this.unbreakable.UseVisualStyleBackColor = true;
            // 
            // item_potion_tab
            // 
            this.item_page_table.SetColumnSpan(this.item_potion_tab, 6);
            this.item_potion_tab.Controls.Add(this.potion_page);
            this.item_potion_tab.Enabled = false;
            this.item_potion_tab.Location = new System.Drawing.Point(3, 290);
            this.item_potion_tab.Name = "item_potion_tab";
            this.item_potion_tab.SelectedIndex = 0;
            this.item_potion_tab.Size = new System.Drawing.Size(571, 47);
            this.item_potion_tab.TabIndex = 19;
            // 
            // potion_page
            // 
            this.potion_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.potion_page.Controls.Add(this.potioin_second);
            this.potion_page.Controls.Add(this.label19);
            this.potion_page.Controls.Add(this.potion_amplifier);
            this.potion_page.Controls.Add(this.label18);
            this.potion_page.Controls.Add(this.potion_id);
            this.potion_page.Controls.Add(this.label17);
            this.potion_page.Location = new System.Drawing.Point(4, 22);
            this.potion_page.Name = "potion_page";
            this.potion_page.Padding = new System.Windows.Forms.Padding(3);
            this.potion_page.Size = new System.Drawing.Size(563, 21);
            this.potion_page.TabIndex = 0;
            this.potion_page.Text = "第1个药水效果";
            // 
            // potioin_second
            // 
            this.potioin_second.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.potioin_second.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.potioin_second.ForeColor = System.Drawing.Color.White;
            this.potioin_second.Location = new System.Drawing.Point(194, 3);
            this.potioin_second.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.potioin_second.Name = "potioin_second";
            this.potioin_second.Size = new System.Drawing.Size(59, 17);
            this.potioin_second.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(151, 5);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 12);
            this.label19.TabIndex = 4;
            this.label19.Text = "second:";
            // 
            // potion_amplifier
            // 
            this.potion_amplifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.potion_amplifier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.potion_amplifier.ForeColor = System.Drawing.Color.White;
            this.potion_amplifier.Location = new System.Drawing.Point(318, 3);
            this.potion_amplifier.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.potion_amplifier.Name = "potion_amplifier";
            this.potion_amplifier.Size = new System.Drawing.Size(59, 17);
            this.potion_amplifier.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(253, 4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 2;
            this.label18.Text = "amplifier:";
            // 
            // potion_id
            // 
            this.potion_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.potion_id.ForeColor = System.Drawing.Color.White;
            this.potion_id.FormattingEnabled = true;
            this.potion_id.Location = new System.Drawing.Point(26, 1);
            this.potion_id.Name = "potion_id";
            this.potion_id.Size = new System.Drawing.Size(121, 20);
            this.potion_id.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(6, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "id:";
            // 
            // item_attribute_tab
            // 
            this.item_page_table.SetColumnSpan(this.item_attribute_tab, 6);
            this.item_attribute_tab.Controls.Add(this.attribute_page);
            this.item_attribute_tab.Location = new System.Drawing.Point(3, 192);
            this.item_attribute_tab.Name = "item_attribute_tab";
            this.item_attribute_tab.SelectedIndex = 0;
            this.item_attribute_tab.Size = new System.Drawing.Size(571, 92);
            this.item_attribute_tab.TabIndex = 18;
            // 
            // attribute_page
            // 
            this.attribute_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.attribute_page.Controls.Add(this.attribute_slot);
            this.attribute_page.Controls.Add(this.label14);
            this.attribute_page.Controls.Add(this.attribute_operation);
            this.attribute_page.Controls.Add(this.label13);
            this.attribute_page.Controls.Add(this.attribute_value);
            this.attribute_page.Controls.Add(this.label12);
            this.attribute_page.Controls.Add(this.attribute_name);
            this.attribute_page.Controls.Add(this.label11);
            this.attribute_page.Controls.Add(this.attribute_id);
            this.attribute_page.Controls.Add(this.label10);
            this.attribute_page.Location = new System.Drawing.Point(4, 22);
            this.attribute_page.Name = "attribute_page";
            this.attribute_page.Padding = new System.Windows.Forms.Padding(3);
            this.attribute_page.Size = new System.Drawing.Size(563, 66);
            this.attribute_page.TabIndex = 0;
            this.attribute_page.Text = "第1个属性";
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
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(28, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 12);
            this.label15.TabIndex = 20;
            this.label15.Text = "可放置:";
            // 
            // can_place
            // 
            this.can_place.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.can_place.ForeColor = System.Drawing.Color.White;
            this.can_place.FormattingEnabled = true;
            this.can_place.Location = new System.Drawing.Point(81, 106);
            this.can_place.Name = "can_place";
            this.can_place.Size = new System.Drawing.Size(143, 20);
            this.can_place.TabIndex = 21;
            this.can_place.SelectedIndexChanged += new System.EventHandler(this.can_place_SelectedIndexChanged);
            // 
            // add_place
            // 
            this.add_place.BackColor = System.Drawing.Color.Transparent;
            this.add_place.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_place.BackgroundImage")));
            this.add_place.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_place.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_place.FlatAppearance.BorderSize = 0;
            this.add_place.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.add_place.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.add_place.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_place.ForeColor = System.Drawing.Color.White;
            this.add_place.Location = new System.Drawing.Point(230, 106);
            this.add_place.Name = "add_place";
            this.add_place.Size = new System.Drawing.Size(59, 22);
            this.add_place.TabIndex = 22;
            this.add_place.Text = "添加";
            this.add_place.UseVisualStyleBackColor = false;
            this.add_place.Click += new System.EventHandler(this.add_place_Click);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(344, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 23;
            this.label16.Text = "可破坏:";
            // 
            // can_destory
            // 
            this.can_destory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.can_destory.ForeColor = System.Drawing.Color.White;
            this.can_destory.FormattingEnabled = true;
            this.can_destory.Location = new System.Drawing.Point(397, 106);
            this.can_destory.Name = "can_destory";
            this.can_destory.Size = new System.Drawing.Size(118, 20);
            this.can_destory.TabIndex = 24;
            this.can_destory.SelectedIndexChanged += new System.EventHandler(this.can_destory_SelectedIndexChanged);
            // 
            // add_destory
            // 
            this.add_destory.BackColor = System.Drawing.Color.Transparent;
            this.add_destory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_destory.BackgroundImage")));
            this.add_destory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_destory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_destory.FlatAppearance.BorderSize = 0;
            this.add_destory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.add_destory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.add_destory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_destory.ForeColor = System.Drawing.Color.White;
            this.add_destory.Location = new System.Drawing.Point(521, 106);
            this.add_destory.Name = "add_destory";
            this.add_destory.Size = new System.Drawing.Size(53, 22);
            this.add_destory.TabIndex = 25;
            this.add_destory.Text = "添加";
            this.add_destory.UseVisualStyleBackColor = false;
            this.add_destory.Click += new System.EventHandler(this.add_destory_Click);
            // 
            // item_enchantment_tab
            // 
            this.item_page_table.SetColumnSpan(this.item_enchantment_tab, 6);
            this.item_enchantment_tab.Controls.Add(this.enchantment_page);
            this.item_enchantment_tab.Location = new System.Drawing.Point(3, 134);
            this.item_enchantment_tab.Name = "item_enchantment_tab";
            this.item_enchantment_tab.SelectedIndex = 0;
            this.item_enchantment_tab.Size = new System.Drawing.Size(571, 52);
            this.item_enchantment_tab.TabIndex = 17;
            // 
            // enchantment_page
            // 
            this.enchantment_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.enchantment_page.Controls.Add(this.enchantment_level);
            this.enchantment_page.Controls.Add(this.label9);
            this.enchantment_page.Controls.Add(this.enchantment_id);
            this.enchantment_page.Controls.Add(this.label8);
            this.enchantment_page.ForeColor = System.Drawing.Color.White;
            this.enchantment_page.Location = new System.Drawing.Point(4, 22);
            this.enchantment_page.Name = "enchantment_page";
            this.enchantment_page.Padding = new System.Windows.Forms.Padding(3);
            this.enchantment_page.Size = new System.Drawing.Size(563, 26);
            this.enchantment_page.TabIndex = 0;
            this.enchantment_page.Text = "第1个附魔";
            // 
            // enchantment_level
            // 
            this.enchantment_level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.enchantment_level.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enchantment_level.Dock = System.Windows.Forms.DockStyle.Left;
            this.enchantment_level.ForeColor = System.Drawing.Color.White;
            this.enchantment_level.Location = new System.Drawing.Point(188, 3);
            this.enchantment_level.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.enchantment_level.Name = "enchantment_level";
            this.enchantment_level.Size = new System.Drawing.Size(120, 17);
            this.enchantment_level.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(147, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "level:";
            // 
            // enchantment_id
            // 
            this.enchantment_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.enchantment_id.Dock = System.Windows.Forms.DockStyle.Left;
            this.enchantment_id.ForeColor = System.Drawing.Color.White;
            this.enchantment_id.FormattingEnabled = true;
            this.enchantment_id.Location = new System.Drawing.Point(26, 3);
            this.enchantment_id.Name = "enchantment_id";
            this.enchantment_id.Size = new System.Drawing.Size(121, 20);
            this.enchantment_id.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "id:";
            // 
            // item_component
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.item_tab);
            this.Name = "item_component";
            this.Size = new System.Drawing.Size(591, 370);
            this.item_tab.ResumeLayout(false);
            this.item_page.ResumeLayout(false);
            this.item_page_table.ResumeLayout(false);
            this.item_page_table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_data)).EndInit();
            this.item_potion_tab.ResumeLayout(false);
            this.potion_page.ResumeLayout(false);
            this.potion_page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.potioin_second)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potion_amplifier)).EndInit();
            this.item_attribute_tab.ResumeLayout(false);
            this.attribute_page.ResumeLayout(false);
            this.attribute_page.PerformLayout();
            this.item_enchantment_tab.ResumeLayout(false);
            this.enchantment_page.ResumeLayout(false);
            this.enchantment_page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enchantment_level)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage item_page;
        private System.Windows.Forms.TableLayoutPanel item_page_table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox item_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown item_count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown item_data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox item_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox item_lore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox item_custom_tag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox item_display_style;
        private System.Windows.Forms.Button click_to_spawn_uid;
        private System.Windows.Forms.TextBox item_uid;
        private System.Windows.Forms.CheckBox unbreakable;
        private System.Windows.Forms.TabControl item_potion_tab;
        private System.Windows.Forms.TabPage potion_page;
        private System.Windows.Forms.NumericUpDown potioin_second;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown potion_amplifier;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox potion_id;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabControl item_attribute_tab;
        private System.Windows.Forms.TabPage attribute_page;
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
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox can_place;
        private System.Windows.Forms.Button add_place;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox can_destory;
        private System.Windows.Forms.Button add_destory;
        private System.Windows.Forms.TabControl item_enchantment_tab;
        private System.Windows.Forms.TabPage enchantment_page;
        private System.Windows.Forms.NumericUpDown enchantment_level;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox enchantment_id;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TabControl item_tab;
    }
}
