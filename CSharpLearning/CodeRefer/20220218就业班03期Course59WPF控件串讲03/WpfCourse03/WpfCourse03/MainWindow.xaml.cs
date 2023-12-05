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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfCourse03.Models;

namespace WpfCourse03
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



        /// <summary>
        /// 获取菜单数据
        /// </summary>
        /// <returns></returns>
        private List<MenuInfo> GetMenuList()
        {
            string sql = "select MenuId,MenuName,ParentId,MKey from MenuInfos";
            SqlDataReader dr = SqlHelper.ExecuteReader(sql, 1);
            List<MenuInfo> list = new List<MenuInfo>();
            while (dr.Read())
            {
                MenuInfo menu = new MenuInfo();
                menu.MenuId = (int)dr["MenuId"];
                menu.MenuName = dr["MenuName"].ToString();
                menu.ParentId = (int)dr["ParentId"];
                menu.MKey = dr["MKey"].ToString();
                list.Add(menu);
            }
            dr.Close();
            return list;
        }

        //定义一个递归加载方法
        private void AddMenuItems(List<MenuInfo> allMenus, MenuItem pMenu, int parentId)
        {
            //获取当前的子菜单列表
            var subList = allMenus.Where(m => m.ParentId == parentId);
            foreach (var mi in subList)
            {
                MenuItem mItem = new MenuItem();
                mItem.Header = mi.MenuName;
                if (!string.IsNullOrEmpty(mi.MKey))
                    mItem.InputGestureText = mi.MKey;
                if (pMenu != null)
                    pMenu.Items.Add(mItem);//子菜单
                else
                   menus.Items.Add(mItem);//一级菜单
                AddMenuItems(allMenus, mItem, mi.MenuId);
            }
        }

        private void AddTvItems(List<MenuInfo> allMenus, TreeViewItem pMenu, int parentId)
        {
            //获取当前的子菜单列表
            var subList = allMenus.Where(m => m.ParentId == parentId);
            foreach (var mi in subList)
            {
                TreeViewItem mItem = new TreeViewItem();
                mItem.Header = mi.MenuName;
                if (pMenu != null)
                    pMenu.Items.Add(mItem);//子节点
                else
                    tvList2.Items.Add(mItem);
                AddTvItems(allMenus, mItem, mi.MenuId);
            }
        }

        private void miUser_Click(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("用户管理");
            //打开页面逻辑
            Window1 window = new Window1();
            window.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<MenuInfo> menuList = GetMenuList();
            //调用递归方法
            AddMenuItems(menuList, null, 0);

            //TreeViewItem item1 = new TreeViewItem();
            //item1.Header = "基础资料";
            //TreeViewItem rootNode = tvList.Items[0] as TreeViewItem;
            //rootNode.Items.Add(item1);//添加一个节点

            //TreeViewItem item2 = new TreeViewItem();
            //item2.Header = "商品信息";
            //item1.Items.Add(item2);

            AddTvItems(menuList, null, 0);
        }
    }
}
