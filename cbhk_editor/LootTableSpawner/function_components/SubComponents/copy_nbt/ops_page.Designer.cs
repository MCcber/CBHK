
namespace cbhk_editor.LootTableSpawner.function_components.SubComponents
{
    partial class ops_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ops_page));
            this.ops_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.set_op = new System.Windows.Forms.Button();
            this.set_target = new System.Windows.Forms.Button();
            this.set_source = new System.Windows.Forms.Button();
            this.ops_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ops_tab
            // 
            this.ops_tab.Controls.Add(this.tabPage1);
            this.ops_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ops_tab.ItemSize = new System.Drawing.Size(15, 15);
            this.ops_tab.Location = new System.Drawing.Point(0, 0);
            this.ops_tab.Name = "ops_tab";
            this.ops_tab.SelectedIndex = 0;
            this.ops_tab.Size = new System.Drawing.Size(377, 139);
            this.ops_tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.ops_tab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage1.Controls.Add(this.set_op);
            this.tabPage1.Controls.Add(this.set_target);
            this.tabPage1.Controls.Add(this.set_source);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 19);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(369, 116);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1";
            // 
            // set_op
            // 
            this.set_op.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_op.BackgroundImage")));
            this.set_op.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.set_op.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_op.FlatAppearance.BorderSize = 0;
            this.set_op.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_op.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_op.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_op.Location = new System.Drawing.Point(6, 76);
            this.set_op.Name = "set_op";
            this.set_op.Size = new System.Drawing.Size(357, 37);
            this.set_op.TabIndex = 3;
            this.set_op.Text = "设置复制方式";
            this.set_op.UseVisualStyleBackColor = true;
            this.set_op.Click += new System.EventHandler(this.set_op_Click);
            // 
            // set_target
            // 
            this.set_target.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_target.BackgroundImage")));
            this.set_target.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.set_target.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_target.FlatAppearance.BorderSize = 0;
            this.set_target.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_target.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_target.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_target.Location = new System.Drawing.Point(6, 39);
            this.set_target.Name = "set_target";
            this.set_target.Size = new System.Drawing.Size(357, 37);
            this.set_target.TabIndex = 2;
            this.set_target.Text = "设置到目标";
            this.set_target.UseVisualStyleBackColor = true;
            // 
            // set_source
            // 
            this.set_source.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_source.BackgroundImage")));
            this.set_source.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.set_source.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_source.FlatAppearance.BorderSize = 0;
            this.set_source.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_source.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_source.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_source.Location = new System.Drawing.Point(6, 2);
            this.set_source.Name = "set_source";
            this.set_source.Size = new System.Drawing.Size(357, 37);
            this.set_source.TabIndex = 1;
            this.set_source.Text = "设置到源";
            this.set_source.UseVisualStyleBackColor = true;
            // 
            // ops_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ops_tab);
            this.Name = "ops_page";
            this.Size = new System.Drawing.Size(377, 139);
            this.ops_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button set_op;
        private System.Windows.Forms.Button set_target;
        private System.Windows.Forms.Button set_source;
        public System.Windows.Forms.TabControl ops_tab;
    }
}
