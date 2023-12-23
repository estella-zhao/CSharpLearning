using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.数组与异常
{
    public class StuDAL
    {
        public bool UpdateStu(Student stu)
        {
            try
            {
                stu.StuId = 12;
                return true;
            }
            catch (Exception ex)
            {
                //throw;//抛异常  
                throw new Exception("修改的学生信息是空对象", ex);  //推荐的方式
            }
        }
    }
}
