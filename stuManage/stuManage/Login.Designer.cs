namespace stuManage
{
    partial class Login
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
            this.sBtn_queding = new DevExpress.XtraEditors.SimpleButton();
            this.sBtn_cancle = new DevExpress.XtraEditors.SimpleButton();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtPassed = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassed.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sBtn_queding
            // 
            this.sBtn_queding.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sBtn_queding.Appearance.Options.UseFont = true;
            this.sBtn_queding.Location = new System.Drawing.Point(132, 462);
            this.sBtn_queding.Name = "sBtn_queding";
            this.sBtn_queding.Size = new System.Drawing.Size(84, 33);
            this.sBtn_queding.TabIndex = 0;
            this.sBtn_queding.Text = "确定";
            this.sBtn_queding.Click += new System.EventHandler(this.sBtn_queding_Click);
            // 
            // sBtn_cancle
            // 
            this.sBtn_cancle.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sBtn_cancle.Appearance.Options.UseFont = true;
            this.sBtn_cancle.Location = new System.Drawing.Point(262, 462);
            this.sBtn_cancle.Name = "sBtn_cancle";
            this.sBtn_cancle.Size = new System.Drawing.Size(84, 33);
            this.sBtn_cancle.TabIndex = 1;
            this.sBtn_cancle.Text = "取消";
            this.sBtn_cancle.Click += new System.EventHandler(this.sBtn_cancle_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(234, 266);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Size = new System.Drawing.Size(112, 26);
            this.txtName.TabIndex = 2;
            // 
            // txtPassed
            // 
            this.txtPassed.EditValue = "";
            this.txtPassed.Location = new System.Drawing.Point(234, 335);
            this.txtPassed.Name = "txtPassed";
            this.txtPassed.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassed.Properties.Appearance.Options.UseFont = true;
            this.txtPassed.Properties.UseSystemPasswordChar = true;
            this.txtPassed.Size = new System.Drawing.Size(112, 26);
            this.txtPassed.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl1.Location = new System.Drawing.Point(135, 266);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 25);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "用户名:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl2.Location = new System.Drawing.Point(135, 335);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 25);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "密   码:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl3.Location = new System.Drawing.Point(157, 121);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(163, 32);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "欢   迎   登   录";
            // 
            // Login
            // 
            this.Appearance.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 617);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtPassed);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.sBtn_cancle);
            this.Controls.Add(this.sBtn_queding);
            this.Name = "Login";
            this.Text = "登录";
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassed.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sBtn_queding;
        private DevExpress.XtraEditors.SimpleButton sBtn_cancle;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtPassed;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;

    }
}