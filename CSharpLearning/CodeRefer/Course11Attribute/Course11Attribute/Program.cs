using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Course11Attribute.CustAttrs;

namespace Course11Attribute
{
    /// <summary>
    /// 文档注释
    /// </summary>
    class Program
    {
        //单行注释
        static void Main(string[] args)
        {
            #region 特性
            {
                //1.声明自定义特性
                //2.构建特性
                //3.应用自定义特性
                CourseInfo course = new CourseInfo();
                course.CouseId = 1;
                course.CouseName = "C#程序设计";

                //类、属性、方法  注释文件拿到
                Type courseType = typeof(CourseInfo);
                //获取自定义特性
               object[] attrs=  courseType.GetCustomAttributes(false);
                //foreach (var attr0 in attrs)
                //{
                //     if(attr0 is RemarkAttribute)
                //    {
                //        RemarkAttribute attr1 = attr0 as RemarkAttribute;
                //        break;
                //    }
                //}
                //获取指定类型的特性
                //RemarkAttribute attr=  courseType.GetCustomAttribute<RemarkAttribute>();
                //  if(attr!=null)
                //   {
                //      string desp1 = attr.Description;
                //      Console.WriteLine($"CourseInfo的注释信息：" + desp1);
                //  }
                Console.WriteLine($"CourseInfo的注释信息：" + RemarkHelper.GetDescription<CourseInfo>());
                var props = courseType.GetProperties();
                //属性上的注释
                foreach (var p in props)
                {
                    //应用在属性之上的特性
                    // RemarkAttribute pAttr=  p.GetCustomAttribute<RemarkAttribute>();
                    //if (pAttr!=null)
                    //{
                    //    Console.WriteLine($"{p.Name} 的注释信息：" + RemarkHelper.GetProDescription(p));
                    //}
                    Console.WriteLine($"{p.Name} 的注释信息：" + RemarkHelper.GetProDescription(p));
                }
              
                MethodInfo mGet = courseType.GetMethod("ShowCourse");
                //如果没有应用特性，就会返回null
                //RemarkAttribute mAttr= mGet.GetCustomAttribute<RemarkAttribute>();
                //if (mAttr != null)
                //{
                //    Console.WriteLine($"{mGet.Name} 的注释信息：" + mAttr.Description);
                //}
                //else
                //{
                //    Console.WriteLine($"{mGet.Name}  无注释");
                //}
                Console.WriteLine($"{mGet.Name} 的注释信息：" + RemarkHelper.GetMethodDescription(mGet));

                Console.WriteLine($"{course.CouseId}---{course.CouseName}");


                //表名映射：
                TableAttribute tableAttr = courseType.GetCustomAttribute<TableAttribute>();
                string tableName = "";
                if (tableAttr!=null)
                {
                   tableName= tableAttr.TableName;
                }
                else
                {
                    tableName = courseType.Name;
                }
                Console.WriteLine($"CourseInfo对应的表名是：{tableName}");

                //表名映射实现步骤：
                //1.建特性：TableAttribute
                //2.应用特性，指定真实表名
                //3.封装扩展方法：GetTableName(this  Type type)
                //4.指定类型的Type对象调用 GetTableName（）即可获取到表名


                string tableName1 = courseType.GetTableName();
                course.ShowCourse();//实例方法调用

                string str = "256";
                int intVal = str.GetInt();//调用扩展方法
                int val1 = StringHelper.GetInt(str);
               // int val2 = (int)str;
            }
            #endregion

            Console.ReadKey();  
        }
    }
}
