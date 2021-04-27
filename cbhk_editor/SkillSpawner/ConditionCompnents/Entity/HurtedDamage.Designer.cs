
namespace cbhk_editor.SkillSpawner.ConditionCompnents.Entity
{
    partial class HurtedDamage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HurtedDamage));
            this.label1 = new System.Windows.Forms.Label();
            this.hurt_damage_value = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.load_entity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hurt_damage_value)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "受到";
            // 
            // hurt_damage_value
            // 
            this.hurt_damage_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.hurt_damage_value.Location = new System.Drawing.Point(30, 0);
            this.hurt_damage_value.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.hurt_damage_value.Name = "hurt_damage_value";
            this.hurt_damage_value.Size = new System.Drawing.Size(128, 21);
            this.hurt_damage_value.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(159, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "点伤害";
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
            this.load_entity.Location = new System.Drawing.Point(202, 0);
            this.load_entity.Name = "load_entity";
            this.load_entity.Size = new System.Drawing.Size(75, 23);
            this.load_entity.TabIndex = 3;
            this.load_entity.Text = "导入实体";
            this.load_entity.UseVisualStyleBackColor = true;
            // 
            // HurtedDamage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.load_entity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hurt_damage_value);
            this.Controls.Add(this.label1);
            this.Name = "HurtedDamage";
            this.Size = new System.Drawing.Size(279, 21);
            ((System.ComponentModel.ISupportInitialize)(this.hurt_damage_value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown hurt_damage_value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button load_entity;
    }
}
