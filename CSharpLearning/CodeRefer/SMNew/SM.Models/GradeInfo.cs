using Common.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Models
{
    [Table("GradeInfos")]
    [PrimaryKey("GradeId", autoIncrement = true)]
    public class GradeInfo
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
    }
}
