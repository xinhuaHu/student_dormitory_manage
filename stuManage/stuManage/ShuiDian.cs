using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;

namespace stuManage
{
    public partial class ShuiDian : DevExpress.XtraEditors.XtraForm
    {
        public ShuiDian()
        {
            InitializeComponent();
        }

        private stuManage.BLL.Utilities bll = new BLL.Utilities();
        private DataTable baseDataTable;
        string GridViewKeyField = "number";

        private void Utilities_LoadData()
        {
            baseDataTable = bll.GetAllList().Tables[0];
            baseDataTable.Columns["number"].Caption = "编号";

            gridControl.DataSource = baseDataTable;
        }

        private void ShuiDian_Load(object sender, EventArgs e)
        {
            Utilities_LoadData();
        }

        //修改
        EditdShuiDian edit;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            edit = new EditdShuiDian();
            string number;

            DataRow row = gridView.GetFocusedDataRow();
            number = row["number"].ToString();

            edit.number = row["number"].ToString();
            edit.isadd = false;

            if (edit.ShowDialog() == DialogResult.OK)
            {
                Utilities_LoadData();
                GridViewRefresh(number);
            }
        }

        //退出当前窗体
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow row = gridView.GetFocusedDataRow();
                string GridKeyValue;
                if (MessageBox.Show("是否删除?", "提示框", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (row != null)
                    {
                        GridKeyValue = row["flo_num"].ToString();
                    }
                    else
                    {
                        GridKeyValue = "";
                    }

                    bll.Delete(GridKeyValue);
                    MessageBox.Show("删除宿舍'" + GridKeyValue + "'成功", "提示");
                    Utilities_LoadData();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }
    }
}