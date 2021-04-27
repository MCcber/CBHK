
namespace cbhk_editor.LootTableSpawner.function_components
{
    partial class copy_nbt
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
            this.set_nbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // set_nbt
            // 
            this.set_nbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.set_nbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.set_nbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_nbt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_nbt.FlatAppearance.BorderSize = 0;
            this.set_nbt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_nbt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_nbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_nbt.ForeColor = System.Drawing.Color.White;
            this.set_nbt.Location = new System.Drawing.Point(0, 0);
            this.set_nbt.Name = "set_nbt";
            this.set_nbt.Size = new System.Drawing.Size(389, 191);
            this.set_nbt.TabIndex = 0;
            this.set_nbt.Text = "设置NBT";
            this.set_nbt.UseVisualStyleBackColor = false;
            this.set_nbt.Click += new System.EventHandler(this.set_nbt_Click);
            // 
            // copy_nbt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.set_nbt);
            this.Name = "copy_nbt";
            this.Size = new System.Drawing.Size(389, 191);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button set_nbt;
    }
}
