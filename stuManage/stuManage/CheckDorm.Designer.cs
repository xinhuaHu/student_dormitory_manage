namespace stuManage
{
    partial class CheckDorm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.numc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.namec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sexc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.professionc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.check_timec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flo_numc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dor_numc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCancle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Panel1.Controls.Add(this.gridControl);
            this.splitContainerControl.Panel1.Text = "Panel1";
            this.splitContainerControl.Panel2.Controls.Add(this.btnCancle);
            this.splitContainerControl.Panel2.Controls.Add(this.btnEdit);
            this.splitContainerControl.Panel2.Controls.Add(this.btnDel);
            this.splitContainerControl.Panel2.Text = "Panel2";
            this.splitContainerControl.Size = new System.Drawing.Size(859, 636);
            this.splitContainerControl.SplitterPosition = 676;
            this.splitContainerControl.TabIndex = 0;
            this.splitContainerControl.Text = "splitContainerControl2";
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(676, 636);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.numc,
            this.namec,
            this.sexc,
            this.professionc,
            this.check_timec,
            this.flo_numc,
            this.dor_numc});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            // 
            // numc
            // 
            this.numc.Caption = "学号";
            this.numc.FieldName = "num";
            this.numc.Name = "numc";
            this.numc.Visible = true;
            this.numc.VisibleIndex = 0;
            // 
            // namec
            // 
            this.namec.Caption = "姓名";
            this.namec.FieldName = "name";
            this.namec.Name = "namec";
            this.namec.Visible = true;
            this.namec.VisibleIndex = 1;
            // 
            // sexc
            // 
            this.sexc.Caption = "性别";
            this.sexc.FieldName = "sex";
            this.sexc.Name = "sexc";
            this.sexc.Visible = true;
            this.sexc.VisibleIndex = 2;
            // 
            // professionc
            // 
            this.professionc.Caption = "系部";
            this.professionc.FieldName = "profession";
            this.professionc.Name = "professionc";
            this.professionc.Visible = true;
            this.professionc.VisibleIndex = 3;
            // 
            // check_timec
            // 
            this.check_timec.Caption = "入住时间";
            this.check_timec.FieldName = "check_time";
            this.check_timec.Name = "check_timec";
            this.check_timec.Visible = true;
            this.check_timec.VisibleIndex = 4;
            // 
            // flo_numc
            // 
            this.flo_numc.Caption = "楼号";
            this.flo_numc.FieldName = "flo_num";
            this.flo_numc.Name = "flo_numc";
            this.flo_numc.Visible = true;
            this.flo_numc.VisibleIndex = 5;
            // 
            // dor_numc
            // 
            this.dor_numc.Caption = "宿舍号";
            this.dor_numc.FieldName = "dor_num";
            this.dor_numc.Name = "dor_numc";
            this.dor_numc.Visible = true;
            this.dor_numc.VisibleIndex = 6;
            // 
            // btnCancle
            // 
            this.btnCancle.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Appearance.Options.UseFont = true;
            this.btnCancle.Location = new System.Drawing.Point(52, 376);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 26);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Text = "退    出";
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Location = new System.Drawing.Point(52, 300);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 26);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "修    改";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Appearance.Options.UseFont = true;
            this.btnDel.Location = new System.Drawing.Point(52, 234);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 26);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "删    除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // Check
            // 
            this.ClientSize = new System.Drawing.Size(859, 636);
            this.Controls.Add(this.splitContainerControl);
            this.Name = "Check";
            this.Load += new System.EventHandler(this.Check_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn numc;
        private DevExpress.XtraGrid.Columns.GridColumn namec;
        private DevExpress.XtraGrid.Columns.GridColumn sexc;
        private DevExpress.XtraGrid.Columns.GridColumn professionc;
        private DevExpress.XtraGrid.Columns.GridColumn check_timec;
        private DevExpress.XtraGrid.Columns.GridColumn flo_numc;
        private DevExpress.XtraGrid.Columns.GridColumn dor_numc;
        private DevExpress.XtraEditors.SimpleButton btnCancle;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDel;
    }
}