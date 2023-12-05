using Helper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFCourse03.Models;

namespace WPFCourse03
{
    /// <summary>
    /// DataGridWindow.xaml 的交互逻辑
    /// </summary>
    public partial class DataGridWindow : Window
    {
        public DataGridWindow()
        {
            InitializeComponent();
        }

        private List<StudentInfo> GetStudentList()
        {
            string sql = "select StuId,StuName,ClassId,Sex,Phone from StudentInfos";
            SqlDataReader dr = SqlHelper.ExecuteReader(sql, 1);
            List<StudentInfo> list = new List<StudentInfo>();
            while (dr.Read())
            {
                StudentInfo stu = new StudentInfo();
                stu.StuId = int.Parse(dr["StuId"].ToString());
                stu.StuName = dr["StuName"].ToString();
                stu.ClassId = int.Parse(dr["ClassId"].ToString());
                stu.Sex = dr["Sex"].ToString();
                stu.IsMale = stu.Sex == "男" ? true : false;
                stu.Phone = dr["Phone"].ToString();
                list.Add(stu);
            }
            dr.Close();
            return list;
        }

        private List<ClassInfo> GetClassList()
        {
            string sql = "select ClassId,ClassName from ClassInfos where IsDeleted=0";
            SqlDataReader dr = SqlHelper.ExecuteReader(sql, 1);
            List<ClassInfo> list = new List<ClassInfo>();
            while (dr.Read())
            {
                ClassInfo info = new ClassInfo()
                {
                    ClassId = int.Parse(dr["ClassId"].ToString()),
                    ClassName = dr["ClassName"].ToString()
                };
                list.Add(info);
            }

            return list;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<StudentInfo> listStudents = GetStudentList();
            List<ClassInfo> classList = GetClassList();
            colClasses.ItemsSource = classList;
            dgList.ItemsSource = listStudents;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            int stuId = int.Parse(((Button)sender).Tag.ToString());
            //显示信息页面，加载学生信息，修改操作---提交 
        }
    }
}
