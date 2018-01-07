namespace stuManage
{
    partial class AddDorm
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtnumber = new DevExpress.XtraEditors.TextEdit();
            this.txtFlo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtYizhu = new DevExpress.XtraEditors.TextEdit();
            this.txtkezhu = new DevExpress.XtraEditors.TextEdit();
            this.txtDor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancle = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFlo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYizhu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkezhu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDor.Properties)).BeginInit();
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
            this.splitContainerControl1.Panel2.Controls.Add(this.btnClear);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnCancle);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnAdd);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(419, 458);
            this.splitContainerControl1.SplitterPosition = 358;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtnumber);
            this.groupControl1.Controls.Add(this.txtFlo);
            this.groupControl1.Controls.Add(this.txtYizhu);
            this.groupControl1.Controls.Add(this.txtkezhu);
            this.groupControl1.Controls.Add(this.txtDor);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(419, 358);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "添    加";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(106, 81);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 20);
            this.labelControl3.TabIndex = 55;
            this.labelControl3.Text = "编        号";
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(213, 79);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumber.Properties.Appearance.Options.UseFont = true;
            this.txtnumber.Size = new System.Drawing.Size(100, 26);
            this.txtnumber.TabIndex = 54;
            // 
            // txtFlo
            // 
            this.txtFlo.Location = new System.Drawing.Point(213, 124);
            this.txtFlo.Name = "txtFlo";
            this.txtFlo.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlo.Properties.Appearance.Options.UseFont = true;
            this.txtFlo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFlo.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.txtFlo.Size = new System.Drawing.Size(100, 26);
            this.txtFlo.TabIndex = 59;
            // 
            // txtYizhu
            // 
            this.txtYizhu.Location = new System.Drawing.Point(213, 260);
            this.txtYizhu.Name = "txtYizhu";
            this.txtYizhu.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYizhu.Properties.Appearance.Options.UseFont = true;
            this.txtYizhu.Size = new System.Drawing.Size(100, 26);
            this.txtYizhu.TabIndex = 58;
            // 
            // txtkezhu
            // 
            this.txtkezhu.Location = new System.Drawing.Point(213, 213);
            this.txtkezhu.Name = "txtkezhu";
            this.txtkezhu.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkezhu.Properties.Appearance.Options.UseFont = true;
            this.txtkezhu.Size = new System.Drawing.Size(100, 26);
            this.txtkezhu.TabIndex = 57;
            // 
            // txtDor
            // 
            this.txtDor.Location = new System.Drawing.Point(213, 165);
            this.txtDor.Name = "txtDor";
            this.txtDor.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDor.Properties.Appearance.Options.UseFont = true;
            this.txtDor.Size = new System.Drawing.Size(100, 26);
            this.txtDor.TabIndex = 56;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(105, 262);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 20);
            this.labelControl1.TabIndex = 55;
            this.labelControl1.Text = "已住人数";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(106, 215);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 20);
            this.labelControl2.TabIndex = 54;
            this.labelControl2.Text = "可住人数";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(105, 167);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 20);
            this.labelControl4.TabIndex = 53;
            this.labelControl4.Text = "宿  舍  号";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(105, 126);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(62, 20);
            this.labelControl5.TabIndex = 52;
            this.labelControl5.Text = "楼        号";
            // 
            // btnClear
            // 
            this.btnClear.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Location = new System.Drawing.Point(176, 33);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 28);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "清      除";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Appearance.Options.UseFont = true;
            this.btnCancle.Location = new System.Drawing.Point(282, 33);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 28);
            this.btnCancle.TabIndex = 3;
            this.btnCancle.Text = "退    出";
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(61, 33);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "确    定";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddDorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 458);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "AddDorm";
            this.Text = "AddDorm";
            this.Load += new System.EventHandler(this.AddDorm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFlo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYizhu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkezhu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDor.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit txtFlo;
        private DevExpress.XtraEditors.TextEdit txtYizhu;
        private DevExpress.XtraEditors.TextEdit txtkezhu;
        private DevExpress.XtraEditors.TextEdit txtDor;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnCancle;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtnumber;
        private DevExpress.XtraEditors.SimpleButton btnClear;
    }
}