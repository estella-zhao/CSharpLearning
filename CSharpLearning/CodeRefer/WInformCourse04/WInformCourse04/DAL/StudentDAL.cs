using DAL.Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WInformCourse04.Models;

namespace WInformCourse04.DAL
{
    public class StudentDAL : BaseDAL<StudentInfo>
    {
        /// <summary>
        /// 条件查询获取学生列表
        /// </summary>
        /// <param name="classId"></param>
        /// <param name="stuName"></param>
        /// <param name="phone"></param>
        /// <param name="sex"></param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        public List<StudentInfo> GetStudentList(int classId,string stuName,string phone,string sex,int isDeleted)
        {
            string strWhere = $"IsDeleted={isDeleted}";
            if(classId>0)
            {
                //or ClassId in (select ClassId from ClassInfos where GradeId=" + classId + ")
                strWhere += " and (ClassId =" + classId + " )";
            }
            if(!string.IsNullOrEmpty(stuName))
            {
                strWhere += " and StuName like @stuName";
            }
            if(!string.IsNullOrEmpty(phone))
            {
                strWhere += " and Phone like @phone";
            }
            if(!string.IsNullOrEmpty(sex))
            {
                strWhere += " and Sex =@sex";
            }
            SqlParameter[] paras =
            {
                new SqlParameter("@stuName",$"%{stuName}%"),
                new SqlParameter("@phone",$"%{phone}%"),
                new SqlParameter("@sex",sex),
            };
            return GetModelList(strWhere, "", "", paras);
        }

        public bool ExistStudent(string name,string phone)
        {
            string strWhere = $"StuName='{name}' and Phone='{phone}' and IsDeleted=0";
            return Exists(strWhere);
        }
    }
}
