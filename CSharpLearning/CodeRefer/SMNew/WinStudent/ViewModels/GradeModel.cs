using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinStudent.ViewModels
{
    public class GradeModel: ViewModelBase
    {
        private int gradeId;

        public int GradeId
        {
            get { return gradeId; }
            set { gradeId = value;
                OnPropertyChanged();
            }
        }

        private string gradeName;

        public string GradeName
        {
            get { return gradeName; }
            set { gradeName = value;
                OnPropertyChanged();
            }
        }

    }
}
