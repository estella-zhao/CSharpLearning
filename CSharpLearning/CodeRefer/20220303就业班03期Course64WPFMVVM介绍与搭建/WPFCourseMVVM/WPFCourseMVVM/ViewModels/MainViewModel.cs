using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFCourseMVVM.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            UserName = "admin";
            UserAge = 22;
        }
        private string userName;
        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                OnPropertyChanged();
            }
        }
        private int userAge;
        public int UserAge
        {
            get { return userAge; }
            set
            {
                userAge = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand LoginCmd
        {
            get
            {
                return new RelayCommand(o =>
                {
                    UserName = "Fresh";
                },
                b =>
                {
                    bool bl = (string.IsNullOrEmpty(UserName)) ? false : true;
                    return bl;
                });
            }
        }

        public RelayCommand UserNameChanged
        {
            get
            {
                return new RelayCommand(o =>
                {
                    if(UserName!="")
                    {
                        UserAge += 1;
                    }
                });
            }
        }
    }
}
