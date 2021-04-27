
namespace cbhk_editor.MainForm
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.user_head_box = new System.Windows.Forms.PictureBox();
            this.login = new System.Windows.Forms.PictureBox();
            this.result_display = new System.Windows.Forms.Label();
            this.go_to_register = new System.Windows.Forms.PictureBox();
            this.save_user_name_box = new System.Windows.Forms.PictureBox();
            this.save_passwd_box = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.user_head_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.go_to_register)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.save_user_name_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.save_passwd_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // user_head_box
            // 
            this.user_head_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.user_head_box.BackColor = System.Drawing.Color.Transparent;
            this.user_head_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.user_head_box.Location = new System.Drawing.Point(56, 173);
            this.user_head_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.user_head_box.Name = "user_head_box";
            this.user_head_box.Size = new System.Drawing.Size(130, 130);
            this.user_head_box.TabIndex = 13;
            this.user_head_box.TabStop = false;
            this.user_head_box.Paint += new System.Windows.Forms.PaintEventHandler(this.User_head_box_Paint);
            // 
            // login
            // 
            this.login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login.BackgroundImage")));
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.Location = new System.Drawing.Point(327, 336);
            this.login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(253, 54);
            this.login.TabIndex = 14;
            this.login.TabStop = false;
            this.login.Click += new System.EventHandler(this.Login_Click);
            this.login.MouseEnter += new System.EventHandler(this.Login_MouseEnter);
            this.login.MouseLeave += new System.EventHandler(this.Login_MouseLeave);
            // 
            // result_display
            // 
            this.result_display.AutoSize = true;
            this.result_display.BackColor = System.Drawing.Color.Transparent;
            this.result_display.ForeColor = System.Drawing.Color.Gray;
            this.result_display.Location = new System.Drawing.Point(305, 122);
            this.result_display.Name = "result_display";
            this.result_display.Size = new System.Drawing.Size(36, 27);
            this.result_display.TabIndex = 15;
            this.result_display.Text = "    ";
            // 
            // go_to_register
            // 
            this.go_to_register.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("go_to_register.BackgroundImage")));
            this.go_to_register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.go_to_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.go_to_register.Location = new System.Drawing.Point(520, 469);
            this.go_to_register.Name = "go_to_register";
            this.go_to_register.Size = new System.Drawing.Size(107, 26);
            this.go_to_register.TabIndex = 16;
            this.go_to_register.TabStop = false;
            this.go_to_register.Click += new System.EventHandler(this.Goto_register_Click);
            this.go_to_register.MouseEnter += new System.EventHandler(this.Go_to_register_MouseEnter);
            this.go_to_register.MouseLeave += new System.EventHandler(this.Go_to_register_MouseLeave);
            // 
            // save_user_name_box
            // 
            this.save_user_name_box.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save_user_name_box.BackgroundImage")));
            this.save_user_name_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save_user_name_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_user_name_box.Location = new System.Drawing.Point(310, 289);
            this.save_user_name_box.Name = "save_user_name_box";
            this.save_user_name_box.Size = new System.Drawing.Size(106, 28);
            this.save_user_name_box.TabIndex = 17;
            this.save_user_name_box.TabStop = false;
            this.save_user_name_box.Click += new System.EventHandler(this.Save_user_name_box_Click);
            // 
            // save_passwd_box
            // 
            this.save_passwd_box.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save_passwd_box.BackgroundImage")));
            this.save_passwd_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save_passwd_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_passwd_box.Location = new System.Drawing.Point(486, 289);
            this.save_passwd_box.Name = "save_passwd_box";
            this.save_passwd_box.Size = new System.Drawing.Size(106, 28);
            this.save_passwd_box.TabIndex = 18;
            this.save_passwd_box.TabStop = false;
            this.save_passwd_box.Click += new System.EventHandler(this.Save_passwd_box_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(612, 259);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 10);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Display_pwd_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 507);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.save_passwd_box);
            this.Controls.Add(this.save_user_name_box);
            this.Controls.Add(this.go_to_register);
            this.Controls.Add(this.result_display);
            this.Controls.Add(this.login);
            this.Controls.Add(this.user_head_box);
            this.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "命令管家";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignIn_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.user_head_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.go_to_register)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.save_user_name_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.save_passwd_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox user_head_box;
        private System.Windows.Forms.PictureBox login;
        private System.Windows.Forms.Label result_display;
        private System.Windows.Forms.PictureBox go_to_register;
        private System.Windows.Forms.PictureBox save_user_name;
        private System.Windows.Forms.PictureBox save_passwd;
        private System.Windows.Forms.PictureBox save_user_name_box;
        private System.Windows.Forms.PictureBox save_passwd_box;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}