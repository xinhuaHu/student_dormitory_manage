/*
 * 宿舍添加
 * **/
using System;
using System.Data;
using System.Windows.Forms;
using stuManage.Model;

namespace stuManage
{
    public partial class AddDorm : DevExpress.XtraEditors.XtraForm
    {
        public AddDorm()
        {
            InitializeComponent();
        }

        private stuManage.BLL.Dormitory bll = new BLL.Dormitory();
        private DataTable baseDataTable;

        public bool isadd = true;
        public string number;

        private void AddDorm_Load(object sender, EventArgs e)
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
                baseDataTable.PrimaryKey = new DataColumn[] { baseDataTable.Columns["number"] };
                //txtFlo.Properties.ReadOnly = true;
            }
            //数据绑定
            txtnumber.DataBindings.Add("EditValue", baseDataTable, "number");
            txtFlo.DataBindings.Add("EditValue", baseDataTable, "flo_num");
            txtDor.DataBindings.Add("EditValue", baseDataTable, "dor_num");
            txtkezhu.DataBindings.Add("EditValue", baseDataTable, "num_occupants");
            txtYizhu.DataBindings.Add("EditValue", baseDataTable, "live_num");
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
            MessageBox.Show("添加宿舍成功", "提示");
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtnumber.Text = "";
            txtFlo.Text = "";
            txtDor.Text = "";
            txtkezhu.Text = "";
            txtYizhu.Text = "";
        }

    }
}