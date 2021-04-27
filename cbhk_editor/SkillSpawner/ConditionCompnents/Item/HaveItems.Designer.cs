
namespace cbhk_editor.SkillSpawner.ConditionCompnents.Item
{
    partial class HaveItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HaveItems));
            this.load_item_info = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // load_item_info
            // 
            this.load_item_info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("load_item_info.BackgroundImage")));
            this.load_item_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.load_item_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.load_item_info.FlatAppearance.BorderSize = 0;
            this.load_item_info.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.load_item_info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.load_item_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_item_info.ForeColor = System.Drawing.Color.White;
            this.load_item_info.Location = new System.Drawing.Point(-1, -1);
            this.load_item_info.Name = "load_item_info";
            this.load_item_info.Size = new System.Drawing.Size(71, 23);
            this.load_item_info.TabIndex = 0;
            this.load_item_info.Text = "导入物品";
            this.load_item_info.UseVisualStyleBackColor = true;
            // 
            // HaveItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.load_item_info);
            this.Name = "HaveItems";
            this.Size = new System.Drawing.Size(71, 22);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button load_item_info;
    }
}
