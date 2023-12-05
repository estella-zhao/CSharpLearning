using Microsoft.Win32;
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

namespace WpfCourse03
{
    /// <summary>
    /// MediaElementWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MediaElementWindow : Window
    {
        System.Timers.Timer timer = null;
        public MediaElementWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }

        private void me_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PlayerPause();
        }

        /// <summary>
        /// 媒体加载完成时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void me_MediaOpened(object sender, RoutedEventArgs e)
        {
            posSlider.Maximum = me.NaturalDuration.TimeSpan.TotalSeconds;
            lblTime.Content = "0:00:00";
            SetPlayer(true);
        }

        private void me_MediaEnded(object sender, RoutedEventArgs e)
        {
            lblTime.Content = "播放结束！";
            timer.Stop();
        }

        private void posSlider_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            me.Pause();
            timer.Stop();
            int val = (int)posSlider.Value;
            me.Position = new TimeSpan(0, 0, 0, val);
            SetTime();
            me.Play();
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Dispatcher.Invoke(new Action(() =>
            {
                posSlider.Value = me.Position.TotalSeconds;
                SetTime();
            }));
        }

        private void SetTime()
        {
            lblTime.Content = string.Format("{0:00}:{1:00}:{2:00}", me.Position.Hours, me.Position.Minutes, me.Position.Seconds);
        }

        /// <summary>
        /// 打开选择播放文件 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = @"视频文件(*.avi格式)|*.avi|视频文件(*.wav格式)|*.wav|视频文件(*.wmv格式)|*.wmv|视频文件(*.mp4格式)|*.mp4|All Files|*.*";
            if (ofd.ShowDialog() == false)
            {
                return;
            }
            string path = "";
            path = ofd.FileName;
            if (path == "")
                return;
            //设置媒体源
            me.Source = new Uri(path, UriKind.Absolute);
            btnPlay.IsEnabled = true;
            me.Play();
            timer.Start();
            btnPlay.Content = "暂停";
        }

        /// <summary>
        /// 播放或暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            SetPlayer(true);
            PlayerPause();
        }

        private void PlayerPause()
        {
            if (btnPlay.Content.ToString() == "播放")
            {
                me.Play();
                timer.Start();
                btnPlay.Content = "暂停";
                me.ToolTip = "单击暂停";
            }
            else
            {
                me.Pause();
                timer.Stop();
                btnPlay.Content = "播放";
                me.ToolTip = "单击播放";
            }
        }

        private void SetPlayer(bool bl)
        {
            btnStop.IsEnabled = bl;
            btnPlay.IsEnabled = bl;
            btnBack.IsEnabled = bl;
            btnForward.IsEnabled = bl;
        }

        /// <summary>
        /// 停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            me.Stop();
            posSlider.Value = 0;
            lblTime.Content = "0:00:00";
            btnPlay.Content = "播放";
            timer.Stop();
        }

        /// <summary>
        /// 快退  回退10s
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            me.Pause();
            timer.Stop();
            me.Position = me.Position - TimeSpan.FromSeconds(10);
            SetTime();
            me.Play();
            timer.Start();
        }

        /// <summary>
        /// 快进   前进10s
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnForward_Click(object sender, RoutedEventArgs e)
        {
            me.Pause();
            timer.Stop();
            me.Position = me.Position + TimeSpan.FromSeconds(10);
            SetTime();
            me.Play();
            timer.Start();
        }
    }
}
