using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.类与方法
{
    internal class ClassAndMethod
    {
        public void testClass()
        {
            //new一个实例，调用它的构造函数（无参构造）
            Student stu1 = new Student();
            stu1.age = 12;
            //对属性赋值，其实对私有变量赋值
            //为什么不直接公开 就好了？？？ 公开了，不够安全
            stu1.Id = -1;
            stu1.Name = "小星星";
            stu1.ShowInfo();
            stu1.ShowInfo("Leah");

            int count = Student.GetCount();

            Student stu2 = new Student(11, "青青");
            stu2.ShowInfo();
        }

        public void testMethod()
        {
            Show();//方法调用 
            int a = 3, b = 5;
            int result = Add(a, b);//方法调用 
            Console.WriteLine($"a:{a},b:{b},result:{result}");
            //引用参数  
            int result2 = Substract(ref a, ref b);
            Console.WriteLine($"a:{a},b:{b},result2:{result2}");
            /**
             * 引用参数在方法中使用时必须为其赋值，并且必须是由变量赋予的值，不能是常量或表达式
             * 输出参数在方法中使用时可以不用提前赋值，但在函数中必须给他赋值
             * 值类型：直接存储数据的值
             * 引用类型：存储对值的引用，即存储值的内存地址；
             */

            //输出参数
            int c = 10;
            int d = 2;
            int e = 12;
            int result3 = AddNew(c, out d, out e);

            //https://www.cnblogs.com/ck235/p/4726009.html
        }

        /// <summary>
        /// 不带返回值的方法
        /// 访问修饰符   （方法修饰符） 返回值类型（void）方法名（参数列表（可以有一个或多个或没有））
        /// {   }
        /// </summary>
        private static void Show()
        {
            Console.WriteLine(" Hello,Welcome!");
        }
        /// <summary>
        /// 带返回值
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private static int Add(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// 引用参数 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private static int Substract(ref int x, ref int y)
        {
            x += 2;
            y -= 3;
            return x - y;
        }
        /// <summary>
        /// 输出参数
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private static int AddNew(int x, out int y, out int z)
        {
            y = x + 5;
            z = y + 5;
            return x + y;
        }

    }
}
