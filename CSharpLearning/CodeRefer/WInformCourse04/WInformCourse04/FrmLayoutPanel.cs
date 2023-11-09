using Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformCourse03.DAL;
using WinformCourse04;
using WInformCourse04.DAL;
using WInformCourse04.Models;

namespace WInformCourse04
{
    public partial class FrmLayoutPanel : Form
    {
        public FrmLayoutPanel()
        {
            InitializeComponent();
        }
        GradeDAL gradeDAL = new GradeDAL();
        ClassDAL classDAL = new ClassDAL();
        StudentDAL studentDAL = new StudentDAL();
        StudentListViewModel vm = new StudentListViewModel();
        private void FrmLayoutPanel_Load(object sender, EventArgs e)
        {
            cboSex.SelectedIndex = 0;//选中全部
            //加载TvClasses列表
            LoadTVClassList();
            LoadCboClasses();
            // FindStudentList();
            dgvStudents.DataBindings.Add("DataSource", vm, "StudentList");
        }

        private void LoadCboClasses()
        {
            //下拉框列作为下拉框控件对象
            DataGridViewComboBoxColumn cboCol = dgvStudents.Columns["colClassId"] as DataGridViewComboBoxColumn;
            cboCol.DataSource = classDAL.GetModelList("ClassId,ClassName", "", 0);
            cboCol.DisplayMember = "ClassName";
            cboCol.ValueMember = "ClassId";
        }

        private void FindStudentList()
        {
            int classId = 0;
            if(tvClasses.SelectedNode!=null)
            {
                classId = tvClasses.SelectedNode.Name.GetInt();
            }
            string stuName = txtStuName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string sex = cboSex.SelectedItem.ToString();
            if (sex == "全部") sex = "";
            int isDel = chkDel.Checked ? 1 : 0;
            List<StudentInfo> stuList = studentDAL.GetStudentList(classId, stuName, phone, sex, isDel);
            if(stuList.Count>0)
            {
                panel2.Visible = true;
                dgvStudents.Visible = true;
                dgvStudents.AutoGenerateColumns = false;
                dgvStudents.DataSource = stuList;
                bool blDel = chkDel.Checked;
                dgvStudents.Columns["colEdit"].Visible = !blDel;
                dgvStudents.Columns["colDel"].Visible = !blDel;
                dgvStudents.Columns["colRecover"].Visible = blDel;
                dgvStudents.Columns["colRemove"].Visible = blDel;
                btnAdd.Enabled = !blDel;
                btnDelete.Enabled = !blDel;
                btnRecover.Enabled = blDel;
                btnRemove.Enabled = blDel;
            }
            else
            {
                dgvStudents.Visible = false;
                panel2.Visible = false;
            }
        }

        private void LoadTVClassList()
        {
            //1.手动添加所有班级节点
            TreeNode rootNode = new TreeNode();
            rootNode.Name = "0";
            rootNode.Text = "所有班级";
            tvClasses.Nodes.Add(rootNode);
            //2.添加年级级点
            List<GradeInfo> gradeList = gradeDAL.GetModelList("GradeId,GradeName", "", 0);
            if(gradeList.Count>0)
            {
                foreach(GradeInfo g in gradeList)
                {
                    CreateGradeNode(g, rootNode);
                }
            }
            //3.指定年级下的班级节点
        }

        private void CreateGradeNode(GradeInfo grade, TreeNode pNode)
        {
            TreeNode node = new TreeNode();
            node.Name = grade.GradeId.ToString();
            node.Text = grade.GradeName;
            pNode.Nodes.Add(node);
            List<ClassInfo> classList = classDAL.GetClassList(grade.GradeId);
            if (classList.Count > 0)
            {
                foreach (ClassInfo cInfo in classList)
                {
                    TreeNode cNode = new TreeNode();
                    cNode.Name = cInfo.ClassId.ToString();
                    cNode.Text = cInfo.ClassName;
                    node.Nodes.Add(cNode);
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindStudentList();
        }

       

        private void tvClasses_AfterSelect(object sender, TreeViewEventArgs e)
        {
            FindStudentList();
        }

        private void chkDel_CheckedChanged(object sender, EventArgs e)
        {
            FindStudentList();
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow dr in dgvStudents.Rows)
            {
                DataGridViewCell cell = dr.Cells["colCheck"];
                cell.Value = chkAll.Checked;
            }
        }

        private void dgvStudents_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dgvStudents.IsCurrentCellDirty)//如果单元格未提交
            {
                this.dgvStudents.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        List<int> chkIds = new List<int>();
        /// <summary>
        /// 多选功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStudents_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>-1)
            {
                StudentInfo stu = dgvStudents.Rows[e.RowIndex].DataBoundItem as StudentInfo;
                DataGridViewCell cell = dgvStudents.CurrentCell;//当前单元格
                if(cell is DataGridViewCheckBoxCell)
                {
                    int id = stu.StuId;
                    if(cell.FormattedValue.ToString()=="True")
                    {
                        chkIds.Add(id);
                    }
                    else if(cell.FormattedValue.ToString() == "False")
                    {
                        chkIds.Remove(id);
                    }
                }
            }
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dgvStudents.Rows[e.RowIndex].Cells[e.ColumnIndex];
            //  StudentInfo stu = dgvStudents.Rows[e.RowIndex].DataBoundItem as StudentInfo;
            StudentInfo stu = vm.StudentList[e.RowIndex];
              int id = stu.StuId;
            if (cell.FormattedValue.ToString() == "删除")
            {
                if (MessageBox.Show("您确定要删除吗?", "删除提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)//
                {
                    //删除操作
                    bool bl = studentDAL.Delete(id, 0, 1);
                    if (bl)
                    {
                        MessageBox.Show("删除成功！");
                        //List<StudentInfo> list = dgvStudents.DataSource as List<StudentInfo>;
                        //list.Remove(stu);
                        //dgvStudents.DataSource = null;
                        //dgvStudents.DataSource = list;
                        vm.StudentList.Remove(stu);
                        
                    }
                }
            }
            else if(cell.FormattedValue.ToString() == "修改")
            {
                ShowStudentPage(stu.StuId);
            }
            else if (cell.FormattedValue.ToString() == "恢复")
            {
                //恢复操作
                bool bl = studentDAL.Delete(id, 0, 0);
                if (bl)
                {
                    MessageBox.Show("恢复成功！");
                    List<StudentInfo> list = dgvStudents.DataSource as List<StudentInfo>;
                    list.Remove(stu);
                    dgvStudents.DataSource = null;
                    dgvStudents.DataSource = list;

                }
            }
            else if (cell.FormattedValue.ToString() == "移除")
            {
                //移除操作
                bool bl = studentDAL.Delete(id, 1, 1);
                if (bl)
                {
                    MessageBox.Show("移除成功！");
                    List<StudentInfo> list = dgvStudents.DataSource as List<StudentInfo>;
                    list.Remove(stu);
                    dgvStudents.DataSource = null;
                    dgvStudents.DataSource = list;
                }
            }
        }

        private void ShowStudentPage(int stuId)
        {
            FrmStudent fStudent = new FrmStudent();
            fStudent.Tag = stuId;
            fStudent.ReloadList += vm.ReLoadStudents;
            fStudent.StartPosition = FormStartPosition.CenterScreen;
            fStudent.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowStudentPage(0);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要删除吗?", "删除提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bool bl = studentDAL.DeleteList(chkIds, 0, 1);
                if (bl)
                {
                    MessageBox.Show("删除成功！");
                    FindStudentList();
                    chkIds.Clear();
                }
            }
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要恢复这些信息吗?", "恢复提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bool bl = studentDAL.DeleteList(chkIds, 0, 0);
                if (bl)
                {
                    MessageBox.Show("恢复成功！");
                    FindStudentList();
                    chkIds.Clear();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要移除吗?", "移除提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bool bl = studentDAL.DeleteList(chkIds, 1, 1);
                if (bl)
                {
                    MessageBox.Show("移除成功！");
                    FindStudentList();
                    chkIds.Clear();
                }
            }
        }
    }
}
