using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TIETKIEM
{
    public partial class In_DS_KhachHang : DevExpress.XtraEditors.XtraForm
    {
        public In_DS_KhachHang()
        {
            InitializeComponent();

        }

        private void In_DS_KhachHang_Load(object sender, EventArgs e)
        {
            XtraReport_DanhsachKhachHang xtr = new XtraReport_DanhsachKhachHang();
            printControl1.PrintingSystem = xtr.PrintingSystem;
            xtr.CreateDocument();
        }

    }
}