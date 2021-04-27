
namespace cbhk_editor.VillagerSpawner
{
    partial class villager_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(villager_page));
            this.villager_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.villager_table = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.villager_type_box = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.villager_professional = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.transaction_level_box = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.exp_box = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.version_box = new System.Windows.Forms.ComboBox();
            this.speech_area = new System.Windows.Forms.GroupBox();
            this.value_box = new System.Windows.Forms.NumericUpDown();
            this.target_box = new System.Windows.Forms.TextBox();
            this.targetleast_box = new System.Windows.Forms.TextBox();
            this.targetmost_box = new System.Windows.Forms.TextBox();
            this.random_target = new System.Windows.Forms.Button();
            this.random_targetleast = new System.Windows.Forms.Button();
            this.random_targetmost = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.speech_btn_box = new System.Windows.Forms.ListView();
            this.position_area = new System.Windows.Forms.GroupBox();
            this.pos_z_box = new System.Windows.Forms.TextBox();
            this.pos_y_box = new System.Windows.Forms.TextBox();
            this.pos_x_box = new System.Windows.Forms.TextBox();
            this.memory_btn_box = new System.Windows.Forms.ListView();
            this.dimension_box = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.transaction_tab = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.villager_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.villager_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exp_box)).BeginInit();
            this.speech_area.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.value_box)).BeginInit();
            this.position_area.SuspendLayout();
            this.transaction_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // villager_tab
            // 
            this.villager_tab.Controls.Add(this.tabPage1);
            this.villager_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.villager_tab.Location = new System.Drawing.Point(0, 0);
            this.villager_tab.Name = "villager_tab";
            this.villager_tab.SelectedIndex = 0;
            this.villager_tab.Size = new System.Drawing.Size(602, 396);
            this.villager_tab.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.villager_table);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(594, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "第1个";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // villager_table
            // 
            this.villager_table.BackColor = System.Drawing.Color.Gray;
            this.villager_table.ColumnCount = 10;
            this.villager_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.villager_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.villager_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.villager_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.villager_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.villager_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.villager_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.villager_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.villager_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.villager_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.villager_table.Controls.Add(this.label1, 0, 0);
            this.villager_table.Controls.Add(this.villager_type_box, 1, 0);
            this.villager_table.Controls.Add(this.label2, 2, 0);
            this.villager_table.Controls.Add(this.villager_professional, 3, 0);
            this.villager_table.Controls.Add(this.label3, 4, 0);
            this.villager_table.Controls.Add(this.transaction_level_box, 5, 0);
            this.villager_table.Controls.Add(this.label4, 6, 0);
            this.villager_table.Controls.Add(this.exp_box, 7, 0);
            this.villager_table.Controls.Add(this.label5, 8, 0);
            this.villager_table.Controls.Add(this.version_box, 9, 0);
            this.villager_table.Controls.Add(this.speech_area, 0, 1);
            this.villager_table.Controls.Add(this.position_area, 5, 1);
            this.villager_table.Controls.Add(this.transaction_tab, 0, 2);
            this.villager_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.villager_table.ForeColor = System.Drawing.Color.White;
            this.villager_table.Location = new System.Drawing.Point(3, 3);
            this.villager_table.Name = "villager_table";
            this.villager_table.RowCount = 3;
            this.villager_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.villager_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.villager_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.villager_table.Size = new System.Drawing.Size(588, 364);
            this.villager_table.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "类型:";
            // 
            // villager_type_box
            // 
            this.villager_type_box.BackColor = System.Drawing.Color.Gray;
            this.villager_type_box.ForeColor = System.Drawing.Color.White;
            this.villager_type_box.FormattingEnabled = true;
            this.villager_type_box.Location = new System.Drawing.Point(50, 3);
            this.villager_type_box.Name = "villager_type_box";
            this.villager_type_box.Size = new System.Drawing.Size(86, 20);
            this.villager_type_box.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "职业:";
            // 
            // villager_professional
            // 
            this.villager_professional.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.villager_professional.BackColor = System.Drawing.Color.Gray;
            this.villager_professional.ForeColor = System.Drawing.Color.White;
            this.villager_professional.FormattingEnabled = true;
            this.villager_professional.Location = new System.Drawing.Point(183, 5);
            this.villager_professional.Name = "villager_professional";
            this.villager_professional.Size = new System.Drawing.Size(87, 20);
            this.villager_professional.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "交易等级:";
            // 
            // transaction_level_box
            // 
            this.transaction_level_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.transaction_level_box.BackColor = System.Drawing.Color.Gray;
            this.transaction_level_box.ForeColor = System.Drawing.Color.White;
            this.transaction_level_box.FormattingEnabled = true;
            this.transaction_level_box.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.transaction_level_box.Location = new System.Drawing.Point(342, 5);
            this.transaction_level_box.Name = "transaction_level_box";
            this.transaction_level_box.Size = new System.Drawing.Size(41, 20);
            this.transaction_level_box.TabIndex = 5;
            this.transaction_level_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.transaction_level_box_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "经验值:";
            // 
            // exp_box
            // 
            this.exp_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exp_box.BackColor = System.Drawing.Color.Gray;
            this.exp_box.ForeColor = System.Drawing.Color.White;
            this.exp_box.Location = new System.Drawing.Point(443, 4);
            this.exp_box.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.exp_box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.exp_box.Name = "exp_box";
            this.exp_box.Size = new System.Drawing.Size(38, 21);
            this.exp_box.TabIndex = 7;
            this.exp_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "版本:";
            // 
            // version_box
            // 
            this.version_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.version_box.BackColor = System.Drawing.Color.Gray;
            this.version_box.ForeColor = System.Drawing.Color.White;
            this.version_box.FormattingEnabled = true;
            this.version_box.Items.AddRange(new object[] {
            "1.12及以下",
            "1.13及以上"});
            this.version_box.Location = new System.Drawing.Point(531, 5);
            this.version_box.Name = "version_box";
            this.version_box.Size = new System.Drawing.Size(54, 20);
            this.version_box.TabIndex = 9;
            // 
            // speech_area
            // 
            this.villager_table.SetColumnSpan(this.speech_area, 5);
            this.speech_area.Controls.Add(this.value_box);
            this.speech_area.Controls.Add(this.target_box);
            this.speech_area.Controls.Add(this.targetleast_box);
            this.speech_area.Controls.Add(this.targetmost_box);
            this.speech_area.Controls.Add(this.random_target);
            this.speech_area.Controls.Add(this.random_targetleast);
            this.speech_area.Controls.Add(this.random_targetmost);
            this.speech_area.Controls.Add(this.label8);
            this.speech_area.Controls.Add(this.speech_btn_box);
            this.speech_area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.speech_area.ForeColor = System.Drawing.Color.White;
            this.speech_area.Location = new System.Drawing.Point(3, 33);
            this.speech_area.Name = "speech_area";
            this.speech_area.Size = new System.Drawing.Size(333, 164);
            this.speech_area.TabIndex = 10;
            this.speech_area.TabStop = false;
            this.speech_area.Text = "言论";
            // 
            // value_box
            // 
            this.value_box.BackColor = System.Drawing.Color.Gray;
            this.value_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.value_box.ForeColor = System.Drawing.Color.White;
            this.value_box.Location = new System.Drawing.Point(47, 111);
            this.value_box.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.value_box.Name = "value_box";
            this.value_box.Size = new System.Drawing.Size(138, 17);
            this.value_box.TabIndex = 10;
            // 
            // target_box
            // 
            this.target_box.BackColor = System.Drawing.Color.Gray;
            this.target_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.target_box.ForeColor = System.Drawing.Color.White;
            this.target_box.Location = new System.Drawing.Point(126, 80);
            this.target_box.Name = "target_box";
            this.target_box.Size = new System.Drawing.Size(59, 21);
            this.target_box.TabIndex = 9;
            // 
            // targetleast_box
            // 
            this.targetleast_box.BackColor = System.Drawing.Color.Gray;
            this.targetleast_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.targetleast_box.ForeColor = System.Drawing.Color.White;
            this.targetleast_box.Location = new System.Drawing.Point(126, 51);
            this.targetleast_box.Name = "targetleast_box";
            this.targetleast_box.Size = new System.Drawing.Size(59, 21);
            this.targetleast_box.TabIndex = 8;
            // 
            // targetmost_box
            // 
            this.targetmost_box.BackColor = System.Drawing.Color.Gray;
            this.targetmost_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.targetmost_box.ForeColor = System.Drawing.Color.White;
            this.targetmost_box.Location = new System.Drawing.Point(126, 22);
            this.targetmost_box.Name = "targetmost_box";
            this.targetmost_box.Size = new System.Drawing.Size(59, 21);
            this.targetmost_box.TabIndex = 7;
            // 
            // random_target
            // 
            this.random_target.BackColor = System.Drawing.Color.Gray;
            this.random_target.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("random_target.BackgroundImage")));
            this.random_target.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.random_target.Cursor = System.Windows.Forms.Cursors.Hand;
            this.random_target.FlatAppearance.BorderSize = 0;
            this.random_target.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.random_target.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.random_target.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.random_target.Location = new System.Drawing.Point(8, 78);
            this.random_target.Name = "random_target";
            this.random_target.Size = new System.Drawing.Size(112, 23);
            this.random_target.TabIndex = 6;
            this.random_target.Text = "随机Target:";
            this.random_target.UseVisualStyleBackColor = false;
            this.random_target.Click += new System.EventHandler(this.random_target_Click);
            // 
            // random_targetleast
            // 
            this.random_targetleast.BackColor = System.Drawing.Color.Gray;
            this.random_targetleast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("random_targetleast.BackgroundImage")));
            this.random_targetleast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.random_targetleast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.random_targetleast.FlatAppearance.BorderSize = 0;
            this.random_targetleast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.random_targetleast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.random_targetleast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.random_targetleast.Location = new System.Drawing.Point(8, 49);
            this.random_targetleast.Name = "random_targetleast";
            this.random_targetleast.Size = new System.Drawing.Size(112, 23);
            this.random_targetleast.TabIndex = 5;
            this.random_targetleast.Text = "随机TargetLeast:";
            this.random_targetleast.UseVisualStyleBackColor = false;
            this.random_targetleast.Click += new System.EventHandler(this.random_targetleast_Click);
            // 
            // random_targetmost
            // 
            this.random_targetmost.BackColor = System.Drawing.Color.Gray;
            this.random_targetmost.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("random_targetmost.BackgroundImage")));
            this.random_targetmost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.random_targetmost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.random_targetmost.FlatAppearance.BorderSize = 0;
            this.random_targetmost.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.random_targetmost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.random_targetmost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.random_targetmost.Location = new System.Drawing.Point(8, 20);
            this.random_targetmost.Name = "random_targetmost";
            this.random_targetmost.Size = new System.Drawing.Size(112, 23);
            this.random_targetmost.TabIndex = 4;
            this.random_targetmost.Text = "随机TargetMost:";
            this.random_targetmost.UseVisualStyleBackColor = false;
            this.random_targetmost.Click += new System.EventHandler(this.random_targetmost_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(6, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "Value:";
            // 
            // speech_btn_box
            // 
            this.speech_btn_box.BackColor = System.Drawing.Color.Gray;
            this.speech_btn_box.ForeColor = System.Drawing.Color.White;
            this.speech_btn_box.HideSelection = false;
            this.speech_btn_box.Location = new System.Drawing.Point(191, 13);
            this.speech_btn_box.Name = "speech_btn_box";
            this.speech_btn_box.Size = new System.Drawing.Size(136, 145);
            this.speech_btn_box.TabIndex = 0;
            this.speech_btn_box.UseCompatibleStateImageBehavior = false;
            // 
            // position_area
            // 
            this.villager_table.SetColumnSpan(this.position_area, 5);
            this.position_area.Controls.Add(this.pos_z_box);
            this.position_area.Controls.Add(this.pos_y_box);
            this.position_area.Controls.Add(this.pos_x_box);
            this.position_area.Controls.Add(this.memory_btn_box);
            this.position_area.Controls.Add(this.dimension_box);
            this.position_area.Controls.Add(this.label10);
            this.position_area.Controls.Add(this.label9);
            this.position_area.Controls.Add(this.label7);
            this.position_area.Controls.Add(this.label6);
            this.position_area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.position_area.ForeColor = System.Drawing.Color.White;
            this.position_area.Location = new System.Drawing.Point(342, 33);
            this.position_area.Name = "position_area";
            this.position_area.Size = new System.Drawing.Size(243, 164);
            this.position_area.TabIndex = 11;
            this.position_area.TabStop = false;
            this.position_area.Text = "记忆";
            // 
            // pos_z_box
            // 
            this.pos_z_box.BackColor = System.Drawing.Color.Gray;
            this.pos_z_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pos_z_box.ForeColor = System.Drawing.Color.White;
            this.pos_z_box.Location = new System.Drawing.Point(29, 80);
            this.pos_z_box.Name = "pos_z_box";
            this.pos_z_box.Size = new System.Drawing.Size(100, 21);
            this.pos_z_box.TabIndex = 11;
            // 
            // pos_y_box
            // 
            this.pos_y_box.BackColor = System.Drawing.Color.Gray;
            this.pos_y_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pos_y_box.ForeColor = System.Drawing.Color.White;
            this.pos_y_box.Location = new System.Drawing.Point(29, 51);
            this.pos_y_box.Name = "pos_y_box";
            this.pos_y_box.Size = new System.Drawing.Size(100, 21);
            this.pos_y_box.TabIndex = 10;
            // 
            // pos_x_box
            // 
            this.pos_x_box.BackColor = System.Drawing.Color.Gray;
            this.pos_x_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pos_x_box.ForeColor = System.Drawing.Color.White;
            this.pos_x_box.Location = new System.Drawing.Point(29, 22);
            this.pos_x_box.Name = "pos_x_box";
            this.pos_x_box.Size = new System.Drawing.Size(100, 21);
            this.pos_x_box.TabIndex = 9;
            // 
            // memory_btn_box
            // 
            this.memory_btn_box.BackColor = System.Drawing.Color.Gray;
            this.memory_btn_box.ForeColor = System.Drawing.Color.White;
            this.memory_btn_box.HideSelection = false;
            this.memory_btn_box.Location = new System.Drawing.Point(135, 12);
            this.memory_btn_box.Name = "memory_btn_box";
            this.memory_btn_box.Size = new System.Drawing.Size(104, 89);
            this.memory_btn_box.TabIndex = 8;
            this.memory_btn_box.UseCompatibleStateImageBehavior = false;
            // 
            // dimension_box
            // 
            this.dimension_box.BackColor = System.Drawing.Color.Gray;
            this.dimension_box.ForeColor = System.Drawing.Color.White;
            this.dimension_box.FormattingEnabled = true;
            this.dimension_box.Items.AddRange(new object[] {
            "minecraft:overworld",
            "minecraft:nether",
            "minecraft:the_end"});
            this.dimension_box.Location = new System.Drawing.Point(47, 108);
            this.dimension_box.Name = "dimension_box";
            this.dimension_box.Size = new System.Drawing.Size(136, 20);
            this.dimension_box.TabIndex = 7;
            this.dimension_box.Text = "minecraft:overworld";
            this.dimension_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dimension_box_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(6, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "维度:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(6, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "Z:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "X:";
            // 
            // transaction_tab
            // 
            this.villager_table.SetColumnSpan(this.transaction_tab, 10);
            this.transaction_tab.Controls.Add(this.tabPage2);
            this.transaction_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transaction_tab.Location = new System.Drawing.Point(3, 203);
            this.transaction_tab.Name = "transaction_tab";
            this.transaction_tab.SelectedIndex = 0;
            this.transaction_tab.Size = new System.Drawing.Size(582, 158);
            this.transaction_tab.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(574, 132);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "1号交易";
            // 
            // villager_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.villager_tab);
            this.Name = "villager_page";
            this.Size = new System.Drawing.Size(602, 396);
            this.villager_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.villager_table.ResumeLayout(false);
            this.villager_table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exp_box)).EndInit();
            this.speech_area.ResumeLayout(false);
            this.speech_area.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.value_box)).EndInit();
            this.position_area.ResumeLayout(false);
            this.position_area.PerformLayout();
            this.transaction_tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel villager_table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox villager_type_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox villager_professional;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox transaction_level_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown exp_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox version_box;
        private System.Windows.Forms.GroupBox speech_area;
        private System.Windows.Forms.NumericUpDown value_box;
        private System.Windows.Forms.TextBox target_box;
        private System.Windows.Forms.TextBox targetleast_box;
        private System.Windows.Forms.TextBox targetmost_box;
        private System.Windows.Forms.Button random_target;
        private System.Windows.Forms.Button random_targetleast;
        private System.Windows.Forms.Button random_targetmost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView speech_btn_box;
        private System.Windows.Forms.GroupBox position_area;
        private System.Windows.Forms.TextBox pos_z_box;
        private System.Windows.Forms.TextBox pos_y_box;
        private System.Windows.Forms.TextBox pos_x_box;
        private System.Windows.Forms.ListView memory_btn_box;
        private System.Windows.Forms.ComboBox dimension_box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl transaction_tab;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabControl villager_tab;
    }
}
