using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.MainForm
{
    public partial class individualization : Form
    {
        Font current_font;
        public Font target_font;
        SoundPlayer sound;
        public List<string> musics = new List<string> { };
        //保存图片路径
        public List<string> ImageLinksPathes = new List<string> { };
        //保存图片描述
        public List<string> ImageLinksDescription = new List<string> { };
        //保存链接
        public List<string> UrlInfo = new List<string> { };
        //清空链接
        public bool ClearLinks = false;
        public individualization(Font main_font,SoundPlayer click_sound,int SelectedIndex)
        {
            InitializeComponent();
            cbhk_visible.SelectedIndex = 0;
            diy_info.ForeColor = Color.FromArgb(168, 168, 168);
            
            diy_info.GotFocus += (a,b) => {
                TextBox this_obj = a as TextBox;
                if(this_obj.ForeColor == Color.FromArgb(168, 168, 168))
                {
                    this_obj.Text = "";
                    this_obj.ForeColor = Color.FromArgb(0, 0, 0);
                }
            };
            diy_info.LostFocus += (a,b) => {
                TextBox this_obj = a as TextBox;
                if(this_obj.Text.Trim()=="")
                {
                    this_obj.Text = "自定义标题信息(文本)";
                    this_obj.ForeColor = Color.FromArgb(168, 168, 168);
                }
            };
            
            setting_tips.SetToolTip(cbhk_visible,"启动器可见性:\r\n0:生成器启动后保持不变\r\n1:生成器启动后最小化\r\n2:生成器启动后最小化至托盘");
            indiviTabControl.SelectedIndex = SelectedIndex;
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            current_font = main_font;
            sound = click_sound;
            MaximumSize = MinimumSize = Size;
        }

        private void IndiviTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tc = sender as TabControl;
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(155,50, 50, 50)),0,0,Width,Height);
            foreach (TabPage item in tc.TabPages)
            {
                item.BackColor = Color.FromArgb(50,50,50);
            }
            if(e.Index == 0)
            e.Graphics.DrawString("个性化",Font,new SolidBrush(Color.FromArgb(255,255,255)),new PointF(2,4));
            if (e.Index == 1)
                e.Graphics.DrawString("启动项", Font, new SolidBrush(Color.FromArgb(255, 255, 255)), new PointF(tc.ItemSize.Width+2, 4));
        }

        private void Individualization_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void Load_link_Click(object sender, System.EventArgs e)
        {
            sound.Play();
            Load_links loadLinks = new Load_links(sound);
            if(loadLinks.ShowDialog() == DialogResult.OK)
            {
                TableLayoutPanel source = loadLinks.extern_links_area;
                ImageLinksPathes.Clear();
                UrlInfo.Clear();
                ImageLinksDescription.Clear();
                for (int i = 0; i < (source.RowCount-1); i++)
                {
                    Label a_image = source.GetControlFromPosition(0,i) as Label;
                    ImageLinksPathes.Add(a_image.Tag.ToString());
                    TextBox url_info = source.GetControlFromPosition(1,i) as TextBox;
                    UrlInfo.Add(url_info.Text);
                    TextBox description = source.GetControlFromPosition(2,i) as TextBox;
                    ImageLinksDescription.Add(description.Text);
                }
            }
        }

        private void Load_font_Click(object sender, System.EventArgs e)
        {
            sound.Play();
            FontDialog mc_font = new FontDialog
            {
                Color = ForeColor,
                FixedPitchOnly = false,
                ShowApply = true,
                ShowEffects = true,
                ShowHelp = false,
                ShowColor = false,
                MaxSize = 100
            };
            if (mc_font.ShowDialog() == DialogResult.OK)
            {
                target_font = mc_font.Font;
                Button this_obj = sender as Button;
                this_obj.Tag = "true";
            }
        }

        private void Reset_font_Click(object sender, System.EventArgs e)
        {
            sound.Play();
            target_font = current_font;
        }

        private void Set_music_Click(object sender, System.EventArgs e)
        {
            sound.Play();
            OpenFileDialog select_musics = new OpenFileDialog
            {
                AddExtension = true,
                AutoUpgradeEnabled = true,
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = ".wav",
                DereferenceLinks = true,
                Filter = "音频文件|*.wav",
                //Multiselect = true,
                Title = "请选择一个音频文件",
                RestoreDirectory = true,
                SupportMultiDottedExtensions = true,
                ShowHelp = true
            };
            if(select_musics.ShowDialog() == DialogResult.OK)
            {
                set_music.Tag = select_musics.FileName;
            }
        }

        private void Clear_music_Click(object sender, System.EventArgs e)
        {
            sound.Play();
            set_music.Tag = null;
        }

        private void Clear_links_Click(object sender, System.EventArgs e)
        {
            if(MessageBox.Show("确定清空链接?","提示",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ClearLinks = true;
                Directory.Delete(Application.StartupPath+ "\\UrlLinks");
                Directory.CreateDirectory(Application.StartupPath + "\\UrlLinks");
            }
        }
    }
}
