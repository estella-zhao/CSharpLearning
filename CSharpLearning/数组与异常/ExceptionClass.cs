using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.数组与异常
{
    public class ExceptionClass
    {
        public void testException()
        {
            //异常处理：在上层捕获，并处理，不要在下层处理（不得不捕获异常，可以捕获，但不处理，往上抛）  
            //下层非必须不要进行异常捕获。
            int c = 0;
            try
            {
                //可能会出现异常的语句块（一条或多条）

                //int a = 12, b = 0;
                //c = a / b;

                int[] arr1 = { 1, 2, 3 };
                //  arr1[3] = 4;

                StuDAL dal = new StuDAL();
                Student stu = null;
                dal.UpdateStu(stu);
                c = 12;
            }
            //catch(DivideByZeroException ex1)  
            //{
            //    Console.WriteLine("除数不能为0" );//处理异常
            //    c = -1;
            //}
            //catch(IndexOutOfRangeException ex2)
            //{
            //    Console.WriteLine("你访问的索引超出了范围");

            //}
            //catch(NullReferenceException ex3)
            //{
            //    Console.WriteLine("未将对象引用到实例！");
            //}
            catch (Exception ex)  //catch  异常捕获   一个或多个catch
            {
                Console.WriteLine(ex.Message + " " + ex.GetType().Name);//处理异常
                                                                        //throw; //抛出异常   用于下层
            }
            //finally  //非必须
            //{

            //}
        }
    }
}
