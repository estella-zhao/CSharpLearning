using Helper;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFCourse03.Models;

namespace WPFCourse03
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private DataTable GetClasses()
        {
            string sql = "select ClassId,ClassName from ClassInfos where GradeId=4";
            return SqlHelper.GetDataTable(sql, 1);
        }

        private List<ClassInfo> GetClassList()
        {
            DataTable dt = GetClasses();
            List<ClassInfo> list = new List<ClassInfo>();
            foreach (DataRow row in dt.Rows)
            {
                ClassInfo info = new ClassInfo()
                {
                    ClassId = int.Parse(row["ClassId"].ToString()),
                    ClassName = row["ClassName"].ToString()
                };
                list.Add(info);

            }
            return list;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataTable dt = GetClasses();
            cboClasses.DisplayMemberPath = "ClassName";
            cboClasses.SelectedValuePath = "ClassId";
            cboClasses.ItemsSource = dt.AsDataView();

            List<ClassInfo> list = GetClassList();
            lbList.DisplayMemberPath = "ClassName";
            lbList.SelectedValuePath = "ClassId";
            lbList.ItemsSource =list;

        }

        private void cboClasses_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string id = cboClasses.SelectedValue.ToString();
        }
    }
}
