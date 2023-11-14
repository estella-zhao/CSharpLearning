using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Course10Event
{
    //订阅器
    class Program  
    {
        static void Main(string[] args)
        {
            #region 事件
            {
                Student student = new Student()
                {
                    StuId = 1,
                    StuName = "李明"
                };
                student.Study += Student_Study;  
                student.Study += (o, e) =>
                {
                    Console.WriteLine("老师开始讲课！");
                    Thread.Sleep(1000);
                };
                Student.StudyHandler study01 = (o, e) =>
                {
                    Console.WriteLine($"学生:{e.StuName} 开始做作业！");
                    Thread.Sleep(1000);
                };

                student.Study += study01;
                // student.Study -= study01;


                //student.Study();//不能在外部调用
                //  student.StartCourse();//触发并调用 
                student.IsStart = true; //属性值改变时

                //Student.StudyHandler stu =Student_Study;
                //stu += (o, e) =>
                //{
                //    Console.WriteLine("学生正在学习过程中。。。。");
                //};
                //stu(student,new EventArgs());//没问题


            }
            #endregion

            Console.ReadKey();
        }
        /// <summary>
        /// Study的事件处理程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Student_Study(object sender, StudyArgs e)
        {
            Console.WriteLine($"学生:{e.StuName} 正在学习中。。。。");
            Thread.Sleep(1000);
        }
    }
}
