/*
 * 登陆界面
 * **/
using System;
using System.Collections.Generic;
using stuManage.Model;
using System.Windows.Forms;

namespace stuManage
{
    public partial class Demglu : DevExpress.XtraEditors.XtraForm
    {
        public Demglu()
        {
            InitializeComponent();
        }

        private stuManage.BLL.Employee eBll = new BLL.Employee();
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
                
            }
        }
    }
}