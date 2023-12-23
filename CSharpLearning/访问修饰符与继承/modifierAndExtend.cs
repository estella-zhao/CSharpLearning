using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpLearning.Other;
using CSharpLearning.访问修饰符与继承.Shape;

namespace CSharpLearning.访问修饰符与继承
{
    internal class modifierAndExtend
    {
        public void testModifier()
        {
            //修饰class 只能是public internal
            //修饰成员 public private  protected
            //public 公开的，不受限制   class不能用private去修饰
            People p1 = new People();
            p1.Id = 11;
            StudentNew stuNew1 = new StudentNew();//跨程序集一样可以访问 
            stuNew1.IdNew = 12;

            //internal  同一程序集（不是同一命名空间可以访问）中，可以访问
            Student stu1 = new Student();
            stu1.Id = 14;
            //internal 不同程序中，不能访问
            //TeacherNew teaNew = new Models.TeacherNew();

            //private 变量  方法  

            //protected 成员
            PeopleBase1 pbase1 = new PeopleBase1();
            // pbase1.address = "aaa"; //受保护成员  实例或子类实例也不能访问
            StudentNew2 stuNew2 = new StudentNew2();
            // stuNew2.address = "aaaa";


            //封装   ------》  类------》抽象       类的实例----》对象   （具体）
            Student stu3 = new Student();
            stu3.Id = 23;
            Student stu4 = new Student();
            stu4.Id = 23;
        }

        public void testStatic() 
        {
            //static 即可以修饰方法，也可修饰类，还可以修饰成员 
            StaticClass.Add();//静态类成员通过类名访问
            int count = StaticClass.val;
        }

        public void testMethodModifier()
        {
            /**
             * virtual 可以在子类里重写
             * override虚方法 重写 抽象方法实现
             * new 隐藏父类同名方法 取代父类中同名方法
             * sealed 密封类或派生类中密封重写的方法
             * sealed static不能与abstract一起用
             * abstract 抽象类 抽象方法
             * 抽象方法与虚方法区别：
             *  抽象方法不能有实现
             *  虚方法可以有实现
             * 
             */

            //使用上与普通类无区别，只是不能派生
            SealedClass sealedClass = new SealedClass();
            sealedClass.Show();
        }

        public void testPolymorphic() 
        {
            //静态多态
            MethodsClass method = new MethodsClass();
            method.Add(3.5f, 4.6f);//编译时  
            method.Add(4.4f, 6.1f, 9.9f);

            //动态多态  虚方法
            People p1 = new People();
            p1.Id = 1;
            p1.Name = "点点";
            p1.ShowInfo();//父类行为
            p1.Work(); //父类行为 

            Student stu1 = new Student();
            stu1.Id = 2;
            stu1.Name = "随别杨柳";
            stu1.Phone = "1345667778";
            stu1.ShowInfo();//子类行为
            stu1.Work();//子类行为  new 隐藏了父类的Work()

            People p2 = new Student();
            p2.Id = 3;
            p2.Name = "点点1";

            p2.ShowInfo();//子类中行为
            p2.Work();//父类行为 


            People p3 = new People();
            Student stu3 = (Student)p3;
            stu3.Id = 4;
            stu3.Name = "随别杨柳1";
            stu3.Phone = "13456677781";
            stu3.ShowInfo();//子类行为
            stu3.Work();//子类行为  new 隐藏了父类的Work()
        }

        public void testAbstract()
        {
            //AbstractClass stu4 = new AbstractClass();//error
            AbstractClass stu4 = new AbstractImp();//right 通过派生类来例化
            stu4.Id = 6;
            stu4.Study();
            stu4.Show();

            //抽象类-----动态多态
            AbstractClass teacher1 = new AbstractImp2();//通过派生类来实例化
            teacher1.Id = 8;
            teacher1.Study();
            teacher1.Show();
        }

        public void testInterface()
        {
            People p1 = new People();
            p1.Id = 1;
            p1.Name = "点点";
            p1.ShowInfo();//父类行为
            p1.Work(); //父类行为 

            //接口
            IPeople istudent = new StudentImp();
            int id = istudent.GetId();
            istudent.ShowInfo(p1);
            People stu6 = istudent.GetInfo();

            ShapeBase shape = new ShapeBase();
            shape.Lines = new int[] { 10, 15 };
            shape.CalTotalLength();

            RectangleShape rect1 = new RectangleShape(4);
            rect1.Width = 10;
            rect1.Height = 15;
            rect1.InitLines();
            rect1.CalTotalLength();

            AbstractShape rect2 = new RectangleAbImp(4);
            rect2.Lines = new int[] { 10, 15, 10, 15 };
            rect2.PaintShape();
            rect2.CalTotalLength();
        }
    }
}
