using Helper;
using SM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.DAL
{
    public   class GradeDAL:BaseDAL<GradeInfo>
    {
        /// <summary>
        /// 获取所有的年级列表 
        /// </summary>
        /// <returns></returns>
        public List<GradeInfo> GetGradeList()
        {
            return GetModelList("GradeId,GradeName", 0);
        }
        /// <summary>
        /// 判断年级名称是否已存在
        /// </summary>
        /// <param name="gradeName"></param>
        /// <returns></returns>
        public bool ExistsGrade(string gradeName)
        {
            return ExistsByName("GradeName", gradeName);
        }

        /// <summary>
        /// 年级信息新增
        /// </summary>
        /// <param name="gradeName"></param>
        /// <returns></returns>
        public int AddGrade(string gradeName)
        {
            GradeInfo grade = new GradeInfo() { GradeName = gradeName };
            return Add(grade, "GradeName", 1);
        }
        /// <summary>
        /// 修改年级信息
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public bool UpdateGrade(GradeInfo grade)
        {
            return Update(grade, "GradeId,GradeName");
        }

        /// <summary>
        /// 删除年级
        /// </summary>
        /// <param name="gradeId"></param>
        /// <returns></returns>
        public bool DeleteGrade(int gradeId)
        {
            //学生
            string delStudent = $"delete from StudentInfos where ClassId in (select  ClassId from ClassInfos where GradeId={gradeId})";
            //班级
            string delClass = $"delete from ClassInfos where GradeId={gradeId}";
            //年级
            string delGrade = $"delete from GradeInfos where GradeId={gradeId}";
            List<string> sqlList = new List<string> { delStudent, delClass, delGrade };
            return SqlHelper.ExecuteTrans(sqlList);
        }
    }
}
