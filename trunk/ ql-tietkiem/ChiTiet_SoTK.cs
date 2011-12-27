using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TIETKIEM.report;
using TIETKIEM.Data.DataAccess;
using System.Data.SqlClient;
using TIETKIEM.Data.Business;

namespace TIETKIEM
{
    public partial class ChiTiet_SoTK : DevExpress.XtraEditors.XtraForm
    {
        public ChiTiet_SoTK()
        {
            InitializeComponent();
            for (int i = 0; i < Data.Business.BSO_TIET_KIEM.ListAll().Count; i++)
            {
                comboBoxEdit1.Properties.Items.Add(Data.Business.BSO_TIET_KIEM.SelectAll().Rows[i]["Ma_TK"].ToString());
            }
            
           
        }
       
       

        private void printControl1_Load(object sender, EventArgs e)
        {
           
        }

        private void barEditItem1_EditValueChanged(object sender, EventArgs e)
        {

        }

        public string inchu(string value)
        {
            Data.Business.CONTROLLER.Num2Str inchu = new CONTROLLER.Num2Str();
            string chu = inchu.NumberToString(value);
            return chu;
        }


        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable in_so_TK = new DataTable();
            in_so_TK = Data.Business.BSO_TIET_KIEM.In_So_TK(comboBoxEdit1.Text);
            
            gridView1.GridControl.DataSource = in_so_TK;        
            
            Xtra_rpt_Print_SoTK xtr = new Xtra_rpt_Print_SoTK();
           
            xtr.DataSource = in_so_TK;
            xtr.label_Soduhienco.Text = inchu(in_so_TK.Rows[0]["So_Du_Hien_Co"].ToString());
            xtr.label_SoTienGui.Text = inchu(in_so_TK.Rows[0]["Tong_So_Tien_Goi"].ToString());          
            printControl1.PrintingSystem = xtr.PrintingSystem;
            xtr.CreateDocument();
        }
    }
}