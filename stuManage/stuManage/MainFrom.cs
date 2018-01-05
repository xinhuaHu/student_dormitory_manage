/*
 * 主窗体
 * **/
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using System;

namespace stuManage
{
    public partial class MainFrom : RibbonForm
    {
        public MainFrom()
        {
            InitializeComponent();
            InitSkinGallery();

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
        BindingList<Person> gridDataList = new BindingList<Person>();


        //添加学生
        AddStu addstu;
        private void addStu_ItemClick(object sender, ItemClickEventArgs e)
        {
            addstu = new AddStu();
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                Form tempChild = (Form)this.MdiChildren[x];
                tempChild.Close();
            }
            addstu.MdiParent = this;
            addstu.WindowState = FormWindowState.Maximized;
            addstu.Show();
        }

        //删除学生
        DelStu delStu;
        private void DelStu_ItemClick(object sender, ItemClickEventArgs e)
        {
            delStu = new DelStu();
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                Form tempChild = (Form)this.MdiChildren[x];
                tempChild.Close();
            }
            delStu.MdiParent = this;
            delStu.WindowState = FormWindowState.Maximized;
            delStu.Show();
        }

        //宿舍查询
        Dorm drom;
        private void Dorm_ItemClick(object sender, ItemClickEventArgs e)
        {
            drom = new Dorm();
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                Form tempChild = (Form)this.MdiChildren[x];
                tempChild.Close();
            }
            drom.MdiParent = this;
            drom.WindowState = FormWindowState.Maximized;
            drom.Show();
        }

        // 查看学生
        Check check;
        private void Check_ItemClick(object sender, ItemClickEventArgs e)
        {
            check = new Check();
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                Form tempChild = (Form)this.MdiChildren[x];
                tempChild.Close();
            }
            check.MdiParent = this;
            check.WindowState = FormWindowState.Maximized;
            check.Show();
        }

        //宿舍添加
        AddDorm addDorm;
        private void DormAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            addDorm = new AddDorm();
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                Form tempChild = (Form)this.MdiChildren[x];
                tempChild.Close();
            }
            addDorm.MdiParent = this;
            addDorm.WindowState = FormWindowState.Maximized;
            addDorm.Show();
        }

        //水电查询
        ShuiDian shuiDian;
        private void ShuiDian_ItemClick(object sender, ItemClickEventArgs e)
        {
            shuiDian = new ShuiDian();
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                Form tempChild = (Form)this.MdiChildren[x];
                tempChild.Close();
            }
            shuiDian.MdiParent = this;
            shuiDian.WindowState = FormWindowState.Maximized;
            shuiDian.Show();
        }
    }
}