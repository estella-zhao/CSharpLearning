using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.特性
{
    public static class StringHelper
    {
        /// <summary>
        /// 将字符串转换为Int类型 扩展方法：两个static
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int GetInt(this string str) 
        { 
            int retInt = 0;
            int.TryParse(str, out retInt);
            return retInt;
        }
    }
}
