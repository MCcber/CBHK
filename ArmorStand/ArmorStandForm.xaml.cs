using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using Button = System.Windows.Controls.Button;
using CheckBox = System.Windows.Controls.CheckBox;
using Control = System.Windows.Controls.Control;
using Cursors = System.Windows.Input.Cursors;

namespace ArmorStand
{
    /// <summary>
    /// ArmorStandForm.xaml 的交互逻辑
    /// </summary>
    public partial class ArmorStandForm : Window
    {
        //根目录
        //AppDomain.CurrentDomain.BaseDirectory

        //as的所有NBT项
        string[] as_nbt = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory+ "\\ArmorStandNBT\\base_nbt.ini");
        //调用此窗体的对象
        Form parent_form;

        #region 所有3D视图对象
        private WpfCube Head_cube = new WpfCube(new Point3D(0.0, 12.5, 0.0), 1.0, 3.0, 1.0);

        private WpfCube Lhand_cube = new WpfCube(new Point3D(3.0, 10.0, 0.0), 1.0, 5.0, 1.0);

        private WpfCube Rhand_cube = new WpfCube(new Point3D(-3.0, 10.0, 0.0), 1.0, 5.0, 1.0);

        private WpfCube Lleg_cube = new WpfCube(new Point3D(1.0, 5.0, 0.0), 1.0, 5.0, 1.0);

        private WpfCube Rleg_cube = new WpfCube(new Point3D(-1.0, 5.0, 0.0), 1.0, 5.0, 1.0);

        private WpfCube Top_cube = new WpfCube(new Point3D(-3.0, 10.0, 0.0), 7.0, 1.0, 1.0);

        private WpfCube Bottom_cube = new WpfCube(new Point3D(-1.5, 5.0, 0.0), 4.0, 1.0, 1.0);

        private WpfCube Left_cube = new WpfCube(new Point3D(1.0, 5.0, 0.0), 1.0, -5.0, 1.0);

        private WpfCube Right_cube = new WpfCube(new Point3D(-1.0, 5.0, 0.0), 1.0, -5.0, 1.0);

        private WpfCube BasePlate_cube = new WpfCube(new Point3D(-4.5, 0.0, -4.5), 10.0, 1.0, 10.0);

        private WpfCube X_axis_cube = new WpfCube(new Point3D(0.0, 0.0, 0.0), 100.0, 0.1, 0.1);

        private WpfCube Y_axis_cube = new WpfCube(new Point3D(0.0, 0.0, 0.0), 0.1, -100.0, 0.1);

        private WpfCube Z_axis_cube = new WpfCube(new Point3D(0.0, 0.0, 0.0), 0.1, 0.1, 100.0);

        private GeometryModel3D Head_cubeModel;

        private GeometryModel3D Lhand_cubeModel;

        private GeometryModel3D Rhand_cubeModel;

        private GeometryModel3D Lleg_cubeModel;

        private GeometryModel3D Rleg_cubeModel;

        private GeometryModel3D Top_cubeModel;

        private GeometryModel3D Bottom_cubeModel;

        private GeometryModel3D Left_cubeModel;

        private GeometryModel3D Right_cubeModel;

        private GeometryModel3D BasePlate_cubeModel;

        private GeometryModel3D X_axis_cubeModel;

        private GeometryModel3D Y_axis_cubeModel;

        private GeometryModel3D Z_axis_cubeModel;

        private Model3DGroup groupScene = new Model3DGroup();

        private double pos_x = -15.0;

        private double pos_y = -10.0;

        private double pos_z = -15.0;

        private Vector3D zero_pos = new Vector3D(0.0, 0.0, 0.0);

        private double motion_x;

        private double motion_y;

        private double motion_z;

        private double Camera_pos_x = 15.0;

        private bool Mousedown = false;

        private double mouse_pos_x = 0.0;

        private double mouse_pos_y = 0.0;

        private double move_x;

        private double move_y;

        private double mouse_move_x;

        private double mouse_move_y;

        private Viewport3D AS_model;
        #endregion

        public ArmorStandForm(Form obj)
        {
            InitializeComponent();
            Icon = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory+ "\\ResourceImages\\CB图标.ico"));
            parent_form = obj;
            //初始化UI
            InitUISetting();
        }

        public void InitUISetting()
        {
            Width = 800;
            Height = 606;
            armor_stand_tab.Cursor = Cursors.SizeAll;
            foreach (string a_nbt in as_nbt)
            {
                CheckBox nbt_box = new CheckBox()
                {
                    Content = a_nbt,
                    Name = a_nbt,
                    FontSize = 20,
                    Foreground = new SolidColorBrush(Color.FromArgb(255, 168, 168, 168)),
                    Background = new SolidColorBrush(Color.FromArgb(255, 168, 168, 168)),
                    Opacity = 1
                };
                switch (a_nbt)
                {
                    case "ShowArms":
                        {
                            nbt_box.Click += (a,b) => {
                                CheckBox this_obj = a as CheckBox;
                                if (this_obj.IsChecked == true)
                                {
                                    groupScene.Children.Add(Lhand_cubeModel);
                                    groupScene.Children.Add(Rhand_cubeModel);
                                }
                                else
                                {
                                    groupScene.Children.Remove(Lhand_cubeModel);
                                    groupScene.Children.Remove(Rhand_cubeModel);
                                }
                            };
                            break;
                        }
                    case "Pose":
                        {
                            nbt_box.Click += (a,b) => {
                                CheckBox this_obj = a as CheckBox;
                                pose_page.IsEnabled = this_obj.IsChecked.Value;
                            };
                            break;
                        }
                    case "NoBasePlate":
                        {
                            nbt_box.Click += (a,b) => {
                                CheckBox this_obj = a as CheckBox;
                                if (this_obj.IsChecked == true)
                                {
                                    groupScene.Children.Remove(BasePlate_cubeModel);
                                }
                                else if (this_obj.IsChecked == false)
                                {
                                    groupScene.Children.Add(BasePlate_cubeModel);
                                }
                            };
                            break;
                        }
                }
                nbt_area.Children.Add(nbt_box);
            }
        }

        private void Head_item_Click(object sender, RoutedEventArgs e)
        {
            Item_form item_Form = new Item_form("头部物品信息",sender as Control);
            ElementHost.EnableModelessKeyboardInterop(GetWindow(item_Form));
            item_Form.Show();
        }

        private void Chest_item_Click(object sender, RoutedEventArgs e)
        {
            Item_form item_Form = new Item_form("胸部物品信息", sender as Control);
            ElementHost.EnableModelessKeyboardInterop(GetWindow(item_Form));
            item_Form.Show();
        }

        private void Leg_item_Click(object sender, RoutedEventArgs e)
        {
            Item_form item_Form = new Item_form("腿部物品信息", sender as Control);
            ElementHost.EnableModelessKeyboardInterop(GetWindow(item_Form));
            item_Form.Show();
        }

        private void Feet_item_Click(object sender, RoutedEventArgs e)
        {
            Item_form item_Form = new Item_form("脚部物品信息", sender as Control);
            ElementHost.EnableModelessKeyboardInterop(GetWindow(item_Form));
            item_Form.Show();
        }

        private void Lefthand_item_Click(object sender, RoutedEventArgs e)
        {
            Item_form item_Form = new Item_form("左手物品信息", sender as Control);
            ElementHost.EnableModelessKeyboardInterop(GetWindow(item_Form));
            item_Form.Show();
        }

        private void Righthand_item_Click(object sender, RoutedEventArgs e)
        {
            Item_form item_Form = new Item_form("右手物品信息", sender as Control);
            ElementHost.EnableModelessKeyboardInterop(GetWindow(item_Form));
            item_Form.Show();
        }

        private void Click_to_spawn_Click(object sender, RoutedEventArgs e)
        {
            int d_head = (dHead.IsChecked == true) ? 16 : 0;
            int d_chest = (dChest.IsChecked == true) ? 8 : 0;
            int d_legs = (dLegs.IsChecked == true) ? 4 : 0;
            int d_boots = (dBoots.IsChecked == true) ? 2 : 0;
            int d_hand = (dHand.IsChecked == true) ? 1 : 0;
            int d_sum = d_head + d_chest + d_legs + d_boots + d_hand;
            int r_head = (rHead.IsChecked == true) ? 4096 : 0;
            int r_chest = (rChest.IsChecked == true) ? 2048 : 0;
            int r_legs = (rLegs.IsChecked == true) ? 1024 : 0;
            int r_boots = (rBoots.IsChecked == true) ? 512 : 0;
            int r_hand = (rHand.IsChecked == true) ? 256 : 0;
            int r_sum = r_head + r_chest + r_legs + r_boots + r_hand;
            int p_head = (pHead.IsChecked == true) ? 1048576 : 0;
            int p_chest = (pChest.IsChecked == true) ? 524288 : 0;
            int p_legs = (pLegs.IsChecked == true) ? 262144 : 0;
            int p_boots = (pBoots.IsChecked == true) ? 131072 : 0;
            int p_hand = (pHand.IsChecked == true) ? 65536 : 0;
            int p_sum = p_hand + p_chest + p_legs + p_boots;
            int body_part_sum = d_sum + r_sum + p_sum + p_head;
            string result;
            string boots_item = (FeetItem.Tag != null) ? FeetItem.Tag.ToString().Trim() : "{}";
            string legs_item = (LegItem.Tag != null) ? LegItem.Tag.ToString().Trim() : "{}";
            string chest_item = (ChestItem.Tag != null) ? ChestItem.Tag.ToString().Trim() : "{}";
            string head_item = (HeadItem.Tag != null) ? HeadItem.Tag.ToString().Trim() : "{}";
            string armorItems = "ArmorItems:[" + boots_item + "," + legs_item + "," + chest_item + "," + head_item + "],";
            if (Regex.Replace(armorItems.Replace("ArmorItems:", ""), "[\\p{S}\\p{C}\\p{P}]", "").Trim() == "")
            {
                armorItems = "";
            }
            string mainHandItem = (LeftHandItem.Tag != null) ? LeftHandItem.Tag.ToString().Trim() : "{}";
            string offHandItem = (RightHandItem.Tag != null) ? RightHandItem.Tag.ToString().Trim() : "{}";
            string handItems = "HandItems:[" + mainHandItem + "," + offHandItem + "]";
            if (Regex.Replace(handItems.Replace("HandItems:", ""), "[\\p{S}\\p{C}\\p{P}]", "").Trim() == "")
            {
                handItems = "";
            }
            string equipmentItems = ((armorItems.Trim() != "") ? armorItems : "") + ((handItems.Trim() != "") ? handItems : "");

            //合并NBT信息
            string NBTInfo = "";
            foreach (UIElement a_nbt in nbt_area.Children)
            {
                if(a_nbt is CheckBox)
                {
                    CheckBox this_obj = a_nbt as CheckBox;
                    if(this_obj.IsChecked.Value && !this_obj.Content.ToString().Contains("Pose"))
                    NBTInfo += this_obj.Content+":"+this_obj.IsChecked.ToString().ToLower()+",";
                }
            }
            result = "/summon armor_stand ~ ~ ~ {" + NBTInfo + ((pose_page.IsEnabled == true) ? ("Pose:{Head:[" + head_x.Value.ToString() + "f, " + head_y.Value.ToString() + "f, " + head_z.Value.ToString() + "f],Body:[" + body_x.Value.ToString() + "f, " + body_y.Value.ToString() + "f, " + body_z.Value.ToString() + "f],LeftArm:[" + lhand_x.Value.ToString() + "f, " + lhand_y.Value.ToString() + "f, " + lhand_z.Value.ToString() + "f],RightArm:[" + rhand_z.Value.ToString() + "f, " + rhand_y.Value.ToString() + "f, " + rhand_z.Value.ToString() + "f],LeftLeg:[" + lleg_x.Value.ToString() + "f, " + lleg_y.Value.ToString() + "f, " + lleg_z.Value.ToString() + "f],RightLeg:[" + rleg_z.Value.ToString() + "f, " + rleg_y.Value.ToString() + "f, " + rleg_z.Value.ToString() + "f]},") : "") + ((body_part_sum == 0) ? "" : ("DisabledSlots:" + body_part_sum.ToString() + ",")) + equipmentItems;
            Item_form as_info = new Item_form(result.TrimEnd(',')+"}",sender as Control);
            as_info.Show();
        }

        private void Click_to_return_Click(object sender, RoutedEventArgs e)
        {
            parent_form.TopMost = true;
            parent_form.ShowInTaskbar = true;
            parent_form.WindowState = FormWindowState.Normal;
            Close();
            parent_form.TopMost = false;
        }

        public void TurnModel(Point3D center, GeometryModel3D model, double seconds, bool axis, Slider X, Slider Y, Slider Z)
        {
            Vector3D vector5 = new Vector3D(0.0, 1.0, 0.0);
            Vector3D vector4 = new Vector3D(1.0, 0.0, 0.0);
            Vector3D vector3 = new Vector3D(0.0, 0.0, 1.0);
            AxisAngleRotation3D rotation5 = new AxisAngleRotation3D(vector5, 0.0);
            AxisAngleRotation3D rotation4 = new AxisAngleRotation3D(vector4, 0.0);
            AxisAngleRotation3D rotation3 = new AxisAngleRotation3D(vector3, 0.0);
            RotateTransform3D rotateTransform5 = new RotateTransform3D(rotation5, center);
            RotateTransform3D rotateTransform4 = new RotateTransform3D(rotation4, center);
            RotateTransform3D rotateTransform3 = new RotateTransform3D(rotation3, center);
            Transform3DGroup transformGroup = new Transform3DGroup();
            transformGroup.Children.Add(rotateTransform5);
            transformGroup.Children.Add(rotateTransform4);
            transformGroup.Children.Add(rotateTransform3);
            model.Transform = transformGroup;
            if (axis)
            {
                DoubleAnimation doubleAnimation5 = new DoubleAnimation(Y.Value, Y.Value, DurationTS(seconds))
                {
                    BeginTime = DurationTS(0.0)
                };
                rotation5.BeginAnimation(AxisAngleRotation3D.AngleProperty, doubleAnimation5);
                DoubleAnimation doubleAnimation4 = new DoubleAnimation(X.Value, X.Value, DurationTS(seconds))
                {
                    BeginTime = DurationTS(0.0)
                };
                rotation4.BeginAnimation(AxisAngleRotation3D.AngleProperty, doubleAnimation4);
                DoubleAnimation doubleAnimation3 = new DoubleAnimation(Z.Value, Z.Value, DurationTS(seconds))
                {
                    BeginTime = DurationTS(0.0)
                };
                rotation3.BeginAnimation(AxisAngleRotation3D.AngleProperty, doubleAnimation3);
            }
        }

        private int DurationM(double seconds)
        {
            return (int)(seconds * 1000.0);
        }

        public TimeSpan DurationTS(double seconds)
        {
            return new TimeSpan(0, 0, 0, 0, DurationM(seconds));
        }

        public PerspectiveCamera Camera(double x, double y, double z, int fieldofView, Vector3D xyz_rotation)
        {
            return new PerspectiveCamera
            {
                Position = new Point3D(x, y, z),
                FieldOfView = fieldofView,
                LookDirection = xyz_rotation
            };
        }

        public DirectionalLight PositionLight(Point3D position)
        {
            return new DirectionalLight
            {
                Color = Colors.Gray,
                Direction = new Point3D(0.0, 0.0, 0.0) - position
            };
        }

        private void Armor_stand_tab_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Mousedown = true;
            mouse_pos_x = e.GetPosition(this).X;
            mouse_pos_y = e.GetPosition(this).Y;
        }

        private void Armor_stand_tab_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Mousedown = false;
            move_x = mouse_move_x;
            move_y = mouse_move_y;
        }

        private void Armor_stand_tab_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (Mousedown)
            {
                mouse_move_x = 0.01 * (e.GetPosition(this).X - mouse_pos_x) + move_x;
                mouse_move_y = 0.01 * (e.GetPosition(this).Y - mouse_pos_y) + move_y;
                pos_x = Camera_pos_x * Math.Cos(mouse_move_x) * Math.Cos(mouse_move_y);
                pos_y = Camera_pos_x * Math.Sin(mouse_move_y) * -1.0;
                pos_z = Camera_pos_x * Math.Sin(mouse_move_x) * Math.Cos(mouse_move_y);
                motion_x = zero_pos.X - pos_x;
                motion_y = zero_pos.Y - pos_y;
                motion_z = zero_pos.Z - pos_z;
                AS_model.Camera = Camera(pos_x, pos_y, pos_z, 90, new Vector3D(motion_x, motion_y, motion_z));
            }
        }

        private void Armor_stand_tab_MouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            double x_move = zero_pos.X - pos_x;
            double y_move = zero_pos.Y - pos_y;
            double z_move = zero_pos.Z - pos_z;
            if (e.Delta > 0)
            {
                pos_x += x_move * 0.1;
                pos_y += y_move * 0.1;
                pos_z += z_move * 0.1;
                AS_model.Camera = Camera(pos_x, pos_y, pos_z, 60, new Vector3D(zero_pos.X - pos_x, zero_pos.Y - pos_y, zero_pos.Z - pos_z));
                Camera_pos_x = Math.Sqrt(Math.Pow(pos_x, 2.0) + Math.Pow(pos_y, 2.0) + Math.Pow(pos_z, 2.0));
            }
            else if (e.Delta < 0)
            {
                pos_x -= x_move * 0.1;
                pos_y -= y_move * 0.1;
                pos_z -= z_move * 0.1;
                AS_model.Camera = Camera(pos_x, pos_y, pos_z, 60, new Vector3D(zero_pos.X - pos_x, zero_pos.Y - pos_y, zero_pos.Z - pos_z));
                Camera_pos_x = Math.Sqrt(Math.Pow(pos_x, 2.0) + Math.Pow(pos_y, 2.0) + Math.Pow(pos_z, 2.0));
            }
        }

        private void Armor_stand_area_Loaded(object sender, RoutedEventArgs e)
        {
            if (sender is Viewport3D MainWindow)
            {
                Head_cubeModel = Head_cube.CreateModel(Colors.BurlyWood);
                Lhand_cubeModel = Lhand_cube.CreateModel(Colors.BurlyWood);
                Rhand_cubeModel = Rhand_cube.CreateModel(Colors.BurlyWood);
                Lleg_cubeModel = Lleg_cube.CreateModel(Colors.BurlyWood);
                Rleg_cubeModel = Rleg_cube.CreateModel(Colors.BurlyWood);
                Top_cubeModel = Top_cube.CreateModel(Colors.BurlyWood);
                Bottom_cubeModel = Bottom_cube.CreateModel(Colors.BurlyWood);
                Left_cubeModel = Left_cube.CreateModel(Colors.BurlyWood);
                Right_cubeModel = Right_cube.CreateModel(Colors.BurlyWood);
                BasePlate_cubeModel = BasePlate_cube.CreateModel(Colors.Gray);
                X_axis_cubeModel = X_axis_cube.CreateModel(Colors.Red);
                Y_axis_cubeModel = Y_axis_cube.CreateModel(Colors.Green);
                Z_axis_cubeModel = Z_axis_cube.CreateModel(Colors.Purple);
                groupScene.Children.Add(Head_cubeModel);
                groupScene.Children.Add(Lleg_cubeModel);
                groupScene.Children.Add(Rleg_cubeModel);
                groupScene.Children.Add(Top_cubeModel);
                groupScene.Children.Add(Bottom_cubeModel);
                groupScene.Children.Add(Left_cubeModel);
                groupScene.Children.Add(Right_cubeModel);
                groupScene.Children.Add(BasePlate_cubeModel);
                groupScene.Children.Add(X_axis_cubeModel);
                groupScene.Children.Add(Y_axis_cubeModel);
                groupScene.Children.Add(Z_axis_cubeModel);
                groupScene.Children.Add(PositionLight(new Point3D(-5.0, 10.0, 0.0)));
                groupScene.Children.Add(new AmbientLight(Colors.LightGray));
                ModelVisual3D visual = new ModelVisual3D
                {
                    Content = groupScene
                };
                MainWindow.Children.Add(visual);
                MainWindow.Camera = Camera(15.0, 10.0, 15.0, 90, new Vector3D(-15.0, -10.0, -15.0));
                AS_model = MainWindow;
            }
        }

        private void Head_x_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TurnModel(new Point3D(0.5, 9.5, 0.5), Head_cubeModel, 0.02, axis: true, head_x, head_y, head_z);
            head_x_value.Text = head_x.Value.ToString();
        }

        private void Head_y_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TurnModel(new Point3D(0.5, 9.5, 0.5), Head_cubeModel, 0.02, axis: true, head_x, head_y, head_z);
            head_y_value.Text = head_y.Value.ToString();
        }

        private void Head_z_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TurnModel(new Point3D(0.5, 9.5, 0.5), Head_cubeModel, 0.02, axis: true, head_x, head_y, head_z);
            head_z_value.Text = head_z.Value.ToString();
        }

        private void Body_x_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TurnModel(new Point3D(0.5, 9.5, 0.5), Top_cubeModel, 0.02, axis: true, body_x, body_y, body_z);
            TurnModel(new Point3D(0.5, 9.5, 0.5), Bottom_cubeModel, 0.02, axis: true, body_x, body_y, body_z);
            TurnModel(new Point3D(0.5, 9.5, 0.5), Left_cubeModel, 0.02, axis: true, body_x, body_y, body_z);
            TurnModel(new Point3D(0.5, 9.5, 0.5), Right_cubeModel, 0.02, axis: true, body_x, body_y, body_z);
            body_x_value.Text = body_x.Value.ToString();
        }

        private void Body_y_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TurnModel(new Point3D(0.5, 9.5, 0.5), Top_cubeModel, 0.02, axis: true, body_x, body_y, body_z);
            TurnModel(new Point3D(0.5, 9.5, 0.5), Bottom_cubeModel, 0.02, axis: true, body_x, body_y, body_z);
            TurnModel(new Point3D(0.5, 9.5, 0.5), Left_cubeModel, 0.02, axis: true, body_x, body_y, body_z);
            TurnModel(new Point3D(0.5, 9.5, 0.5), Right_cubeModel, 0.02, axis: true, body_x, body_y, body_z);
            body_y_value.Text = body_y.Value.ToString();
        }

        private void Body_z_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TurnModel(new Point3D(0.5, 9.5, 0.5), Top_cubeModel, 0.02, axis: true, body_x, body_y, body_z);
            TurnModel(new Point3D(0.5, 9.5, 0.5), Bottom_cubeModel, 0.02, axis: true, body_x, body_y, body_z);
            TurnModel(new Point3D(0.5, 9.5, 0.5), Left_cubeModel, 0.02, axis: true, body_x, body_y, body_z);
            TurnModel(new Point3D(0.5, 9.5, 0.5), Right_cubeModel, 0.02, axis: true, body_x, body_y, body_z);
            body_z_value.Text = body_z.Value.ToString();
        }

        private void Lhand_x_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TurnModel(new Point3D(3.5, 9.5, 0.5), Lhand_cubeModel, 0.02, axis: true, lhand_x, lhand_y, lhand_z);
            lhand_x_value.Text = lhand_x.Value.ToString();
        }

        private void Lhand_y_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TurnModel(new Point3D(3.5, 9.5, 0.5), Lhand_cubeModel, 0.02, axis: true, lhand_x, lhand_y, lhand_z);
            lhand_y_value.Text = lhand_y.Value.ToString();
        }

        private void Lhand_z_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TurnModel(new Point3D(3.5, 9.5, 0.5), Lhand_cubeModel, 0.02, axis: true, lhand_x, lhand_y, lhand_z);
            lhand_z_value.Text = lhand_z.Value.ToString();
        }

        private void Rhand_x_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TurnModel(new Point3D(-2.5, 9.5, 0.5), Rhand_cubeModel, 0.02, axis: true, rhand_x, rhand_y, rhand_z);
            rhand_x_value.Text = rhand_x.Value.ToString();
        }

        private void Rhand_y_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TurnModel(new Point3D(-2.5, 9.5, 0.5), Rhand_cubeModel, 0.02, axis: true, rhand_x, rhand_y, rhand_z);
            rhand_y_value.Text = rhand_y.Value.ToString();
        }

        private void Rhand_z_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TurnModel(new Point3D(-2.5, 9.5, 0.5), Rhand_cubeModel, 0.02, axis: true, rhand_x, rhand_y, rhand_z);
            rhand_z_value.Text = rhand_z.Value.ToString();
        }

        private void Lleg_x_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TurnModel(new Point3D(1.5, 4.5, 0.5), Lleg_cubeModel, 0.02, axis: true, lleg_x, lleg_y, lleg_z);
            lleg_x_value.Text = lleg_x.Value.ToString();
        }

        private void Lleg_y_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TurnModel(new Point3D(1.5, 4.5, 0.5), Lleg_cubeModel, 0.02, axis: true, lleg_x, lleg_y, lleg_z);
            lleg_y_value.Text = lleg_y.Value.ToString();
        }

        private void Lleg_z_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TurnModel(new Point3D(1.5, 4.5, 0.5), Lleg_cubeModel, 0.02, axis: true, lleg_x, lleg_y, lleg_z);
            lleg_z_value.Text = lleg_z.Value.ToString();
        }

        private void Rleg_x_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TurnModel(new Point3D(-0.5, 4.5, 0.5), Rleg_cubeModel, 0.02, axis: true, rleg_x, rleg_y, rleg_z);
            rleg_x_value.Text = rleg_x.Value.ToString();
        }

        private void Rleg_y_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TurnModel(new Point3D(-0.5, 4.5, 0.5), Rleg_cubeModel, 0.02, axis: true, rleg_x, rleg_y, rleg_z);
            rleg_y_value.Text = rleg_y.Value.ToString();
        }

        private void Rleg_z_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TurnModel(new Point3D(-0.5, 4.5, 0.5), Rleg_cubeModel, 0.02, axis: true, rleg_x, rleg_y, rleg_z);
            rleg_z_value.Text = rleg_z.Value.ToString();
        }

        private void Reset_head_Click(object sender, RoutedEventArgs e)
        {
            head_x.Value = head_y.Value = head_z.Value = 0;
            head_x_value.Text = head_y_value.Text = head_z_value.Text = "0";
        }

        private void Reset_body_Click(object sender, RoutedEventArgs e)
        {
            body_x.Value = body_y.Value = body_z.Value = 0;
            body_x_value.Text = body_y_value.Text = body_z_value.Text = "0";
        }

        private void Reset_lhand_Click(object sender, RoutedEventArgs e)
        {
            lhand_x.Value = lhand_y.Value = lhand_z.Value = 0;
            lhand_x_value.Text = lhand_y_value.Text = lhand_z_value.Text = "0";
        }

        private void Reset_rhand_Click(object sender, RoutedEventArgs e)
        {
            rhand_x.Value = rhand_y.Value = rhand_z.Value = 0;
            rhand_x_value.Text = rhand_y_value.Text = rhand_z_value.Text = "0";
        }

        private void Reset_lleg_Click(object sender, RoutedEventArgs e)
        {
            lleg_x.Value = lleg_y.Value = lleg_z.Value = 0;
            lleg_x_value.Text = lleg_y_value.Text = lleg_z_value.Text = "0";
        }

        private void Reset_rleg_Click(object sender, RoutedEventArgs e)
        {
            rleg_x.Value = rleg_y.Value = rleg_z.Value = 0;
            rleg_x_value.Text = rleg_y_value.Text = rleg_z_value.Text = "0";
        }
    }

    public static class Rotate3DModel
    {
        public static Vector3D Rotate(this Vector3D vector3D, double x, double y, double z)
        {
            Matrix3D rotateX = new Matrix3D(1.0, 0.0, 0.0, 0.0, 0.0, Math.Cos(x), Math.Sin(x), 0.0, 0.0, 0.0 - Math.Sin(x), Math.Cos(x), 0.0, 0.0, 0.0, 0.0, 1.0);
            Matrix3D rotateY = new Matrix3D(Math.Cos(y), 0.0, 0.0 - Math.Sin(y), 0.0, 0.0, 1.0, 0.0, 0.0, Math.Sin(y), 0.0, Math.Cos(y), 0.0, 0.0, 0.0, 0.0, 1.0);
            Matrix3D rotateZ = new Matrix3D(Math.Cos(z), Math.Sin(z), 0.0, 0.0, 0.0 - Math.Sin(z), Math.Cos(z), 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0);
            return vector3D * rotateX * rotateY * rotateZ;
        }
    }

    internal class WpfTriangle
    {
        private Point3D p1;

        private Point3D p2;

        private Point3D p3;

        public WpfTriangle(Point3D P1, Point3D P2, Point3D P3)
        {
            p1 = P1;
            p2 = P2;
            p3 = P3;
        }

        public static void AddTriangleToMesh(Point3D p0, Point3D p1, Point3D p2, MeshGeometry3D mesh)
        {
            AddTriangleToMesh(p0, p1, p2, mesh, combine_vertices: false);
        }

        public static void AddPointCombined(Point3D point, MeshGeometry3D mesh, Vector3D normal)
        {
            bool found = false;
            int i = 0;
            foreach (Point3D position in mesh.Positions)
            {
                if (position.Equals(point))
                {
                    found = true;
                    mesh.TriangleIndices.Add(i);
                    mesh.Positions.Add(point);
                    mesh.Normals.Add(normal);
                    break;
                }
                i++;
            }
            if (!found)
            {
                mesh.Positions.Add(point);
                mesh.TriangleIndices.Add(mesh.TriangleIndices.Count);
                mesh.Normals.Add(normal);
            }
        }

        public static void AddTriangleToMesh(Point3D p0, Point3D p1, Point3D p2, MeshGeometry3D mesh, bool combine_vertices)
        {
            Vector3D normal = CalculateNormal(p0, p1, p2);
            if (combine_vertices)
            {
                AddPointCombined(p0, mesh, normal);
                AddPointCombined(p1, mesh, normal);
                AddPointCombined(p2, mesh, normal);
                return;
            }
            mesh.Positions.Add(p0);
            mesh.Positions.Add(p1);
            mesh.Positions.Add(p2);
            mesh.TriangleIndices.Add(mesh.TriangleIndices.Count);
            mesh.TriangleIndices.Add(mesh.TriangleIndices.Count);
            mesh.TriangleIndices.Add(mesh.TriangleIndices.Count);
            mesh.Normals.Add(normal);
            mesh.Normals.Add(normal);
            mesh.Normals.Add(normal);
        }

        public GeometryModel3D CreateTriangleModel(Color color)
        {
            return CreateTriangleModel(p1, p2, p3, color);
        }

        public static GeometryModel3D CreateTriangleModel(Point3D P0, Point3D P1, Point3D P2, Color color)
        {
            MeshGeometry3D mesh = new MeshGeometry3D();
            AddTriangleToMesh(P0, P1, P2, mesh);
            Material material = new DiffuseMaterial(new SolidColorBrush(color));
            return new GeometryModel3D(mesh, material);
        }

        public static Vector3D CalculateNormal(Point3D P0, Point3D P1, Point3D P2)
        {
            Vector3D v2 = new Vector3D(P1.X - P0.X, P1.Y - P0.Y, P1.Z - P0.Z);
            Vector3D v = new Vector3D(P2.X - P1.X, P2.Y - P1.Y, P2.Z - P1.Z);
            return Vector3D.CrossProduct(v2, v);
        }
    }

    public class WpfRectangle
    {
        private Point3D p0;

        private Point3D p1;

        private Point3D p2;

        private Point3D p3;

        public WpfRectangle(Point3D P0, Point3D P1, Point3D P2, Point3D P3)
        {
            p0 = P0;
            p1 = P1;
            p2 = P2;
            p3 = P3;
        }

        public WpfRectangle(Point3D P0, double w, double h, double d)
        {
            p0 = P0;
            if (w != 0.0 && h != 0.0)
            {
                p1 = new Point3D(p0.X + w, p0.Y, p0.Z);
                p2 = new Point3D(p0.X + w, p0.Y - h, p0.Z);
                p3 = new Point3D(p0.X, p0.Y - h, p0.Z);
            }
            else if (w != 0.0 && d != 0.0)
            {
                p1 = new Point3D(p0.X, p0.Y, p0.Z + d);
                p2 = new Point3D(p0.X + w, p0.Y, p0.Z + d);
                p3 = new Point3D(p0.X + w, p0.Y, p0.Z);
            }
            else if (h != 0.0 && d != 0.0)
            {
                p1 = new Point3D(p0.X, p0.Y, p0.Z + d);
                p2 = new Point3D(p0.X, p0.Y - h, p0.Z + d);
                p3 = new Point3D(p0.X, p0.Y - h, p0.Z);
            }
        }

        public void AddToMesh(MeshGeometry3D mesh)
        {
            WpfTriangle.AddTriangleToMesh(p0, p1, p2, mesh);
            WpfTriangle.AddTriangleToMesh(p2, p3, p0, mesh);
        }

        public static void AddRectangleToMesh(Point3D p0, Point3D p1, Point3D p2, Point3D p3, MeshGeometry3D mesh)
        {
            WpfTriangle.AddTriangleToMesh(p0, p1, p2, mesh);
            WpfTriangle.AddTriangleToMesh(p2, p3, p0, mesh);
        }

        public static GeometryModel3D CreateRectangleModel(Point3D p0, Point3D p1, Point3D p2, Point3D p3)
        {
            return CreateRectangleModel(p0, p1, p2, p3, texture: false);
        }

        public static GeometryModel3D CreateRectangleModel(Point3D p0, Point3D p1, Point3D p2, Point3D p3, bool texture)
        {
            MeshGeometry3D mesh = new MeshGeometry3D();
            AddRectangleToMesh(p0, p1, p2, p3, mesh);
            Material material = new DiffuseMaterial(new SolidColorBrush(Colors.White));
            return new GeometryModel3D(mesh, material);
        }
    }

    public class WpfCube
    {
        private Point3D origin;

        private double width;

        private double height;

        private double depth;

        public Point3D CenterBottom()
        {
            return new Point3D(origin.X + width / 2.0, origin.Y + height, origin.Z + depth / 2.0);
        }

        public Point3D Center()
        {
            return new Point3D(origin.X + width / 2.0, origin.Y - height / 2.0, origin.Z + depth / 2.0);
        }

        public Point3D CenterTop()
        {
            return new Point3D(origin.X + width / 2.0, origin.Y, origin.Z + depth / 2.0);
        }

        public WpfCube(Point3D P0, double w, double h, double d)
        {
            width = w;
            height = h;
            depth = d;
            origin = P0;
        }

        public WpfCube(WpfCube cube)
        {
            width = cube.width;
            height = cube.height;
            depth = cube.depth;
            origin = new Point3D(cube.origin.X, cube.origin.Y, cube.origin.Z);
        }

        public WpfRectangle Front()
        {
            return new WpfRectangle(origin, width, height, 0.0);
        }

        public WpfRectangle Back()
        {
            return new WpfRectangle(new Point3D(origin.X + width, origin.Y, origin.Z + depth), 0.0 - width, height, 0.0);
        }

        public WpfRectangle Left()
        {
            return new WpfRectangle(new Point3D(origin.X, origin.Y, origin.Z + depth), 0.0, height, 0.0 - depth);
        }

        public WpfRectangle Right()
        {
            return new WpfRectangle(new Point3D(origin.X + width, origin.Y, origin.Z), 0.0, height, depth);
        }

        public WpfRectangle Top()
        {
            return new WpfRectangle(origin, width, 0.0, depth);
        }

        public WpfRectangle Bottom()
        {
            return new WpfRectangle(new Point3D(origin.X + width, origin.Y - height, origin.Z), 0.0 - width, 0.0, depth);
        }

        public static void AddCubeToMesh(Point3D p0, double w, double h, double d, MeshGeometry3D mesh)
        {
            WpfCube cube = new WpfCube(p0, w, h, d);
            WpfRectangle front = cube.Front();
            WpfRectangle back = cube.Back();
            WpfRectangle right = cube.Right();
            WpfRectangle left = cube.Left();
            WpfRectangle top = cube.Top();
            WpfRectangle bottom = cube.Bottom();
            front.AddToMesh(mesh);
            back.AddToMesh(mesh);
            right.AddToMesh(mesh);
            left.AddToMesh(mesh);
            top.AddToMesh(mesh);
            bottom.AddToMesh(mesh);
        }

        public GeometryModel3D CreateModel(Color color)
        {
            return CreateCubeModel(origin, width, height, depth, color);
        }

        public static GeometryModel3D CreateCubeModel(Point3D p0, double w, double h, double d, Color color)
        {
            MeshGeometry3D mesh = new MeshGeometry3D();
            AddCubeToMesh(p0, w, h, d, mesh);
            Material material = new DiffuseMaterial(new SolidColorBrush(color));
            return new GeometryModel3D(mesh, material);
        }
    }

}
