using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WInformCourse04.DAL;
using WInformCourse04.Models;

namespace WInformCourse04
{
    public  class StudentListViewModel:ViewModelBase
    {
        StudentDAL studentDAL = new StudentDAL();
        public StudentListViewModel()
        {
            ReLoadStudents();
        }

        public void ReLoadStudents()
        {
            StudentList = GetStudentList();
        }

        private BindingList<StudentInfo> studentList;
        public BindingList<StudentInfo> StudentList
        {
            get {
                return studentList;
            }
            set
            {
                studentList = value;
                OnPropertyChanged();
            }
        }

        private BindingList<StudentInfo> GetStudentList()
        {
            List<StudentInfo> stuList = studentDAL.GetStudentList(0, "", "", "", 0);
            BindingList<StudentInfo> list = new BindingList<StudentInfo>();
            stuList.ForEach(s => list.Add(s));
            return list;
        }
    }
}
