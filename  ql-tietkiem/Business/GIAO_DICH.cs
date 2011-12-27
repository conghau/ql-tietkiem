

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using TIETKIEM.Data.Entities;
using TIETKIEM.Data.DataAccess;
 
namespace TIETKIEM.Data.Business
{
    public class BGIAO_DICH
    {
//-----------------------------------------------------------//
        public static DataTable SelectAll()
        {
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "GIAO_DICH_SelectAll", null);
            return all;
        }
        public static DataTable SelectTop(int Top)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Top", Top);
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "GIAO_DICH_SelectTop", pr);
            return all;
        }
//-----------------------------------------------------------//
        public static void Insert(EGIAO_DICH OGIAO_DICH)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter(@"Ma_So_GD", OGIAO_DICH.Ma_So_GD);
            pr[1] = new SqlParameter(@"Ma_Loai_GD", OGIAO_DICH.Ma_Loai_GD);
            pr[2] = new SqlParameter(@"Ma_TK", OGIAO_DICH.Ma_TK);
            pr[3] = new SqlParameter(@"Ngay_GD", OGIAO_DICH.Ngay_GD);
            pr[4] = new SqlParameter(@"So_Tien_GD", OGIAO_DICH.So_Tien_GD);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"GIAO_DICH_Insert", pr);
        }
//-----------------------------------------------------------//
        public static void Update(EGIAO_DICH OGIAO_DICH)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter(@"Ma_So_GD", OGIAO_DICH.Ma_So_GD);
            pr[1] = new SqlParameter(@"Ma_Loai_GD", OGIAO_DICH.Ma_Loai_GD);
            pr[2] = new SqlParameter(@"Ma_TK", OGIAO_DICH.Ma_TK);
            pr[3] = new SqlParameter(@"Ngay_GD", OGIAO_DICH.Ngay_GD);
            pr[4] = new SqlParameter(@"So_Tien_GD", OGIAO_DICH.So_Tien_GD);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"GIAO_DICH_Update", pr);
        }
//-----------------------------------------------------------//
        public static void Delete(string Ma_So_GD)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Ma_So_GD",Ma_So_GD);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "GIAO_DICH_Delete", pr);
        }
//-----------------------------------------------------------//
        public static EGIAO_DICH SelectByID(string Ma_So_GD)
        {
            EGIAO_DICH OGIAO_DICH = new EGIAO_DICH();
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Ma_So_GD",Ma_So_GD);
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure,"GIAO_DICH_SelectByID", pr);
            if (idr.Read())
              OGIAO_DICH = GetOneGIAO_DICH(idr);
            idr.Close();
            idr.Dispose();
            return OGIAO_DICH;
        }
//-----------------------------------------------------------//
        private static EGIAO_DICH GetOneGIAO_DICH(IDataReader idr)
       {
            EGIAO_DICH OGIAO_DICH = new EGIAO_DICH();
                if (idr["Ma_So_GD"] != DBNull.Value)
                    OGIAO_DICH.Ma_So_GD = (string)idr["Ma_So_GD"];
                if (idr["Ma_Loai_GD"] != DBNull.Value)
                    OGIAO_DICH.Ma_Loai_GD = (string)idr["Ma_Loai_GD"];
                if (idr["Ma_TK"] != DBNull.Value)
                    OGIAO_DICH.Ma_TK = (string)idr["Ma_TK"];
                if (idr["Ngay_GD"] != DBNull.Value)
                    OGIAO_DICH.Ngay_GD = (DateTime)idr["Ngay_GD"];
                if (idr["So_Tien_GD"] != DBNull.Value)
                    OGIAO_DICH.So_Tien_GD = (double)idr["So_Tien_GD"];
            return OGIAO_DICH;
       }
//-----------------------------------------------------------//
        public static bool TestByID(string Ma_So_GD)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter(@"Ma_So_GD",Ma_So_GD);
            pr[1] = new SqlParameter(@"TestID",SqlDbType.Bit);
            pr[1].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"GIAO_DICH_TestByID", pr);
            return Convert.ToBoolean(pr[1].Value);
        }
//-----------------------------------------------------------//
        public static List<EGIAO_DICH> ListAll()
        {
            List<EGIAO_DICH> list = new List<EGIAO_DICH>();
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "GIAO_DICH_SelectAll", null);
            while (idr.Read())
              list.Add(GetOneGIAO_DICH(idr));
            if (idr.IsClosed == false)
            {
               idr.Close();
               idr.Dispose();
            }
            return list;
        }
        public static List<EGIAO_DICH> ListTop(int Top)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Top", Top);
            List<EGIAO_DICH> list = new List<EGIAO_DICH>();
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "GIAO_DICH_SelectAll", pr);
            while (idr.Read())
              list.Add(GetOneGIAO_DICH(idr));
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
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "GIAO_DICH_LastID", pr);
            return all;
        }
        public static String NextID()
        {

            return TIETKIEM.Utilities.NextID(SelectBottom(1).Rows[0]["Ma_So_GD"].ToString(), "MSGD");
        }

        public static DataTable In_Phieu_GD()
        {
            
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "GIAO_DICH_InPhieuGD",null);
            return all;

        }
        public static DataTable In_Phieu_GD_As(string ma_tk, DateTime ngay_gd, string mlgd)
        {
            SqlParameter[] pr = new SqlParameter[3];
            pr[0] = new SqlParameter(@"Ma_TK", ma_tk);
            pr[1] = new SqlParameter(@"Ngay_GD", ngay_gd);
            pr[2] = new SqlParameter(@"Ma_Loai_GD", mlgd);
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "GIAO_DICH_InPhieuGD_as", pr);
            return all;
        }
        public static int row_In_Phieu_GD_As(string ma_tk, DateTime ngay_gd, string ma_gd)
        {
            DataTable test = In_Phieu_GD_As(ma_tk, ngay_gd, ma_gd);
            return test.Rows.Count;
        }
        public static DataTable In_Phieu_GD_As_MSGD(string ma_so_GD)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Ma_So_GD", ma_so_GD);
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "GIAO_DICH_InPhieuGD_as_MSGD", pr);
            return all;
        }
    }
 
}