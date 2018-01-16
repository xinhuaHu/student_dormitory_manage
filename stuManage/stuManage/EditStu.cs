/*
 * 学生修改
 * **/
using System;
using System.Data;
using stuManage.Model;
using System.Windows.Forms;

namespace stuManage
{
    public partial class EditStu : DevExpress.XtraEditors.XtraForm
    {
        public EditStu()
        {
            InitializeComponent();
        }

        private stuManage.BLL.Stustay bll = new BLL.Stustay();
        private DataTable baseDataTable;

        public bool isadd = true;
        public string num;

        private void EditStu_Load(object sender, EventArgs e)
        {
            if (isadd)
            {
                baseDataTable = bll.GetList("1=2").Tables[0];
                baseDataTable.Rows.Add(baseDataTable.NewRow());
            }
            else {
                baseDataTable = bll.GetList("num='" + num + "'").Tables[0];
                baseDataTable.TableName = "Stustay";
            }
            //数据绑定
            txtNum.DataBindings.Add("EditValue", baseDataTable, "num");
            txtName.DataBindings.Add("EditValue", baseDataTable, "name");
            txtSex.DataBindings.Add("EditValue", baseDataTable, "sex");
            Stupro.DataBindings.Add("EditValue", baseDataTable, "profession");
            txtFlo.DataBindings.Add("EditValue", baseDataTable, "flo_num");
            txtDor.DataBindings.Add("EditValue", baseDataTable, "dor_num");
            DateStuTime.DataBindings.Add("EditValue", baseDataTable, "check_time");
        }

        private void sBtn_Ok_Click(object sender, EventArgs e)
        {
            Stustay model = new Stustay();//model
            model.num = txtNum.EditValue.ToString();
            model.name = txtName.EditValue.ToString();
            model.sex = txtSex.EditValue.ToString();
            model.profession = Stupro.EditValue.ToString();
            model.flo_num = txtFlo.EditValue.ToString();
            model.dor_num = txtDor.EditValue.ToString();
            model.check_time = DateStuTime.DateTime;

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

        private void sBtn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}