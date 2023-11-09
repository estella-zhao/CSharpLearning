using Common;
using System;
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
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }
        public event Action ReloadList;
        int stuId = 0;
        ClassDAL classDAL = new ClassDAL();
        StudentDAL studentDAL = new StudentDAL();
        string oldName = "";
        string oldPhone = "";
        //绑定源
        //StudentModel stuModel = null;
        private void FrmStudent_Load(object sender, EventArgs e)
        {
            //stuModel = new StudentModel();
            //stuModel.StuName = "Fresh";
            if (this.Tag != null)
            {
                stuId = this.Tag.GetInt();
            }
            LoadCboClasses();
            if (stuId == 0)
            {
                txtName.Clear();
                txtPhone.Clear();
                cboClasses.SelectedIndex = 0;
                rbtnMale.Checked = true;
                txtName.Focus();
            }
            else
            {
                StudentInfo stuInfo = studentDAL.GetById(stuId, "");
                if (stuInfo != null)
                {
                    txtName.Text = stuInfo.StuName;
                    txtPhone.Text = stuInfo.Phone;
                    cboClasses.SelectedValue = stuInfo.ClassId;
                    if (stuInfo.Sex == "男")
                        rbtnMale.Checked = true;
                    else
                        rbtnFemale.Checked = true;
                    oldName = stuInfo.StuName;
                    oldPhone = stuInfo.Phone;
                }
            }


            //txtName.DataBindings.Add("Text", stuModel, "StuName",false,DataSourceUpdateMode.OnPropertyChanged);//数据绑定的方式 呈现信息
            //rbtnMale.DataBindings.Add("Checked", stuModel, "IsMale");
            //rbtnFemale.DataBindings.Add("Checked", stuModel, "IsFemale");
            //txtPhone.DataBindings.Add("Text", stuModel, "Phone");
            //cboClasses.sele
        }

        private void LoadCboClasses()
        {
            //cboClasses.DataBindings.Add("DataSource", stuModel, "ClassList");
            cboClasses.DataSource = classDAL.GetModelList("", "", 0);
            cboClasses.DisplayMember = "ClassName";
            cboClasses.ValueMember = "ClassId";
          //  cboClasses.DataBindings.Add("SelectedValue", stuModel, "ClassId");
      
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //  stuModel.StuName = "探lu者";
            // string name1 = stuModel.StuName;
            string name = txtName.Text.Trim();
            string sex = rbtnMale.Checked ? "男" : "女";
            string phone = txtPhone.Text.Trim();
            int classId = cboClasses.SelectedValue.GetInt();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("请输入学生姓名！", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("请输入学生电话号码！", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }
            if (stuId == 0 || (oldPhone != phone || oldName != name))
            {
                if (studentDAL.ExistStudent(name, phone))
                {
                    MessageBox.Show("该学生信息已存在！", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    return;
                }
            }
            StudentInfo stu = new StudentInfo
            {
                StuId = stuId,
                StuName = name,
                Sex = sex,
                Phone = phone,
                ClassId = classId
            };
            if (stuId > 0)
            {
                bool blUpdate = studentDAL.Update(stu, "");
                if (blUpdate)
                {
                    MessageBox.Show("该学生信息更新成功！");
                    ReloadList?.Invoke();
                }
                else
                {
                    MessageBox.Show("该学生信息更新失败！", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                bool blAdd = studentDAL.Add(stu, "StuName,Sex,Phone,ClassId", 0) > 0;
                if (blAdd)
                {
                    MessageBox.Show("该学生信息新增成功！");
                    ReloadList?.Invoke();
                }
                else
                {
                    MessageBox.Show("该学生信息新增失败！", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
