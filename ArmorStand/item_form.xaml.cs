using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace ArmorStand
{
    /// <summary>
    /// item_form.xaml 的交互逻辑
    /// </summary>
    public partial class Item_form : Window
    {
        Control this_obj;
        public Item_form(string text, Control main_obj)
        {
            InitializeComponent();
            Icon = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + "\\ResourceImages\\CB图标.ico"));
            Title = text;
            this_obj = main_obj;
            if (main_obj.Tag != null && main_obj.Tag.ToString().Trim() != "")
                ItemInfoBox.Text = main_obj.Tag.ToString();
            //区分开物品信息和生成信息
            ItemInfoBox.IsReadOnly = main_obj.Uid != "modify";
            if (ItemInfoBox.IsReadOnly)
            {
                ItemInfoBox.Text = text;
                Title = "盔甲架命令";
            }
        }

        private void ItemForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(!ItemInfoBox.IsReadOnly)
            {
                this_obj.Tag = ItemInfoBox.Text;
            }
        }
    }
}
