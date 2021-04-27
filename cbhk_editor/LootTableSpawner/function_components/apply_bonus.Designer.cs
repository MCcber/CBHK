
namespace cbhk_editor.LootTableSpawner.function_components
{
    partial class apply_bonus
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
            this.formula_box = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.enchant_id_box = new System.Windows.Forms.ComboBox();
            this.parameter_box = new System.Windows.Forms.GroupBox();
            this.parameter_area = new System.Windows.Forms.TableLayoutPanel();
            this.bonusMultiplier_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.probability_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.extra_box = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.table.SuspendLayout();
            this.parameter_box.SuspendLayout();
            this.parameter_area.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extra_box)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 338F));
            this.table.Controls.Add(this.formula_box, 1, 1);
            this.table.Controls.Add(this.label2, 0, 1);
            this.table.Controls.Add(this.label1, 0, 0);
            this.table.Controls.Add(this.enchant_id_box, 1, 0);
            this.table.Controls.Add(this.parameter_box, 0, 2);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 3;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.table.Size = new System.Drawing.Size(404, 168);
            this.table.TabIndex = 0;
            // 
            // formula_box
            // 
            this.formula_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.formula_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formula_box.ForeColor = System.Drawing.Color.White;
            this.formula_box.FormattingEnabled = true;
            this.formula_box.Items.AddRange(new object[] {
            "binomial_with_bonus_count",
            "uniform_bonus_count",
            "ore_drops"});
            this.formula_box.Location = new System.Drawing.Point(69, 29);
            this.formula_box.Name = "formula_box";
            this.formula_box.Size = new System.Drawing.Size(332, 20);
            this.formula_box.TabIndex = 3;
            this.formula_box.Text = "ore_drops";
            this.formula_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.formula_box_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "计算公式:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "附魔ID:";
            // 
            // enchant_id_box
            // 
            this.enchant_id_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.enchant_id_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enchant_id_box.ForeColor = System.Drawing.Color.White;
            this.enchant_id_box.FormattingEnabled = true;
            this.enchant_id_box.Location = new System.Drawing.Point(69, 3);
            this.enchant_id_box.Name = "enchant_id_box";
            this.enchant_id_box.Size = new System.Drawing.Size(332, 20);
            this.enchant_id_box.TabIndex = 1;
            // 
            // parameter_box
            // 
            this.table.SetColumnSpan(this.parameter_box, 2);
            this.parameter_box.Controls.Add(this.parameter_area);
            this.parameter_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parameter_box.ForeColor = System.Drawing.Color.White;
            this.parameter_box.Location = new System.Drawing.Point(3, 55);
            this.parameter_box.Name = "parameter_box";
            this.parameter_box.Size = new System.Drawing.Size(398, 110);
            this.parameter_box.TabIndex = 4;
            this.parameter_box.TabStop = false;
            this.parameter_box.Text = "参数:";
            // 
            // parameter_area
            // 
            this.parameter_area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.parameter_area.ColumnCount = 2;
            this.parameter_area.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.parameter_area.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 284F));
            this.parameter_area.Controls.Add(this.bonusMultiplier_box, 1, 2);
            this.parameter_area.Controls.Add(this.label3, 0, 0);
            this.parameter_area.Controls.Add(this.probability_box, 1, 1);
            this.parameter_area.Controls.Add(this.label5, 0, 2);
            this.parameter_area.Controls.Add(this.extra_box, 1, 0);
            this.parameter_area.Controls.Add(this.label4, 0, 1);
            this.parameter_area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parameter_area.Location = new System.Drawing.Point(3, 17);
            this.parameter_area.Name = "parameter_area";
            this.parameter_area.RowCount = 3;
            this.parameter_area.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.parameter_area.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.parameter_area.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.parameter_area.Size = new System.Drawing.Size(392, 90);
            this.parameter_area.TabIndex = 1;
            // 
            // bonusMultiplier_box
            // 
            this.bonusMultiplier_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bonusMultiplier_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bonusMultiplier_box.ForeColor = System.Drawing.Color.White;
            this.bonusMultiplier_box.Location = new System.Drawing.Point(111, 64);
            this.bonusMultiplier_box.Name = "bonusMultiplier_box";
            this.bonusMultiplier_box.Size = new System.Drawing.Size(278, 21);
            this.bonusMultiplier_box.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "extra:";
            // 
            // probability_box
            // 
            this.probability_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.probability_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.probability_box.ForeColor = System.Drawing.Color.White;
            this.probability_box.Location = new System.Drawing.Point(111, 34);
            this.probability_box.Name = "probability_box";
            this.probability_box.Size = new System.Drawing.Size(278, 21);
            this.probability_box.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "bonusMultiplier:";
            // 
            // extra_box
            // 
            this.extra_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.extra_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.extra_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.extra_box.ForeColor = System.Drawing.Color.White;
            this.extra_box.Location = new System.Drawing.Point(111, 7);
            this.extra_box.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.extra_box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.extra_box.Name = "extra_box";
            this.extra_box.Size = new System.Drawing.Size(278, 17);
            this.extra_box.TabIndex = 1;
            this.extra_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "probability:";
            // 
            // apply_bonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "apply_bonus";
            this.Size = new System.Drawing.Size(404, 168);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.parameter_box.ResumeLayout(false);
            this.parameter_area.ResumeLayout(false);
            this.parameter_area.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extra_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox enchant_id_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox formula_box;
        private System.Windows.Forms.GroupBox parameter_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown extra_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox probability_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bonusMultiplier_box;
        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.TableLayoutPanel parameter_area;
    }
}
