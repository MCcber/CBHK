using cbhk_editor.LootTableSpawner.function_components;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner
{
    class FunctionsManager
    {
        public Control ApplyBonus()
        {
            apply_bonus ab = new apply_bonus();
            return ab.table;
        }

        public Control CopyNbt()
        {
            copy_nbt cn = new copy_nbt();
            return cn.set_nbt;
        }

        public Control CopyState()
        {
            copy_state cs = new copy_state();
            return cs.table;
        }

        public Control EnchantRandomly()
        {
            enchant_randomly er = new enchant_randomly();
            return er.enchant_list_box;
        }

        public Control EnchantWithLevels()
        {
            enchant_with_levels ewl = new enchant_with_levels();
            return ewl.table;
        }

        public Control ExplorationMap()
        {
            exploration_map em = new exploration_map();
            return em.table;
        }

        public Control FillPlayerHead()
        {
            fill_player_head fph = new fill_player_head();
            return fph.table;
        }

        public Control LimitCount()
        {
            limit_count lc = new limit_count();
            return lc.table;
        }

        public Control LootingEnchant()
        {
            looting_enchant le = new looting_enchant();
            return le.table;
        }

        public Control SetAttributes()
        {
            set_attributes sa = new set_attributes();
            return sa.table;
        }

        public Control SetContents()
        {
            set_contents sc = new set_contents();
            return sc.table;
        }

        public Control SetCount()
        {
            set_count sc = new set_count();
            return sc.table;
        }

        public Control SetDamage()
        {
            set_damage sd = new set_damage();
            return sd.table;
        }

        public Control SetLore()
        {
            set_lore sl = new set_lore();
            return sl.table;
        }

        public Control SetName()
        {
            set_name sn = new set_name();
            return sn.table;
        }

        public Control SetNbt()
        {
            set_nbt sn = new set_nbt();
            return sn.nbt_box;
        }

        public Control SetStewEffect()
        {
            set_stew_effect sse = new set_stew_effect();
            return sse.set_stew_effect_btn;
        }

        public Control SetLootTable()
        {
            set_loot_table slt = new set_loot_table();
            return slt.table;
        }
    }
}
