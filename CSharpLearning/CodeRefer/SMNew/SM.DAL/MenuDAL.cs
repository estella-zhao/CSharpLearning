using SM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.DAL
{
    public  class MenuDAL:BaseDAL<MenuInfo>
    {
        /// <summary>
        /// 返回所有菜单数据
        /// </summary>
        /// <returns></returns>
         public List<MenuInfo> GetAllMenus()
        {
            string cols = CreateSql.GetColsString<MenuInfo>("IsDeleted");
            return GetModelList("IsDeleted=0 order by ParentId,MOrder", cols);
        }
    }
}
