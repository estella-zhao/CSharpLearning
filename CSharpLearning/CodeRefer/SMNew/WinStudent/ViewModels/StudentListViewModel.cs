using SM.DAL;
using SM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinStudent.ViewModels
{
    public class StudentListViewModel:ViewModelBase
    {
        ClassDAL classDAL = new ClassDAL();
        StudentDAL studentDAL = new StudentDAL();

        public StudentListViewModel()
        {
            //按默认条件查询 学生信息
            ReloadStudentList();
        }

        public void ReloadStudentList()
        {
            StudentList = FindStudentList();
        }

       

        private string stuName;
        /// <summary>
        /// 姓名关键词
        /// </summary>
        public string StuName
        {
            get { return stuName; }
            set
            {
                stuName = value;
                OnPropertyChanged();
            }
        }

        private int classId;
        /// <summary>
        /// 选择的班级编号
        /// </summary>
        public int ClassId
        {
            get { return classId; }
            set
            {
                classId = value;
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
        private BindingList<StudentModel> studentList = new BindingList<StudentModel>();
        /// <summary>
        /// 学生列表
        /// </summary>
        public BindingList<StudentModel> StudentList
        {
            get { return studentList; }
            set
            {
                studentList = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 获取学生列表
        /// </summary>
        /// <returns></returns>
        private BindingList<StudentModel> FindStudentList()
        {
            BindingList<StudentModel> reList = new BindingList<StudentModel>();
            List<StudentClassInfo> list = studentDAL.GetStudentList(ClassId,StuName);
            list.ForEach(s => reList.Add(new StudentModel()
            {
                StuId = s.StuId,
                StuName = s.StuName,
                ClassId = s.ClassId,
                ClassName = s.ClassName,
                Sex = s.Sex,
                Phone = s.Phone
            }));
            return reList;
        }

        /// <summary>
        /// 单个学生信息删除
        /// </summary>
        /// <param name="index"></param>
        public void DeleteStudent(int index)
        {
            int stuId = StudentList[index].StuId;
            List<int> stuIds = new List<int> { stuId };
            DeleteStudents(stuIds);
        }

        /// <summary>
        /// 学生信息删除
        /// </summary>
        /// <param name="stuIds"></param>
        public void DeleteStudents(List<int> stuIds)
        {
            //删除的事
            //  学生  信息

            string msgTitle = "删除学生";
            if (MsgBoxHelper.MsgBoxConfirm(msgTitle, "你确定要删除学生信息吗？") == System.Windows.Forms.DialogResult.Yes)
            {
                bool blDel = studentDAL.DeleteStudents(stuIds);
                if (blDel)
                {
                    MsgBoxHelper.MsgBoxShow(msgTitle, "选择的学生删除成功！");
                    //刷新学生列表
                    var delStudents = StudentList.Where(s => stuIds.Contains(s.StuId)).ToList();
                    delStudents.ForEach(s => StudentList.Remove(s));
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow(msgTitle, "选择的学生删除失败！");
                    return;
                }
            }
        }
    }
}
