
namespace cbhk_editor.LootTableSpawner.function_components
{
    partial class set_nbt
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
            this.nbt_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nbt_box
            // 
            this.nbt_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nbt_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nbt_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.nbt_box.Location = new System.Drawing.Point(0, 0);
            this.nbt_box.Multiline = true;
            this.nbt_box.Name = "nbt_box";
            this.nbt_box.Size = new System.Drawing.Size(559, 326);
            this.nbt_box.TabIndex = 0;
            this.nbt_box.Text = "设置NBT(请自行转义:1层起)";
            this.nbt_box.TextChanged += new System.EventHandler(this.nbt_box_TextChanged);
            // 
            // set_nbt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nbt_box);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "set_nbt";
            this.Size = new System.Drawing.Size(559, 326);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox nbt_box;
    }
}
