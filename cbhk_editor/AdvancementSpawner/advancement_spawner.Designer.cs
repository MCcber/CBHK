
namespace cbhk_editor.AdvancementSpawner
{
    partial class advancement_spawner
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("item:apple");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("nbt");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("icon", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("title");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("frame:task");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("background");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("description");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("show_toast:true");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("announce_to_chat:true");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("hidden:false");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("display", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("parent");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("trigger:");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("1", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("criteria", new System.Windows.Forms.TreeNode[] {
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("requirements");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("recipes");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("loot");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("experience:");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("function");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("rewards", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("advancement", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode15,
            treeNode16,
            treeNode21});
            this.adv_view = new System.Windows.Forms.TreeView();
            this.adv_rclick_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.add = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.adv_title_menu = new System.Windows.Forms.MenuStrip();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.生成返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_spawn = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_return = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.simple_triggers_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.impossibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simple_triggers = new System.Windows.Forms.ToolStripMenuItem();
            this.impossibleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.display_info = new System.Windows.Forms.ToolTip(this.components);
            this.adv_rclick_menu.SuspendLayout();
            this.adv_title_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // adv_view
            // 
            this.adv_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.adv_view.ContextMenuStrip = this.adv_rclick_menu;
            this.adv_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adv_view.ForeColor = System.Drawing.Color.White;
            this.adv_view.Location = new System.Drawing.Point(0, 25);
            this.adv_view.Name = "adv_view";
            treeNode1.Name = "value:string";
            treeNode1.Text = "item:apple";
            treeNode2.Name = "value:tag";
            treeNode2.Text = "nbt";
            treeNode3.Name = "parent_node";
            treeNode3.Text = "icon";
            treeNode4.Name = "value:tag";
            treeNode4.Tag = "minecraft";
            treeNode4.Text = "title";
            treeNode5.Name = "value:list";
            treeNode5.Tag = "challenge,goal,task";
            treeNode5.Text = "frame:task";
            treeNode6.Name = "value:tag";
            treeNode6.Text = "background";
            treeNode7.Name = "value:tag";
            treeNode7.Tag = "minecraft";
            treeNode7.Text = "description";
            treeNode8.Name = "value:bool";
            treeNode8.Text = "show_toast:true";
            treeNode9.Name = "value:bool";
            treeNode9.Text = "announce_to_chat:true";
            treeNode10.Name = "value:bool";
            treeNode10.Text = "hidden:false";
            treeNode11.Name = "parent_node";
            treeNode11.Text = "display";
            treeNode12.Name = "value:tag";
            treeNode12.Text = "parent";
            treeNode13.Name = "value:list";
            treeNode13.Text = "trigger:";
            treeNode14.Name = "condition";
            treeNode14.Text = "1";
            treeNode15.Name = "parent_node";
            treeNode15.Text = "criteria";
            treeNode16.Name = "list_node";
            treeNode16.Text = "requirements";
            treeNode17.Name = "list_node";
            treeNode17.Text = "recipes";
            treeNode18.Name = "list_node";
            treeNode18.Text = "loot";
            treeNode19.Name = "value:int";
            treeNode19.Text = "experience:";
            treeNode20.Name = "value:tag";
            treeNode20.Text = "function";
            treeNode21.Name = "parent_node";
            treeNode21.Text = "rewards";
            treeNode22.Name = "rootnode";
            treeNode22.Text = "advancement";
            this.adv_view.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode22});
            this.adv_view.Size = new System.Drawing.Size(488, 357);
            this.adv_view.TabIndex = 0;
            this.adv_view.MouseDown += new System.Windows.Forms.MouseEventHandler(this.adv_view_MouseDown);
            this.adv_view.MouseMove += new System.Windows.Forms.MouseEventHandler(this.adv_view_MouseMove);
            // 
            // adv_rclick_menu
            // 
            this.adv_rclick_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add,
            this.simple_triggers,
            this.delete,
            this.clear});
            this.adv_rclick_menu.Name = "adv_rclick_menu";
            this.adv_rclick_menu.Size = new System.Drawing.Size(137, 92);
            // 
            // add
            // 
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(136, 22);
            this.add.Text = "添加/修改";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(136, 22);
            this.delete.Text = "删除";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // clear
            // 
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(136, 22);
            this.clear.Text = "清空";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // adv_title_menu
            // 
            this.adv_title_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.adv_title_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑ToolStripMenuItem,
            this.生成返回ToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.adv_title_menu.Location = new System.Drawing.Point(0, 0);
            this.adv_title_menu.Name = "adv_title_menu";
            this.adv_title_menu.Size = new System.Drawing.Size(488, 25);
            this.adv_title_menu.TabIndex = 1;
            this.adv_title_menu.Text = "menuStrip1";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_menu,
            this.simple_triggers_menu,
            this.delete_menu,
            this.clear_menu});
            this.编辑ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.编辑ToolStripMenuItem.Text = "编辑&E";
            // 
            // add_menu
            // 
            this.add_menu.Name = "add_menu";
            this.add_menu.Size = new System.Drawing.Size(180, 22);
            this.add_menu.Text = "添加/修改";
            this.add_menu.Click += new System.EventHandler(this.add_menu_Click);
            // 
            // delete_menu
            // 
            this.delete_menu.Name = "delete_menu";
            this.delete_menu.Size = new System.Drawing.Size(180, 22);
            this.delete_menu.Text = "删除";
            this.delete_menu.Click += new System.EventHandler(this.delete_menu_Click);
            // 
            // clear_menu
            // 
            this.clear_menu.Name = "clear_menu";
            this.clear_menu.Size = new System.Drawing.Size(180, 22);
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
            this.帮助HToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.帮助HToolStripMenuItem.Text = "帮助&H";
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(160, 22);
            this.about.Text = "关于进度生成器";
            // 
            // simple_triggers_menu
            // 
            this.simple_triggers_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impossibleToolStripMenuItem});
            this.simple_triggers_menu.Name = "simple_triggers_menu";
            this.simple_triggers_menu.Size = new System.Drawing.Size(180, 22);
            this.simple_triggers_menu.Text = "添加触发器";
            // 
            // impossibleToolStripMenuItem
            // 
            this.impossibleToolStripMenuItem.Name = "impossibleToolStripMenuItem";
            this.impossibleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.impossibleToolStripMenuItem.Text = "impossible";
            // 
            // simple_triggers
            // 
            this.simple_triggers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impossibleToolStripMenuItem1});
            this.simple_triggers.Name = "simple_triggers";
            this.simple_triggers.Size = new System.Drawing.Size(136, 22);
            this.simple_triggers.Text = "添加触发器";
            // 
            // impossibleToolStripMenuItem1
            // 
            this.impossibleToolStripMenuItem1.Name = "impossibleToolStripMenuItem1";
            this.impossibleToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.impossibleToolStripMenuItem1.Text = "impossible";
            // 
            // advancement_spawner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(488, 382);
            this.Controls.Add(this.adv_view);
            this.Controls.Add(this.adv_title_menu);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.adv_title_menu;
            this.Name = "advancement_spawner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "进度生成器";
            this.adv_rclick_menu.ResumeLayout(false);
            this.adv_title_menu.ResumeLayout(false);
            this.adv_title_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView adv_view;
        private System.Windows.Forms.MenuStrip adv_title_menu;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成返回ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem click_to_spawn;
        private System.Windows.Forms.ToolStripMenuItem click_to_return;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ToolStripMenuItem add_menu;
        private System.Windows.Forms.ToolStripMenuItem delete_menu;
        private System.Windows.Forms.ToolStripMenuItem clear_menu;
        private System.Windows.Forms.ContextMenuStrip adv_rclick_menu;
        private System.Windows.Forms.ToolStripMenuItem add;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.ToolStripMenuItem clear;
        private System.Windows.Forms.ToolStripMenuItem simple_triggers_menu;
        private System.Windows.Forms.ToolStripMenuItem impossibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simple_triggers;
        private System.Windows.Forms.ToolStripMenuItem impossibleToolStripMenuItem1;
        private System.Windows.Forms.ToolTip display_info;
    }
}