using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.Linq
{
    public class testLinqClass
    {
        public void testLinq()
        {
            List<CourseInfo> list = GetCourseList();
            //Linq 查询 from s in list(要查找的数据集合) select
            var list1 = from c in list 
                        select c;

            PrintOut(list1);
            //select 投影---原始的类型投影成新的类型或匿名类型
            var list2 = from c in list
                        select new
                        {
                            Id = c.CourseId,
                            Name = c.CourseName
                        };//没去执行查询，拿数据
            //延迟加载
            foreach(var item in list2)
            {
                Console.WriteLine("Id:" + item.Id + ",Name:" + item.Name);
            }
            List<CourseInfo> list3 = list1.ToList();//立即执行查询
            PrintOut(list3);

            //where筛选
            //条件：StuCount>35 ClassId=2
            var list4 = from c in list
                        where c.StuCount > 35 && c.ClassId == 2
                        select new
                        {
                            Id = c.ClassId,
                            Name = c.CourseName
                        };
            PrintOut(list4);

            //orderBy 排序
            var list5 = from c in list
                        where c.StuCount > 35
                        orderby c.CourseId ascending, c.StuCount descending//ascending 升序  descending 降序
                        select new
                        {
                            Id = c.CourseId,
                            Name = c.CourseName,
                            Count = c.StuCount
                        };
            PrintOut(list5);

            //inner join 只查询匹配的上的数据
            //join
            var classList = GetClassInfos();
            var list6 = from s in list
                        join c in classList on s.ClassId equals c.ClassId
                        into cInfos
                        from c1 in cInfos
                        select new
                        {
                            CourseId = s.CourseId,
                            CourseName = s.CourseName,
                            ClassId = c1.ClassId,
                            ClassName = c1.ClassName
                        };
            PrintOut(list6);

            //left join以左表为准，匹配的上的，显示对应的信息；匹配不上，以Null占位
            var list7 = from s in list
                        join c in classList on s.ClassId equals c.ClassId
                        into cInfos
                        from c1 in cInfos.DefaultIfEmpty() //如果序列为空就显示默认值
                        select new
                        {
                            CourseId = s.CourseId,
                            CourseName = s.CourseName,
                            ClassId = s.ClassId,
                            ClassName = c1 == null ? "NULL" : c1.ClassName
                        };
            PrintOut(list7);

            //right join以右表为准，匹配的上的，显示对应的信息；匹配不上，以Null占位
            var list8 = from c in classList
                        join s in list on c.ClassId equals s.ClassId
                        into CourseInfos
                        from s1 in CourseInfos.DefaultIfEmpty() //如果序列为空就显示默认值
                        select new
                        {
                            CourseId = s1.CourseId,
                            CourseName = s1 == null ? "NULL" : s1.CourseName,
                            ClassId = s1.ClassId,
                            ClassName = c.ClassName
                        };
            PrintOut(list8);

            //分组 groupby into groups
            var list9 = from c in classList
                        join s in list on c.ClassId equals s.ClassId
                        into courses
                        orderby courses.Count()
                        select new
                        {
                            ClassId = c.ClassId,
                            ClassName = c.ClassName,
                            CourseCount = courses.Count(),
                            Courses = courses
                        };
            PrintOut(list9);

            int max = (from s in list select s.StuCount).Max();//获取最大值
            int min = (from s in list select s.StuCount).Min();//获取最小值
            double avg = (from s in list select s.StuCount).Average();//获取平均值
            (from s in list select s.StuCount).Skip(3).Take(5);
        }

        public void testLinqChained()
        {
            //Linq查询语法---冗长，
            var list = GetCourseList();
            string str = "123,23,12,56,37,98,101";
            string[] strArr = str.Split(',');
            int[] vals = strArr.Select(s => int.Parse(s)).OrderBy(s=>s).ToArray();
            List<Course> courseList1 = list.Select(s => new Course() 
            { 
                CourseId = s.CourseId,
                CourseName = s.CourseName
            }).ToList();

            var list2 = list.Select(s => new 
            {
                Id = s.CourseId,
                Name = s.CourseName
            });
            //Where 条件筛选 
            var list3 = list.Where(s => s.StuCount > 40 && s.CourseId > 4).Select(s => new Course() 
            {
                CourseId= s.CourseId,
                CourseName= s.CourseName
            }).ToList();

            var newvals = vals.Where(n => n > 50).ToArray();

            //OrderBy 排序
            var orderVals = vals.OrderBy(s=>s).ToArray();
            var list4 = list.OrderByDescending(s => s.StuCount).ToList();
            PrintOut(list4);
            var classList = GetClassInfos();
            //连接查询
            var lists = list.Join(classList, s => s.ClassId, c => c.ClassId, (s, c) => new 
            {
                CourseId = s.CourseId,
                CourseName = s.CourseName,
                ClassName = c.ClassName
            });
            PrintOut(lists);

            int max = list.Max(s => s.StuCount);
            int min = list.Min(s => s.StuCount);
            int count = list.Count();
            int sum = list.Sum(s => s.StuCount);
            CourseInfo course1 = list.Find(s => s.ClassId == 1);
            CourseInfo course2 = list.FirstOrDefault();
            list.Distinct();

            



        }

        private static void PrintOut<T>(IEnumerable<T> list)
        {
            PropertyInfo[] props = typeof(T).GetProperties();
            foreach (var t in list)
            {
                string str = "";
                foreach (var prop in props)
                {
                    str += $"{prop.Name}:{prop.GetValue(t)}";
                }
                Console.WriteLine(str);
            }
        }

        private static List<CourseInfo> GetCourseList()
        {
            return new List<CourseInfo>()
            {
                new CourseInfo(){CourseId =1,CourseName="数据库设计",StuCount=35,ClassId=1},
                new CourseInfo(){CourseId =2,CourseName="C#程序设计",StuCount=46,ClassId=4},
                new CourseInfo(){CourseId =3,CourseName="Java程序设计",StuCount=28,ClassId=2},
                new CourseInfo(){CourseId =4,CourseName="大学英语",StuCount=58,ClassId=4},
                new CourseInfo(){CourseId =5,CourseName="高等数学",StuCount=38,ClassId=3},
                new CourseInfo(){CourseId =6,CourseName="C语言设计",StuCount=30,ClassId=1},
                new CourseInfo(){CourseId =7,CourseName="C++程序开发",StuCount=42,ClassId=2},
                new CourseInfo(){CourseId =8,CourseName="全栈开发",StuCount=55,ClassId=2},
                new CourseInfo(){CourseId =9,CourseName=".Net高级开发",StuCount=40,ClassId=3},
                new CourseInfo(){CourseId =10,CourseName=".Net高级开发",StuCount=36,ClassId=1}
            };
        }

        private static List<ClassInfo> GetClassInfos()
        {
            return new List<ClassInfo>() 
            {
                new ClassInfo(){ClassId=1,ClassName="一班"},
                new ClassInfo(){ClassId=2,ClassName="二班"},
                new ClassInfo(){ClassId=3,ClassName="三班"},
                new ClassInfo(){ClassId=5,ClassName="五班"},
                new ClassInfo(){ClassId=6,ClassName="六班"}
            };
        }


    }
}
