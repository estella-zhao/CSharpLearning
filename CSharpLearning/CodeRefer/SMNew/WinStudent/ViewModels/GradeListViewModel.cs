using SM.DAL;
using SM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinStudent.ViewModels
{
    public class GradeListViewModel : ViewModelBase
    {
        GradeDAL gradeDAL = new GradeDAL();
        public GradeListViewModel()
        {
            this.GradeList = GetGradeListNew();
            this.Flag = 1;
            ActType = 1;
            GradeId = 0;
            oldGradeName = "";
            this.BtnText = "添加";
            this.GradeName = "";
        }
        //修改前的年级名称
        private string oldGradeName = "";
        /// <summary>
        /// 将要修改的年级编号
        /// </summary>
        public int GradeId { get; set; }
        //年级编辑状态  1  新增  2 修改
        public int Flag { get; set; } = 1;
        private string gradeName;

        public string GradeName
        {
            get { return gradeName; }
            set
            {
                gradeName = value;
                OnPropertyChanged();
            }
        }

        private string btnText;
        /// <summary>
        /// 提交按钮文本
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

        private BindingList<GradeModel> gradeList;
        /// <summary>
        /// 年级列表
        /// </summary>
        public BindingList<GradeModel> GradeList
        {
            get { return gradeList; }
            set
            {
                gradeList = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 当前年级信息的提交类型：1 新增  2修改
        /// </summary>
        public int ActType { get; set; } = 1;



        private BindingList<GradeModel> GetGradeListNew()
        {
            BindingList<GradeModel> reList = new BindingList<GradeModel>();
            List<GradeInfo> list = gradeDAL.GetGradeList();
            list.ForEach(g => reList.Add(new GradeModel()
            {
                GradeId = g.GradeId,
                GradeName = g.GradeName
            }));
            return reList;
        }

        /// <summary>
        /// 将年级信息提交状态切换回新增
        /// </summary>
        public void AddGrade()
        {
            ActType = 1;
            BtnText = "添加";
            GradeName = "";
            oldGradeName = "";
        }

        public void LoadGradeInfo(int index)
        {
            //选择的年级信息
            GradeModel gradeInfo = GradeList[index];
            BtnText = "修改";
            ActType = 2;
            if (gradeInfo != null)
            {
                oldGradeName = gradeInfo.GradeName;
                GradeName = gradeInfo.GradeName;
                GradeId = gradeInfo.GradeId;
            }

        }

        /// <summary>
        /// 新增、修改提交
        /// </summary>
        public void SubmitGradeInfo()
        {

            string msgTitle = $"年级{BtnText}提交";
            if (string.IsNullOrEmpty(GradeName))
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, "年级名称不能为空！");
                return;
            }
            //判断存在性
            if (GradeId == 0 || oldGradeName != GradeName)
            {
                if (gradeDAL.ExistsGrade(GradeName))
                {
                    MsgBoxHelper.MsgErrorShow(msgTitle, "年级名称已存在！");
                    return;
                }
            }
            //提交阶段  新增、修改
            if (ActType == 1)
            {
                //新增成功后，返回生成的年级编号
                int newGradeId = gradeDAL.AddGrade(GradeName);
                if (newGradeId > 0)//添加成功
                {
                    MsgBoxHelper.MsgBoxShow(msgTitle, $"年级：{GradeName} 添加成功！");
                    //添加到年级列表
                    this.GradeList.Add(new GradeModel()
                    {
                        GradeId = newGradeId,
                        GradeName = GradeName
                    });
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow(msgTitle, "该年级添加失败!");
                    return;
                }
            }
            else  //修改提交
            {
                if (GradeName == oldGradeName)
                {
                    MsgBoxHelper.MsgErrorShow(msgTitle, "该年级信息并未修改!");
                    return;
                }
                else
                {
                    GradeInfo grade = new GradeInfo()
                    {
                        GradeId = GradeId,
                        GradeName = GradeName
                    };
                    bool blUpdate = gradeDAL.UpdateGrade(grade);
                    if (blUpdate)
                    {
                        MsgBoxHelper.MsgBoxShow(msgTitle, $"年级：{GradeName} 修改成功！");
                        GradeList.Where(g => g.GradeId == GradeId).FirstOrDefault().GradeName = GradeName;
                        oldGradeName = GradeName;
                    }
                    else
                    {
                        MsgBoxHelper.MsgErrorShow(msgTitle, "该年级修改失败!");
                        return;
                    }
                }
            }

        }

        public void DeleteGrade(int index)
        {
            //选择的年级信息
            GradeModel gradeInfo = GradeList[index];
            int gId = gradeInfo.GradeId;
            //删除的事
            //  年级---班级---学生   删除这三种信息

            string msgTitle = "删除年级";
            if (MsgBoxHelper.MsgBoxConfirm(msgTitle, "删除年级会连同与之相关的班级和学生信息全部删除，你确定要删除吗？") == System.Windows.Forms.DialogResult.Yes)
            {
                bool blDel = gradeDAL.DeleteGrade(gId);
                if(blDel)
                {
                    MsgBoxHelper.MsgBoxShow(msgTitle, "该年级删除成功！");
                    this.GradeList.Remove(gradeInfo);
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow(msgTitle, "该年级删除失败！");
                    return;
                }
            }
        }

    }
}
