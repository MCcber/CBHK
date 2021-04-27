
namespace cbhk_editor.LootTableSpawner.condition_components.SubComponents.ItemPredicate
{
    partial class enchant_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(enchant_page));
            this.enchant_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.set_max_level = new System.Windows.Forms.Button();
            this.set_min_level = new System.Windows.Forms.Button();
            this.enchant_id_box = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.enchant_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // enchant_tab
            // 
            this.enchant_tab.Controls.Add(this.tabPage1);
            this.enchant_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enchant_tab.ItemSize = new System.Drawing.Size(15, 15);
            this.enchant_tab.Location = new System.Drawing.Point(0, 0);
            this.enchant_tab.Name = "enchant_tab";
            this.enchant_tab.SelectedIndex = 0;
            this.enchant_tab.Size = new System.Drawing.Size(214, 73);
            this.enchant_tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.enchant_tab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage1.Controls.Add(this.set_max_level);
            this.tabPage1.Controls.Add(this.set_min_level);
            this.tabPage1.Controls.Add(this.enchant_id_box);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 19);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(206, 50);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1";
            // 
            // set_max_level
            // 
            this.set_max_level.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_max_level.BackgroundImage")));
            this.set_max_level.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.set_max_level.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_max_level.FlatAppearance.BorderSize = 0;
            this.set_max_level.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_max_level.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_max_level.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_max_level.Location = new System.Drawing.Point(106, 26);
            this.set_max_level.Name = "set_max_level";
            this.set_max_level.Size = new System.Drawing.Size(97, 22);
            this.set_max_level.TabIndex = 19;
            this.set_max_level.Text = "设置最高等级";
            this.set_max_level.UseVisualStyleBackColor = true;
            // 
            // set_min_level
            // 
            this.set_min_level.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_min_level.BackgroundImage")));
            this.set_min_level.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.set_min_level.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_min_level.FlatAppearance.BorderSize = 0;
            this.set_min_level.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_min_level.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_min_level.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_min_level.Location = new System.Drawing.Point(3, 26);
            this.set_min_level.Name = "set_min_level";
            this.set_min_level.Size = new System.Drawing.Size(97, 22);
            this.set_min_level.TabIndex = 18;
            this.set_min_level.Text = "设置最低等级";
            this.set_min_level.UseVisualStyleBackColor = true;
            // 
            // enchant_id_box
            // 
            this.enchant_id_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enchant_id_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.enchant_id_box.ForeColor = System.Drawing.Color.White;
            this.enchant_id_box.FormattingEnabled = true;
            this.enchant_id_box.Location = new System.Drawing.Point(30, 4);
            this.enchant_id_box.Name = "enchant_id_box";
            this.enchant_id_box.Size = new System.Drawing.Size(173, 20);
            this.enchant_id_box.TabIndex = 2;
            this.enchant_id_box.SelectedIndexChanged += new System.EventHandler(this.enchant_id_box_SelectedIndexChanged);
            this.enchant_id_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enchant_id_box_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID:";
            // 
            // enchant_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.enchant_tab);
            this.Name = "enchant_page";
            this.Size = new System.Drawing.Size(214, 73);
            this.enchant_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button set_max_level;
        private System.Windows.Forms.Button set_min_level;
        private System.Windows.Forms.ComboBox enchant_id_box;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TabControl enchant_tab;
    }
}
