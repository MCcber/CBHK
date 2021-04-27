using System.Windows.Forms;

namespace cbhk_editor.EntitySpawner
{
    class EntityModifyManager
    {
        public void add_entity(TabControl tab, TreeView root)
        {
            entity_page entitypage = new entity_page(root);
            tab.TabPages.Add(entitypage.entity_tab.SelectedTab);
            tab.SelectedIndex = tab.TabPages.Count - 1;
            tab.SelectedTab.Text = "第"+tab.TabPages.Count+"个";
        }

        public void delete_entity(TabControl tab, TreeView root)
        {
            tab.TabPages.RemoveAt(tab.SelectedIndex);
        }

        public void clear_entity(TabControl tab, TreeView root)
        {
            tab.TabPages.Clear();
        }

        public void add_potion(TabControl tab,TreeView root)
        {
            entity_potion entitypotion = new entity_potion(root);
            TabControl entity_potion_tab = tab.SelectedTab.Controls.Find("effect_tab", true)[0] as TabControl;
            entity_potion_tab.TabPages.Add(entitypotion.effect_tab.SelectedTab);

            entity_potion_tab.SelectedIndex = entity_potion_tab.TabPages.Count - 1;
            entity_potion_tab.SelectedTab.Text = "第" + entity_potion_tab.TabPages.Count + "个";
        }

        public void delete_potion(TabControl tab, TreeView root)
        {
            TabControl entity_potion_tab = tab.SelectedTab.Controls.Find("effect_tab", true)[0] as TabControl;
            entity_potion_tab.TabPages.RemoveAt(entity_potion_tab.SelectedIndex);
        }

        public void clear_potion(TabControl tab, TreeView root)
        {
            TabControl entity_potion_tab = tab.SelectedTab.Controls.Find("effect_tab", true)[0] as TabControl;
            entity_potion_tab.TabPages.Clear();
        }

        public void add_passenger(TabControl tab, TreeView root)
        {
            passenger_page passengerpage = new passenger_page { };
            TabControl passengerTab = tab.SelectedTab.Controls.Find("passengerTab", true)[0] as TabControl;
            passengerTab.TabPages.Add(passengerpage.passengerTab.SelectedTab);

            passengerTab.SelectedIndex = passengerTab.TabPages.Count - 1;
            passengerTab.SelectedTab.Text = "第" + passengerTab.TabPages.Count + "个";
        }

        public void delete_passenger(TabControl tab, TreeView root)
        {
            TabControl passengerTab = tab.SelectedTab.Controls.Find("passengerTab", true)[0] as TabControl;
            passengerTab.TabPages.RemoveAt(passengerTab.SelectedIndex);
        }

        public void clear_passenger(TabControl tab, TreeView root)
        {
            TabControl passengerTab = tab.SelectedTab.Controls.Find("passengerTab", true)[0] as TabControl;
            passengerTab.TabPages.Clear();
        }
    }
}
