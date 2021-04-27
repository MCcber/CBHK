using cbhk_editor.MainForm;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.condition_components.SubComponents.LocationCheck
{
    public partial class block_predicate_page : UserControl
    {
        TreeView Root = Cbhk_form.Blocks;
        string last_text = "";
        public block_predicate_page()
        {
            InitializeComponent();
            block_id.AutoCompleteMode = AutoCompleteMode.Suggest;
            block_id.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (TreeNode item in Root.Nodes)
            {
                block_id.Items.Add(item.Text);
                block_id.AutoCompleteCustomSource.Add(item.Text.Replace("minecraft:", ""));
            }
            block_id.SelectedIndexChanged += UpdateProperties;
            block_id.KeyDown += (a, b) =>
            {
                if (b.KeyCode == Keys.Enter)
                {
                    int item_index = block_id.FindString("minecraft:" + block_id.Text.Trim());
                    if (item_index != -1)
                        block_id.Text = block_id.Items[item_index].ToString();
                    UpdateInfo();
                }
            };
        }

        private void UpdateInfo()
        {
            string StateInfo = "";
            foreach (Control a_btn in block_state_area.Controls)
            {
                if (a_btn is Button && a_btn.Tag != null && a_btn.Tag.ToString().Trim() != "")
                    StateInfo += a_btn.Tag.ToString();
            }
            if (StateInfo.Trim() != "")
                StateInfo = "\"state\":{" + StateInfo.TrimEnd(',') + "}";

            string BlockIdInfo = block_id.Text.Trim() != "" ? "\"fluid\":\"" + block_id.Text.Trim() + "\"," : "";
            string BlockTagInfo = block_tag_box.Text.Trim() != "" ? "\"tag\":\"" + block_tag_box.Text.Trim() + "\"," : "";
            string BlockNbtInfo = set_nbt.Tag != null && set_nbt.Tag.ToString().Trim() != "" ?"\"nbt\":\""+set_nbt.Tag.ToString().Trim()+"\",":"";

            string BlockInfo = BlockIdInfo + BlockTagInfo + BlockNbtInfo + StateInfo;
            BlockInfo = BlockInfo.TrimEnd(',');

            if (block_id.Text.Trim() != "")
                block_id.Parent.Tag += "\"block\":{" + BlockInfo + "},";
        }

        private void UpdateProperties(object sender, EventArgs e)
        {
            ComboBox this_obj = sender as ComboBox;
            if (last_text != this_obj.Text)
            {
                block_state_area.Controls.Clear();
                last_text = this_obj.Text;
            }
            else
                return;
            foreach (TreeNode item in Root.Nodes)
            {
                if (item.Text.Contains(this_obj.Text.Trim()))
                    foreach (TreeNode property in item.Nodes)
                    {
                        if (property.Text == "properties")
                        {
                            foreach (TreeNode a_property in property.Nodes)
                            {
                                //获取属性列表
                                string[] property_list = a_property.Nodes[0].Text.Replace("[", "").Replace("]", "").Split(',');
                                for (int i = 0; i < property_list.Length; i++)
                                {
                                    property_list[i] = property_list[i].Replace("\"", "").Trim();
                                }

                                Button property_btn = new Button()
                                {
                                    Text = a_property.Text,
                                    Dock = DockStyle.Top
                                };
                                property_btn.Click += (c, d) =>
                                {
                                    ComboBox property_box = new ComboBox()
                                    {
                                        Location = property_btn.Location,
                                        Size = property_btn.Size,
                                        BackColor = Color.FromArgb(50, 50, 50),
                                        ForeColor = Color.White
                                    };
                                    property_box.KeyPress += (h, i) => { i.Handled = true; };
                                    property_box.Items.AddRange(property_list);
                                    property_box.KeyDown += (f, g) =>
                                    {
                                        if (g.KeyCode == Keys.Escape)
                                            block_state_area.Controls.Remove(property_box);
                                        if (g.KeyCode == Keys.Enter)
                                        {
                                            property_btn.Tag = "\"" + property_btn.Text + "\":" + property_box.Text + ",";
                                            block_state_area.Controls.Remove(property_box);
                                            UpdateInfo();
                                        }
                                    };
                                    block_state_area.Controls.Add(property_box);
                                    property_box.BringToFront();
                                };
                                block_state_area.Controls.Add(property_btn);
                            }
                        }
                    }
            }
        }
    }
}
