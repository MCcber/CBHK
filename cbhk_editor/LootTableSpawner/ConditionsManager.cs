using cbhk_editor.LootTableSpawner.condition_components;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner
{
    class ConditionsManager
    {
        public Control BlockStateProperty()
        {
            block_state_property bsp = new block_state_property();
            return bsp.table;
        }

        public Control DamageSourceProperties()
        {
            damage_source_properties dsp = new damage_source_properties();
            return dsp.table;
        }

        public Control EntityProperties()
        {
            entity_properties ep = new entity_properties();
            return ep.table;
        }

        public Control EntityScore()
        {
            entity_scores es = new entity_scores();
            return es.table;
        }

        public Control LocationCheck()
        {
            location_check lc = new location_check();
            return lc.table;
        }

        public Control MatchTool()
        {
            match_tool mt = new match_tool();
            return mt.set_item;
        }

        public Control RandomChance()
        {
            random_chance rc = new random_chance();
            return rc.table;
        }

        public Control RandomChanceWithLooting()
        {
            random_chance_with_looting rcwl = new random_chance_with_looting();
            return rcwl.table;
        }

        public Control Reference()
        {
            reference rf = new reference();
            return rf.table;
        }

        public Control TableBonus()
        {
            table_bonus tb = new table_bonus();
            return tb.table;
        }

        public Control TimeCheck()
        {
            time_check tc = new time_check();
            return tc.table;
        }

        public Control WeatherCheck()
        {
            weather_check wc = new weather_check();
            return wc.table;
        }
    }
}
