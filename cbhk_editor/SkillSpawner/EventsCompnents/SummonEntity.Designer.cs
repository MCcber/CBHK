
namespace cbhk_editor.SkillSpawner.EventsCompnents
{
    partial class SummonEntity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummonEntity));
            this.label1 = new System.Windows.Forms.Label();
            this.entity_id_box = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.load_entity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "召唤:";
            // 
            // entity_id_box
            // 
            this.entity_id_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.entity_id_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.entity_id_box.ForeColor = System.Drawing.Color.White;
            this.entity_id_box.FormattingEnabled = true;
            this.entity_id_box.Location = new System.Drawing.Point(33, 0);
            this.entity_id_box.Name = "entity_id_box";
            this.entity_id_box.Size = new System.Drawing.Size(171, 20);
            this.entity_id_box.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(210, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "NBT:";
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
            this.load_entity.Location = new System.Drawing.Point(237, 0);
            this.load_entity.Name = "load_entity";
            this.load_entity.Size = new System.Drawing.Size(75, 23);
            this.load_entity.TabIndex = 3;
            this.load_entity.Text = "导入NBT";
            this.load_entity.UseVisualStyleBackColor = true;
            // 
            // SummonEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.load_entity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.entity_id_box);
            this.Controls.Add(this.label1);
            this.Name = "SummonEntity";
            this.Size = new System.Drawing.Size(315, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox entity_id_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button load_entity;
    }
}
