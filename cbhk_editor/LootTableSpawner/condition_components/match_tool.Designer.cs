
namespace cbhk_editor.LootTableSpawner.condition_components
{
    partial class match_tool
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
            this.set_item = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // set_item
            // 
            this.set_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.set_item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_item.Location = new System.Drawing.Point(0, 0);
            this.set_item.Name = "set_item";
            this.set_item.Size = new System.Drawing.Size(444, 243);
            this.set_item.TabIndex = 0;
            this.set_item.Text = "设置物品谓词";
            this.set_item.UseVisualStyleBackColor = false;
            this.set_item.Click += new System.EventHandler(this.set_item_Click);
            // 
            // match_tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.set_item);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "match_tool";
            this.Size = new System.Drawing.Size(444, 243);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button set_item;
    }
}
