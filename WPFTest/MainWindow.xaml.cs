using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.DataContext = new LoginVM();
        }

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    if (vm.UserName == "admin" && vm.Password == "123")
        //    {
        //        MessageBox.Show("登录成功");
        //    }
        //    else
        //    {
        //        MessageBox.Show("账号密码错误，请重试！");
        //        vm.UserName = "";
        //        vm.Password = "";

        //    }
        //}
    }
}
