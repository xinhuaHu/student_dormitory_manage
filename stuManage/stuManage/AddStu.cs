using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace stuManage
{
    public partial class AddStu : DevExpress.XtraEditors.XtraForm
    {
        public AddStu()
        {
            InitializeComponent();
        }

        private stuManage.BLL.Stustay bll = new stuManage.BLL.Stustay();
        private DataTable baseDataTable;
        public bool isadd = true;
        public string Stu_num;

        private void AddStu_Load(object sender, EventArgs e)
        {
            //增加一条新记录
            if (isadd)
            {
                baseDataTable = bll.GetList("1=2").Tables[0];
                baseDataTable.Rows.Add(baseDataTable.NewRow());
            }
            else
            {
                baseDataTable = bll.GetList("num='" + txtStuNum + "'").Tables[0];
                baseDataTable.TableName = "Stustay";
                baseDataTable.PrimaryKey = new DataColumn[] { baseDataTable.Columns["num"] };

                txtStuNum.Properties.ReadOnly = true;
            }
            //数据绑定
            txtStuNum.DataBindings.Add("EditValue", baseDataTable, "num");
            txtStuname.DataBindings.Add("EditValue", baseDataTable, "name");
            txtStusex.DataBindings.Add("EditValue", baseDataTable, "sex");
            txtStupro.DataBindings.Add("EditValue", baseDataTable, "profession");
            txtStuflo.DataBindings.Add("EditValue", baseDataTable, "flo_num");
            txtStudor.DataBindings.Add("EditValue", baseDataTable, "dor_num");
            DateStuTime.DataBindings.Add("EditValue", baseDataTable, "check_time");
            //获取类型数据
            //dtType = typebll.GetAllList().Tables[0];
            //dtType.Columns["TID"].Caption = "编号";
            //dtType.Columns["type"].Caption = "名称";
            //dtType.Columns["tRemark"].Caption = "备注";

            //this.bindingSource1.DataSource = dtType;
            //lueType.Properties.DataSource = this.bindingSource1;
            //lueType.Properties.DisplayMember = "type";
            //lueType.Properties.ValueMember = "type";
        }

        private void sBtn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sBtn_add_Click(object sender, EventArgs e)
        {
            //增加一条新记录
            stuManage.Model.Stustay model = new stuManage.Model.Stustay();
            model.num = txtStuNum.EditValue.ToString();
            model.name = txtStuname.EditValue.ToString();
            model.sex = txtStusex.EditValue.ToString();
            model.profession = txtStupro.EditValue.ToString();
            model.flo_num = txtStuflo.EditValue.ToString();
            model.dor_num = txtStudor.EditValue.ToString();

            model.check_time = DateStuTime.DateTime;


            if (isadd)
            {
                bll.Add(model);
            }
            else
            {
                bll.Update(model);
            }
        }
    }
}