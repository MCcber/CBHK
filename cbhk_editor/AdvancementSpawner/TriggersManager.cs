using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner
{
    class TriggersManager
    {
        public Control BeeNestDestroyed()
        {
            triggers.bee_nest_destroyed.bee_nest_destoryed_page bndp = new triggers.bee_nest_destroyed.bee_nest_destoryed_page();
            return bndp.table;
        }

        public Control BredAnimals()
        {
            triggers.bred_animals.bred_animals_page bap = new triggers.bred_animals.bred_animals_page();
            return bap.table;
        }

        public Control BrewedPotion()
        {
            triggers.brewed_potion.brewed_potion_page bpp = new triggers.brewed_potion.brewed_potion_page();
            return bpp.table;
        }

        public Control ChangedDimension()
        {
            triggers.changed_dimension.changed_dimension_page cdp = new triggers.changed_dimension.changed_dimension_page();
            return cdp.table;
        }

        public Control ChanneledLightning()
        {
            triggers.channeled_lightning.channeled_lightning_page clp = new triggers.channeled_lightning.channeled_lightning_page();
            return clp.table;
        }

        public Control ConstructBeacon()
        {
            triggers.construct_beacon.construct_beacon_page cbp = new triggers.construct_beacon.construct_beacon_page();
            return cbp.table;
        }

        public Control ConsumeItem()
        {
            triggers.consume_item.consume_item_page cip = new triggers.consume_item.consume_item_page();
            return cip.table;
        }

        public Control CuredZombieVillager()
        {
            triggers.cured_zombie_villager.cured_zombie_villager_page cvp = new triggers.cured_zombie_villager.cured_zombie_villager_page();
            return cvp.table;
        }

        public Control effects_changed()
        {
            triggers.effects_changed.effects_changed_page ecp = new triggers.effects_changed.effects_changed_page();
            return ecp.table;
        }
        public Control enchanted_item()
        {
            triggers.enchanted_item.enchanted_item_page eip = new triggers.enchanted_item.enchanted_item_page();
            return eip.table;
        }
        public Control enter_block()
        {
            triggers.tool_forms.enter_block_page ebp = new triggers.tool_forms.enter_block_page();
            return ebp.table;
        }
        public Control entity_hurt_player()
        {
            triggers.entity_hurt_player.entity_hurt_player_page ehpp = new triggers.entity_hurt_player.entity_hurt_player_page();
            return ehpp.table;
        }

        public Control entity_killed_player()
        {
            triggers.entity_killed_player.entity_killed_player_page ekpp = new triggers.entity_killed_player.entity_killed_player_page();
            return ekpp.table;
        }
        public Control filled_bucket()
        {
            triggers.filled_bucket.filled_bucket_page fbp = new triggers.filled_bucket.filled_bucket_page();
            return fbp.table;
        }
        public Control fishing_rod_hooked()
        {
            triggers.fishing_rod_hooked.fishing_rod_hooked_page frhp = new triggers.fishing_rod_hooked.fishing_rod_hooked_page();
            return frhp.table;
        }
        public Control hero_of_the_village()
        {
            triggers.hero_of_the_village.hero_of_the_village_page hotvp = new triggers.hero_of_the_village.hero_of_the_village_page();
            return hotvp.table;
        }
        public Control inventory_changed()
        {
            triggers.inventory_changed.inventory_changed_page icp = new triggers.inventory_changed.inventory_changed_page();
            return icp.table;
        }
        public Control item_durability_changed()
        {
            triggers.item_durability_changed.item_durability_changed_page idcp = new triggers.item_durability_changed.item_durability_changed_page();
            return idcp.table;
        }
        public Control item_used_on_block()
        {
            triggers.item_used_on_block.item_used_on_block_page iuobp = new triggers.item_used_on_block.item_used_on_block_page();
            return iuobp.table;
        }
        public Control killed_by_crossbow()
        {
            triggers.killed_by_crossbow.killed_by_crossbow_page bycp = new triggers.killed_by_crossbow.killed_by_crossbow_page();
            return bycp.table;
        }
        public Control levitation()
        {
            triggers.levitation.levitation_page lp = new triggers.levitation.levitation_page();
            return lp.table;
        }
        public Control location()
        {
            triggers.location.location_page lp = new triggers.location.location_page();
            return lp.table;
        }
        public Control nether_travel()
        {
            triggers.nether_travel.nether_travel_page ntp = new triggers.nether_travel.nether_travel_page();
            return ntp.table;
        }
        public Control placed_block()
        {
            triggers.placed_block.placed_block_page pbp = new triggers.placed_block.placed_block_page();
            return pbp.table;
        }
        public Control player_generates_container_loot()
        {
            triggers.player_generates_container_loot.player_generates_container_loot_page pgcl = new triggers.player_generates_container_loot.player_generates_container_loot_page();
            return pgcl.table;
        }
        public Control player_hurt_entity()
        {
            triggers.player_hurt_entity.player_hurt_entity_page phep = new triggers.player_hurt_entity.player_hurt_entity_page();
            return phep.table;
        }
        public Control player_interacted_with_entity()
        {
            triggers.player_interacted_with_entity.player_interacted_with_entity_page piwe = new triggers.player_interacted_with_entity.player_interacted_with_entity_page();
            return piwe.table;
        }
        public Control player_killed_entity()
        {
            triggers.player_killed_entity.player_killed_entity_page pkep = new triggers.player_killed_entity.player_killed_entity_page();
            return pkep.table;
        }
        public Control recipe_unlocked()
        {
            triggers.recipe_unlocked.recipe_unlocked_page rup = new triggers.recipe_unlocked.recipe_unlocked_page();
            return rup.table;
        }
        public Control shot_crossbow()
        {
            triggers.shot_crossbow.shot_crossbow_page scp = new triggers.shot_crossbow.shot_crossbow_page();
            return scp.table;
        }
        public Control slept_in_bed()
        {
            triggers.slept_in_bed.slept_in_bed_page sibp = new triggers.slept_in_bed.slept_in_bed_page();
            return sibp.table;
        }
        public Control slide_down_block()
        {
            triggers.slide_down_block.slide_down_block_page sdbp = new triggers.slide_down_block.slide_down_block_page();
            return sdbp.table;
        }
        public Control summoned_entity()
        {
            triggers.summoned_entity.summoned_entity_page sep = new triggers.summoned_entity.summoned_entity_page();
            return sep.table;
        }
        public Control tame_animal()
        {
            triggers.tame_animal.tame_animal_page tap = new triggers.tame_animal.tame_animal_page();
            return tap.table;
        }
        public Control target_hit()
        {
            triggers.target_hit.target_hit_page thp = new triggers.target_hit.target_hit_page();
            return thp.table;
        }
        public Control thrown_item_picked_up_by_entity()
        {
            triggers.thrown_item_picked_up_by_entity.thrown_item_picked_up_by_entity_page tipibep = new triggers.thrown_item_picked_up_by_entity.thrown_item_picked_up_by_entity_page();
            return tipibep.table;
        }
        public Control tick()
        {
            triggers.tick.tick_page tp = new triggers.tick.tick_page();
            return tp.table;
        }
        public Control used_ender_eye()
        {
            triggers.used_ender_eye.used_ender_eye_page ueep = new triggers.used_ender_eye.used_ender_eye_page();
            return ueep.table;
        }
        public Control used_totem()
        {
            triggers.used_totem.used_totem_page utp = new triggers.used_totem.used_totem_page();
            return utp.table;
        }
        public Control villager_trade()
        {
            triggers.villager_trade.villager_trade_page vtp = new triggers.villager_trade.villager_trade_page();
            return vtp.table;
        }
        public Control voluntary_exile()
        {
            triggers.voluntary_exile.voluntary_exile_page vep = new triggers.voluntary_exile.voluntary_exile_page();
            return vep.table;
        }
    }
}
