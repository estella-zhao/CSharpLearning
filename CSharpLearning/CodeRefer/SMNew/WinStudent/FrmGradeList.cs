using SM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinStudent.ViewModels;

namespace WinStudent
{
    public partial class FrmGradeList : Form
    {
        public FrmGradeList()
        {
            InitializeComponent();
        }

        public static FrmGradeList frmGrade;
        /// <summary>
        /// 静态构造Form实例的方法
        /// </summary>
        /// <returns></returns>
        public static FrmGradeList CreateForm()
        {
            if (frmGrade == null || frmGrade.IsDisposed)
                frmGrade = new FrmGradeList();
            return frmGrade;
        }
        GradeListViewModel fvModel = new GradeListViewModel();
        private void FrmGradeList_Load(object sender, EventArgs e)
        {
            dgvGradeList.AutoGenerateColumns = false;
            // txtGradeName.DataBindings.Add("Text", fvModel, "GradeName");
            txtGradeName.BindText(fvModel, "GradeName");
            dgvGradeList.Bind( fvModel, "DataSource", "GradeList");
            btnOK.BindText(fvModel, "BtnText");
        
        }

        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            //实现过程 ----ViewModel中实现
            fvModel.SubmitGradeInfo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fvModel.AddGrade();
        }

        private void dgvGradeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>-1)
            {
                //获取点击的单元格
                DataGridViewCell cell = dgvGradeList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                
                if(cell.FormattedValue.ToString()=="修改")
                {
                    //信息状态切换为修改状态，并且加载年级信息
                    fvModel.LoadGradeInfo(e.RowIndex);
                }
                else if (cell.FormattedValue.ToString() == "删除")
                {
                    fvModel.DeleteGrade(e.RowIndex);
                }
            }
        }
    }
}
