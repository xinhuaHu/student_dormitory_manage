using System;
using System.Data;
using System.Windows.Forms;

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

        private void Stustay_LoadData()
        {
            baseDataTable = bll.GetAllList().Tables[0];
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
            //取得当前的行
            DataRow row = gridView.GetFocusedDataRow();
            stuManage.Model.Stustay model = new stuManage.Model.Stustay();
            if (row != null && gridControl.DataSource != null)
            {
                editStu = new EditStu();
                editStu.txtNum.Text = row["num"].ToString();
                editStu.txtName.Text = row["name"].ToString();
                editStu.txtSex.Text = row["sex"].ToString();
                editStu.Stupro.Text = row["profession"].ToString();
                editStu.txtFlo.Text = row["flo_num"].ToString();
                editStu.txtDor.Text = row["dor_num"].ToString();
                editStu.DateStuTime.Text = row["check_time"].ToString();
                editStu.ShowDialog();
                Stustay_LoadData();
            }
            model.profession = editStu.Stupro.EditValue.ToString();
            model.flo_num = editStu.txtFlo.EditValue.ToString();
            model.dor_num = editStu.txtDor.EditValue.ToString();
            model.check_time = editStu.DateStuTime.DateTime;

            editStu.Stupro.DataBindings.Add("EditValue", baseDataTable, "profession");
            editStu.txtFlo.DataBindings.Add("EditValue", baseDataTable, "flo_num");
            editStu.txtDor.DataBindings.Add("EditValue", baseDataTable, "dor_num");
            editStu.DateStuTime.DataBindings.Add("EditValue", baseDataTable, "check_time");

            bll.Update(model);
            //MessageBox.Show("修改成功", "提示");
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}