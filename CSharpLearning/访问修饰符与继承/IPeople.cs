using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.访问修饰符与继承
{
    /// <summary>
    /// 接口   命名：以I开头，后面Pascal命名
    /// 接口中方法：返回值  方法名  参数列表  不能有访问修饰符   也不能有主体
    /// 约定或模板---------做什么，不是怎么做
    /// 抽象方法
    /// 接口不能被直接实例化   通过实现类来实例化
    /// </summary>
    public interface IPeople
    {
        void Show();
        bool Add(People p);
        void ShowInfo(People p);
        int GetId();
        People GetInfo();
    }
}
