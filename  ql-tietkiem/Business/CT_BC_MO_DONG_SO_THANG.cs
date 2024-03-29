

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using TIETKIEM.Data.Entities;
using TIETKIEM.Data.DataAccess;
using System.Windows.Forms;
 
namespace TIETKIEM.Data.Business
{
    public class BCT_BC_MO_DONG_SO_THANG
    {
//-----------------------------------------------------------//
        public static DataTable SelectAll()
        {
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "CT_BC_MO_DONG_SO_THANG_SelectAll", null);
            return all;
        }
        public static DataTable SelectTop(int Top)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Top", Top);
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "CT_BC_MO_DONG_SO_THANG_SelectTop", pr);
            return all;
        }
//-----------------------------------------------------------//
        public static void Insert(ECT_BC_MO_DONG_SO_THANG OCT_BC_MO_DONG_SO_THANG)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter(@"Ma_BC_Mo_Dong_So", OCT_BC_MO_DONG_SO_THANG.Ma_BC_Mo_Dong_So);
            pr[1] = new SqlParameter(@"Ngay", OCT_BC_MO_DONG_SO_THANG.Ngay);
            pr[2] = new SqlParameter(@"So_So_Mo", OCT_BC_MO_DONG_SO_THANG.So_So_Mo);
            pr[3] = new SqlParameter(@"So_So_Dong", OCT_BC_MO_DONG_SO_THANG.So_So_Dong);
            pr[4] = new SqlParameter(@"Chenh_Lech", OCT_BC_MO_DONG_SO_THANG.Chenh_Lech);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"CT_BC_MO_DONG_SO_THANG_Insert", pr);
        }
//-----------------------------------------------------------//
        public static void Update(ECT_BC_MO_DONG_SO_THANG OCT_BC_MO_DONG_SO_THANG)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter(@"Ma_BC_Mo_Dong_So", OCT_BC_MO_DONG_SO_THANG.Ma_BC_Mo_Dong_So);
            pr[1] = new SqlParameter(@"Ngay", OCT_BC_MO_DONG_SO_THANG.Ngay);
            pr[2] = new SqlParameter(@"So_So_Mo", OCT_BC_MO_DONG_SO_THANG.So_So_Mo);
            pr[3] = new SqlParameter(@"So_So_Dong", OCT_BC_MO_DONG_SO_THANG.So_So_Dong);
            pr[4] = new SqlParameter(@"Chenh_Lech", OCT_BC_MO_DONG_SO_THANG.Chenh_Lech);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"CT_BC_MO_DONG_SO_THANG_Update", pr);
        }
//-----------------------------------------------------------//
        public static void Delete(string Ma_BC_Mo_Dong_So,DateTime Ngay)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter(@"Ma_BC_Mo_Dong_So",Ma_BC_Mo_Dong_So);
            pr[1] = new SqlParameter(@"Ngay",Ngay);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "CT_BC_MO_DONG_SO_THANG_Delete", pr);
        }
//-----------------------------------------------------------//
        public static ECT_BC_MO_DONG_SO_THANG SelectByID(string Ma_BC_Mo_Dong_So,DateTime Ngay)
        {
            ECT_BC_MO_DONG_SO_THANG OCT_BC_MO_DONG_SO_THANG = new ECT_BC_MO_DONG_SO_THANG();
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter(@"Ma_BC_Mo_Dong_So",Ma_BC_Mo_Dong_So);
            pr[1] = new SqlParameter(@"Ngay",Ngay);
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure,"CT_BC_MO_DONG_SO_THANG_SelectByID", pr);
            if (idr.Read())
              OCT_BC_MO_DONG_SO_THANG = GetOneCT_BC_MO_DONG_SO_THANG(idr);
            idr.Close();
            idr.Dispose();
            return OCT_BC_MO_DONG_SO_THANG;
        }
//-----------------------------------------------------------//
        private static ECT_BC_MO_DONG_SO_THANG GetOneCT_BC_MO_DONG_SO_THANG(IDataReader idr)
       {
            ECT_BC_MO_DONG_SO_THANG OCT_BC_MO_DONG_SO_THANG = new ECT_BC_MO_DONG_SO_THANG();
                if (idr["Ma_BC_Mo_Dong_So"] != DBNull.Value)
                    OCT_BC_MO_DONG_SO_THANG.Ma_BC_Mo_Dong_So = (string)idr["Ma_BC_Mo_Dong_So"];
                if (idr["Ngay"] != DBNull.Value)
                    OCT_BC_MO_DONG_SO_THANG.Ngay = (DateTime)idr["Ngay"];
                if (idr["So_So_Mo"] != DBNull.Value)
                    OCT_BC_MO_DONG_SO_THANG.So_So_Mo = (int)idr["So_So_Mo"];
                if (idr["So_So_Dong"] != DBNull.Value)
                    OCT_BC_MO_DONG_SO_THANG.So_So_Dong = (int)idr["So_So_Dong"];
                if (idr["Chenh_Lech"] != DBNull.Value)
                    OCT_BC_MO_DONG_SO_THANG.Chenh_Lech = (int)idr["Chenh_Lech"];
            return OCT_BC_MO_DONG_SO_THANG;
       }
//-----------------------------------------------------------//
        public static DataTable Ma_BC(string Ma_Loai_TK)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Ma_Loai_TK", Ma_Loai_TK);
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "CT_BC_MO_DONG_SO_THANG_Get_Ma_BC_Thang", pr);
            return all;
        }



        public static string GET_MaBC(string Ma_Loai_TK)
        {
            DataTable a = Ma_BC(Ma_Loai_TK);
            return a.Rows[0]["Ma_BC_Mo_Dong_So"].ToString();
        }
//------------------------------------------------------------//






        public static bool Check_MLTK(string Ma_Loai_TK) // kiem tra trong ngày mã loại tk này đã có chưa
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter(@"Ma_Loai_TK",Ma_Loai_TK);         
            pr[1] = new SqlParameter(@"Test",SqlDbType.Bit);
            pr[1].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"CT_BC_MO_DONG_SO_THANG_Check", pr);
            return Convert.ToBoolean(pr[1].Value);
        }
        public static void Update_So_SoMo(string Ma_Loai_TK)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Ma_Loai_TK", Ma_Loai_TK);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "CT_BC_DSHD_NGAY_Update_SO_MO", pr);
        }
        public static void Update_So_SoDong(string Ma_Loai_TK)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Ma_Loai_TK", Ma_Loai_TK);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "CT_BC_DSHD_NGAY_Update_SO_DONG", pr);
        }
//-----------------------------------------------------------//
        public static List<ECT_BC_MO_DONG_SO_THANG> ListAll()
        {
            List<ECT_BC_MO_DONG_SO_THANG> list = new List<ECT_BC_MO_DONG_SO_THANG>();
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "CT_BC_MO_DONG_SO_THANG_SelectAll", null);
            while (idr.Read())
              list.Add(GetOneCT_BC_MO_DONG_SO_THANG(idr));
            if (idr.IsClosed == false)
            {
               idr.Close();
               idr.Dispose();
            }
            return list;
        }

        public static List<ECT_BC_MO_DONG_SO_THANG> ListTop(int Top)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Top", Top);
            List<ECT_BC_MO_DONG_SO_THANG> list = new List<ECT_BC_MO_DONG_SO_THANG>();
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "CT_BC_MO_DONG_SO_THANG_SelectAll", pr);
            while (idr.Read())
              list.Add(GetOneCT_BC_MO_DONG_SO_THANG(idr));
            if (idr.IsClosed == false)
            {
               idr.Close();
               idr.Dispose();
            }
            return list;
        }

        public static void KiemTra_Insert_Or_Update(string MLTK, int choise)// 
        {
            if (Check_MLTK(MLTK) == true)
            {             
                //MessageBox.Show(MLTK + "đã có", "CT_BC");
                if (choise == 1)
                {
                    Update_So_SoMo(MLTK);
                    //MessageBox.Show(" Đã Update Sổ Mở ", "CT_BC");
                }
                if (choise == 2)
                {
                    Update_So_SoDong(MLTK);
                   // MessageBox.Show(" Đã Update Sổ Đóng", "CT_BC");
                }


            }
            else 
            { 
                //MessageBox.Show("CHua có,Bat dau Insert", "CT_BC"); 
                ECT_BC_MO_DONG_SO_THANG Insert_CTBC = new ECT_BC_MO_DONG_SO_THANG();
                Insert_CTBC.Ma_BC_Mo_Dong_So = GET_MaBC(MLTK);
                Insert_CTBC.Ngay = Convert.ToDateTime(DateTime.Today);
                if (choise == 1)
                {
                    Insert_CTBC.So_So_Dong = 0;
                    Insert_CTBC.So_So_Mo = 1;
                    Insert_CTBC.Chenh_Lech = 1;
                    //MessageBox.Show(" insert Sổ Mở ", "CT_BC");
                }
                if (choise == 2)
                {
                    Insert_CTBC.So_So_Dong = 1;
                    Insert_CTBC.So_So_Mo = 0;
                    Insert_CTBC.Chenh_Lech = -1;
                    //MessageBox.Show(" insert_sodong ", "CT_BC");
                }
                Insert(Insert_CTBC);
               // MessageBox.Show("Đã Insert Xong", "CT_BC"); 
 
            }

 
        }
    }
 
}