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
    public partial class EditStu : DevExpress.XtraEditors.XtraForm
    {
        public EditStu()
        {
            InitializeComponent();
        }

        private void sBtn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}