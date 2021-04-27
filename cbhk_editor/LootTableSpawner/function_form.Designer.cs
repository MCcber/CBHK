
namespace cbhk_editor.LootTableSpawner
{
    partial class function_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.function_title_menu = new System.Windows.Forms.MenuStrip();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.function_tab = new System.Windows.Forms.TabControl();
            this.apply_bonus_page = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.copy_nbt_page = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.copy_state_page = new System.Windows.Forms.TabPage();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.enchant_randomly_page = new System.Windows.Forms.TabPage();
            this.tabControl5 = new System.Windows.Forms.TabControl();
            this.enchant_with_levels_page = new System.Windows.Forms.TabPage();
            this.tabControl6 = new System.Windows.Forms.TabControl();
            this.exploration_map_page = new System.Windows.Forms.TabPage();
            this.tabControl7 = new System.Windows.Forms.TabControl();
            this.fill_player_head_page = new System.Windows.Forms.TabPage();
            this.tabControl8 = new System.Windows.Forms.TabControl();
            this.limit_count_page = new System.Windows.Forms.TabPage();
            this.tabControl9 = new System.Windows.Forms.TabControl();
            this.looting_enchant_page = new System.Windows.Forms.TabPage();
            this.tabControl10 = new System.Windows.Forms.TabControl();
            this.set_attributes_page = new System.Windows.Forms.TabPage();
            this.tabControl11 = new System.Windows.Forms.TabControl();
            this.set_contents_page = new System.Windows.Forms.TabPage();
            this.tabControl12 = new System.Windows.Forms.TabControl();
            this.set_count_page = new System.Windows.Forms.TabPage();
            this.tabControl13 = new System.Windows.Forms.TabControl();
            this.set_damage_page = new System.Windows.Forms.TabPage();
            this.tabControl14 = new System.Windows.Forms.TabControl();
            this.set_lore_page = new System.Windows.Forms.TabPage();
            this.tabControl15 = new System.Windows.Forms.TabControl();
            this.set_name_page = new System.Windows.Forms.TabPage();
            this.tabControl16 = new System.Windows.Forms.TabControl();
            this.set_nbt_page = new System.Windows.Forms.TabPage();
            this.tabControl17 = new System.Windows.Forms.TabControl();
            this.set_stew_effect_page = new System.Windows.Forms.TabPage();
            this.tabControl18 = new System.Windows.Forms.TabControl();
            this.set_loot_table = new System.Windows.Forms.TabPage();
            this.tabControl19 = new System.Windows.Forms.TabControl();
            this.explosion_decay = new System.Windows.Forms.ToolStripMenuItem();
            this.furnace_smelt = new System.Windows.Forms.ToolStripMenuItem();
            this.function_title_menu.SuspendLayout();
            this.function_tab.SuspendLayout();
            this.apply_bonus_page.SuspendLayout();
            this.copy_nbt_page.SuspendLayout();
            this.copy_state_page.SuspendLayout();
            this.enchant_randomly_page.SuspendLayout();
            this.enchant_with_levels_page.SuspendLayout();
            this.exploration_map_page.SuspendLayout();
            this.fill_player_head_page.SuspendLayout();
            this.limit_count_page.SuspendLayout();
            this.looting_enchant_page.SuspendLayout();
            this.set_attributes_page.SuspendLayout();
            this.set_contents_page.SuspendLayout();
            this.set_count_page.SuspendLayout();
            this.set_damage_page.SuspendLayout();
            this.set_lore_page.SuspendLayout();
            this.set_name_page.SuspendLayout();
            this.set_nbt_page.SuspendLayout();
            this.set_stew_effect_page.SuspendLayout();
            this.set_loot_table.SuspendLayout();
            this.SuspendLayout();
            // 
            // function_title_menu
            // 
            this.function_title_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.function_title_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑ToolStripMenuItem});
            this.function_title_menu.Location = new System.Drawing.Point(0, 0);
            this.function_title_menu.Name = "function_title_menu";
            this.function_title_menu.Size = new System.Drawing.Size(573, 25);
            this.function_title_menu.TabIndex = 0;
            this.function_title_menu.Text = "menuStrip1";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add,
            this.delete,
            this.clear});
            this.编辑ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.编辑ToolStripMenuItem.Text = "编辑&E";
            // 
            // add
            // 
            this.add.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.explosion_decay,
            this.furnace_smelt});
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(180, 22);
            this.add.Text = "添加";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(180, 22);
            this.delete.Text = "删除";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // clear
            // 
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(180, 22);
            this.clear.Text = "清空";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // function_tab
            // 
            this.function_tab.Controls.Add(this.apply_bonus_page);
            this.function_tab.Controls.Add(this.copy_nbt_page);
            this.function_tab.Controls.Add(this.copy_state_page);
            this.function_tab.Controls.Add(this.enchant_randomly_page);
            this.function_tab.Controls.Add(this.enchant_with_levels_page);
            this.function_tab.Controls.Add(this.exploration_map_page);
            this.function_tab.Controls.Add(this.fill_player_head_page);
            this.function_tab.Controls.Add(this.limit_count_page);
            this.function_tab.Controls.Add(this.looting_enchant_page);
            this.function_tab.Controls.Add(this.set_attributes_page);
            this.function_tab.Controls.Add(this.set_contents_page);
            this.function_tab.Controls.Add(this.set_count_page);
            this.function_tab.Controls.Add(this.set_damage_page);
            this.function_tab.Controls.Add(this.set_lore_page);
            this.function_tab.Controls.Add(this.set_name_page);
            this.function_tab.Controls.Add(this.set_nbt_page);
            this.function_tab.Controls.Add(this.set_stew_effect_page);
            this.function_tab.Controls.Add(this.set_loot_table);
            this.function_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.function_tab.Location = new System.Drawing.Point(0, 25);
            this.function_tab.Name = "function_tab";
            this.function_tab.SelectedIndex = 0;
            this.function_tab.Size = new System.Drawing.Size(573, 358);
            this.function_tab.TabIndex = 1;
            this.function_tab.SelectedIndexChanged += new System.EventHandler(this.function_tab_SelectedIndexChanged);
            // 
            // apply_bonus_page
            // 
            this.apply_bonus_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.apply_bonus_page.Controls.Add(this.tabControl1);
            this.apply_bonus_page.Location = new System.Drawing.Point(4, 22);
            this.apply_bonus_page.Name = "apply_bonus_page";
            this.apply_bonus_page.Padding = new System.Windows.Forms.Padding(3);
            this.apply_bonus_page.Size = new System.Drawing.Size(565, 332);
            this.apply_bonus_page.TabIndex = 0;
            this.apply_bonus_page.Text = "物品数量";
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(15, 15);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(559, 326);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // copy_nbt_page
            // 
            this.copy_nbt_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.copy_nbt_page.Controls.Add(this.tabControl3);
            this.copy_nbt_page.Location = new System.Drawing.Point(4, 22);
            this.copy_nbt_page.Name = "copy_nbt_page";
            this.copy_nbt_page.Size = new System.Drawing.Size(565, 332);
            this.copy_nbt_page.TabIndex = 2;
            this.copy_nbt_page.Text = "复制NBT";
            // 
            // tabControl3
            // 
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.ItemSize = new System.Drawing.Size(15, 15);
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(565, 332);
            this.tabControl3.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl3.TabIndex = 3;
            // 
            // copy_state_page
            // 
            this.copy_state_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.copy_state_page.Controls.Add(this.tabControl4);
            this.copy_state_page.Location = new System.Drawing.Point(4, 22);
            this.copy_state_page.Name = "copy_state_page";
            this.copy_state_page.Size = new System.Drawing.Size(565, 332);
            this.copy_state_page.TabIndex = 3;
            this.copy_state_page.Text = "复制状态";
            // 
            // tabControl4
            // 
            this.tabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl4.ItemSize = new System.Drawing.Size(15, 15);
            this.tabControl4.Location = new System.Drawing.Point(0, 0);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(565, 332);
            this.tabControl4.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl4.TabIndex = 3;
            // 
            // enchant_randomly_page
            // 
            this.enchant_randomly_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.enchant_randomly_page.Controls.Add(this.tabControl5);
            this.enchant_randomly_page.Location = new System.Drawing.Point(4, 22);
            this.enchant_randomly_page.Name = "enchant_randomly_page";
            this.enchant_randomly_page.Size = new System.Drawing.Size(565, 332);
            this.enchant_randomly_page.TabIndex = 4;
            this.enchant_randomly_page.Text = "随机附魔";
            // 
            // tabControl5
            // 
            this.tabControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl5.ItemSize = new System.Drawing.Size(15, 15);
            this.tabControl5.Location = new System.Drawing.Point(0, 0);
            this.tabControl5.Name = "tabControl5";
            this.tabControl5.SelectedIndex = 0;
            this.tabControl5.Size = new System.Drawing.Size(565, 332);
            this.tabControl5.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl5.TabIndex = 3;
            // 
            // enchant_with_levels_page
            // 
            this.enchant_with_levels_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.enchant_with_levels_page.Controls.Add(this.tabControl6);
            this.enchant_with_levels_page.Location = new System.Drawing.Point(4, 22);
            this.enchant_with_levels_page.Name = "enchant_with_levels_page";
            this.enchant_with_levels_page.Size = new System.Drawing.Size(565, 332);
            this.enchant_with_levels_page.TabIndex = 5;
            this.enchant_with_levels_page.Text = "等量附魔";
            // 
            // tabControl6
            // 
            this.tabControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl6.ItemSize = new System.Drawing.Size(15, 15);
            this.tabControl6.Location = new System.Drawing.Point(0, 0);
            this.tabControl6.Name = "tabControl6";
            this.tabControl6.SelectedIndex = 0;
            this.tabControl6.Size = new System.Drawing.Size(565, 332);
            this.tabControl6.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl6.TabIndex = 3;
            // 
            // exploration_map_page
            // 
            this.exploration_map_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.exploration_map_page.Controls.Add(this.tabControl7);
            this.exploration_map_page.Location = new System.Drawing.Point(4, 22);
            this.exploration_map_page.Name = "exploration_map_page";
            this.exploration_map_page.Size = new System.Drawing.Size(565, 332);
            this.exploration_map_page.TabIndex = 6;
            this.exploration_map_page.Text = "转换地图";
            // 
            // tabControl7
            // 
            this.tabControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl7.ItemSize = new System.Drawing.Size(15, 15);
            this.tabControl7.Location = new System.Drawing.Point(0, 0);
            this.tabControl7.Name = "tabControl7";
            this.tabControl7.SelectedIndex = 0;
            this.tabControl7.Size = new System.Drawing.Size(565, 332);
            this.tabControl7.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl7.TabIndex = 3;
            // 
            // fill_player_head_page
            // 
            this.fill_player_head_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.fill_player_head_page.Controls.Add(this.tabControl8);
            this.fill_player_head_page.Location = new System.Drawing.Point(4, 22);
            this.fill_player_head_page.Name = "fill_player_head_page";
            this.fill_player_head_page.Size = new System.Drawing.Size(565, 332);
            this.fill_player_head_page.TabIndex = 7;
            this.fill_player_head_page.Text = "设置头颅";
            // 
            // tabControl8
            // 
            this.tabControl8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl8.ItemSize = new System.Drawing.Size(15, 15);
            this.tabControl8.Location = new System.Drawing.Point(0, 0);
            this.tabControl8.Name = "tabControl8";
            this.tabControl8.SelectedIndex = 0;
            this.tabControl8.Size = new System.Drawing.Size(565, 332);
            this.tabControl8.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl8.TabIndex = 3;
            // 
            // limit_count_page
            // 
            this.limit_count_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.limit_count_page.Controls.Add(this.tabControl9);
            this.limit_count_page.Location = new System.Drawing.Point(4, 22);
            this.limit_count_page.Name = "limit_count_page";
            this.limit_count_page.Size = new System.Drawing.Size(565, 332);
            this.limit_count_page.TabIndex = 8;
            this.limit_count_page.Text = "限制数量";
            // 
            // tabControl9
            // 
            this.tabControl9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl9.ItemSize = new System.Drawing.Size(15, 15);
            this.tabControl9.Location = new System.Drawing.Point(0, 0);
            this.tabControl9.Name = "tabControl9";
            this.tabControl9.SelectedIndex = 0;
            this.tabControl9.Size = new System.Drawing.Size(565, 332);
            this.tabControl9.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl9.TabIndex = 3;
            // 
            // looting_enchant_page
            // 
            this.looting_enchant_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.looting_enchant_page.Controls.Add(this.tabControl10);
            this.looting_enchant_page.Location = new System.Drawing.Point(4, 22);
            this.looting_enchant_page.Name = "looting_enchant_page";
            this.looting_enchant_page.Size = new System.Drawing.Size(565, 332);
            this.looting_enchant_page.TabIndex = 9;
            this.looting_enchant_page.Text = "设置抢夺";
            // 
            // tabControl10
            // 
            this.tabControl10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl10.ItemSize = new System.Drawing.Size(15, 15);
            this.tabControl10.Location = new System.Drawing.Point(0, 0);
            this.tabControl10.Name = "tabControl10";
            this.tabControl10.SelectedIndex = 0;
            this.tabControl10.Size = new System.Drawing.Size(565, 332);
            this.tabControl10.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl10.TabIndex = 3;
            // 
            // set_attributes_page
            // 
            this.set_attributes_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.set_attributes_page.Controls.Add(this.tabControl11);
            this.set_attributes_page.Location = new System.Drawing.Point(4, 22);
            this.set_attributes_page.Name = "set_attributes_page";
            this.set_attributes_page.Size = new System.Drawing.Size(565, 332);
            this.set_attributes_page.TabIndex = 10;
            this.set_attributes_page.Text = "控制属性";
            // 
            // tabControl11
            // 
            this.tabControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl11.ItemSize = new System.Drawing.Size(15, 15);
            this.tabControl11.Location = new System.Drawing.Point(0, 0);
            this.tabControl11.Name = "tabControl11";
            this.tabControl11.SelectedIndex = 0;
            this.tabControl11.Size = new System.Drawing.Size(565, 332);
            this.tabControl11.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl11.TabIndex = 3;
            // 
            // set_contents_page
            // 
            this.set_contents_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.set_contents_page.Controls.Add(this.tabControl12);
            this.set_contents_page.Location = new System.Drawing.Point(4, 22);
            this.set_contents_page.Name = "set_contents_page";
            this.set_contents_page.Size = new System.Drawing.Size(565, 332);
            this.set_contents_page.TabIndex = 11;
            this.set_contents_page.Text = "设置容器";
            // 
            // tabControl12
            // 
            this.tabControl12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl12.ItemSize = new System.Drawing.Size(15, 15);
            this.tabControl12.Location = new System.Drawing.Point(0, 0);
            this.tabControl12.Name = "tabControl12";
            this.tabControl12.SelectedIndex = 0;
            this.tabControl12.Size = new System.Drawing.Size(565, 332);
            this.tabControl12.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl12.TabIndex = 3;
            // 
            // set_count_page
            // 
            this.set_count_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.set_count_page.Controls.Add(this.tabControl13);
            this.set_count_page.Location = new System.Drawing.Point(4, 22);
            this.set_count_page.Name = "set_count_page";
            this.set_count_page.Size = new System.Drawing.Size(565, 332);
            this.set_count_page.TabIndex = 12;
            this.set_count_page.Text = "设置数量";
            // 
            // tabControl13
            // 
            this.tabControl13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl13.ItemSize = new System.Drawing.Size(15, 15);
            this.tabControl13.Location = new System.Drawing.Point(0, 0);
            this.tabControl13.Name = "tabControl13";
            this.tabControl13.SelectedIndex = 0;
            this.tabControl13.Size = new System.Drawing.Size(565, 332);
            this.tabControl13.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl13.TabIndex = 3;
            // 
            // set_damage_page
            // 
            this.set_damage_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.set_damage_page.Controls.Add(this.tabControl14);
            this.set_damage_page.Location = new System.Drawing.Point(4, 22);
            this.set_damage_page.Name = "set_damage_page";
            this.set_damage_page.Size = new System.Drawing.Size(565, 332);
            this.set_damage_page.TabIndex = 13;
            this.set_damage_page.Text = "设置耐久";
            // 
            // tabControl14
            // 
            this.tabControl14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl14.ItemSize = new System.Drawing.Size(15, 15);
            this.tabControl14.Location = new System.Drawing.Point(0, 0);
            this.tabControl14.Name = "tabControl14";
            this.tabControl14.SelectedIndex = 0;
            this.tabControl14.Size = new System.Drawing.Size(565, 332);
            this.tabControl14.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl14.TabIndex = 3;
            // 
            // set_lore_page
            // 
            this.set_lore_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.set_lore_page.Controls.Add(this.tabControl15);
            this.set_lore_page.Location = new System.Drawing.Point(4, 22);
            this.set_lore_page.Name = "set_lore_page";
            this.set_lore_page.Size = new System.Drawing.Size(565, 332);
            this.set_lore_page.TabIndex = 14;
            this.set_lore_page.Text = "设置描述";
            // 
            // tabControl15
            // 
            this.tabControl15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl15.ItemSize = new System.Drawing.Size(15, 15);
            this.tabControl15.Location = new System.Drawing.Point(0, 0);
            this.tabControl15.Name = "tabControl15";
            this.tabControl15.SelectedIndex = 0;
            this.tabControl15.Size = new System.Drawing.Size(565, 332);
            this.tabControl15.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl15.TabIndex = 3;
            // 
            // set_name_page
            // 
            this.set_name_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.set_name_page.Controls.Add(this.tabControl16);
            this.set_name_page.Location = new System.Drawing.Point(4, 22);
            this.set_name_page.Name = "set_name_page";
            this.set_name_page.Size = new System.Drawing.Size(565, 332);
            this.set_name_page.TabIndex = 15;
            this.set_name_page.Text = "设置名称";
            // 
            // tabControl16
            // 
            this.tabControl16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl16.ItemSize = new System.Drawing.Size(15, 15);
            this.tabControl16.Location = new System.Drawing.Point(0, 0);
            this.tabControl16.Name = "tabControl16";
            this.tabControl16.SelectedIndex = 0;
            this.tabControl16.Size = new System.Drawing.Size(565, 332);
            this.tabControl16.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl16.TabIndex = 3;
            // 
            // set_nbt_page
            // 
            this.set_nbt_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.set_nbt_page.Controls.Add(this.tabControl17);
            this.set_nbt_page.Location = new System.Drawing.Point(4, 22);
            this.set_nbt_page.Name = "set_nbt_page";
            this.set_nbt_page.Size = new System.Drawing.Size(565, 332);
            this.set_nbt_page.TabIndex = 16;
            this.set_nbt_page.Text = "设置NBT";
            // 
            // tabControl17
            // 
            this.tabControl17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl17.ItemSize = new System.Drawing.Size(15, 15);
            this.tabControl17.Location = new System.Drawing.Point(0, 0);
            this.tabControl17.Name = "tabControl17";
            this.tabControl17.SelectedIndex = 0;
            this.tabControl17.Size = new System.Drawing.Size(565, 332);
            this.tabControl17.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl17.TabIndex = 3;
            // 
            // set_stew_effect_page
            // 
            this.set_stew_effect_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.set_stew_effect_page.Controls.Add(this.tabControl18);
            this.set_stew_effect_page.Location = new System.Drawing.Point(4, 22);
            this.set_stew_effect_page.Name = "set_stew_effect_page";
            this.set_stew_effect_page.Size = new System.Drawing.Size(565, 332);
            this.set_stew_effect_page.TabIndex = 17;
            this.set_stew_effect_page.Text = "设置谜之炖菜";
            // 
            // tabControl18
            // 
            this.tabControl18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl18.ItemSize = new System.Drawing.Size(15, 15);
            this.tabControl18.Location = new System.Drawing.Point(0, 0);
            this.tabControl18.Name = "tabControl18";
            this.tabControl18.SelectedIndex = 0;
            this.tabControl18.Size = new System.Drawing.Size(565, 332);
            this.tabControl18.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl18.TabIndex = 3;
            // 
            // set_loot_table
            // 
            this.set_loot_table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.set_loot_table.Controls.Add(this.tabControl19);
            this.set_loot_table.Location = new System.Drawing.Point(4, 22);
            this.set_loot_table.Name = "set_loot_table";
            this.set_loot_table.Size = new System.Drawing.Size(565, 332);
            this.set_loot_table.TabIndex = 18;
            this.set_loot_table.Text = "设置战利品表";
            // 
            // tabControl19
            // 
            this.tabControl19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl19.ItemSize = new System.Drawing.Size(15, 15);
            this.tabControl19.Location = new System.Drawing.Point(0, 0);
            this.tabControl19.Name = "tabControl19";
            this.tabControl19.SelectedIndex = 0;
            this.tabControl19.Size = new System.Drawing.Size(565, 332);
            this.tabControl19.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl19.TabIndex = 3;
            // 
            // explosion_decay
            // 
            this.explosion_decay.Name = "explosion_decay";
            this.explosion_decay.Size = new System.Drawing.Size(180, 22);
            this.explosion_decay.Text = "爆炸损失";
            // 
            // furnace_smelt
            // 
            this.furnace_smelt.Name = "furnace_smelt";
            this.furnace_smelt.Size = new System.Drawing.Size(180, 22);
            this.furnace_smelt.Text = "被熔炼";
            // 
            // function_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(573, 383);
            this.Controls.Add(this.function_tab);
            this.Controls.Add(this.function_title_menu);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.function_title_menu;
            this.MaximizeBox = false;
            this.Name = "function_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "函数";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.function_form_FormClosing);
            this.function_title_menu.ResumeLayout(false);
            this.function_title_menu.PerformLayout();
            this.function_tab.ResumeLayout(false);
            this.apply_bonus_page.ResumeLayout(false);
            this.copy_nbt_page.ResumeLayout(false);
            this.copy_state_page.ResumeLayout(false);
            this.enchant_randomly_page.ResumeLayout(false);
            this.enchant_with_levels_page.ResumeLayout(false);
            this.exploration_map_page.ResumeLayout(false);
            this.fill_player_head_page.ResumeLayout(false);
            this.limit_count_page.ResumeLayout(false);
            this.looting_enchant_page.ResumeLayout(false);
            this.set_attributes_page.ResumeLayout(false);
            this.set_contents_page.ResumeLayout(false);
            this.set_count_page.ResumeLayout(false);
            this.set_damage_page.ResumeLayout(false);
            this.set_lore_page.ResumeLayout(false);
            this.set_name_page.ResumeLayout(false);
            this.set_nbt_page.ResumeLayout(false);
            this.set_stew_effect_page.ResumeLayout(false);
            this.set_loot_table.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip function_title_menu;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.ToolStripMenuItem clear;
        private System.Windows.Forms.TabPage apply_bonus_page;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage copy_nbt_page;
        private System.Windows.Forms.TabPage copy_state_page;
        private System.Windows.Forms.TabPage enchant_randomly_page;
        private System.Windows.Forms.TabPage enchant_with_levels_page;
        private System.Windows.Forms.TabPage exploration_map_page;
        private System.Windows.Forms.TabPage fill_player_head_page;
        private System.Windows.Forms.TabPage limit_count_page;
        private System.Windows.Forms.TabPage looting_enchant_page;
        private System.Windows.Forms.TabPage set_attributes_page;
        private System.Windows.Forms.TabPage set_contents_page;
        private System.Windows.Forms.TabPage set_count_page;
        private System.Windows.Forms.TabPage set_damage_page;
        private System.Windows.Forms.TabPage set_lore_page;
        private System.Windows.Forms.TabPage set_name_page;
        private System.Windows.Forms.TabPage set_nbt_page;
        private System.Windows.Forms.TabPage set_stew_effect_page;
        private System.Windows.Forms.TabPage set_loot_table;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabControl tabControl5;
        private System.Windows.Forms.TabControl tabControl6;
        private System.Windows.Forms.TabControl tabControl7;
        private System.Windows.Forms.TabControl tabControl8;
        private System.Windows.Forms.TabControl tabControl9;
        private System.Windows.Forms.TabControl tabControl10;
        private System.Windows.Forms.TabControl tabControl11;
        private System.Windows.Forms.TabControl tabControl12;
        private System.Windows.Forms.TabControl tabControl13;
        private System.Windows.Forms.TabControl tabControl14;
        private System.Windows.Forms.TabControl tabControl15;
        private System.Windows.Forms.TabControl tabControl16;
        private System.Windows.Forms.TabControl tabControl17;
        private System.Windows.Forms.TabControl tabControl18;
        private System.Windows.Forms.TabControl tabControl19;
        public System.Windows.Forms.TabControl function_tab;
        private System.Windows.Forms.ToolStripMenuItem explosion_decay;
        private System.Windows.Forms.ToolStripMenuItem furnace_smelt;
    }
}