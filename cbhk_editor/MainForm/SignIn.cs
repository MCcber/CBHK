using cbhk_editor.ToolClasses;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Windows.Forms;

namespace cbhk_editor.MainForm
{
    public partial class SignIn : Form
    {
		//用户名
		public string user_name_string = "";
		//用户头像
		public Image user_head;
		//用户id
		public string user_id = "";
        //音效对象
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
		//登录结果
		bool through = false;
        ////用户名称
        TextBoxTransparent user_name = new TextBoxTransparent() {BackAlpha = 0, Cursor = Cursors.IBeam,Location = new Point(304, 185),BorderStyle = BorderStyle.None,Size = new Size(297, 25),ForeColor = Color.FromArgb(168, 168, 168) };
        //401, 222
        //393, 30
        ////用户密码
        TextBoxTransparent password = new TextBoxTransparent() {BackAlpha = 0, Cursor = Cursors.IBeam, Location = new Point(304, 253), BorderStyle = BorderStyle.None, Size = new Size(297, 25), ForeColor = Color.FromArgb(168, 168, 168) };
        //point:400, 307
        //size:393, 30
        //记住账号
        bool SaveUserName = false;
        //记住密码
        bool SavePasswd = false;

        //记住账号1
        Image save_user_name1 = Image.FromFile(Application.StartupPath+ "\\LoginFormBgImages\\user_name1.png");
		//记住账号2
		Image save_user_name2 = Image.FromFile(Application.StartupPath + "\\LoginFormBgImages\\user_name2.png");
		//记住密码1
		Image save_passwd1 = Image.FromFile(Application.StartupPath + "\\LoginFormBgImages\\passwd1.png");
		//记住密码2
		Image save_passwd2 = Image.FromFile(Application.StartupPath + "\\LoginFormBgImages\\passwd2.png");
		//忘记密码1
		Image go_to_register1 = Image.FromFile(Application.StartupPath + "\\LoginFormBgImages\\forgot_passwd1.png");
		//忘记密码2
		Image go_to_register2 = Image.FromFile(Application.StartupPath + "\\LoginFormBgImages\\forgot_passwd2.png");
		//登录1
		Image GoToRegister1 = Image.FromFile(Application.StartupPath + "\\LoginFormBgImages\\login_btn1.png");
		//登录2
		Image GoToRegister2 = Image.FromFile(Application.StartupPath + "\\LoginFormBgImages\\login_btn2.png");
		//显示密码1
		Image ShowPasswd1 = Image.FromFile(Application.StartupPath+ "\\LoginFormBgImages\\eye1.png");
		//显示密码2
		Image ShowPasswd2 = Image.FromFile(Application.StartupPath + "\\LoginFormBgImages\\eye2.png");

		public SignIn()
		{
			InitializeComponent();
			//初始化UI
			InitUISettings();
		}

		private void InitUISettings()
        {
			Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
			user_name.Font = password.Font = Font;
			password.UseSystemPasswordChar = true;
			user_name.KeyDown += User_name_KeyDown;
			password.KeyDown += Password_KeyDown;
			Controls.Add(user_name);
			Controls.Add(password);
			if (File.Exists(Application.StartupPath + "\\Settings\\user_info.ini"))
			{
				result_display.ForeColor = Color.FromArgb(168, 168, 168);
				string[] user_info = File.ReadAllLines(Application.StartupPath + "\\Settings\\user_info.ini", new UTF8Encoding(false));
				if (user_info.Length == 1)
				{
					SaveUserName = true;
					save_user_name_box.BackgroundImage = save_user_name2;
					user_name.Text = user_info[0];
					password.Select(password.Text.Length, 0);
				}
				if (user_info.Length > 1)
				{
					SaveUserName = true;
					SavePasswd = true;
					save_user_name_box.BackgroundImage = save_user_name2;
					save_passwd_box.BackgroundImage = save_passwd2;
					password.Text = user_info[1];
					user_name.Text = user_info[0];
					password.Select(password.Text.Length, 0);
				}
				password.Focus();
			}
		}

        private void Goto_register_Click(object sender, EventArgs e)
        {
            Process.Start("https://mc.metamo.cn/u/register/");
        }

        private void Display_pwd_Click(object sender, EventArgs e)
        {
            PictureBox this_obj = sender as PictureBox;
			password.UseSystemPasswordChar = !password.UseSystemPasswordChar;
			if (password.UseSystemPasswordChar)
				this_obj.BackgroundImage = ShowPasswd2;
			else
				this_obj.BackgroundImage = ShowPasswd1;
        }

        private void SignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
			if (!through)
            {
				DialogResult = DialogResult.Cancel;
			}
			else
            {
				DialogResult = DialogResult.OK;
			}
        }

        private void Login_Click(object sender, EventArgs e)
        {
            click_sound.Play();
            if(user_name.Text.Trim()=="")
            {
                result_display.Text = "祖安提示:没号!";
                return;
            }
            if(password.Text.Trim() == "")
            {
                result_display.Text = "祖安提示:没码!";
                return;
            }
            result_display.Text = "登录中...";
            //不转义密码
            string passwd_string = Regex.Escape(password.Text);

			#region 保存账号和密码
			if(SavePasswd && SaveUserName)
            {
				string user_info = "";
				if (SaveUserName)
					user_info += user_name.Text + "\r\n";
				if (SavePasswd)
					user_info += Regex.Escape(password.Text) + "\r\n";
				File.WriteAllText(Application.StartupPath + "\\Settings\\user_info.ini", user_info);
			}
			#endregion

            #region 进行登录
            JObject result = new JObject();
			try
			{
				result = JsonConvert.DeserializeObject(login_tool.SendDataByGet("https://mc.metamo.cn/php/user/info-extra.php", "act=login&key=TkcyT2EpzbcmiQF5WE&acc="+ user_name.Text + "&pwd="+ Regex.Match(passwd_string, "(.*)").ToString())) as JObject;
			}
			catch
			{
				Process tls_process = new Process();
				tls_process.StartInfo.FileName = "cmd.exe";
				tls_process.StartInfo.UseShellExecute = false;
				tls_process.StartInfo.RedirectStandardInput = true;
				tls_process.StartInfo.RedirectStandardOutput = true;
				tls_process.StartInfo.RedirectStandardError = true;
				tls_process.StartInfo.CreateNoWindow = true;
				tls_process.Start();
				tls_process.StandardInput.WriteLine("REG ADD HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings /v SecureProtocols /t REG_DWORD /d 2720 /f&exit");
				tls_process.StandardInput.AutoFlush = true;
				login.Enabled = false;
				result_display.Text = "正在校准注册表...";
				tls_process.WaitForExit();
				login.Enabled = true;
				tls_process.Close();
			}
			try
			{
				string state = result["code"].ToString().Trim();
				if (state == "200")
				{
					user_name_string = result["name"].ToString();
					user_id = result["id"].ToString();
					string head_frame_url = Regex.Unescape(result["avatar"].ToString()).Contains("https") ? Regex.Unescape(result["avatar"].ToString()) : "";
					if (head_frame_url.Trim() != "")
                    {
						login_tool.DownLoadUserHead(head_frame_url, Application.StartupPath + "\\UserHeadImages\\user_head.png");
						if(File.Exists(Application.StartupPath+ "\\UserHeadImages\\user_head.png"))
							user_head = user_head_box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\UserHeadImages\\user_head.png");
					}

					if (result["CBHK"].ToString() == "1")
					{
						result_display.Text = "启动成功!欢迎" + result["name"].ToString();
                        Application.DoEvents();
                        Thread.Sleep(1000);
						through = true;
						Close();
					}
					else
					{
						result_display.Text = "您还未解锁命令管家!启动失败!";
						Application.DoEvents();
						Thread.Sleep(1000);
					}
				}
				else
				{
					result_display.Text = result["msg"].ToString();
					Application.DoEvents();
				}
			}
			catch (Exception a)
			{
				result_display.Text = a.Message;
				Application.DoEvents();
			}
            #endregion
        }

        private void User_name_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            Login_Click(null, null);
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Login_Click(null, null);
        }

        private void User_head_box_Paint(object sender, PaintEventArgs e)
        {
			PictureBox pb = sender as PictureBox;
			GraphicsPath gp = new GraphicsPath();
			gp.AddEllipse(pb.ClientRectangle);
			Pen pen = new Pen(Color.Transparent, 1f);
			e.Graphics.DrawPath(pen, gp);
			Region region = new Region(gp);
			pb.Region = region;
			gp.Dispose();
			region.Dispose();
		}

        private void Go_to_register_MouseEnter(object sender, EventArgs e)
        {
			PictureBox this_obj = sender as PictureBox;
			this_obj.BackgroundImage = go_to_register2;
        }

		private void Go_to_register_MouseLeave(object sender, EventArgs e)
		{
			PictureBox this_obj = sender as PictureBox;
			this_obj.BackgroundImage = go_to_register1;
		}

		private void Login_MouseEnter(object sender, EventArgs e)
        {
			PictureBox this_obj = sender as PictureBox;
			this_obj.BackgroundImage = GoToRegister2;
		}

        private void Login_MouseLeave(object sender, EventArgs e)
        {
			PictureBox this_obj = sender as PictureBox;
			this_obj.BackgroundImage = GoToRegister1;
		}

        private void Save_user_name_box_Click(object sender, EventArgs e)
        {
			PictureBox this_obj = sender as PictureBox;
			SaveUserName = !SaveUserName;
			if (SaveUserName)
				this_obj.BackgroundImage = save_user_name2;
			else
				this_obj.BackgroundImage = save_user_name1;
		}

        private void Save_passwd_box_Click(object sender, EventArgs e)
        {
			PictureBox this_obj = sender as PictureBox;
			SavePasswd = !SavePasswd;
			if (SavePasswd)
				this_obj.BackgroundImage = save_passwd2;
			else
				this_obj.BackgroundImage = save_passwd1;
		}

		//控制窗体随鼠标移动
		protected override void WndProc(ref Message m)
		{
			switch (m.Msg)
			{
				case 0x0201://鼠标左键按下的消息
					m.Msg = 0x00A1;//更改消息为非客户区按下鼠标
					m.LParam = IntPtr.Zero;//默认值
					m.WParam = new IntPtr(2);//鼠标放在标题栏内
					break;
			}
			base.WndProc(ref m);
		}
    }
}
