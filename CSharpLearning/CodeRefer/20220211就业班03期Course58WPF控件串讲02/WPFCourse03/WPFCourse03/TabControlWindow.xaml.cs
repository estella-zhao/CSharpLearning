using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFCourse03
{
    /// <summary>
    /// TabControlWindow.xaml 的交互逻辑
    /// </summary>
    public partial class TabControlWindow : Window
    {
        public TabControlWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //2.
            // frmePage.Navigate(new Uri("UserInfoPage.xaml", UriKind.Relative));
            //3.
            UserInfoPage userPage = new UserInfoPage();
            //frmePage.Navigate(userPage);
            //4.
            frmePage.Content = userPage;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //选择页
            //  tabPages.SelectedIndex = 1;
            //tabPages.SelectedItem = tab3;

            TabItem tab4 = new TabItem();
            tab4.Header = "菜单管理";
            tabPages.Items.Add(tab4);
            tabPages.SelectedItem = tab4;

        }
    }
}
