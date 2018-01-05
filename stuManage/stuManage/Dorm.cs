using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;

namespace stuManage
{
    public partial class Dorm : Form
    {
        public Dorm()
        {
            InitializeComponent();
        }

        //private stuManage.BLL.Stustay bll = new BLL.Stustay();

        private stuManage.BLL.Dormitory bll = new BLL.Dormitory();
        private DataTable baseDataTable;
        string GridViewKeyField = "flo_num";

        private void Dormitory_LoadData()
        {
            baseDataTable = bll.GetAllList().Tables[0];
            baseDataTable.Columns["flo_num"].Caption = "楼号";

            gridControl.DataSource = baseDataTable;
        }

        private void Dorm_Load(object sender, EventArgs e)
        {
            Dormitory_LoadData();
        }

        /*
         * 宿舍修改
         * **/
        EditDorm editDorm;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            editDorm = new EditDorm();
            string number;

            DataRow row = gridView.GetFocusedDataRow();
            number = row["number"].ToString();
            
            editDorm.number = row["number"].ToString();
            editDorm.isadd = false;

            if (editDorm.ShowDialog() == DialogResult.OK)
            {
                Dormitory_LoadData();
                GridViewRefresh(number);
            }
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

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                //取得当前的行
                DataRow row = gridView.GetFocusedDataRow();
                string GridKeyValue;

                if (MessageBox.Show("是否删除宿舍?", "提示框", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (row != null)
                    {
                        GridKeyValue = row["flo_num"].ToString();
                    }
                    else
                    {
                        GridKeyValue = "";
                    }
                    //bll.Delete(GridKeyValue);
                    bll.Delete(GridKeyValue);
                    MessageBox.Show("删除宿舍'" + GridKeyValue + "'成功", "提示");
                    Dormitory_LoadData();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }
    }
}
