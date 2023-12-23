using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.泛型
{
    public class BaseModel
    {
        //泛型  思想：实际类型的指定推迟到调用时-----推迟一切可推迟的
        //泛型方法
        public void Show<T>(T t)
        {
            Console.WriteLine($"类型是：{t.GetType().Name}");
        }
        /// <summary>
        /// 字符串转换成目标类型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str"></param>
        /// <returns></returns>
        public T ToType<T>(string str)
        {
            return (T)Convert.ChangeType(str, typeof(T));
        }

        public void Add<T>(T t1, T t2)
        {

        }

        //基类约束  不能既是引用约束又是基类约束
        public void ShowInfo<T>(T t) where T : ModelBase, IBase
        {
            Console.WriteLine($"Id:{t.Id} Name:{t.Name}");
        }
    }
}
