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
    public partial class EditdShuiDian : DevExpress.XtraEditors.XtraForm
    {
        public EditdShuiDian()
        {
            InitializeComponent();
        }

        private stuManage.BLL.Utilities bll = new BLL.Utilities();
        private DataTable baseDataTable;

        public bool isadd = true;
        public string number;

        private void btnOk_Click(object sender, EventArgs e)
        {
            //增加一条新记录
            Utilities model = new Utilities();
            model.number = txtNumber.EditValue.ToString();
            model.flo_num = txtNumber.EditValue.ToString();
            model.dor_num = txtNumber.EditValue.ToString();
            model.number = txtNumber.EditValue.ToString();
            model.electricity = txtNumber.EditValue.ToString();
            model.ele_fee = txtNumber.EditValue.ToString();
            model.water = txtNumber.EditValue.ToString();
            model.wat_fee = txtNumber.EditValue.ToString();

            if (isadd)
            {
                bll.Add(model);
            }
            else
            {
                bll.Update(model);
            }
            MessageBox.Show("成功","提示");
        }

        //清空
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

        private void EditdShuiDian_Load(object sender, EventArgs e)
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
    }
}