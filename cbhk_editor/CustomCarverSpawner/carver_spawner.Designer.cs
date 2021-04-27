
namespace cbhk_editor.CustomCarverSpawner
{
    partial class carver_spawner
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("type:minecraft:underwater_cave");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("probability:");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("type:");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("y", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("type:");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("value:");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("yScale", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("absolute:");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("lava_level", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("debug_mode:false");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Name:");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Properties");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("air_state", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("debug_settings", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("config", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode7,
            treeNode9,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Carver", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode15});
            this.Carver_title_menu = new System.Windows.Forms.MenuStrip();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.生成返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_spawn = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_return = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于地形雕刻器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carver_view = new System.Windows.Forms.TreeView();
            this.Carver_rclick_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.add_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Carver_title_menu.SuspendLayout();
            this.Carver_rclick_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Carver_title_menu
            // 
            this.Carver_title_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Carver_title_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑EToolStripMenuItem,
            this.生成返回ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.Carver_title_menu.Location = new System.Drawing.Point(0, 0);
            this.Carver_title_menu.Name = "Carver_title_menu";
            this.Carver_title_menu.Size = new System.Drawing.Size(598, 25);
            this.Carver_title_menu.TabIndex = 0;
            this.Carver_title_menu.Text = "menuStrip1";
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
            this.关于地形雕刻器ToolStripMenuItem});
            this.关于ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 关于地形雕刻器ToolStripMenuItem
            // 
            this.关于地形雕刻器ToolStripMenuItem.Name = "关于地形雕刻器ToolStripMenuItem";
            this.关于地形雕刻器ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.关于地形雕刻器ToolStripMenuItem.Text = "关于地形雕刻器";
            // 
            // carver_view
            // 
            this.carver_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.carver_view.ContextMenuStrip = this.Carver_rclick_menu;
            this.carver_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carver_view.ForeColor = System.Drawing.Color.White;
            this.carver_view.Location = new System.Drawing.Point(0, 25);
            this.carver_view.Name = "carver_view";
            treeNode1.Name = "value:string";
            treeNode1.Tag = "minecraft:canyon,minecraft:cave,minecraft:nether_cave,minecraft:underwater_canyon" +
    ",minecraft:underwater_cave";
            treeNode1.Text = "type:minecraft:underwater_cave";
            treeNode2.Name = "value:float";
            treeNode2.Text = "probability:";
            treeNode3.Name = "value:string";
            treeNode3.Tag = "minecraft:constant,minecraft:uniform,minecraft:biased_to_bottom,minecraft:very_bi" +
    "ased_to_bottom,minecraft:trapezoid";
            treeNode3.Text = "type:";
            treeNode4.Name = "parent_node";
            treeNode4.Tag = "";
            treeNode4.Text = "y";
            treeNode5.Name = "value:string";
            treeNode5.Tag = "minecraft:constant,minecraft:uniform,minecraft:clamped_normal,minecraft:trapezoid" +
    "";
            treeNode5.Text = "type:";
            treeNode6.Name = "value:int";
            treeNode6.Text = "value:";
            treeNode7.Name = "parent_node";
            treeNode7.Text = "yScale";
            treeNode8.Name = "value:int";
            treeNode8.Text = "absolute:";
            treeNode9.Name = "parent_node";
            treeNode9.Tag = "absolute,above_bottom,below_top";
            treeNode9.Text = "lava_level";
            treeNode10.Name = "value:bool";
            treeNode10.Text = "debug_mode:false";
            treeNode11.Name = "value:tag";
            treeNode11.Text = "Name:";
            treeNode12.Name = "parent_node";
            treeNode12.Text = "Properties";
            treeNode13.Name = "parent_node";
            treeNode13.Text = "air_state";
            treeNode14.Name = "parent_node";
            treeNode14.Text = "debug_settings";
            treeNode15.Name = "parent_node";
            treeNode15.Text = "config";
            treeNode16.Name = "root_node";
            treeNode16.Text = "Carver";
            this.carver_view.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16});
            this.carver_view.Size = new System.Drawing.Size(598, 425);
            this.carver_view.TabIndex = 1;
            this.carver_view.MouseDown += new System.Windows.Forms.MouseEventHandler(this.carver_view_MouseDown);
            // 
            // Carver_rclick_menu
            // 
            this.Carver_rclick_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_menu,
            this.delete_menu,
            this.clear_menu});
            this.Carver_rclick_menu.Name = "Carver_rclick_menu";
            this.Carver_rclick_menu.Size = new System.Drawing.Size(130, 70);
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
            // carver_spawner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.carver_view);
            this.Controls.Add(this.Carver_title_menu);
            this.MainMenuStrip = this.Carver_title_menu;
            this.Name = "carver_spawner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "地形雕刻器";
            this.Carver_title_menu.ResumeLayout(false);
            this.Carver_title_menu.PerformLayout();
            this.Carver_rclick_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Carver_title_menu;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成返回ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.TreeView carver_view;
        private System.Windows.Forms.ToolStripMenuItem add;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.ToolStripMenuItem clear;
        private System.Windows.Forms.ToolStripMenuItem click_to_spawn;
        private System.Windows.Forms.ToolStripMenuItem click_to_return;
        private System.Windows.Forms.ToolStripMenuItem 关于地形雕刻器ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Carver_rclick_menu;
        private System.Windows.Forms.ToolStripMenuItem add_menu;
        private System.Windows.Forms.ToolStripMenuItem delete_menu;
        private System.Windows.Forms.ToolStripMenuItem clear_menu;
    }
}