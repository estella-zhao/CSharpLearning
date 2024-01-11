using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.特性
{

    public class RemarkHelper
    {
        /// <summary>
        /// 获取指定类型的注释
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string GetDescription<T>()
        {
            Type type = typeof(T);
            string desp = "";
            RemarkAttribute attr = type.GetCustomAttribute<RemarkAttribute>();
            if (attr != null)
            {
                desp = attr.Description;
            }
            return desp;
        }

        /// <summary>
        /// 获取指定成员的注释
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string GetPropDescription(PropertyInfo p) 
        {
            string desp = "";
            RemarkAttribute attr = p.GetCustomAttribute<RemarkAttribute>();
            if(attr != null)
            {
                desp = attr.Description;
            }
            return desp;
        }

        /// <summary>
        /// 获取指定方法的注释
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
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
