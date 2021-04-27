using System.Collections.Generic;
using System.Windows.Forms;
using System;
using cbhk_editor.LootTableSpawner.condition_components.SubComponents;
using System.Text.RegularExpressions;

namespace cbhk_editor.LootTableSpawner.condition_components
{
    public partial class damage_source_properties : UserControl
    {
        List<string> damageObjList = new List<string> { "bypasses_armor:是否破甲", "bypasses_invulnerability:是否无视无敌状态", "bypasses_magic:是否由饥饿引起", "is_explosion:是否由爆炸引起", "is_fire:是否由火焰引起", "is_magic:是否由魔法引起", "is_projectile:是否由弹射物引起", "is_lightning:是否由闪电引起" };
        public damage_source_properties()
        {
            InitializeComponent();
            InitUISettings();
        }

        private void InitUISettings()
        {
            foreach (string item in damageObjList)
            {
                damage_obj_box.Items.Add(item);
            }
            set_direct_entity.Click += ClickEvent;
            set_direct_entity.Click += ClickEvent;
        }

        private void UpdateInfo()
        {
            #region 合并实体状态数据
            string entityStates = "";
            for (int i = 0; i < damage_obj_box.Items.Count; i++)
            {
                if(damage_obj_box.GetItemChecked(i))
                {
                    //MessageBox.Show(damage_obj_box.Items[i].ToString());
                    entityStates += "\"" + Regex.Match(damage_obj_box.Items[i].ToString(), @"[A-z_]+").ToString() + "\":true,";
                }
            }
            #endregion

            #region 合并最终结果
            string entityInfo = "";
            entityInfo += (set_direct_entity.Tag != null ?set_direct_entity.Tag.ToString():"")+(set_source_entity.Tag != null? set_source_entity.Tag.ToString():"");
            if (entityInfo.Trim() != "")
                entityInfo = entityInfo.TrimEnd(',');
            entityInfo = entityStates + entityInfo;
            entityInfo = entityInfo.TrimEnd(',');
            table.Parent.Tag = "{\"condition\":\"minecraft:damage_source_properties\",\"predicate\":{" + entityInfo + "}},";
            #endregion
        }

        private void ClickEvent(object sender,EventArgs e)
        {
            Button this_obj = sender as Button;
            entity_property_form epf = new entity_property_form();
            if (epf.ShowDialog() == DialogResult.OK && epf.result.Trim() != "")
            {
                this_obj.Tag = "\"" + this_obj.Name.Replace("set_", "") + "\":{" + epf.result + "},";
            }
            else
                this_obj.Tag = null;
            UpdateInfo();
        }

        private void damage_obj_box_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateInfo();
        }
    }
}
