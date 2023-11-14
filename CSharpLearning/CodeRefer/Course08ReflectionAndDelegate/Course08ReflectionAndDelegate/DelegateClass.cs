using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course08ReflectionAndDelegate
{

    public class DelegateClass
    {
        public void ShowMsg()
        {
            Console.WriteLine("ShowMsg");
        }

        public void ConsoleLine()
        {
            Console.WriteLine("ConsoleLine");
        }

        public int Substract(int x,int y)
        {
            return x - y;
        }

        public int Add(int x,int y)
        {
            return x + y;
        }

        public void Test()
        {
            ShowMsg();
            int re = Substract(5, 2);

            
        }


    }
}
