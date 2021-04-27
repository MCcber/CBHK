
namespace cbhk_editor.SkillSpawner
{
    partial class skill_ui
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
            this.skill_title_menu = new System.Windows.Forms.MenuStrip();
            this.click_to_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_condition_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_event_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_all_conditions = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_all_events = new System.Windows.Forms.ToolStripMenuItem();
            this.生成返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Click_to_spawn = new System.Windows.Forms.ToolStripMenuItem();
            this.click_to_return = new System.Windows.Forms.ToolStripMenuItem();
            this.添加预览条件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemCondition = new System.Windows.Forms.ToolStripMenuItem();
            this.EntityCondition = new System.Windows.Forms.ToolStripMenuItem();
            this.AddEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.版本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version1_12 = new System.Windows.Forms.ToolStripMenuItem();
            this.version1_13 = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About_skill_spawner = new System.Windows.Forms.ToolStripMenuItem();
            this.skill_rclick_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rclick_delete_contidion = new System.Windows.Forms.ToolStripMenuItem();
            this.rclick_delete_event = new System.Windows.Forms.ToolStripMenuItem();
            this.rclick_delete_conditions = new System.Windows.Forms.ToolStripMenuItem();
            this.rclick_delete_events = new System.Windows.Forms.ToolStripMenuItem();
            this.skill_tab = new System.Windows.Forms.TabControl();
            this.page1 = new System.Windows.Forms.TabPage();
            this.skill_title_menu.SuspendLayout();
            this.skill_rclick_menu.SuspendLayout();
            this.skill_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // skill_title_menu
            // 
            this.skill_title_menu.BackColor = System.Drawing.Color.Transparent;
            this.skill_title_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.click_to_edit,
            this.生成返回ToolStripMenuItem,
            this.添加预览条件ToolStripMenuItem,
            this.AddEvent,
            this.版本ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.skill_title_menu.Location = new System.Drawing.Point(0, 0);
            this.skill_title_menu.Name = "skill_title_menu";
            this.skill_title_menu.Size = new System.Drawing.Size(501, 25);
            this.skill_title_menu.TabIndex = 0;
            this.skill_title_menu.Text = "menuStrip1";
            // 
            // click_to_edit
            // 
            this.click_to_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delete_condition_menu,
            this.delete_event_menu,
            this.delete_all_conditions,
            this.delete_all_events});
            this.click_to_edit.ForeColor = System.Drawing.Color.White;
            this.click_to_edit.Name = "click_to_edit";
            this.click_to_edit.Size = new System.Drawing.Size(51, 21);
            this.click_to_edit.Text = "编辑&E";
            // 
            // delete_condition_menu
            // 
            this.delete_condition_menu.Name = "delete_condition_menu";
            this.delete_condition_menu.Size = new System.Drawing.Size(148, 22);
            this.delete_condition_menu.Text = "删除条件";
            this.delete_condition_menu.Click += new System.EventHandler(this.Delete_condition_menu_Click);
            // 
            // delete_event_menu
            // 
            this.delete_event_menu.Name = "delete_event_menu";
            this.delete_event_menu.Size = new System.Drawing.Size(148, 22);
            this.delete_event_menu.Text = "删除事件";
            this.delete_event_menu.Click += new System.EventHandler(this.Delete_event_menu_Click);
            // 
            // delete_all_conditions
            // 
            this.delete_all_conditions.Name = "delete_all_conditions";
            this.delete_all_conditions.Size = new System.Drawing.Size(148, 22);
            this.delete_all_conditions.Text = "删除所有条件";
            this.delete_all_conditions.Click += new System.EventHandler(this.Delete_all_conditions_Click);
            // 
            // delete_all_events
            // 
            this.delete_all_events.Name = "delete_all_events";
            this.delete_all_events.Size = new System.Drawing.Size(148, 22);
            this.delete_all_events.Text = "删除所有事件";
            this.delete_all_events.Click += new System.EventHandler(this.Delete_all_events_Click);
            // 
            // 生成返回ToolStripMenuItem
            // 
            this.生成返回ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Click_to_spawn,
            this.click_to_return});
            this.生成返回ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.生成返回ToolStripMenuItem.Name = "生成返回ToolStripMenuItem";
            this.生成返回ToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+R";
            this.生成返回ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.生成返回ToolStripMenuItem.Size = new System.Drawing.Size(118, 21);
            this.生成返回ToolStripMenuItem.Text = "生成-返回(Ctrl+R)";
            // 
            // Click_to_spawn
            // 
            this.Click_to_spawn.Name = "Click_to_spawn";
            this.Click_to_spawn.Size = new System.Drawing.Size(100, 22);
            this.Click_to_spawn.Text = "生成";
            this.Click_to_spawn.Click += new System.EventHandler(this.Click_to_spawn_Click);
            // 
            // click_to_return
            // 
            this.click_to_return.Name = "click_to_return";
            this.click_to_return.Size = new System.Drawing.Size(100, 22);
            this.click_to_return.Text = "返回";
            // 
            // 添加预览条件ToolStripMenuItem
            // 
            this.添加预览条件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemCondition,
            this.EntityCondition});
            this.添加预览条件ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.添加预览条件ToolStripMenuItem.Name = "添加预览条件ToolStripMenuItem";
            this.添加预览条件ToolStripMenuItem.Size = new System.Drawing.Size(105, 21);
            this.添加预览条件ToolStripMenuItem.Text = "添加/预览条件&C";
            // 
            // ItemCondition
            // 
            this.ItemCondition.Name = "ItemCondition";
            this.ItemCondition.Size = new System.Drawing.Size(124, 22);
            this.ItemCondition.Text = "物品条件";
            this.ItemCondition.Click += new System.EventHandler(this.ItemCondition_Click);
            // 
            // EntityCondition
            // 
            this.EntityCondition.Name = "EntityCondition";
            this.EntityCondition.Size = new System.Drawing.Size(124, 22);
            this.EntityCondition.Text = "实体条件";
            this.EntityCondition.Click += new System.EventHandler(this.EntityCondition_Click);
            // 
            // AddEvent
            // 
            this.AddEvent.ForeColor = System.Drawing.Color.White;
            this.AddEvent.Name = "AddEvent";
            this.AddEvent.Size = new System.Drawing.Size(105, 21);
            this.AddEvent.Text = "添加/预览事件&B";
            this.AddEvent.Click += new System.EventHandler(this.AddEvent_Click);
            // 
            // 版本ToolStripMenuItem
            // 
            this.版本ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.version1_12,
            this.version1_13});
            this.版本ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
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
            this.version1_12.Click += new System.EventHandler(this.Version1_12_Click);
            // 
            // version1_13
            // 
            this.version1_13.Checked = true;
            this.version1_13.CheckOnClick = true;
            this.version1_13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.version1_13.Name = "version1_13";
            this.version1_13.Size = new System.Drawing.Size(136, 22);
            this.version1_13.Text = "1.13及以上";
            this.version1_13.Click += new System.EventHandler(this.Version1_13_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About_skill_spawner});
            this.帮助ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.帮助ToolStripMenuItem.Text = "帮助&H";
            // 
            // About_skill_spawner
            // 
            this.About_skill_spawner.Name = "About_skill_spawner";
            this.About_skill_spawner.Size = new System.Drawing.Size(148, 22);
            this.About_skill_spawner.Text = "关于本生成器";
            this.About_skill_spawner.Click += new System.EventHandler(this.About_skill_spawner_Click);
            // 
            // skill_rclick_menu
            // 
            this.skill_rclick_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rclick_delete_contidion,
            this.rclick_delete_event,
            this.rclick_delete_conditions,
            this.rclick_delete_events});
            this.skill_rclick_menu.Name = "skill_rclick_menu";
            this.skill_rclick_menu.Size = new System.Drawing.Size(149, 92);
            // 
            // rclick_delete_contidion
            // 
            this.rclick_delete_contidion.Name = "rclick_delete_contidion";
            this.rclick_delete_contidion.Size = new System.Drawing.Size(148, 22);
            this.rclick_delete_contidion.Text = "删除条件";
            this.rclick_delete_contidion.Click += new System.EventHandler(this.Rclick_delete_contidion_Click);
            // 
            // rclick_delete_event
            // 
            this.rclick_delete_event.Name = "rclick_delete_event";
            this.rclick_delete_event.Size = new System.Drawing.Size(148, 22);
            this.rclick_delete_event.Text = "删除事件";
            this.rclick_delete_event.Click += new System.EventHandler(this.Rclick_delete_event_Click);
            // 
            // rclick_delete_conditions
            // 
            this.rclick_delete_conditions.Name = "rclick_delete_conditions";
            this.rclick_delete_conditions.Size = new System.Drawing.Size(148, 22);
            this.rclick_delete_conditions.Text = "删除所有条件";
            this.rclick_delete_conditions.Click += new System.EventHandler(this.Rclick_delete_conditions_Click);
            // 
            // rclick_delete_events
            // 
            this.rclick_delete_events.Name = "rclick_delete_events";
            this.rclick_delete_events.Size = new System.Drawing.Size(148, 22);
            this.rclick_delete_events.Text = "删除所有事件";
            this.rclick_delete_events.Click += new System.EventHandler(this.Rclick_delete_events_Click);
            // 
            // skill_tab
            // 
            this.skill_tab.Controls.Add(this.page1);
            this.skill_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skill_tab.Location = new System.Drawing.Point(0, 25);
            this.skill_tab.Name = "skill_tab";
            this.skill_tab.SelectedIndex = 0;
            this.skill_tab.Size = new System.Drawing.Size(501, 208);
            this.skill_tab.TabIndex = 2;
            // 
            // page1
            // 
            this.page1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.page1.Location = new System.Drawing.Point(4, 22);
            this.page1.Name = "page1";
            this.page1.Padding = new System.Windows.Forms.Padding(3);
            this.page1.Size = new System.Drawing.Size(493, 182);
            this.page1.TabIndex = 0;
            this.page1.Text = "1号条件";
            // 
            // skill_ui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(501, 233);
            this.ContextMenuStrip = this.skill_rclick_menu;
            this.Controls.Add(this.skill_tab);
            this.Controls.Add(this.skill_title_menu);
            this.MainMenuStrip = this.skill_title_menu;
            this.Name = "skill_ui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "技能生成器";
            this.skill_title_menu.ResumeLayout(false);
            this.skill_title_menu.PerformLayout();
            this.skill_rclick_menu.ResumeLayout(false);
            this.skill_tab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip skill_title_menu;
        private System.Windows.Forms.ToolStripMenuItem click_to_edit;
        private System.Windows.Forms.ToolStripMenuItem delete_condition_menu;
        private System.Windows.Forms.ToolStripMenuItem delete_event_menu;
        private System.Windows.Forms.ToolStripMenuItem delete_all_conditions;
        private System.Windows.Forms.ToolStripMenuItem delete_all_events;
        private System.Windows.Forms.ToolStripMenuItem 生成返回ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Click_to_spawn;
        private System.Windows.Forms.ToolStripMenuItem 版本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem version1_12;
        private System.Windows.Forms.ToolStripMenuItem version1_13;
        private System.Windows.Forms.ToolStripMenuItem 添加预览条件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ItemCondition;
        private System.Windows.Forms.ToolStripMenuItem EntityCondition;
        private System.Windows.Forms.ToolStripMenuItem AddEvent;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem About_skill_spawner;
        private System.Windows.Forms.ContextMenuStrip skill_rclick_menu;
        private System.Windows.Forms.ToolStripMenuItem rclick_delete_contidion;
        private System.Windows.Forms.ToolStripMenuItem rclick_delete_event;
        private System.Windows.Forms.ToolStripMenuItem rclick_delete_conditions;
        private System.Windows.Forms.ToolStripMenuItem rclick_delete_events;
        private System.Windows.Forms.TabControl skill_tab;
        private System.Windows.Forms.TabPage page1;
        private System.Windows.Forms.ToolStripMenuItem click_to_return;
    }
}