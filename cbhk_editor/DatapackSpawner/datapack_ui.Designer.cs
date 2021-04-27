
namespace cbhk_editor.DatapackSpawner
{
    partial class Datapack_ui
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
            this.dp_title_menu = new System.Windows.Forms.MenuStrip();
            this.file_title = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_pack_title_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_function_title_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.open_datapack = new System.Windows.Forms.ToolStripMenuItem();
            this.recent_packs = new System.Windows.Forms.ToolStripMenuItem();
            this.close_pack = new System.Windows.Forms.ToolStripMenuItem();
            this.close_all_pack = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.save_as = new System.Windows.Forms.ToolStripMenuItem();
            this.save_all = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.head_area = new System.Windows.Forms.ToolStripMenuItem();
            this.function_area = new System.Windows.Forms.ToolStripMenuItem();
            this.生成返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_spawn = new System.Windows.Forms.ToolStripMenuItem();
            this.spawner_all = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_return = new System.Windows.Forms.ToolStripMenuItem();
            this.Navigation = new System.Windows.Forms.ToolStripMenuItem();
            this.datapack_tc = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dp_rclick_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.add_new = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_current = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_current = new System.Windows.Forms.ToolStripMenuItem();
            this.rename_rclick = new System.Windows.Forms.ToolStripMenuItem();
            this.dp_title_menu.SuspendLayout();
            this.datapack_tc.SuspendLayout();
            this.dp_rclick_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dp_title_menu
            // 
            this.dp_title_menu.BackColor = System.Drawing.Color.Transparent;
            this.dp_title_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_title,
            this.视图ToolStripMenuItem,
            this.生成返回ToolStripMenuItem,
            this.Navigation});
            this.dp_title_menu.Location = new System.Drawing.Point(0, 0);
            this.dp_title_menu.Name = "dp_title_menu";
            this.dp_title_menu.Size = new System.Drawing.Size(582, 25);
            this.dp_title_menu.TabIndex = 0;
            this.dp_title_menu.Text = "menuStrip1";
            // 
            // file_title
            // 
            this.file_title.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.open_datapack,
            this.recent_packs,
            this.close_pack,
            this.close_all_pack,
            this.save,
            this.save_as,
            this.save_all});
            this.file_title.Name = "file_title";
            this.file_title.Size = new System.Drawing.Size(50, 21);
            this.file_title.Text = "文件&F";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_pack_title_menu,
            this.Add_function_title_menu});
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.新建ToolStripMenuItem.Text = "新建";
            // 
            // Add_pack_title_menu
            // 
            this.Add_pack_title_menu.Name = "Add_pack_title_menu";
            this.Add_pack_title_menu.Size = new System.Drawing.Size(112, 22);
            this.Add_pack_title_menu.Text = "数据包";
            this.Add_pack_title_menu.Click += new System.EventHandler(this.Add_pack_title_menu_Click);
            // 
            // Add_function_title_menu
            // 
            this.Add_function_title_menu.Name = "Add_function_title_menu";
            this.Add_function_title_menu.Size = new System.Drawing.Size(112, 22);
            this.Add_function_title_menu.Text = "函数";
            this.Add_function_title_menu.Click += new System.EventHandler(this.Add_function_title_menu_Click);
            // 
            // open_datapack
            // 
            this.open_datapack.Name = "open_datapack";
            this.open_datapack.Size = new System.Drawing.Size(180, 22);
            this.open_datapack.Text = "打开";
            this.open_datapack.Click += new System.EventHandler(this.Open_datapack_Click);
            // 
            // recent_packs
            // 
            this.recent_packs.Name = "recent_packs";
            this.recent_packs.Size = new System.Drawing.Size(180, 22);
            this.recent_packs.Text = "最近使用的数据包";
            // 
            // close_pack
            // 
            this.close_pack.BackColor = System.Drawing.Color.Transparent;
            this.close_pack.ForeColor = System.Drawing.Color.Gray;
            this.close_pack.Name = "close_pack";
            this.close_pack.Size = new System.Drawing.Size(180, 22);
            this.close_pack.Text = "关闭";
            this.close_pack.Click += new System.EventHandler(this.Close_pack_Click);
            // 
            // close_all_pack
            // 
            this.close_all_pack.BackColor = System.Drawing.Color.Transparent;
            this.close_all_pack.ForeColor = System.Drawing.Color.Gray;
            this.close_all_pack.Name = "close_all_pack";
            this.close_all_pack.Size = new System.Drawing.Size(180, 22);
            this.close_all_pack.Text = "全部关闭";
            this.close_all_pack.Click += new System.EventHandler(this.Close_all_pack_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.ForeColor = System.Drawing.Color.Gray;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(180, 22);
            this.save.Text = "保存";
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // save_as
            // 
            this.save_as.BackColor = System.Drawing.Color.Transparent;
            this.save_as.ForeColor = System.Drawing.Color.Gray;
            this.save_as.Name = "save_as";
            this.save_as.Size = new System.Drawing.Size(180, 22);
            this.save_as.Text = "另存为";
            this.save_as.Click += new System.EventHandler(this.Save_as_Click);
            // 
            // save_all
            // 
            this.save_all.BackColor = System.Drawing.Color.Transparent;
            this.save_all.ForeColor = System.Drawing.Color.Gray;
            this.save_all.Name = "save_all";
            this.save_all.Size = new System.Drawing.Size(180, 22);
            this.save_all.Text = "全部保存";
            this.save_all.Click += new System.EventHandler(this.Save_all_Click);
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.head_area,
            this.function_area});
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.视图ToolStripMenuItem.Text = "视图切换&V";
            // 
            // head_area
            // 
            this.head_area.CheckOnClick = true;
            this.head_area.Name = "head_area";
            this.head_area.Size = new System.Drawing.Size(124, 22);
            this.head_area.Text = "头信息区";
            this.head_area.Click += new System.EventHandler(this.Head_area_Click);
            // 
            // function_area
            // 
            this.function_area.CheckOnClick = true;
            this.function_area.Name = "function_area";
            this.function_area.Size = new System.Drawing.Size(124, 22);
            this.function_area.Text = "函数区";
            this.function_area.Click += new System.EventHandler(this.Function_area_Click);
            // 
            // 生成返回ToolStripMenuItem
            // 
            this.生成返回ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.click_to_spawn,
            this.spawner_all,
            this.click_to_return});
            this.生成返回ToolStripMenuItem.Name = "生成返回ToolStripMenuItem";
            this.生成返回ToolStripMenuItem.Size = new System.Drawing.Size(81, 21);
            this.生成返回ToolStripMenuItem.Text = "生成-返回&B";
            // 
            // click_to_spawn
            // 
            this.click_to_spawn.Name = "click_to_spawn";
            this.click_to_spawn.Size = new System.Drawing.Size(124, 22);
            this.click_to_spawn.Text = "生成";
            this.click_to_spawn.Click += new System.EventHandler(this.Click_to_spawn_Click);
            // 
            // spawner_all
            // 
            this.spawner_all.Name = "spawner_all";
            this.spawner_all.Size = new System.Drawing.Size(124, 22);
            this.spawner_all.Text = "全部生成";
            this.spawner_all.Click += new System.EventHandler(this.Spawner_all_Click);
            // 
            // click_to_return
            // 
            this.click_to_return.Name = "click_to_return";
            this.click_to_return.Size = new System.Drawing.Size(124, 22);
            this.click_to_return.Text = "返回";
            // 
            // Navigation
            // 
            this.Navigation.Name = "Navigation";
            this.Navigation.Size = new System.Drawing.Size(88, 21);
            this.Navigation.Text = "数据包导航&A";
            // 
            // datapack_tc
            // 
            this.datapack_tc.Controls.Add(this.tabPage1);
            this.datapack_tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datapack_tc.Location = new System.Drawing.Point(0, 25);
            this.datapack_tc.Name = "datapack_tc";
            this.datapack_tc.SelectedIndex = 0;
            this.datapack_tc.Size = new System.Drawing.Size(582, 425);
            this.datapack_tc.TabIndex = 1;
            this.datapack_tc.SelectedIndexChanged += new System.EventHandler(this.Datapack_tc_SelectedIndexChanged);
            this.datapack_tc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Datapack_tc_MouseDown);
            this.datapack_tc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Datapack_tc_MouseUp);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(574, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "new_pack1";
            // 
            // dp_rclick_menu
            // 
            this.dp_rclick_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_new,
            this.delete_current,
            this.clear_current,
            this.rename_rclick});
            this.dp_rclick_menu.Name = "dp_rclick_menu";
            this.dp_rclick_menu.Size = new System.Drawing.Size(125, 92);
            // 
            // add_new
            // 
            this.add_new.Name = "add_new";
            this.add_new.Size = new System.Drawing.Size(124, 22);
            this.add_new.Text = "新建";
            this.add_new.Click += new System.EventHandler(this.Add_new_Click);
            // 
            // delete_current
            // 
            this.delete_current.Name = "delete_current";
            this.delete_current.Size = new System.Drawing.Size(124, 22);
            this.delete_current.Text = "删除";
            this.delete_current.Click += new System.EventHandler(this.Delete_current_Click);
            // 
            // clear_current
            // 
            this.clear_current.Name = "clear_current";
            this.clear_current.Size = new System.Drawing.Size(124, 22);
            this.clear_current.Text = "全部删除";
            this.clear_current.Click += new System.EventHandler(this.Clear_current_Click);
            // 
            // rename_rclick
            // 
            this.rename_rclick.Name = "rename_rclick";
            this.rename_rclick.Size = new System.Drawing.Size(124, 22);
            this.rename_rclick.Text = "重命名";
            this.rename_rclick.Click += new System.EventHandler(this.Rename_rclick_Click);
            // 
            // Datapack_ui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.ContextMenuStrip = this.dp_rclick_menu;
            this.Controls.Add(this.datapack_tc);
            this.Controls.Add(this.dp_title_menu);
            this.MainMenuStrip = this.dp_title_menu;
            this.Name = "Datapack_ui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据包生成器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Datapack_ui_FormClosing);
            this.dp_title_menu.ResumeLayout(false);
            this.dp_title_menu.PerformLayout();
            this.datapack_tc.ResumeLayout(false);
            this.dp_rclick_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip dp_title_menu;
        private System.Windows.Forms.ToolStripMenuItem file_title;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem open_datapack;
        private System.Windows.Forms.ToolStripMenuItem recent_packs;
        private System.Windows.Forms.ToolStripMenuItem close_pack;
        private System.Windows.Forms.ToolStripMenuItem close_all_pack;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem save_as;
        private System.Windows.Forms.ToolStripMenuItem save_all;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成返回ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Navigation;
        private System.Windows.Forms.ToolStripMenuItem click_to_spawn;
        private System.Windows.Forms.ToolStripMenuItem head_area;
        private System.Windows.Forms.ToolStripMenuItem function_area;
        private System.Windows.Forms.ToolStripMenuItem Add_pack_title_menu;
        private System.Windows.Forms.ToolStripMenuItem Add_function_title_menu;
        private System.Windows.Forms.TabControl datapack_tc;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ContextMenuStrip dp_rclick_menu;
        private System.Windows.Forms.ToolStripMenuItem add_new;
        private System.Windows.Forms.ToolStripMenuItem delete_current;
        private System.Windows.Forms.ToolStripMenuItem clear_current;
        public System.Windows.Forms.ToolStripMenuItem click_to_return;
        private System.Windows.Forms.ToolStripMenuItem rename_rclick;
        private System.Windows.Forms.ToolStripMenuItem spawner_all;
    }
}