
namespace cbhk_editor.RecipeSpawner
{
    partial class value_tab
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
            this.recipe_value_tab = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.key_tag = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.key_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.recipe_value_tab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // recipe_value_tab
            // 
            this.recipe_value_tab.Controls.Add(this.tabPage2);
            this.recipe_value_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipe_value_tab.Location = new System.Drawing.Point(0, 0);
            this.recipe_value_tab.Name = "recipe_value_tab";
            this.recipe_value_tab.SelectedIndex = 0;
            this.recipe_value_tab.Size = new System.Drawing.Size(429, 84);
            this.recipe_value_tab.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.key_tag);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.key_id);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(421, 58);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "槽位:";
            // 
            // key_tag
            // 
            this.key_tag.BackColor = System.Drawing.Color.Gray;
            this.key_tag.ForeColor = System.Drawing.Color.White;
            this.key_tag.Location = new System.Drawing.Point(30, 30);
            this.key_tag.Name = "key_tag";
            this.key_tag.Size = new System.Drawing.Size(388, 21);
            this.key_tag.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tag:";
            // 
            // key_id
            // 
            this.key_id.BackColor = System.Drawing.Color.Gray;
            this.key_id.ForeColor = System.Drawing.Color.White;
            this.key_id.Location = new System.Drawing.Point(30, 0);
            this.key_id.Name = "key_id";
            this.key_id.Size = new System.Drawing.Size(388, 21);
            this.key_id.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID:";
            // 
            // value_tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.recipe_value_tab);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "value_tab";
            this.Size = new System.Drawing.Size(429, 84);
            this.recipe_value_tab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox key_tag;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox key_id;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TabControl recipe_value_tab;
    }
}
