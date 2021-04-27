
namespace cbhk_editor.LootTableSpawner.condition_components.SubComponents.EntityProperty
{
    partial class equipment_slot
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
            this.slot_box = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // slot_box
            // 
            this.slot_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.slot_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slot_box.ForeColor = System.Drawing.Color.White;
            this.slot_box.FormattingEnabled = true;
            this.slot_box.Items.AddRange(new object[] {
            "mainhand",
            "offhand",
            "head",
            "chest",
            "legs",
            "feet"});
            this.slot_box.Location = new System.Drawing.Point(0, 0);
            this.slot_box.Name = "slot_box";
            this.slot_box.Size = new System.Drawing.Size(243, 150);
            this.slot_box.TabIndex = 0;
            // 
            // equipment_slot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(243, 150);
            this.Controls.Add(this.slot_box);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "equipment_slot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置装备槽位";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.equipment_slot_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckedListBox slot_box;
    }
}