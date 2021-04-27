using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.effects_changed
{
    public partial class effects_changed_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        //保存药水效果信息
        string EffectInfo = "";
        public effects_changed_page()
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
                string result = set_player.Tag.ToString()+(EffectInfo.Trim() != ""?","+EffectInfo:"");
                table.Parent.Tag = "\"conditions\":{"+result+"}";
            }
            else
                table.Parent.Tag = null;
        }

        private void ClickSound(object sender, EventArgs e)
        {
            click_sound.Play();
        }

        private void set_effect_Click(object sender, EventArgs e)
        {
            ClickSound(null,null);
            effect_form ef = new effect_form();
            if(ef.ShowDialog() == DialogResult.OK)
            {
                if (ef.result.Trim() != "")
                    EffectInfo = ef.result;
            }
            UpdateInfo(null,null);
        }
    }
}
