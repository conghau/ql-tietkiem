namespace TIETKIEM
{
    partial class fmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmLogin));
            this.Pass = new DevExpress.XtraEditors.LabelControl();
            this.account = new DevExpress.XtraEditors.LabelControl();
            this.txt_TaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.txt_MatKhau = new DevExpress.XtraEditors.TextEdit();
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.ribbonClientPanel2 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btcancel = new DevExpress.XtraEditors.SimpleButton();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.btenter = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatKhau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(133, 117);
            this.Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(44, 13);
            this.Pass.TabIndex = 0;
            this.Pass.Text = "Mật khẩu";
            // 
            // account
            // 
            this.account.Location = new System.Drawing.Point(133, 75);
            this.account.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(46, 13);
            this.account.TabIndex = 0;
            this.account.Text = "Tài khoản";
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.EditValue = "Gõ tên đăng nhập";
            this.txt_TaiKhoan.Location = new System.Drawing.Point(209, 72);
            this.txt_TaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Properties.NullValuePrompt = "Gõ tên đăng nhập";
            this.txt_TaiKhoan.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_TaiKhoan.Size = new System.Drawing.Size(171, 20);
            this.txt_TaiKhoan.TabIndex = 0;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(209, 112);
            this.txt_MatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Properties.NullValuePrompt = "Nhập mật khẩu";
            this.txt_MatKhau.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_MatKhau.Properties.PasswordChar = '●';
            this.txt_MatKhau.Size = new System.Drawing.Size(171, 20);
            this.txt_MatKhau.TabIndex = 1;
            this.txt_MatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox2_KeyDown);
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.Location = new System.Drawing.Point(93, 39);
            this.ribbonClientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(300, 2);
            // 
            // 
            // 
            this.ribbonClientPanel1.Style.Class = "RibbonClientPanel";
            this.ribbonClientPanel1.TabIndex = 6;
            this.ribbonClientPanel1.Text = "ribbonClientPanel1";
            // 
            // ribbonClientPanel2
            // 
            this.ribbonClientPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel2.Location = new System.Drawing.Point(133, 47);
            this.ribbonClientPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonClientPanel2.Name = "ribbonClientPanel2";
            this.ribbonClientPanel2.Size = new System.Drawing.Size(225, 2);
            // 
            // 
            // 
            this.ribbonClientPanel2.Style.Class = "RibbonClientPanel";
            this.ribbonClientPanel2.TabIndex = 7;
            this.ribbonClientPanel2.Text = "ribbonClientPanel2";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Location = new System.Drawing.Point(155, 7);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(163, 31);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "ĐĂNG  NHẬP";
            // 
            // btcancel
            // 
            this.btcancel.Image = ((System.Drawing.Image)(resources.GetObject("btcancel.Image")));
            this.btcancel.Location = new System.Drawing.Point(316, 157);
            this.btcancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(76, 37);
            this.btcancel.TabIndex = 3;
            this.btcancel.Text = "Thoát";
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // reflectionImage1
            // 
            this.reflectionImage1.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage1.Image")));
            this.reflectionImage1.Location = new System.Drawing.Point(34, 47);
            this.reflectionImage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(85, 137);
            this.reflectionImage1.TabIndex = 4;
            // 
            // btenter
            // 
            this.btenter.Image = ((System.Drawing.Image)(resources.GetObject("btenter.Image")));
            this.btenter.Location = new System.Drawing.Point(209, 157);
            this.btenter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btenter.Name = "btenter";
            this.btenter.Size = new System.Drawing.Size(102, 37);
            this.btenter.TabIndex = 2;
            this.btenter.Text = "Đăng Nhập";
            this.btenter.Click += new System.EventHandler(this.btenter_Click);
            // 
            // fmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 210);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.ribbonClientPanel2);
            this.Controls.Add(this.ribbonClientPanel1);
            this.Controls.Add(this.reflectionImage1);
            this.Controls.Add(this.btenter);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_TaiKhoan);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.account);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Money Twins";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.fmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_TaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatKhau.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl Pass;
        private DevExpress.XtraEditors.LabelControl account;
        private DevExpress.XtraEditors.TextEdit txt_MatKhau;
        private DevExpress.XtraEditors.SimpleButton btenter;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel2;
        private DevExpress.XtraEditors.SimpleButton btcancel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit txt_TaiKhoan;

    }
}