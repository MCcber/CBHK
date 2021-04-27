
namespace cbhk_editor.LootTableSpawner.condition_components
{
    partial class damage_source_properties
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
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.set_source_entity = new System.Windows.Forms.Button();
            this.damage_obj_box = new System.Windows.Forms.CheckedListBox();
            this.set_direct_entity = new System.Windows.Forms.Button();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 3;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.table.Controls.Add(this.set_source_entity, 2, 0);
            this.table.Controls.Add(this.damage_obj_box, 0, 0);
            this.table.Controls.Add(this.set_direct_entity, 1, 0);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.ForeColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.table.Size = new System.Drawing.Size(444, 243);
            this.table.TabIndex = 0;
            // 
            // set_source_entity
            // 
            this.set_source_entity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.set_source_entity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_source_entity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_source_entity.FlatAppearance.BorderSize = 0;
            this.set_source_entity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_source_entity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_source_entity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.set_source_entity.Location = new System.Drawing.Point(305, 3);
            this.set_source_entity.Name = "set_source_entity";
            this.set_source_entity.Size = new System.Drawing.Size(136, 237);
            this.set_source_entity.TabIndex = 2;
            this.set_source_entity.Text = "设置伤害根本来源实体";
            this.set_source_entity.UseVisualStyleBackColor = true;
            // 
            // damage_obj_box
            // 
            this.damage_obj_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.damage_obj_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.damage_obj_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.damage_obj_box.ForeColor = System.Drawing.Color.White;
            this.damage_obj_box.FormattingEnabled = true;
            this.damage_obj_box.Location = new System.Drawing.Point(3, 3);
            this.damage_obj_box.Name = "damage_obj_box";
            this.damage_obj_box.Size = new System.Drawing.Size(145, 237);
            this.damage_obj_box.TabIndex = 0;
            this.damage_obj_box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.damage_obj_box_MouseDown);
            // 
            // set_direct_entity
            // 
            this.set_direct_entity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.set_direct_entity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_direct_entity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_direct_entity.FlatAppearance.BorderSize = 0;
            this.set_direct_entity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_direct_entity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_direct_entity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.set_direct_entity.Location = new System.Drawing.Point(154, 3);
            this.set_direct_entity.Name = "set_direct_entity";
            this.set_direct_entity.Size = new System.Drawing.Size(145, 237);
            this.set_direct_entity.TabIndex = 1;
            this.set_direct_entity.Text = "设置伤害直接来源实体";
            this.set_direct_entity.UseVisualStyleBackColor = true;
            // 
            // damage_source_properties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.Name = "damage_source_properties";
            this.Size = new System.Drawing.Size(444, 243);
            this.table.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox damage_obj_box;
        private System.Windows.Forms.Button set_direct_entity;
        private System.Windows.Forms.Button set_source_entity;
        public System.Windows.Forms.TableLayoutPanel table;
    }
}
