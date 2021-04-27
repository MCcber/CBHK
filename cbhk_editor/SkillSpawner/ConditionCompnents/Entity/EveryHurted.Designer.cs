
namespace cbhk_editor.SkillSpawner.ConditionCompnents.Entity
{
    partial class EveryHurted
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EveryHurted));
            this.load_entity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // load_entity
            // 
            this.load_entity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("load_entity.BackgroundImage")));
            this.load_entity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.load_entity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.load_entity.FlatAppearance.BorderSize = 0;
            this.load_entity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.load_entity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.load_entity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_entity.ForeColor = System.Drawing.Color.White;
            this.load_entity.Location = new System.Drawing.Point(0, 0);
            this.load_entity.Name = "load_entity";
            this.load_entity.Size = new System.Drawing.Size(75, 23);
            this.load_entity.TabIndex = 0;
            this.load_entity.Text = "导入实体";
            this.load_entity.UseVisualStyleBackColor = true;
            // 
            // EveryHurted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.load_entity);
            this.Name = "EveryHurted";
            this.Size = new System.Drawing.Size(76, 24);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button load_entity;
    }
}
