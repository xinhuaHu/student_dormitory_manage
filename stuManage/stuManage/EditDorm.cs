/*
 * 宿舍修改
 * **/
using System;
using System.Data;
using System.Windows.Forms;
using stuManage.Model;

namespace stuManage
{
    public partial class EditDorm : DevExpress.XtraEditors.XtraForm
    {
        public EditDorm()
        {
            InitializeComponent();
        }

        private stuManage.BLL.Dormitory bll = new BLL.Dormitory();
        private DataTable baseDataTable;

        public bool isadd = true;
        public string number;

        private void EditDorm_Load(object sender, EventArgs e)
        {
            if (isadd)
            {
                baseDataTable = bll.GetList("1=2").Tables[0];
                baseDataTable.Rows.Add(baseDataTable.NewRow());
            }
            else
            {
                baseDataTable = bll.GetList("number='" + number + "'").Tables[0];
                baseDataTable.TableName = "Dormitory";
                //baseDataTable.PrimaryKey = new DataColumn[] { baseDataTable.Columns["flo_num"] };
            }
            //数据绑定
            txtnumber.DataBindings.Add("EditValue", baseDataTable, "number");
            txtFlo.DataBindings.Add("EditValue", baseDataTable, "flo_num");
            txtDor.DataBindings.Add("EditValue", baseDataTable, "dor_num");
            txtkezhu.DataBindings.Add("EditValue", baseDataTable, "num_occupants");
            txtYizhu.DataBindings.Add("EditValue", baseDataTable, "live_num");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //增加一条新记录
            Dormitory model = new Dormitory();
            model.number = txtnumber.EditValue.ToString();
            model.flo_num = txtFlo.EditValue.ToString();
            model.dor_num = txtDor.EditValue.ToString();
            model.num_occupants = txtkezhu.EditValue.ToString();
            model.live_num = txtYizhu.EditValue.ToString();

            if (isadd)
            {
                bll.Add(model);
            }
            else
            {
                bll.Update(model);
            }
            MessageBox.Show("修改成功", "提示");
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}