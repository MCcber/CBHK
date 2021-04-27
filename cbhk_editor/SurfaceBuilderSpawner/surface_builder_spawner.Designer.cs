
namespace cbhk_editor.SurfaceBuilderSpawner
{
    partial class surface_builder_spawner
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("type:default");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Name:");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Properties");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("top_material", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Name:");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Properties");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("under_material", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Name:");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Properties");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("underwater_material", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("config", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("SurfaceBuilder", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode11});
            this.surface_builder_title_menu = new System.Windows.Forms.MenuStrip();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.生成返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_spawn = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_return = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.surface_builder_view = new System.Windows.Forms.TreeView();
            this.surface_builder_rclick_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.add_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.surface_builder_title_menu.SuspendLayout();
            this.surface_builder_rclick_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // surface_builder_title_menu
            // 
            this.surface_builder_title_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.surface_builder_title_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑ToolStripMenuItem,
            this.生成返回ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.surface_builder_title_menu.Location = new System.Drawing.Point(0, 0);
            this.surface_builder_title_menu.Name = "surface_builder_title_menu";
            this.surface_builder_title_menu.Size = new System.Drawing.Size(474, 25);
            this.surface_builder_title_menu.TabIndex = 0;
            this.surface_builder_title_menu.Text = "menuStrip1";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add,
            this.delete,
            this.clear});
            this.编辑ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // add
            // 
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 22);
            this.add.Text = "添加";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 22);
            this.delete.Text = "删除";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // clear
            // 
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(100, 22);
            this.clear.Text = "清空";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // 生成返回ToolStripMenuItem
            // 
            this.生成返回ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.click_to_spawn,
            this.click_to_return});
            this.生成返回ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.生成返回ToolStripMenuItem.Name = "生成返回ToolStripMenuItem";
            this.生成返回ToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.生成返回ToolStripMenuItem.Text = "生成-返回";
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
            this.about});
            this.关于ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.关于ToolStripMenuItem.Text = "帮助&H";
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(160, 22);
            this.about.Text = "关于地表生成器";
            // 
            // surface_builder_view
            // 
            this.surface_builder_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.surface_builder_view.ContextMenuStrip = this.surface_builder_rclick_menu;
            this.surface_builder_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.surface_builder_view.ForeColor = System.Drawing.Color.White;
            this.surface_builder_view.Location = new System.Drawing.Point(0, 25);
            this.surface_builder_view.Name = "surface_builder_view";
            treeNode1.Name = "value:tag";
            treeNode1.Tag = "default,mountain,shattered_savanna,gravelly_mountain,giant_tree_taiga,swamp,badla" +
    "nds,wooded_badlands,eroded_badlands,frozen_ocean,nether,nether_forest,soul_sand_" +
    "valley, basalt_deltas,nope";
            treeNode1.Text = "type:default";
            treeNode2.Name = "value:tag";
            treeNode2.Text = "Name:";
            treeNode3.Name = "parent_node";
            treeNode3.Text = "Properties";
            treeNode4.Name = "parent_node";
            treeNode4.Text = "top_material";
            treeNode5.Name = "value:tag";
            treeNode5.Text = "Name:";
            treeNode6.Name = "parent_node";
            treeNode6.Text = "Properties";
            treeNode7.Name = "parent_node";
            treeNode7.Text = "under_material";
            treeNode8.Name = "value:tag";
            treeNode8.Text = "Name:";
            treeNode9.Name = "parent_node";
            treeNode9.Text = "Properties";
            treeNode10.Name = "parent_node";
            treeNode10.Text = "underwater_material";
            treeNode11.Name = "parent_node";
            treeNode11.Text = "config";
            treeNode12.Name = "root_node";
            treeNode12.Text = "SurfaceBuilder";
            this.surface_builder_view.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.surface_builder_view.Size = new System.Drawing.Size(474, 337);
            this.surface_builder_view.TabIndex = 1;
            this.surface_builder_view.MouseDown += new System.Windows.Forms.MouseEventHandler(this.surface_builder_view_MouseDown);
            // 
            // surface_builder_rclick_menu
            // 
            this.surface_builder_rclick_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_menu,
            this.delete_menu,
            this.clear_menu});
            this.surface_builder_rclick_menu.Name = "surface_builder_rclick_menu";
            this.surface_builder_rclick_menu.Size = new System.Drawing.Size(130, 70);
            // 
            // add_menu
            // 
            this.add_menu.Name = "add_menu";
            this.add_menu.Size = new System.Drawing.Size(129, 22);
            this.add_menu.Text = "添加/修改";
            this.add_menu.Click += new System.EventHandler(this.add_menu_Click);
            // 
            // delete_menu
            // 
            this.delete_menu.Name = "delete_menu";
            this.delete_menu.Size = new System.Drawing.Size(129, 22);
            this.delete_menu.Text = "删除";
            this.delete_menu.Click += new System.EventHandler(this.delete_menu_Click);
            // 
            // clear_menu
            // 
            this.clear_menu.Name = "clear_menu";
            this.clear_menu.Size = new System.Drawing.Size(129, 22);
            this.clear_menu.Text = "清空";
            this.clear_menu.Click += new System.EventHandler(this.clear_menu_Click);
            // 
            // surface_builder_spawner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(474, 362);
            this.Controls.Add(this.surface_builder_view);
            this.Controls.Add(this.surface_builder_title_menu);
            this.MainMenuStrip = this.surface_builder_title_menu;
            this.Name = "surface_builder_spawner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "地表生成器";
            this.surface_builder_title_menu.ResumeLayout(false);
            this.surface_builder_title_menu.PerformLayout();
            this.surface_builder_rclick_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip surface_builder_title_menu;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.ToolStripMenuItem clear;
        private System.Windows.Forms.ToolStripMenuItem 生成返回ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem click_to_spawn;
        private System.Windows.Forms.ToolStripMenuItem click_to_return;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.TreeView surface_builder_view;
        private System.Windows.Forms.ContextMenuStrip surface_builder_rclick_menu;
        private System.Windows.Forms.ToolStripMenuItem add_menu;
        private System.Windows.Forms.ToolStripMenuItem delete_menu;
        private System.Windows.Forms.ToolStripMenuItem clear_menu;
    }
}