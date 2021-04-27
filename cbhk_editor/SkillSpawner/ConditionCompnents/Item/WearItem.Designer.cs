
namespace cbhk_editor.SkillSpawner.ConditionCompnents.Item
{
    partial class WearItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WearItem));
            this.label1 = new System.Windows.Forms.Label();
            this.inventory_index = new System.Windows.Forms.NumericUpDown();
            this.load_wear_item = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_index)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "槽位索引:";
            // 
            // inventory_index
            // 
            this.inventory_index.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.inventory_index.Location = new System.Drawing.Point(57, 0);
            this.inventory_index.Maximum = new decimal(new int[] {
            103,
            0,
            0,
            0});
            this.inventory_index.Minimum = new decimal(new int[] {
            106,
            0,
            0,
            -2147483648});
            this.inventory_index.Name = "inventory_index";
            this.inventory_index.Size = new System.Drawing.Size(56, 21);
            this.inventory_index.TabIndex = 1;
            // 
            // load_wear_item
            // 
            this.load_wear_item.BackColor = System.Drawing.Color.Transparent;
            this.load_wear_item.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("load_wear_item.BackgroundImage")));
            this.load_wear_item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.load_wear_item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.load_wear_item.FlatAppearance.BorderSize = 0;
            this.load_wear_item.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.load_wear_item.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.load_wear_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_wear_item.ForeColor = System.Drawing.Color.White;
            this.load_wear_item.Location = new System.Drawing.Point(113, 0);
            this.load_wear_item.Name = "load_wear_item";
            this.load_wear_item.Size = new System.Drawing.Size(102, 23);
            this.load_wear_item.TabIndex = 2;
            this.load_wear_item.Text = "导入的穿戴物品";
            this.load_wear_item.UseVisualStyleBackColor = false;
            // 
            // WearItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.load_wear_item);
            this.Controls.Add(this.inventory_index);
            this.Controls.Add(this.label1);
            this.Name = "WearItem";
            this.Size = new System.Drawing.Size(216, 22);
            ((System.ComponentModel.ISupportInitialize)(this.inventory_index)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown inventory_index;
        private System.Windows.Forms.Button load_wear_item;
    }
}
