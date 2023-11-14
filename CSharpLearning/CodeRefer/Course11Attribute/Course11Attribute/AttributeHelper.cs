using Course11Attribute.CustAttrs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Course11Attribute
{
    //扩展方法：静态类中静态方法
     public static  class AttributeHelper
    {
        /// <summary>
        /// 获取指定类型对应的表名
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
         public static string GetTableName(this Type type)
        {
            string tableName = "";
            TableAttribute attr = type.GetCustomAttribute<TableAttribute>();
            if (attr != null)
            {
                tableName = attr.TableName;
            }
            else
                tableName = type.Name;
            return tableName;
        }
    }
}
