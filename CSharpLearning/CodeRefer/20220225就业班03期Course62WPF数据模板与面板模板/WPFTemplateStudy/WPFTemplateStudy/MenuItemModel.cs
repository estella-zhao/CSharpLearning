using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPFTemplateStudy
{
    //菜单项绑定实体
    public class MenuItemModel
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string MKey { get; set; }
        /// <summary>
        /// 子菜单项集合
        /// </summary>
       public List<MenuItemModel> SubItems { get; set; }

        public MenuItemModel()
        {
            SubItems = new List<MenuItemModel>();
        }
      
    }
}
