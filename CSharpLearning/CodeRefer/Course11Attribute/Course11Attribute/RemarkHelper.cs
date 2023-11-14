using Course11Attribute.CustAttrs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Course11Attribute
{
    public class RemarkHelper
    {
        /// <summary>
        /// 获取指定类型的注释
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string GetDescription<T>()
        {
            Type type = typeof(T);
            string desp = "";
            RemarkAttribute attr = type.GetCustomAttribute<RemarkAttribute>();
            if(attr!=null)
            {
                desp = attr.Description;
            }
            return desp;
        }
        /// <summary>
        /// 获取指定成员的注释
        /// </summary>
        /// <param name="pro"></param>
        /// <returns></returns>
        public static string GetProDescription(PropertyInfo  t) 
        {
            string desp = "";
            RemarkAttribute attr = t.GetCustomAttribute<RemarkAttribute>();
            if (attr != null)
            {
                desp = attr.Description;
            }
            return desp;
        }

        public static string GetMethodDescription(MethodInfo m)
        {
            string desp = "";
            RemarkAttribute attr = m.GetCustomAttribute<RemarkAttribute>();
            if (attr != null)
            {
                desp = attr.Description;
            }
            return desp;
        }
    }
}
