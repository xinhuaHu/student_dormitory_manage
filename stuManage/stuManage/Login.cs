/*
 * 登陆界面
 * **/
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace stuManage
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        stuManage.BLL.Employee eBll = new BLL.Employee();
        private void sBtn_cancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sBtn_queding_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Trim() == "" || txtPassed.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名和密码", "提示");
            }
            else
            {
                stuManage.Model.Employee employee = eBll.GetModel(txtName.Text.Trim(), txtPassed.Text.Trim());
                if (null != employee)
                {
                    this.Visible = false;
                    MainFrom main = new MainFrom();
                    main.ShowDialog();
                }
                else
                    MessageBox.Show("用户名或密码错误", "警告");
            }
        }
    }
}