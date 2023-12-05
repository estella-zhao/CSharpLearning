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

namespace WPFCourseDependencyPropertyAndDataBinding
{
    /// <summary>
    /// DataBingWindow2.xaml 的交互逻辑
    /// </summary>
    public partial class DataBindingWindow2 : Window
    {
        public DataBindingWindow2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 获取班级信息列表
        /// </summary>
        /// <returns></returns>
        public List<ClassInfo> GetClassList()
        {
            string sql = "select ClassId,ClassName,GradeId from ClassInfos";
            SqlDataReader dr = SqlHelper.ExecuteReader(sql, 1);
            List<ClassInfo> list = new List<ClassInfo>();
            while (dr.Read())
            {
                ClassInfo classInfo = new ClassInfo();
                classInfo.ClassId = (int)dr["ClassId"];
                classInfo.ClassName = dr["ClassName"].ToString();
                classInfo.GradeId = (int)dr["GradeId"];
                list.Add(classInfo);
            }
            dr.Close();
            return list;
        }

       //public List<ClassInfo> ClassList { get; set; }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<ClassInfo> classList = GetClassList();
            //原来的做法
            //lbList1.ItemsSource = classList;
            //lbList1.DisplayMemberPath = "ClassName";
            //现在的做法
            //1.条目控件的DataContext
            //  lbList1.DataContext = classList;
            //2.
            // this.ClassList = classList;
            //  this.DataContext = this;
            //3.
            Window2VModel vm = new Window2VModel();
            vm.ClassList = classList;
            this.DataContext = vm;
        }
    }
}
