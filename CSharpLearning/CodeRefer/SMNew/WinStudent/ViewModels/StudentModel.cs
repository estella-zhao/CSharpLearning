using SM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinStudent.ViewModels
{
    public class StudentModel:ViewModelBase
    {
        private StudentClassInfo studentClass = new StudentClassInfo();

        public int StuId
        {
            get { return studentClass.StuId; }
            set
            {
                studentClass.StuId = value;
                OnPropertyChanged();
            }
        }

        public string StuName
        {
            get { return studentClass.StuName; }
            set
            {
                studentClass.StuName = value;
                OnPropertyChanged();
            }
        }

        public int ClassId
        {
            get { return studentClass.ClassId; }
            set
            {
                studentClass.ClassId = value;
                OnPropertyChanged();
            }
        }

        public string ClassName
        {
            get { return studentClass.ClassName; }
            set
            {
                studentClass.ClassName = value;
                OnPropertyChanged();
            }
        }

        public string Sex
        {
            get { return studentClass.Sex; }
            set
            {
                studentClass.Sex = value;
                OnPropertyChanged();
            }
        }

        public string Phone
        {
            get { return studentClass.Phone; }
            set
            {
                studentClass.Phone = value;
                OnPropertyChanged();
            }
        }
    }
}
