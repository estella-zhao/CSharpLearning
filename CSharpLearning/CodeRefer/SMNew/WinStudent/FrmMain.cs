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
using SM.DAL;
using System.Reflection;

namespace WinStudent
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 页面加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //获取菜单数据列表
            MenuDAL menuDAL = new MenuDAL();
            List<MenuInfo> allMenuList=  menuDAL.GetAllMenus();
            //调用递归方法，生成菜单栏
            AddMenuItems(allMenuList, null, 0);
        }

        /// <summary>
        /// 递归加载菜单项     
        /// </summary>
        /// <param name="allList"></param>
        /// <param name="pMenu"></param>
        /// <param name="parentId"></param>
       private void AddMenuItems(List<MenuInfo> allList, ToolStripMenuItem pMenu, int parentId)
        {
            //获取当前parentId父菜单下所有子菜单数据
            var subList = allList.Where(m => m.ParentId == parentId);
            foreach(var child in subList)
            {
                //生成一个ToolStripMenuItem
                ToolStripMenuItem mi = new ToolStripMenuItem();
                mi.Name = child.MenuId.ToString();
                mi.Text = child.MenuName;
                //要作响应的项：有关联页面、IsMorePage=2(特殊处理)
                if(!string.IsNullOrEmpty(child.FrmName)||child.IsMorePage==2)
                {
                    mi.Tag = child;
                    mi.Click += Mi_Click; //Click事件注册
                }
                //添加到谁之下（菜单控件或父菜单项）
                if (pMenu != null)
                    pMenu.DropDownItems.Add(mi);
                else
                {
                    stuMenus.Items.Add(mi);
                }
                //为mi添加它的子菜单列表
                AddMenuItems(allList, mi, child.MenuId);
            }
        }

        /// <summary>
        /// 菜单项响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mi_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            if(menu.Tag!=null)
            {
                MenuInfo miInfo = menu.Tag as MenuInfo;
                if(miInfo.IsMorePage==2)
                {
                    Application.Exit();//退出应用程序
                }
                else
                {
                    //FrmName 不为null
                    string frmFullName = this.GetType().Namespace + "." + miInfo.FrmName;
                    Form frm = null;
                    //Form 的Type 对象
                    Type frmType = Type.GetType(frmFullName);
                    if(frmType!=null)
                    {
                        if(miInfo.IsMorePage==1)//可以打开多个项目
                        {
                            frm = (Form)Activator.CreateInstance(frmType);
                        }
                        else if(miInfo.IsMorePage==0)
                        {
                            MethodInfo method = frmType.GetMethod("CreateForm");
                            if(method!=null)
                            {
                                frm = (Form)method.Invoke(null, null);
                                frm.Activate();
                            }
                        }
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        frm.MdiParent = this;
                        frm.Show();
                    }
                }
            }
        }

        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //在点击Form关闭按钮时，会弹出两次消息询问-----消息循环
            if (MsgBoxHelper.MsgBoxConfirm("退出系统", "你确定要退出吗？") == DialogResult.Yes)
            {
                Application.ExitThread();//避免消息循环  
            }
            else
                e.Cancel = true;
        }
    }
}
