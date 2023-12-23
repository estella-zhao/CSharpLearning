using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.访问修饰符与继承
{
    /// <summary>
    /// 抽象类   ：一系列看上去不同，本质、共同点是相同的具体概念的抽象。
    /// 不能直接实例化 ，可以通过实现类来实例化
    /// sealed static 不能与abstract 一起用
    /// </summary>
    public abstract class AbstractClass
    {
        public int Id { get; set; }

        //抽象方法 不能有实现，必须通过派生类实现
        public abstract void Show();
        //虚方法
        public virtual void Study()
        {
            Console.WriteLine("Studying");
        }
        //普通方法
        public void Work()
        {
            Console.WriteLine("Working");
        }
    }
}
