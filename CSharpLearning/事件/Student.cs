using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.事件
{
    public class Student
    {
        //委托
        public delegate void StudyHandler(object sender, StudyArgs e);
        public event StudyHandler Study;

        public int StuId { get; set; }

        public string StuName { get; set; }

        private bool isStart;

        public bool IsStart
        {
            get { return isStart; }
            set { 
                isStart = value;
                OnStudy();
            }
        }

        /// <summary>
        /// 事件不能在外部调用，只有在内部调用；
        /// 发布者：Student
        /// </summary>
        private void OnStudy()
        {
            //Study?.Invoke(this, new StudyArgs(StuName));
            //if (Study != null)
            //{
            //    Study.Invoke(this, new StudyArgs(StuName));
            //}

            if (IsStart)
            {
                //多播调用
                foreach (StudyHandler act in Study.GetInvocationList())
                {
                    act.Invoke(this, new StudyArgs(StuName));
                }
            }
        }

    }
}
