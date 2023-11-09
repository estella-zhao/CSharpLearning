using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinStudent
{
    /// <summary>
    /// 静态类静态方法
    /// </summary>
   public static   class BindHelper
    {
        /// <summary>
        /// 将数据源中指定属性绑定到控件中的指定属性，
        /// </summary>
        /// <param name="c"></param>
        /// <param name="source"></param>
        /// <param name="proName"></param>
        /// <param name="dataMember"></param>
        public static void Bind(this Control c, object source, string proName, string dataMember)
        {
            if (c.DataBindings[proName] != null)
                RemoveBind(c, proName);
            c.DataBindings.Add(proName, source, dataMember);
        }
        /// <summary>
        /// 将数据源中指定属性绑定到控件中的指定属性，更新设置源属性更新为：属性值改变更新数据源属性值 
        /// </summary>
        /// <param name="c"></param>
        /// <param name="source"></param>
        /// <param name="proName"></param>
        /// <param name="dataMember"></param>
        /// <param name="blUpdate"></param>
        public static void Bind(this Control c, object source, string proName, string dataMember, bool blUpdate)
        {
            if (c.DataBindings[proName] != null)
                RemoveBind(c, proName);
            if (!blUpdate)
                c.DataBindings.Add(proName, source, dataMember);
            else
                c.DataBindings.Add(proName, source, dataMember, false, DataSourceUpdateMode.OnPropertyChanged);
        }

        /// <summary>
        /// 绑定Text属性
        /// </summary>
        /// <param name="c"></param>
        /// <param name="source"></param>
        /// <param name="dataMember"></param>
        public static void BindText(this Control c, object source, string dataMember)
        {
            Bind(c, source, "Text", dataMember);
        }

        public static void BindText(this Control c, object source, string dataMember, bool blUpdate)
        {
            Bind(c, source, "Text", dataMember, blUpdate);
        }

        //12  12.00  2021-9-8  ----2021-09-08
        public static void BindText(this Control c, object source, string dataMember, bool blUpdate, string formatStr)
        {
            if (c.DataBindings["Text"] != null)
                RemoveBind(c, "Text");
            if (!blUpdate)
                c.DataBindings.Add("Text", source, dataMember);
            else
            {
                if (string.IsNullOrEmpty(formatStr))
                {
                    c.DataBindings.Add("Text", source, dataMember, false, DataSourceUpdateMode.OnPropertyChanged);
                }
                else
                {
                    c.DataBindings.Add("Text", source, dataMember, true, DataSourceUpdateMode.OnPropertyChanged, null, formatStr);
                }
            }

        }

        /// <summary>
        /// 移除指定属性的绑定
        /// </summary>
        /// <param name="c"></param>
        /// <param name="proName"></param>
        private static void RemoveBind(Control c, string proName)
        {
            Binding bind = c.DataBindings[proName];
            c.DataBindings.Remove(bind);
        }
    }
}
