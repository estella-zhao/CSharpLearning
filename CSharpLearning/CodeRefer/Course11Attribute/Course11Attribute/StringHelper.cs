using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course11Attribute
{
    public static  class StringHelper
    {
        /// <summary>
        /// 将字符串转换为Int类型   扩展方法：两个static  
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int GetInt(this string str)
        {
            int reInt = 0;
            int.TryParse(str, out reInt);
            return reInt;
        }
    }
}
