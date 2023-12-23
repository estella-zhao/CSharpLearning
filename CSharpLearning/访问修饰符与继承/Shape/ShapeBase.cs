using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.访问修饰符与继承.Shape
{
    public class ShapeBase
    {
        //边数
        public int LineCount { get; set; }
        //各边的长
        public int[] Lines { get; set; }
        //周长
        public int TotalLength { get; set; }
        public ShapeBase()
        {
            LineCount = 2;
            Lines = new int[LineCount];
        }
        //画形状
        public void PaintShape()
        {
            Console.WriteLine($"画角，有{LineCount}条边");
        }

        public virtual void CalTotalLength()
        {
            TotalLength = 0;
            foreach (int l in Lines)
            {
                TotalLength += l;
            }
            Console.WriteLine("角的周长是：" + TotalLength);
        }
    }
}
