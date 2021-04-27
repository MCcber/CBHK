
namespace cbhk_editor.LootTableSpawner.function_components
{
    partial class set_name
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
            this.label3 = new System.Windows.Forms.Label();
            this.score_id_box = new System.Windows.Forms.TextBox();
            this.model_box = new System.Windows.Forms.CheckBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.player_name_box = new System.Windows.Forms.TextBox();
            this.entity_box = new System.Windows.Forms.ComboBox();
            this.font_property_box = new System.Windows.Forms.CheckedListBox();
            this.font_color_box = new System.Windows.Forms.CheckedListBox();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 4;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.table.Controls.Add(this.label3, 0, 2);
            this.table.Controls.Add(this.score_id_box, 1, 1);
            this.table.Controls.Add(this.model_box, 0, 0);
            this.table.Controls.Add(this.name_box, 1, 0);
            this.table.Controls.Add(this.label1, 0, 1);
            this.table.Controls.Add(this.label2, 2, 1);
            this.table.Controls.Add(this.player_name_box, 3, 1);
            this.table.Controls.Add(this.entity_box, 1, 2);
            this.table.Controls.Add(this.font_property_box, 0, 3);
            this.table.Controls.Add(this.font_color_box, 2, 3);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 4;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.table.Size = new System.Drawing.Size(559, 326);
            this.table.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "指定实体:";
            // 
            // score_id_box
            // 
            this.score_id_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.score_id_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.score_id_box.Enabled = false;
            this.score_id_box.ForeColor = System.Drawing.Color.White;
            this.score_id_box.Location = new System.Drawing.Point(88, 32);
            this.score_id_box.Name = "score_id_box";
            this.score_id_box.Size = new System.Drawing.Size(192, 21);
            this.score_id_box.TabIndex = 3;
            // 
            // model_box
            // 
            this.model_box.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.model_box.AutoSize = true;
            this.model_box.Checked = true;
            this.model_box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.model_box.Location = new System.Drawing.Point(10, 6);
            this.model_box.Name = "model_box";
            this.model_box.Size = new System.Drawing.Size(72, 16);
            this.model_box.TabIndex = 0;
            this.model_box.Text = "普通文本";
            this.model_box.UseVisualStyleBackColor = true;
            this.model_box.CheckedChanged += new System.EventHandler(this.model_box_CheckedChanged);
            // 
            // name_box
            // 
            this.name_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.SetColumnSpan(this.name_box, 3);
            this.name_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_box.ForeColor = System.Drawing.Color.White;
            this.name_box.Location = new System.Drawing.Point(88, 3);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(468, 21);
            this.name_box.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "记分项:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "玩家名:";
            // 
            // player_name_box
            // 
            this.player_name_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.player_name_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player_name_box.Enabled = false;
            this.player_name_box.ForeColor = System.Drawing.Color.White;
            this.player_name_box.Location = new System.Drawing.Point(339, 32);
            this.player_name_box.Name = "player_name_box";
            this.player_name_box.Size = new System.Drawing.Size(217, 21);
            this.player_name_box.TabIndex = 5;
            // 
            // entity_box
            // 
            this.entity_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.entity_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entity_box.ForeColor = System.Drawing.Color.White;
            this.entity_box.FormattingEnabled = true;
            this.entity_box.Items.AddRange(new object[] {
            "this",
            "killer",
            "killer_player"});
            this.entity_box.Location = new System.Drawing.Point(88, 60);
            this.entity_box.Name = "entity_box";
            this.entity_box.Size = new System.Drawing.Size(192, 20);
            this.entity_box.TabIndex = 7;
            this.entity_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.entity_box_KeyPress);
            // 
            // font_property_box
            // 
            this.font_property_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.font_property_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table.SetColumnSpan(this.font_property_box, 2);
            this.font_property_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.font_property_box.Enabled = false;
            this.font_property_box.ForeColor = System.Drawing.Color.White;
            this.font_property_box.FormattingEnabled = true;
            this.font_property_box.Items.AddRange(new object[] {
            "Bold",
            "Italic",
            "underlined",
            "strikethrough",
            "obfuscated"});
            this.font_property_box.Location = new System.Drawing.Point(3, 90);
            this.font_property_box.Name = "font_property_box";
            this.font_property_box.Size = new System.Drawing.Size(277, 233);
            this.font_property_box.TabIndex = 8;
            // 
            // font_color_box
            // 
            this.font_color_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.font_color_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table.SetColumnSpan(this.font_color_box, 2);
            this.font_color_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.font_color_box.Enabled = false;
            this.font_color_box.ForeColor = System.Drawing.Color.White;
            this.font_color_box.FormattingEnabled = true;
            this.font_color_box.Items.AddRange(new object[] {
            "aqua",
            "black",
            "blue",
            "dark_aqua",
            "dark_blue",
            "dark_gray",
            "dark_green",
            "dark_purple",
            "dark_red",
            "gold",
            "gray",
            "green",
            "light_purple",
            "red",
            "white",
            "yellow"});
            this.font_color_box.Location = new System.Drawing.Point(286, 90);
            this.font_color_box.Name = "font_color_box";
            this.font_color_box.Size = new System.Drawing.Size(270, 233);
            this.font_color_box.TabIndex = 9;
            this.font_color_box.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.font_color_box_ItemCheck);
            // 
            // set_name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "set_name";
            this.Size = new System.Drawing.Size(559, 326);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.CheckBox model_box;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox score_id_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox player_name_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox entity_box;
        public System.Windows.Forms.CheckedListBox font_property_box;
        public System.Windows.Forms.CheckedListBox font_color_box;
    }
}
