using SM.DAL;
using SM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinStudent.ViewModels
{
    public class ClassInfoViewModel:ViewModelBase
    {
        GradeDAL gradeDAL = new GradeDAL();
        ClassDAL classDAL = new ClassDAL();
        private ClassInfo classInfo = new ClassInfo();

        /// <summary>
        /// 页面初始化信息
        /// </summary>
        /// <param name="classId"></param>
        public ClassInfoViewModel(int classId)
        {
            this.ClassId = classId;
            if(classId>0)
            {
                classInfo = classDAL.GetById(classId, "");
                BtnText = "修改";
                oldName = classInfo.ClassName;
                oldGradeId = classInfo.GradeId;
            }
            else
            {
                BtnText = "新增";
                GradeId = 0;
                oldName = "";
                oldGradeId = 0;
            }
        }

        /// <summary>
        /// 年级下拉框数据源
        /// </summary>
        public List<GradeInfo> GradeList
        {
            get
            {
                List<GradeInfo> grades = gradeDAL.GetGradeList();
                grades.Insert(0, new GradeInfo()
                {
                    GradeId = 0,
                    GradeName = "请选择"
                });
                return grades;
            }
        }



        /// <summary>
        /// 选择的年级编号 
        /// </summary>
        public int GradeId
        {
            get { return classInfo.GradeId; }
            set
            {
                classInfo.GradeId = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 当前修改的编号
        /// </summary>
        public int ClassId
        {
            get
            {
                return classInfo.ClassId;
            }
            set { classInfo.ClassId = value; }
        }

        public string ClassName
        {
            get { return classInfo.ClassName; }
            set
            {
                classInfo.ClassName = value;
                OnPropertyChanged();
            }
        }

        public string Remark
        {
            get { return classInfo.Remark; }
            set
            {
                classInfo.Remark = value;
                OnPropertyChanged();
            }
        }

        private string btnText;
        /// <summary>
        /// 按钮文本
        /// </summary>
        public string BtnText
        {
            get { return btnText; }
            set
            {
                btnText = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 修改前的班级名称
        /// </summary>
        private string oldName = "";
        /// <summary>
        /// 修改前的年级编号
        /// </summary>
        private int oldGradeId = 0;

        public void CommitClass(Action reloadList)
        {
            string actTypeName = ClassId == 0 ? "新增" : "修改";
            string msgTitle = $"班级{actTypeName}提交";
            if(string.IsNullOrEmpty(ClassName))
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, "班级名称不能为空！");
                return;
            }
            if(GradeId==0)
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, "请选择年级！");
                return;
            }
            if(ClassId==0||(oldName!=ClassName)||(GradeId!=oldGradeId))
            {
                if(classDAL.ExistClass(ClassName,GradeId))
                {
                    MsgBoxHelper.MsgErrorShow(msgTitle, "班级名称已存在！");
                    return;
                }
            }
            bool bl = false;
            if(ClassId==0)
            {
                bl = classDAL.AddClass(classInfo);
            }
            else
            {
                bl = classDAL.UpdateClass(classInfo);
            }
            if(bl)
            {
                MsgBoxHelper.MsgBoxShow(msgTitle, $"班级：{ClassName} {actTypeName} 成功！");
                reloadList?.Invoke();
            }
            else
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, $"班级：{ClassName} {actTypeName} 失败！");
                return;
            }
        }

    }
}
