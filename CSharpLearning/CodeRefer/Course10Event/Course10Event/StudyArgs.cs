using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course10Event
{
    /// <summary>
    /// 自定义事件参数
    /// </summary>
    public class StudyArgs:EventArgs
    {
        public string StuName { get; set; }
        public StudyArgs(string name)
        {
            StuName = name;
        }
    }
}
