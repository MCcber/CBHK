
namespace cbhk_editor.LootTableSpawner.condition_components.SubComponents
{
    partial class adv_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adv_page));
            this.adv_tab = new System.Windows.Forms.TabControl();
            this.page = new System.Windows.Forms.TabPage();
            this.add_trigger = new System.Windows.Forms.Button();
            this.trigger_box = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.set_adv_id = new System.Windows.Forms.Button();
            this.adv_tab.SuspendLayout();
            this.page.SuspendLayout();
            this.SuspendLayout();
            // 
            // adv_tab
            // 
            this.adv_tab.Controls.Add(this.page);
            this.adv_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adv_tab.ItemSize = new System.Drawing.Size(15, 15);
            this.adv_tab.Location = new System.Drawing.Point(0, 0);
            this.adv_tab.Name = "adv_tab";
            this.adv_tab.SelectedIndex = 0;
            this.adv_tab.Size = new System.Drawing.Size(194, 80);
            this.adv_tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.adv_tab.TabIndex = 1;
            // 
            // page
            // 
            this.page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.page.Controls.Add(this.add_trigger);
            this.page.Controls.Add(this.trigger_box);
            this.page.Controls.Add(this.label14);
            this.page.Controls.Add(this.set_adv_id);
            this.page.Location = new System.Drawing.Point(4, 19);
            this.page.Name = "page";
            this.page.Padding = new System.Windows.Forms.Padding(3);
            this.page.Size = new System.Drawing.Size(186, 57);
            this.page.TabIndex = 0;
            this.page.Text = "1";
            // 
            // add_trigger
            // 
            this.add_trigger.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_trigger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_trigger.BackgroundImage")));
            this.add_trigger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_trigger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_trigger.FlatAppearance.BorderSize = 0;
            this.add_trigger.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.add_trigger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.add_trigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_trigger.Location = new System.Drawing.Point(103, 30);
            this.add_trigger.Name = "add_trigger";
            this.add_trigger.Size = new System.Drawing.Size(81, 23);
            this.add_trigger.TabIndex = 28;
            this.add_trigger.Text = "添加";
            this.add_trigger.UseVisualStyleBackColor = true;
            this.add_trigger.Click += new System.EventHandler(this.add_trigger_Click);
            // 
            // trigger_box
            // 
            this.trigger_box.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trigger_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.trigger_box.ForeColor = System.Drawing.Color.White;
            this.trigger_box.FormattingEnabled = true;
            this.trigger_box.Location = new System.Drawing.Point(1, 31);
            this.trigger_box.Name = "trigger_box";
            this.trigger_box.Size = new System.Drawing.Size(99, 20);
            this.trigger_box.TabIndex = 27;
            this.trigger_box.SelectedIndexChanged += new System.EventHandler(this.trigger_box_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(101, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 12);
            this.label14.TabIndex = 26;
            this.label14.Text = "已触发的判据:";
            // 
            // set_adv_id
            // 
            this.set_adv_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.set_adv_id.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_adv_id.BackgroundImage")));
            this.set_adv_id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.set_adv_id.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_adv_id.FlatAppearance.BorderSize = 0;
            this.set_adv_id.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_adv_id.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_adv_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_adv_id.Location = new System.Drawing.Point(1, 1);
            this.set_adv_id.Name = "set_adv_id";
            this.set_adv_id.Size = new System.Drawing.Size(99, 23);
            this.set_adv_id.TabIndex = 25;
            this.set_adv_id.Text = "设置进度";
            this.set_adv_id.UseVisualStyleBackColor = true;
            this.set_adv_id.Click += new System.EventHandler(this.set_adv_id_Click);
            // 
            // adv_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adv_tab);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "adv_page";
            this.Size = new System.Drawing.Size(194, 80);
            this.adv_tab.ResumeLayout(false);
            this.page.ResumeLayout(false);
            this.page.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage page;
        private System.Windows.Forms.Button add_trigger;
        private System.Windows.Forms.ComboBox trigger_box;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button set_adv_id;
        public System.Windows.Forms.TabControl adv_tab;
    }
}
