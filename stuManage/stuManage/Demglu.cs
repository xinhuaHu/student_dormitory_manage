/*
 * 登陆界面
 * **/
using System;
using System.Collections.Generic;
using stuManage.Model;

namespace stuManage
{
    public partial class Demglu : DevExpress.XtraEditors.XtraForm
    {
        public Demglu()
        {
            InitializeComponent();
        }

        private void sBtn_cancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sBtn_queding_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.emp_name = txtName.Text;
            emp.emp_passwd = txtPassed.Text;
            MainFrom mainFrom = new MainFrom();
            mainFrom.Show();
        }
    }
}