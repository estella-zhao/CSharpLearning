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
    public class ClassDAL:BaseDAL<ClassInfo>
    {
        /// <summary>
        /// 查询班级列表
        /// </summary>
        /// <param name="gradeId"></param>
        /// <param name="className"></param>
        /// <returns></returns>
        public List<ClassGradeInfo> GetClassList(int gradeId,string className)
        {
            string sql = "select ClassId,ClassName,c.GradeId,GradeName,Remark from ClassInfos c inner join GradeInfos g" +
                " on c.GradeId=g.GradeId where 1=1";
             if(gradeId>0)
            {
                sql += " and c.GradeId=@gradeId";
            }
             if(!string.IsNullOrEmpty(className))
            {
                sql += " and ClassName like @className";
            }
            SqlParameter[] paras =
            {
                new SqlParameter("@gradeId",gradeId),
                new SqlParameter("@className",$"%{className}%")
            };
            DataTable dt = SqlHelper.GetDataTable(sql, 1, paras);
            return DbConvert.DataTableToList<ClassGradeInfo>(dt, "");
        }

        /// <summary>
        /// 删除班级信息
        /// </summary>
        /// <param name="classId"></param>
        /// <returns></returns>
        public bool DeleteClass(int classId)
        {
            string sqlStudent = $"delete from StudentInfos where ClassId={classId}";
            string sqlClass = $"delete from ClassInfos where ClassId={classId}";
            List<string> sqlList = new List<string> { sqlStudent, sqlClass };
            return SqlHelper.ExecuteTrans(sqlList);
        }

        /// <summary>
        /// 检查班级是否已存在
        /// </summary>
        /// <param name="className"></param>
        /// <param name="gradeId"></param>
        /// <returns></returns>
        public bool ExistClass(string className,int gradeId)
        {
            string strWhere = $" ClassName='{className}' and GradeId={gradeId}";
            return Exists(strWhere);
        }

        public bool AddClass(ClassInfo classInfo)
        {
            return Add(classInfo, "ClassName,GradeId,Remark", 0) > 0;
        }

        public bool UpdateClass(ClassInfo classInfo)
        {
            return Update(classInfo, "ClassId,ClassName,GradeId,Remark");
        }
        /// <summary>
        /// 获取组合班级列表
        /// </summary>
        /// <returns></returns>
        public List<ClassInfo> GetClassNewList()
        {
            List<ClassInfo> list = new List<ClassInfo>();
            string sql = "select ClassId,ClassName,GradeName from ClassInfos c inner join GradeInfos g" +
                " on c.GradeId=g.GradeId  where c.IsDeleted=0";
            DataTable dt = SqlHelper.GetDataTable(sql, 1);
            if(dt.Rows.Count>0)
            {
                foreach (DataRow  dr in dt.Rows)
                {
                    if(!string.IsNullOrEmpty(dr["ClassId"].ToString()))
                    {
                        ClassInfo info = new ClassInfo();
                        info.ClassId = dr["ClassId"].GetInt();
                        info.ClassName = dr["ClassName"].ToString() + " " + dr["GradeName"].ToString();
                        list.Add(info);
                    }
                }
            }
            return list;
        }
    }
}
