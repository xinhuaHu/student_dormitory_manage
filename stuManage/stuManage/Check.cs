/*
 * 查看学生
 * **/
using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;

namespace stuManage
{
    public partial class Check : DevExpress.XtraEditors.XtraForm
    {
        public Check()
        {
            InitializeComponent();
        }

        private stuManage.BLL.Stustay bll = new BLL.Stustay();
        private DataTable baseDataTable;

        string GridViewKeyField = "num";

        private void Stustay_LoadData()
        {
            baseDataTable = bll.GetAllList().Tables[0];
            baseDataTable.Columns["num"].Caption = "学号";

            gridControl.DataSource = baseDataTable;
        }

        private void Check_Load(object sender, EventArgs e)
        {
            Stustay_LoadData();
        }

        /*
         *删除学生
         * **/
        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                //取得当前的行
                DataRow row = gridView.GetFocusedDataRow();
                string GridKeyValue;

                if (MessageBox.Show("是否删除用户?", "提示框", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (row != null)
                    {
                        GridKeyValue = row["num"].ToString();
                    }
                    else
                    {
                        GridKeyValue = "";
                    }
                    bll.Delete(GridKeyValue);
                    MessageBox.Show("删除用户'" + GridKeyValue + "'成功", "提示");
                    Stustay_LoadData();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }

        /*
         * 修改
         * **/
        EditStu editStu;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            editStu = new EditStu();
            string num;

            DataRow row = gridView.GetFocusedDataRow();
            num = row["num"].ToString();

            editStu.num = row["num"].ToString();
            editStu.isadd = false;

            if (editStu.ShowDialog() == DialogResult.OK)
            {
                Stustay_LoadData();
                GridViewRefresh(num);
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void GridViewRefresh(string keyValue)
        {

            GridColumn column = gridView.Columns[GridViewKeyField];
            if (column != null)
            {

                if (!string.IsNullOrEmpty(keyValue))
                {
                    int locate = gridView.LocateByValue(0, column, keyValue);
                    if (locate == GridControl.InvalidRowHandle)
                    {
                        gridView.MoveLast();
                    }
                    else
                    {
                        gridView.FocusedRowHandle = locate;
                    }
                }
            }
        }
    }
}