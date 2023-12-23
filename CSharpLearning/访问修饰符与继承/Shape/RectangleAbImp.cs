using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.访问修饰符与继承.Shape
{
    public class RectangleAbImp : AbstractShape
    {
        public RectangleAbImp(int count)
        {
            LineCount = count;
            Lines = new int[count];
        }

        public override void CalTotalLength()
        {
            TotalLength = (Lines[0] + Lines[1]) * 2;
            Console.WriteLine("长方形的周长是：" + TotalLength);
        }

        public override void PaintShape()
        {
            Console.WriteLine($"画长方形，有{LineCount}条边");
        }
    }
}
