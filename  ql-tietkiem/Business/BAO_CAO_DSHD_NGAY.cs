

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using TIETKIEM.Data.Entities;
using TIETKIEM.Data.DataAccess;
using System.Windows.Forms;
 
namespace TIETKIEM.Data.Business
{
    public class BBAO_CAO_DSHD_NGAY
    {
//-----------------------------------------------------------//
        public static DataTable SelectAll()
        {
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "BAO_CAO_DSHD_NGAY_SelectAll", null);
            return all;
        }
        public static DataTable SelectTop(int Top)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Top", Top);
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "BAO_CAO_DSHD_NGAY_SelectTop", pr);
            return all;
        }
//-----------------------------------------------------------//
        public static void Insert(EBAO_CAO_DSHD_NGAY OBAO_CAO_DSHD_NGAY)
        {
            SqlParameter[] pr = new SqlParameter[6];
            pr[0] = new SqlParameter(@"Ma_BC_DSHD", OBAO_CAO_DSHD_NGAY.Ma_BC_DSHD);
            pr[1] = new SqlParameter(@"Ngay", OBAO_CAO_DSHD_NGAY.Ngay);
            pr[2] = new SqlParameter(@"Ma_Loai_TK", OBAO_CAO_DSHD_NGAY.Ma_Loai_TK);
            pr[3] = new SqlParameter(@"Tong_Thu", OBAO_CAO_DSHD_NGAY.Tong_Thu);
            pr[4] = new SqlParameter(@"Tong_Chi", OBAO_CAO_DSHD_NGAY.Tong_Chi);
            pr[5] = new SqlParameter(@"Chenh_Lech", OBAO_CAO_DSHD_NGAY.Chenh_Lech);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"BAO_CAO_DSHD_NGAY_Insert", pr);
        }
//-----------------------------------------------------------//
        public static void Update(EBAO_CAO_DSHD_NGAY OBAO_CAO_DSHD_NGAY)
        {
            SqlParameter[] pr = new SqlParameter[6];
            pr[0] = new SqlParameter(@"Ma_BC_DSHD", OBAO_CAO_DSHD_NGAY.Ma_BC_DSHD);
            pr[1] = new SqlParameter(@"Ngay", OBAO_CAO_DSHD_NGAY.Ngay);
            pr[2] = new SqlParameter(@"Ma_Loai_TK", OBAO_CAO_DSHD_NGAY.Ma_Loai_TK);
            pr[3] = new SqlParameter(@"Tong_Thu", OBAO_CAO_DSHD_NGAY.Tong_Thu);
            pr[4] = new SqlParameter(@"Tong_Chi", OBAO_CAO_DSHD_NGAY.Tong_Chi);
            pr[5] = new SqlParameter(@"Chenh_Lech", OBAO_CAO_DSHD_NGAY.Chenh_Lech);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"BAO_CAO_DSHD_NGAY_Update", pr);
        }
//-----------------------------------------------------------//
        public static void Delete(string Ma_BC_DSHD)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Ma_BC_DSHD",Ma_BC_DSHD);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "BAO_CAO_DSHD_NGAY_Delete", pr);
        }
//-----------------------------------------------------------//
        public static EBAO_CAO_DSHD_NGAY SelectByID(string Ma_BC_DSHD)
        {
            EBAO_CAO_DSHD_NGAY OBAO_CAO_DSHD_NGAY = new EBAO_CAO_DSHD_NGAY();
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Ma_BC_DSHD",Ma_BC_DSHD);
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure,"BAO_CAO_DSHD_NGAY_SelectByID", pr);
            if (idr.Read())
              OBAO_CAO_DSHD_NGAY = GetOneBAO_CAO_DSHD_NGAY(idr);
            idr.Close();
            idr.Dispose();
            return OBAO_CAO_DSHD_NGAY;
        }
//-----------------------------------------------------------//
        private static EBAO_CAO_DSHD_NGAY GetOneBAO_CAO_DSHD_NGAY(IDataReader idr)
       {
            EBAO_CAO_DSHD_NGAY OBAO_CAO_DSHD_NGAY = new EBAO_CAO_DSHD_NGAY();
                if (idr["Ma_BC_DSHD"] != DBNull.Value)
                    OBAO_CAO_DSHD_NGAY.Ma_BC_DSHD = (string)idr["Ma_BC_DSHD"];
                if (idr["Ngay"] != DBNull.Value)
                    OBAO_CAO_DSHD_NGAY.Ngay = (DateTime)idr["Ngay"];
                if (idr["Ma_Loai_TK"] != DBNull.Value)
                    OBAO_CAO_DSHD_NGAY.Ma_Loai_TK = (string)idr["Ma_Loai_TK"];
                if (idr["Tong_Thu"] != DBNull.Value)
                    OBAO_CAO_DSHD_NGAY.Tong_Thu = (double)idr["Tong_Thu"];
                if (idr["Tong_Chi"] != DBNull.Value)
                    OBAO_CAO_DSHD_NGAY.Tong_Chi = (double)idr["Tong_Chi"];
                if (idr["Chenh_Lech"] != DBNull.Value)
                    OBAO_CAO_DSHD_NGAY.Chenh_Lech = (double)idr["Chenh_Lech"];
            return OBAO_CAO_DSHD_NGAY;
       }
//-----------------------------------------------------------//
        public static bool TestByMLTK(string Ma_Loai_TK)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter(@"Ma_Loai_TK", Ma_Loai_TK);
            pr[1] = new SqlParameter(@"TestID",SqlDbType.Bit);
            pr[1].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"BAO_CAO_DSHD_NGAY_CheckByMLTK", pr);
            return Convert.ToBoolean(pr[1].Value);
        }
//-----------------------------------------------------------//
        public static List<EBAO_CAO_DSHD_NGAY> ListAll()
        {
            List<EBAO_CAO_DSHD_NGAY> list = new List<EBAO_CAO_DSHD_NGAY>();
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "BAO_CAO_DSHD_NGAY_SelectAll", null);
            while (idr.Read())
              list.Add(GetOneBAO_CAO_DSHD_NGAY(idr));
            if (idr.IsClosed == false)
            {
               idr.Close();
               idr.Dispose();
            }
            return list;
        }

        public static List<EBAO_CAO_DSHD_NGAY> ListTop(int Top)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Top", Top);
            List<EBAO_CAO_DSHD_NGAY> list = new List<EBAO_CAO_DSHD_NGAY>();
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "BAO_CAO_DSHD_NGAY_SelectAll", pr);
            while (idr.Read())
              list.Add(GetOneBAO_CAO_DSHD_NGAY(idr));
            if (idr.IsClosed == false)
            {
               idr.Close();
               idr.Dispose();
            }
            return list;
        }
        //---------------------------------------------------//
        public static DataTable SelectBottom(int Top)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Top", Top);
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "BAO_CAO_DSHD_NGAY_LastID", pr);
            return all;
        }
        public static String NextID()
        {

            return TIETKIEM.Utilities.NextID(SelectBottom(1).Rows[0]["Ma_BC_DSHD"].ToString(), "BCDS");
        }
        //---------------------------------------------------//
        public static string MaBC(string Ma_Loai_TK)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Ma_Loai_TK", Ma_Loai_TK);
            pr[1].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "BAO_CAO_DSHD_NGAY_Get_Ma_BC_DSHD",pr);
            return pr[1].Value.ToString();
        }
        public static void get_DSHD_Ngay(string Ma_BC,string Ma_Loai_TK, double tongthu,double tongchi)
        {
            EBAO_CAO_DSHD_NGAY get_DSHD_NGAY = new EBAO_CAO_DSHD_NGAY();
            get_DSHD_NGAY.Ma_Loai_TK = Ma_Loai_TK;
            get_DSHD_NGAY.Ngay = DateTime.Today;
            get_DSHD_NGAY.Ma_BC_DSHD = Ma_BC;
            get_DSHD_NGAY.Tong_Thu = tongthu;
          
            
        }
        public static void Kiemtra_Insert_or_Update(string Ma_Loai_TK, string MLGD, double Tong_Thu)
        {
            //string tongthu,
            EBAO_CAO_DSHD_NGAY OBAO_CAO_DSHD_NGAY = new EBAO_CAO_DSHD_NGAY();
            if (TestByMLTK(Ma_Loai_TK) == true) // return Update 
            {
                if (MLGD == "MLGD01")
                {
                    SqlParameter[] pr = new SqlParameter[2];
                    pr[0] = new SqlParameter(@"Ma_Loai_TK", OBAO_CAO_DSHD_NGAY.Ma_Loai_TK = Ma_Loai_TK);
                    pr[1] = new SqlParameter(@"Tong_Thu", OBAO_CAO_DSHD_NGAY.Tong_Thu = Tong_Thu);

                    SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "BAO_CAO_DSHD_NGAY_Update_Tong_Thu", pr);
                   
                }
                else
                {
                    SqlParameter[] pr = new SqlParameter[2];
                    pr[0] = new SqlParameter(@"Ma_Loai_TK", OBAO_CAO_DSHD_NGAY.Ma_Loai_TK = Ma_Loai_TK);
                    pr[1] = new SqlParameter(@"Tong_Chi", OBAO_CAO_DSHD_NGAY.Tong_Chi = Tong_Thu);

                    SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "BAO_CAO_DSHD_NGAY_Update_Tong_Chi", pr);
                    
                }
              

            }
            else // return Insert
            {
                string ID = NextID();
                if (MLGD == "MLGD01")
                {
                    
                    try
                    {
                        
                        OBAO_CAO_DSHD_NGAY.Ma_BC_DSHD = NextID();
                        OBAO_CAO_DSHD_NGAY.Ma_Loai_TK = Ma_Loai_TK;
                        OBAO_CAO_DSHD_NGAY.Ngay = Convert.ToDateTime(DateTime.Today);
                        OBAO_CAO_DSHD_NGAY.Tong_Thu = Tong_Thu;
                        OBAO_CAO_DSHD_NGAY.Tong_Chi = 0;
                        OBAO_CAO_DSHD_NGAY.Chenh_Lech = Tong_Thu;
                        Insert(OBAO_CAO_DSHD_NGAY);
                        //MessageBox.Show( ID.ToString() + "|" + Ma_Loai_TK + "|" + Tong_Thu);
                    }
                    catch { }

                }
                else
                {
                    OBAO_CAO_DSHD_NGAY.Ma_BC_DSHD = NextID();
                    OBAO_CAO_DSHD_NGAY.Ma_Loai_TK = Ma_Loai_TK;
                    OBAO_CAO_DSHD_NGAY.Ngay = Convert.ToDateTime(DateTime.Today);
                    OBAO_CAO_DSHD_NGAY.Tong_Thu = 0;
                    OBAO_CAO_DSHD_NGAY.Tong_Chi = Tong_Thu;
                    OBAO_CAO_DSHD_NGAY.Chenh_Lech = 0 - Tong_Thu;
                    Insert(OBAO_CAO_DSHD_NGAY);
                    //MessageBox.Show(ID.ToString() + "|" + Ma_Loai_TK + "|" + - Tong_Thu);
                }


            }


        }       



              
        
        
    }
 
}