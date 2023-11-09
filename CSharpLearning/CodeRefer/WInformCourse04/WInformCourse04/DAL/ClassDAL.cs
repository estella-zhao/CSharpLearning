using DAL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformCourse04;

namespace WinformCourse03.DAL
{
     public  class ClassDAL:BaseDAL<ClassInfo>
    {
        /// <summary>
        /// 获取指定年级的班级列表
        /// </summary>
        /// <param name="gradeId"></param>
        /// <returns></returns>
        public List<ClassInfo> GetClassList(int gradeId)
        {
            return GetModelList("GradeId="+gradeId+" and IsDeleted=0", "ClassId,GradeId,ClassName", "");
        }
    }
}
