using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.tool_forms
{
    public partial class enter_block_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");

        //保存方块数据
        string blockInfo = "";

        public enter_block_page()
        {
            InitializeComponent();

            set_player.Click += ClickSound;
            set_player.Click += SetInfo.SetPlayer;
            set_player.Click += UpdateInfo;
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if (set_player.Tag != null)
            {
                table.Parent.Tag = "\"conditions\":{"+set_player.Tag.ToString()+(blockInfo.Trim() != ""?","+blockInfo.TrimEnd(','):"")+"}";
            }
            else
                table.Parent.Tag = null;
        }

        private void ClickSound(object sender, EventArgs e)
        {
            click_sound.Play();
        }

        private void set_block_Click(object sender, EventArgs e)
        {
            block_form bf = new block_form();
            if (bf.ShowDialog() == DialogResult.OK && bf.Tag != null)
            {
                blockInfo = bf.Tag.ToString();
                blockInfo = blockInfo.Substring(1, blockInfo.Length - 3);
                blockInfo = blockInfo.Replace("\"condition\":\"minecraft:block_state_property\",", "").Replace("properties", "state") + ",";
            }
            else
                blockInfo = "";
            UpdateInfo(null,null);
        }
    }
}
