using System;
using System.Data;

namespace stuManage
{
    public partial class Check : DevExpress.XtraEditors.XtraForm
    {
        public Check()
        {
            InitializeComponent();
        }

        //private LibraryMis.BLL.manager bll = new LibraryMis.BLL.manager();
        //private Stustay bll = new Stustay();
        private stuManage.BLL.Stustay bll = new BLL.Stustay();
        private DataTable baseDataTable;

        private void Stustay_LoadData()
        {
            baseDataTable = bll.GetAllList().Tables[0];
            gridControl1.DataSource = baseDataTable;
        }

        private void Stustay_Load(object sender, EventArgs e)
        {
            Stustay_LoadData();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //取得当前的行
            DataRow row = gridView1.GetFocusedDataRow();
        }
    }
}