using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpLearning.选择循环;

namespace CSharpLearning//命名空间，默认与项目名称一样
{
    /// <summary>
    /// 入口类 3、文档注释
    /// 命名规则：类 属性 方法 结构体 pascal 首字母大写
    /// </summary>
    internal class Program//类名
    {
        //入口
        static void Main(string[] args)
        {
            #region 注释声明赋值枚举
            {
                
                ////1、单行注释
                ////Console.Clear();

                ///*
                // * 2、块注释
                // * Console.WriteLine("Hello, CSharp!");
                // * string ss = Console.ReadLine();//接受输入信息
                // * Console.WriteLine(ss);
                // * 
                // */

                ////关键词：
                //int rowId = 123;
                //int a;//声明变量
                //      // = 赋值运算符
                //a = 12;//初始化
                //a = rowId + 2;
                ////  byte b1 = 256;//超范围
                //a = 23;
                ////  a = 2147483648;
                //long longNum = 34567;
                //var money = 2.3;//double
                //float f1 = 3.45f;//float 
                //double d2 = 23.56D;//double 不带后缀也可带：D或d
                //decimal de1 = 2.3m;//decimal 带后缀 M   m
                //                   //sizeof(Type) 分配空间大小
                //                   //Console.WriteLine(sizeof(decimal));

                ////可空类型
                ////Nullable<T> int? float? double? Nullable<int>
                ////int c = null;//error null是引用类型，c是值类型
                //int? c = null;//right

                ////bool  true  false  默认值 false  有  无   成功  失败
                //bool bl = false;
                //bl = c > 0 ? true : false;//三目运算符
                //                          //if(!bl)//bl=false
                //                          //if(bl==false)
                //                          //{

                ////}

                ////枚举类型enum
                //Sex sex = Sex.Female;
                //Console.WriteLine(sex);//Female
                //int intFemale = (int)sex;//枚举转换成整型
                //Sex sex2 = (Sex)intFemale;//整型转换成枚举
                //string strSex = sex.ToString();//枚举转换成string
                //string[] sexNameArray = Enum.GetNames(typeof(Sex));//获取枚举中的常量名称数组
                //Array sexValArray = Enum.GetValues(typeof(Sex));//获取枚举中的常量值数组
            
            }

            #endregion


            
            Console.ReadKey();
        }

        /// <summary>
        /// 枚举类型
        /// </summary>
        enum Sex
        {
            Male = 0,
            Female = 1
        }

        struct StudentInfo : IPeople
        {
            //不能显式定义无参构造函数
            //public StudentInfo()
            //{

            //}

            /// <summary>
            /// 可以有带参的构造函数
            /// </summary>
            /// <param name="_age"></param>
            /// <param name="stuName"></param>
            public StudentInfo(int _age, string stuName)
            {
                age = _age;
                StuName = stuName;
            }

            public int age;//不能赋初值 字段或变量
            public string StuName { get; set; }//属性

            //方法 void 无返回值
            public void ShowInfo()
            {
                Console.WriteLine($"年龄:{age}, 姓名：{StuName}");
            }

            //struct不能有析构函数
            //~StudentInfo()
            //{

            //}
        }

        struct People
        {

        }

        //Class
        class PeopleBase 
        {
        
        }

        //接口
        interface IPeople
        {
            void ShowInfo();
        }
        
    }
}
