
namespace cbhk_editor.SkillSpawner.ConditionCompnents.Item
{
    partial class SelectedItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectedItem));
            this.load_selected_item = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // load_selected_item
            // 
            this.load_selected_item.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("load_selected_item.BackgroundImage")));
            this.load_selected_item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.load_selected_item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.load_selected_item.FlatAppearance.BorderSize = 0;
            this.load_selected_item.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.load_selected_item.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.load_selected_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_selected_item.ForeColor = System.Drawing.Color.White;
            this.load_selected_item.Location = new System.Drawing.Point(-1, -1);
            this.load_selected_item.Name = "load_selected_item";
            this.load_selected_item.Size = new System.Drawing.Size(88, 26);
            this.load_selected_item.TabIndex = 0;
            this.load_selected_item.Text = "导入手持物品";
            this.load_selected_item.UseVisualStyleBackColor = true;
            // 
            // SelectedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.load_selected_item);
            this.Name = "SelectedItem";
            this.Size = new System.Drawing.Size(88, 25);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button load_selected_item;
    }
}
