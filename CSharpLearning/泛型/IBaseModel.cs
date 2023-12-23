using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.泛型
{
    //泛型接口
    public interface IBaseModel<T>
    {
        void Add(T t);
        void Delete(T t);

        T GetModel(int id);
    }
}
