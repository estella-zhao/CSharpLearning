using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;//反射命名

namespace Course08ReflectionAndDelegate
{
    class Program
    {
        delegate void ShowMsg();//无参  不带返回值  
        delegate int Substract(int a, int b);//带参数  带返回值
        static void Main(string[] args)
        {

            #region 反射
            {
                // 相关命名空间   类     System.Reflection   Type   Assembly
                //.Net的重要机制  程序或程序集中每一个类型的信息

                //创建对象
                UserInfo user1 = new UserInfo();//创建实例
                //假设不直接创建
                Type type = typeof(UserInfo);//获取类型的Type对象
                UserInfo user2 = Activator.CreateInstance<UserInfo>();//创建一个UserInfo实例
                UserInfo user3 = (UserInfo)Activator.CreateInstance(type);//使用默认构造函数创建实例
                user3.UserId = 1;
                user3.UserName = "Leah";
                user3.Age = 30;
                user3.Show();
                //  type.Name  类型名   FullName  完整名称   Namespace 命名空间名
                // type.Assembly.GetName().Name;  程序集的简单名称 
                object user4= Activator.CreateInstance(type);
                //获取类成员
                var properties = type.GetProperties();//所有的公有属性
                PropertyInfo proId = type.GetProperty("UserId");//指定的公开属性
                var fields = type.GetFields();//字段
                //获取私有的字段
                var priFields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
                var pubMethods = type.GetMethods();//获取所有公开方法
                                                   //user4 调用Show()   GetAge()
                
                //方法的获取与调用
                MethodInfo mShow = type.GetMethod("Show", new Type[] { });
                mShow.Invoke(user4, null);
                //匹配带参数的方法Show
                MethodInfo mShow1 = type.GetMethod("Show", new Type[] { typeof(string)});
                mShow1.Invoke(user4, new object[] { "点点" });

                //静态方法获取
                MethodInfo staticShow = type.GetMethod("ShowInfo", new Type[] { });
                staticShow.Invoke(null, null);//静态方法调用   第一个参数 null

                //获取构造函数以及用构造函数创建对象
                var cons = type.GetConstructors();//公共的构造函数

                ConstructorInfo cons1 = type.GetConstructor(new Type[] { });
                ConstructorInfo cons2 = type.GetConstructor(new Type[] { typeof(int), typeof(string) });
                 UserInfo user5= (UserInfo)cons1.Invoke(null);//调用无参构造函数
                object user6 = cons2.Invoke(new object[] { 12, "Mr.Sun" });



                //加载程序集
                //三种方式
                //1.Load()     dll/exe   文件名不带后缀   dll文件 放在 debug里
                //Assembly ass = Assembly.Load("Models");//加载程序集

                //2.LoadFile()  dll文件绝对路径
                //Assembly ass=Assembly.LoadFile(@"D:\工作\基础班Vip03\Winform+WPF+上位机直播第三期\20210826就业班03期Course08反射与委托\Course08ReflectionAndDelegate\Course08ReflectionAndDelegate\bin\Debug\Models.dll");

                //3.LoadFrom() 程序集名称  带dll后缀
                Assembly ass = Assembly.LoadFrom("Models.dll");
                Type[] types = ass.GetTypes();
                Type typeMenu= ass.GetType("Models.MenuInfo");//类的完整名称    命名空间+类名

                //读写属性值
                object menuInfo = Activator.CreateInstance(typeMenu);//创建实例
                //写属性值  MenuId
                typeMenu.GetProperty("MenuId").SetValue(menuInfo,5);
                typeMenu.GetProperty("MenuName").SetValue(menuInfo, "系统管理");
                typeMenu.GetProperty("FrmName").SetValue(menuInfo, "SM.FrmSysManage");
                //读属性值
                foreach (var p in typeMenu.GetProperties())
                {
                    object objVal= p.GetValue(menuInfo);
                    if(objVal!=null)
                         Console.WriteLine(objVal.ToString());
                }
            }

            #endregion


            #region 委托
            {
                //委托实例化
                // Action<object,EventArgs>

                //委托可指向与它具有相同名称的方法
                DelegateClass del = new DelegateClass();
                //del.ShowMsg();
                //del.Test();
                //委托实例化
                ShowMsg show1 = new ShowMsg(del.ConsoleLine);//参数是：方法的签名（名称）不要加（）
                Substract sub1 = new Substract(del.Add);
                sub1 += del.Substract;
                show1();
                show1.Invoke();

               int re=   sub1(12, 10);  //调用 

                Substract sub2 = del.Add;//赋值委托 
                sub1 += del.Substract;

                //多播委托
            }

            #endregion


            Console.ReadKey();
        }

      
    }
}
