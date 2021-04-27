using System.Windows.Forms;

namespace cbhk_editor.ItemSpawner
{
    class ItemModifyManager
    {
        public void add_item(TabControl tab)
        {
            item_component item = new item_component();
            tab.TabPages.Add(item.item_tab.SelectedTab);
            tab.SelectedIndex++;
            tab.SelectedTab.Text = "第"+tab.TabPages.Count+"个物品";
        }
        public void delete_item(TabControl tab)
        {
            tab.TabPages.RemoveAt(tab.SelectedIndex);
        }
        public void clear_item(TabControl tab)
        {
            tab.TabPages.Clear();
        }
        public void add_enchantment(TabControl tab)
        {
            enchantment_component enchant = new enchantment_component();
            TabControl enchantment_tab = tab.SelectedTab.Controls.Find("item_enchantment_tab", true)[0] as TabControl;
            enchantment_tab.TabPages.Add(enchant.item_enchantment_tab.SelectedTab);
            enchantment_tab.SelectedIndex++;
            enchantment_tab.SelectedTab.Text = "第"+enchantment_tab.TabPages.Count+"个附魔";
        }
        public void delete_enchantment(TabControl tab)
        {
            TabControl enchantment_tab = tab.SelectedTab.Controls.Find("item_enchantment_tab", true)[0] as TabControl;
            enchantment_tab.TabPages.RemoveAt(enchantment_tab.SelectedIndex);
        }
        public void clear_enchantment(TabControl tab)
        {
            TabControl enchantment_tab = tab.SelectedTab.Controls.Find("item_enchantment_tab", true)[0] as TabControl;
            enchantment_tab.TabPages.Clear();
        }
        public void add_attribute(TabControl tab)
        {
            attribute_component attri = new attribute_component();
            TabControl attribute_tab = tab.SelectedTab.Controls.Find("item_attribute_tab", true)[0] as TabControl;
            attribute_tab.TabPages.Add(attri.item_attribute_tab.SelectedTab);
            attribute_tab.SelectedIndex++;
            attribute_tab.SelectedTab.Text = "第"+ attribute_tab.TabPages.Count+"个属性";
        }
        public void delete_attribute(TabControl tab)
        {
            TabControl attribute_tab = tab.SelectedTab.Controls.Find("item_attribute_tab", true)[0] as TabControl;
            attribute_tab.TabPages.RemoveAt(attribute_tab.SelectedIndex);
        }
        public void clear_attribute(TabControl tab)
        {
            TabControl attribute_tab = tab.SelectedTab.Controls.Find("item_attribute_tab", true)[0] as TabControl;
            attribute_tab.TabPages.Clear();
        }
        public void add_potion(TabControl tab)
        {
            potion_component potion = new potion_component();
            TabControl potion_tab = tab.SelectedTab.Controls.Find("item_potion_tab", true)[0] as TabControl;
            potion_tab.TabPages.Add(potion.item_potion_tab.SelectedTab);
            potion_tab.SelectedIndex++;
            potion_tab.SelectedTab.Text = "第"+potion_tab.TabPages.Count+"个药水效果";
        }
        public void delete_potion(TabControl tab)
        {
            TabControl potion_tab = tab.SelectedTab.Controls.Find("item_potion_tab", true)[0] as TabControl;
            potion_tab.TabPages.RemoveAt(potion_tab.SelectedIndex);
        }
        public void clear_potion(TabControl tab)
        {
            TabControl potion_tab = tab.SelectedTab.Controls.Find("item_potion_tab", true)[0] as TabControl;
            potion_tab.TabPages.Clear();
        }
    }
}
