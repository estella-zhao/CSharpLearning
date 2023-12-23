using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.泛型
{
    /// <summary>
    /// 泛型类
    /// 1、T:struct 值类型约束
    /// 2、T:class  引用类型约束
    /// 1和2不能同时用
    /// 3、无参构造函数约束new()若与其他约束一起使用，只能放在最后
    /// 4、基类约束
    /// 5、接口约束 应用实际类型必须实现该接口 T:IBase
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyList<T> where T: class, new()
    {
        List<T> childs = new List<T>();

        public int Size
        {
            get
            {
                return childs.Count;
            }
        }

        public void Add(T t)
        {
            T t1 = new T();//可以创建一个类型的实例（有了无参构造函数约束才行）
            childs.Add(t);
        }

        public void Remove(T t)
        {
            childs.Remove(t);
        }

        public T this[int index]
        {
            get
            {
                T t = default(T);//返回该类型的默认值
                if (index >= 0 && index <= childs.Count - 1)
                {
                    t = childs[index];
                }
                return t;
            }
            set
            {
                if (index >= 0 && index <= childs.Count - 1)
                {
                    childs[index] = value;
                }
            }
        }
    }


}
