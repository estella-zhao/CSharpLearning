using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.泛型
{
    public class genericClass
    {
        public void testGeneric()
        {
            //普通方法
            {
                NoGenericMethods method = new NoGenericMethods();
                int val1 = method.ToInt("123");
                float val2 = method.ToFloat("123.5");
                double val3 = method.ToDouble("23.67");
                decimal val4 = method.ToDecimal("45.6");
            }


            //泛型引入场景：相似的逻辑   传入参数、返回类型不同------解决的问题
            // 泛型类、泛型方法、泛型委托、泛型接口
            //2.泛型定义   ：方法、类、委托、接口  名称后<T>  T:占位符  -----类型参数
            {
                //泛型调用

                BaseModel model = new BaseModel();
                int a = 3;
                model.Show(a);//ok  正确，可以自动推算
                model.Show<double>(34.5);//正确调用  用实际类型去替换类型参数T

                int val1 = model.ToType<int>("123");//这里自动推算，调用时必须显式加上<int>
                float val2 = model.ToType<float>("34.6");

                //应用泛型类
                MyList<UserInfo> userList = new MyList<UserInfo>();//像不像List<User>
                userList.Add(new UserInfo() { Id = 1, Name = "Jsey" });
                userList.Add(new UserInfo() { Id = 2, Name = "Whitle" });
                int count = userList.Size;
                UserInfo user = userList[1];

                IBaseModel<UserInfo> iUser = new BaseModelNew<UserInfo>();
                iUser.Add(user);
                iUser.Delete(user);
                iUser.GetModel(1);
            }
        }

        public void testGenericConstraint()
        {
            //值类型
            //MyList<int> myIds = new MyList<int>();
            //myIds.Add(12);
            //myIds.Add(34);
            //myIds.Remove(12);
            ////myIds.Add(23.5);
            //MyList<double> myIds1 = new MyList<double>();
            //MyList<StudentInfo> myStuList = new MyList<StudentInfo>();//StudentInfo class  引用类型  
            //引用类型
            MyList<StudentInfo> myStuList = new MyList<StudentInfo>();//引用类型约束时，正确的
            MyList<UserInfo> userList = new MyList<UserInfo>();
            //  MyList<string> strList = new MyList<string>();  它对new() 无效

            BaseModel model = new BaseModel();
            UserInfo user = new UserInfo() { Id = 1, Name = "Jsey" };
            model.ShowInfo<UserInfo>(user);
            //model.ShowInfo<string>("sss");//不行  string 不是ModelBase派生而来的
        }
    }
}
