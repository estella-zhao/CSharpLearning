using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.访问修饰符与继承
{
    /// <summary>
    /// 不写访问修饰符，默认为internal
    /// Class1:Class2------Class1继承于Class2
    /// People--父类或基类   Student----派生类或子类
    /// Class只能继承一个基类（不能同时继承于多个类），但可以实现多个接口
    /// </summary>
    class Student:People, IStudent, IPeople
    {
        public int Age {  get; set; }

        public bool Add(People people) {
            return true;
        }

        public Student GetStudent(int id) {
            if (id > 0)
            {
                return new Student() { Id = id };
            }
            return null;
        }

        public void Show()
        {
            Console.WriteLine("Student");
        }

        public string Phone { get; set; }
        //对父类的虚方法重写  override
        public override void ShowInfo()
        {
            Console.WriteLine($"学生：编号：{Id},姓名：{Name},电话:{Phone}");
        }

        public new void Work()
        {
            Console.WriteLine($"学生：{Name} 在学习！");
        }
    }

    public class StudentNew2 : PeopleBase1
    {
        public void Show()
        {
            address = "北京";
        }
    }


}
