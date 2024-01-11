using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.特性
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TableAttribute : Attribute
    {
        public string TableName {  get; set; }

        public TableAttribute(string tableName)
        {
            TableName = tableName;
        }
    }
}
