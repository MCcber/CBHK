using cbhk_editor.MainForm;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.condition_components.SubComponents.LocationCheck
{
    public partial class fluid_predicate_page : UserControl
    {
        TreeView Root = Cbhk_form.Blocks;
        string last_text = "";
        public fluid_predicate_page()
        {
            InitializeComponent();
            fluid_id.AutoCompleteMode = AutoCompleteMode.Suggest;
            fluid_id.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (TreeNode item in Root.Nodes)
            {
                if(item.Text == "minecraft:water" || item.Text == "minecraft:lava")
                {
                    fluid_id.Items.Add(item.Text);
                    fluid_id.AutoCompleteCustomSource.Add(item.Text.Replace("minecraft:",""));
                }
            }
            fluid_id.SelectedIndexChanged += UpdateProperties;
            fluid_id.KeyDown += (a,b) => 
            {
                if(b.KeyCode == Keys.Enter)
                {
                    int item_index = fluid_id.FindString("minecraft:" + fluid_id.Text.Trim());
                    if (item_index != -1)
                        fluid_id.Text = fluid_id.Items[item_index].ToString();
                    UpdateInfo();
                }
            };
        }

        private void UpdateInfo()
        {
            string StateInfo = "";
            foreach (Control a_btn in fluid_state_area.Controls)
            {
                if (a_btn is Button)
                    StateInfo += a_btn.Tag.ToString();
            }
            if (StateInfo.Trim() != "")
                StateInfo = "\"state\":{" + StateInfo.TrimEnd(',') + "},";

            string blockIdInfo = fluid_id.Text.Trim() != "" ? "\"fluid\":\"" + fluid_id.Text.Trim() + "\"," : "";
            string blockTagInfo = fluid_tag_box.Text.Trim() != "" ? "\"tag\":\"" + fluid_tag_box.Text.Trim() + "\"," : "";

            string FluidInfo = blockIdInfo + blockTagInfo + StateInfo;
            FluidInfo = FluidInfo.TrimEnd(',');

            if (FluidInfo != "")
                fluid_id.Parent.Tag += "\"fluid\":{" + FluidInfo + "},";
        }

        private void UpdateProperties(object sender,EventArgs e)
        {
            ComboBox this_obj = sender as ComboBox;
            if (last_text != this_obj.Text)
            {
                fluid_state_area.Controls.Clear();
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
                                    property_list[i] = property_list[i].Replace("\"","").Trim();
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
                                            fluid_state_area.Controls.Remove(property_box);
                                        if (g.KeyCode == Keys.Enter)
                                        {
                                            property_btn.Tag = "\"" + property_btn.Text + "\":" + property_box.Text + ",";
                                            fluid_state_area.Controls.Remove(property_box);
                                            UpdateInfo();
                                        }
                                    };
                                    fluid_state_area.Controls.Add(property_box);
                                    property_box.BringToFront();
                                };
                                fluid_state_area.Controls.Add(property_btn);
                            }
                        }
                    }
            }
        }
    }
}
