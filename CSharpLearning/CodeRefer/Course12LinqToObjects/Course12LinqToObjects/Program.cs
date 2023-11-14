using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Course12LinqToObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Linq查询
            {
                List<CourseInfo> list = GetCourseList();
                //linq 查询  from  s  in  list(要查找的数据集合) select 
                var list1 = from c in list
                            select c;
                //PrintOut(list1);
                //select  投影---原始的类型投影成新的类型或匿名类型
                var list2 = from c in list
                            select   new  
                            {
                                Id = c.CouseId,
                                Name = c.CouseName
                            };//并没去执行查询，拿数据，
                //延迟加载：
                //foreach (var item in list2)
                //{
                //    Console.WriteLine("Id:"+item.Id+",Name:"+item.Name);
                //}
                List<CourseInfo> list0 = list1.ToList();//立即执行查询
                //PrintOut(list2);

                //where 筛选
                //条件：StuCount>35  ClassId=2
                var list3=from c in list
                          where c.StuCount>35 && c.ClassId==2
                          select new
                          {
                              Id = c.CouseId,
                              Name = c.CouseName
                          };
                //PrintOut(list3);
                //orderby 排序
                var list4=from c in list
                          where c.StuCount>35
                          orderby  c.CouseId ascending,c.StuCount descending// ascending升序   descending降序
                          select new
                          {
                              Id = c.CouseId,
                              Name = c.CouseName,
                              Count=c.StuCount
                          };
                //PrintOut(list4);
                // inner  join  只查询匹配得上的数据
                // join 
                var classList = GetClassInfos();
                var list5 = from s in list
                            join c in classList on s.ClassId equals c.ClassId
                            into cInfos
                            from c1 in cInfos
                            select new
                            {
                                CourseId = s.CouseId,
                                CourseName = s.CouseName,
                                ClassId = c1.ClassId,
                                ClassName = c1.ClassName
                            };
                PrintOut(list5);
                Console.WriteLine("*************************************************");
                //left join  以左表为准  匹配得上的，显示对应的信息，匹配不上，以Null占位
                var list6 = from s in list
                            join c in classList on s.ClassId equals c.ClassId
                            into cInfos
                            from c1 in cInfos.DefaultIfEmpty() //如果序列为空就显示默认值
                            select new
                            {
                                CourseId = s.CouseId,
                                CourseName = s.CouseName,
                                ClassId = s.ClassId,
                                ClassName = c1 == null ? "NULL" : c1.ClassName
                            };
                //PrintOut(list6);
                //right join  以右边列表为主，去匹配左边，匹配得上的，显示信息；匹配不上的，以Null占位
                var list7 = from c in classList
                            join s in list on c.ClassId equals s.ClassId
                            into courseInfos
                            from s1 in courseInfos.DefaultIfEmpty() //如果序列为空就显示默认值
                            select new
                            {
                                CourseId = s1==null?0:s1.CouseId,
                                CourseName = s1 == null ? "NULL":s1.CouseName,
                                ClassId = c.ClassId,
                                ClassName = c.ClassName
                            };
                PrintOut(list7);

                //分组  groupby   into groups
                var list8 = from c in classList
                            join s in list on c.ClassId equals s.ClassId
                            into courses
                            orderby courses.Count()
                            select new
                            {
                                ClassId = c.ClassId,
                                ClassName = c.ClassId,
                                CourseCount = courses.Count(),
                                Courses= courses
                            };
                // PrintOut(list8);

                int max = (from s in list select s.StuCount).Max();//获取最大值 
                int min = (from s in list select s.StuCount).Min();//获取最小值
                double avg = (from s in list select s.StuCount).Average();//获取平均值
                (from s in list select s.StuCount).Skip(3).Take(5);
            }
            #endregion
            //linq查询语法----冗长，啰嗦，----不喜欢，想抛弃
            #region Linq扩展方法  支持链式写法
            {
                var list = GetCourseList();
                //Select
                string str = "123,23,12,56,37,98,101";
                string[] strArr = str.Split(',');
                int[] vals = strArr.Select(s => int.Parse(s)).OrderBy(s=>s).ToArray();
                List<Course> courseList1 = list.Select(s => new Course()
                {
                    CouseId = s.CouseId,
                    CouseName = s.CouseName
                }).ToList();

                var list2 = list.Select(s => new
                {
                    Id = s.CouseId,
                    Name = s.CouseName
                });
                //Where  条件筛选   ---应用频率很高
                var list3 = list.Where(s => s.StuCount > 40 && s.CouseId > 4).Select(s=>new Course()
                {
                    CouseId = s.CouseId,
                    CouseName = s.CouseName
                }).ToList();
               var newVals= vals.Where(n => n > 50).ToArray();

                //Orderby 排序
                var orderVals= vals.OrderBy(s=>s).ToArray();
                var list4 = list.OrderByDescending(s => s.StuCount).ToList();
                PrintOut(list4);
                var classList = GetClassInfos();
                //连接查询
                var list5 = list.Join(classList, s => s.ClassId, c => c.ClassId, (s, c) => new
                {
                    CouseId = s.CouseId,
                    CouseName = s.CouseName,
                    ClassName = c.ClassName
                });
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
                PrintOut(list5);

                int max = list.Max(s => s.StuCount);
                int min = list.Min(s => s.StuCount);
                int count = list.Count();
                int sum = list.Sum(s => s.StuCount);
                CourseInfo course1 = list.Find(s => s.ClassId == 3);
                CourseInfo course2 = list.FirstOrDefault();
                list.Distinct();
            }
            #endregion

            Console.ReadKey();
        }

        private static void PrintOut<T>(IEnumerable<T> list)
        {
            PropertyInfo[] props = typeof(T).GetProperties();
            foreach(T t in list)
            {
                string str = "";
                foreach(var p in props)
                {
                    str += $"{p.Name}:{p.GetValue(t)};";
                }
                Console.WriteLine(str);
            }
        }

        private static List<CourseInfo> GetCourseList()
        {
            return new List<CourseInfo>()
          {
                new CourseInfo(){CouseId =1,CouseName="数据库设计",StuCount=35,ClassId=1},
                new CourseInfo(){CouseId =2,CouseName="C#程序设计",StuCount=46,ClassId=4},
                new CourseInfo(){CouseId =3,CouseName="Java程序设计",StuCount=28,ClassId=2},
                new CourseInfo(){CouseId =4,CouseName="大学英语",StuCount=58,ClassId=4},
                new CourseInfo(){CouseId =5,CouseName="高等数学",StuCount=38,ClassId=3},
                new CourseInfo(){CouseId =6,CouseName="C语言设计",StuCount=30,ClassId=1},
                new CourseInfo(){CouseId =7,CouseName="C++程序开发",StuCount=42,ClassId=2},
                new CourseInfo(){CouseId =8,CouseName="全栈开发",StuCount=55,ClassId=2},
                new CourseInfo(){CouseId =9,CouseName=".Net高级开发",StuCount=40,ClassId=3},
                new CourseInfo(){CouseId =10,CouseName=".Net高级开发",StuCount=36,ClassId=1}
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
