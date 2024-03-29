

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using TIETKIEM.Data.Entities;
using TIETKIEM.Data.DataAccess;
 
namespace TIETKIEM.Data.Business
{
    public class BSO_TIET_KIEM
    {
//-----------------------------------------------------------//
        public static DataTable SelectAll()
        {
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "SO_TIET_KIEM_SelectAll", null);
            return all;
        }
        public static DataTable SelectTop(int Top)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Top", Top);
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "SO_TIET_KIEM_SelectTop", pr);
            return all;
        }
  //----------------------------------------------------------//      
        public static DataTable SelectBottom(int Top)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Top", Top);
            DataTable all = SqlHelper.ExecuteData(CommandType.Text, "Select top(@Top) * from SO_TIET_KIEM ORDER BY Ma_TK DESC", pr);
            return all;
        }
        public static String NextID()
        {

            return TIETKIEM.Utilities.NextID(SelectBottom(1).Rows[0]["Ma_TK"].ToString(), "TK");
        }

//-----------------------------------------------------------//
        public static void Insert(ESO_TIET_KIEM OSO_TIET_KIEM)
        {

            SqlParameter[] pr = new SqlParameter[12];
            pr[0] = new SqlParameter(@"Ma_TK", OSO_TIET_KIEM.Ma_TK);
            pr[1] = new SqlParameter(@"Ma_KH", OSO_TIET_KIEM.Ma_KH);
            pr[2] = new SqlParameter(@"Ngay_Mo_So", OSO_TIET_KIEM.Ngay_Mo_So);
            pr[3] = new SqlParameter(@"Tong_So_Tien_Goi", OSO_TIET_KIEM.Tong_So_Tien_Goi);
            pr[4] = new SqlParameter(@"Ma_Loai_TK", OSO_TIET_KIEM.Ma_Loai_TK);
            pr[5] = new SqlParameter(@"So_Du_Hien_Co", OSO_TIET_KIEM.So_Du_Hien_Co);
            pr[6] = new SqlParameter(@"Tong_So_Tien_Rut", OSO_TIET_KIEM.Tong_So_Tien_Rut);
            pr[7] = new SqlParameter(@"Ngay_Tinh_Lai_Gan_Nhat", OSO_TIET_KIEM.Ngay_Tinh_Lai_Gan_Nhat);
            pr[8] = new SqlParameter(@"Ngay_Dao_Han_Ke_Tiep", OSO_TIET_KIEM.Ngay_Dao_Han_Ke_Tiep);
            pr[9] = new SqlParameter(@"Tien_Lai_Phat_Sinh", OSO_TIET_KIEM.Tien_Lai_Phat_Sinh);
            pr[10] = new SqlParameter(@"Ngay_Dong_So", OSO_TIET_KIEM.Ngay_Dong_So);
            pr[11] = new SqlParameter(@"Trang_Thai_So", OSO_TIET_KIEM.Trang_Thai_So);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"SO_TIET_KIEM_Insert", pr);
        }
//-----------------------------------------------------------//
        public static void Update(ESO_TIET_KIEM OSO_TIET_KIEM)
        {
           
            SqlParameter[] pr = new SqlParameter[12];
            pr[0] = new SqlParameter(@"Ma_TK", OSO_TIET_KIEM.Ma_TK);
            pr[1] = new SqlParameter(@"Ma_KH", OSO_TIET_KIEM.Ma_KH);
            pr[2] = new SqlParameter(@"Ngay_Mo_So", OSO_TIET_KIEM.Ngay_Mo_So);
            pr[3] = new SqlParameter(@"Tong_So_Tien_Goi", OSO_TIET_KIEM.Tong_So_Tien_Goi);
            pr[4] = new SqlParameter(@"Ma_Loai_TK", OSO_TIET_KIEM.Ma_Loai_TK);
            pr[5] = new SqlParameter(@"So_Du_Hien_Co", OSO_TIET_KIEM.So_Du_Hien_Co);
            pr[6] = new SqlParameter(@"Tong_So_Tien_Rut", OSO_TIET_KIEM.Tong_So_Tien_Rut);
            pr[7] = new SqlParameter(@"Ngay_Tinh_Lai_Gan_Nhat", OSO_TIET_KIEM.Ngay_Tinh_Lai_Gan_Nhat);
            pr[8] = new SqlParameter(@"Ngay_Dao_Han_Ke_Tiep", OSO_TIET_KIEM.Ngay_Dao_Han_Ke_Tiep);
            pr[9] = new SqlParameter(@"Tien_Lai_Phat_Sinh", OSO_TIET_KIEM.Tien_Lai_Phat_Sinh);
            pr[10] = new SqlParameter(@"Ngay_Dong_So", OSO_TIET_KIEM.Ngay_Dong_So);
            pr[11] = new SqlParameter(@"Trang_Thai_So", OSO_TIET_KIEM.Trang_Thai_So);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"SO_TIET_KIEM_Update", pr);
        }
//-----------------------------------------------------------//
        public static void Delete(string Ma_TK)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Ma_TK",Ma_TK);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "SO_TIET_KIEM_Delete", pr);
        }
//-----------------------------------------------------------//
        public static ESO_TIET_KIEM SelectByID(string Ma_TK)
        {
            ESO_TIET_KIEM OSO_TIET_KIEM = new ESO_TIET_KIEM();
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Ma_TK",Ma_TK);
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure,"SO_TIET_KIEM_SelectByID", pr);
            if (idr.Read())
              OSO_TIET_KIEM = GetOneSO_TIET_KIEM(idr);
            idr.Close();
            idr.Dispose();
            return OSO_TIET_KIEM;
        }
//-----------------------------------------------------------//
        private static ESO_TIET_KIEM GetOneSO_TIET_KIEM(IDataReader idr)
       {
           ESO_TIET_KIEM OSO_TIET_KIEM = new ESO_TIET_KIEM();
           if (idr["Ma_TK"] != DBNull.Value)
               OSO_TIET_KIEM.Ma_TK = (string)idr["Ma_TK"];
           if (idr["Ma_KH"] != DBNull.Value)
               OSO_TIET_KIEM.Ma_KH = (string)idr["Ma_KH"];
           if (idr["Ngay_Mo_So"] != DBNull.Value)
               OSO_TIET_KIEM.Ngay_Mo_So = (DateTime)idr["Ngay_Mo_So"];
           if (idr["Tong_So_Tien_Goi"] != DBNull.Value)
               OSO_TIET_KIEM.Tong_So_Tien_Goi = (double)idr["Tong_So_Tien_Goi"];
           if (idr["Ma_Loai_TK"] != DBNull.Value)
               OSO_TIET_KIEM.Ma_Loai_TK = (string)idr["Ma_Loai_TK"];
           if (idr["So_Du_Hien_Co"] != DBNull.Value)
               OSO_TIET_KIEM.So_Du_Hien_Co = (double)idr["So_Du_Hien_Co"];
           if (idr["Tong_So_Tien_Rut"] != DBNull.Value)
               OSO_TIET_KIEM.Tong_So_Tien_Rut = (double)idr["Tong_So_Tien_Rut"];
           if (idr["Ngay_Tinh_Lai_Gan_Nhat"] != DBNull.Value)
               OSO_TIET_KIEM.Ngay_Tinh_Lai_Gan_Nhat = (DateTime)idr["Ngay_Tinh_Lai_Gan_Nhat"];
           if (idr["Ngay_Dao_Han_Ke_Tiep"] != DBNull.Value)
               OSO_TIET_KIEM.Ngay_Dao_Han_Ke_Tiep = (DateTime)idr["Ngay_Dao_Han_Ke_Tiep"];
           if (idr["Tien_Lai_Phat_Sinh"] != DBNull.Value)
               OSO_TIET_KIEM.Tien_Lai_Phat_Sinh = (double)idr["Tien_Lai_Phat_Sinh"];
           if (idr["Ngay_Dong_So"] != DBNull.Value)
               OSO_TIET_KIEM.Ngay_Dong_So = (string)idr["Ngay_Dong_So"];
           if (idr["Trang_Thai_So"] != DBNull.Value)
               OSO_TIET_KIEM.Trang_Thai_So = (bool)idr["Trang_Thai_So"];
            return OSO_TIET_KIEM;
       }
//-----------------------------------------------------------//
        public static bool TestByID(string Ma_TK)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter(@"Ma_TK",Ma_TK);
            pr[1] = new SqlParameter(@"TestID",SqlDbType.Bit);
            pr[1].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"SO_TIET_KIEM_TestByID", pr);
            return Convert.ToBoolean(pr[1].Value);
        }
//-----------------------------------------------------------//

        public static List<ESO_TIET_KIEM> ListAll()
        {
            List<ESO_TIET_KIEM> list = new List<ESO_TIET_KIEM>();
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "SO_TIET_KIEM_SelectAll", null);
            while (idr.Read())
                list.Add(GetOneSO_TIET_KIEM(idr));
            if (idr.IsClosed == false)
            {
                idr.Close();
                idr.Dispose();
            }
            return list;
        }

        public static List<ESO_TIET_KIEM> ListTop(int Top)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Top", Top);
            List<ESO_TIET_KIEM> list = new List<ESO_TIET_KIEM>();
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "SO_TIET_KIEM_SelectAll", pr);
            while (idr.Read())
              list.Add(GetOneSO_TIET_KIEM(idr));
            if (idr.IsClosed == false)
            {
               idr.Close();
               idr.Dispose();
            }
            return list;
        }

        public static DataTable In_So_TK(string @Ma_TK)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Ma_TK", Ma_TK);
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "In_So_TK", pr);
            return all;
        }
    }
 
}