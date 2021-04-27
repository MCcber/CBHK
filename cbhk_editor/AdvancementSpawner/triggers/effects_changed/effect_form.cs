using cbhk_editor.LootTableSpawner.condition_components.SubComponents;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.effects_changed
{
    public partial class effect_form : Form
    {
        //保存最终结果
        public string result = "";
        public effect_form()
        {
            InitializeComponent();
            add_Click(null,null);
        }

        private void add_Click(object sender, System.EventArgs e)
        {
            effect_page ep = new effect_page();
            effect_tab.TabPages.Add(ep.effect_tab.SelectedTab);
            effect_tab.SelectedTab.Text = effect_tab.TabPages.Count+1+"";
        }

        private void delete_Click(object sender, System.EventArgs e)
        {
            for (int i = effect_tab.SelectedIndex+1; i < effect_tab.TabPages.Count; i++)
            {
                effect_tab.TabPages[i].Text = i+"";
            }
            effect_tab.TabPages.RemoveAt(effect_tab.SelectedIndex);
        }

        private void clear_Click(object sender, System.EventArgs e)
        {
            effect_tab.TabPages.Clear();
        }

        private void effect_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            result = "";
            foreach (TabPage item in effect_tab.TabPages)
            {
                if(item.Tag != null)
                result += item.Tag.ToString();
            }
            if(result.Trim() != "")
            {
                result = "effects:["+result.TrimEnd(',')+"]";
                DialogResult = DialogResult.OK;
            }
        }
    }
}
