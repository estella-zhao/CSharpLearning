using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.访问修饰符与继承
{
    public class StudentImp : IPeople
    {
        public bool Add(People p)
        {
            if (p.Id > 0 && !string.IsNullOrEmpty(p.Name))
            {
                return true;
            }
            return false;
        }

        public int GetId()
        {
            int id = 10;
            return id; ;
        }

        public People GetInfo()
        {
            return new Student() { Id = 12, Name = "点点" };
        }

        public void Show()
        {
            Console.WriteLine("");

        }

        public void ShowInfo(People p)
        {
            Console.WriteLine($"学生：编号：{p.Id},姓名：{p.Name}");
        }


    }
}
