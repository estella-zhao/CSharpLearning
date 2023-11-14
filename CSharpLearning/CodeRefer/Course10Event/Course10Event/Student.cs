using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course10Event
{
    public class Student
    { 
        //委托
        public delegate void StudyHandler(object sender, StudyArgs e);
        public event StudyHandler Study;//事件
        public int StuId { get; set; }
        public string StuName { get; set; }

        private bool isStart;

        public bool IsStart
        {
            get { return isStart; }
            set { isStart = value;
                OnStudy();
            }
        }

        //事件不能在外部调用，只有在内部：发布者----Student
        //事件的调用
        private void OnStudy()
        {
            //Study?.Invoke(this, new EventArgs());
            //if (Study != null)
            //    Study.Invoke(this, new EventArgs());
            if(isStart)
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
