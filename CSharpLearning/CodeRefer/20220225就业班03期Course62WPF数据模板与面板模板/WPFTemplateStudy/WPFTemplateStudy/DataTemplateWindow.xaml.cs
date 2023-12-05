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

namespace WPFTemplateStudy
{
    /// <summary>
    /// DataTemplateWindow.xaml 的交互逻辑
    /// </summary>
    public partial class DataTemplateWindow : Window
    {
        public DataTemplateWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<ClassInfo> classList = GetClassList();
            lbList1.ItemsSource = classList;
            //lbList1.DisplayMemberPath = "ClassName";
            cboList1.ItemsSource = classList;
            //所有菜单数据
            List<MenuInfo> menuList = GetMenuList();
            List<MenuItemModel> listMenus = new List<MenuItemModel>();
            AddMenuItems(menuList, listMenus, null, 0);
            tvList1.ItemsSource = listMenus;
            stuMenus.ItemsSource = listMenus;
        }

        /// <summary>
        /// 获取班级信息列表
        /// </summary>
        /// <returns></returns>
        public List<ClassInfo> GetClassList()
        {
            string sql = "select ClassId,ClassName from ClassInfos";
            SqlDataReader dr = SqlHelper.ExecuteReader(sql, 1);
            List<ClassInfo> list = new List<ClassInfo>();
            while (dr.Read())
            {
                ClassInfo classInfo = new ClassInfo();
                classInfo.ClassId = (int)dr["ClassId"];
                classInfo.ClassName = dr["ClassName"].ToString();
                list.Add(classInfo);
            }
            dr.Close();
            return list;
        }

        /// <summary>
        /// 获取菜单信息列表
        /// </summary>
        /// <returns></returns>
        public List<MenuInfo> GetMenuList()
        {
            string sql = "select MenuId,MenuName,ParentId,MKey from MenuInfos";
            SqlDataReader dr = SqlHelper.ExecuteReader(sql, 1);
            List<MenuInfo> list = new List<MenuInfo>();
            while (dr.Read())
            {
                MenuInfo menuInfo = new MenuInfo();
                menuInfo.MenuId = (int)dr["MenuId"];
                menuInfo.MenuName = dr["MenuName"].ToString();
                menuInfo.ParentId = (int)dr["ParentId"];
                menuInfo.MKey = dr["MKey"].ToString();
                list.Add(menuInfo);
            }
            dr.Close();
            return list;
        }

        /// <summary>
        /// 递归生成菜单项
        /// </summary>
        /// <param name="allMenus"></param>
        /// <param name="list"></param>
        /// <param name="pMenu"></param>
        /// <param name="parentId"></param>
        private void AddMenuItems(List<MenuInfo> allMenus, List<MenuItemModel> list, MenuItemModel pMenu, int parentId)
        {
            var subList = allMenus.Where(m => m.ParentId == parentId);//子菜单数据 
            foreach (MenuInfo mi in subList)
            {
                MenuItemModel miInfo = new MenuItemModel();
                miInfo.MenuId = mi.MenuId;
                miInfo.MenuName = mi.MenuName;
                miInfo.MKey = mi.MKey;
                if (pMenu != null)
                    pMenu.SubItems.Add(miInfo);
                else
                    list.Add(miInfo);
                //以当前创建的菜单项为父级，去添加它的子项集合
                AddMenuItems(allMenus, list, miInfo, mi.MenuId);//递归思想
            }

        }
    }
}
