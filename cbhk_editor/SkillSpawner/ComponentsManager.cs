using System.Windows.Forms;
using cbhk_editor.SkillSpawner.ConditionCompnents.Item;
using cbhk_editor.SkillSpawner.ConditionCompnents.Entity;
using cbhk_editor.SkillSpawner.EventsCompnents;

namespace cbhk_editor.SkillSpawner
{
    class ComponentsManager
    {
        /// <summary>
        /// 条件:拥有物品
        /// </summary>
        /// <returns></returns>
       public UserControl HaveItem()
        {
            HaveItems have_item = new HaveItems();
            return have_item;
        }

        /// <summary>
        /// 条件:手持物品
        /// </summary>
        /// <returns></returns>
        public UserControl Selected_Item()
        {
            SelectedItem selectedItem = new SelectedItem();
            return selectedItem;
        }

        /// <summary>
        /// 条件:按Q丢弃物品
        /// </summary>
        /// <returns></returns>
        public UserControl DropedItem()
        {
            DropItemByQKey dropItemByQKey = new DropItemByQKey();
            return dropItemByQKey;
        }

        /// <summary>
        /// 条件:选择物品并按F键
        /// </summary>
        /// <returns></returns>
        public UserControl SelectedItemFKey()
        {
            return Selected_Item();
        }

        /// <summary>
        /// 条件:穿戴物品
        /// </summary>
        /// <returns></returns>
        public UserControl Wear_Item()
        {
            WearItem wearItem = new WearItem();
            return wearItem;
        }

        /// <summary>
        /// 条件:手持物品并攻击玩家
        /// </summary>
        /// <returns></returns>
        public UserControl AttackPlayerWithItem()
        {
            return Selected_Item();
        }

        /// <summary>
        /// 条件:手持物品并攻击实体
        /// </summary>
        /// <returns></returns>
        public UserControl AttackEntityWithItem()
        {
            return Selected_Item();
        }

        /// <summary>
        /// 条件:受到N点伤害
        /// </summary>
        /// <returns></returns>
        public UserControl Hurted_Damage()
        {
            HurtedDamage hurtedDamage = new HurtedDamage();
            return hurtedDamage;
        }

        /// <summary>
        /// 条件:被玩家攻击
        /// </summary>
        public UserControl HurtedByPlayer()
        {
            EveryHurted everyHurted = new EveryHurted();
            return everyHurted;
        }


        /// <summary>
        /// 条件:每延迟N秒
        /// </summary>
        /// <returns></returns>
        public UserControl Delay_Times()
        {
            DelayTimes delayTimes = new DelayTimes();
            return delayTimes;
        }

        /// <summary>
        /// 事件:召唤实体
        /// </summary>
        /// <returns></returns>
        public UserControl Summon_Entity()
        {
            SummonEntity summonEntity = new SummonEntity();
            return summonEntity;
        }

        /// <summary>
        /// 事件:被雷击
        /// </summary>
        /// <returns></returns>
        public UserControl Struck_By_Lightning()
        {
            StruckByLightning struckByLightning = new StruckByLightning();
            return struckByLightning;
        }

        /// <summary>
        /// 事件:得到药水效果
        /// </summary>
        /// <returns></returns>
        public UserControl Get_Effect()
        {
            GetEffect getEffect = new GetEffect();
            return getEffect;
        }

        /// <summary>
        /// 事件:播放粒子效果
        /// </summary>
        /// <returns></returns>
        public UserControl Particle_Effect()
        {
            ParticleEffect particleEffect = new ParticleEffect();
            return particleEffect;
        }

        /// <summary>
        /// 事件:随机传送
        /// </summary>
        /// <returns></returns>
        public UserControl Spread_Teleport()
        {
            SpreadTeleport spreadTeleport = new SpreadTeleport();
            return spreadTeleport;
        }
    }
}
