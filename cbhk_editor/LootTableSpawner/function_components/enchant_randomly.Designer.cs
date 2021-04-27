
namespace cbhk_editor.LootTableSpawner.function_components
{
    partial class enchant_randomly
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
            this.enchant_list_box = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // enchant_list_box
            // 
            this.enchant_list_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.enchant_list_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enchant_list_box.ForeColor = System.Drawing.Color.White;
            this.enchant_list_box.FormattingEnabled = true;
            this.enchant_list_box.Location = new System.Drawing.Point(0, 0);
            this.enchant_list_box.Name = "enchant_list_box";
            this.enchant_list_box.Size = new System.Drawing.Size(459, 192);
            this.enchant_list_box.TabIndex = 0;
            this.enchant_list_box.Click += new System.EventHandler(this.enchant_list_box_Click);
            // 
            // enchant_randomly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.enchant_list_box);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "enchant_randomly";
            this.Size = new System.Drawing.Size(459, 192);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckedListBox enchant_list_box;
    }
}
