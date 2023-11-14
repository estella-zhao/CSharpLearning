using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course09DelegateAndLambda
{
    delegate void ShowMsg();//不带返回  无参
    delegate int Add(int x, int y);
    public class DelegateClass
    {
        public int AddNew(int a, int b)
        {
            int c = a + b;
            return c;
        }

        public void ShowMsg()
        {
            Console.WriteLine("Welcome to ZhaoXi Edu");
        }

        public void ShowInfo()
        {
            Console.WriteLine("Welcome to ZhaoXi Info");
        }

        public void ShowNew()
        {
            Console.WriteLine("Welcome to ZhaoXi New");
        }

        public void Test()
        {
            //ShowMsg show = new ShowMsg(ShowInfo);
            //show += ShowMsg;

            //多播委托  +=  添加方法    -= 移除
            ShowMsg show = ShowInfo;//赋值委托  这里不能+=
            show += ShowMsg;
            show += ShowInfo;
            show += ShowNew;
            show += ShowMsg;
            show -= ShowNew;

            show();
            //匿名方法
            ShowMsg show1 = delegate ()
              {
                  Console.WriteLine("匿名方法");
              };   //这里必写分号

            Add add0 = AddNew;

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
            add1 += (a, b) => a + b;
            add1 += (m, n) => (m + n) + (m - n);


            ShowMsg show2 = () =>  Console.WriteLine("Hello !");
            show2 += () => Console.WriteLine("Welcome");
            show2 += () => Console.WriteLine("Byebye");


            int re=  add1(3, 5);//6   最后一个操作的结果
            show2();

        }
    }
}

