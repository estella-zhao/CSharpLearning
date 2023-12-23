using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.选择循环
{
    internal class SelectStruct
    {
        /// <summary>
        /// 选择分支 满足条件，则执行{}内的语句
        /// </summary>
        public void testSelectStruct()
        {
            //1.
            int newAge = 28;
            //if (newAge > 20)
            //{
            //    Console.WriteLine("成年");
            //}
            //2.  if() {}   else{}  只会执行其中之一
            if (newAge > 20)
            {
                Console.WriteLine("成年");
            }
            else
            {
                Console.WriteLine("未成年");
            }

            //3.if(){}  else if(){}  ....  elseif(){}    （else{}） 多分支，只要执行其一，后面的直接跳过
            if (newAge > 10 && newAge <= 18) //都为true
            {
                Console.WriteLine("未成年");
            }
            else if (newAge > 19 && newAge <= 50)
            {
                Console.WriteLine("中年");
            }
            else if (newAge <= 60 || newAge > 50)//或  其中一个条件为true 
            {
                Console.WriteLine("老年");
            }
            else
            {
                Console.WriteLine("晚年");
            }
            int isCheck = 2;//0  1  2  3 4 5
            string stateName = "";
            //能不能多个不同的值，执行相同的语句块？？？ 可以
            switch (isCheck)
            {
                case 0:
                    stateName = "未审核";
                    break;
                case 1:
                    stateName = "已审核";
                    break;
                case 2:
                    stateName = "已红冲";
                    break;
                case 3:
                case 4:
                case 5:
                    stateName = "已作废";
                    break;
                default:
                    break;
            }
        }
    }
}
