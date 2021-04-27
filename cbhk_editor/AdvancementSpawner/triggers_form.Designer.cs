
namespace cbhk_editor.AdvancementSpawner
{
    partial class triggers_form
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
            this.trigger_tip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // triggers_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(539, 372);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "triggers_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置触发器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.triggers_form_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip trigger_tip;
    }
}