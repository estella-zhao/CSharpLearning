using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.访问修饰符与继承
{
    //实现类必须实现抽象类中的方法
    public class AbstractImp : AbstractClass
    {
        //override实现抽象方法 (抽象方法也叫隐式的虚方法)
        public override void Show()
        {
            Console.WriteLine($"编号： {Id}, Welcome!");
        }
        //虚方法的实现
        public override void Study()
        {
            Console.WriteLine("Studying New");
        }
    }

    public class AbstractImp2 : AbstractClass
    {
        //override  实现抽象方法 (抽象方法也叫隐式的虚方法)
        public override void Show()
        {
            Console.WriteLine($"编号：{Id}，Welcome Teacher!");
        }
        //虚方法的实现
        public override void Study()
        {
            Console.WriteLine("Teacher Studying ");
        }
    }
}
