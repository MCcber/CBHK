
namespace cbhk_editor.SkillSpawner
{
    partial class SkillInforForm
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
            this.InfoList = new System.Windows.Forms.CheckedListBox();
            this.selectAll = new System.Windows.Forms.Button();
            this.reverseSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoList
            // 
            this.InfoList.BackColor = System.Drawing.Color.White;
            this.InfoList.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoList.ForeColor = System.Drawing.Color.Black;
            this.InfoList.FormattingEnabled = true;
            this.InfoList.Location = new System.Drawing.Point(0, 0);
            this.InfoList.Name = "InfoList";
            this.InfoList.Size = new System.Drawing.Size(408, 308);
            this.InfoList.TabIndex = 0;
            // 
            // selectAll
            // 
            this.selectAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectAll.BackColor = System.Drawing.SystemColors.Control;
            this.selectAll.ForeColor = System.Drawing.Color.White;
            this.selectAll.Location = new System.Drawing.Point(-1, 307);
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(213, 34);
            this.selectAll.TabIndex = 1;
            this.selectAll.Text = "全选";
            this.selectAll.UseVisualStyleBackColor = false;
            this.selectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // reverseSelect
            // 
            this.reverseSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reverseSelect.ForeColor = System.Drawing.Color.White;
            this.reverseSelect.Location = new System.Drawing.Point(210, 307);
            this.reverseSelect.Name = "reverseSelect";
            this.reverseSelect.Size = new System.Drawing.Size(199, 34);
            this.reverseSelect.TabIndex = 2;
            this.reverseSelect.Text = "反选";
            this.reverseSelect.UseVisualStyleBackColor = true;
            this.reverseSelect.Click += new System.EventHandler(this.ReverseSelect_Click);
            // 
            // SkillInforForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 340);
            this.Controls.Add(this.reverseSelect);
            this.Controls.Add(this.selectAll);
            this.Controls.Add(this.InfoList);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SkillInforForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "列表";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SkillInforForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox InfoList;
        private System.Windows.Forms.Button selectAll;
        private System.Windows.Forms.Button reverseSelect;
    }
}