using cbhk_editor.MainForm;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace cbhk_editor.TagSpawner
{
    public partial class tag_spawner : Form
    {
        Form parent = null;
        SoundPlayer click_sound = null;
        TreeView register = new TreeView();
        Image btn_img = Image.FromFile(Application.StartupPath+ "\\ButtonsBgImages\\button.png");
        public tag_spawner(Form this_obj,SoundPlayer click)
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            parent = this_obj;
            click_sound = click;
            register = Cbhk_form.register;
            click_to_return.Click += (a, b) =>
            {
                click_sound.Play();
                parent.WindowState = FormWindowState.Normal;
                parent.TopMost = true;
                parent.Show();
                parent.TopMost = false;
                Close();
            };
            InitUISettings();
        }

        private void InitUISettings()
        {
            BackColor = Color.FromArgb(50,50,50);
            id_tab.TabPages.Clear();
            Add_tag_title_menu_Click(null,null);
            id_tab.SelectedTab.BackColor = Color.FromArgb(50,50,50);
            foreach (ToolStripMenuItem item in tag_title_menu.Items)
            {
                item.BackgroundImage = btn_img;
                item.BackgroundImageLayout = ImageLayout.Stretch;
                item.ForeColor = Color.FromArgb(255,255,255);
                item.DropDownOpened += (a,b) => 
                {
                    item.ForeColor = Color.FromArgb(0,0,0);
                };
                item.DropDownClosed += (a,b) => 
                {
                    item.ForeColor = Color.FromArgb(255,255,255);
                };
                item.Click += ClickSound;
                foreach (ToolStripMenuItem subitem in item.DropDownItems)
                {
                    subitem.BackgroundImage = btn_img;
                    subitem.BackgroundImageLayout = ImageLayout.Stretch;
                    subitem.ForeColor = Color.FromArgb(255, 255, 255);
                    subitem.Click += ClickSound;
                }
            }
        }

        private void ClickSound(object sender,EventArgs e)
        {
            click_sound.Play();
        }

        private void Add_tag_title_menu_Click(object sender, EventArgs e)
        {
            Tag_page tag_Page = new Tag_page(register);
            tag_Page.id_tab.SelectedTab.BackColor = Color.FromArgb(50, 50, 50);
            tag_Page.id_tab.SelectedTab.Text = id_tab.TabPages.Count + 1 + "号标签文件";
            id_tab.TabPages.Add(tag_Page.id_tab.SelectedTab);
            id_tab.SelectedIndex++;
        }

        private void Remove_tag_title_menu_Click(object sender, EventArgs e)
        {
            id_tab.TabPages.Remove(id_tab.SelectedTab);
        }

        private void Clear_tag_title_menu_Click(object sender, EventArgs e)
        {
            id_tab.TabPages.Clear();
        }

        private void Add_tag_Click(object sender, EventArgs e)
        {
            Add_tag_title_menu_Click(null,null);
        }

        private void Delete_tag_Click(object sender, EventArgs e)
        {
            Remove_tag_title_menu_Click(null,null);
        }

        private void Clear_tag_Click(object sender, EventArgs e)
        {
            Clear_tag_title_menu_Click(null,null);
        }

        private void Click_to_spawn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog select_folder = new FolderBrowserDialog()
            {
                Description = "请选择标签生成路径",
                RootFolder = Environment.SpecialFolder.MyComputer,
                ShowNewFolderButton = true
            };
            if(select_folder.ShowDialog() == DialogResult.OK)
            {
                foreach (TabPage page in id_tab.TabPages)
                {
                    //获取文件名文本框的引用
                    TextBox file_name_box = page.Controls.Find("tag_file", true)[0] as TextBox;
                    //获取是否覆盖的勾选框
                    CheckBox Needreplace = page.Controls.Find("NeedReplace", true)[0] as CheckBox;
                    //获取ID列表引用
                    CheckedListBox id_list_box = page.Controls.Find("id_list_box", true)[0] as CheckedListBox;
                    //保存id集合
                    string IdString = "";
                    foreach (string item in id_list_box.CheckedItems)
                    {
                        IdString += "\""+item + "\",\r\n";
                    }
                    string result = "{\r\n\"replace\":" + Needreplace.Checked.ToString().ToLower() + ",\r\n\"values\":[\r\n" + IdString.TrimEnd(new char[] { '\r','\n',',' }) + "\r\n]}";
                    File.WriteAllText(select_folder.SelectedPath+"\\"+file_name_box.Text+".json",result,new UTF8Encoding(false));
                }
                Process.Start(select_folder.SelectedPath);
            }
        }

        private void About_tag_spawner_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本生成器生成的json文件提供给指令的选择器使用,功能是批量判断实体或方块");
        }
    }
}
