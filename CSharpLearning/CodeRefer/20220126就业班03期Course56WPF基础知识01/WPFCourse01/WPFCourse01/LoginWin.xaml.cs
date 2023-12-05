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

namespace WPFCourse01
{
    /// <summary>
    /// LoginWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWin : Window
    {
        public LoginWin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWin = new MainWindow();
            mainWin.ShowDialog();
           
        }

        private void Window_SourceInitialized(object sender, EventArgs e)
        {
            Console.WriteLine("Window_SourceInitialized");
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            Console.WriteLine("Window_Activated");
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            Console.WriteLine("Window_Deactivated");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Window_Loaded");
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            Console.WriteLine("Window_ContentRendered");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Console.WriteLine("Window_Closing");
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Console.WriteLine("Window_Closed");
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btnMax_Click(object sender, RoutedEventArgs e)
        {
            if(btnMax.Content.ToString()=="2")
            {
                this.WindowState = WindowState.Maximized;
                btnMax.Content = "1";
            }
            else
            {
                this.WindowState = WindowState.Normal;
                btnMax.Content = "2";
            }
        }
    }
}
