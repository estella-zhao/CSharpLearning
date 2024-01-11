using CSharpLearning.委托与Lambda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.委托
{
    public class testDelegateClass
    {
        delegate void ShowMsg();//无参 不带返回值
        delegate int Substrate(int a, int b);//带参数 带返回值

        public void testDelegate()
        {
            //委托实例化
            //Action<object, EventArgs>

            //委托可指向与他具有相同名称的方法
            DelegateClass del = new DelegateClass();
            del.ShowMsg();
            del.Test();

            //委托实例化
            //参数是方法的签名（名称），不要加（）
            ShowMsg show1 = new ShowMsg(del.ShowMsg);
            Substrate sub1 = new Substrate(del.Substract);
            Substrate sub2 = new Substrate(del.Add);
            sub1 += del.Add;
            //2种方式都可以执行委托方法
            show1();
            show1.Invoke();

            int ret = sub1(12, 10);

            Substrate sub3 = del.Add;//赋值委托
            sub3 += del.Substract;

            //多播委托 +=添加方法 -=移除方法
            ShowMsg show2 = del.ShowMsg;
            show2 += del.ShowMsg;
            show2 += del.ConsoleLine;
            show2 -= del.ShowMsg;

            show2();

            //匿名方法
            ShowMsg show3 = delegate ()
            {
                Console.WriteLine("匿名方法");
            };//别忘了写分号

            //赋值
            Substrate add0 = del.Add;

            ShowMsg show4 = () => Console.WriteLine("Hello jisan");
            show4 += () => Console.WriteLine("Welcome jisan");
            show4 += () => Console.WriteLine("ByeBye jisan");
            show4();




        }

        public void testLambda()
        {
            //1、delegate (T x, T y) {函数主体};
            Substrate add1 = delegate (int x, int y)
            {
                int z = x + y;
                return z;
            };
            //2、(T x, T y) => {函数主体} ;
            Substrate add2 = (int x, int y) =>
            {
                int z = x + y;
                return z;
            };
            //3、(x, y) => {函数主体};
            Substrate add3 = (x, y) =>
            {
                int z = x + y;
                return z;
            };
            //4、(x, y) => 函数主体;
            Substrate add4 = (x, y) => x + y;
            add4 += (x, y) => x + y;
            add4 += (m, n) => (m + n) + (m - n);

            int ret = add4(1, 20);// 返回最后一个操作的结果
        }
        /// <summary>
        /// Action 不带返回值的委托 可以不带参数，也可以带参数（最多带16个参数）
        /// </summary>
        public void testAction()
        {
            Action act1 = () => { };//最简单的委托
            Action act2 = () => Console.WriteLine("Hello, Wrold!");
            Action act3 = () => 
            {
                string str = "xlw";
                //return str;//不能带返回值
            };
            //带一个int参数
            Action<int> act4 = a => { int b = a + 3; };//不能省略{}；
            //带两个参数
            Action<int, string> act5 = (m, s) =>
            {
                Console.WriteLine("m: " + m + "s: " + s);
            };
            //带三个参数
            Action<int, string, double> act6 = (m, s, d) =>
            {
                Console.WriteLine("m: " + m + "s: " + s + "d: " + d);
            };

        }

        /// <summary>
        /// Func 带一个返回值的委托，可以不带参数，也可以带参数（最多带16个参数）
        /// </summary>
        public void testFunc()
        {
            //不带参数，返回一个string值
            Func<string> func1 = () => "estella";
            //带一个参数，返回一个int值
            Func<int, int> func2 = a =>
            {
                int b = a + 3;
                int c = a + b;
                return c;
            };
            //带两个参数string,int,返回一个string值
            Func<string, int, string> func3 = (s, y) =>
            {
                string name = s + y;
                return name;
            };
            //Func 条件应用
            List<int> list = new List<int> { 20, 21, 1, 22, 7, 6, 3};
            List<int> listNew = new List<int>();
            //以前筛选
            foreach (int i in list)
            {
                if (i >= 20)
                {
                    listNew.Add(i);
                }
            }
            //Func应用
            List<int> listNew2 = list.Where(n => n >= 20).ToList();
            listNew2.Sort();

            List<UserInfo> users = new List<UserInfo>()
            {
                new UserInfo(){Id =1,Name="sss",Age=23},
                new UserInfo(){Id =12,Name="Fresh",Age=32},
                new UserInfo(){Id =6,Name="White",Age=27},
                new UserInfo(){Id =3,Name="Mr.Sun",Age=18},
                new UserInfo(){Id =9,Name="Jessy",Age=26},
                new UserInfo(){Id =7,Name="Numerr",Age=21}
            };

            var userList = users.OrderBy(u => u.Age).ToList();
            double avgAge = users.Average(u => u.Age);

            //事件：自定义的委托类型
            //若要用到委托，尽量使用Action或Func，尽量不要自定义




        }
    }
}
