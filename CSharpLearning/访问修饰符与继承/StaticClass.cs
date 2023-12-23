using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.访问修饰符与继承
{
    /// <summary>
    /// 静态类 内存中之创建一个 不能实例化 不用new 不能扩展
    /// 静态类中成员，也必须是静态，不能声明实例成员，也不能包含实例化构造函数，可以有静态构造函数
    /// SqlHelper 静态类 扩展方法必须在静态类中  通用性，不与具体对象关联
    /// </summary>
    public static class StaticClass
    {
        static int count = 0;
        public const int val = 20;//可以有常量，本质就是静态的

        public static void Add()
        {
            //static int id = 12;//error 不能再静态方法内部声明静态变量
        }

        //静态构造函数，不可以被直接调用，自动执行，只执行一次
        static StaticClass()
        {

        }
    }
}
