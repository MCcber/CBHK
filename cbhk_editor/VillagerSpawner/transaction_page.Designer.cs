
namespace cbhk_editor.VillagerSpawner
{
    partial class transaction_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transaction_page));
            this.transaction_tab = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.transaction_table = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.set_item1 = new System.Windows.Forms.Button();
            this.set_item2 = new System.Windows.Forms.Button();
            this.set_item3 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.xp_box = new System.Windows.Forms.NumericUpDown();
            this.uses_box = new System.Windows.Forms.NumericUpDown();
            this.maxUses_box = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.demand_box = new System.Windows.Forms.NumericUpDown();
            this.specialPrice_box = new System.Windows.Forms.NumericUpDown();
            this.rewardExp = new System.Windows.Forms.CheckBox();
            this.priceMultiplier_box = new System.Windows.Forms.TextBox();
            this.transaction_tab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.transaction_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xp_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uses_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxUses_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demand_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialPrice_box)).BeginInit();
            this.SuspendLayout();
            // 
            // transaction_tab
            // 
            this.transaction_tab.Controls.Add(this.tabPage2);
            this.transaction_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transaction_tab.Location = new System.Drawing.Point(0, 0);
            this.transaction_tab.Name = "transaction_tab";
            this.transaction_tab.SelectedIndex = 0;
            this.transaction_tab.Size = new System.Drawing.Size(582, 158);
            this.transaction_tab.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.transaction_table);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(574, 132);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "1号交易";
            // 
            // transaction_table
            // 
            this.transaction_table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.transaction_table.ColumnCount = 5;
            this.transaction_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.transaction_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.transaction_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.transaction_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.transaction_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 234F));
            this.transaction_table.Controls.Add(this.label11, 0, 0);
            this.transaction_table.Controls.Add(this.label14, 0, 1);
            this.transaction_table.Controls.Add(this.label17, 0, 2);
            this.transaction_table.Controls.Add(this.set_item1, 1, 0);
            this.transaction_table.Controls.Add(this.set_item2, 1, 1);
            this.transaction_table.Controls.Add(this.set_item3, 1, 2);
            this.transaction_table.Controls.Add(this.label22, 3, 0);
            this.transaction_table.Controls.Add(this.label21, 3, 1);
            this.transaction_table.Controls.Add(this.label20, 3, 2);
            this.transaction_table.Controls.Add(this.xp_box, 4, 0);
            this.transaction_table.Controls.Add(this.uses_box, 4, 1);
            this.transaction_table.Controls.Add(this.maxUses_box, 4, 2);
            this.transaction_table.Controls.Add(this.label23, 0, 3);
            this.transaction_table.Controls.Add(this.label24, 0, 4);
            this.transaction_table.Controls.Add(this.label25, 3, 3);
            this.transaction_table.Controls.Add(this.demand_box, 2, 3);
            this.transaction_table.Controls.Add(this.specialPrice_box, 2, 4);
            this.transaction_table.Controls.Add(this.rewardExp, 3, 4);
            this.transaction_table.Controls.Add(this.priceMultiplier_box, 4, 3);
            this.transaction_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transaction_table.ForeColor = System.Drawing.Color.White;
            this.transaction_table.Location = new System.Drawing.Point(3, 3);
            this.transaction_table.Name = "transaction_table";
            this.transaction_table.RowCount = 5;
            this.transaction_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.transaction_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.transaction_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.transaction_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.transaction_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.transaction_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.transaction_table.Size = new System.Drawing.Size(568, 126);
            this.transaction_table.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(9, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "Buy:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(3, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 12);
            this.label14.TabIndex = 6;
            this.label14.Text = "BuyB:";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(3, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 12);
            this.label17.TabIndex = 12;
            this.label17.Text = "Sell:";
            // 
            // set_item1
            // 
            this.set_item1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_item1.BackgroundImage")));
            this.set_item1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transaction_table.SetColumnSpan(this.set_item1, 2);
            this.set_item1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_item1.FlatAppearance.BorderSize = 0;
            this.set_item1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_item1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_item1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_item1.Location = new System.Drawing.Point(44, 3);
            this.set_item1.Name = "set_item1";
            this.set_item1.Size = new System.Drawing.Size(178, 21);
            this.set_item1.TabIndex = 5;
            this.set_item1.Text = "设置物品";
            this.set_item1.UseVisualStyleBackColor = true;
            // 
            // set_item2
            // 
            this.set_item2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_item2.BackgroundImage")));
            this.set_item2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transaction_table.SetColumnSpan(this.set_item2, 2);
            this.set_item2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_item2.FlatAppearance.BorderSize = 0;
            this.set_item2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_item2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_item2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_item2.Location = new System.Drawing.Point(44, 30);
            this.set_item2.Name = "set_item2";
            this.set_item2.Size = new System.Drawing.Size(178, 20);
            this.set_item2.TabIndex = 11;
            this.set_item2.Text = "设置物品";
            this.set_item2.UseVisualStyleBackColor = true;
            // 
            // set_item3
            // 
            this.set_item3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_item3.BackgroundImage")));
            this.set_item3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transaction_table.SetColumnSpan(this.set_item3, 2);
            this.set_item3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_item3.FlatAppearance.BorderSize = 0;
            this.set_item3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.set_item3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.set_item3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_item3.Location = new System.Drawing.Point(44, 56);
            this.set_item3.Name = "set_item3";
            this.set_item3.Size = new System.Drawing.Size(178, 21);
            this.set_item3.TabIndex = 17;
            this.set_item3.Text = "设置物品";
            this.set_item3.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(308, 7);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(23, 12);
            this.label22.TabIndex = 24;
            this.label22.Text = "xp:";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(296, 34);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 12);
            this.label21.TabIndex = 22;
            this.label21.Text = "uses:";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(278, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 30;
            this.label20.Text = "maxUses:";
            // 
            // xp_box
            // 
            this.xp_box.BackColor = System.Drawing.Color.Gray;
            this.xp_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xp_box.ForeColor = System.Drawing.Color.White;
            this.xp_box.Location = new System.Drawing.Point(337, 3);
            this.xp_box.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.xp_box.Name = "xp_box";
            this.xp_box.Size = new System.Drawing.Size(201, 17);
            this.xp_box.TabIndex = 25;
            // 
            // uses_box
            // 
            this.uses_box.BackColor = System.Drawing.Color.Gray;
            this.uses_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uses_box.ForeColor = System.Drawing.Color.White;
            this.uses_box.Location = new System.Drawing.Point(337, 30);
            this.uses_box.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.uses_box.Name = "uses_box";
            this.uses_box.Size = new System.Drawing.Size(201, 17);
            this.uses_box.TabIndex = 23;
            // 
            // maxUses_box
            // 
            this.maxUses_box.BackColor = System.Drawing.Color.Gray;
            this.maxUses_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxUses_box.ForeColor = System.Drawing.Color.White;
            this.maxUses_box.Location = new System.Drawing.Point(337, 56);
            this.maxUses_box.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.maxUses_box.Name = "maxUses_box";
            this.maxUses_box.Size = new System.Drawing.Size(201, 17);
            this.maxUses_box.TabIndex = 21;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label23.AutoSize = true;
            this.transaction_table.SetColumnSpan(this.label23, 2);
            this.label23.Location = new System.Drawing.Point(39, 86);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(47, 12);
            this.label23.TabIndex = 26;
            this.label23.Text = "demand:";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label24.AutoSize = true;
            this.transaction_table.SetColumnSpan(this.label24, 2);
            this.label24.Location = new System.Drawing.Point(3, 110);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 12);
            this.label24.TabIndex = 28;
            this.label24.Text = "specialPrice:";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(230, 86);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(101, 12);
            this.label25.TabIndex = 31;
            this.label25.Text = "priceMultiplier:";
            // 
            // demand_box
            // 
            this.demand_box.BackColor = System.Drawing.Color.Gray;
            this.demand_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.demand_box.ForeColor = System.Drawing.Color.White;
            this.demand_box.Location = new System.Drawing.Point(92, 83);
            this.demand_box.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.demand_box.Name = "demand_box";
            this.demand_box.Size = new System.Drawing.Size(131, 17);
            this.demand_box.TabIndex = 27;
            // 
            // specialPrice_box
            // 
            this.specialPrice_box.BackColor = System.Drawing.Color.Gray;
            this.specialPrice_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.specialPrice_box.ForeColor = System.Drawing.Color.White;
            this.specialPrice_box.Location = new System.Drawing.Point(92, 108);
            this.specialPrice_box.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.specialPrice_box.Name = "specialPrice_box";
            this.specialPrice_box.Size = new System.Drawing.Size(131, 17);
            this.specialPrice_box.TabIndex = 29;
            // 
            // rewardExp
            // 
            this.rewardExp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rewardExp.AutoSize = true;
            this.rewardExp.Location = new System.Drawing.Point(229, 108);
            this.rewardExp.Name = "rewardExp";
            this.rewardExp.Size = new System.Drawing.Size(78, 16);
            this.rewardExp.TabIndex = 20;
            this.rewardExp.Text = "rewardExp";
            this.rewardExp.UseVisualStyleBackColor = true;
            // 
            // priceMultiplier_box
            // 
            this.priceMultiplier_box.BackColor = System.Drawing.Color.Gray;
            this.priceMultiplier_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceMultiplier_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceMultiplier_box.ForeColor = System.Drawing.Color.White;
            this.priceMultiplier_box.Location = new System.Drawing.Point(337, 83);
            this.priceMultiplier_box.Name = "priceMultiplier_box";
            this.priceMultiplier_box.Size = new System.Drawing.Size(228, 21);
            this.priceMultiplier_box.TabIndex = 32;
            // 
            // transaction_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.transaction_tab);
            this.Name = "transaction_page";
            this.Size = new System.Drawing.Size(582, 158);
            this.transaction_tab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.transaction_table.ResumeLayout(false);
            this.transaction_table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xp_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uses_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxUses_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demand_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialPrice_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button set_item1;
        private System.Windows.Forms.Button set_item2;
        private System.Windows.Forms.Button set_item3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown xp_box;
        private System.Windows.Forms.NumericUpDown uses_box;
        private System.Windows.Forms.NumericUpDown maxUses_box;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown demand_box;
        private System.Windows.Forms.NumericUpDown specialPrice_box;
        private System.Windows.Forms.CheckBox rewardExp;
        private System.Windows.Forms.TextBox priceMultiplier_box;
        public System.Windows.Forms.TabControl transaction_tab;
        public System.Windows.Forms.TableLayoutPanel transaction_table;
    }
}
