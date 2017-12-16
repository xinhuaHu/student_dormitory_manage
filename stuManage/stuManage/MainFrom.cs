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
            InitGrid();

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
        BindingList<Person> gridDataList = new BindingList<Person>();
        void InitGrid()
        {
            //gridDataList.Add(new Person("John", "Smith"));
            //gridDataList.Add(new Person("Gabriel", "Smith"));
            //gridDataList.Add(new Person("Ashley", "Smith", "some comment"));
            //gridDataList.Add(new Person("Adrian", "Smith", "some comment"));
            //gridDataList.Add(new Person("Gabriella", "Smith", "some comment"));
        }
        /// <summary>
        /// 添加学生
        /// </summary>
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
        /// <summary>
        /// 删除学生
        /// </summary>
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
        /// <summary>
        /// 修改学生
        /// </summary>
        EditStu editStu;
        private void EditStu_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            editStu = new EditStu();
            for (int x = 0; x < this.MdiChildren.Length; x++)
            {
                Form tempChild = (Form)this.MdiChildren[x];
                tempChild.Close();
            }
            editStu.MdiParent = this;
            editStu.WindowState = FormWindowState.Maximized;
            editStu.Show();
        }

        /// <summary>
        /// 宿舍查询
        /// </summary>
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
    }
}