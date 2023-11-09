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
using WinStudent.ViewModels;

namespace WinStudent
{
    public partial class FrmStudentInfo : Form
    {
        public FrmStudentInfo()
        {
            InitializeComponent();
        }

        public event Action ReloadList;//刷新列表事件
        StudentInfoViewModel vModel = null;
        private void FrmStudentInfo_Load(object sender, EventArgs e)
        {
            if(this.Tag!=null)
            {
                int stuId = this.Tag.GetInt();
                vModel = new StudentInfoViewModel(stuId);
            }
            else
            {
                vModel = new StudentInfoViewModel(0);
            }
            //绑定控件属性
            cbClasses.DisplayMember = "ClassName";
            cbClasses.ValueMember = "ClassId";
            cbClasses.Bind(vModel, "DataSource", "ClassList");
            cbClasses.Bind(vModel, "SelectedValue", "ClassId");
            txtName.BindText(vModel, "StuName");
            txtPhone.BindText(vModel, "Phone");
            rbMale.Bind(vModel, "Checked", "IsMale");
            rbFemale.Bind(vModel, "Checked", "IsFemale");
            btnAdd.BindText(vModel, "BtnText");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            vModel.CommitStudentInfo(ReloadList);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
