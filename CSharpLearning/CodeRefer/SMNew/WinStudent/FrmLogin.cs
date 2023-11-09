using SM.DAL;
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

namespace WinStudent
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        UserInfo userInfo = new UserInfo();
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // txtUName.DataBindings.Add("Text", userInfo, "UserName");
            //txtUPwd.DataBindings.Add("Text", userInfo, "UserPwd");
            txtUName.BindText(userInfo, "UserName");
            txtUPwd.BindText(userInfo, "UserPwd");
            txtUName.Focus();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            //数据源对象，改属性值，看能否更新控件上的显示值???----不能直接更新
            // userInfo.UserName = "lycchun";

            //判断 
            if (string.IsNullOrEmpty(userInfo.UserName))
            {
                MsgBoxHelper.MsgErrorShow("登录系统", "账号不能为空！");
                txtUName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(userInfo.UserPwd))
            {
                MsgBoxHelper.MsgErrorShow("登录系统", "密码不能为空！");
                txtUPwd.Focus();
                return;
            }
            UserDAL userDAL = new UserDAL();
            bool blLogin = userDAL.LoginSystem(userInfo);
            if (blLogin)//登录成功
            {
                FrmMain frmMain = new FrmMain();
                frmMain.WindowState = FormWindowState.Maximized;
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MsgBoxHelper.MsgErrorShow("登录系统", "账号或密码输入有误，请检查！");
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
