using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPFCourse01
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //2.设置启动页
            //LoginWin loginWin = new LoginWin();
            //loginWin.Show();

            //3.设置启动页  StartupUri 
            // Application.Current.StartupUri = new Uri("LoginWin.xaml", UriKind.Relative);
            //默认：关闭最后一个窗口，才退出应用程序 
            //改成：关闭启动页就退出
            //Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
        }
    }
}
