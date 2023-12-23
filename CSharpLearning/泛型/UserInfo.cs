using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.泛型
{
    public class UserInfo : ModelBase, IBase
    {
        public void Show()
        {
            Console.WriteLine("Show Info");
        }
    }
}
