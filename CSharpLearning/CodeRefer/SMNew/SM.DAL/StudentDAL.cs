using Common;
using Helper;
using SM.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.DAL
{
    public class StudentDAL:BaseDAL<StudentInfo>
    {
        /// <summary>
        /// 学生信息查询 
        /// </summary>
        /// <param name="classId"></param>
        /// <param name="stuName"></param>
        /// <returns></returns>
        public List<StudentClassInfo> GetStudentList(int classId, string stuName)
        {
            string sql = "select StuId,StuName,Sex,s.ClassId,ClassName,Phone from StudentInfos s  inner join ClassInfos  c" +
                " on s.ClassId=c.ClassId where 1=1";
            if (classId > 0)
            {
                sql += " and s.ClassId=@classId";
            }
            if (!string.IsNullOrEmpty(stuName))
            {
                sql += " and StuName like @stuName";
            }
            SqlParameter[] paras =
          {
                new SqlParameter("@classId",classId),
                new SqlParameter("@stuName",$"%{stuName}%")
            };
            DataTable dt = SqlHelper.GetDataTable(sql, 1, paras);
            return DbConvert.DataTableToList<StudentClassInfo>(dt, "StuId,StuName,Sex,ClassId,ClassName,Phone");
        }

        /// <summary>
        /// 删除学生信息
        /// </summary>
        /// <param name="stuIds"></param>
        /// <returns></returns>
        public bool DeleteStudents(List<int> stuIds)
        {
            string strIds = string.Join(",", stuIds);
            string sqlStudent = $"delete from StudentInfos where StuId in ({strIds})";
            List<string> sqlList = new List<string> { sqlStudent };
            return SqlHelper.ExecuteTrans(sqlList);
        }

        /// <summary>
        /// 判断学生是否已存在
        /// </summary>
        /// <param name="stuName"></param>
        /// <param name="phone"></param>
        /// <returns></returns>
        public bool ExistStudent(string stuName, string phone)
        {
            string sql = "select count(1) from StudentInfos where StuName=@stuName and Phone=@phone";
            SqlParameter[] paras =
            {
                  new SqlParameter("@StuName",stuName),
                  new SqlParameter("@Phone",phone)
            };
            object oCount = SqlHelper.ExecuteScalar(sql, 1, paras);
            if (oCount == null || oCount == DBNull.Value)
                return false;
            else if (oCount.GetInt() > 0)
                return true;
            else
                return false;
        }

        public bool AddStudent(StudentInfo stu)
        {
            return Add(stu, "StuName,ClassId,Sex,Phone",0)>0;
        }

        public bool UpdateStudent(StudentInfo stu)
        {
            return Update(stu, "StuId,StuName,ClassId,Sex,Phone");
        }
    }
}
