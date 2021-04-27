using System;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.function_components.SubComponents.set_stew_effect
{
    public partial class set_stew_effect_form : Form
    {
        public string result = "";
        public set_stew_effect_form()
        {
            InitializeComponent();

            add_Click(null,null);
        }

        private void set_stew_effect_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            #region 合并炖菜效果数据
            string effectInfo = "";
            foreach (TabPage item in set_stew_effect_tab.TabPages)
            {
                if(item.Tag != null)
                effectInfo += item.Tag.ToString();
            }
            if (effectInfo.Trim() != "")
                effectInfo = effectInfo.TrimEnd(',');
            #endregion

            #region 合并最终数据
            string setStewEffectInfo = "";
            if(effectInfo.Trim() != "")
            {
                setStewEffectInfo = "{\"function\":\"minecraft:set_stew_effect\",\"effects\":[" + effectInfo + "]},";
            }
            if (setStewEffectInfo.Trim() != "")
                result = setStewEffectInfo;
            else
                result = "";
            DialogResult = DialogResult.OK;
            #endregion
        }

        private void add_Click(object sender, EventArgs e)
        {
            set_stew_effect_page ssep = new set_stew_effect_page();
            set_stew_effect_tab.TabPages.Add(ssep.set_stew_effect_tab.SelectedTab);
            set_stew_effect_tab.SelectedIndex = set_stew_effect_tab.TabPages.Count - 1;
            set_stew_effect_tab.SelectedTab.Text = set_stew_effect_tab.TabPages.Count + "";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            set_stew_effect_tab.TabPages.RemoveAt(set_stew_effect_tab.SelectedIndex);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            set_stew_effect_tab.TabPages.Clear();
        }
    }
}
