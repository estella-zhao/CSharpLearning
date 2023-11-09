using SM.DAL;
using SM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinStudent.ViewModels
{
   public class StudentInfoViewModel:ViewModelBase
    {
        ClassDAL classDAL = new ClassDAL();
        StudentDAL studentDAL = new StudentDAL();
        private StudentInfo studentInfo = new StudentInfo();
        int oldClassId = 0;
        string oldName = "";
        string oldPhone = "";

        public StudentInfoViewModel(int stuId)
        {
            StuId = stuId;
            if(stuId>0)
            {
                studentInfo = studentDAL.GetById(stuId, "");
                BtnText = "修改";
                oldClassId = studentInfo.ClassId;
                oldName = studentInfo.StuName;
                oldPhone = studentInfo.Phone;
            }
            else
            {
                BtnText = "新增";
                studentInfo.Sex = "男";
                ClassId = 0;
            }
            IsMale = studentInfo.Sex == "男" ? true : false;
            IsFemale = !IsMale;
        }

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
                List<ClassInfo> classList = classDAL.GetClassNewList();
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

        private string btnText;

        public string BtnText
        {
            get { return btnText; }
            set
            {
                btnText = value;
                OnPropertyChanged();
            }
        }

        public void CommitStudentInfo(Action reLoad)
        {
            studentInfo.Sex = IsMale ? "男" : "女";
            string msgTitle = "提交学生信息";
            if(string.IsNullOrEmpty(StuName))
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, "学生姓名不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(Phone))
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, "学生电话号码不能为空！");
                return;
            }
            if (ClassId == 0)
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, "请选择班级！");
                return;
            }
            if(StuId==0||oldName!=StuName||oldPhone!=Phone)
            {
                if (studentDAL.ExistStudent(StuName, Phone))
                {
                    MsgBoxHelper.MsgErrorShow(msgTitle, "该学生已存在！");
                    return;
                }
            }
            //提交 
            bool bl = false;
            if(StuId>0)
            {
               bl= studentDAL.UpdateStudent(studentInfo);
            }
            else
            {
               bl= studentDAL.AddStudent(studentInfo);
            }
            string actName = StuId > 0 ? "修改" : "新增";
            if(bl)
            {
                MsgBoxHelper.MsgBoxShow(msgTitle, $"学生：{StuName} {actName} 成功！");
                reLoad?.Invoke();//刷新
            }
            else
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, $"学生：{StuName} {actName} 失败！");
                return;
            }
        }

    }
}
