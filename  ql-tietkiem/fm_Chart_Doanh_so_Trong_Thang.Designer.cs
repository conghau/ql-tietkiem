namespace TIETKIEM
{
    partial class fm_Chart_Doanh_so_Trong_Thang
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel3 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.bAO_CAO_DSHD_NGAYTableAdapter = new TIETKIEM.Chart.DS_Chart_Doanh_so_Trong_ThangTableAdapters.BAO_CAO_DSHD_NGAYTableAdapter();
            this.bAOCAODSHDNGAYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Chart_Doanh_so_Trong_Thang1 = new TIETKIEM.Chart.DS_Chart_Doanh_so_Trong_Thang();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.cb_Thang = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cb_Nam = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltongthu1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltongchi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOCAODSHDNGAYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Chart_Doanh_so_Trong_Thang1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Thang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Nam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.DataAdapter = this.bAO_CAO_DSHD_NGAYTableAdapter;
            this.chartControl1.DataSource = this.bAOCAODSHDNGAYBindingSource;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Title.Alignment = System.Drawing.StringAlignment.Far;
            xyDiagram1.AxisX.Title.Text = "Ngày";
            xyDiagram1.AxisX.Title.Visible = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Title.Alignment = System.Drawing.StringAlignment.Far;
            xyDiagram1.AxisY.Title.Text = "Giá trị";
            xyDiagram1.AxisY.Title.Visible = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentDataMember = "Ngay";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            sideBySideBarSeriesLabel1.LineVisible = true;
            series1.Label = sideBySideBarSeriesLabel1;
            series1.Name = "Tổng Thu";
            series1.ValueDataMembersSerializable = "tongthu";
            series2.ArgumentDataMember = "Ngay";
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            sideBySideBarSeriesLabel2.LineVisible = true;
            series2.Label = sideBySideBarSeriesLabel2;
            series2.Name = "Tổng Chi";
            series2.ValueDataMembersSerializable = "tongchi";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            sideBySideBarSeriesLabel3.LineVisible = true;
            this.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel3;
            this.chartControl1.Size = new System.Drawing.Size(855, 363);
            this.chartControl1.TabIndex = 0;
            chartTitle1.Text = "\r\nBiểu đồ thể hiện tổng doanh thu từng ngày trong tháng\r\n";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // bAO_CAO_DSHD_NGAYTableAdapter
            // 
            this.bAO_CAO_DSHD_NGAYTableAdapter.ClearBeforeFill = true;
            // 
            // bAOCAODSHDNGAYBindingSource
            // 
            this.bAOCAODSHDNGAYBindingSource.DataMember = "BAO_CAO_DSHD_NGAY";
            this.bAOCAODSHDNGAYBindingSource.DataSource = this.dS_Chart_Doanh_so_Trong_Thang1;
            // 
            // dS_Chart_Doanh_so_Trong_Thang1
            // 
            this.dS_Chart_Doanh_so_Trong_Thang1.DataSetName = "DS_Chart_Doanh_so_Trong_Thang";
            this.dS_Chart_Doanh_so_Trong_Thang1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.cb_Thang);
            this.splitContainerControl1.Panel1.Controls.Add(this.cb_Nam);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.chartControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(972, 363);
            this.splitContainerControl1.SplitterPosition = 111;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // cb_Thang
            // 
            this.cb_Thang.Location = new System.Drawing.Point(12, 148);
            this.cb_Thang.Name = "cb_Thang";
            this.cb_Thang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_Thang.Size = new System.Drawing.Size(83, 20);
            this.cb_Thang.TabIndex = 1;
            this.cb_Thang.SelectedIndexChanged += new System.EventHandler(this.cb_Thang_SelectedIndexChanged);
            // 
            // cb_Nam
            // 
            this.cb_Nam.Location = new System.Drawing.Point(12, 57);
            this.cb_Nam.Name = "cb_Nam";
            this.cb_Nam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_Nam.Size = new System.Drawing.Size(83, 20);
            this.cb_Nam.TabIndex = 0;
            this.cb_Nam.SelectedIndexChanged += new System.EventHandler(this.cb_Nam_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Location = new System.Drawing.Point(12, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Chọn Năm";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Location = new System.Drawing.Point(12, 123);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Chọn Tháng";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.gridControl2);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.splitContainerControl1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(972, 456);
            this.splitContainerControl2.SplitterPosition = 87;
            this.splitContainerControl2.TabIndex = 2;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.bAOCAODSHDNGAYBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(972, 87);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNgay,
            this.coltongthu1,
            this.coltongchi1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colNgay
            // 
            this.colNgay.Caption = "Ngày";
            this.colNgay.FieldName = "Ngay";
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 0;
            // 
            // coltongthu1
            // 
            this.coltongthu1.Caption = "Tổng Thu";
            this.coltongthu1.FieldName = "tongthu";
            this.coltongthu1.Name = "coltongthu1";
            this.coltongthu1.OptionsColumn.ReadOnly = true;
            this.coltongthu1.Visible = true;
            this.coltongthu1.VisibleIndex = 1;
            // 
            // coltongchi1
            // 
            this.coltongchi1.Caption = "Tổng Chi";
            this.coltongchi1.FieldName = "tongchi";
            this.coltongchi1.Name = "coltongchi1";
            this.coltongchi1.OptionsColumn.ReadOnly = true;
            this.coltongchi1.Visible = true;
            this.coltongchi1.VisibleIndex = 2;
            // 
            // fm_Chart_Doanh_so_Trong_Thang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(972, 456);
            this.Controls.Add(this.splitContainerControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fm_Chart_Doanh_so_Trong_Thang";
            this.Text = "Doanh thu từng ngày trong tháng";
            this.Load += new System.EventHandler(this.fm_Chart_Doanh_so_Trong_Thang_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOCAODSHDNGAYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Chart_Doanh_so_Trong_Thang1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cb_Thang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Nam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private TIETKIEM.Chart.DS_Chart_Doanh_so_Trong_ThangTableAdapters.BAO_CAO_DSHD_NGAYTableAdapter bAO_CAO_DSHD_NGAYTableAdapter;
        private System.Windows.Forms.BindingSource bAOCAODSHDNGAYBindingSource;
        private Chart.DS_Chart_Doanh_so_Trong_Thang dS_Chart_Doanh_so_Trong_Thang1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cb_Nam;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cb_Thang;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn coltongthu1;
        private DevExpress.XtraGrid.Columns.GridColumn coltongchi1;

    }
}