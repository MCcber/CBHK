using cbhk_editor.MainForm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace cbhk_editor.VillagerSpawner
{
    public partial class villager_spawner : Form
    {
        Form parent;
        SoundPlayer soundPlayer;
        TreeView Root;
        //按钮图像
        Image btnImg = Image.FromFile(Application.StartupPath + "\\ButtonsBgImages\\button.png");

        public villager_spawner(Form obj,SoundPlayer click)
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            parent = obj;
            soundPlayer = click;
            Root = Cbhk_form.register;
            click_to_return.Click += (a,b) => 
            {
                soundPlayer.Play();
                parent.ShowInTaskbar = true;
                parent.TopMost = true;
                parent.WindowState = FormWindowState.Normal;
                parent.Show();
                parent.TopMost = false;
                Close();
            };
            InitUISettings();
        }

        private void InitUISettings()
        {
            BackColor = Color.FromArgb(50,50,50);
            ForeColor = Color.White;
            villager_tab.SelectedTab.BackColor = Color.FromArgb(50,50,50);
            foreach (ToolStripMenuItem item in villager_title_menu.Items)
            {
                item.BackgroundImage = btnImg;
                item.BackgroundImageLayout = ImageLayout.Stretch;
                item.ForeColor = Color.FromArgb(255, 255, 255);
                item.DropDownOpened += (a, b) =>
                {
                    item.ForeColor = Color.FromArgb(0, 0, 0);
                };
                item.DropDownClosed += (a, b) =>
                {
                    item.ForeColor = Color.FromArgb(255, 255, 255);
                };
                item.Click += ClickSound;
                foreach (ToolStripMenuItem subitem in item.DropDownItems)
                {
                    subitem.BackgroundImage = btnImg;
                    subitem.BackgroundImageLayout = ImageLayout.Stretch;
                    subitem.ForeColor = Color.FromArgb(255, 255, 255);
                    subitem.Click += ClickSound;
                }
            }
            villager_tab.TabPages.Clear();
            add_villager_title_menu_Click(null, null);
        }

        private void ClickSound(object sender,EventArgs e)
        {
            soundPlayer.Play();
        }

        private void add_villager_title_menu_Click(object sender, EventArgs e)
        {
            villager_page villager_Page = new villager_page(Root,soundPlayer);
            villager_tab.TabPages.Add(villager_Page.villager_tab.SelectedTab);
            villager_tab.SelectedIndex = villager_tab.TabPages.Count - 1;
            villager_tab.SelectedTab.Text = "第"+villager_tab.TabPages.Count+"个";
            villager_tab.SelectedTab.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void delete_villager_title_menu_Click(object sender, EventArgs e)
        {
            villager_tab.TabPages.RemoveAt(villager_tab.SelectedIndex);
        }

        private void clear_villager_title_menu_Click(object sender, EventArgs e)
        {
            villager_tab.TabPages.Clear();
        }

        private void add_transaction_title_menu_Click(object sender, EventArgs e)
        {
            transaction_page transaction_Page = new transaction_page(soundPlayer,Root);
            TabControl transaction_tab = villager_tab.SelectedTab.Controls.Find("transaction_tab", true)[0] as TabControl;
            transaction_tab.TabPages.Add(transaction_Page.transaction_tab.SelectedTab);
            transaction_tab.SelectedIndex = transaction_tab.TabPages.Count - 1;
            transaction_tab.SelectedTab.Text = transaction_tab.TabPages.Count+"号交易";
        }

        private void delete_transaction_title_menu_Click(object sender, EventArgs e)
        {
            TabControl transaction_tab = villager_tab.SelectedTab.Controls.Find("transaction_tab", true)[0] as TabControl;
            transaction_tab.TabPages.RemoveAt(transaction_tab.SelectedIndex);
        }

        private void clear_transaction_title_menu_Click(object sender, EventArgs e)
        {
            TabControl transaction_tab = villager_tab.SelectedTab.Controls.Find("transaction_tab", true)[0] as TabControl;
            transaction_tab.TabPages.Clear();
        }

        private void add_villager_Click(object sender, EventArgs e)
        {
            add_villager_title_menu_Click(null,null);
        }

        private void delete_villager_Click(object sender, EventArgs e)
        {
            delete_villager_title_menu_Click(null,null);
        }

        private void clear_villager_Click(object sender, EventArgs e)
        {
            clear_villager_title_menu_Click(null,null);
        }

        private void add_transaction_Click(object sender, EventArgs e)
        {
            add_transaction_title_menu_Click(null,null);
        }

        private void delete_transaction_Click(object sender, EventArgs e)
        {
            delete_transaction_title_menu_Click(null,null);
        }

        private void clear_transaction_Click(object sender, EventArgs e)
        {
            clear_transaction_title_menu_Click(null,null);
        }

        private void click_to_spawn_Click(object sender, EventArgs e)
        {
            //保存最终结果
            List<string> results = new List<string> { };
            foreach (TabPage villager_page in villager_tab.TabPages)
            {
                //保存职业
                ComboBox villager_professional = villager_page.Controls.Find("villager_professional", true)[0] as ComboBox;
                //保存类型
                ComboBox villager_type_box = villager_page.Controls.Find("villager_type_box", true)[0] as ComboBox;
                //交易等级
                ComboBox transaction_level_box = villager_page.Controls.Find("transaction_level_box", true)[0] as ComboBox;
                //当前经验值
                NumericUpDown exp_box = villager_page.Controls.Find("exp_box", true)[0] as NumericUpDown;
                //版本信息
                ComboBox version_box = villager_page.Controls.Find("version_box", true)[0] as ComboBox;

                #region 保存UID列表
                string Gossips = "";
                ListView speech_btn_box = villager_page.Controls.Find("speech_btn_box", true)[0] as ListView;
                foreach (Button item in speech_btn_box.Controls)
                {
                    if (item.Tag != null && item.Tag.ToString().Trim() != "")
                        Gossips += item.Tag.ToString();
                }
                Gossips = Gossips.Trim()!=""?(Gossips.Trim() != "" ? "Gossips:[" + Gossips.TrimEnd(',') + "]," : "") :"";
                #endregion

                #region 保存站点列表
                string Brain = "";
                ListView memory_btn_box = villager_page.Controls.Find("memory_btn_box", true)[0] as ListView;
                foreach (Button item in memory_btn_box.Controls)
                {
                    if (item.Tag != null && item.Tag.ToString().Trim() != "")
                        Brain += item.Tag.ToString();
                }
                Brain = Brain.Trim()!=""? "Brain:{memories:{" + Brain.TrimEnd(',') + "}}," : "";
                #endregion

                #region 保存所有交易数据
                //交易标签页引用
                TabControl transaction_tab = villager_page.Controls.Find("transaction_tab", true)[0] as TabControl;


                string transaction_string = "";
                List<string> transaction_item = new List<string> { };
                foreach (TabPage a_transaction in transaction_tab.TabPages)
                {
                    Button buy = a_transaction.Controls.Find("set_item1", true)[0] as Button;
                    Button buyB = a_transaction.Controls.Find("set_item2", true)[0] as Button;
                    Button sell = a_transaction.Controls.Find("set_item3", true)[0] as Button;

                    NumericUpDown xp_box = a_transaction.Controls.Find("xp_box", true)[0] as NumericUpDown;
                    NumericUpDown uses_box = a_transaction.Controls.Find("uses_box", true)[0] as NumericUpDown;
                    NumericUpDown maxUses_box = a_transaction.Controls.Find("maxUses_box", true)[0] as NumericUpDown;
                    NumericUpDown demand_box = a_transaction.Controls.Find("demand_box", true)[0] as NumericUpDown;
                    NumericUpDown specialPrice_box = a_transaction.Controls.Find("specialPrice_box", true)[0] as NumericUpDown;
                    TextBox priceMultiplier_box = a_transaction.Controls.Find("priceMultiplier_box", true)[0] as TextBox;
                    CheckBox rewardExp = a_transaction.Controls.Find("rewardExp", true)[0] as CheckBox;

                    #region 合并物品数据
                    string transaction_result = "{" + (rewardExp.Checked ? "rewardExp:true," : "") + (xp_box.Value != -1 ? "xp:" + xp_box.Value + "," : "") + (uses_box.Value != -1 ? "uses:" + uses_box.Value + "," : "") + (maxUses_box.Value != -1 ? "maxUses:" + maxUses_box.Value + "," : "") + (demand_box.Value != -1 ? "demand:" + demand_box.Value + "," : "") + (priceMultiplier_box.Text.Trim() != "" ? "priceMultiplier:" + priceMultiplier_box.Text.Trim() + "," : "") + (specialPrice_box.Value != -1 ? "specialPrice:" + specialPrice_box.Value + "," : "")+(buy.Tag!=null && buy.Tag.ToString().Trim()!=""?"buy:"+buy.Tag.ToString()+",":"")+ (buyB.Tag != null && buyB.Tag.ToString().Trim() != "" ? "buyB:" + buyB.Tag.ToString()+"," : "")+ (sell.Tag != null && sell.Tag.ToString().Trim() != "" ? "sell:" + sell.Tag.ToString()+"," : "");

                    transaction_item.Add(transaction_result.TrimEnd(',')+"},");
                    #endregion
                }


                foreach (string item in transaction_item)
                {
                    transaction_string += item;
                }
                transaction_string = transaction_string.Trim() != "" ? "Offers:{Recipes:[" + transaction_string.TrimEnd(',') + "]}," : "";
                #endregion

                string ProfessionInfo = villager_professional.Text.Trim() != "" ? (version_box.SelectedIndex == 0?"P":"p")+"rofession:\"" + (version_box.SelectedIndex == 0?villager_type_box.Text.Trim(): villager_professional.Text.Trim()) + "\"," : "";

                string TypeInfo = villager_type_box.Text.Trim() != "" && version_box.SelectedIndex == 1 ?"type:\""+villager_type_box.Text.Trim()+"\",":"";

                string LevelInfo = transaction_level_box.Text.Trim() != "" ?"level:"+transaction_level_box.Text.Trim()+",":"";

                string VillagerData = ProfessionInfo.Trim()!=""||TypeInfo.Trim()!="" || LevelInfo.Trim()!=""? (version_box.SelectedIndex == 1 ? "VillagerData:{" : "") + ProfessionInfo + TypeInfo + LevelInfo : "";
                VillagerData = VillagerData.Trim()!=""? (version_box.SelectedIndex == 1 ? VillagerData.TrimEnd(',') + "}," : VillagerData) : "";

                string result = "/summon villager ~ ~1 ~ {"+VillagerData + transaction_string + Gossips + Brain + (exp_box.Value != -1 ? "Xp:" + exp_box.Value + "," : "");
                result = result.Trim(',') + "}";
                results.Add(result);
            }

            #region 生成命令
            command_result cmd_result = new command_result("村民指令",results);
            cmd_result.Show();
            #endregion
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.最终价格 = ( demand ×  priceMultiplier × 原价) + ( priceMultiplier ×  Gossips标签下 Type为minor_negative时的 Value) - ( priceMultiplier ×  Gossips标签下 Type为trading时的 Value × 10) +  specialPrice + 原价\r\n2.添加言论或记忆时请点击对应的按钮进行数据设置");
        }
    }
}
