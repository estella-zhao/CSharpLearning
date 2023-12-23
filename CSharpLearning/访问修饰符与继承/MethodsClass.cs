using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.访问修饰符与继承
{
    public class MethodsClass
    {
        //方法重载
        public float Add(float x, float y)
        {
            return x + y;
        }

        public float Add(float x, float y, float z)
        {
            return x + y + z;
        }
    }
}
