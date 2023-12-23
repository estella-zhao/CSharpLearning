using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.访问修饰符与继承
{
    public class People
    {
        private int id;//默认private
        public int Id { get; set; }
        public string Name { get; set; }
        //外部不能调用
        private void Show()
        {

        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"编号：{Id},姓名：{Name}");
        }

        public void Work()
        {
            Console.WriteLine($"{Name} 在工作！");
        }



    }
    //不显式声明为private  protected
    public class PeopleBase1
    {
        protected string address = "四川绵阳";
    }
}
