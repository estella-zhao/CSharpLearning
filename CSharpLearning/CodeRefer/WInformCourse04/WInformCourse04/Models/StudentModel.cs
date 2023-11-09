using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformCourse03.DAL;
using WinformCourse04;
using WInformCourse04.DAL;

namespace WInformCourse04.Models
{
    public  class StudentModel:ViewModelBase
    {
        ClassDAL classDAL = new ClassDAL();
        StudentDAL studentDAL = new StudentDAL();
        private StudentInfo studentInfo = new StudentInfo();
        public int StuId
        {
            get { return studentInfo.StuId; }
            set
            {
                studentInfo.StuId = value;
            }
        }

        /// <summary>
        /// 选择的班级编号
        /// </summary>
        public int ClassId
        {
            get { return studentInfo.ClassId; }
            set
            {
                studentInfo.ClassId = value;
                OnPropertyChanged();
            }
        }

        public List<ClassInfo> ClassList
        {
            get
            {
                List<ClassInfo> classList = classDAL.GetModelList("ClassId,ClassName", "", 0);
                classList.Insert(0, new ClassInfo()
                {
                    ClassId = 0,
                    ClassName = "请选择"
                });
                return classList;
            }

        }


        /// <summary>
        /// 姓名
        /// </summary>
        public string StuName
        {
            get { return studentInfo.StuName; }
            set
            {
                studentInfo.StuName = value;
                OnPropertyChanged();
            }
        }

        private bool isMale;
        //男  单选按钮的勾选状态
        public bool IsMale
        {
            get { return isMale; }
            set
            {
                isMale = value;
                isFemale = !isMale;
                OnPropertyChanged();
            }
        }

        private bool isFemale;
        //女  单选按钮的勾选状态
        public bool IsFemale
        {
            get { return isFemale; }
            set
            {
                isFemale = value;
                isMale = !isFemale;
                OnPropertyChanged();
            }
        }

        public string Phone
        {
            get { return studentInfo.Phone; }
            set
            {
                studentInfo.Phone = value;
                OnPropertyChanged();
            }
        }

    }
}
