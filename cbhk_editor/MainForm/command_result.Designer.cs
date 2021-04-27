
namespace cbhk_editor.MainForm
{
    partial class command_result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(command_result));
            this.click_to_copy = new System.Windows.Forms.Button();
            this.cmd_result_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmd_result_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // click_to_copy
            // 
            this.click_to_copy.BackColor = System.Drawing.Color.Transparent;
            this.click_to_copy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("click_to_copy.BackgroundImage")));
            this.click_to_copy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.click_to_copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.click_to_copy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.click_to_copy.FlatAppearance.BorderSize = 0;
            this.click_to_copy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.click_to_copy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.click_to_copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.click_to_copy.Location = new System.Drawing.Point(0, 334);
            this.click_to_copy.Name = "click_to_copy";
            this.click_to_copy.Size = new System.Drawing.Size(460, 47);
            this.click_to_copy.TabIndex = 1;
            this.click_to_copy.Text = "全选并复制";
            this.click_to_copy.UseVisualStyleBackColor = false;
            this.click_to_copy.Click += new System.EventHandler(this.click_to_copy_Click);
            // 
            // cmd_result_tab
            // 
            this.cmd_result_tab.Controls.Add(this.tabPage1);
            this.cmd_result_tab.Location = new System.Drawing.Point(0, 1);
            this.cmd_result_tab.Name = "cmd_result_tab";
            this.cmd_result_tab.SelectedIndex = 0;
            this.cmd_result_tab.Size = new System.Drawing.Size(460, 336);
            this.cmd_result_tab.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(452, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "第1条";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // command_result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(460, 381);
            this.Controls.Add(this.cmd_result_tab);
            this.Controls.Add(this.click_to_copy);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "command_result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "command_result";
            this.cmd_result_tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button click_to_copy;
        private System.Windows.Forms.TabControl cmd_result_tab;
        private System.Windows.Forms.TabPage tabPage1;
    }
}