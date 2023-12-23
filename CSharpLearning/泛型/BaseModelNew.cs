using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.泛型
{
    public class BaseModelNew<T> : IBaseModel<T>
    {
        public void Add(T t)
        {
            Console.WriteLine($"Add  {t.GetType().Name}");
        }

        public void Delete(T t)
        {
            Console.WriteLine($"Delete  {t.GetType().Name}");
        }

        public T GetModel(int id)
        {
            Console.WriteLine($"GetModel  {typeof(T).Name}");
            return default(T);
        }
    }
}
