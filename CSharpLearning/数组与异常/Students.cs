using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.数组与异常
{
    public class Students
    {
        private List<Student> stuList = new List<Student>();
        public int Size
        {
            get { return stuList.Count; }
        }

        public void Add(Student stu)
        {
            stuList.Add(stu);
        }

        public void Remove(Student stu)
        {
            stuList.Remove(stu);
        }
        /// <summary>
        /// 按下标访问的索引器
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Student this[int index]
        {
            get
            {
                Student stu = null;
                if (index >= 0 && index < Size)
                    stu = stuList[index];
                return stu;
            }
            set
            {
                if (index >= 0 && index < Size && stuList[index] != null)
                    stuList[index] = value;
            }
        }
        /// <summary>
        /// 按名称访问的索引器
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Student this[string name]
        {
            get
            {
                foreach (Student stu in stuList)
                {
                    if (stu.StuName == name)
                        return stu;
                }
                return null;
            }
            set
            {
                int index = 0;
                while (index < Size)
                {
                    if (stuList[index].StuName == name)
                    {
                        stuList[index] = value;
                        break;
                    }
                    index++;
                }
            }
        }
    }
}
