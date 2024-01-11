using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.特性
{
    public class testAttributeClass
    {
        public void testAttribute() 
        { 
            //1、声明自定义特性
            //2、构建特性
            //3、应用自定义特性
            CourseInfo course = new CourseInfo();
            course.CourseId = 1;
            course.CourseName = "CSharp程序设计";

            //类，属性，方法 注释文件拿到
            Type courseType = typeof(CourseInfo);
            //获取自定义特性
            object[] attrs = courseType.GetCustomAttributes(false);

            foreach (var attr in attrs) 
            {
                if (attr is RemarkAttribute)
                {
                    RemarkAttribute attr2 = attr as RemarkAttribute;
                    break;
                }
            }
            //获取指定类型的特性
            RemarkAttribute remarkAttr = courseType.GetCustomAttribute<RemarkAttribute>();
            if (remarkAttr != null)
            {
                string desp = remarkAttr.Description;
                Console.WriteLine($"CourseInfo的注释信息：" + desp);
            }
            Console.WriteLine($"CourseInfo的注释信息：" + RemarkHelper.GetDescription<CourseInfo>());
            var props = courseType.GetProperties();
            //属性上的注释
            foreach (var prop in props)
            {
                ////应用在属性值上的特性
                //RemarkAttribute propAttr = prop.GetCustomAttribute<RemarkAttribute>();
                //if (propAttr != null)
                //{
                //    Console.WriteLine($"{prop.Name}的注释信息：" + RemarkHelper.GetPropDescription(prop));
                //}
                Console.WriteLine($"{prop.Name} 的注释信息：" + RemarkHelper.GetPropDescription(prop));
            }

            MethodInfo mGet = courseType.GetMethod("ShowCourse");
            RemarkAttribute mAttr = mGet.GetCustomAttribute<RemarkAttribute>();
            if (mAttr != null)
            {
                Console.WriteLine($"{mGet.Name}的注释信息：" + mAttr.Description);
            } else
            {
                Console.WriteLine($"{mGet.Name} 无注释");
            }
            Console.WriteLine($"{mGet.Name} 的注释信息：" + RemarkHelper.GetMethodDescription(mGet));

            Console.WriteLine($"{course.CourseId }---{course.CourseName}");

            //表名映射
            TableAttribute tableAttr = courseType.GetCustomAttribute<TableAttribute>();
            string tableName = "";
            if (tableAttr != null)
            {
                tableName = tableAttr.TableName;
            } else
            {
                tableName = courseType.Name;
            }
            Console.WriteLine($"CourseInfo对应的表名是： {tableName}");


            //表名映射实现步骤
            //1、建特性：TableAttribute
            //2、应用特性，指定真实表名
            //3、封装扩展方法：GetTableName(this Type type)
            //4、指定类型的Type对象调用 GetTableName() 即可获取到表名

            string tableName1 = courseType.GetTableName();
            course.ShowCourse();//实例方法调用

            string str = "256";
            int intVal1 = str.GetInt();//调用扩展方法
            int intVal2 = StringHelper.GetInt(str);

        }
    }
}
