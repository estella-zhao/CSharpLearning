using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WPFTemplateStudy
{
    public  class ComClass
    {
        /// <summary>
        /// 获取指定元素的父类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reference"></param>
        /// <returns></returns>
        public static T GetAncestor<T>(DependencyObject reference) where T : DependencyObject
        {
            DependencyObject parent = VisualTreeHelper.GetParent(reference);
            while (!(parent is T) && parent != null)
            {
                parent = VisualTreeHelper.GetParent(parent);
            }
            if (parent != null)
                return (T)parent;
            else
                return null;
        }

        /// <summary>
        /// 获取指定名称的子元素
        /// </summary>
        /// <typeparam name="childitem"></typeparam>
        /// <param name="obj"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static childitem FindVisualChild<childitem>(DependencyObject obj, string name)
            where childitem : FrameworkElement
        {
            if (obj == null)
                return null;
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                if (child != null && child is childitem && ((childitem)child).Name == name)
                    return (childitem)child;
                else
                {
                    childitem childOfChild = FindVisualChild<childitem>(child, name);
                    if (childOfChild != null)
                        return childOfChild;
                }
            }
            return null;
        }

        public static childitem FindLogicChild<childitem>(DependencyObject obj, string name)
          where childitem : FrameworkElement
        {
            if (obj == null)
                return null;
            foreach (var child in LogicalTreeHelper.GetChildren(obj))
            {
                if (child != null && child is childitem && ((childitem)child).Name == name)
                    return (childitem)child;
                else
                {
                    childitem childOfChild = FindLogicChild<childitem>(child as DependencyObject, name);
                    if (childOfChild != null)
                        return childOfChild;
                }
            }
            return null;
        }
    }
}
