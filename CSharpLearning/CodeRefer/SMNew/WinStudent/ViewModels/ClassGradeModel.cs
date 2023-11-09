using SM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinStudent.ViewModels
{
    public class ClassGradeModel : ViewModelBase
    {
        private ClassGradeInfo classGrade = new ClassGradeInfo();

        public int ClassId
        {
            get { return classGrade.ClassId; }
            set
            {
                classGrade.ClassId = value;
                OnPropertyChanged();
            }
        }

        public string ClassName
        {
            get { return classGrade.ClassName; }
            set
            {
                classGrade.ClassName = value;
                OnPropertyChanged();
            }
        }


        public int GradeId
        {
            get { return classGrade.GradeId; }
            set
            {
                classGrade.GradeId = value;
                OnPropertyChanged();
            }
        }

        public string GradeName
        {
            get { return classGrade.GradeName; }
            set
            {
                classGrade.GradeName = value;
                OnPropertyChanged();
            }
        }

        public string Remark
        {
            get { return classGrade.Remark; }
            set
            {
                classGrade.Remark = value;
                OnPropertyChanged();
            }
        }
    }
}
