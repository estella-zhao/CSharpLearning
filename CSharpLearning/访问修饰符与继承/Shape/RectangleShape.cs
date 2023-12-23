using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.访问修饰符与继承.Shape
{
    public class RectangleShape:ShapeBase
    {
        public RectangleShape(int count)
        {
            LineCount = count;
            Lines = new int[count];
        }

        public int Width { get; set; }
        public int Height { get; set; }

        public void InitLines()
        {
            Lines[0] = Width;
            Lines[2] = Width;
            Lines[1] = Height;
            Lines[3] = Height;
        }

        public override void CalTotalLength()
        {
            TotalLength = 0;
            TotalLength = (Width + Height) * 2;  //周长计算
            Console.WriteLine("长方形的周长是：" + TotalLength);
        }
    }
}
