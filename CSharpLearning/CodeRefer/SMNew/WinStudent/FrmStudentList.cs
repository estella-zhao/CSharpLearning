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
    public partial class FrmStudentList : Form
    {
        public FrmStudentList()
        {
            InitializeComponent();
        }

        public static FrmStudentList frmStudentList;
        /// <summary>
        /// 静态构造Form实例的方法
        /// </summary>
        /// <returns></returns>
        public static FrmStudentList CreateForm()
        {
            if (frmStudentList == null || frmStudentList.IsDisposed)
                frmStudentList = new FrmStudentList();
            return frmStudentList;
        }
        StudentListViewModel vModel = null;
        private void FrmStudentList_Load(object sender, EventArgs e)
        {
            vModel = new StudentListViewModel();
            cbClasses.DisplayMember = "ClassName";
            cbClasses.ValueMember = "ClassId";
            cbClasses.Bind(vModel, "DataSource", "ClassList");
            cbClasses.Bind(vModel, "SelectedValue", "ClassId");
            txtName.BindText(vModel, "StuName");
            dgvStudents.AutoGenerateColumns = false;
            dgvStudents.Bind(vModel, "DataSource", "StudentList");
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            vModel.ReloadStudentList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //获取选择的行，拿到选择行的学号
            List<int> stuIds = new List<int>();
            for (int i = 0; i < dgvStudents.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell chkCell = dgvStudents.Rows[i].Cells["colChk"] as DataGridViewCheckBoxCell;
                bool bl = Convert.ToBoolean(chkCell.Value);
                if(bl)
                {
                    stuIds.Add(vModel.StudentList[i].StuId);
                }
            }
            //学生删除
            vModel.DeleteStudents(stuIds);
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                //获取点击的单元格
                DataGridViewCell cell = dgvStudents.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.FormattedValue.ToString() == "修改")
                {
                    //信息状态切换为修改状态，并且显示学生信息页（修改）
                    int stuId = vModel.StudentList[e.RowIndex].StuId;
                    ShowStudentInfo(stuId);
                }
                else if (cell.FormattedValue.ToString() == "删除")
                {
                    //删除班级信息
                    vModel.DeleteStudent(e.RowIndex);
                }
            }
        }

        /// <summary>
        /// 显示学生页面页
        /// </summary>
        /// <param name="stuId"></param>
        private void ShowStudentInfo(int stuId)
        {
            FrmStudentInfo fStudent = new FrmStudentInfo();
           fStudent.Tag = stuId;
           fStudent.ReloadList += vModel.ReloadStudentList;//刷新事件注册
           fStudent.MdiParent = this.MdiParent;
            fStudent.Show();//这里不能ShowDialog()
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowStudentInfo(0);
        }
    }
}
