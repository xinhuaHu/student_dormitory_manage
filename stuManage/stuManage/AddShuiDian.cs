using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using stuManage.Model;

namespace stuManage
{
    public partial class AddShuiDian : DevExpress.XtraEditors.XtraForm
    {
        public AddShuiDian()
        {
            InitializeComponent();
        }

        private stuManage.BLL.Utilities bll = new BLL.Utilities();
        private DataTable baseDataTable;

        public bool isadd = true;
        public string number;

        private void AddShuiDian_Load(object sender, EventArgs e)
        {
            if (isadd)
            {
                baseDataTable = bll.GetList("1=2").Tables[0];
                baseDataTable.Rows.Add(baseDataTable.NewRow());
            }
            else
            {
                baseDataTable = bll.GetList("number='" + number + "'").Tables[0];
                baseDataTable.TableName = "Utilities";
            }
            //数据绑定
            txtNumber.DataBindings.Add("EditValue", baseDataTable, "number");
            txtFlo.DataBindings.Add("EditValue", baseDataTable, "flo_num");
            txtDor.DataBindings.Add("EditValue", baseDataTable, "dor_num");
            txtMonth.DataBindings.Add("EditValue", baseDataTable, "month_");
            txtEle.DataBindings.Add("EditValue", baseDataTable, "electricity");
            txtElF.DataBindings.Add("EditValue", baseDataTable, "ele_fee");
            txtWater.DataBindings.Add("EditValue", baseDataTable, "water");
            txtWatFee.DataBindings.Add("EditValue", baseDataTable, "wat_fee");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //增加一条新记录
            Utilities model = new Utilities();
            model.number = txtNumber.EditValue.ToString();
            model.flo_num = txtFlo.EditValue.ToString();
            model.dor_num = txtDor.EditValue.ToString();
            model.month_ = txtMonth.EditValue.ToString();
            model.electricity = txtEle.EditValue.ToString();
            model.ele_fee = txtElF.EditValue.ToString();
            model.water = txtWater.EditValue.ToString();
            model.wat_fee = txtWatFee.EditValue.ToString();

            if (isadd)
            {
                bll.Add(model);
            }
            else
            {
                bll.Update(model);
            }
            MessageBox.Show("添加成功", "提示");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            txtFlo.Text = "";
            txtDor.Text = "";
            txtEle.Text = "";
            txtElF.Text = "";
            txtWater.Text = "";
            txtWatFee.Text = "";
            txtMonth.Text = "";
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}