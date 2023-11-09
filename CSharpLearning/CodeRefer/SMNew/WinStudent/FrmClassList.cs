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
    public partial class FrmClassList : Form
    {
        public FrmClassList()
        {
            InitializeComponent();
        }
        public static FrmClassList frmClassList;
        /// <summary>
        /// 静态构造Form实例的方法
        /// </summary>
        /// <returns></returns>
        public static FrmClassList CreateForm()
        {
            if (frmClassList == null || frmClassList.IsDisposed)
                frmClassList = new FrmClassList();
            return frmClassList;
        }

        ClassListViewModel vModel = null;
        private void FrmClassList_Load(object sender, EventArgs e)
        {
            vModel = new ClassListViewModel();
            cbGrades.DisplayMember = "GradeName";
            cbGrades.ValueMember = "GradeId";
            cbGrades.Bind(vModel, "DataSource", "GradeList");
            cbGrades.Bind(vModel, "SelectedValue", "GradeId");
            txtName.BindText(vModel, "ClassName");
            dgvClasses.AutoGenerateColumns = false;
            dgvClasses.Bind(vModel, "DataSource", "ClassList");
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            vModel.ReloadClassList();
        }

        private void dgvClasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                //获取点击的单元格
                DataGridViewCell cell = dgvClasses.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell.FormattedValue.ToString() == "修改")
                {
                    //信息状态切换为修改状态，并且显示班级信息页（修改）
                    int classId = vModel.ClassList[e.RowIndex].ClassId;
                    ShowClassInfo(classId);
                }
                else if (cell.FormattedValue.ToString() == "删除")
                {
                    //删除班级信息
                    vModel.DeleteClass(e.RowIndex);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowClassInfo(0);
        }

        private void ShowClassInfo(int classId)
        {
            FrmClassInfo fClass = new FrmClassInfo();
            fClass.Tag = classId;
            fClass.ReloadList += vModel.ReloadClassList;//刷新事件注册
            fClass.MdiParent = this.MdiParent;
            fClass.Show();//这里不能ShowDialog()
        }


    }
}
