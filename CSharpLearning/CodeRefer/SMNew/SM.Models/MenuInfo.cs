using Common.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Models
{
    /// <summary>
    /// 菜单信息实体
    /// </summary>
    [Table("MenuInfos")]
    [PrimaryKey("MenuId", autoIncrement = true)]
    public  class MenuInfo
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public int ParentId { get; set; }
        public string FrmName { get; set; }
        //是否可以打开多个页面
        public int IsMorePage { get; set; }
        public int MOrder { get; set; }
    }
}
