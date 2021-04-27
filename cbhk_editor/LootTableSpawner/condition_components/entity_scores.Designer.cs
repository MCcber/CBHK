
namespace cbhk_editor.LootTableSpawner.condition_components
{
    partial class entity_scores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(entity_scores));
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.score_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.entity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.add_score = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.min_box = new System.Windows.Forms.TextBox();
            this.max_box = new System.Windows.Forms.TextBox();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 3;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.table.Controls.Add(this.score_box, 1, 1);
            this.table.Controls.Add(this.label1, 0, 0);
            this.table.Controls.Add(this.entity, 1, 0);
            this.table.Controls.Add(this.label2, 0, 2);
            this.table.Controls.Add(this.label3, 0, 3);
            this.table.Controls.Add(this.add_score, 2, 1);
            this.table.Controls.Add(this.label4, 0, 1);
            this.table.Controls.Add(this.min_box, 1, 2);
            this.table.Controls.Add(this.max_box, 1, 3);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.ForeColor = System.Drawing.Color.White;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 4;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.table.Size = new System.Drawing.Size(444, 243);
            this.table.TabIndex = 0;
            // 
            // score_box
            // 
            this.score_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.score_box.ForeColor = System.Drawing.Color.White;
            this.score_box.FormattingEnabled = true;
            this.score_box.Location = new System.Drawing.Point(130, 29);
            this.score_box.Name = "score_box";
            this.score_box.Size = new System.Drawing.Size(238, 20);
            this.score_box.TabIndex = 3;
            this.score_box.SelectedIndexChanged += new System.EventHandler(this.score_box_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "检测的实体:";
            // 
            // entity
            // 
            this.entity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.entity.ForeColor = System.Drawing.Color.White;
            this.entity.FormattingEnabled = true;
            this.entity.Items.AddRange(new object[] {
            "this",
            "killer",
            "killer_player"});
            this.entity.Location = new System.Drawing.Point(130, 3);
            this.entity.Name = "entity";
            this.entity.Size = new System.Drawing.Size(121, 20);
            this.entity.TabIndex = 1;
            this.entity.SelectedIndexChanged += new System.EventHandler(this.entity_SelectedIndexChanged);
            this.entity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.entity_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "最小值:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "最大值:";
            // 
            // add_score
            // 
            this.add_score.BackColor = System.Drawing.Color.Gray;
            this.add_score.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_score.BackgroundImage")));
            this.add_score.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_score.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_score.FlatAppearance.BorderSize = 0;
            this.add_score.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_score.Location = new System.Drawing.Point(374, 29);
            this.add_score.Name = "add_score";
            this.add_score.Size = new System.Drawing.Size(67, 23);
            this.add_score.TabIndex = 4;
            this.add_score.Text = "添加";
            this.add_score.UseVisualStyleBackColor = false;
            this.add_score.Click += new System.EventHandler(this.add_score_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "记分板名:";
            // 
            // min_box
            // 
            this.min_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.min_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.min_box.ForeColor = System.Drawing.Color.White;
            this.min_box.Location = new System.Drawing.Point(130, 60);
            this.min_box.Name = "min_box";
            this.min_box.Size = new System.Drawing.Size(238, 21);
            this.min_box.TabIndex = 10;
            // 
            // max_box
            // 
            this.max_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.max_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.max_box.ForeColor = System.Drawing.Color.White;
            this.max_box.Location = new System.Drawing.Point(130, 88);
            this.max_box.Name = "max_box";
            this.max_box.Size = new System.Drawing.Size(238, 21);
            this.max_box.TabIndex = 11;
            // 
            // entity_scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.Name = "entity_scores";
            this.Size = new System.Drawing.Size(444, 243);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox entity;
        private System.Windows.Forms.ComboBox score_box;
        private System.Windows.Forms.Button add_score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox min_box;
        private System.Windows.Forms.TextBox max_box;
    }
}
