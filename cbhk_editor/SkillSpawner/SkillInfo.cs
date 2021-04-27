using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace cbhk_editor.SkillSpawner
{
    public partial class SkillInforForm : Form
    {
        //按钮背景图
        Image btnimg = Image.FromFile(Application.StartupPath + "\\ButtonsBgImages\\button.png");
        //实体条件列表
        List<string> entity_conditions = new List<string> { "每受到N点伤害","每受到伤害","每延迟N秒" };
        //物品条件列表
        List<string> item_conditions = new List<string> { "实体拥有物品","实体手持物品","实体按Q丢弃物品","玩家手持物品并按F","玩家物品穿戴或放置在N号槽位","玩家手持物品并攻击实体" };
        //事件列表
        List<string> events = new List<string> { "召唤实体","实体/玩家被雷击","玩家得到药水效果","实体播放粒子效果","实体被随机传送" };
        //是否为实体条件
        bool EntityCondition = false;
        //是否为事件
        bool IsEvent = false;
        //返回的文本
        public List<string> result_text = new List<string> { };
        public SkillInforForm(bool IsEntityConditions,bool IsEvents)
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            selectAll.BackgroundImage = reverseSelect.BackgroundImage = btnimg;
            selectAll.BackgroundImageLayout = reverseSelect.BackgroundImageLayout = ImageLayout.Stretch;
            InfoList.BackColor = Color.FromArgb(20,20,20);
            InfoList.ForeColor = Color.FromArgb(255,255,255);
            EntityCondition = IsEntityConditions;
            IsEvent = IsEvents;
            if (IsEntityConditions)
            {
                Text = "实体条件"+Text;
                foreach (string item in entity_conditions)
                {
                    InfoList.Items.Add(item,false);
                }
            }
            else
                if(!IsEvents)
            {
                Text = "物品条件" + Text;
                foreach (string item in item_conditions)
                {
                    InfoList.Items.Add(item, false);
                }
            }
            else
            {
                Text = "事件" + Text;
                foreach (string item in events)
                {
                    InfoList.Items.Add(item, false);
                }
            }
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < InfoList.Items.Count; i++)
                InfoList.SetItemChecked(i,true);
        }

        private void ReverseSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < InfoList.Items.Count; i++)
            {
                if (InfoList.GetItemChecked(i))
                    InfoList.SetItemChecked(i, false);
                else
                    InfoList.SetItemChecked(i,true);
            }
        }

        private void SkillInforForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //物品/实体条件
            if(!IsEvent)
            {
                foreach (string obj in InfoList.CheckedItems)
                    result_text.Add(InfoList.Items.IndexOf(obj)+"");
            }
            else
            if(IsEvent)
            {
                foreach (string obj in InfoList.CheckedItems)
                    result_text.Add(InfoList.Items.IndexOf(obj)+"");
            }
            DialogResult = DialogResult.OK;
        }
    }
}
