using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.MainForm
{
    public partial class Load_links : Form
    {
		//点击音效
		SoundPlayer sound;
		//记录行标
		int rowIndex = 0;
		public Load_links(SoundPlayer click_sound)
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            MaximumSize = MinimumSize = Size;
			sound = click_sound;
			BackColor = Color.FromArgb(50,50,50);
        }

        private void Click_to_load_Click(object sender, EventArgs e)
        {
			sound.Play();
			OpenFileDialog select_images = new OpenFileDialog
			{
				AddExtension = true,
				AutoUpgradeEnabled = true,
				CheckFileExists = true,
				CheckPathExists = true,
				DefaultExt = ".png",
				DereferenceLinks = true,
				Filter = "图像文件|*.jpg;*.png;*.gif;*.jpeg;*.bmp",
				Multiselect = true,
				Title = "请选择一个或多个图像文件",
				RestoreDirectory = true,
				SupportMultiDottedExtensions = true,
				ShowHelp = true
			};

			if(select_images.ShowDialog() == DialogResult.OK)
            {
				sound.Play();
                foreach (string a_path in select_images.FileNames)
                {
					//文件路径显示
					Label path_display = new Label()
					{
						AutoSize = true,
						Text = Path.GetFileName(a_path),
						//设置Tag值为路径
						Tag = a_path,
						Anchor = AnchorStyles.Left,
						ForeColor = Color.FromArgb(255,255,255)
					};
					file_path_info.SetToolTip(path_display,a_path+"\r\n单击后删除该路径");
					extern_links_area.Controls.Add(path_display,0,rowIndex);
					//设置网址
					TextBox url_box = new TextBox()
					{
						Text = "",
						Anchor = AnchorStyles.Left,
						Height = 25
					};
					extern_links_area.Controls.Add(url_box,1,rowIndex);

					//图片描述
					TextBox image_description = new TextBox()
					{
						Text = "",
						Anchor = AnchorStyles.Left,
						Height = 25
					};
					extern_links_area.Controls.Add(image_description, 2,rowIndex);

					path_display.Click += (a, b) => {
						int row_index = extern_links_area.GetRow(path_display);
						extern_links_area.Controls.Remove(path_display);
						extern_links_area.Controls.Remove(url_box);

                        for (int i = row_index+1; i < (extern_links_area.RowStyles.Count-1); i++)
                        {
                            Label next_img = extern_links_area.GetControlFromPosition(0, i) as Label;
							extern_links_area.Controls.Remove(next_img);
                            extern_links_area.Controls.Add(next_img,0, i-1);
                            TextBox next_path = extern_links_area.GetControlFromPosition(1, i) as TextBox;
							extern_links_area.Controls.Remove(next_path);
                            extern_links_area.Controls.Add(next_path,1, i-1);
                                extern_links_area.RowStyles[i-1].Height = 25f;
                        }
						extern_links_area.RowCount--;
						extern_links_area.RowStyles.RemoveAt(rowIndex);
						rowIndex--;
					};

					extern_links_area.RowStyles.Add(new RowStyle(SizeType.Absolute,25f));
					++extern_links_area.RowCount;
					extern_links_area.RowStyles[rowIndex].Height = 25f;
					rowIndex++;
                }
            }
		}

        private void Load_links_FormClosing(object sender, FormClosingEventArgs e)
        {
			DialogResult = DialogResult.OK;
        }
    }
}
