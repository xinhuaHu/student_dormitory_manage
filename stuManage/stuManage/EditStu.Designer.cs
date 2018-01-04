namespace stuManage
{
    partial class EditStu
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Stupro = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.DateStuTime = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtDor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtFlo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtSex = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNum = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sBtn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.sBtn_Ok = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stupro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateStuTime.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateStuTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFlo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.sBtn_Cancel);
            this.splitContainerControl1.Panel2.Controls.Add(this.sBtn_Ok);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(862, 497);
            this.splitContainerControl1.SplitterPosition = 372;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.Stupro);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.DateStuTime);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtDor);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtFlo);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtSex);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtNum);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(862, 372);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "修   改";
            // 
            // Stupro
            // 
            this.Stupro.Location = new System.Drawing.Point(179, 161);
            this.Stupro.Name = "Stupro";
            this.Stupro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Stupro.Properties.Items.AddRange(new object[] {
            "信息工程系",
            "应用外语系",
            "机电工程系",
            "艺术设计系",
            "经济管理系",
            "轻化工程系",
            "纺织系",
            "服装系"});
            this.Stupro.Size = new System.Drawing.Size(100, 24);
            this.Stupro.TabIndex = 44;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(105, 161);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(30, 20);
            this.labelControl8.TabIndex = 43;
            this.labelControl8.Text = "系部";
            // 
            // DateStuTime
            // 
            this.DateStuTime.EditValue = null;
            this.DateStuTime.Location = new System.Drawing.Point(179, 254);
            this.DateStuTime.Name = "DateStuTime";
            this.DateStuTime.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateStuTime.Properties.Appearance.Options.UseFont = true;
            this.DateStuTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateStuTime.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DateStuTime.Size = new System.Drawing.Size(100, 24);
            this.DateStuTime.TabIndex = 41;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(105, 254);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(60, 20);
            this.labelControl7.TabIndex = 40;
            this.labelControl7.Text = "入住时间";
            // 
            // txtDor
            // 
            this.txtDor.Location = new System.Drawing.Point(632, 163);
            this.txtDor.Name = "txtDor";
            this.txtDor.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDor.Properties.Appearance.Options.UseFont = true;
            this.txtDor.Size = new System.Drawing.Size(100, 26);
            this.txtDor.TabIndex = 39;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(558, 165);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 20);
            this.labelControl4.TabIndex = 38;
            this.labelControl4.Text = "宿舍号";
            // 
            // txtFlo
            // 
            this.txtFlo.Location = new System.Drawing.Point(396, 163);
            this.txtFlo.Name = "txtFlo";
            this.txtFlo.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlo.Properties.Appearance.Options.UseFont = true;
            this.txtFlo.Size = new System.Drawing.Size(100, 26);
            this.txtFlo.TabIndex = 37;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(322, 165);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 20);
            this.labelControl5.TabIndex = 36;
            this.labelControl5.Text = "楼号";
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(632, 76);
            this.txtSex.Name = "txtSex";
            this.txtSex.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.Properties.Appearance.Options.UseFont = true;
            this.txtSex.Properties.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(100, 26);
            this.txtSex.TabIndex = 33;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(558, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 20);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "性别";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(396, 76);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Properties.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 31;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(322, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 20);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "姓名";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(179, 76);
            this.txtNum.Name = "txtNum";
            this.txtNum.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Properties.Appearance.Options.UseFont = true;
            this.txtNum.Properties.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(100, 26);
            this.txtNum.TabIndex = 29;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(105, 78);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 20);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "学号";
            // 
            // sBtn_Cancel
            // 
            this.sBtn_Cancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sBtn_Cancel.Appearance.Options.UseFont = true;
            this.sBtn_Cancel.Location = new System.Drawing.Point(495, 39);
            this.sBtn_Cancel.Name = "sBtn_Cancel";
            this.sBtn_Cancel.Size = new System.Drawing.Size(75, 32);
            this.sBtn_Cancel.TabIndex = 43;
            this.sBtn_Cancel.Text = "取   消";
            this.sBtn_Cancel.Click += new System.EventHandler(this.sBtn_Cancel_Click);
            // 
            // sBtn_Ok
            // 
            this.sBtn_Ok.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sBtn_Ok.Appearance.Options.UseFont = true;
            this.sBtn_Ok.Location = new System.Drawing.Point(290, 39);
            this.sBtn_Ok.Name = "sBtn_Ok";
            this.sBtn_Ok.Size = new System.Drawing.Size(75, 32);
            this.sBtn_Ok.TabIndex = 42;
            this.sBtn_Ok.Text = "修   改";
            // 
            // EditStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 497);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "EditStu";
            this.Text = "EditSt";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stupro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateStuTime.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateStuTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFlo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        public DevExpress.XtraEditors.DateEdit DateStuTime;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        public DevExpress.XtraEditors.TextEdit txtDor;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.TextEdit txtFlo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        public DevExpress.XtraEditors.TextEdit txtSex;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.TextEdit txtNum;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton sBtn_Cancel;
        public DevExpress.XtraEditors.ComboBoxEdit Stupro;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton sBtn_Ok;
    }
}