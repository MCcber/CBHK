using cbhk_editor.MainForm;
using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.slide_down_block
{
    public partial class slide_down_block_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        public slide_down_block_page()
        {
            InitializeComponent();
            set_player.Click += ClickSound;
            set_player.Click += SetInfo.SetPlayer;
            set_player.Click += UpdateInfo;

            block_id.TextChanged += UpdateInfo;

            TreeView Root = Cbhk_form.Blocks;
            foreach (TreeNode item in Root.Nodes)
            {
                block_id.Items.Add(item.Text);
                block_id.AutoCompleteCustomSource.Add(item.Text);
            }
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if (set_player.Tag != null)
            {
                table.Parent.Tag = "\"conditions\":{"+set_player.Tag.ToString()+(block_id.Text.Trim() != ""?",\"block\":\""+block_id.Text.Trim()+"\"":"")+"}";
            }
            else
                table.Parent.Tag = null;
        }

        private void ClickSound(object sender, EventArgs e)
        {
            click_sound.Play();
        }
    }
}
