using cbhk_editor.MainForm;
using cbhk_editor.ToolClasses;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace cbhk_editor.welcome_form
{
    public partial class WelcomeForm : Form
    {
        #region 保存注册表,指令语法树等对象的引用
        public TreeView register = new TreeView();
        public TreeView command = new TreeView();
        public TreeView block = new TreeView();
        public TreeView EntityNBT = new TreeView();
        #endregion
        //是否可以关闭窗体
        bool CanClose = false;
        public WelcomeForm()
        {
            InitializeComponent();
            Icon = null;
        }

        private void WelcomeForm_Shown(object sender, System.EventArgs e)
        {
            if (!Directory.Exists(Application.StartupPath + "\\generates"))
            {
                handle_lable.Text = "正在爬取1.16.3.jar...";
                Application.DoEvents();
                string file_result = login_tool.GetJarFile("https://www.tcotp.cn/download/Minecraft_Server/minecraft_server.1.16.3.jar", Application.StartupPath + "\\minecraft1.16.3.jar");
                if (file_result == "success")
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\generates");
                    handle_lable.Text = "爬取成功";
                    Application.DoEvents();
                }
            }

            if (!Directory.Exists(Application.StartupPath + "\\generates\\generated1.16.3"))
            {
                handle_lable.Text = "开始解析1.16.3.jar文件";
                ProcessStartInfo startInfo = new ProcessStartInfo()
                {
                    CreateNoWindow = true,
                    Arguments = "/c java -cp " + Application.StartupPath + "\\minecraft1.16.3.jar" + " net.minecraft.data.Main --all",
                    FileName = "cmd.exe",
                    UseShellExecute = false
                };
                Process.Start(startInfo).WaitForExit();
            }

            #region 反序列化或序列化registries.json
            Bind_TreeView register_treeview = new Bind_TreeView();
            if (!File.Exists(Application.StartupPath + "\\generates\\generated1.16.3\\reports\\registries"))
            {
                handle_lable.Text = "正在反序列化registries.json";
                Application.DoEvents();
                TreeNode registries = new TreeNode { };
                string register_content = File.ReadAllText(Application.StartupPath + "\\generates\\generated1.16.3\\reports\\registries.json", new UTF8Encoding(false));
                register_treeview.BindTreeView(registries, register_content);

                register.Nodes.Add(registries);
                SerializeTree.TreeViewDataAccess.SaveTreeViewData(register, Application.StartupPath + "\\generates\\generated1.16.3\\reports\\registries");
            }
            else
            {
                handle_lable.Text = "正在序列化registries";

                SerializeTree.TreeViewDataAccess.LoadTreeViewData(register, Application.StartupPath + "\\generates\\generated1.16.3\\reports\\registries");
            }
            #endregion

            #region 反序列化或序列化commands.json
            Bind_TreeView command_treeview = new Bind_TreeView();
            if (!File.Exists(Application.StartupPath + "\\generates\\generated1.16.3\\reports\\commands"))
            {
                handle_lable.Text = "正在反序列化commands.json";
                Application.DoEvents();
                TreeNode commands = new TreeNode();
                string command_content = File.ReadAllText(Application.StartupPath + "\\generates\\generated1.16.3\\reports\\commands.json", new UTF8Encoding(false));
                command_treeview.BindTreeView(commands, command_content);

                command.Nodes.Add(commands);
                SerializeTree.TreeViewDataAccess.SaveTreeViewData(command, Application.StartupPath + "\\generates\\generated1.16.3\\reports\\commands");
            }
            else
            {
                handle_lable.Text = "正在序列化commands";
                Application.DoEvents();
                Thread.Sleep(1000);

                SerializeTree.TreeViewDataAccess.LoadTreeViewData(command, Application.StartupPath + "\\generates\\generated1.16.3\\reports\\commands");
            }
            #endregion

            #region 反序列化或序列化blocks.json
            Bind_TreeView block_treeview = new Bind_TreeView();
            if (!File.Exists(Application.StartupPath + "\\generates\\generated1.16.3\\reports\\blocks"))
            {
                handle_lable.Text = "正在反序列化blocks.json";
                Application.DoEvents();
                TreeNode blocks = new TreeNode();
                string block_content = File.ReadAllText(Application.StartupPath + "\\generates\\generated1.16.3\\reports\\blocks.json", new UTF8Encoding(false));
                block_treeview.BindTreeView(blocks, block_content);

                block.Nodes.Add(blocks);
                SerializeTree.TreeViewDataAccess.SaveTreeViewData(block, Application.StartupPath + "\\generates\\generated1.16.3\\reports\\blocks");
            }
            else
            {
                handle_lable.Text = "正在序列化blocks";
                Application.DoEvents();
                Thread.Sleep(1000);

                SerializeTree.TreeViewDataAccess.LoadTreeViewData(block, Application.StartupPath + "\\generates\\generated1.16.3\\reports\\blocks");
            }
            #endregion

            #region 开启实体NBT爬取程序
            Bind_TreeView entity_nbt_treeview = new Bind_TreeView();
            if(!File.Exists(Application.StartupPath+ "\\ToolPrograms\\entity_datas") && File.Exists(Application.StartupPath+ "\\ToolPrograms\\minecraft_nbt_spider.exe"))
            {
                handle_lable.Text = "正在爬取所有实体NBT数据..";
                Application.DoEvents();
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.Start();

                string cmd = Application.StartupPath + "\\ToolPrograms\\minecraft_nbt_spider.exe --output-file " + Application.StartupPath + "\\ToolPrograms\\entity_datas.json";
                p.StandardInput.WriteLine(cmd+"&exit");
                p.StandardInput.AutoFlush = true;
                p.WaitForExit(3000);
                p.Close();
            }
            #endregion
        }

        private void File_watcher_Tick(object sender, System.EventArgs e)
        {
            #region 处理jar文件夹
            if (Directory.Exists(Application.StartupPath + "\\generated\\reports") && Directory.Exists(Application.StartupPath + "\\logs"))
            {
                Directory.Delete(Application.StartupPath + "\\logs", true);
                Directory.Move(Application.StartupPath + "\\generated", Application.StartupPath + "\\generates\\generated1.16.3");
                Thread.Sleep(1000);
            }
            if (Directory.Exists(Application.StartupPath + "\\generates\\generated1.16.3"))
                File.Delete(Application.StartupPath + "\\minecraft1.16.3.jar");
            #endregion

            #region 反序列化实体NBT数据文件
            Bind_TreeView entity_nbt_treeview = new Bind_TreeView();
            if (!File.Exists(Application.StartupPath + "\\ToolPrograms\\entity_datas") && File.Exists(Application.StartupPath + "\\ToolPrograms\\entity_datas.json"))
            {
                string entity_nbt_file = File.ReadAllText(Application.StartupPath+ "\\ToolPrograms\\entity_datas.json",new UTF8Encoding(false));
                TreeNode entity_nbt = new TreeNode();
                TreeView entityNBT = new TreeView();
                entity_nbt_treeview.BindTreeView(entity_nbt,entity_nbt_file);
                entityNBT.Nodes.Add(entity_nbt);
                SerializeTree.TreeViewDataAccess.SaveTreeViewData(entityNBT,Application.StartupPath+ "\\ToolPrograms\\entity_datas");
                CanClose = true;
            }

            if(File.Exists(Application.StartupPath + "\\ToolPrograms\\entity_datas"))
            {
                SerializeTree.TreeViewDataAccess.LoadTreeViewData(EntityNBT,Application.StartupPath+ "\\ToolPrograms\\entity_datas");
                CanClose = true;
            }
            #endregion
            if (CanClose || !SystemInformation.Network)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
