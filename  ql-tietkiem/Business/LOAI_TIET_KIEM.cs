

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using TIETKIEM.Data.Entities;
using TIETKIEM.Data.DataAccess;
 
namespace TIETKIEM.Data.Business
{
    public class BLOAI_TIET_KIEM
    {
        //-----------------------------------------------------------//
        public static DataTable SelectAll()
        {
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "LOAI_TIET_KIEM_SelectAll", null);
            return all;
        }
        public static DataTable SelectTop(int Top)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Top", Top);
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "LOAI_TIET_KIEM_SelectTop", pr);
            return all;
        }
        //-----------------------------------------------------------//
        public static void Insert(ELOAI_TIET_KIEM OLOAI_TIET_KIEM)
        {
            SqlParameter[] pr = new SqlParameter[6];
            pr[0] = new SqlParameter(@"Ma_Loai_TK", OLOAI_TIET_KIEM.Ma_Loai_TK);
            pr[1] = new SqlParameter(@"Ten_Loai_TK", OLOAI_TIET_KIEM.Ten_Loai_TK);
            pr[2] = new SqlParameter(@"Ky_Han", OLOAI_TIET_KIEM.Ky_Han);
            pr[3] = new SqlParameter(@"Lai_Suat", OLOAI_TIET_KIEM.Lai_Suat);
            pr[4] = new SqlParameter(@"So_Ngay_Goi_Toi_Thieu", OLOAI_TIET_KIEM.So_Ngay_Goi_Toi_Thieu);
            pr[5] = new SqlParameter(@"QD_So_Tien_Duoc_Rut", OLOAI_TIET_KIEM.QD_So_Tien_Duoc_Rut);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "LOAI_TIET_KIEM_Insert", pr);
        }
        //-----------------------------------------------------------//
        public static void Update(ELOAI_TIET_KIEM OLOAI_TIET_KIEM)
        {
            SqlParameter[] pr = new SqlParameter[6];
            pr[0] = new SqlParameter(@"Ma_Loai_TK", OLOAI_TIET_KIEM.Ma_Loai_TK);
            pr[1] = new SqlParameter(@"Ten_Loai_TK", OLOAI_TIET_KIEM.Ten_Loai_TK);
            pr[2] = new SqlParameter(@"Ky_Han", OLOAI_TIET_KIEM.Ky_Han);
            pr[3] = new SqlParameter(@"Lai_Suat", OLOAI_TIET_KIEM.Lai_Suat);
            pr[4] = new SqlParameter(@"So_Ngay_Goi_Toi_Thieu", OLOAI_TIET_KIEM.So_Ngay_Goi_Toi_Thieu);
            pr[5] = new SqlParameter(@"QD_So_Tien_Duoc_Rut", OLOAI_TIET_KIEM.QD_So_Tien_Duoc_Rut);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "LOAI_TIET_KIEM_Update", pr);
        }
        //-----------------------------------------------------------//
        public static void Delete(string Ma_Loai_TK)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Ma_Loai_TK", Ma_Loai_TK);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "LOAI_TIET_KIEM_Delete", pr);
        }
        //-----------------------------------------------------------//
        public static ELOAI_TIET_KIEM SelectByID(string Ma_Loai_TK)
        {
            ELOAI_TIET_KIEM OLOAI_TIET_KIEM = new ELOAI_TIET_KIEM();
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Ma_Loai_TK", Ma_Loai_TK);
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "LOAI_TIET_KIEM_SelectByID", pr);
            if (idr.Read())
                OLOAI_TIET_KIEM = GetOneLOAI_TIET_KIEM(idr);
            idr.Close();
            idr.Dispose();
            return OLOAI_TIET_KIEM;
        }
        //-----------------------------------------------------------//
        private static ELOAI_TIET_KIEM GetOneLOAI_TIET_KIEM(IDataReader idr)
        {
            ELOAI_TIET_KIEM OLOAI_TIET_KIEM = new ELOAI_TIET_KIEM();
            if (idr["Ma_Loai_TK"] != DBNull.Value)
                OLOAI_TIET_KIEM.Ma_Loai_TK = (string)idr["Ma_Loai_TK"];
            if (idr["Ten_Loai_TK"] != DBNull.Value)
                OLOAI_TIET_KIEM.Ten_Loai_TK = (string)idr["Ten_Loai_TK"];
            if (idr["Ky_Han"] != DBNull.Value)
                OLOAI_TIET_KIEM.Ky_Han = (int)idr["Ky_Han"];
            if (idr["Lai_Suat"] != DBNull.Value)
                OLOAI_TIET_KIEM.Lai_Suat = (double)idr["Lai_Suat"];
            if (idr["So_Ngay_Goi_Toi_Thieu"] != DBNull.Value)
                OLOAI_TIET_KIEM.So_Ngay_Goi_Toi_Thieu = (int)idr["So_Ngay_Goi_Toi_Thieu"];
            if (idr["QD_So_Tien_Duoc_Rut"] != DBNull.Value)
                OLOAI_TIET_KIEM.QD_So_Tien_Duoc_Rut = (string)idr["QD_So_Tien_Duoc_Rut"];
            return OLOAI_TIET_KIEM;
        }
        //-----------------------------------------------------------//
        public static bool TestByID(string Ma_Loai_TK)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter(@"Ma_Loai_TK", Ma_Loai_TK);
            pr[1] = new SqlParameter(@"TestID", SqlDbType.Bit);
            pr[1].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "LOAI_TIET_KIEM_TestByID", pr);
            return Convert.ToBoolean(pr[1].Value);
        }
        //-----------------------------------------------------------//
        public static List<ELOAI_TIET_KIEM> ListAll()
        {
            List<ELOAI_TIET_KIEM> list = new List<ELOAI_TIET_KIEM>();
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "LOAI_TIET_KIEM_SelectAll", null);
            while (idr.Read())
                list.Add(GetOneLOAI_TIET_KIEM(idr));
            if (idr.IsClosed == false)
            {
                idr.Close();
                idr.Dispose();
            }
            return list;
        }

        public static List<ELOAI_TIET_KIEM> ListTop(int Top)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Top", Top);
            List<ELOAI_TIET_KIEM> list = new List<ELOAI_TIET_KIEM>();
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "LOAI_TIET_KIEM_SelectAll", pr);
            while (idr.Read())
                list.Add(GetOneLOAI_TIET_KIEM(idr));
            if (idr.IsClosed == false)
            {
                idr.Close();
                idr.Dispose();
            }
            return list;
        }
        public static ELOAI_TIET_KIEM SelectByColumn(string Ma_Loai_TK)
        {
            string A = Ma_Loai_TK;
            ELOAI_TIET_KIEM OLOAI_TIET_KIEM = new ELOAI_TIET_KIEM();
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@A, A);
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "LOAI_TIET_KIEM_SelectByID", pr);
            if (idr.Read())
                OLOAI_TIET_KIEM = GetOneLOAI_TIET_KIEM(idr);
            idr.Close();
            idr.Dispose();
            return OLOAI_TIET_KIEM;
        }
        public static DataTable SelectBottom(int Top)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Top", Top);
            DataTable all = SqlHelper.ExecuteData(CommandType.Text, "Select top(@Top) * from LOAI_TIET_KIEM ORDER BY Ma_Loai_TK DESC", pr);
            return all;
        }
        public static String NextID()
        {

            return TIETKIEM.Utilities.NextID(SelectBottom(1).Rows[0]["Ma_Loai_TK"].ToString(), "MLTK");
        }
      
      
    }
 
}