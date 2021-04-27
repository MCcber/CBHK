
namespace cbhk_editor.LootTableSpawner.function_components
{
    partial class set_lore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(set_lore));
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.entity_box = new System.Windows.Forms.ComboBox();
            this.set_lore_btn = new System.Windows.Forms.Button();
            this.replace_box = new System.Windows.Forms.CheckBox();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 3;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 364F));
            this.table.Controls.Add(this.label2, 0, 0);
            this.table.Controls.Add(this.entity_box, 1, 0);
            this.table.Controls.Add(this.set_lore_btn, 2, 0);
            this.table.Controls.Add(this.replace_box, 1, 1);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.ForeColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 2;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.table.Size = new System.Drawing.Size(559, 326);
            this.table.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "指定实体:";
            // 
            // entity_box
            // 
            this.entity_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.entity_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.entity_box.ForeColor = System.Drawing.Color.White;
            this.entity_box.FormattingEnabled = true;
            this.entity_box.Items.AddRange(new object[] {
            "this",
            "killer",
            "killer_entity"});
            this.entity_box.Location = new System.Drawing.Point(71, 5);
            this.entity_box.Name = "entity_box";
            this.entity_box.Size = new System.Drawing.Size(117, 20);
            this.entity_box.TabIndex = 6;
            this.entity_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.entity_box_KeyPress);
            // 
            // set_lore_btn
            // 
            this.set_lore_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.set_lore_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_lore_btn.BackgroundImage")));
            this.set_lore_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.set_lore_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_lore_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.set_lore_btn.FlatAppearance.BorderSize = 0;
            this.set_lore_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_lore_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_lore_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_lore_btn.Location = new System.Drawing.Point(198, 3);
            this.set_lore_btn.Name = "set_lore_btn";
            this.set_lore_btn.Size = new System.Drawing.Size(358, 24);
            this.set_lore_btn.TabIndex = 7;
            this.set_lore_btn.Text = "设置描述";
            this.set_lore_btn.UseVisualStyleBackColor = false;
            this.set_lore_btn.Click += new System.EventHandler(this.set_lore_btn_Click);
            // 
            // replace_box
            // 
            this.replace_box.AutoSize = true;
            this.replace_box.Checked = true;
            this.replace_box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.replace_box.Location = new System.Drawing.Point(71, 33);
            this.replace_box.Name = "replace_box";
            this.replace_box.Size = new System.Drawing.Size(120, 16);
            this.replace_box.TabIndex = 8;
            this.replace_box.Text = "是否覆盖原有描述";
            this.replace_box.UseVisualStyleBackColor = true;
            // 
            // set_lore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.Name = "set_lore";
            this.Size = new System.Drawing.Size(559, 326);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox entity_box;
        private System.Windows.Forms.Button set_lore_btn;
        private System.Windows.Forms.CheckBox replace_box;
        public System.Windows.Forms.TableLayoutPanel table;
    }
}
