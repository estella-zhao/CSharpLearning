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
    public partial class FrmClassInfo : Form
    {
        public FrmClassInfo()
        {
            InitializeComponent();
        }
        public event Action ReloadList;//刷新列表页

        ClassInfoViewModel vModel = null;
        private void FrmClassInfo_Load(object sender, EventArgs e)
        {
            if(this.Tag!=null)
            {
                int classId = this.Tag.GetInt();
                vModel = new ClassInfoViewModel(classId);
            }
            else
            {
                vModel = new ClassInfoViewModel(0);
            }
            cbGrades.DisplayMember = "GradeName";
            cbGrades.ValueMember = "GradeId";
            cbGrades.Bind(vModel, "DataSource", "GradeList");
            cbGrades.Bind(vModel, "SelectedValue", "GradeId");
            txtName.BindText(vModel, "ClassName");
            txtRemark.BindText(vModel, "Remark");
            btnAdd.BindText(vModel, "BtnText");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            vModel.CommitClass(ReloadList);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
