using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace cbhk_editor.SkillSpawner
{
    class SkillManager
    {
        List<string> result = new List<string> { };

        /// <summary>
        /// 条件:受到N点伤害
        /// </summary>
        /// <param name="target_control"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public List<string> HurtedDamage(UserControl target_control,string version)
        {
            result.Clear();
            int damage = 0;
            Button entity = new Button();
            foreach (Control item in target_control.Controls)
            {
                if(item is NumericUpDown)
                {
                    NumericUpDown this_obj = item as NumericUpDown;
                    damage = (int)this_obj.Value;
                    break;
                }
                if(item is Button)
                {
                    Button this_obj = item as Button;
                    entity = this_obj;
                    break;
                }
            }

            //添加标签名称
            result.Add("Tag:HurtedDamage,Scb:HurtedDamage:"+damage);
            if(version == "1.12")
            {
                string init_scb = "scoreboard objectives add HurtedDamage stat.damageTaken";
                string remove_tag = "scoreboard players tag @e remove HurtedDamage";
                string reset_scb = "scoreboard players set @a[score_HurtedDamage_min="+damage+ "] HurtedDamage 0";
                string add_tag = "scoreboard players tag @a[score_HurtedDamage_min=" + damage + "] add HurtedDamage {HurtTime:9s"+(entity.Tag!=null?","+entity.Tag.ToString():"") +"}";
                result.Add(init_scb+"\r\n");
                result.Add(remove_tag+"\r\n");
                result.Add(add_tag + "\r\n");
                result.Add(reset_scb+"\r\n");
            }
            else
                if(version == "1.13")
            {
                string init_scb = "scoreboard objectives add HurtedDamage minecraft.custom:minecraft.damage_taken";
                string remove_tag = "tag @e remove HurtedDamage";
                string reset_scb = "scoreboard players set @a[scores={HurtedDamage=" + damage + "..}] HurtedDamage 0";
                string add_tag = "tag @a[scores={HurtedDamage=" + damage + "..},nbt={HurtTime:9s}] add HurtedDamage";
                result.Add(init_scb + "\r\n");
                result.Add(remove_tag + "\r\n");
                result.Add(add_tag + "\r\n");
                result.Add(reset_scb+"\r\n");
            }
            return result;
        }

        /// <summary>
        /// 条件:每受到伤害
        /// </summary>
        /// <param name="empty">空</param>
        /// <param name="version">版本</param>
        /// <returns></returns>
        public List<string> HurtedByPlayer(UserControl target_control, string version)
        {
            result.Clear();

            //添加标签名称
            result.Add("Tag:EveryHurted");
            if (version == "1.12")
            {
                string add_tag = "scoreboard players tag @e add EveryHurted {HurtTime:9s}";
                string remove_tag = "scoreboard players tag @e remove EveryHurted";
                result.Add(remove_tag + "\r\n");
                result.Add(add_tag + "\r\n");
            }
            else
                if (version == "1.13")
            {
                string remove_tag = "tag @e remove EveryHurted";
                string add_tag = "tag @e[nbt={HurtTime:9s}] add EveryHurted";
                result.Add(remove_tag + "\r\n");
                result.Add(add_tag + "\r\n");
            }

            return result;
        }

        /// <summary>
        /// 条件:延迟一定时间
        /// </summary>
        /// <param name="target_control"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public List<string> DelayTimes(UserControl target_control,string version)
        {
            result.Clear();
            int delay_value = 0;
            string entity_id = "";
            string entity_nbt = "";
            foreach (Control item in target_control.Controls)
            {
                if(item is NumericUpDown)
                {
                    NumericUpDown this_obj = item as NumericUpDown;
                    delay_value = int.Parse(this_obj.Value.ToString());
                    break;
                }
                if(item is Button)
                {
                    Button entity_info = item as Button;
                    entity_id = entity_info.Name;
                    entity_nbt = entity_info.Tag != null ?entity_info.Tag.ToString():"";
                }
            }
            //添加记分板变量名称
            result.Add("Tag:"+entity_id+"_delayer,Scb:delay:" + delay_value);
            string tag_value = "tag:"+entity_id+ "_delayer";
            string init = "scoreboard objectives add DelayTime dummy";
            if (version == "1.12")
            {
                string reset_scb = "scoreboard players set @e[type="+entity_id+","+tag_value+",score_DelayTime_min="+ (delay_value * 20) + "] DelayTime 0";
                string remove_tag = "scoreboard players tag @e[type=" + entity_id +"] remove "+entity_id+ "_delayer";
                string add_scb = "scoreboard players add @e[type=" + entity_id + "] DelayTime 1";
                string add_tag = "scoreboard players tag @e[type="+entity_id+ ",score_DelayTime_min="+(delay_value*20)+"] add "+entity_id+ "_delayer "+entity_nbt;

                result.Add(init + "\r\n");
                result.Add(remove_tag + "\r\n");
                result.Add(add_scb + "\r\n");
                result.Add(add_tag + "\r\n");
                result.Add(reset_scb+"\r\n");
            }
            else
                if(version == "1.13")
            {
                string reset_scb = "scoreboard players set @e[type=" + entity_id + "," + tag_value + ",scores={DelayTime=" + (delay_value * 20) + "..}] DelayTime 0";
                string remove_tag = "tag @e[type=" + entity_id + "," + tag_value + "] remove " + entity_id + "_delayer";
                string add_scb = "scoreboard players add @e[type=" + entity_id + "] DelayTime 1";
                string add_tag = "tag @e[type=" + entity_id + ",score_DelayTime_min=" + (delay_value * 20) + "] add " + entity_id + "_delayer "+entity_nbt;

                result.Add(init + "\r\n");
                result.Add(remove_tag + "\r\n");
                result.Add(add_scb + "\r\n");
                result.Add(add_tag + "\r\n");
                result.Add(reset_scb + "\r\n");
            }

            return result;
        }

        /// <summary>
        /// 条件:拥有物品
        /// </summary>
        /// <param name="target_control"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public List<string> HaveItems(UserControl target_control,string version)
        {
            result.Clear();
            Button item_btn = new Button() { };
            foreach (Control item in target_control.Controls)
            {
                if(item is Button)
                {
                    item_btn = item as Button;
                    break;
                }
            }
            result.Add("Tag:HaveItem_"+item_btn);
            if(version == "1.12")
            {
                string remove_tag = "scoreboard players tag @a remove HaveItems_"+item_btn.Name;
                string add_tag = "scoreboard players tag @a add HaveItems_"+item_btn.Name + (item_btn.Tag != null ? " {Inventory:[" + item_btn.Tag.ToString() +"]}": "") + "\r\n";
                result.Add(remove_tag+"\r\n");
                result.Add(add_tag+"\r\n");
            }
            else
            if(version == "1.13")
            {
                string remove_tag = "tag @a remove HaveItems_"+item_btn.Name;
                string add_tag = "tag @a[nbt={" + (item_btn.Tag != null ? "Inventory:["+ item_btn.Tag.ToString()+"]" : "") + "}] add HaveItems_"+item_btn.Name;
                result.Add(remove_tag + "\r\n");
                result.Add(add_tag + "\r\n");
            }
            return result;
        }

        /// <summary>
        /// 条件:手持物品
        /// </summary>
        /// <param name="target_control"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public List<string> SelectedItem(UserControl target_control, string version)
        {
            result.Clear();
            Button item_btn = new Button() { };
            foreach (Control item in target_control.Controls)
            {
                if (item is Button)
                {
                    item_btn = item as Button;
                    break;
                }
            }
            result.Add("Tag:SelectedItem_"+item_btn.Name);
            if (version == "1.12")
            {
                string remove_tag = "scoreboard players tag @a remove SelectedItem_" + item_btn.Name;
                string add_tag = "scoreboard players tag @a add SelectedItem_" + item_btn.Name + (item_btn.Tag != null ? " {SelectedItem:" + item_btn.Tag.ToString()+"}" : "")+"\r\n";
                result.Add(remove_tag + "\r\n");
                result.Add(add_tag + "\r\n");
            }
            else
            if (version == "1.13")
            {
                string remove_tag = "tag @a remove SelectedItem_"+item_btn.Name;
                string add_tag = "tag @a[nbt={" + (item_btn.Tag != null ? "SelectedItem:" + item_btn.Tag.ToString() : "") + "}] add SelectedItem_"+item_btn.Name;
                result.Add(remove_tag + "\r\n");
                result.Add(add_tag + "\r\n");
            }
            return result;
        }

        /// <summary>
        /// 条件:按Q丢弃物品
        /// </summary>
        /// <param name="target_control"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public List<string> DropItemByQKey(UserControl target_control, string version)
        {
            result.Clear();
            Button item_btn = new Button();
            foreach (Control item in target_control.Controls)
            {
                if (item is Button)
                {
                    item_btn = item as Button;
                    break;
                }
            }
            result.Add("Tag:Drop_"+item_btn.Name+",Scb:drop_"+item_btn.Name+":1");
            if (version == "1.12")
            {
                string init = "scoreboard objectives add drop_"+item_btn.Name+" stat.drop.minecraft."+item_btn.Name;
                string reset_scb = "scoreboard players set @e[tag=Drop_"+item_btn.Name+",score_drop_"+item_btn.Name+"_min=1] drop_"+item_btn.Name+" 0";
                string remove_tag = "scoreboard players tag @a remove Drop_" + item_btn.Name;
                string remove_havetag = "scoreboard players tag @a remove HaveDrop_" + item_btn.Name;
                string have_tag = "scoreboard players tag @a add HaveDrop_"+item_btn.Name+(item_btn.Tag!=null? " {SelectedItem:"+item_btn.Tag.ToString()+"}" :"");
                string add_tag = "scoreboard players tag @a[score_drop_" + item_btn.Name + "_min=1,tag=HaveDrop_"+item_btn.Name+"] add Drop_"+item_btn.Name;

                result.Add(init);
                result.Add(remove_tag);
                result.Add(have_tag);
                result.Add(remove_havetag);
                result.Add(have_tag);
                result.Add(add_tag);
                result.Add(reset_scb);
            }
            else
            if (version == "1.13")
            {
                string init = "scoreboard objectives add drop_"+item_btn.Name+" minecraft.dropped:minecraft."+item_btn.Name;
                string reset_scb = "scoreboard players set @e[tag=Drop_" + item_btn.Name + ",scores={drop_" + item_btn.Name + "=1..}] drop_"+item_btn.Name+" 0";
                string remove_tag = "tag @a remove Drop_" + item_btn.Name;
                string remove_havetag = "tag @a remove HaveDrop_" + item_btn.Name;
                string have_tag = "tag @a[nbt={" + (item_btn.Tag != null ? "SelectedItem:" + item_btn.Tag.ToString() : "")+"}] add HaveDrop_"+item_btn.Name;
                string add_tag = "tag @a[scores={drop_" + item_btn.Name + "=1..},tag=HaveDrop_"+item_btn.Name+ "] add Drop_" + item_btn.Name;

                result.Add(init);
                result.Add(remove_tag);
                result.Add(remove_havetag);
                result.Add(have_tag);
                result.Add(add_tag);
                result.Add(reset_scb);
            }
            return result;
        }

        /// <summary>
        /// 手持物品并切换到副手
        /// </summary>
        /// <returns></returns>
        public List<string> HaveItemFKey(UserControl target_control, string version)
        {
            result.Clear();
            Button item_btn = new Button() { };
            foreach (Control item in target_control.Controls)
            {
                if (item is Button)
                {
                    item_btn = item as Button;
                    break;
                }
            }
            result.Add("Tag:OffHandHaveItems_" + item_btn.Name);
            if (version == "1.12")
            {
                string remove_tag = "scoreboard players tag @a remove OffHandHaveItems_" + item_btn.Name;
                string add_tag = "scoreboard players tag @a add OffHandHaveItems_" + item_btn.Name + (item_btn.Tag != null ? " {Inventory:["+item_btn.Tag.ToString().Substring(0, item_btn.Tag.ToString().Length - 1) + ",Slot:-106b}]}" : "") + "\r\n";
                result.Add(remove_tag + "\r\n");
                result.Add(add_tag + "\r\n");
            }
            else
            if (version == "1.13")
            {
                string remove_tag = "tag @a remove OffHandHaveItems_" + item_btn.Name;
                string add_tag = "tag @a[nbt={"+ (item_btn.Tag != null ? "Inventory:["+ item_btn.Tag.ToString().Substring(0, item_btn.Tag.ToString().Length - 1) + ", Slot:-106b}]" : "") + "}] add OffHandHaveItems_"+item_btn.Name;
                result.Add(remove_tag + "\r\n");
                result.Add(add_tag + "\r\n");
            }
            return result;
        }

        /// <summary>
        /// 条件:玩家穿戴物品并放在N号槽位
        /// </summary>
        /// <param name="target_control"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public List<string> WearItems(UserControl target_control, string version)
        {
            result.Clear();
            NumericUpDown slot_index = null;
            Button item_btn = null;
            foreach (Control item in target_control.Controls)
            {
                if(item is NumericUpDown)
                    slot_index = item as NumericUpDown;
                if (item is Button)
                    item_btn = item as Button;
                if (slot_index != null && item_btn != null)
                    break;
            }
            result.Add("Tag:Wear_"+item_btn.Name);
            if(version == "1.12")
            {
                string remove_tag = "scoreboard players tag @a remove Wear_"+item_btn.Name;
                string add_tag = "scoreboard players tag @a add Wear_"+item_btn.Name+(item_btn.Tag!=null? " {Inventory:["+item_btn.Tag.ToString().Substring(0,item_btn.Tag.ToString().Length-1)+",Slot:"+slot_index+"b}" : "") + "]}";
                result.Add(remove_tag);
                result.Add(add_tag);
            }
            else
                if(version == "1.13")
            {
                string remove_tag = "tag @a remove Wear_"+item_btn.Name;
                string add_tag = "tag @a[nbt={"+(item_btn.Tag != null ? "Inventory:["+ item_btn.Tag.ToString().Substring(0, item_btn.Tag.ToString().Length - 1) + ",Slot:" + slot_index + "b}": "") + "]}] add Wear_" + item_btn.Name;
                result.Add(remove_tag);
                result.Add(add_tag);
            }
            return result;
        }

        /// <summary>
        /// 条件:使用物品攻击
        /// </summary>
        /// <param name="target_control"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public List<string> AttackByItems(UserControl target_control, string version)
        {
            result.Clear();
            Button item_btn = new Button();
            foreach (Control item in target_control.Controls)
            {
                if(item is Button)
                {
                    item_btn = item as Button;
                    break;
                }
            }
            result.Add("Tag:AttackBy_"+item_btn.Name+ ",Scb:AttackBy_"+item_btn.Name+":1");
            if(version == "1.12")
            {
                string init = "scoreboard objectives add AttackBy_"+item_btn.Name+ " stat.damageDealt";
                string reset_scb = "scoreboard players set @e[tag=AttackBy_"+item_btn.Name+ ",score_AttackBy_"+item_btn.Name + "_min=1] AttackBy_"+item_btn.Name+" 0";
                string remove_tag = "scoreboard players tag @a remove AttackBy_"+item_btn.Name;
                string add_tag = "scoreboard players tag @a[score_Attackby_"+item_btn.Name+"_min=1] add Attackby_"+item_btn.Name+(item_btn.Tag!=null? " {SelectedItem:"+item_btn.Tag.ToString()+"}":"");
                result.Add(init);
                result.Add(remove_tag);
                result.Add(add_tag);
                result.Add(reset_scb);
            }
            else
            if(version == "1.13")
            {
                string init = "scoreboard objectives add AttackBy_"+item_btn.Name+" minecraft.custom:minecraft.damage_dealt";
                string reset_scb = "scoreboard players set @e[tag=AttackBy_" + item_btn.Name + ",scores={AttackBy_" + item_btn.Name + "=1..}] AttackBy_" + item_btn.Name + " 0";
                string remove_tag = "tag @a remove AttackBy_" + item_btn.Name;
                string add_tag = "tag @a[scores={AttackBy_"+item_btn.Name+"=1..}] add Attackby_" + item_btn.Name + (item_btn.Tag != null ? " {SelectedItem:"+ item_btn.Tag.ToString()+"}": "");
                result.Add(init);
                result.Add(remove_tag);
                result.Add(add_tag);
                result.Add(reset_scb);
            }
            return result;
        }

        /// <summary>
        /// 事件:召唤实体
        /// </summary>
        /// <param name="event_data"></param>
        /// <param name="condition_parameter"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public List<string> SummonEntity(UserControl event_ctl,string condition_parameter,string version)
        {
            result.Clear();
            string tag_value = "";
            string score_name = "";
            int score_value = 0;
            List<string> event_data = new List<string> { "","{}" };
            foreach (Control item in event_ctl.Controls)
            {
                if(item is ComboBox)
                {
                    ComboBox this_obj = item as ComboBox;
                    event_data[0] = this_obj.Text;
                }
                if(item is Button)
                {
                    Button this_obj = item as Button;
                    event_data[1] = this_obj.Tag != null ?this_obj.Tag.ToString():"{}";
                }
            }
            if (condition_parameter.Contains(","))
            {
                tag_value = condition_parameter.Split(',')[0].Split(':')[1];
                if (!Regex.Match(condition_parameter.Split(',')[1], "[\u4E00-\u9FA5]{0,}").Success)
                {
                    score_name = condition_parameter.Split(',')[1].Split(':')[1];
                    score_value = int.Parse(condition_parameter.Split(',')[1].Split(':')[2]);
                }
            }
            else
            {
                if (condition_parameter.Split(':')[0] == "Tag")
                    tag_value = condition_parameter.Split(':')[1];
                if(condition_parameter.Split(':')[0] == "Scb")
                {
                    score_name = condition_parameter.Split(':')[1];
                    score_value = int.Parse(condition_parameter.Split(':')[2]);
                }
            }
            string tag_data = tag_value != "" ? "tag=" + tag_value : "";
            if (version == "1.12")
            {
                string score_data = score_name != "" ?"score_"+score_name+"_min="+score_value:"";
                string target_para = "["+(tag_data!=""?tag_data:"")+(score_data!=""?","+score_data:"")+"]";
                if (target_para == "[]")
                    target_para = "";
                string summon_entity = "execute @e"+target_para+" summon "+event_data[0]+" ~ ~ ~ "+event_data[1];
                result.Add(summon_entity+"\r\n");
            }
            else
                if(version == "1.13")
            {
                string score_data = score_name != "" ? "scores={" + score_name + "=" + score_value + "..}" : "";
                string target_para = "[" + (tag_data != "" ? tag_data : "") + (score_data != "" ? "," + score_data : "") + "]";
                if (target_para == "[]")
                    target_para = "";
                string summon_entity = "execute as @e" + target_para + " at @s run summon " + (event_data.Count>0?event_data[0]:"") + " ~ ~ ~ " + (event_data.Count > 1 ? event_data[1] : "");
                result.Add(summon_entity+"\r\n");
            }
            return result;
        }

        /// <summary>
        /// 事件:被雷击
        /// </summary>
        /// <param name="event_data"></param>
        /// <param name="condition_parameter"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public List<string> StruckByLightning(UserControl event_ctl, string condition_parameter, string version)
        {
            result.Clear();
            string tag_value = "";
            string score_name = "";
            int score_value = 0;
            string entity_id = "";
            foreach (Control item in event_ctl.Controls)
            {
                if(item is ComboBox)
                {
                    ComboBox this_obj = item as ComboBox;
                    entity_id = this_obj.Text;
                    break;
                }
            }
            if (condition_parameter.Contains(","))
            {
                tag_value = condition_parameter.Split(',')[0].Split(':')[1];
                if (!Regex.Match(condition_parameter.Split(',')[1], "[\u4E00-\u9FA5]{0,}").Success)
                {
                    score_name = condition_parameter.Split(',')[1].Split(':')[1];
                score_value = int.Parse(condition_parameter.Split(',')[1].Split(':')[2]);
                }

            }
            else
            {
                if (condition_parameter.Split(':')[0] == "Tag")
                    tag_value = condition_parameter.Split(':')[1];
                if (condition_parameter.Split(':')[0] == "Scb")
                {
                    score_name = condition_parameter.Split(':')[1];
                    score_value = int.Parse(condition_parameter.Split(':')[2]);
                }
            }
            string tag_data = tag_value != "" ? ",tag=" + tag_value : "";
            string lightning = "";
            if (version == "1.12")
            {
                string score_data = score_name != "" ? ",score_" + score_name + "_min=" + score_value : "";
                string target_para = "["+ (entity_id!=""?"type="+entity_id:"") + (tag_data != "" ? tag_data : "") + (score_data != "" ? score_data : "")+"]";
                string player_data = "[" + (tag_data != "" ? tag_data.TrimStart(',') : "") + (score_data != "" ? score_data : "") + "]";
                if (target_para == "[]")
                    target_para = "";
                lightning = "execute @a"+player_data+" ~ ~ ~ execute @e[type="+entity_id+"] ~ ~ ~ summon minecraft:lightning_bolt";
            }
            else
                if (version == "1.13")
            {
                string score_data = score_name != "" ? ",scores{" + score_name + "=" + score_value+"..}" : "";
                string target_para = "[" + (entity_id != "" ? "type=" + entity_id : "") + (tag_data != "" ? tag_data : "") + (score_data != "" ? score_data : "") + "]";
                string player_data = "["+ (tag_data != "" ? tag_data.TrimStart(',') : "") + (score_data != "" ? score_data : "") + "]";
                if (target_para == "[]")
                    target_para = "";
                lightning = "execute as @a"+player_data+" at @s run execute as @e[type="+entity_id+"] at @s run summon minecraft:lightning_bolt";
            }
            result.Add(lightning+"\r\n");
            return result;
        }

        /// <summary>
        /// 事件:得到药水效果
        /// </summary>
        /// <param name="event_data"></param>
        /// <param name="condition_parameter"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public List<string> GetEffect(UserControl event_ctl, string condition_parameter, string version)
        {
            result.Clear();
            string tag_value = "";
            string score_name = "";
            int score_value = 0;
            string effect_id = "";
            int second =0;
            int level = 0;
            foreach (Control item in event_ctl.Controls)
            {
                if(item is ComboBox)
                {
                    ComboBox this_obj = item as ComboBox;
                    effect_id = this_obj.Text;
                }
                if(item is NumericUpDown && item.Name == "second")
                {
                    NumericUpDown this_obj = item as NumericUpDown;
                    second = (int)this_obj.Value;
                }
                if(item is NumericUpDown && item.Name == "level")
                {
                    NumericUpDown this_obj = item as NumericUpDown;
                    level = (int)this_obj.Value;
                }
            }
            if (condition_parameter.Contains(","))
            {
                tag_value = condition_parameter.Split(',')[0].Split(':')[1];
                if (!Regex.Match(condition_parameter.Split(',')[1], "[\u4E00-\u9FA5]{0,}").Success)
                {
                score_name = condition_parameter.Split(',')[1].Split(':')[1];
                score_value = int.Parse(condition_parameter.Split(',')[1].Split(':')[2]);
                }

            }
            else
            {
                if (condition_parameter.Split(':')[0] == "Tag")
                    tag_value = condition_parameter.Split(':')[1];
                if (condition_parameter.Split(':')[0] == "Scb")
                {
                    score_name = condition_parameter.Split(':')[1];
                    score_value = int.Parse(condition_parameter.Split(':')[2]);
                }
            }
            string tag_data = tag_value != "" ? "tag=" + tag_value : "";
            if (version == "1.12")
            {
                string score_data = score_name != "" ? "scores_"+score_name+"_min="+score_value : "";
                string target_para = "[" + (tag_data != "" ? tag_data : "") + (score_data != "" ? "," + score_data : "") + "]";
                if (target_para == "[]")
                    target_para = "";
                string get_effect = "effect @e"+target_para+" "+ effect_id + " "+ second + " "+ level;
                result.Add(get_effect+"\r\n");
            }
            else
                if(version == "1.13")
            {
                string score_data = score_name != "" ? "scores={" + score_name + "=" + score_value + "..}" : "";
                string target_para = "[" + (tag_data != "" ? tag_data : "") + (score_data != "" ? "," + score_data : "") + "]";
                if (target_para == "[]")
                    target_para = "";
                string get_effect = "effect give @e" + target_para + " " + effect_id + " " + second + " " + level;
                result.Add(get_effect + "\r\n");
            }
            return result;
        }

        /// <summary>
        /// 事件:播放粒子效果
        /// </summary>
        /// <param name="event_data"></param>
        /// <param name="condition_parameter"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public List<string> ParticleEffect(UserControl event_ctl, string condition_parameter, string version)
        {
            result.Clear();
            string tag_value = "";
            string score_name = "";
            int score_value = 0;
            string particle_id = "";
            foreach (Control item in event_ctl.Controls)
            {
                if (item is ComboBox)
                {
                    ComboBox this_obj = item as ComboBox;
                    particle_id = this_obj.Text;
                    break;
                }
            }
            if (condition_parameter.Contains(","))
            {
                tag_value = condition_parameter.Split(',')[0].Split(':')[1];
                if (!Regex.Match(condition_parameter.Split(',')[1], "[\u4E00-\u9FA5]{0,}").Success)
                {
                score_name = condition_parameter.Split(',')[1].Split(':')[1];
                score_value = int.Parse(condition_parameter.Split(',')[1].Split(':')[2]);
                }

            }
            else
            {
                if (condition_parameter.Split(':')[0] == "Tag")
                    tag_value = condition_parameter.Split(':')[1];
                if (condition_parameter.Split(':')[0] == "Scb")
                {
                    score_name = condition_parameter.Split(':')[1];
                    score_value = int.Parse(condition_parameter.Split(':')[2]);
                }
            }
            string tag_data = tag_value != "" ? "tag=" + tag_value : "";
            if(version == "1.12")
            {
                string score_data = score_name != "" ? ",scores_" + score_name + "_min=" + score_value : "";
                string target_para = "[" + (tag_data != "" ? tag_data : "") + (score_data != "" ?  score_data : "") + "]";
                if (target_para == "[]")
                    target_para = "";
                string particle_play = "execute @e"+target_para+" ~ ~ ~ particle "+ particle_id + " ~ ~ ~ 0.1 0.1 0.1 0 1 force @a";
                result.Add(particle_play+"\r\n");
            }
            else
                if(version == "1.13")
            {
                string score_data = score_name != "" ? ",scores={" + score_name + "=" + score_value + "..}" : "";
                string target_para = "[" + (tag_data != "" ? tag_data : "") + (score_data != "" ?  score_data : "") + "]";
                if (target_para == "[]")
                    target_para = "";
                string particle_play = "execute as @e"+ target_para + " at @s run particle " + particle_id + " ~ ~ ~ 0.1 0.1 0.1 0 1 force @a";
                result.Add(particle_play + "\r\n");
            }
            return result;
        }

        /// <summary>
        /// 事件:随机传送
        /// </summary>
        /// <param name="event_data"></param>
        /// <param name="condition_parameter"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public List<string> SpreadTeleport(UserControl event_ctl, string condition_parameter, string version)
        {
            result.Clear();
            string tag_value = "";
            string score_name = "";
            int score_value = 0;
            int spreadDistance = 0;
            int maxRange = 0;
            int under = 0;
            foreach (Control item in event_ctl.Controls)
            {
                if(item is NumericUpDown && item.Name == "spreadDistance")
                {
                    NumericUpDown this_obj = item as NumericUpDown;
                    spreadDistance = (int)this_obj.Value;
                }
                if (item is NumericUpDown && item.Name == "maxRange")
                {
                    NumericUpDown this_obj = item as NumericUpDown;
                    maxRange = (int)this_obj.Value;
                }
                if (item is NumericUpDown && item.Name == "under")
                {
                    NumericUpDown this_obj = item as NumericUpDown;
                    under = (int)this_obj.Value;
                }
            }
            if (condition_parameter.Contains(","))
            {
                tag_value = condition_parameter.Split(',')[0].Split(':')[1];
                if (!Regex.Match(condition_parameter.Split(',')[1], "[\u4E00-\u9FA5]{0,}").Success)
                {
                    score_name = condition_parameter.Split(',')[1].Split(':')[1];
                    score_value = int.Parse(condition_parameter.Split(',')[1].Split(':')[2]);
                }
            }
            else
            {
                if (condition_parameter.Split(':')[0] == "Tag")
                    tag_value = condition_parameter.Split(':')[1];
                if (condition_parameter.Split(':')[0] == "Scb")
                {
                    score_name = condition_parameter.Split(':')[1];
                    score_value = int.Parse(condition_parameter.Split(':')[2]);
                }
            }
            string tag_data = tag_value != "" ? "tag=" + tag_value : "";

            if (version == "1.12")
            {
                string score_data = score_name != "" ? "scores_" + score_name + "_min=" + score_value : "";
                string target_para = "[" + (tag_data != "" ? tag_data : "") + (score_data != "" ? "," + score_data : "") + "]";
                if (target_para == "[]")
                    target_para = "";
                string particle_play = "spreadplayers ~ ~ "+ spreadDistance+ " "+ maxRange + " false @e"+target_para;
                result.Add(particle_play + "\r\n");
            }
            else
            if (version == "1.13")
            {
                string score_data = score_name != "" ? "scores={" + score_name + "=" + score_value + "..}" : "";
                string target_para = "[" + (tag_data != "" ? tag_data : "") + (score_data != "" ? "," + score_data : "") + "]";
                if (target_para == "[]")
                    target_para = "";
                string particle_play = "";
                if (under == -1)
                particle_play = "spreadplayers ~ ~ " + spreadDistance + " " + maxRange + " false @e" + target_para;
                else
                    particle_play = "spreadplayers ~ ~ " + spreadDistance + " " + maxRange + "under "+ under + " false @e" + target_para;
                result.Add(particle_play + "\r\n");
            }
            return result;
        }
    }
}
