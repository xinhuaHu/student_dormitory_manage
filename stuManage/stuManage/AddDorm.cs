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
    public partial class AddDorm : DevExpress.XtraEditors.XtraForm
    {
        public AddDorm()
        {
            InitializeComponent();
        }

        private stuManage.BLL.Dormitory bll = new BLL.Dormitory();
        private DataTable baseDataTable;

        public bool isadd = true;
        public string floNum;

        private void AddDorm_Load(object sender, EventArgs e)
        {
            if (isadd)
            {
                baseDataTable = bll.GetList("1=2").Tables[0];
                baseDataTable.Rows.Add(baseDataTable.NewRow());
            }
            else
            {
                baseDataTable = bll.GetList("flo_num='" + floNum + "'").Tables[0];
                baseDataTable.TableName = "Dormitory";
                //baseDataTable.PrimaryKey = new DataColumn[] { baseDataTable.Columns["flo_num"] };
                //txtFlo.Properties.ReadOnly = true;
            }
            //数据绑定
            txtFlo.DataBindings.Add("EditValue", baseDataTable, "flo_num");
            txtDor.DataBindings.Add("EditValue", baseDataTable, "dor_num");
            txtkezhu.DataBindings.Add("EditValue", baseDataTable, "num_occupants");
            txtYizhu.DataBindings.Add("EditValue", baseDataTable, "live_num");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //增加一条新记录
            Dormitory model = new Dormitory();
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
            MessageBox.Show("添加成功", "提示");
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}