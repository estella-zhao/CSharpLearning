using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFCourseDependencyPropertyAndDataBinding
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
          
        }
        //1.所在类型继承自DependencyObject  Window已有
        //2.声明依赖属性
        // public static readonly DependencyProperty NewTitleProperty;
        //3.注册元数据
        //static MainWindow()
        //{
        //    NewTitleProperty = DependencyProperty.Register("NewTitle", typeof(string), typeof(MainWindow), new PropertyMetadata(string.Empty));
        //}
        //2.3步综合成一步  声明+注册
        public static readonly DependencyProperty NewTitleProperty = DependencyProperty.Register("NewTitle", typeof(string), typeof(MainWindow), new PropertyMetadata(string.Empty));
        //4.属性包装  提供读写操作
        public string NewTitle
        {
            get { return (string)GetValue(NewTitleProperty); }
            set { SetValue(NewTitleProperty, value); }
        }

        private string userPwd;
        public string UserPwd
        {
            get { return userPwd; }
            set { userPwd = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string proName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(proName));
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            NewTitle = "12345";
            UserPwd = "123456";
            this.DataContext = this;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
