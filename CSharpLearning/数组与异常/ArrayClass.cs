using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.数组与异常
{
    public class ArrayClass
    {
        public void testArray()
        {
            //声明数组  数据类型[] 数组变量    固定长度
            int[] idArr;
            idArr = new int[6];
            idArr[0] = 12;
            idArr[1] = 1;
            idArr[2] = 3;
            idArr[3] = 11;
            idArr[4] = 30;
            idArr[5] = 100;
            //  idArr[6] = 33;  //索引超出边界
            string[] nameList = new string[6] { "1", "2", "1", "2", "1", "2" };//声明时初始化  指定长度，初始化项长度一定匹配
            int[] numList = new int[5];//声明时指定数组长度，不初始化存储的元素

            string[] nameList1 = new string[] { "1", "2", "1" };//不指定数组长度
            float[] fList = { 12.5f, 2.0f };//声明并初始化
            double[] dList = new double[] { };
            Console.WriteLine(nameList1.Length);
            Console.WriteLine(nameList1[1]);//下标 访问
            //应用：参数列表(传递相同类型的多个参数) 临时存储    

            //动态数组   ArrayList   不使用：存取过程：装箱  拆箱  
            ArrayList arr = new ArrayList();
            arr.Add(12);
            arr.Add("aaa");
            arr.Add(2.3);
            arr.Add(4.5M);
            Console.WriteLine("**************ArrayList************");

            //  Console.WriteLine(arr[2]);
            arr[2] = "string";
            arr.Insert(3, "点点");//在指定索引处插入一个元素
            arr.Remove(12);
            arr.RemoveAt(1);
            arr.RemoveRange(0, 2);//范围移除
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***************List**************");

            //  List   强类型列表
            List<int> rowIds = new List<int>();
            rowIds.Add(12);
            rowIds.Add(23);
            rowIds.Insert(1, 45);
            rowIds.InsertRange(2, new int[] { 3, 4, 7, 10 });//指定范围插入多个  
            rowIds.Sort();
            foreach (var item in rowIds)
            {
                Console.WriteLine(item);
            }
        }

        public void testIndexer()
        {
            Students stuList = new Students();
            stuList.Add(new Student() { StuId = 1, StuName = "saber", Age = 23 });
            stuList.Add(new Student() { StuId = 5, StuName = "blades", Age = 26 });
            stuList.Add(new Student() { StuId = 9, StuName = "espada", Age = 24 });
            stuList.Add(new Student() { StuId = 12, StuName = "saikou", Age = 21 });
            stuList.Add(new Student() { StuId = 17, StuName = "calibur", Age = 20 });

            //Student stu1 = stuList[1];//通过下标读取
            //stuList[3] = new Student() { StuId = 22, StuName = "slash", Age = 28 };//设置指定下标的元素

            Student stu2 = stuList["blades"];//通过名称索引访问
            stuList["saikou"] = new Student() { StuId = 30, StuName = "WhIte", Age = 33 };  //修改指定名称的元素
            Student stu3 = stuList["kenzan"];
            stuList["kenzan"] = new Student() { StuId = 33, StuName = "Green", Age = 30 };
            for (int i = 0; i < stuList.Size; i++)
            {
                Console.WriteLine($"Id:{stuList[i].StuId},Name:{stuList[i].StuName}");
            }
        }
    }
}
