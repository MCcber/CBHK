
namespace cbhk_editor.CustomBiomeSpawner
{
    partial class biome_spawner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("depth:");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("scale:");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("temperature:");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("downfall:");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("precipitation:");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("category:");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("sky_color:");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("fog_color:");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("water_color:");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("water_fog_color:");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("foliage_color:");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("type:");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("options", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("probability:");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("particle", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("ambient_sound:");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("sound:");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("tick_delay:");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("block_search_extent:");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("offset:");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("mood_sound", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("sound:");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("tick_chance:");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("additions_sound", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("sound:");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("min_delay:");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("max_delay:");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("replace_current_music:");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("music", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("effects", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode15,
            treeNode16,
            treeNode21,
            treeNode24,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("surface_builder:");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("air");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("liquid");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("carvers", new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode33});
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("features");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("starts");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("spawners");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("player_spawn_friendly:");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("creature_spawn_probability:");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("parent");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("spawn_costs");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("biomes", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode30,
            treeNode31,
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode41});
            this.biome_title_menu = new System.Windows.Forms.MenuStrip();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.生成返回RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_spawn = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_return = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于群系生成器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biome_rclick_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.add_rclick = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_rclick = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_rclick = new System.Windows.Forms.ToolStripMenuItem();
            this.biomes_view = new System.Windows.Forms.TreeView();
            this.biome_title_menu.SuspendLayout();
            this.biome_rclick_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // biome_title_menu
            // 
            this.biome_title_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.biome_title_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑EToolStripMenuItem,
            this.生成返回RToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.biome_title_menu.Location = new System.Drawing.Point(0, 0);
            this.biome_title_menu.Name = "biome_title_menu";
            this.biome_title_menu.Size = new System.Drawing.Size(526, 25);
            this.biome_title_menu.TabIndex = 0;
            this.biome_title_menu.Text = "menuStrip1";
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add,
            this.delete,
            this.clear});
            this.编辑EToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.编辑EToolStripMenuItem.Text = "编辑&E";
            // 
            // add
            // 
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(129, 22);
            this.add.Text = "添加/修改";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(129, 22);
            this.delete.Text = "删除";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // clear
            // 
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(129, 22);
            this.clear.Text = "清空";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // 生成返回RToolStripMenuItem
            // 
            this.生成返回RToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.click_to_spawn,
            this.click_to_return});
            this.生成返回RToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.生成返回RToolStripMenuItem.Name = "生成返回RToolStripMenuItem";
            this.生成返回RToolStripMenuItem.Size = new System.Drawing.Size(81, 21);
            this.生成返回RToolStripMenuItem.Text = "生成-返回&R";
            // 
            // click_to_spawn
            // 
            this.click_to_spawn.Name = "click_to_spawn";
            this.click_to_spawn.Size = new System.Drawing.Size(100, 22);
            this.click_to_spawn.Text = "生成";
            this.click_to_spawn.Click += new System.EventHandler(this.click_to_spawn_Click);
            // 
            // click_to_return
            // 
            this.click_to_return.Name = "click_to_return";
            this.click_to_return.Size = new System.Drawing.Size(100, 22);
            this.click_to_return.Text = "返回";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于群系生成器ToolStripMenuItem});
            this.关于ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 关于群系生成器ToolStripMenuItem
            // 
            this.关于群系生成器ToolStripMenuItem.Name = "关于群系生成器ToolStripMenuItem";
            this.关于群系生成器ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.关于群系生成器ToolStripMenuItem.Text = "关于群系生成器";
            // 
            // biome_rclick_menu
            // 
            this.biome_rclick_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_rclick,
            this.delete_rclick,
            this.clear_rclick});
            this.biome_rclick_menu.Name = "biome_rclick_menu";
            this.biome_rclick_menu.Size = new System.Drawing.Size(130, 70);
            // 
            // add_rclick
            // 
            this.add_rclick.Name = "add_rclick";
            this.add_rclick.Size = new System.Drawing.Size(129, 22);
            this.add_rclick.Text = "添加/修改";
            this.add_rclick.Click += new System.EventHandler(this.add_rclick_Click);
            // 
            // delete_rclick
            // 
            this.delete_rclick.Name = "delete_rclick";
            this.delete_rclick.Size = new System.Drawing.Size(129, 22);
            this.delete_rclick.Text = "删除";
            this.delete_rclick.Click += new System.EventHandler(this.delete_rclick_Click);
            // 
            // clear_rclick
            // 
            this.clear_rclick.Name = "clear_rclick";
            this.clear_rclick.Size = new System.Drawing.Size(129, 22);
            this.clear_rclick.Text = "清空";
            this.clear_rclick.Click += new System.EventHandler(this.clear_rclick_Click);
            // 
            // biomes_view
            // 
            this.biomes_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.biomes_view.ContextMenuStrip = this.biome_rclick_menu;
            this.biomes_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.biomes_view.ForeColor = System.Drawing.Color.White;
            this.biomes_view.Location = new System.Drawing.Point(0, 25);
            this.biomes_view.Name = "biomes_view";
            treeNode1.Name = "value:float";
            treeNode1.Text = "depth:";
            treeNode2.Name = "value:float";
            treeNode2.Text = "scale:";
            treeNode3.Name = "value:float";
            treeNode3.Text = "temperature:";
            treeNode4.Name = "value:float";
            treeNode4.Text = "downfall:";
            treeNode5.Name = "value:string";
            treeNode5.Tag = "none,rain,snow";
            treeNode5.Text = "precipitation:";
            treeNode6.Name = "value:string";
            treeNode6.Tag = "none,taiga,extreme_hills,jungle,mesa,plains,savanna,icy,the_end,beach,forest,ocea" +
    "n,desert,river,swamp,mushroom,nether";
            treeNode6.Text = "category:";
            treeNode7.Name = "value:int";
            treeNode7.Text = "sky_color:";
            treeNode8.Name = "value:int";
            treeNode8.Text = "fog_color:";
            treeNode9.Name = "value:int";
            treeNode9.Text = "water_color:";
            treeNode10.Name = "value:int";
            treeNode10.Text = "water_fog_color:";
            treeNode11.Name = "value:int";
            treeNode11.Text = "foliage_color:";
            treeNode12.Name = "value:string";
            treeNode12.Tag = "block,falling_dust,dust,item";
            treeNode12.Text = "type:";
            treeNode13.Name = "parent_node";
            treeNode13.Text = "options";
            treeNode14.Name = "value:float";
            treeNode14.Text = "probability:";
            treeNode15.Name = "节点13";
            treeNode15.Text = "particle";
            treeNode16.Name = "value:string";
            treeNode16.Text = "ambient_sound:";
            treeNode17.Name = "value:string";
            treeNode17.Text = "sound:";
            treeNode18.Name = "value:int";
            treeNode18.Text = "tick_delay:";
            treeNode19.Name = "value:int";
            treeNode19.Text = "block_search_extent:";
            treeNode20.Name = "value:double";
            treeNode20.Text = "offset:";
            treeNode21.Name = "parent_node";
            treeNode21.Text = "mood_sound";
            treeNode22.Name = "value:string";
            treeNode22.Text = "sound:";
            treeNode23.Name = "value:double";
            treeNode23.Text = "tick_chance:";
            treeNode24.Name = "parent_node";
            treeNode24.Text = "additions_sound";
            treeNode25.Name = "value:string";
            treeNode25.Text = "sound:";
            treeNode26.Name = "value:int";
            treeNode26.Text = "min_delay:";
            treeNode27.Name = "value:int";
            treeNode27.Text = "max_delay:";
            treeNode28.Name = "value:bool";
            treeNode28.Text = "replace_current_music:";
            treeNode29.Name = "parent_node";
            treeNode29.Text = "music";
            treeNode30.Name = "parent_node";
            treeNode30.Text = "effects";
            treeNode31.Name = "value:tag";
            treeNode31.Text = "surface_builder:";
            treeNode32.Name = "list_node";
            treeNode32.Text = "air";
            treeNode33.Name = "list_node";
            treeNode33.Text = "liquid";
            treeNode34.Name = "parent_node";
            treeNode34.Text = "carvers";
            treeNode35.Name = "list_node";
            treeNode35.Text = "features";
            treeNode36.Name = "list_node";
            treeNode36.Text = "starts";
            treeNode37.Name = "objects_node";
            treeNode37.Tag = "monster,creature,ambient,water_creature,water_ambient,misc";
            treeNode37.Text = "spawners";
            treeNode38.Name = "value:bool";
            treeNode38.Text = "player_spawn_friendly:";
            treeNode39.Name = "value:bool";
            treeNode39.Text = "creature_spawn_probability:";
            treeNode40.Name = "value:tag";
            treeNode40.Tag = "";
            treeNode40.Text = "parent";
            treeNode41.Name = "objects_node";
            treeNode41.Text = "spawn_costs";
            treeNode42.Name = "root_node";
            treeNode42.Text = "biomes";
            this.biomes_view.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode42});
            this.biomes_view.Size = new System.Drawing.Size(526, 390);
            this.biomes_view.TabIndex = 1;
            this.biomes_view.MouseDown += new System.Windows.Forms.MouseEventHandler(this.biomes_view_MouseDown);
            // 
            // biome_spawner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(526, 415);
            this.Controls.Add(this.biomes_view);
            this.Controls.Add(this.biome_title_menu);
            this.MainMenuStrip = this.biome_title_menu;
            this.Name = "biome_spawner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生物群系生成器";
            this.biome_title_menu.ResumeLayout(false);
            this.biome_title_menu.PerformLayout();
            this.biome_rclick_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip biome_title_menu;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成返回RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem click_to_spawn;
        private System.Windows.Forms.ToolStripMenuItem click_to_return;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于群系生成器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.ToolStripMenuItem clear;
        private System.Windows.Forms.ContextMenuStrip biome_rclick_menu;
        private System.Windows.Forms.ToolStripMenuItem add_rclick;
        private System.Windows.Forms.ToolStripMenuItem delete_rclick;
        private System.Windows.Forms.ToolStripMenuItem clear_rclick;
        private System.Windows.Forms.TreeView biomes_view;
    }
}