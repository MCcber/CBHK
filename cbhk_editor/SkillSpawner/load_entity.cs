using cbhk_editor.EntitySpawner;
using cbhk_editor.MainForm;
using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.SkillSpawner
{
    class Load_entity
    {
        public static string EntityType { get; set; }
        public static string NBT { get; set; }
        public static void Modify(object sender,EventArgs e)
        {
            Control this_obj = sender as Control;
            SoundPlayer soundPlayer = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
            TreeView Root = Cbhk_form.register;
            entity_spawner es = new entity_spawner(null,soundPlayer,true);
            if(es.ShowDialog() == DialogResult.OK)
            {
                NBT = es.EntityNBT[0];
                EntityType = es.EntityId[0];
                if (NBT.Trim() != "")
                    this_obj.Tag = NBT;
                else
                    this_obj.Tag = null;
                if (EntityType.Trim() != "")
                    this_obj.Name = EntityType.Replace(":",".");
            }
        }
    }
}
