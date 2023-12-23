using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.访问修饰符与继承
{
    //密封类 禁止派生
    public sealed class SealedClass
    {
        //密封类中不能有虚拟成员
        //public virtual void ShowInfo()
        //{
        //    Console.WriteLine("Hello");
        //}
        public void Show()
        {
            Console.WriteLine("Hello");
        }
    }

    public class Teacher
    {
        //sealed 不能与virtual 一起用   sealed不修饰普通方法
        public virtual void Show()
        {

        }
    }

    //子类可以密封，一旦密封则不能派生
    public class TeacherChild : Teacher
    {
        //密封某个成员，在派生类中, 这个成员就不能被重写   -----防止成员被自定义  
        public sealed override void Show()
        {
            base.Show();
        }
    }

    public class TeacherChild2 : TeacherChild
    {
        //密封成员不能被重写
        //public override void Show()
        //{
        //    base.Show();
        //}
    }
}
