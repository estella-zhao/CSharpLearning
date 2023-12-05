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

namespace WPFCourseDependencyPropertyAndDataBinding
{
    /// <summary>
    /// DataBindingWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class DataBindingWindow1 : Window
    {
        public DataBindingWindow1()
        {
            InitializeComponent();
        }
        UserInfo userInfo = new UserInfo()
        {
            UserId = 1,
            UserName = "蝌蚪"
        };
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //C#建立绑定
          
            Binding bind1 = new Binding("UserName");//源属性名
            bind1.Source = userInfo;//源对象
            bind1.Mode = BindingMode.OneWay;//源流向目标
           // txtName5.SetBinding(TextBox.TextProperty, bind1);//建立绑定
            BindingOperations.SetBinding(txtName5, TextBox.TextProperty, bind1);
            //以上两种方式都可以
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            userInfo.UserName = "俊杰";
        }
    }
}
