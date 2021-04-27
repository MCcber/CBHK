
namespace cbhk_editor.FireWorkSpawner
{
    partial class firework_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(firework_page));
            this.firework_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.shotAtAngle_box = new System.Windows.Forms.CheckBox();
            this.model_area = new System.Windows.Forms.GroupBox();
            this.summon_model = new System.Windows.Forms.CheckBox();
            this.give_model = new System.Windows.Forms.CheckBox();
            this.duration_area = new System.Windows.Forms.GroupBox();
            this.random_duration = new System.Windows.Forms.Button();
            this.duration_box = new System.Windows.Forms.ComboBox();
            this.explode_trajectory = new System.Windows.Forms.GroupBox();
            this.Procrastination = new System.Windows.Forms.CheckBox();
            this.twinkle = new System.Windows.Forms.CheckBox();
            this.random_trajectory = new System.Windows.Forms.Button();
            this.firework_shape_area = new System.Windows.Forms.GroupBox();
            this.random_shape = new System.Windows.Forms.Button();
            this.shape_box = new System.Windows.Forms.CheckedListBox();
            this.firework_color_area = new System.Windows.Forms.GroupBox();
            this.fade_color_list = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.color_list = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fade_color_count = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.random_fade_color = new System.Windows.Forms.CheckBox();
            this.color_count = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.random_color = new System.Windows.Forms.CheckBox();
            this.add_to_fade_color = new System.Windows.Forms.Button();
            this.add_to_color = new System.Windows.Forms.Button();
            this.reverse_select = new System.Windows.Forms.Button();
            this.select_all = new System.Windows.Forms.Button();
            this.color_box = new System.Windows.Forms.CheckedListBox();
            this.firework_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.model_area.SuspendLayout();
            this.duration_area.SuspendLayout();
            this.explode_trajectory.SuspendLayout();
            this.firework_shape_area.SuspendLayout();
            this.firework_color_area.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fade_color_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_count)).BeginInit();
            this.SuspendLayout();
            // 
            // firework_tab
            // 
            this.firework_tab.Controls.Add(this.tabPage1);
            this.firework_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firework_tab.Location = new System.Drawing.Point(0, 0);
            this.firework_tab.Name = "firework_tab";
            this.firework_tab.SelectedIndex = 0;
            this.firework_tab.Size = new System.Drawing.Size(429, 337);
            this.firework_tab.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage1.Controls.Add(this.shotAtAngle_box);
            this.tabPage1.Controls.Add(this.model_area);
            this.tabPage1.Controls.Add(this.duration_area);
            this.tabPage1.Controls.Add(this.explode_trajectory);
            this.tabPage1.Controls.Add(this.firework_shape_area);
            this.tabPage1.Controls.Add(this.firework_color_area);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(421, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "第1个";
            // 
            // shotAtAngle_box
            // 
            this.shotAtAngle_box.AutoSize = true;
            this.shotAtAngle_box.ForeColor = System.Drawing.Color.White;
            this.shotAtAngle_box.Location = new System.Drawing.Point(322, 287);
            this.shotAtAngle_box.Name = "shotAtAngle_box";
            this.shotAtAngle_box.Size = new System.Drawing.Size(84, 16);
            this.shotAtAngle_box.TabIndex = 5;
            this.shotAtAngle_box.Text = "按角度射出";
            this.shotAtAngle_box.UseVisualStyleBackColor = true;
            this.shotAtAngle_box.CheckedChanged += new System.EventHandler(this.shotAtAngle_box_CheckedChanged);
            // 
            // model_area
            // 
            this.model_area.Controls.Add(this.summon_model);
            this.model_area.Controls.Add(this.give_model);
            this.model_area.ForeColor = System.Drawing.Color.White;
            this.model_area.Location = new System.Drawing.Point(205, 270);
            this.model_area.Name = "model_area";
            this.model_area.Size = new System.Drawing.Size(111, 38);
            this.model_area.TabIndex = 4;
            this.model_area.TabStop = false;
            this.model_area.Text = "模式";
            // 
            // summon_model
            // 
            this.summon_model.AutoSize = true;
            this.summon_model.Location = new System.Drawing.Point(57, 16);
            this.summon_model.Name = "summon_model";
            this.summon_model.Size = new System.Drawing.Size(48, 16);
            this.summon_model.TabIndex = 1;
            this.summon_model.Text = "召唤";
            this.summon_model.UseVisualStyleBackColor = true;
            // 
            // give_model
            // 
            this.give_model.AutoSize = true;
            this.give_model.Location = new System.Drawing.Point(3, 16);
            this.give_model.Name = "give_model";
            this.give_model.Size = new System.Drawing.Size(48, 16);
            this.give_model.TabIndex = 0;
            this.give_model.Text = "给予";
            this.give_model.UseVisualStyleBackColor = true;
            // 
            // duration_area
            // 
            this.duration_area.Controls.Add(this.random_duration);
            this.duration_area.Controls.Add(this.duration_box);
            this.duration_area.ForeColor = System.Drawing.Color.White;
            this.duration_area.Location = new System.Drawing.Point(3, 270);
            this.duration_area.Name = "duration_area";
            this.duration_area.Size = new System.Drawing.Size(200, 38);
            this.duration_area.TabIndex = 3;
            this.duration_area.TabStop = false;
            this.duration_area.Text = "飞行时长";
            // 
            // random_duration
            // 
            this.random_duration.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("random_duration.BackgroundImage")));
            this.random_duration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.random_duration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.random_duration.FlatAppearance.BorderSize = 0;
            this.random_duration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.random_duration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.random_duration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.random_duration.Location = new System.Drawing.Point(111, 13);
            this.random_duration.Name = "random_duration";
            this.random_duration.Size = new System.Drawing.Size(83, 23);
            this.random_duration.TabIndex = 1;
            this.random_duration.Text = "随机时长";
            this.random_duration.UseVisualStyleBackColor = true;
            this.random_duration.Click += new System.EventHandler(this.random_duration_Click);
            // 
            // duration_box
            // 
            this.duration_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.duration_box.ForeColor = System.Drawing.Color.White;
            this.duration_box.FormattingEnabled = true;
            this.duration_box.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.duration_box.Location = new System.Drawing.Point(3, 15);
            this.duration_box.Name = "duration_box";
            this.duration_box.Size = new System.Drawing.Size(102, 20);
            this.duration_box.TabIndex = 0;
            this.duration_box.Text = "1";
            // 
            // explode_trajectory
            // 
            this.explode_trajectory.Controls.Add(this.Procrastination);
            this.explode_trajectory.Controls.Add(this.twinkle);
            this.explode_trajectory.Controls.Add(this.random_trajectory);
            this.explode_trajectory.ForeColor = System.Drawing.Color.White;
            this.explode_trajectory.Location = new System.Drawing.Point(3, 230);
            this.explode_trajectory.Name = "explode_trajectory";
            this.explode_trajectory.Size = new System.Drawing.Size(415, 40);
            this.explode_trajectory.TabIndex = 2;
            this.explode_trajectory.TabStop = false;
            this.explode_trajectory.Text = "爆炸轨迹";
            // 
            // Procrastination
            // 
            this.Procrastination.AutoSize = true;
            this.Procrastination.Location = new System.Drawing.Point(57, 17);
            this.Procrastination.Name = "Procrastination";
            this.Procrastination.Size = new System.Drawing.Size(48, 16);
            this.Procrastination.TabIndex = 3;
            this.Procrastination.Text = "拖尾";
            this.Procrastination.UseVisualStyleBackColor = true;
            // 
            // twinkle
            // 
            this.twinkle.AutoSize = true;
            this.twinkle.Location = new System.Drawing.Point(3, 17);
            this.twinkle.Name = "twinkle";
            this.twinkle.Size = new System.Drawing.Size(48, 16);
            this.twinkle.TabIndex = 2;
            this.twinkle.Text = "闪烁";
            this.twinkle.UseVisualStyleBackColor = true;
            // 
            // random_trajectory
            // 
            this.random_trajectory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("random_trajectory.BackgroundImage")));
            this.random_trajectory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.random_trajectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.random_trajectory.FlatAppearance.BorderSize = 0;
            this.random_trajectory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.random_trajectory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.random_trajectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.random_trajectory.Location = new System.Drawing.Point(128, 14);
            this.random_trajectory.Name = "random_trajectory";
            this.random_trajectory.Size = new System.Drawing.Size(284, 20);
            this.random_trajectory.TabIndex = 1;
            this.random_trajectory.Text = "随机轨迹";
            this.random_trajectory.UseVisualStyleBackColor = true;
            this.random_trajectory.Click += new System.EventHandler(this.random_trajectory_Click);
            // 
            // firework_shape_area
            // 
            this.firework_shape_area.Controls.Add(this.random_shape);
            this.firework_shape_area.Controls.Add(this.shape_box);
            this.firework_shape_area.ForeColor = System.Drawing.Color.White;
            this.firework_shape_area.Location = new System.Drawing.Point(3, 122);
            this.firework_shape_area.Name = "firework_shape_area";
            this.firework_shape_area.Size = new System.Drawing.Size(415, 105);
            this.firework_shape_area.TabIndex = 1;
            this.firework_shape_area.TabStop = false;
            this.firework_shape_area.Text = "爆炸形状";
            // 
            // random_shape
            // 
            this.random_shape.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("random_shape.BackgroundImage")));
            this.random_shape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.random_shape.Cursor = System.Windows.Forms.Cursors.Hand;
            this.random_shape.FlatAppearance.BorderSize = 0;
            this.random_shape.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.random_shape.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.random_shape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.random_shape.Location = new System.Drawing.Point(127, 15);
            this.random_shape.Name = "random_shape";
            this.random_shape.Size = new System.Drawing.Size(285, 84);
            this.random_shape.TabIndex = 1;
            this.random_shape.Text = "随机形状";
            this.random_shape.UseVisualStyleBackColor = true;
            this.random_shape.Click += new System.EventHandler(this.random_shape_Click);
            // 
            // shape_box
            // 
            this.shape_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.shape_box.ForeColor = System.Drawing.Color.White;
            this.shape_box.FormattingEnabled = true;
            this.shape_box.Items.AddRange(new object[] {
            "球形",
            "大球形",
            "星形",
            "苦力怕形",
            "零散形"});
            this.shape_box.Location = new System.Drawing.Point(6, 15);
            this.shape_box.Name = "shape_box";
            this.shape_box.Size = new System.Drawing.Size(120, 84);
            this.shape_box.TabIndex = 0;
            this.shape_box.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.shape_box_ItemCheck);
            // 
            // firework_color_area
            // 
            this.firework_color_area.Controls.Add(this.fade_color_list);
            this.firework_color_area.Controls.Add(this.label4);
            this.firework_color_area.Controls.Add(this.color_list);
            this.firework_color_area.Controls.Add(this.label3);
            this.firework_color_area.Controls.Add(this.fade_color_count);
            this.firework_color_area.Controls.Add(this.label2);
            this.firework_color_area.Controls.Add(this.random_fade_color);
            this.firework_color_area.Controls.Add(this.color_count);
            this.firework_color_area.Controls.Add(this.label1);
            this.firework_color_area.Controls.Add(this.random_color);
            this.firework_color_area.Controls.Add(this.add_to_fade_color);
            this.firework_color_area.Controls.Add(this.add_to_color);
            this.firework_color_area.Controls.Add(this.reverse_select);
            this.firework_color_area.Controls.Add(this.select_all);
            this.firework_color_area.Controls.Add(this.color_box);
            this.firework_color_area.ForeColor = System.Drawing.Color.White;
            this.firework_color_area.Location = new System.Drawing.Point(3, 3);
            this.firework_color_area.Name = "firework_color_area";
            this.firework_color_area.Size = new System.Drawing.Size(415, 117);
            this.firework_color_area.TabIndex = 0;
            this.firework_color_area.TabStop = false;
            this.firework_color_area.Text = "颜色";
            // 
            // fade_color_list
            // 
            this.fade_color_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.fade_color_list.ForeColor = System.Drawing.Color.White;
            this.fade_color_list.FormattingEnabled = true;
            this.fade_color_list.Location = new System.Drawing.Point(266, 89);
            this.fade_color_list.Name = "fade_color_list";
            this.fade_color_list.Size = new System.Drawing.Size(146, 20);
            this.fade_color_list.TabIndex = 14;
            this.fade_color_list.SelectedIndexChanged += new System.EventHandler(this.fade_color_list_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "备用列表:";
            // 
            // color_list
            // 
            this.color_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.color_list.ForeColor = System.Drawing.Color.White;
            this.color_list.FormattingEnabled = true;
            this.color_list.Location = new System.Drawing.Point(266, 65);
            this.color_list.Name = "color_list";
            this.color_list.Size = new System.Drawing.Size(146, 20);
            this.color_list.TabIndex = 12;
            this.color_list.SelectedIndexChanged += new System.EventHandler(this.color_list_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "颜色列表:";
            // 
            // fade_color_count
            // 
            this.fade_color_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.fade_color_count.Enabled = false;
            this.fade_color_count.ForeColor = System.Drawing.Color.White;
            this.fade_color_count.Location = new System.Drawing.Point(319, 41);
            this.fade_color_count.Name = "fade_color_count";
            this.fade_color_count.Size = new System.Drawing.Size(93, 21);
            this.fade_color_count.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "数量:";
            // 
            // random_fade_color
            // 
            this.random_fade_color.AutoSize = true;
            this.random_fade_color.Location = new System.Drawing.Point(206, 42);
            this.random_fade_color.Name = "random_fade_color";
            this.random_fade_color.Size = new System.Drawing.Size(72, 16);
            this.random_fade_color.TabIndex = 8;
            this.random_fade_color.Text = "随机备用";
            this.random_fade_color.UseVisualStyleBackColor = true;
            this.random_fade_color.CheckedChanged += new System.EventHandler(this.random_fade_color_CheckedChanged);
            // 
            // color_count
            // 
            this.color_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.color_count.Enabled = false;
            this.color_count.ForeColor = System.Drawing.Color.White;
            this.color_count.Location = new System.Drawing.Point(319, 16);
            this.color_count.Name = "color_count";
            this.color_count.Size = new System.Drawing.Size(93, 21);
            this.color_count.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "数量:";
            // 
            // random_color
            // 
            this.random_color.AutoSize = true;
            this.random_color.Location = new System.Drawing.Point(206, 18);
            this.random_color.Name = "random_color";
            this.random_color.Size = new System.Drawing.Size(72, 16);
            this.random_color.TabIndex = 5;
            this.random_color.Text = "随机颜色";
            this.random_color.UseVisualStyleBackColor = true;
            this.random_color.CheckedChanged += new System.EventHandler(this.random_color_CheckedChanged);
            // 
            // add_to_fade_color
            // 
            this.add_to_fade_color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_to_fade_color.BackgroundImage")));
            this.add_to_fade_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_to_fade_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_to_fade_color.FlatAppearance.BorderSize = 0;
            this.add_to_fade_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.add_to_fade_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.add_to_fade_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_to_fade_color.Location = new System.Drawing.Point(127, 87);
            this.add_to_fade_color.Name = "add_to_fade_color";
            this.add_to_fade_color.Size = new System.Drawing.Size(75, 23);
            this.add_to_fade_color.TabIndex = 4;
            this.add_to_fade_color.Text = "添加到备用";
            this.add_to_fade_color.UseVisualStyleBackColor = true;
            this.add_to_fade_color.Click += new System.EventHandler(this.add_to_fade_color_Click);
            // 
            // add_to_color
            // 
            this.add_to_color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_to_color.BackgroundImage")));
            this.add_to_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_to_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_to_color.FlatAppearance.BorderSize = 0;
            this.add_to_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.add_to_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.add_to_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_to_color.Location = new System.Drawing.Point(127, 63);
            this.add_to_color.Name = "add_to_color";
            this.add_to_color.Size = new System.Drawing.Size(75, 23);
            this.add_to_color.TabIndex = 3;
            this.add_to_color.Text = "添加到颜色";
            this.add_to_color.UseVisualStyleBackColor = true;
            this.add_to_color.Click += new System.EventHandler(this.add_to_color_Click);
            // 
            // reverse_select
            // 
            this.reverse_select.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reverse_select.BackgroundImage")));
            this.reverse_select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reverse_select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reverse_select.FlatAppearance.BorderSize = 0;
            this.reverse_select.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.reverse_select.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.reverse_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reverse_select.Location = new System.Drawing.Point(127, 38);
            this.reverse_select.Name = "reverse_select";
            this.reverse_select.Size = new System.Drawing.Size(75, 23);
            this.reverse_select.TabIndex = 2;
            this.reverse_select.Text = "反选";
            this.reverse_select.UseVisualStyleBackColor = true;
            this.reverse_select.Click += new System.EventHandler(this.reverse_select_Click);
            // 
            // select_all
            // 
            this.select_all.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("select_all.BackgroundImage")));
            this.select_all.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.select_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.select_all.FlatAppearance.BorderSize = 0;
            this.select_all.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.select_all.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.select_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_all.Location = new System.Drawing.Point(127, 14);
            this.select_all.Name = "select_all";
            this.select_all.Size = new System.Drawing.Size(75, 23);
            this.select_all.TabIndex = 1;
            this.select_all.Text = "全选";
            this.select_all.UseVisualStyleBackColor = true;
            this.select_all.Click += new System.EventHandler(this.select_all_Click);
            // 
            // color_box
            // 
            this.color_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.color_box.ForeColor = System.Drawing.Color.White;
            this.color_box.FormattingEnabled = true;
            this.color_box.Location = new System.Drawing.Point(6, 13);
            this.color_box.Name = "color_box";
            this.color_box.Size = new System.Drawing.Size(120, 100);
            this.color_box.TabIndex = 0;
            // 
            // firework_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.firework_tab);
            this.Name = "firework_page";
            this.Size = new System.Drawing.Size(429, 337);
            this.firework_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.model_area.ResumeLayout(false);
            this.model_area.PerformLayout();
            this.duration_area.ResumeLayout(false);
            this.explode_trajectory.ResumeLayout(false);
            this.explode_trajectory.PerformLayout();
            this.firework_shape_area.ResumeLayout(false);
            this.firework_color_area.ResumeLayout(false);
            this.firework_color_area.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fade_color_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_count)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox shotAtAngle_box;
        private System.Windows.Forms.GroupBox model_area;
        private System.Windows.Forms.CheckBox summon_model;
        private System.Windows.Forms.CheckBox give_model;
        private System.Windows.Forms.GroupBox duration_area;
        private System.Windows.Forms.Button random_duration;
        private System.Windows.Forms.ComboBox duration_box;
        private System.Windows.Forms.GroupBox explode_trajectory;
        private System.Windows.Forms.CheckBox Procrastination;
        private System.Windows.Forms.CheckBox twinkle;
        private System.Windows.Forms.Button random_trajectory;
        private System.Windows.Forms.GroupBox firework_shape_area;
        private System.Windows.Forms.Button random_shape;
        private System.Windows.Forms.CheckedListBox shape_box;
        private System.Windows.Forms.GroupBox firework_color_area;
        private System.Windows.Forms.ComboBox fade_color_list;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox color_list;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown fade_color_count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox random_fade_color;
        private System.Windows.Forms.NumericUpDown color_count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox random_color;
        private System.Windows.Forms.Button add_to_fade_color;
        private System.Windows.Forms.Button add_to_color;
        private System.Windows.Forms.Button reverse_select;
        private System.Windows.Forms.Button select_all;
        private System.Windows.Forms.CheckedListBox color_box;
        public System.Windows.Forms.TabControl firework_tab;
    }
}
