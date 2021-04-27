using System;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.function_components.SubComponents.set_attributes
{
    public partial class set_attributes_form : Form
    {
        public string result = "";
        public set_attributes_form()
        {
            InitializeComponent();
            add_Click(null,null);
        }

        private void add_Click(object sender, EventArgs e)
        {
            attribute_page ap = new attribute_page();
            attribute_tab.TabPages.Add(ap.attribute_tab.SelectedTab);
            attribute_tab.SelectedIndex = attribute_tab.TabPages.Count - 1;
            attribute_tab.SelectedTab.Text = attribute_tab.TabPages.Count+"";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            attribute_tab.TabPages.RemoveAt(attribute_tab.SelectedIndex);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            attribute_tab.TabPages.Clear();
        }

        private void set_attributes_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            result = "{\"function\":\"minecraft:set_attributes\",\"modifiers\":[";
            foreach (TabPage page in attribute_tab.TabPages)
            {
                if (page.Tag != null)
                    result += page.Tag.ToString();
            }
            result = result.TrimEnd(',')+"]},";
            DialogResult = DialogResult.OK;
        }
    }
}
