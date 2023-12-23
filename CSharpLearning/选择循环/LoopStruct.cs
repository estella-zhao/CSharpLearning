using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.选择循环
{
    internal class LoopStruct
    {
        public void testLoopStruct()
        {
            //for  1.....1000
            int total = 0;
            //for (int i = 1; i <= 1000; i++)
            //{
            //    total += i; //total=total+i;
            //}
            //int i = 1;
            //while
            //while(i<=1000)
            //{
            //    total += i;
            //    i++;
            //}
            //Console.WriteLine(total);
            //遍历数组
            //int[] ids = { 2, 4, 13, 45, 98, 59 };
            //for (int i = 1; i <ids.Length; i++)
            //{
            //    ids[i] += 2;
            //    Console.WriteLine(ids[i]);
            //}
            ////foreach 遍历数组或集合中的元素
            //foreach (var id in ids)
            //{
            //    Console.WriteLine(id);
            //}
            //int j = 1;
            ////至少会执行一次语句块，不管条件是否满足
            //do
            //{
            //    total += j;
            //    j++;
            //}
            //while (j<1);

            //循环嵌套   冒泡排序   从大到小排序
            int[] intArr = { 2, 4, 13, 45, 98, 59, 28, 36, 89 };//  8   7   6    ... 1
                                                                //总结交换规律：通用
            for (int i = 0; i < intArr.Length; i++)
            {
                for (int j = 0; j < intArr.Length - i - 1; j++)
                {
                    //交换：大往前交换，小的往后
                    if (intArr[j] < intArr[j + 1])
                    {
                        int temp = intArr[j];
                        intArr[j] = intArr[j + 1];
                        intArr[j + 1] = temp;
                    }
                }
            }
            foreach (int i in intArr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            int index1 = 0;
            while(index1 < intArr.Length)
            {
                int index2 = 0;
                while (index2 < intArr.Length - index1 - 1)
                {
                    if (intArr[index2] > intArr[index2 + 1])
                    {
                        int temp = intArr[index2];
                        intArr[index2] = intArr[index2 + 1];
                        intArr[index2 + 1] = temp;
                    }
                    index2++;
                }
                index1++;
            }

            foreach (int i in intArr)
            {
                Console.Write(i + " ");
            }


            Console.WriteLine();
            // 空心菱形
            int r = 6;
            for (int p = 1; p <= r; p++)
            {
                for (int q = 1; q <= 2 * r - 1; q++)
                {
                    if (q == r - p + 1 || q == r + p - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            for (int p = 1; p <= r - 1; p++)
            {
                for (int q = 1; q <= 2 * r - 1; q++)
                {
                    if (q == p + 1 || q == 2 * r - p - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            //死循环  谨慎使用
            //int s = 10;
            //while (true)
            //{
            //    s += 2;
            //    if (s > 100)
            //    {
            //        break;
            //    }
            //    if (s == 40)
            //        continue;
            //}
        }
    }
}
