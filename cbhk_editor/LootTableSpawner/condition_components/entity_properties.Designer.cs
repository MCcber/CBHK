
namespace cbhk_editor.LootTableSpawner.condition_components
{
    partial class entity_properties
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
            this.label1 = new System.Windows.Forms.Label();
            this.entity_box = new System.Windows.Forms.ComboBox();
            this.set_entity = new System.Windows.Forms.Button();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 367F));
            this.table.Controls.Add(this.label1, 0, 0);
            this.table.Controls.Add(this.entity_box, 1, 0);
            this.table.Controls.Add(this.set_entity, 0, 1);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.ForeColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 2;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.table.Size = new System.Drawing.Size(444, 243);
            this.table.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "检测的实体:";
            // 
            // entity_box
            // 
            this.entity_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.entity_box.ForeColor = System.Drawing.Color.White;
            this.entity_box.FormattingEnabled = true;
            this.entity_box.Items.AddRange(new object[] {
            "this",
            "killer",
            "killer_entity"});
            this.entity_box.Location = new System.Drawing.Point(80, 3);
            this.entity_box.Name = "entity_box";
            this.entity_box.Size = new System.Drawing.Size(121, 20);
            this.entity_box.TabIndex = 1;
            this.entity_box.SelectedIndexChanged += new System.EventHandler(this.entity_box_SelectedIndexChanged);
            this.entity_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.entity_box_KeyPress);
            // 
            // set_entity
            // 
            this.table.SetColumnSpan(this.set_entity, 2);
            this.set_entity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_entity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_entity.FlatAppearance.BorderSize = 0;
            this.set_entity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_entity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_entity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.set_entity.Location = new System.Drawing.Point(3, 26);
            this.set_entity.Name = "set_entity";
            this.set_entity.Size = new System.Drawing.Size(438, 214);
            this.set_entity.TabIndex = 2;
            this.set_entity.Text = "设置检测的实体";
            this.set_entity.UseVisualStyleBackColor = true;
            this.set_entity.Click += new System.EventHandler(this.set_entity_Click);
            // 
            // entity_properties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.Name = "entity_properties";
            this.Size = new System.Drawing.Size(444, 243);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox entity_box;
        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Button set_entity;
    }
}
