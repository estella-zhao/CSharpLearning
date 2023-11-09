using Common.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Models
{
    [Table("ClassInfos")]
    [PrimaryKey("ClassId")]
    public class ClassInfo
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public int GradeId { get; set; }
        public string Remark { get; set; }

    }
}
