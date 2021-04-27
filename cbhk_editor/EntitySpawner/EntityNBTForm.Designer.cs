
namespace cbhk_editor.EntitySpawner
{
    partial class EntityNBTForm
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
            this.nbt_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nbt_box
            // 
            this.nbt_box.BackColor = System.Drawing.Color.Gray;
            this.nbt_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nbt_box.ForeColor = System.Drawing.Color.White;
            this.nbt_box.Location = new System.Drawing.Point(0, 0);
            this.nbt_box.Multiline = true;
            this.nbt_box.Name = "nbt_box";
            this.nbt_box.Size = new System.Drawing.Size(329, 261);
            this.nbt_box.TabIndex = 0;
            // 
            // EntityNBTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 261);
            this.Controls.Add(this.nbt_box);
            this.MaximizeBox = false;
            this.Name = "EntityNBTForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "特殊NBT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EntityNBTForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nbt_box;
    }
}