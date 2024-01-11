using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CSharpLearning.反射
{
    public class testReflection
    {
        //相关命名空间 System.Reflection
        //相关类 Type Assembly
        //.Net的重要机制 程序或程序集中每一个类型的信息

        public static void testReflectionMethods() 
        {
            //创建对象
            UserInfo user1 = new UserInfo();
            //假设不直接创建
            Type type = typeof(UserInfo);//获取类型的Type对象
                                         //创建一个UserInfo实例
            UserInfo user2 = Activator.CreateInstance<UserInfo>();
            //使用默认构造函数创建实例
            UserInfo user3 = (UserInfo)Activator.CreateInstance(type);

            user3.UserId = 1;
            user3.UserName = "test";
            user3.Age = 30;
            user3.Show();

            //type.Name 类型名 type.FullName 完整名称 type.NameSpace 命名空间名
            //type.Assembly.GetName().Name 程序集的完整名称
            object user4 = Activator.CreateInstance(type);

            //获取类成员
            var properties = type.GetProperties();//所有的公有属性
            PropertyInfo proId = type.GetProperty("id");//指定的公开属性
            var fields = type.GetFields();//字段
            //获取私有字段
            var privateFields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            //获取所有公开方法
            var publicMethods = type.GetMethods();

            //方法的获取与调用
            MethodInfo mShowWithoutPara = type.GetMethod("Show", new Type[] { });//获取指定名称的无参方法
            mShowWithoutPara.Invoke(user3, null);
            MethodInfo mShowWithPara = type.GetMethod("Show", new Type[] { typeof(string) });//获取指定名称的带参方法
            mShowWithPara.Invoke(user4, new object[] { "布莱泽" });

            //静态方法获取
            MethodInfo staticShow = type.GetMethod("ShowInfo", new Type[] { });
            staticShow.Invoke(null, null);//静态方法调用 第一个参数为null

            //获取构造函数以及用构造函数创建对象
            var cons = type.GetConstructors();//公共的构造函数

            ConstructorInfo cons1 = type.GetConstructor(new Type[] { });
            ConstructorInfo cons2 = type.GetConstructor(new Type[] { typeof(int), typeof(string) });
            UserInfo user5 = (UserInfo)cons1.Invoke(null);//调用无参构造函数
            object user6 = cons2.Invoke(new object[] {12, "Mr.Sun"});
        
        }

        public void testLoadDll()
        {
            /*
             * 加载程序集
             * 3种方式：
             *  1、Load() dll/exe 文件名不带后缀 dll文件放在启动程序所在的地方
             *  2、LoadFile() dll文件的绝对路径
             *  3、LoadFrom() 程序集名称 带dll后缀
             *  
             */

            Assembly ass1 = Assembly.Load("Models");
            Type[] types = ass1.GetTypes();
            Type typeMenu = ass1.GetType("Models.MenuInfo");//类的完整名称 命名空间+类名

            //读写属性值
            object menuInfo = Activator.CreateInstance(typeMenu);//创建实例
            //写属性值
            typeMenu.GetProperty("MenuId").SetValue(menuInfo, 5);
            typeMenu.GetProperty("MenuName").SetValue(menuInfo, "系统管理");
            typeMenu.GetProperty("FrmName").SetValue(menuInfo, "SM.FrmSysManage");
            //读属性值
            foreach (var p in typeMenu.GetProperties()) 
            {
                object objVal = p.GetValue(menuInfo);
                if(objVal != null)
                {
                    Console.WriteLine(objVal.ToString());
                }
            }


        }

    }
}
