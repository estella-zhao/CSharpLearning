using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.反射
{
    public class UserInfo
    {
        public UserInfo()
        {
            Console.WriteLine("UserInfo对象被创建");
        }

        public UserInfo(int id, string name)
        {
            UserId = id;
            UserName = name;
        }
        private int id;
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }

        public void Show()
        {
            Console.WriteLine("Show UserInfo");
        }

        public void Show(string name)
        {
            Console.WriteLine("Show " + name);
        }

        public static void ShowInfo()
        {
            Console.WriteLine("ShowInfo  UserInfo");
        }


        public int GetAge()
        {
            return Age;
        }
    }
}
