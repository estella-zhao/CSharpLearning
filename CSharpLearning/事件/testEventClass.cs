using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpLearning.事件
{
    public class testEventClass
    {
        public void testEvent()
        {
            Student stu1 = new Student()
            {
                StuId = 1,
                StuName = "naruto"
            };

            stu1.Study += Student_Study;
            stu1.Study += (o, e) =>
            {
                Console.WriteLine("老师开始讲课");
                Thread.Sleep(1000);
            };

            Student.StudyHandler study01 = (o, e) =>
            {
                Console.WriteLine($"学生{e.StuName} 开始做作业");
                Thread.Sleep(1000);
            };

            stu1.Study += study01;
            //stu1.Study -= study01;

            //stu1.Study();//不能在外部调用
            //stu1.StartCourse();//触发并调用
            stu1.IsStart = true;//属性值改变时调用

            Student.StudyHandler stu = Student_Study;
            stu += (o, e) =>
            {
                Console.WriteLine("学生正在学习中");
            };
            stu(stu1, new StudyArgs(stu1.StuName));

        }

        /// <summary>
        /// Study的事件处理程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Student_Study(object sender, StudyArgs args)
        {
            Console.WriteLine($"学生：{args.StuName} 正在学习中。。。");
            Thread.Sleep(1000);
        }



    }
}
