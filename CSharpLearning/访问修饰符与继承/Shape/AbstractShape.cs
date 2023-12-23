using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.访问修饰符与继承.Shape
{
    public abstract class AbstractShape
    {
        //边数
        public int LineCount { get; set; }
        //各边的长
        public int[] Lines { get; set; }
        //周长
        public int TotalLength { get; set; }
        //画图
        public abstract void PaintShape();
        //计算周长
        public abstract void CalTotalLength();
    }
}
