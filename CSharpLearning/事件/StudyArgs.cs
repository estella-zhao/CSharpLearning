using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.事件
{
    public class StudyArgs
    {
        public string StuName { get; set; }

        public StudyArgs(string name)
        {
            StuName = name;
        }
    }
}
