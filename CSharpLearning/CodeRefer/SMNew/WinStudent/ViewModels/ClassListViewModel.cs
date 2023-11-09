using SM.DAL;
using SM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinStudent.ViewModels
{
     public  class ClassListViewModel:ViewModelBase
    {
        GradeDAL gradeDAL = new GradeDAL();
        ClassDAL classDAL = new ClassDAL();

        public ClassListViewModel()
        {
            GradeList = GetGrades();
            ReloadClassList();
        }

    

        //ClassName  GradeList  GradeId  ClassList
        private string className;
        /// <summary>
        /// 关键词
        /// </summary>
        public string ClassName
        {
            get { return className; }
            set { className = value;
                OnPropertyChanged();
            }
        }

        private int gradeId;
        /// <summary>
        /// 选择的年级编号
        /// </summary>
        public int GradeId
        {
            get { return gradeId; }
            set { gradeId = value;
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// 年级列表
        /// </summary>
        public List<GradeInfo> GradeList
        {
            get;set;
        }

        private BindingList<ClassGradeModel> classList;
        /// <summary>
        /// 班级列表
        /// </summary>
        public BindingList<ClassGradeModel> ClassList
        {
            get { return classList; }
            set
            {
                classList = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 根据查询条件，返回班级列表
        /// </summary>
        /// <returns></returns>
        private BindingList<ClassGradeModel> FindClassList()
        {
            BindingList<ClassGradeModel> reList = new BindingList<ClassGradeModel>();
            List<ClassGradeInfo> list = classDAL.GetClassList(GradeId, ClassName);
            list.ForEach(c => reList.Add(new ClassGradeModel()
            {
                ClassId = c.ClassId,
                ClassName = c.ClassName,
                GradeId = c.GradeId,
                GradeName = c.GradeName,
                Remark = c.Remark
            }));
            return reList;
        }

        public List<GradeInfo> GetGrades()
        {
            List<GradeInfo> grades = gradeDAL.GetGradeList();
            grades.Insert(0, new GradeInfo()
            {
                GradeName = "请选择",
                GradeId = 0
            });
            return grades;
        }

        /// <summary>
        /// 查询班级列表
        /// </summary>
        public void ReloadClassList()
        {
            ClassList = FindClassList();
        }

        /// <summary>
        /// 删除班级信息
        /// </summary>
        /// <param name="index"></param>
        public void DeleteClass(int index)
        {
            //选择的班级信息
            ClassGradeModel classInfo = ClassList[index];
            int classId = classInfo.ClassId;
            //删除的事
            //  班级---学生   删除这两种信息

            string msgTitle = "删除班级";
            if (MsgBoxHelper.MsgBoxConfirm(msgTitle, "删除班级会连同与之相关的学生信息全部删除，你确定要删除吗？") == System.Windows.Forms.DialogResult.Yes)
            {
                bool blDel = classDAL.DeleteClass(classId);
                if (blDel)
                {
                    MsgBoxHelper.MsgBoxShow(msgTitle, "该班级删除成功！");
                    this.ClassList.Remove(classInfo);
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow(msgTitle, "该班级删除失败！");
                    return;
                }
            }
        }

    }
}
