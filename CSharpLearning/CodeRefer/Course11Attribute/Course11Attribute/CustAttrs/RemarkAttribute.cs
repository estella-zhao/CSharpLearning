using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course11Attribute.CustAttrs
{
    /// <summary>
    /// 自定义特性类型名：Remark+Attribute   
    /// </summary>
    //指定特性应用于哪些元素
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Property|AttributeTargets.Method)]
    public  class RemarkAttribute : Attribute
    {
        public string Description { get; set; }
        public RemarkAttribute(string desp)
        {
            Description = desp;
        }
    }
}
