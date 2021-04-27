
namespace cbhk_editor.DimensionSpawner
{
    partial class dimension_spawner
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("type:minecraft:overworld");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("type:debug");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("seed:0");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("generator", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("dimension", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4});
            this.dimension_title_menu = new System.Windows.Forms.MenuStrip();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.生成返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_spawn = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_return = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.dimension_view = new System.Windows.Forms.TreeView();
            this.dimension_rclick_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.add = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.dimension_title_menu.SuspendLayout();
            this.dimension_rclick_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dimension_title_menu
            // 
            this.dimension_title_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dimension_title_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑EToolStripMenuItem,
            this.生成返回ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.dimension_title_menu.Location = new System.Drawing.Point(0, 0);
            this.dimension_title_menu.Name = "dimension_title_menu";
            this.dimension_title_menu.Size = new System.Drawing.Size(505, 25);
            this.dimension_title_menu.TabIndex = 0;
            this.dimension_title_menu.Text = "menuStrip1";
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_menu,
            this.delete_menu,
            this.clear_menu});
            this.编辑EToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.编辑EToolStripMenuItem.Text = "编辑&E";
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
            this.click_to_spawn.Size = new System.Drawing.Size(180, 22);
            this.click_to_spawn.Text = "生成";
            this.click_to_spawn.Click += new System.EventHandler(this.click_to_spawn_Click);
            // 
            // click_to_return
            // 
            this.click_to_return.Name = "click_to_return";
            this.click_to_return.Size = new System.Drawing.Size(180, 22);
            this.click_to_return.Text = "返回";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about});
            this.帮助ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(160, 22);
            this.about.Text = "关于维度生成器";
            // 
            // dimension_view
            // 
            this.dimension_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dimension_view.ContextMenuStrip = this.dimension_rclick_menu;
            this.dimension_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dimension_view.ForeColor = System.Drawing.Color.White;
            this.dimension_view.Location = new System.Drawing.Point(0, 25);
            this.dimension_view.Name = "dimension_view";
            treeNode1.Name = "value:string";
            treeNode1.Tag = "minecraft:overworld,minecraft:overworld_caves,minecraft:the_nether,minecraft:the_" +
    "end,object";
            treeNode1.Text = "type:minecraft:overworld";
            treeNode2.Name = "value:string";
            treeNode2.Tag = "minecraft:flat,minecraft:noise,minecraft:debug";
            treeNode2.Text = "type:debug";
            treeNode3.Name = "value:long";
            treeNode3.Text = "seed:0";
            treeNode4.Name = "parent_node";
            treeNode4.Text = "generator";
            treeNode5.Name = "root_node";
            treeNode5.Text = "dimension";
            this.dimension_view.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.dimension_view.Size = new System.Drawing.Size(505, 374);
            this.dimension_view.TabIndex = 1;
            this.dimension_view.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dimension_view_MouseDown);
            // 
            // dimension_rclick_menu
            // 
            this.dimension_rclick_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add,
            this.delete,
            this.clear});
            this.dimension_rclick_menu.Name = "dimension_rclick_menu";
            this.dimension_rclick_menu.Size = new System.Drawing.Size(130, 70);
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
            // dimension_spawner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(505, 399);
            this.Controls.Add(this.dimension_view);
            this.Controls.Add(this.dimension_title_menu);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.dimension_title_menu;
            this.Name = "dimension_spawner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自定义维度";
            this.dimension_title_menu.ResumeLayout(false);
            this.dimension_title_menu.PerformLayout();
            this.dimension_rclick_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip dimension_title_menu;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_menu;
        private System.Windows.Forms.ToolStripMenuItem delete_menu;
        private System.Windows.Forms.ToolStripMenuItem clear_menu;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ToolStripMenuItem 生成返回ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem click_to_spawn;
        private System.Windows.Forms.ToolStripMenuItem click_to_return;
        private System.Windows.Forms.TreeView dimension_view;
        private System.Windows.Forms.ContextMenuStrip dimension_rclick_menu;
        private System.Windows.Forms.ToolStripMenuItem add;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.ToolStripMenuItem clear;
    }
}