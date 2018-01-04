namespace stuManage
{
    partial class AddStu
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
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Stupro = new DevExpress.XtraEditors.ComboBoxEdit();
            this.DateStuTime = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtStudor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtStuflo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtStuname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtStuNum = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sBtn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.sBtn_add = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.Stusex = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stupro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateStuTime.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateStuTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStuflo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStuname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStuNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stusex.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(860, 541);
            this.splitContainerControl1.SplitterPosition = 421;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.btnClear);
            this.splitContainerControl2.Panel2.Controls.Add(this.sBtn_Cancel);
            this.splitContainerControl2.Panel2.Controls.Add(this.sBtn_add);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(860, 541);
            this.splitContainerControl2.SplitterPosition = 421;
            this.splitContainerControl2.TabIndex = 1;
            this.splitContainerControl2.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.Stusex);
            this.groupControl1.Controls.Add(this.Stupro);
            this.groupControl1.Controls.Add(this.DateStuTime);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtStudor);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtStuflo);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtStuname);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtStuNum);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(23, 45);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(812, 330);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "添 加 学 生";
            // 
            // Stupro
            // 
            this.Stupro.Location = new System.Drawing.Point(200, 172);
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
            this.Stupro.TabIndex = 42;
            // 
            // DateStuTime
            // 
            this.DateStuTime.EditValue = null;
            this.DateStuTime.Location = new System.Drawing.Point(200, 261);
            this.DateStuTime.Name = "DateStuTime";
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
            this.labelControl7.Location = new System.Drawing.Point(126, 261);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(60, 20);
            this.labelControl7.TabIndex = 40;
            this.labelControl7.Text = "入住时间";
            // 
            // txtStudor
            // 
            this.txtStudor.Location = new System.Drawing.Point(653, 170);
            this.txtStudor.Name = "txtStudor";
            this.txtStudor.Size = new System.Drawing.Size(100, 24);
            this.txtStudor.TabIndex = 39;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(579, 172);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 20);
            this.labelControl4.TabIndex = 38;
            this.labelControl4.Text = "宿舍号";
            // 
            // txtStuflo
            // 
            this.txtStuflo.Location = new System.Drawing.Point(417, 170);
            this.txtStuflo.Name = "txtStuflo";
            this.txtStuflo.Size = new System.Drawing.Size(100, 24);
            this.txtStuflo.TabIndex = 37;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(343, 172);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 20);
            this.labelControl5.TabIndex = 36;
            this.labelControl5.Text = "楼号";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(126, 172);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(30, 20);
            this.labelControl6.TabIndex = 34;
            this.labelControl6.Text = "系部";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(579, 85);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 20);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "性别";
            // 
            // txtStuname
            // 
            this.txtStuname.Location = new System.Drawing.Point(417, 83);
            this.txtStuname.Name = "txtStuname";
            this.txtStuname.Size = new System.Drawing.Size(100, 24);
            this.txtStuname.TabIndex = 31;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(343, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 20);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "姓名";
            // 
            // txtStuNum
            // 
            this.txtStuNum.Location = new System.Drawing.Point(200, 83);
            this.txtStuNum.Name = "txtStuNum";
            this.txtStuNum.Size = new System.Drawing.Size(100, 24);
            this.txtStuNum.TabIndex = 29;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(126, 85);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 20);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "学号";
            // 
            // sBtn_Cancel
            // 
            this.sBtn_Cancel.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sBtn_Cancel.Appearance.Options.UseFont = true;
            this.sBtn_Cancel.Location = new System.Drawing.Point(517, 33);
            this.sBtn_Cancel.Name = "sBtn_Cancel";
            this.sBtn_Cancel.Size = new System.Drawing.Size(75, 32);
            this.sBtn_Cancel.TabIndex = 45;
            this.sBtn_Cancel.Text = "取    消";
            this.sBtn_Cancel.Click += new System.EventHandler(this.sBtn_Cancel_Click);
            // 
            // sBtn_add
            // 
            this.sBtn_add.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sBtn_add.Appearance.Options.UseFont = true;
            this.sBtn_add.Location = new System.Drawing.Point(214, 33);
            this.sBtn_add.Name = "sBtn_add";
            this.sBtn_add.Size = new System.Drawing.Size(75, 32);
            this.sBtn_add.TabIndex = 44;
            this.sBtn_add.Text = "添    加";
            this.sBtn_add.Click += new System.EventHandler(this.sBtn_add_Click);
            // 
            // btnClear
            // 
            this.btnClear.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Location = new System.Drawing.Point(375, 33);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 32);
            this.btnClear.TabIndex = 46;
            this.btnClear.Text = "清    空";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Stusex
            // 
            this.Stusex.Location = new System.Drawing.Point(653, 83);
            this.Stusex.Name = "Stusex";
            this.Stusex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Stusex.Properties.Items.AddRange(new object[] {
            "男",
            "女"});
            this.Stusex.Size = new System.Drawing.Size(100, 24);
            this.Stusex.TabIndex = 43;
            // 
            // AddStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 541);
            this.Controls.Add(this.splitContainerControl2);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "AddStu";
            this.Text = "AddStu";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stupro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateStuTime.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateStuTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStuflo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStuname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStuNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stusex.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtStudor;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtStuflo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtStuname;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtStuNum;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton sBtn_Cancel;
        private DevExpress.XtraEditors.SimpleButton sBtn_add;
        private DevExpress.XtraEditors.DateEdit DateStuTime;
        private DevExpress.XtraEditors.ComboBoxEdit Stupro;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.ComboBoxEdit Stusex;
    }
}