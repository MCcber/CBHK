
namespace cbhk_editor.LootTableSpawner
{
    partial class lt_spawner
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("type:entity");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("functions");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("functions");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("conditions");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("min:0");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("max:0");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("rolls", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("min:0");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("max:0");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("bonus_rolls", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("functions");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("conditions");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("type:item");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("name:apple");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("weight:1");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("quality:0");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("expand:false");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("1", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("entries", new System.Windows.Forms.TreeNode[] {
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("1", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode7,
            treeNode10,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("pools", new System.Windows.Forms.TreeNode[] {
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("战利品表", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode21});
            this.lt_title_menu = new System.Windows.Forms.MenuStrip();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_node_title_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.modify_node_title_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_node_title_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_node_title_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.生成返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_spawn = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_return = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.版本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version1_12 = new System.Windows.Forms.ToolStripMenuItem();
            this.version1_13 = new System.Windows.Forms.ToolStripMenuItem();
            this.lt_view = new System.Windows.Forms.TreeView();
            this.lt_rclick_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.add_node = new System.Windows.Forms.ToolStripMenuItem();
            this.modify_node = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_node = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_node = new System.Windows.Forms.ToolStripMenuItem();
            this.lt_title_menu.SuspendLayout();
            this.lt_rclick_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lt_title_menu
            // 
            this.lt_title_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lt_title_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑EToolStripMenuItem,
            this.生成返回ToolStripMenuItem,
            this.帮助HToolStripMenuItem,
            this.版本ToolStripMenuItem});
            this.lt_title_menu.Location = new System.Drawing.Point(0, 0);
            this.lt_title_menu.Name = "lt_title_menu";
            this.lt_title_menu.Size = new System.Drawing.Size(627, 25);
            this.lt_title_menu.TabIndex = 0;
            this.lt_title_menu.Text = "menuStrip1";
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_node_title_menu,
            this.modify_node_title_menu,
            this.delete_node_title_menu,
            this.clear_node_title_menu});
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.编辑EToolStripMenuItem.Text = "编辑&E";
            // 
            // add_node_title_menu
            // 
            this.add_node_title_menu.Name = "add_node_title_menu";
            this.add_node_title_menu.Size = new System.Drawing.Size(148, 22);
            this.add_node_title_menu.Text = "添加节点";
            this.add_node_title_menu.Click += new System.EventHandler(this.add_node_title_menu_Click);
            // 
            // modify_node_title_menu
            // 
            this.modify_node_title_menu.Name = "modify_node_title_menu";
            this.modify_node_title_menu.Size = new System.Drawing.Size(148, 22);
            this.modify_node_title_menu.Text = "修改节点";
            this.modify_node_title_menu.Click += new System.EventHandler(this.modify_node_title_menu_Click);
            // 
            // delete_node_title_menu
            // 
            this.delete_node_title_menu.Name = "delete_node_title_menu";
            this.delete_node_title_menu.Size = new System.Drawing.Size(148, 22);
            this.delete_node_title_menu.Text = "删除节点";
            this.delete_node_title_menu.Click += new System.EventHandler(this.delete_node_title_menu_Click);
            // 
            // clear_node_title_menu
            // 
            this.clear_node_title_menu.Name = "clear_node_title_menu";
            this.clear_node_title_menu.Size = new System.Drawing.Size(148, 22);
            this.clear_node_title_menu.Text = "删除所有子级";
            this.clear_node_title_menu.Click += new System.EventHandler(this.clear_node_title_menu_Click);
            // 
            // 生成返回ToolStripMenuItem
            // 
            this.生成返回ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.click_to_spawn,
            this.click_to_return});
            this.生成返回ToolStripMenuItem.Name = "生成返回ToolStripMenuItem";
            this.生成返回ToolStripMenuItem.Size = new System.Drawing.Size(81, 21);
            this.生成返回ToolStripMenuItem.Text = "生成-返回&R";
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
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.帮助HToolStripMenuItem.Text = "帮助&H";
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(184, 22);
            this.about.Text = "关于战利品表生成器";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // 版本ToolStripMenuItem
            // 
            this.版本ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.version1_12,
            this.version1_13});
            this.版本ToolStripMenuItem.Name = "版本ToolStripMenuItem";
            this.版本ToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.版本ToolStripMenuItem.Text = "版本&V";
            // 
            // version1_12
            // 
            this.version1_12.CheckOnClick = true;
            this.version1_12.Name = "version1_12";
            this.version1_12.Size = new System.Drawing.Size(136, 22);
            this.version1_12.Text = "1.12及以下";
            this.version1_12.Click += new System.EventHandler(this.version1_12_Click);
            // 
            // version1_13
            // 
            this.version1_13.Checked = true;
            this.version1_13.CheckOnClick = true;
            this.version1_13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.version1_13.Name = "version1_13";
            this.version1_13.Size = new System.Drawing.Size(136, 22);
            this.version1_13.Text = "1.13及以上";
            this.version1_13.Click += new System.EventHandler(this.version1_13_Click);
            // 
            // lt_view
            // 
            this.lt_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lt_view.ContextMenuStrip = this.lt_rclick_menu;
            this.lt_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lt_view.ForeColor = System.Drawing.Color.White;
            this.lt_view.Location = new System.Drawing.Point(0, 25);
            this.lt_view.Name = "lt_view";
            treeNode1.Name = "value:string";
            treeNode1.Text = "type:entity";
            treeNode2.Name = "arraynode";
            treeNode2.Text = "functions";
            treeNode3.Name = "arraynode";
            treeNode3.Text = "functions";
            treeNode4.Name = "arraynode";
            treeNode4.Text = "conditions";
            treeNode5.Name = "value:int";
            treeNode5.Text = "min:0";
            treeNode6.Name = "value:int";
            treeNode6.Text = "max:0";
            treeNode7.Name = "parentnode";
            treeNode7.Text = "rolls";
            treeNode8.Name = "value:int";
            treeNode8.Text = "min:0";
            treeNode9.Name = "value:int";
            treeNode9.Text = "max:0";
            treeNode10.Name = "parentnode";
            treeNode10.Text = "bonus_rolls";
            treeNode11.Name = "arraynode";
            treeNode11.Text = "functions";
            treeNode12.Name = "arraynode";
            treeNode12.Text = "conditions";
            treeNode13.Name = "value:string";
            treeNode13.Text = "type:item";
            treeNode14.Name = "value:string";
            treeNode14.Text = "name:apple";
            treeNode15.Name = "value:float";
            treeNode15.Text = "weight:1";
            treeNode16.Name = "value:float";
            treeNode16.Text = "quality:0";
            treeNode17.Name = "value:bool";
            treeNode17.Text = "expand:false";
            treeNode18.Name = "ele";
            treeNode18.Text = "1";
            treeNode19.Name = "obj_parentnode";
            treeNode19.Text = "entries";
            treeNode20.Name = "ele";
            treeNode20.Text = "1";
            treeNode21.Name = "obj_parentnode";
            treeNode21.Text = "pools";
            treeNode22.Name = "rootnode";
            treeNode22.Text = "战利品表";
            this.lt_view.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode22});
            this.lt_view.Size = new System.Drawing.Size(627, 425);
            this.lt_view.TabIndex = 1;
            this.lt_view.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lt_view_MouseDoubleClick);
            this.lt_view.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lt_view_MouseDown);
            // 
            // lt_rclick_menu
            // 
            this.lt_rclick_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_node,
            this.modify_node,
            this.delete_node,
            this.clear_node});
            this.lt_rclick_menu.Name = "lt_rclick_menu";
            this.lt_rclick_menu.Size = new System.Drawing.Size(149, 92);
            // 
            // add_node
            // 
            this.add_node.Name = "add_node";
            this.add_node.Size = new System.Drawing.Size(148, 22);
            this.add_node.Text = "添加节点";
            this.add_node.Click += new System.EventHandler(this.add_node_Click);
            // 
            // modify_node
            // 
            this.modify_node.Name = "modify_node";
            this.modify_node.Size = new System.Drawing.Size(148, 22);
            this.modify_node.Text = "修改节点";
            this.modify_node.Click += new System.EventHandler(this.modify_node_Click);
            // 
            // delete_node
            // 
            this.delete_node.Name = "delete_node";
            this.delete_node.Size = new System.Drawing.Size(148, 22);
            this.delete_node.Text = "删除节点";
            this.delete_node.Click += new System.EventHandler(this.delete_node_Click);
            // 
            // clear_node
            // 
            this.clear_node.Name = "clear_node";
            this.clear_node.Size = new System.Drawing.Size(148, 22);
            this.clear_node.Text = "删除所有子级";
            this.clear_node.Click += new System.EventHandler(this.clear_node_Click);
            // 
            // lt_spawner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.lt_view);
            this.Controls.Add(this.lt_title_menu);
            this.MainMenuStrip = this.lt_title_menu;
            this.MaximizeBox = false;
            this.Name = "lt_spawner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "战利品表生成器";
            this.lt_title_menu.ResumeLayout(false);
            this.lt_title_menu.PerformLayout();
            this.lt_rclick_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip lt_title_menu;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_node_title_menu;
        private System.Windows.Forms.ToolStripMenuItem delete_node_title_menu;
        private System.Windows.Forms.ToolStripMenuItem clear_node_title_menu;
        private System.Windows.Forms.ToolStripMenuItem 生成返回ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem click_to_spawn;
        private System.Windows.Forms.ToolStripMenuItem click_to_return;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 版本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem version1_12;
        private System.Windows.Forms.ToolStripMenuItem version1_13;
        private System.Windows.Forms.TreeView lt_view;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ContextMenuStrip lt_rclick_menu;
        private System.Windows.Forms.ToolStripMenuItem add_node;
        private System.Windows.Forms.ToolStripMenuItem delete_node;
        private System.Windows.Forms.ToolStripMenuItem clear_node;
        private System.Windows.Forms.ToolStripMenuItem modify_node_title_menu;
        private System.Windows.Forms.ToolStripMenuItem modify_node;
    }
}