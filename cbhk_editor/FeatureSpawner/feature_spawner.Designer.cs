
namespace cbhk_editor.FeatureSpawner
{
    partial class feature_spawner
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("type:");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("config");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Feature", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.feature_title_menu = new System.Windows.Forms.MenuStrip();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于地物生成器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_spawn = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_return = new System.Windows.Forms.ToolStripMenuItem();
            this.add = new System.Windows.Forms.ToolStripMenuItem();
            this.remove = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.feature_rclick_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feature_view = new System.Windows.Forms.TreeView();
            this.feature_title_menu.SuspendLayout();
            this.feature_rclick_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // feature_title_menu
            // 
            this.feature_title_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.feature_title_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑EToolStripMenuItem,
            this.生成返回ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.feature_title_menu.Location = new System.Drawing.Point(0, 0);
            this.feature_title_menu.Name = "feature_title_menu";
            this.feature_title_menu.Size = new System.Drawing.Size(339, 25);
            this.feature_title_menu.TabIndex = 0;
            this.feature_title_menu.Text = "menuStrip1";
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add,
            this.remove,
            this.clear});
            this.编辑EToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.编辑EToolStripMenuItem.Text = "编辑&E";
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
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于地物生成器ToolStripMenuItem});
            this.关于ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 关于地物生成器ToolStripMenuItem
            // 
            this.关于地物生成器ToolStripMenuItem.Name = "关于地物生成器ToolStripMenuItem";
            this.关于地物生成器ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.关于地物生成器ToolStripMenuItem.Text = "关于地物生成器";
            // 
            // click_to_spawn
            // 
            this.click_to_spawn.Name = "click_to_spawn";
            this.click_to_spawn.Size = new System.Drawing.Size(180, 22);
            this.click_to_spawn.Text = "生成";
            // 
            // click_to_return
            // 
            this.click_to_return.Name = "click_to_return";
            this.click_to_return.Size = new System.Drawing.Size(180, 22);
            this.click_to_return.Text = "返回";
            // 
            // add
            // 
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(180, 22);
            this.add.Text = "添加/修改";
            // 
            // remove
            // 
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(180, 22);
            this.remove.Text = "删除";
            // 
            // clear
            // 
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(180, 22);
            this.clear.Text = "清空";
            // 
            // feature_rclick_menu
            // 
            this.feature_rclick_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加修改ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.清空ToolStripMenuItem});
            this.feature_rclick_menu.Name = "feature_rclick_menu";
            this.feature_rclick_menu.Size = new System.Drawing.Size(130, 70);
            // 
            // 添加修改ToolStripMenuItem
            // 
            this.添加修改ToolStripMenuItem.Name = "添加修改ToolStripMenuItem";
            this.添加修改ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.添加修改ToolStripMenuItem.Text = "添加/修改";
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.清空ToolStripMenuItem.Text = "清空";
            // 
            // feature_view
            // 
            this.feature_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.feature_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feature_view.ForeColor = System.Drawing.Color.White;
            this.feature_view.Location = new System.Drawing.Point(0, 25);
            this.feature_view.Name = "feature_view";
            treeNode1.Name = "value:tag";
            treeNode1.Tag = "";
            treeNode1.Text = "type:";
            treeNode2.Name = "parent_node";
            treeNode2.Text = "config";
            treeNode3.Name = "root_node";
            treeNode3.Text = "Feature";
            this.feature_view.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.feature_view.Size = new System.Drawing.Size(339, 197);
            this.feature_view.TabIndex = 2;
            // 
            // feature_spawner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(339, 222);
            this.Controls.Add(this.feature_view);
            this.Controls.Add(this.feature_title_menu);
            this.MainMenuStrip = this.feature_title_menu;
            this.Name = "feature_spawner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "地物生成器";
            this.feature_title_menu.ResumeLayout(false);
            this.feature_title_menu.PerformLayout();
            this.feature_rclick_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip feature_title_menu;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成返回ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于地物生成器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add;
        private System.Windows.Forms.ToolStripMenuItem remove;
        private System.Windows.Forms.ToolStripMenuItem clear;
        private System.Windows.Forms.ToolStripMenuItem click_to_spawn;
        private System.Windows.Forms.ToolStripMenuItem click_to_return;
        private System.Windows.Forms.ContextMenuStrip feature_rclick_menu;
        private System.Windows.Forms.ToolStripMenuItem 添加修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
        private System.Windows.Forms.TreeView feature_view;
    }
}