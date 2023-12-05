using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPFCourseDependencyPropertyAndDataBinding
{
    public class PasswordBoxHelper:DependencyObject
    {
        //声明+注册
        public static readonly DependencyProperty PasswordProperty = DependencyProperty.RegisterAttached("Password", typeof(string), typeof(PasswordBoxHelper), new PropertyMetadata(string.Empty, OnPasswrodChanged));
        private static readonly DependencyProperty IsUpdatingProperty =
          DependencyProperty.RegisterAttached("IsUpdating", typeof(bool),
          typeof(PasswordBoxHelper));

        //属性包装
        //读取值
        public static string GetPassword(DependencyObject dpa)
        {
            return (string)dpa.GetValue(PasswordProperty);
        }
        //设置值
        public static void SetPassword(DependencyObject dpa,string value)
        {
            dpa.SetValue(PasswordProperty, value);
        }

        private static bool GetIsUpdating(DependencyObject dp)
        {
            return (bool)dp.GetValue(IsUpdatingProperty);
        }
        private static void SetIsUpdating(DependencyObject dp, bool value)
        {
            dp.SetValue(IsUpdatingProperty, value);
        }

        private static void OnPasswrodChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //附加属性中的值，赋值到PasswordBox的Passwrod属性中
            PasswordBox pb = d as PasswordBox;
            pb.PasswordChanged -= PasswordChanged;
            if(!GetIsUpdating(pb))
               pb.Password = e.NewValue == null ? "" : e.NewValue.ToString();
            pb.PasswordChanged += PasswordChanged;
        }
        //密码值改变时
        private static void PasswordChanged(object sender, RoutedEventArgs e)
       {
            PasswordBox pb = sender as PasswordBox;
            SetIsUpdating(pb, true);
            SetPassword(pb, pb.Password);
            SetIsUpdating(pb, false);
        }
    }
}
