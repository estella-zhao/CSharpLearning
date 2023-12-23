using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.变量常量
{
    internal class VariableAndConstant
    {
        public void testVariableAndConstant()
        {
            //引用类型、动态类型  

            //值类型  局部变量 参数----栈 
            int a = 123;
            int b = a;//创建一个副本  
            b = 345;
            Console.WriteLine(a);//123
            //创建2个对象   str1    "123"
            string str1 = "123";
            string str = @"233455";
            string constr = @"server=.\sqlexpress;database-.......";
            string str2 = str1;
            string ss = "", ss1 = string.Empty, ss2 = null;
            //他们三者的分别
            //ss="" 或string.empty  会分别空间 长度0   null 不会分配空间
            Console.WriteLine("str2:" + str2);//
            str2 = "345";
            Console.WriteLine("str1:" + str1);

            //装箱：值-》引用 栈-》堆（消耗：内存，cpu资源）
            object o = 12;
            //拆箱：引用-》值 堆-》栈（消耗：内存，cpu资源）
            int temp = (int)o;
            //动态类型 不推荐使用，不安全
            var age = "strreee";
            //动态类型
            dynamic strName = "stringddd";
            int count = (int)strName;//不检查，运行时才检查，类型不安全

            //类型转换
            byte bb = 200;
            int intVal = bb;//小类型转换成大范围类型
            float ff = 23.5f;
            int intMoney = (int)ff;//会丢失
            string ss3 = "234";
            //string->int
            int intSS1 = int.Parse(ss3);
            int intSS2;
            int.TryParse(ss3, out intSS2);
            int intSS3 = Convert.ToInt32(ss3);
            //任何类型都可以
            //Convert.ChangeType(intSS1, typeof(int));
            object stu3 = new Student();
            Student stu4 = stu3 as Student;//as 只能用于引用类型


            //常量
            const int conIntVal = 12;
            //conIntVal = 24;//error 常量值不能改变

        }

        private class Student
        {
            public int Age { get; set; }

        }
    }
}
