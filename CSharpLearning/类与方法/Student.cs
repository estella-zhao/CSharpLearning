using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.类与方法
{
    /// <summary>
    /// 不会用private ,protected  受保护的   派生类中访问，外部也不能访问
    /// </summary>
    public class Student
    {
        //如果定义了带参数的构造函数，也需要用无参构造函数，就需要显式的定义无参构造函数
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Student()
        {

        }
        /// <summary>
        /// 带参数的构造函数
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
        private int id;
        public int age;
        //属性
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value > 0)
                    id = value;
            }
        }
        /// <summary>
        /// 属性封装完整写法
        /// </summary>
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //自动属性封装
        public string Phone { get; set; }
        static int count = 2;
        public int Age
        {
            get { return age; }
        }

        //public int Count
        //{
        //    // set; //不能只有set
        //    private get;set;  //外部只能写
        //}

        /// <summary>
        /// 方法（实例方法）
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine($"编号：{Id},姓名：{Name},年龄：{Age}");
        }

        public void ShowInfo(string s)
        {
            Name = s;
            Console.WriteLine($"编号：{Id},姓名：{Name},年龄：{Age}");
        }

        public static int GetCount()
        {
            return count;
        }
        /// <summary>
        /// 特殊的成员函数     被自动调用的   无访问修饰符，无参数
        /// </summary>
        ~Student()
        {
            Console.WriteLine("对象已删除");
        }
    }
}
