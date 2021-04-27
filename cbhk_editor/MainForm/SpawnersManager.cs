using System.Media;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using ArmorStand;
using cbhk_editor.AdvancementSpawner;
using cbhk_editor.CustomCarverSpawner;
using cbhk_editor.CustomBiomeSpawner;
using cbhk_editor.DatapackSpawner;
using cbhk_editor.DimensionSpawner;
using cbhk_editor.EntitySpawner;
using cbhk_editor.FireWorkSpawner;
using cbhk_editor.ItemSpawner;
using cbhk_editor.LootTableSpawner;
using cbhk_editor.RecipeSpawner;
using cbhk_editor.SkillSpawner;
using cbhk_editor.SpawnerSpawner;
using cbhk_editor.TagSpawner;
using cbhk_editor.VillagerSpawner;
using cbhk_editor.WrittrenBookSpawner;
using cbhk_editor.SurfaceBuilderSpawner;

namespace cbhk_editor.MainForm
{
    class SpawnersManager
    {
        //技能生成器
        public void SkillSpawner(Form obj, SoundPlayer click_sound)
        {
            skill_ui skill_form = new skill_ui(obj,click_sound);
            skill_form.Show();
        }
        //数据包生成器
        public void DatapackSpawner(Form obj,SoundPlayer click_sound)
        {
            Datapack_ui datapack_Ui = new Datapack_ui(obj,click_sound);
            datapack_Ui.Show();
        }
        //盔甲架生成器
        public void ArmorStandSpawner(Form obj, SoundPlayer click_sound)
        {
            Window as_form = new ArmorStandForm(obj);
            ElementHost.EnableModelessKeyboardInterop(as_form);
            as_form.Show();
        }
        //成书生成器
        public void WrittenBookSpawner(Form obj, SoundPlayer click_sound)
        {
            written_book_spawner written_Book_Spawner = new written_book_spawner(obj,click_sound);
            written_Book_Spawner.Show();
        }
        //战利品表生成器
        public void LootTableSpawner(Form obj, SoundPlayer click_sound)
        {
            lt_spawner lt_Spawner = new lt_spawner(obj,click_sound);
            lt_Spawner.Show();
        }
        //刷怪笼生成器
        public void SpawnerSpawner(Form obj, SoundPlayer click_sound)
        {
            spawner_spawner sp_sp = new spawner_spawner(obj,click_sound);
            sp_sp.Show();
        }
        //配方生成器
        public void RecipesSpawner(Form obj, SoundPlayer click_sound)
        {
            recipe_spawner recipe = new recipe_spawner(obj,click_sound);
            recipe.Show();
        }
        //村民生成器
        public void VillagerSpawner(Form obj, SoundPlayer click_sound)
        {
            villager_spawner villager_Spawner = new villager_spawner(obj,click_sound);
            villager_Spawner.Show();
        }
        //进度生成器
        public void AdvancementsSpawner(Form obj, SoundPlayer click_sound)
        {
            advancement_spawner ads = new advancement_spawner(obj,click_sound);
            ads.Show();
        }
        //标签生成器
        public void TagSpawner(Form obj, SoundPlayer click_sound)
        {
            tag_spawner tag_Spawner = new tag_spawner(obj,click_sound);
            tag_Spawner.Show();
        }
        //物品生成器
        public void ItemSpawner(Form obj, SoundPlayer click_sound)
        {
            Item_spawner itemspawner = new Item_spawner(obj,click_sound);
            itemspawner.Show();
        }
        //烟花火箭生成器
        public void FireWorkSpawner(Form obj, SoundPlayer click_sound)
        {
            firework_spawner firework = new firework_spawner(obj,click_sound);
            firework.Show();
        }
        //实体生成器
        public void EntitySpawner(Form obj, SoundPlayer click_sound)
        {
            entity_spawner Entity = new entity_spawner(obj,click_sound);
            Entity.Show();
        }
        //维度生成器
        public void Dimension(Form obj, SoundPlayer click_sound)
        {
            dimension_spawner ds = new dimension_spawner(obj,click_sound);
            ds.Show();
        }
        //生物群系生成器
        public void BiomeSpawner(Form obj,SoundPlayer click_sound)
        {
            biome_spawner bs = new biome_spawner(obj,click_sound);
            bs.Show();
        }
        //雕刻器生成器
        public void CarverSpawner(Form obj, SoundPlayer click_sound)
        {
            carver_spawner cs = new carver_spawner(obj,click_sound);
            cs.Show();
        }
        //地表生成器
        public void SurfaceBuilderSpawner(Form obj,SoundPlayer click_sound)
        {
            surface_builder_spawner sbs = new surface_builder_spawner(obj,click_sound);
            sbs.Show();
        }
    }
}
