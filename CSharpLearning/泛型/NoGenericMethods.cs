using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.泛型
{
    public class NoGenericMethods
    {
        /// <summary>
        /// 将字符串转换成整型
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int ToInt(string str)
        {
            int re = 0;
            int.TryParse(str, out re);
            return re;
        }

        /// <summary>
        /// 将字符串转换为float
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public float ToFloat(string str)
        {
            float re = 0;
            float.TryParse(str, out re);
            return re;
        }

        /// <summary>
        /// 将字符串转换为decimal
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public decimal ToDecimal(string str)
        {
            decimal re = 0;
            decimal.TryParse(str, out re);
            return re;
        }

        /// <summary>
        /// 将字符串转换为double
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public double ToDouble(string str)
        {
            double re = 0;
            double.TryParse(str, out re);
            return re;
        }

        /// <summary>
        /// 显示用户信息
        /// </summary>
        /// <param name="user"></param>
        public void ShowInfo(UserInfo user)
        {
            Console.WriteLine($"编号：{user.Id}  姓名：{user.Name}");
        }
        /// <summary>
        /// 显示学生信息
        /// </summary>
        /// <param name="student"></param>
        public void ShowInfo(StudentInfo student)
        {
            Console.WriteLine($"编号：{student.Id}  姓名：{student.Name}");
        }
    }
}
