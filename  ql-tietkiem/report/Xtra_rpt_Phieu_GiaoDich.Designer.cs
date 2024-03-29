namespace TIETKIEM.report
{
    partial class Xtra_rpt_Phieu_GiaoDich
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xtra_rpt_Phieu_GiaoDich));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.label_SoTienBangChu = new DevExpress.XtraReports.UI.XRLabel();
            this.col_SoCMND = new DevExpress.XtraReports.UI.XRLabel();
            this.col_DiaChi = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.col_TenKhachHang = new DevExpress.XtraReports.UI.XRLabel();
            this.col_SoTien_GD = new DevExpress.XtraReports.UI.XRLabel();
            this.col_MaTK = new DevExpress.XtraReports.UI.XRLabel();
            this.col_DienGiai = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.dS_GiaoDich1 = new TIETKIEM.report.DS_GiaoDich();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.labelTieuDe = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GiaoDich1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6,
            this.xrLabel2,
            this.label_SoTienBangChu,
            this.col_SoCMND,
            this.col_DiaChi,
            this.xrLabel14,
            this.xrLabel13,
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel9,
            this.col_TenKhachHang,
            this.col_SoTien_GD,
            this.col_MaTK,
            this.col_DienGiai});
            this.Detail.HeightF = 261.4584F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // label_SoTienBangChu
            // 
            this.label_SoTienBangChu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_SoTienBangChu.LocationFloat = new DevExpress.Utils.PointFloat(208.3334F, 221.3333F);
            this.label_SoTienBangChu.Name = "label_SoTienBangChu";
            this.label_SoTienBangChu.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label_SoTienBangChu.SizeF = new System.Drawing.SizeF(193.7499F, 23.00002F);
            this.label_SoTienBangChu.StylePriority.UseFont = false;
            this.label_SoTienBangChu.StylePriority.UseTextAlignment = false;
            this.label_SoTienBangChu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // col_SoCMND
            // 
            this.col_SoCMND.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "GIAODICH.So_CMND")});
            this.col_SoCMND.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.col_SoCMND.LocationFloat = new DevExpress.Utils.PointFloat(208.3334F, 124.4166F);
            this.col_SoCMND.Name = "col_SoCMND";
            this.col_SoCMND.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.col_SoCMND.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.col_SoCMND.StylePriority.UseFont = false;
            this.col_SoCMND.StylePriority.UseTextAlignment = false;
            this.col_SoCMND.Text = "col_SoCMND";
            this.col_SoCMND.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // col_DiaChi
            // 
            this.col_DiaChi.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "GIAODICH.Dia_Chi")});
            this.col_DiaChi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.col_DiaChi.LocationFloat = new DevExpress.Utils.PointFloat(208.3334F, 72.91666F);
            this.col_DiaChi.Name = "col_DiaChi";
            this.col_DiaChi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.col_DiaChi.SizeF = new System.Drawing.SizeF(193.7499F, 23.00002F);
            this.col_DiaChi.StylePriority.UseFont = false;
            this.col_DiaChi.StylePriority.UseTextAlignment = false;
            this.col_DiaChi.Text = "col_DiaChi";
            this.col_DiaChi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel14
            // 
            this.xrLabel14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(51.04165F, 221.3333F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(122.9167F, 23F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "Số tiền bằng chữ";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel13
            // 
            this.xrLabel13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(51.04167F, 168.7501F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "Nội dung";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(51.04165F, 124.4166F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Số CMND";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(51.04167F, 72.91666F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Địa chỉ";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(51.04167F, 23.95833F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Người nộp";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // col_TenKhachHang
            // 
            this.col_TenKhachHang.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "GIAODICH.Ten_Khach_Hang")});
            this.col_TenKhachHang.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.col_TenKhachHang.LocationFloat = new DevExpress.Utils.PointFloat(208.3334F, 23.95833F);
            this.col_TenKhachHang.Name = "col_TenKhachHang";
            this.col_TenKhachHang.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.col_TenKhachHang.SizeF = new System.Drawing.SizeF(193.7499F, 23.00002F);
            this.col_TenKhachHang.StylePriority.UseFont = false;
            this.col_TenKhachHang.StylePriority.UseTextAlignment = false;
            this.col_TenKhachHang.Text = "col_TenKhachHang";
            this.col_TenKhachHang.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // col_SoTien_GD
            // 
            this.col_SoTien_GD.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.col_SoTien_GD.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.col_SoTien_GD.BorderWidth = 2;
            this.col_SoTien_GD.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "GIAODICH.So_Tien_GD")});
            this.col_SoTien_GD.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.col_SoTien_GD.ForeColor = System.Drawing.Color.Red;
            this.col_SoTien_GD.LocationFloat = new DevExpress.Utils.PointFloat(448.9583F, 147.4167F);
            this.col_SoTien_GD.Name = "col_SoTien_GD";
            this.col_SoTien_GD.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.col_SoTien_GD.SizeF = new System.Drawing.SizeF(157.2917F, 44.33333F);
            this.col_SoTien_GD.StylePriority.UseBorderColor = false;
            this.col_SoTien_GD.StylePriority.UseBorders = false;
            this.col_SoTien_GD.StylePriority.UseBorderWidth = false;
            this.col_SoTien_GD.StylePriority.UseFont = false;
            this.col_SoTien_GD.StylePriority.UseForeColor = false;
            this.col_SoTien_GD.StylePriority.UseTextAlignment = false;
            this.col_SoTien_GD.Text = "col_SoTien_GD";
            this.col_SoTien_GD.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // col_MaTK
            // 
            this.col_MaTK.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.col_MaTK.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.col_MaTK.BorderWidth = 2;
            this.col_MaTK.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "GIAODICH.Ma_TK")});
            this.col_MaTK.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.col_MaTK.LocationFloat = new DevExpress.Utils.PointFloat(448.9583F, 61.4584F);
            this.col_MaTK.Name = "col_MaTK";
            this.col_MaTK.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.col_MaTK.SizeF = new System.Drawing.SizeF(157.2917F, 47.49998F);
            this.col_MaTK.StylePriority.UseBorderColor = false;
            this.col_MaTK.StylePriority.UseBorders = false;
            this.col_MaTK.StylePriority.UseBorderWidth = false;
            this.col_MaTK.StylePriority.UseFont = false;
            this.col_MaTK.StylePriority.UseTextAlignment = false;
            this.col_MaTK.Text = "col_MaTK";
            this.col_MaTK.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // col_DienGiai
            // 
            this.col_DienGiai.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "GIAODICH.Dien_Giai")});
            this.col_DienGiai.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.col_DienGiai.LocationFloat = new DevExpress.Utils.PointFloat(208.3334F, 168.75F);
            this.col_DienGiai.Name = "col_DienGiai";
            this.col_DienGiai.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.col_DienGiai.SizeF = new System.Drawing.SizeF(193.7499F, 23.00002F);
            this.col_DienGiai.StylePriority.UseFont = false;
            this.col_DienGiai.StylePriority.UseTextAlignment = false;
            this.col_DienGiai.Text = "col_DienGiai";
            this.col_DienGiai.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel5
            // 
            this.xrLabel5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "GIAODICH.Ngay_GD", "{0:dd/MM/yyyy}")});
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(348.9583F, 170.8333F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel5.StylePriority.UseBorderDashStyle = false;
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "xrLabel5";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash;
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "GIAODICH.Ma_So_GD")});
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(348.9583F, 133.3333F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel3.StylePriority.UseBorderDashStyle = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "xrLabel3";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1});
            this.TopMargin.HeightF = 246.25F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 45.83333F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // dS_GiaoDich1
            // 
            this.dS_GiaoDich1.DataSetName = "DS_GiaoDich";
            this.dS_GiaoDich1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.labelTieuDe,
            this.xrLabel5,
            this.xrLabel3,
            this.xrLabel1});
            this.ReportHeader.HeightF = 232.2917F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.BorderColor = System.Drawing.Color.DodgerBlue;
            this.labelTieuDe.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.labelTieuDe.BorderWidth = 3;
            this.labelTieuDe.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTieuDe.ForeColor = System.Drawing.Color.Red;
            this.labelTieuDe.LocationFloat = new DevExpress.Utils.PointFloat(154.1666F, 43.33334F);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.labelTieuDe.SizeF = new System.Drawing.SizeF(348.9583F, 68.12498F);
            this.labelTieuDe.StylePriority.UseBorderColor = false;
            this.labelTieuDe.StylePriority.UseBorders = false;
            this.labelTieuDe.StylePriority.UseBorderWidth = false;
            this.labelTieuDe.StylePriority.UseFont = false;
            this.labelTieuDe.StylePriority.UseForeColor = false;
            this.labelTieuDe.StylePriority.UseTextAlignment = false;
            this.labelTieuDe.Text = "PHIẾU THU";
            this.labelTieuDe.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 127.4583F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(650F, 82.33336F);
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(208.3334F, 133.3333F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(116.6667F, 23.00002F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Mã số giao dịch";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(208.3334F, 170.8333F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(116.6667F, 23.00002F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Ngày giao dịch";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.xrLabel2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrLabel2.BorderWidth = 2;
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(448.9583F, 23.00005F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(157.2917F, 38.45835F);
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseBorderWidth = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Mã tài khoản";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel6
            // 
            this.xrLabel6.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.xrLabel6.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrLabel6.BorderWidth = 2;
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(448.9583F, 108.9583F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(157.2918F, 38.45832F);
            this.xrLabel6.StylePriority.UseBorderColor = false;
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseBorderWidth = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Số tiền giao dịch";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // Xtra_rpt_Phieu_GiaoDich
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.DataMember = "GIAODICH";
            this.DataSource = this.dS_GiaoDich1;
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 246, 46);
            this.Version = "10.2";
            ((System.ComponentModel.ISupportInitialize)(this.dS_GiaoDich1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DS_GiaoDich dS_GiaoDich1;
        //private TIETKIEM.report.DS_GiaoDichTableAdapters.GIAODICH_TableAdapter gIAODICH_TableAdapter;
        private DevExpress.XtraReports.UI.XRLabel col_DienGiai;
        private DevExpress.XtraReports.UI.XRLabel col_TenKhachHang;
        private DevExpress.XtraReports.UI.XRLabel col_SoTien_GD;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel col_MaTK;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel col_SoCMND;
        private DevExpress.XtraReports.UI.XRLabel col_DiaChi;
        public DevExpress.XtraReports.UI.XRLabel label_SoTienBangChu;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        public DevExpress.XtraReports.UI.XRLabel labelTieuDe;
    }
}
