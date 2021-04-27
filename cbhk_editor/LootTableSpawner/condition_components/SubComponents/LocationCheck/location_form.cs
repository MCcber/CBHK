using cbhk_editor.LootTableSpawner.condition_components.SubComponents.LocationCheck;
using cbhk_editor.MainForm;
using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.condition_components.SubComponents
{
    public partial class location_form : Form
    {
        SoundPlayer soundPlayer = new SoundPlayer(Application.StartupPath+ "\\MainFormClickSounds\\button_click.wav");
        Image btn_img = Image.FromFile(Application.StartupPath + "\\ButtonsBgImages\\button.png");
        //保存最终结果
        public string result = "";
        public location_form()
        {
            InitializeComponent();
            MaximumSize = Size;
            InitUISettings();
        }

        private void SetButtonTag(object sender,EventArgs e)
        {
            Button this_obj = sender as Button;
            string rangeInfo = "";
            string min_value = this_obj.Name.Contains("light") && min_value_box.Text.Contains(".") ? min_value_box.Text.Split('.')[0] : min_value_box.Text.Trim();
            string max_value = this_obj.Name.Contains("light") && max_value_box.Text.Contains(".") ? max_value_box.Text.Split('.')[0] : max_value_box.Text.Trim();
            if (min_value_box.Text.Trim() != "" && max_value_box.Text.Trim() != "")
                rangeInfo = "{\"min\":" + min_value + ",\"max\":" + max_value + "},";
            else
                if (min_value_box.Text.Trim() != "")
                rangeInfo = min_value + ",";
            else
                if (max_value_box.Text.Trim() != "")
                rangeInfo = max_value + ",";
            if(rangeInfo != "")
            this_obj.Tag = "\"" + this_obj.Name.Split('_')[1] + "\":" + rangeInfo;
        }

        private void InitUISettings()
        {
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            add_block_Click(null,null);
            add_fluid_Click(null,null);
            set_x.Click += SetButtonTag;
            set_y.Click += SetButtonTag;
            set_z.Click += SetButtonTag;
            set_light.Click += SetButtonTag;
            foreach (ToolStripMenuItem item in location_title_menu.Items)
            {
                item.ForeColor = Color.White;
                item.BackColor = Color.FromArgb(50,50,50);
                item.BackgroundImage = btn_img;
                item.BackgroundImageLayout = ImageLayout.Stretch;
                item.Click += ClickSound;
                foreach (ToolStripMenuItem subitem in item.DropDownItems)
                {
                    subitem.ForeColor = Color.White;
                    subitem.BackColor = Color.FromArgb(50, 50, 50);
                    subitem.BackgroundImage = btn_img;
                    subitem.BackgroundImageLayout = ImageLayout.Stretch;
                    subitem.Click += ClickSound;
                    foreach (ToolStripMenuItem subsubitem in subitem.DropDownItems)
                    {
                        subsubitem.ForeColor = Color.White;
                        subsubitem.BackColor = Color.FromArgb(50, 50, 50);
                        subsubitem.BackgroundImage = btn_img;
                        subsubitem.BackgroundImageLayout = ImageLayout.Stretch;
                        subsubitem.Click += ClickSound;
                    }
                }
            }

            #region 读取结构,维度,生物群系等数据
            if(Directory.Exists(Application.StartupPath + "\\generates\\generated1.16.3\\reports\\biomes"))
            {
                string[] biomeFiles = Directory.GetFiles(Application.StartupPath + "\\generates\\generated1.16.3\\reports\\biomes");
                if(biomeFiles.Length > 0)
                {
                    biome_box.AutoCompleteMode = AutoCompleteMode.Suggest;
                    biome_box.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    foreach (string item in biomeFiles)
                    {
                        //群系
                        biome_box.Items.Add("minecraft:" + Path.GetFileNameWithoutExtension(item));
                        biome_box.AutoCompleteCustomSource.Add(Path.GetFileNameWithoutExtension(item));
                    }
                }
            }

            TreeView Root = Cbhk_form.register;
            feature_box.AutoCompleteMode = AutoCompleteMode.Suggest;
            feature_box.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (TreeNode item in Root.Nodes)
            {
                //结构
                if(item.Text == "minecraft:worldgen/structure_feature")
                {
                    foreach (TreeNode subitem in item.Nodes)
                    {
                        if(subitem.Text == "entries")
                        {
                            foreach (TreeNode subsubitem in subitem.Nodes)
                            {
                                feature_box.Items.Add(subsubitem.Text);
                                feature_box.AutoCompleteCustomSource.Add(subsubitem.Text.Replace("minecraft:",""));
                            }
                        }
                    }
                }
            }
            #endregion
        }

        private void ClickSound(object sender,EventArgs e)
        {
            soundPlayer.Play();
        }

        private void location_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                #region 合并生物群系数据
                string biomeInfo = "\"biome\":\"";
                if (biome_box.Text.Trim() != "")
                    biomeInfo += biome_box.Text + "\",";
                else
                    biomeInfo = "";
                #endregion

                #region 合并维度数据
                string dimensionInfo = "\"dimension\":\"";
                if (dimension_box.Text.Trim() != "")
                    dimensionInfo += dimension_box.Text.Trim() + "\",";
                else
                    dimensionInfo = "";
                #endregion

                #region 合并结构数据
                string featureInfo = "\"feature\":";
                if (feature_box.Text.Trim() != "")
                    featureInfo += feature_box.Text.Trim() + "\",";
                else
                    featureInfo = "";
                #endregion

                #region 合并方块谓词数据
                string block_predicate_info = "\"predicate\":{";
                foreach (TabPage item in block_tab.TabPages)
                {
                    if (item.Tag != null)
                        block_predicate_info += item.Tag.ToString().Trim();
                }
                if (block_predicate_info != "\"predicate\":{")
                    block_predicate_info = block_predicate_info.TrimEnd(',') + "},";
                else
                    block_predicate_info = "";
                #endregion

                #region 合并流体谓词数据
                string fluid_predicate_info = "\"predicate\":{";
                foreach (TabPage item in fluid_tab.TabPages)
                {
                    if (item.Tag != null)
                        fluid_predicate_info += item.Tag.ToString().Trim();
                }
                if (fluid_predicate_info != "\"predicate\":{")
                    fluid_predicate_info = fluid_predicate_info.TrimEnd(',') + "},";
                else
                    fluid_predicate_info = "";
                #endregion

                #region 合并光照数据
                string lightInfo = set_light.Tag != null && set_light.Tag.ToString().Trim() !="" ?set_light.Tag.ToString().Trim():"";
                #endregion

                #region 合并坐标数据
                string pos = (set_x.Tag != null? set_x.Tag.ToString().Trim() : "") + (set_y.Tag != null ? set_y.Tag.ToString().Trim() : "") + (set_z.Tag != null ? set_z.Tag.ToString().Trim() : "");
                pos = pos.TrimEnd(',');
                string positionInfo = "";
                if (pos.Trim() != "")
                    positionInfo = "\"position\":{" + pos + "}";
                #endregion

                #region 合并出最终结果
                result = biomeInfo + dimensionInfo + featureInfo + block_predicate_info + fluid_predicate_info + lightInfo + positionInfo;
                result = result.TrimEnd(',');
                #endregion

                DialogResult = DialogResult.OK;
            }
        }

        private void add_block_Click(object sender, EventArgs e)
        {
            block_predicate_page bpp = new block_predicate_page();
            block_tab.TabPages.Add(bpp.block_tab.SelectedTab);
            block_tab.SelectedIndex = block_tab.TabPages.Count - 1;
            block_tab.SelectedTab.Text = block_tab.TabPages.Count+"";
        }

        private void delete_block_Click(object sender, EventArgs e)
        {
            block_tab.TabPages.RemoveAt(block_tab.SelectedIndex);
        }

        private void clear_block_Click(object sender, EventArgs e)
        {
            block_tab.TabPages.Clear();
        }

        private void add_fluid_Click(object sender, EventArgs e)
        {
            fluid_predicate_page fpp = new fluid_predicate_page();
            fluid_tab.TabPages.Add(fpp.fluid_tab.SelectedTab);
            fluid_tab.SelectedIndex = fluid_tab.TabPages.Count - 1;
            fluid_tab.SelectedTab.Text = fluid_tab.TabPages.Count + "";
        }

        private void delete_fluid_Click(object sender, EventArgs e)
        {
            fluid_tab.TabPages.RemoveAt(fluid_tab.SelectedIndex);
        }

        private void clear_fluid_Click(object sender, EventArgs e)
        {
            fluid_tab.TabPages.Clear();
        }
    }
}
