using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFCourseDependencyPropertyAndDataBinding
{
    public  class UserInfo 
    {
        //普通属性
        public int UserId { get; set; }
        //更改发出通知  INotifyPropertyChanged接口
        public string UserName { get; set; }
    }
}
