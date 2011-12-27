namespace TIETKIEM
{
    partial class fm_Doi_Mat_Khau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_Doi_Mat_Khau));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_New_Pass1 = new DevExpress.XtraEditors.TextEdit();
            this.txt_New_Pass = new DevExpress.XtraEditors.TextEdit();
            this.txt_Old_Pass = new DevExpress.XtraEditors.TextEdit();
            this.btcancel = new DevExpress.XtraEditors.SimpleButton();
            this.btenter = new DevExpress.XtraEditors.SimpleButton();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ribbonClientPanel2 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.txt_New_Pass1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_New_Pass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Old_Pass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(143, 93);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mật khẩu cũ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(143, 131);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mật khẩu mới";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(143, 171);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(104, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Nhập lại mật khẩu mới";
            // 
            // txt_New_Pass1
            // 
            this.txt_New_Pass1.Location = new System.Drawing.Point(272, 164);
            this.txt_New_Pass1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_New_Pass1.Name = "txt_New_Pass1";
            this.txt_New_Pass1.Properties.NullValuePrompt = "Nhập mật khẩu mới";
            this.txt_New_Pass1.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_New_Pass1.Properties.PasswordChar = '●';
            this.txt_New_Pass1.Size = new System.Drawing.Size(171, 20);
            this.txt_New_Pass1.TabIndex = 2;
            this.txt_New_Pass1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_New_Pass1_KeyDown);
            // 
            // txt_New_Pass
            // 
            this.txt_New_Pass.Location = new System.Drawing.Point(272, 128);
            this.txt_New_Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_New_Pass.Name = "txt_New_Pass";
            this.txt_New_Pass.Properties.NullValuePrompt = "Nhập mật khẩu mới";
            this.txt_New_Pass.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_New_Pass.Properties.PasswordChar = '●';
            this.txt_New_Pass.Size = new System.Drawing.Size(171, 20);
            this.txt_New_Pass.TabIndex = 1;
            this.txt_New_Pass.ToolTip = "Nhập mật khẩu mới";
            // 
            // txt_Old_Pass
            // 
            this.txt_Old_Pass.EditValue = "";
            this.txt_Old_Pass.Location = new System.Drawing.Point(272, 90);
            this.txt_Old_Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Old_Pass.Name = "txt_Old_Pass";
            this.txt_Old_Pass.Properties.NullText = "Nhập mật khẩu cũ";
            this.txt_Old_Pass.Properties.NullValuePrompt = "Nhập mật khẩu cũ";
            this.txt_Old_Pass.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_Old_Pass.Properties.PasswordChar = '●';
            this.txt_Old_Pass.Size = new System.Drawing.Size(171, 20);
            this.txt_Old_Pass.TabIndex = 0;
            this.txt_Old_Pass.ToolTip = "Nhập mật khẩu cũ";
            this.txt_Old_Pass.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Asterisk;
            this.txt_Old_Pass.ToolTipTitle = "Nhập mật khẩu củ";
            // 
            // btcancel
            // 
            this.btcancel.Image = ((System.Drawing.Image)(resources.GetObject("btcancel.Image")));
            this.btcancel.Location = new System.Drawing.Point(368, 202);
            this.btcancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(76, 37);
            this.btcancel.TabIndex = 5;
            this.btcancel.Text = "Thoát";
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // btenter
            // 
            this.btenter.Image = ((System.Drawing.Image)(resources.GetObject("btenter.Image")));
            this.btenter.Location = new System.Drawing.Point(243, 202);
            this.btenter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btenter.Name = "btenter";
            this.btenter.Size = new System.Drawing.Size(102, 37);
            this.btenter.TabIndex = 4;
            this.btenter.Text = "Hoàn thành";
            this.btenter.Click += new System.EventHandler(this.btenter_Click);
            // 
            // reflectionImage1
            // 
            this.reflectionImage1.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage1.Image")));
            this.reflectionImage1.Location = new System.Drawing.Point(42, 73);
            this.reflectionImage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(95, 145);
            this.reflectionImage1.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelControl4.Location = new System.Drawing.Point(223, 35);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(171, 26);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "ĐỔI MẬT KHẨU";
            // 
            // ribbonClientPanel2
            // 
            this.ribbonClientPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel2.Location = new System.Drawing.Point(195, 73);
            this.ribbonClientPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonClientPanel2.Name = "ribbonClientPanel2";
            this.ribbonClientPanel2.Size = new System.Drawing.Size(225, 2);
            // 
            // 
            // 
            this.ribbonClientPanel2.Style.Class = "RibbonClientPanel";
            this.ribbonClientPanel2.TabIndex = 14;
            this.ribbonClientPanel2.Text = "ribbonClientPanel2";
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.Location = new System.Drawing.Point(155, 65);
            this.ribbonClientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(300, 2);
            // 
            // 
            // 
            this.ribbonClientPanel1.Style.Class = "RibbonClientPanel";
            this.ribbonClientPanel1.TabIndex = 13;
            this.ribbonClientPanel1.Text = "ribbonClientPanel1";
            // 
            // fm_Doi_Mat_Khau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 283);
            this.Controls.Add(this.ribbonClientPanel2);
            this.Controls.Add(this.ribbonClientPanel1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.reflectionImage1);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btenter);
            this.Controls.Add(this.txt_Old_Pass);
            this.Controls.Add(this.txt_New_Pass);
            this.Controls.Add(this.txt_New_Pass1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fm_Doi_Mat_Khau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.txt_New_Pass1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_New_Pass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Old_Pass.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_New_Pass1;
        private DevExpress.XtraEditors.TextEdit txt_New_Pass;
        private DevExpress.XtraEditors.TextEdit txt_Old_Pass;
        private DevExpress.XtraEditors.SimpleButton btcancel;
        private DevExpress.XtraEditors.SimpleButton btenter;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel2;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
    }
}