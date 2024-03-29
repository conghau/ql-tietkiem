

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using TIETKIEM.Data.Entities;
using TIETKIEM.Data.DataAccess;
using System.Windows.Forms;
 
namespace TIETKIEM.Data.Business
{
    public class BBAO_CAO_MO_DONG_SO_THANG
    {
//-----------------------------------------------------------//
        public static DataTable SelectAll()
        {
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "BAO_CAO_MO_DONG_SO_THANG_SelectAll", null);
            return all;
        }
        public static DataTable SelectTop(int Top)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Top", Top);
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "BAO_CAO_MO_DONG_SO_THANG_SelectTop", pr);
            return all;
        }
//-----------------------------------------------------------//
        public static void Insert(EBAO_CAO_MO_DONG_SO_THANG OBAO_CAO_MO_DONG_SO_THANG)
        {
            SqlParameter[] pr = new SqlParameter[4];
            pr[0] = new SqlParameter(@"Ma_BC_Mo_Dong_So", OBAO_CAO_MO_DONG_SO_THANG.Ma_BC_Mo_Dong_So);
            pr[1] = new SqlParameter(@"Ma_Loai_TK", OBAO_CAO_MO_DONG_SO_THANG.Ma_Loai_TK);
            pr[2] = new SqlParameter(@"Thang", OBAO_CAO_MO_DONG_SO_THANG.Thang);
            pr[3] = new SqlParameter(@"Nam", OBAO_CAO_MO_DONG_SO_THANG.Nam);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"BAO_CAO_MO_DONG_SO_THANG_Insert", pr);
        }
//-----------------------------------------------------------//
        public static void Update(EBAO_CAO_MO_DONG_SO_THANG OBAO_CAO_MO_DONG_SO_THANG)
        {
            SqlParameter[] pr = new SqlParameter[4];
            pr[0] = new SqlParameter(@"Ma_BC_Mo_Dong_So", OBAO_CAO_MO_DONG_SO_THANG.Ma_BC_Mo_Dong_So);
            pr[1] = new SqlParameter(@"Ma_Loai_TK", OBAO_CAO_MO_DONG_SO_THANG.Ma_Loai_TK);
            pr[2] = new SqlParameter(@"Thang", OBAO_CAO_MO_DONG_SO_THANG.Thang);
            pr[3] = new SqlParameter(@"Nam", OBAO_CAO_MO_DONG_SO_THANG.Nam);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"BAO_CAO_MO_DONG_SO_THANG_Update", pr);
        }
//-----------------------------------------------------------//
        public static void Delete(string Ma_BC_Mo_Dong_So)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Ma_BC_Mo_Dong_So",Ma_BC_Mo_Dong_So);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "BAO_CAO_MO_DONG_SO_THANG_Delete", pr);
        }
//-----------------------------------------------------------//
        public static EBAO_CAO_MO_DONG_SO_THANG SelectByID(string Ma_BC_Mo_Dong_So)
        {
            EBAO_CAO_MO_DONG_SO_THANG OBAO_CAO_MO_DONG_SO_THANG = new EBAO_CAO_MO_DONG_SO_THANG();
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Ma_BC_Mo_Dong_So",Ma_BC_Mo_Dong_So);
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure,"BAO_CAO_MO_DONG_SO_THANG_SelectByID", pr);
            if (idr.Read())
              OBAO_CAO_MO_DONG_SO_THANG = GetOneBAO_CAO_MO_DONG_SO_THANG(idr);
            idr.Close();
            idr.Dispose();
            return OBAO_CAO_MO_DONG_SO_THANG;
        }
//-----------------------------------------------------------//
        private static EBAO_CAO_MO_DONG_SO_THANG GetOneBAO_CAO_MO_DONG_SO_THANG(IDataReader idr)
       {
            EBAO_CAO_MO_DONG_SO_THANG OBAO_CAO_MO_DONG_SO_THANG = new EBAO_CAO_MO_DONG_SO_THANG();
                if (idr["Ma_BC_Mo_Dong_So"] != DBNull.Value)
                    OBAO_CAO_MO_DONG_SO_THANG.Ma_BC_Mo_Dong_So = (string)idr["Ma_BC_Mo_Dong_So"];
                if (idr["Ma_Loai_TK"] != DBNull.Value)
                    OBAO_CAO_MO_DONG_SO_THANG.Ma_Loai_TK = (string)idr["Ma_Loai_TK"];
                if (idr["Thang"] != DBNull.Value)
                    OBAO_CAO_MO_DONG_SO_THANG.Thang = (int)idr["Thang"];
                if (idr["Nam"] != DBNull.Value)
                    OBAO_CAO_MO_DONG_SO_THANG.Nam = (int)idr["Nam"];
            return OBAO_CAO_MO_DONG_SO_THANG;
       }
//-----------------------------------------------------------//
        public static bool TestByID(string Ma_BC_Mo_Dong_So)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter(@"Ma_BC_Mo_Dong_So",Ma_BC_Mo_Dong_So);
            pr[1] = new SqlParameter(@"TestID",SqlDbType.Bit);
            pr[1].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"BAO_CAO_MO_DONG_SO_THANG_TestByID", pr);
            return Convert.ToBoolean(pr[1].Value);
        }
//-----------------------------------------------------------//
        public static List<EBAO_CAO_MO_DONG_SO_THANG> ListAll()
        {
            List<EBAO_CAO_MO_DONG_SO_THANG> list = new List<EBAO_CAO_MO_DONG_SO_THANG>();
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "BAO_CAO_MO_DONG_SO_THANG_SelectAll", null);
            while (idr.Read())
              list.Add(GetOneBAO_CAO_MO_DONG_SO_THANG(idr));
            if (idr.IsClosed == false)
            {
               idr.Close();
               idr.Dispose();
            }
            return list;
        }

        public static List<EBAO_CAO_MO_DONG_SO_THANG> ListTop(int Top)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Top", Top);
            List<EBAO_CAO_MO_DONG_SO_THANG> list = new List<EBAO_CAO_MO_DONG_SO_THANG>();
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "BAO_CAO_MO_DONG_SO_THANG_SelectAll", pr);
            while (idr.Read())
              list.Add(GetOneBAO_CAO_MO_DONG_SO_THANG(idr));
            if (idr.IsClosed == false)
            {
               idr.Close();
               idr.Dispose();
            }
            return list;
        }
        public static DataTable SelectBottom(int Top)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Top", Top);
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "BAO_CAO_MO_DONG_SO_THANG_LastID", pr);
            return all;
        }
        public static String NextID()
        {

            return TIETKIEM.Utilities.NextID(SelectBottom(1).Rows[0]["Ma_BC_Mo_Dong_So"].ToString(), "BCMDS");
        }
        public static bool TestByMLTK(string Ma_Loai_TK)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter(@"Ma_Loai_TK", Ma_Loai_TK);
            pr[1] = new SqlParameter(@"TestID", SqlDbType.Bit);
            pr[1].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "BAO_CAO_MO_DONG_SO_THANG_CheckByMLTK", pr);
            return Convert.ToBoolean(pr[1].Value);
        }
        public static void Insert_BAO_CAO_MO_DONG_SO_THANG(string MLTK)
        {
            if (TestByMLTK(MLTK) == false)// chua MLTK co trong thang ,thi se chèn vào
            {
                EBAO_CAO_MO_DONG_SO_THANG Insert_BC = new EBAO_CAO_MO_DONG_SO_THANG();
                Insert_BC.Ma_BC_Mo_Dong_So = NextID();
                Insert_BC.Thang = DateTime.Now.Month;
                Insert_BC.Nam = DateTime.Now.Year;
                Insert_BC.Ma_Loai_TK = MLTK;
                Insert(Insert_BC);
                //MessageBox.Show("CHèn xong", "BÁO CÁO MỞ ĐÓNG SỔ");
                //MessageBox.Show(NextID()+"|"+ DateTime.Now.Month +"|"+MLTK , "BÁO CÁO MỞ ĐÓNG SỔ");

                
            }
            //else
            //    MessageBox.Show("ĐÃ có", "BÁO CÁO MỞ ĐÓNG SỔ");
        }

    }
 
}