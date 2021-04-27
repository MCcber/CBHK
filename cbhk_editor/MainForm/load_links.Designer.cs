
namespace cbhk_editor.MainForm
{
    partial class Load_links
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Load_links));
            this.extern_links_area = new System.Windows.Forms.TableLayoutPanel();
            this.file_path_info = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.click_to_load = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // extern_links_area
            // 
            this.extern_links_area.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.extern_links_area.AutoScroll = true;
            this.extern_links_area.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.extern_links_area.ColumnCount = 3;
            this.extern_links_area.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.extern_links_area.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.extern_links_area.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.extern_links_area.Location = new System.Drawing.Point(0, 27);
            this.extern_links_area.Name = "extern_links_area";
            this.extern_links_area.RowCount = 1;
            this.extern_links_area.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 279F));
            this.extern_links_area.Size = new System.Drawing.Size(428, 276);
            this.extern_links_area.TabIndex = 0;
            // 
            // file_path_info
            // 
            this.file_path_info.AutoPopDelay = 5000;
            this.file_path_info.InitialDelay = 100;
            this.file_path_info.ReshowDelay = 100;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "链接图片路径";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(180, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "链接网址";
            // 
            // click_to_load
            // 
            this.click_to_load.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("click_to_load.BackgroundImage")));
            this.click_to_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.click_to_load.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.click_to_load.ForeColor = System.Drawing.Color.White;
            this.click_to_load.Location = new System.Drawing.Point(0, 302);
            this.click_to_load.Name = "click_to_load";
            this.click_to_load.Size = new System.Drawing.Size(428, 47);
            this.click_to_load.TabIndex = 3;
            this.click_to_load.Text = "修改/添加";
            this.click_to_load.UseVisualStyleBackColor = true;
            this.click_to_load.Click += new System.EventHandler(this.Click_to_load_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(327, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "图片描述";
            // 
            // Load_links
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(428, 349);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.click_to_load);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.extern_links_area);
            this.Name = "Load_links";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导入链接";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Load_links_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip file_path_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button click_to_load;
        public System.Windows.Forms.TableLayoutPanel extern_links_area;
        private System.Windows.Forms.Label label3;
    }
}