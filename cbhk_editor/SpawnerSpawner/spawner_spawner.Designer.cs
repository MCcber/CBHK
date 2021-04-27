
namespace cbhk_editor.SpawnerSpawner
{
    partial class spawner_spawner
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(spawner_spawner));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Weight:1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Entity");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("SpawnPotentials", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.spawner_title_menu = new System.Windows.Forms.MenuStrip();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.生成返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_spawn = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_return = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于刷怪笼ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nbt_area = new System.Windows.Forms.GroupBox();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SpawnRangeBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.SetSpawnData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SpawnCountBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.MinSpawnDelayBox = new System.Windows.Forms.NumericUpDown();
            this.DelayBox = new System.Windows.Forms.NumericUpDown();
            this.MaxSpawnDelayBox = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RequiredPlayerRangeBox = new System.Windows.Forms.NumericUpDown();
            this.MaxNearbyEntitiesBox = new System.Windows.Forms.NumericUpDown();
            this.nbt_view = new System.Windows.Forms.TreeView();
            this.spawner_rclick_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.add_rclick = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_rclick = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_rclick = new System.Windows.Forms.ToolStripMenuItem();
            this.spawner_title_menu.SuspendLayout();
            this.nbt_area.SuspendLayout();
            this.table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpawnRangeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpawnCountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinSpawnDelayBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSpawnDelayBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequiredPlayerRangeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxNearbyEntitiesBox)).BeginInit();
            this.spawner_rclick_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // spawner_title_menu
            // 
            this.spawner_title_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.spawner_title_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑EToolStripMenuItem,
            this.生成返回ToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.spawner_title_menu.Location = new System.Drawing.Point(0, 0);
            this.spawner_title_menu.Name = "spawner_title_menu";
            this.spawner_title_menu.Size = new System.Drawing.Size(501, 25);
            this.spawner_title_menu.TabIndex = 0;
            this.spawner_title_menu.Text = "menuStrip1";
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_menu,
            this.delete_menu,
            this.clear_menu});
            this.编辑EToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.编辑EToolStripMenuItem.Text = "编辑&E";
            // 
            // add_menu
            // 
            this.add_menu.Name = "add_menu";
            this.add_menu.Size = new System.Drawing.Size(129, 22);
            this.add_menu.Text = "添加/修改";
            this.add_menu.Click += new System.EventHandler(this.add_menu_Click);
            // 
            // delete_menu
            // 
            this.delete_menu.Name = "delete_menu";
            this.delete_menu.Size = new System.Drawing.Size(129, 22);
            this.delete_menu.Text = "删除";
            this.delete_menu.Click += new System.EventHandler(this.delete_menu_Click);
            // 
            // clear_menu
            // 
            this.clear_menu.Name = "clear_menu";
            this.clear_menu.Size = new System.Drawing.Size(129, 22);
            this.clear_menu.Text = "清空";
            this.clear_menu.Click += new System.EventHandler(this.clear_menu_Click);
            // 
            // 生成返回ToolStripMenuItem
            // 
            this.生成返回ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.click_to_spawn,
            this.click_to_return});
            this.生成返回ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.生成返回ToolStripMenuItem.Name = "生成返回ToolStripMenuItem";
            this.生成返回ToolStripMenuItem.Size = new System.Drawing.Size(81, 21);
            this.生成返回ToolStripMenuItem.Text = "生成-返回&R";
            // 
            // click_to_spawn
            // 
            this.click_to_spawn.Name = "click_to_spawn";
            this.click_to_spawn.Size = new System.Drawing.Size(100, 22);
            this.click_to_spawn.Text = "生成";
            this.click_to_spawn.Click += new System.EventHandler(this.click_to_spawn_Click);
            // 
            // click_to_return
            // 
            this.click_to_return.Name = "click_to_return";
            this.click_to_return.Size = new System.Drawing.Size(100, 22);
            this.click_to_return.Text = "返回";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于刷怪笼ToolStripMenuItem});
            this.帮助HToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.帮助HToolStripMenuItem.Text = "帮助&H";
            // 
            // 关于刷怪笼ToolStripMenuItem
            // 
            this.关于刷怪笼ToolStripMenuItem.Name = "关于刷怪笼ToolStripMenuItem";
            this.关于刷怪笼ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.关于刷怪笼ToolStripMenuItem.Text = "关于刷怪笼";
            // 
            // nbt_area
            // 
            this.nbt_area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nbt_area.Controls.Add(this.table);
            this.nbt_area.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nbt_area.ForeColor = System.Drawing.Color.White;
            this.nbt_area.Location = new System.Drawing.Point(0, 292);
            this.nbt_area.Name = "nbt_area";
            this.nbt_area.Size = new System.Drawing.Size(501, 122);
            this.nbt_area.TabIndex = 1;
            this.nbt_area.TabStop = false;
            this.nbt_area.Text = "设置NBT";
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 5;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.table.Controls.Add(this.label5, 0, 2);
            this.table.Controls.Add(this.label4, 0, 1);
            this.table.Controls.Add(this.SpawnRangeBox, 4, 0);
            this.table.Controls.Add(this.label2, 3, 0);
            this.table.Controls.Add(this.SetSpawnData, 0, 0);
            this.table.Controls.Add(this.label1, 1, 0);
            this.table.Controls.Add(this.SpawnCountBox, 2, 0);
            this.table.Controls.Add(this.label3, 2, 1);
            this.table.Controls.Add(this.MinSpawnDelayBox, 3, 1);
            this.table.Controls.Add(this.DelayBox, 1, 1);
            this.table.Controls.Add(this.MaxSpawnDelayBox, 1, 2);
            this.table.Controls.Add(this.label7, 2, 2);
            this.table.Controls.Add(this.label6, 0, 3);
            this.table.Controls.Add(this.RequiredPlayerRangeBox, 4, 2);
            this.table.Controls.Add(this.MaxNearbyEntitiesBox, 1, 3);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(3, 17);
            this.table.Name = "table";
            this.table.RowCount = 4;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.table.Size = new System.Drawing.Size(495, 102);
            this.table.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "MaxSpawnDelay:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Delay:";
            // 
            // SpawnRangeBox
            // 
            this.SpawnRangeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SpawnRangeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SpawnRangeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpawnRangeBox.ForeColor = System.Drawing.Color.White;
            this.SpawnRangeBox.Location = new System.Drawing.Point(386, 3);
            this.SpawnRangeBox.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.SpawnRangeBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpawnRangeBox.Name = "SpawnRangeBox";
            this.SpawnRangeBox.Size = new System.Drawing.Size(106, 17);
            this.SpawnRangeBox.TabIndex = 4;
            this.SpawnRangeBox.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "SpawnRange:";
            // 
            // SetSpawnData
            // 
            this.SetSpawnData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SetSpawnData.BackgroundImage")));
            this.SetSpawnData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SetSpawnData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetSpawnData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetSpawnData.FlatAppearance.BorderSize = 0;
            this.SetSpawnData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SetSpawnData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SetSpawnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetSpawnData.Location = new System.Drawing.Point(3, 3);
            this.SetSpawnData.Name = "SetSpawnData";
            this.SetSpawnData.Size = new System.Drawing.Size(116, 22);
            this.SetSpawnData.TabIndex = 0;
            this.SetSpawnData.Text = "点击设置SpawnData";
            this.SetSpawnData.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "SpawnCount:";
            // 
            // SpawnCountBox
            // 
            this.SpawnCountBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SpawnCountBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SpawnCountBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SpawnCountBox.ForeColor = System.Drawing.Color.White;
            this.SpawnCountBox.Location = new System.Drawing.Point(202, 5);
            this.SpawnCountBox.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.SpawnCountBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpawnCountBox.Name = "SpawnCountBox";
            this.SpawnCountBox.Size = new System.Drawing.Size(100, 17);
            this.SpawnCountBox.TabIndex = 2;
            this.SpawnCountBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.table.SetColumnSpan(this.label3, 2);
            this.label3.Location = new System.Drawing.Point(291, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "MinSpawnDelay:";
            // 
            // MinSpawnDelayBox
            // 
            this.MinSpawnDelayBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MinSpawnDelayBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MinSpawnDelayBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinSpawnDelayBox.ForeColor = System.Drawing.Color.White;
            this.MinSpawnDelayBox.Location = new System.Drawing.Point(386, 31);
            this.MinSpawnDelayBox.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.MinSpawnDelayBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinSpawnDelayBox.Name = "MinSpawnDelayBox";
            this.MinSpawnDelayBox.Size = new System.Drawing.Size(106, 17);
            this.MinSpawnDelayBox.TabIndex = 8;
            this.MinSpawnDelayBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DelayBox
            // 
            this.DelayBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DelayBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DelayBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DelayBox.ForeColor = System.Drawing.Color.White;
            this.DelayBox.Location = new System.Drawing.Point(125, 31);
            this.DelayBox.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.DelayBox.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.DelayBox.Name = "DelayBox";
            this.DelayBox.Size = new System.Drawing.Size(71, 17);
            this.DelayBox.TabIndex = 6;
            // 
            // MaxSpawnDelayBox
            // 
            this.MaxSpawnDelayBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MaxSpawnDelayBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MaxSpawnDelayBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaxSpawnDelayBox.ForeColor = System.Drawing.Color.White;
            this.MaxSpawnDelayBox.Location = new System.Drawing.Point(125, 54);
            this.MaxSpawnDelayBox.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.MaxSpawnDelayBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxSpawnDelayBox.Name = "MaxSpawnDelayBox";
            this.MaxSpawnDelayBox.Size = new System.Drawing.Size(71, 17);
            this.MaxSpawnDelayBox.TabIndex = 10;
            this.MaxSpawnDelayBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.table.SetColumnSpan(this.label7, 2);
            this.label7.Location = new System.Drawing.Point(255, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "RequiredPlayerRange:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "MaxNearbyEntities:";
            // 
            // RequiredPlayerRangeBox
            // 
            this.RequiredPlayerRangeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.RequiredPlayerRangeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RequiredPlayerRangeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RequiredPlayerRangeBox.ForeColor = System.Drawing.Color.White;
            this.RequiredPlayerRangeBox.Location = new System.Drawing.Point(386, 54);
            this.RequiredPlayerRangeBox.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.RequiredPlayerRangeBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RequiredPlayerRangeBox.Name = "RequiredPlayerRangeBox";
            this.RequiredPlayerRangeBox.Size = new System.Drawing.Size(106, 17);
            this.RequiredPlayerRangeBox.TabIndex = 14;
            this.RequiredPlayerRangeBox.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // MaxNearbyEntitiesBox
            // 
            this.MaxNearbyEntitiesBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MaxNearbyEntitiesBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MaxNearbyEntitiesBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaxNearbyEntitiesBox.ForeColor = System.Drawing.Color.White;
            this.MaxNearbyEntitiesBox.Location = new System.Drawing.Point(125, 80);
            this.MaxNearbyEntitiesBox.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.MaxNearbyEntitiesBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxNearbyEntitiesBox.Name = "MaxNearbyEntitiesBox";
            this.MaxNearbyEntitiesBox.Size = new System.Drawing.Size(71, 17);
            this.MaxNearbyEntitiesBox.TabIndex = 12;
            this.MaxNearbyEntitiesBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nbt_view
            // 
            this.nbt_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nbt_view.ContextMenuStrip = this.spawner_rclick_menu;
            this.nbt_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nbt_view.ForeColor = System.Drawing.Color.White;
            this.nbt_view.Location = new System.Drawing.Point(0, 25);
            this.nbt_view.Name = "nbt_view";
            treeNode1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            treeNode1.ForeColor = System.Drawing.Color.White;
            treeNode1.Name = "value:int";
            treeNode1.Text = "Weight:1";
            treeNode2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            treeNode2.ForeColor = System.Drawing.Color.White;
            treeNode2.Name = "a_entity";
            treeNode2.Text = "Entity";
            treeNode3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            treeNode3.ForeColor = System.Drawing.Color.White;
            treeNode3.Name = "ele";
            treeNode3.Text = "1";
            treeNode4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            treeNode4.ForeColor = System.Drawing.Color.White;
            treeNode4.Name = "arraynode";
            treeNode4.Text = "SpawnPotentials";
            this.nbt_view.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.nbt_view.Size = new System.Drawing.Size(501, 267);
            this.nbt_view.TabIndex = 2;
            this.nbt_view.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nbt_view_MouseDown);
            // 
            // spawner_rclick_menu
            // 
            this.spawner_rclick_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_rclick,
            this.delete_rclick,
            this.clear_rclick});
            this.spawner_rclick_menu.Name = "spawner_rclick_menu";
            this.spawner_rclick_menu.Size = new System.Drawing.Size(130, 70);
            // 
            // add_rclick
            // 
            this.add_rclick.Name = "add_rclick";
            this.add_rclick.Size = new System.Drawing.Size(129, 22);
            this.add_rclick.Text = "添加/修改";
            this.add_rclick.Click += new System.EventHandler(this.add_rclick_Click);
            // 
            // delete_rclick
            // 
            this.delete_rclick.Name = "delete_rclick";
            this.delete_rclick.Size = new System.Drawing.Size(129, 22);
            this.delete_rclick.Text = "删除";
            this.delete_rclick.Click += new System.EventHandler(this.delete_rclick_Click);
            // 
            // clear_rclick
            // 
            this.clear_rclick.Name = "clear_rclick";
            this.clear_rclick.Size = new System.Drawing.Size(129, 22);
            this.clear_rclick.Text = "清空";
            this.clear_rclick.Click += new System.EventHandler(this.clear_rclick_Click);
            // 
            // spawner_spawner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(501, 414);
            this.Controls.Add(this.nbt_view);
            this.Controls.Add(this.nbt_area);
            this.Controls.Add(this.spawner_title_menu);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.spawner_title_menu;
            this.Name = "spawner_spawner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "刷怪笼生成器";
            this.spawner_title_menu.ResumeLayout(false);
            this.spawner_title_menu.PerformLayout();
            this.nbt_area.ResumeLayout(false);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpawnRangeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpawnCountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinSpawnDelayBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSpawnDelayBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequiredPlayerRangeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxNearbyEntitiesBox)).EndInit();
            this.spawner_rclick_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip spawner_title_menu;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_menu;
        private System.Windows.Forms.ToolStripMenuItem delete_menu;
        private System.Windows.Forms.ToolStripMenuItem clear_menu;
        private System.Windows.Forms.GroupBox nbt_area;
        private System.Windows.Forms.TreeView nbt_view;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Button SetSpawnData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown SpawnCountBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown SpawnRangeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown DelayBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown MinSpawnDelayBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown MaxSpawnDelayBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown MaxNearbyEntitiesBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown RequiredPlayerRangeBox;
        private System.Windows.Forms.ToolStripMenuItem 生成返回ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem click_to_spawn;
        private System.Windows.Forms.ToolStripMenuItem click_to_return;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip spawner_rclick_menu;
        private System.Windows.Forms.ToolStripMenuItem add_rclick;
        private System.Windows.Forms.ToolStripMenuItem delete_rclick;
        private System.Windows.Forms.ToolStripMenuItem clear_rclick;
        private System.Windows.Forms.ToolStripMenuItem 关于刷怪笼ToolStripMenuItem;
    }
}