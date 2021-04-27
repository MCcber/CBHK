using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner
{
    public partial class triggers_form : Form
    {
        Type trigger_type = typeof(TriggersManager);
        //保存触发器方法组
        MethodInfo[] triggerMethods;
        //保存调用接受对象
        object triggers_obj;
        //需要添加的触发器索引
        int TriggerIndex = 0;
        //保存触发器列表
        string[] trigger_list;
        public triggers_form(int trigger_index)
        {
            InitializeComponent();
            Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            TriggerIndex = trigger_index;
            triggerMethods = trigger_type.GetMethods();
            var trigger_obj = Activator.CreateInstance(trigger_type);
            triggers_obj = trigger_obj;

            trigger_list = File.ReadAllLines(Application.StartupPath + "\\AdvancementTriggers\\triggers.ini");

            //初始化触发器
            add_trigger();

            Button setplayer = Controls.Find("set_player", true)[0] as Button;
            setplayer.Tag = "\"player\":[]";
        }

        private void triggers_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Tag != null)
            {
                Tag = Tag.ToString().TrimEnd(',');
                DialogResult = DialogResult.OK;
            }
        }

        private void add_trigger()
        {
            trigger_tip.SetToolTip(this,trigger_list[TriggerIndex]);
            Controls.Add(trigger_type.InvokeMember(triggerMethods[TriggerIndex].Name, BindingFlags.InvokeMethod, null, triggers_obj, Array.Empty<object>()) as Control);
        }
    }
}
