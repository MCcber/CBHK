
namespace cbhk_editor.LootTableSpawner.condition_components.SubComponents.LocationCheck
{
    partial class fluid_predicate_page
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
            this.fluid_tab = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fluid_state_area = new System.Windows.Forms.Panel();
            this.fluid_tag_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fluid_id = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fluid_tab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fluid_tab
            // 
            this.fluid_tab.Controls.Add(this.tabPage2);
            this.fluid_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluid_tab.ItemSize = new System.Drawing.Size(15, 15);
            this.fluid_tab.Location = new System.Drawing.Point(0, 0);
            this.fluid_tab.Name = "fluid_tab";
            this.fluid_tab.SelectedIndex = 0;
            this.fluid_tab.Size = new System.Drawing.Size(188, 133);
            this.fluid_tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.fluid_tab.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage2.Controls.Add(this.fluid_state_area);
            this.tabPage2.Controls.Add(this.fluid_tag_box);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.fluid_id);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 19);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(180, 110);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "1";
            // 
            // fluid_state_area
            // 
            this.fluid_state_area.AutoScroll = true;
            this.fluid_state_area.Location = new System.Drawing.Point(3, 46);
            this.fluid_state_area.Name = "fluid_state_area";
            this.fluid_state_area.Size = new System.Drawing.Size(177, 61);
            this.fluid_state_area.TabIndex = 20;
            // 
            // fluid_tag_box
            // 
            this.fluid_tag_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.fluid_tag_box.ForeColor = System.Drawing.Color.White;
            this.fluid_tag_box.Location = new System.Drawing.Point(31, 23);
            this.fluid_tag_box.Name = "fluid_tag_box";
            this.fluid_tag_box.Size = new System.Drawing.Size(149, 21);
            this.fluid_tag_box.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "tag:";
            // 
            // fluid_id
            // 
            this.fluid_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fluid_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.fluid_id.ForeColor = System.Drawing.Color.White;
            this.fluid_id.FormattingEnabled = true;
            this.fluid_id.Location = new System.Drawing.Point(21, 3);
            this.fluid_id.Name = "fluid_id";
            this.fluid_id.Size = new System.Drawing.Size(158, 20);
            this.fluid_id.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-1, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "ID:";
            // 
            // fluid_predicate_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fluid_tab);
            this.Name = "fluid_predicate_page";
            this.Size = new System.Drawing.Size(188, 133);
            this.fluid_tab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel fluid_state_area;
        private System.Windows.Forms.TextBox fluid_tag_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox fluid_id;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TabControl fluid_tab;
    }
}
