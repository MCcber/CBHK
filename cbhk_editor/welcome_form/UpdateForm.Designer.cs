
namespace cbhk_editor.welcome_form
{
    partial class UpdateForm
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
            this.task_speed = new System.Windows.Forms.ProgressBar();
            this.task_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // task_speed
            // 
            this.task_speed.Location = new System.Drawing.Point(12, 12);
            this.task_speed.Name = "task_speed";
            this.task_speed.Size = new System.Drawing.Size(233, 23);
            this.task_speed.TabIndex = 0;
            // 
            // task_info
            // 
            this.task_info.AutoSize = true;
            this.task_info.Location = new System.Drawing.Point(10, 49);
            this.task_info.Name = "task_info";
            this.task_info.Size = new System.Drawing.Size(23, 12);
            this.task_info.TabIndex = 1;
            this.task_info.Text = "...";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 70);
            this.Controls.Add(this.task_info);
            this.Controls.Add(this.task_speed);
            this.MaximizeBox = false;
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "更新中...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar task_speed;
        private System.Windows.Forms.Label task_info;
    }
}