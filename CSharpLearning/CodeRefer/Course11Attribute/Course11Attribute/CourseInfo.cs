using Course11Attribute.CustAttrs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course11Attribute
{
    //应用自定义特性
    [Table("CourseInfos")]
    [Remark("课程信息实体类")]
    public class CourseInfo
    {
        [Remark("课程编号")]
        public int CouseId { get; set; }
        [Remark("课程名称")]
        public string CouseName { get; set; }
        [Remark("学生人数")]
        public int StuCount { get; set; }

        //[Remark("显示课程信息")]
        public void ShowCourse()
        {
            Console.WriteLine($"课程编号：{CouseId}，课程名称：{CouseName}，学生人数：{StuCount}");
        }
    }
}
