using cbhk_editor.LootTableSpawner;
using System;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner
{
    public static class SetInfo
    {
        public static void SetPlayer(object sender,EventArgs e)
        {
            Button this_obj = sender as Button;
            condition_form cf = new condition_form();
            string playerInfo = "";
            if (cf.ShowDialog() == DialogResult.OK)
            {
                foreach (TreeNode item in cf.conditionInfo.Nodes)
                {
                    if (item.Tag != null)
                        playerInfo += item.Tag.ToString();
                }
                if (playerInfo.Trim() != "")
                    this_obj.Tag = "\"player\":[" + playerInfo.TrimEnd(',') + "]";
                else
                    this_obj.Tag = null;
            }
        }

        public static void SetItem(object sender, EventArgs e)
        {
            Button this_obj = sender as Button;
            condition_form cf = new condition_form();
            string itemInfo = "";
            if (cf.ShowDialog() == DialogResult.OK)
            {
                foreach (Control tool_page in cf.condition_tab.TabPages[5].Controls)
                {
                    if(tool_page is TabControl)
                    {
                        TabControl tool_tab = tool_page as TabControl;
                        foreach (TabPage page in tool_tab.TabPages)
                        {
                            if (page.Tag != null)
                            {
                                itemInfo += page.Tag.ToString();
                                break;
                            }
                        }
                        break;
                    }
                }

                if (itemInfo.Trim() != "")
                    this_obj.Tag = "\"item\":"+itemInfo.TrimEnd(',');
                else
                    this_obj.Tag = null;
            }
        }

        public static void SetItems(object sender, EventArgs e)
        {
            Button this_obj = sender as Button;
            condition_form cf = new condition_form();
            string itemInfo = "";
            if (cf.ShowDialog() == DialogResult.OK)
            {
                foreach (Control tool_page in cf.condition_tab.TabPages[5].Controls)
                {
                    if (tool_page is TabControl)
                    {
                        TabControl tool_tab = tool_page as TabControl;
                        foreach (TabPage page in tool_tab.TabPages)
                        {
                            if (page.Tag != null)
                            {
                                itemInfo += page.Tag.ToString();
                            }
                        }
                        break;
                    }
                }

                if (itemInfo.Trim() != "")
                    this_obj.Tag = itemInfo.TrimEnd(',');
                else
                    this_obj.Tag = null;
            }
        }

        public static void SetEntity(object sender, EventArgs e)
        {
            Button this_obj = sender as Button;
            condition_form cf = new condition_form();
            string entityInfo = "";
            if (cf.ShowDialog() == DialogResult.OK)
            {
                foreach (Control tool_page in cf.condition_tab.TabPages[2].Controls)
                {
                    if (tool_page is TabControl)
                    {
                        TabControl tool_tab = tool_page as TabControl;
                        foreach (TabPage page in tool_tab.TabPages)
                        {
                            if (page.Tag != null)
                            {
                                entityInfo += page.Tag.ToString();
                                break;
                            }
                        }
                        break;
                    }
                }

                if (entityInfo.Trim() != "")
                    this_obj.Tag = entityInfo.TrimEnd(',');
                else
                    this_obj.Tag = null;
            }
        }

        public static void SetEntities(object sender, EventArgs e)
        {
            Button this_obj = sender as Button;
            condition_form cf = new condition_form();
            string entityInfo = "";
            if (cf.ShowDialog() == DialogResult.OK)
            {
                foreach (Control tool_page in cf.condition_tab.TabPages[2].Controls)
                {
                    if (tool_page is TabControl)
                    {
                        TabControl tool_tab = tool_page as TabControl;
                        foreach (TabPage page in tool_tab.TabPages)
                        {
                            if (page.Tag != null)
                            {
                                entityInfo += page.Tag.ToString();
                            }
                        }
                        break;
                    }
                }

                if (entityInfo.Trim() != "")
                    this_obj.Tag = entityInfo.TrimEnd(',');
                else
                    this_obj.Tag = null;
            }
        }

        public static void SetDamage(object sender,EventArgs e)
        {
            Button this_obj = sender as Button;
            condition_form cf = new condition_form();
            string damageInfo = "";
            if (cf.ShowDialog() == DialogResult.OK)
            {
                foreach (Control tool_page in cf.condition_tab.TabPages[1].Controls)
                {
                    if (tool_page is TabControl)
                    {
                        TabControl tool_tab = tool_page as TabControl;
                        foreach (TabPage page in tool_tab.TabPages)
                        {
                            if (page.Tag != null)
                            {
                                damageInfo += page.Tag.ToString();
                                break;
                            }
                        }
                        break;
                    }
                }

                if (damageInfo.Trim() != "")
                    this_obj.Tag = damageInfo.TrimEnd(',');
                else
                    this_obj.Tag = null;
            }
        }

        public static void SetLocation(object sender,EventArgs e)
        {
            Button this_obj = sender as Button;
            condition_form cf = new condition_form();
            string locationInfo = "";
            if (cf.ShowDialog() == DialogResult.OK)
            {
                foreach (Control tool_page in cf.condition_tab.TabPages[4].Controls)
                {
                    if (tool_page is TabControl)
                    {
                        TabControl tool_tab = tool_page as TabControl;
                        foreach (TabPage page in tool_tab.TabPages)
                        {
                            if (page.Tag != null)
                            {
                                locationInfo += page.Tag.ToString();
                                break;
                            }
                        }
                        break;
                    }
                }

                if (locationInfo.Trim() != "")
                    this_obj.Tag = locationInfo.TrimEnd(',');
                else
                    this_obj.Tag = null;
            }
        }
    }
}
