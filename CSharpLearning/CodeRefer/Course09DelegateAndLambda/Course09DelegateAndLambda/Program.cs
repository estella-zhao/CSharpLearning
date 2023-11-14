using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course09DelegateAndLambda
{
    class Program
    {
       
        static void Main(string[] args)
        {
            DelegateClass del = new DelegateClass();
            #region 委托
            {
                //回顾委托定义与实例化
              
                del.Test();


                //多播委托
            }
            #endregion

            #region Lambda表达式
            {
                //匿名方法
                ShowMsg show1 = delegate ()
                {
                    Console.WriteLine("匿名方法");
                };   //这里必写分号

                Add add0 = del.AddNew;

                //匿名方法演化为Lambda表达式过程
                //1.
                //Add add1 = delegate (int x, int y)
                //  {
                //      int c = x + y;
                //      return c;
                //  };
                //2.去掉delegate,参数列表与主体之间，“=>”  ----goes to 
                //Add add1 = (int x, int y) =>
                //      {
                //          int c = x + y;
                //          return c;
                //      };
                //3.去掉参数类型，如果主体中只有一句话，{}都可以不写
                //Add add1 = (x, y) =>
                //{
                //    int c = x + y;
                //    return c;
                //};
                //4.{} 去掉
                Add add1 = (x, y) => x + y;  //Lambda表达式
            }
            #endregion

            #region Action  Func
            {
                //Action  不返回值 委托   可以不带参数，也可以带参数，最多可以带16个参数    Action<object,EventArgs>
                Action act1 = () => {  };//最简单的委托
                Action act2 = () => Console.WriteLine("Hello,World!");
                Action act3 = () =>
                {
                    string ss = "aaa";
                    //return ss;  带返回值就错了
                };
                Action<int> act4 = a => { int b = a + 3; };//这里不能省略{}
                //带两个参数
                Action<int, string> act5 = (m, s) =>
                 {
                     Console.WriteLine("m=" + m + "; s=" + s);
                 };
                //带三个参数
                Action<int, string,double> act6 = (m, s,d) =>
                {
                    Console.WriteLine("m=" + m + "; s=" + s+"; d="+d);
                };
                //最多可以带16个
                //  Action<int, string, double, int, string, double, int, string, double, int, string, double, int, string, double, int> act7 = ()=>{ };

                //Func  可以不带参数，可以带参数，最多16个参数，会返回一个值
                Func<string> func1 = () => "sss";//不带参数，返回一个string类型的值
                //带一个参数，返回int类型
                Func<int, int> func2 = a =>
                 {
                     int b = a + 5;
                     int c = a + b;
                     return c;
                 };
                //带两参数  string int   返回值类型 string
                Func<string, int, string> func3 = (s, n) =>
                  {
                      string ss = s + n;
                      return ss;
                  };
                //最多参数可以16个
                //Func 条件  Func<T,bool> func=  t=>t.Id>12
                List<int> list = new List<int> { 12, 3, 10, 45, 24, 78, 53, 99 };
                List<int> listNew = new List<int>();
                //老办法筛选方式
                foreach (int num in list)
                {
                    if (num > 15)
                        listNew.Add(num);
                }
                //Func应用
                List<int> listNew2 = list.Where(n => n > 15).ToList();
                list.Sort();

                List<UserInfo> users = new List<UserInfo>()
                {
                    new UserInfo(){Id =1,Name="sss",Age=23},
                    new UserInfo(){Id =12,Name="Fresh",Age=32},
                    new UserInfo(){Id =6,Name="White",Age=27},
                    new UserInfo(){Id =3,Name="Mr.Sun",Age=18},
                    new UserInfo(){Id =9,Name="Jessy",Age=26},
                    new UserInfo(){Id =7,Name="Numerr",Age=21}
                };
                var userList= users.OrderBy(u => u.Name).ToList();
                double avg=   users.Average(u => u.Age);
                //事件：委托类型   自定义委托类型-----正常
                               //完全可以用Action去代替
                //开发过程，如果要用委托，可以用Action或Func去代替，建议不要自定义，直接使用Action或Func。
            }
            #endregion

            Console.ReadKey();
        }
    }
}
