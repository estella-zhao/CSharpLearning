using System;
using System.Collections.Generic;
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

namespace WPFTemplateStudy
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
        /// 遍历到的元素添加到TreeView中
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="item"></param>
        /// <param name="parentItem"></param>
        private void AddTreeViewItem(TreeView tv,object obj, TreeViewItem item, TreeViewItem parentItem)
        {
            item.Header = obj.GetType().Name;
            item.IsExpanded = true;
            if (parentItem == null)
            {
                tv.Items.Add(item);
            }
            else
            {
                parentItem.Items.Add(item);
            }
        }

        /// <summary>
        /// 遍历逻辑树方法
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="parentItem"></param>
        private void PrintLogcTree(object obj, TreeViewItem parentItem)
        {
            TreeViewItem item = new TreeViewItem();
            AddTreeViewItem(tvLTrees, obj, item, parentItem);
            if (!(obj is DependencyObject))
            {
                return;
            }
            foreach (object child in LogicalTreeHelper.GetChildren(obj as DependencyObject))
            {
                if (child is TreeView)
                    return;
                PrintLogcTree(child, item);
            }
        }

        /// <summary>
        /// 遍历视觉树
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="parentItem"></param>
        private void PrintVisualTree(DependencyObject obj, TreeViewItem parentItem)
        {
            TreeViewItem item = new TreeViewItem();
            AddTreeViewItem(tvVTrees, obj, item, parentItem);
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                if (obj is TreeView)
                    return;
                PrintVisualTree(VisualTreeHelper.GetChild(obj, i), item);
            }
        }

        private void ShowLogicTrees(object sender, RoutedEventArgs e)
        {
            tvLTrees.Items.Clear();
            PrintLogcTree(this, null);
        }
        private void ShowVisualTrees(object sender, RoutedEventArgs e)
        {
            tvVTrees.Items.Clear();
            PrintVisualTree(this, null);
        }

    }
}
