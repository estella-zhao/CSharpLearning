using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.特性
{
    [Table("CourseInfos")]
    [Remark("课程信息实体类")]
    public class CourseInfo
    {
        [Remark("课程编号")]
        public int CourseId { get; set; }
        [Remark("课程名称")]
        public string CourseName { get; set; }

        [Remark("学生人数")]
        public int stuCount { get; set; }

        [Remark("显示课程信息")]
        public void ShowCourse()
        {
            Console.WriteLine($"课程编号： {CourseId}, " +
                $"课程名称：{CourseName}, 学生人数： {stuCount}");
        }
    }
}
