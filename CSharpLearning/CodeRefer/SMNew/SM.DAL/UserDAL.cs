using Common;
using Helper;
using SM.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.DAL
{
    public class UserDAL:BaseDAL<UserInfo>
    {
        /// <summary>
        /// 登录方法
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
         public bool LoginSystem(UserInfo userInfo)
        {
            //查询命令
            string sql = "select count(1) from UserInfos where UserName=@userName and UserPwd=@userPwd";
            SqlParameter[] paras =
            {
                new SqlParameter("@userName",userInfo.UserName),
                new SqlParameter("@userPwd",userInfo.UserPwd)
            };
            // 建立连接、命令对象  打开连接  执行命令   关闭连接 返回结果
            object oCount = SqlHelper.ExecuteScalar(sql, 1,paras);
            if (oCount != null)
                return oCount.GetInt() > 0;
            else
                return false;

        }
    }
}
