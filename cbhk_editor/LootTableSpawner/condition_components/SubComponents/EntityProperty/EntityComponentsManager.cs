using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.condition_components.SubComponents
{
    class EntityComponentsManager
    {
        public void add_effect(TableLayoutPanel table)
        {
            TabControl effect_tab = table.Controls.Find("effect_tab", true)[0] as TabControl;
            effect_page ep = new effect_page();
            effect_tab.TabPages.Add(ep.effect_tab.SelectedTab);
            effect_tab.SelectedIndex = effect_tab.TabPages.Count - 1;
            effect_tab.SelectedTab.Text = effect_tab.TabPages.Count+"";
        }

        public void delete_effect(TableLayoutPanel table)
        {
            TabControl effect_tab = table.Controls.Find("effect_tab", true)[0] as TabControl;
            for (int i = effect_tab.SelectedIndex+1; i < effect_tab.TabPages.Count; i++)
            {
                effect_tab.TabPages[i].Text = i +"";
            }
            effect_tab.TabPages.RemoveAt(effect_tab.SelectedIndex);
        }

        public void clear_effect(TableLayoutPanel table)
        {
            TabControl effect_tab = table.Controls.Find("effect_tab", true)[0] as TabControl;
            effect_tab.TabPages.Clear();
        }

        public void add_adv(TableLayoutPanel table)
        {
            TabControl adv_tab = table.Controls.Find("adv_tab", true)[0] as TabControl;
            adv_page ap = new adv_page();
            adv_tab.TabPages.Add(ap.adv_tab.SelectedTab);
            adv_tab.SelectedIndex = adv_tab.TabPages.Count - 1;
            adv_tab.SelectedTab.Text = adv_tab.TabPages.Count + "";
        }

        public void delete_adv(TableLayoutPanel table)
        {
            TabControl adv_tab = table.Controls.Find("adv_tab", true)[0] as TabControl;
            for (int i = adv_tab.SelectedIndex + 1; i < adv_tab.TabPages.Count; i++)
            {
                adv_tab.TabPages[i].Text = i + "";
            }
            adv_tab.TabPages.RemoveAt(adv_tab.SelectedIndex);
        }

        public void clear_adv(TableLayoutPanel table)
        {
            TabControl adv_tab = table.Controls.Find("adv_tab", true)[0] as TabControl;
            adv_tab.TabPages.Clear();
        }

        public void add_stats(TableLayoutPanel table)
        {
            TabControl stats_tab = table.Controls.Find("stats_tab", true)[0] as TabControl;
            stats_page sp = new stats_page();
            stats_tab.TabPages.Add(sp.stats_tab.SelectedTab);
            stats_tab.SelectedIndex = stats_tab.TabPages.Count - 1;
            stats_tab.SelectedTab.Text = stats_tab.TabPages.Count + "";
        }

        public void delete_stats(TableLayoutPanel table)
        {
            TabControl stats_tab = table.Controls.Find("stats_tab", true)[0] as TabControl;
            for (int i = stats_tab.SelectedIndex + 1; i < stats_tab.TabPages.Count; i++)
            {
                stats_tab.TabPages[i].Text = i + "";
            }
            stats_tab.TabPages.RemoveAt(stats_tab.SelectedIndex);
        }

        public void clear_stats(TableLayoutPanel table)
        {
            TabControl stats_tab = table.Controls.Find("stats_tab", true)[0] as TabControl;
            stats_tab.TabPages.Clear();
        }
    }
}
