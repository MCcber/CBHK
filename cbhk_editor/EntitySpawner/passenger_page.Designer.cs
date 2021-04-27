
namespace cbhk_editor.EntitySpawner
{
    partial class passenger_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(passenger_page));
            this.passengerTab = new System.Windows.Forms.TabControl();
            this.passenger_tab = new System.Windows.Forms.TabPage();
            this.passenger_entity_btn = new System.Windows.Forms.Button();
            this.passengerTab.SuspendLayout();
            this.passenger_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // passengerTab
            // 
            this.passengerTab.Controls.Add(this.passenger_tab);
            this.passengerTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passengerTab.Location = new System.Drawing.Point(0, 0);
            this.passengerTab.Name = "passengerTab";
            this.passengerTab.SelectedIndex = 0;
            this.passengerTab.Size = new System.Drawing.Size(464, 54);
            this.passengerTab.TabIndex = 39;
            // 
            // passenger_tab
            // 
            this.passenger_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.passenger_tab.Controls.Add(this.passenger_entity_btn);
            this.passenger_tab.ForeColor = System.Drawing.Color.White;
            this.passenger_tab.Location = new System.Drawing.Point(4, 22);
            this.passenger_tab.Name = "passenger_tab";
            this.passenger_tab.Padding = new System.Windows.Forms.Padding(3);
            this.passenger_tab.Size = new System.Drawing.Size(456, 28);
            this.passenger_tab.TabIndex = 0;
            this.passenger_tab.Text = "1";
            // 
            // passenger_entity_btn
            // 
            this.passenger_entity_btn.BackColor = System.Drawing.Color.Transparent;
            this.passenger_entity_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passenger_entity_btn.BackgroundImage")));
            this.passenger_entity_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.passenger_entity_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passenger_entity_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passenger_entity_btn.FlatAppearance.BorderSize = 0;
            this.passenger_entity_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.passenger_entity_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.passenger_entity_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passenger_entity_btn.Location = new System.Drawing.Point(3, 3);
            this.passenger_entity_btn.Name = "passenger_entity_btn";
            this.passenger_entity_btn.Size = new System.Drawing.Size(450, 22);
            this.passenger_entity_btn.TabIndex = 40;
            this.passenger_entity_btn.Text = "设置/查看骑乘实体";
            this.passenger_entity_btn.UseVisualStyleBackColor = false;
            this.passenger_entity_btn.Click += new System.EventHandler(this.passenger_entity_btn_Click);
            // 
            // passenger_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.passengerTab);
            this.Name = "passenger_page";
            this.Size = new System.Drawing.Size(464, 54);
            this.passengerTab.ResumeLayout(false);
            this.passenger_tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage passenger_tab;
        private System.Windows.Forms.Button passenger_entity_btn;
        public System.Windows.Forms.TabControl passengerTab;
    }
}
