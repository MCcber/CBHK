
namespace cbhk_editor.LootTableSpawner.condition_components.SubComponents.LocationCheck
{
    partial class block_predicate_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(block_predicate_page));
            this.block_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.block_state_area = new System.Windows.Forms.Panel();
            this.set_nbt = new System.Windows.Forms.Button();
            this.block_tag_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.block_id = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.block_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // block_tab
            // 
            this.block_tab.Controls.Add(this.tabPage1);
            this.block_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.block_tab.ItemSize = new System.Drawing.Size(15, 15);
            this.block_tab.Location = new System.Drawing.Point(0, 0);
            this.block_tab.Name = "block_tab";
            this.block_tab.SelectedIndex = 0;
            this.block_tab.Size = new System.Drawing.Size(199, 133);
            this.block_tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.block_tab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage1.Controls.Add(this.block_state_area);
            this.tabPage1.Controls.Add(this.set_nbt);
            this.tabPage1.Controls.Add(this.block_tag_box);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.block_id);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 19);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(191, 110);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1";
            // 
            // block_state_area
            // 
            this.block_state_area.AutoScroll = true;
            this.block_state_area.Location = new System.Drawing.Point(80, 56);
            this.block_state_area.Name = "block_state_area";
            this.block_state_area.Size = new System.Drawing.Size(111, 48);
            this.block_state_area.TabIndex = 10;
            // 
            // set_nbt
            // 
            this.set_nbt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_nbt.BackgroundImage")));
            this.set_nbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.set_nbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_nbt.FlatAppearance.BorderSize = 0;
            this.set_nbt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_nbt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_nbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_nbt.Location = new System.Drawing.Point(3, 56);
            this.set_nbt.Name = "set_nbt";
            this.set_nbt.Size = new System.Drawing.Size(75, 51);
            this.set_nbt.TabIndex = 9;
            this.set_nbt.Text = "设置NBT";
            this.set_nbt.UseVisualStyleBackColor = true;
            // 
            // block_tag_box
            // 
            this.block_tag_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.block_tag_box.ForeColor = System.Drawing.Color.White;
            this.block_tag_box.Location = new System.Drawing.Point(35, 32);
            this.block_tag_box.Name = "block_tag_box";
            this.block_tag_box.Size = new System.Drawing.Size(156, 21);
            this.block_tag_box.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "tag:";
            // 
            // block_id
            // 
            this.block_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.block_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.block_id.ForeColor = System.Drawing.Color.White;
            this.block_id.FormattingEnabled = true;
            this.block_id.Location = new System.Drawing.Point(33, 4);
            this.block_id.Name = "block_id";
            this.block_id.Size = new System.Drawing.Size(158, 20);
            this.block_id.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID:";
            // 
            // block_predicate_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.block_tab);
            this.Name = "block_predicate_page";
            this.Size = new System.Drawing.Size(199, 133);
            this.block_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel block_state_area;
        private System.Windows.Forms.Button set_nbt;
        private System.Windows.Forms.TextBox block_tag_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox block_id;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TabControl block_tab;
    }
}
