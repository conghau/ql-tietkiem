using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TIETKIEM.Data.DataAccess;
using System.Data.SqlClient;
using TIETKIEM.report;
namespace TIETKIEM
{
    public partial class fm_BC_DSHD_ngay : DevExpress.XtraEditors.XtraForm
    {
        public fm_BC_DSHD_ngay()
        {
            InitializeComponent();
            DataTable all = get_ngay();
            for (int i = 0; i < all.Rows.Count; i++)
            {
                comboBoxEdit1.Properties.Items.Add(all.Rows[i]["Ngay"].ToString());
            }
            //gridView1.GridControl.DataBindings.Add("Text",DataR" //= Data.Business.BBAO_CAO_DSHD_NGAY.SelectAll();
           // gridView1.GridControl.DataSource = Data.Business.BBAO_CAO_DSHD_NGAY.SelectAll();
           // gridView1.databinding
        }
        Xtra_rpt_BC_DSHD_NGAY xtr_DSHD_ngay = new Xtra_rpt_BC_DSHD_NGAY();
        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridView1.GridControl.DataSource = this.dS_DSHD_Ngay1.BAO_CAO_DSHD_NGAY;
         
            xtr_DSHD_ngay.DataSource = get_DSHD_ngay();
            xtr_DSHD_ngay.getBC();
            printControl1.PrintingSystem = xtr_DSHD_ngay.PrintingSystem; 
            xtr_DSHD_ngay.CreateDocument();
        }      
        public DataTable get_ngay()
        {
            DataTable all = SqlHelper.ExecuteData(CommandType.Text,"select ngay from BAO_CAO_DSHD_Ngay group by ngay order by ngay", null);
            return all;
        }
        public DataSet get_DSHD_ngay()
        {   
          
           DataSet ds = new DataSet();
           this.baO_CAO_DSHD_NGAYTableAdapter1.Fill(this.dS_DSHD_Ngay1.BAO_CAO_DSHD_NGAY, Convert.ToDateTime(comboBoxEdit1.Text));    
           return  ds = this.dS_DSHD_Ngay1.BAO_CAO_DSHD_NGAY.DataSet;
           
        }
        public void dataBind()
        {
            //ngay.Container
            
        }
        private void fm_BC_DSHD_ngay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_danh_sach_so_hoat_dong_ngay.BAO_CAO_DSHD_NGAY' table. You can move, or remove it, as needed.
            
        }

     

    }
}