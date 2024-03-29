

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using TIETKIEM.Data.Entities;
using TIETKIEM.Data.DataAccess;
using TIETKIEM;
 
namespace TIETKIEM.Data.Business
{
    public class BKHACH_HANG
    {
        //-----------------------------------------------------------//
        public static DataTable SelectAll()
        {
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "KHACH_HANG_SelectAll", null);
            return all;
        }
        public static DataTable SelectTop(int Top)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Top", Top);
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "KHACH_HANG_SelectTop", pr);
            return all;
        }
        //-----------------------------------------------------------//
        public static void Insert(EKHACH_HANG OKHACH_HANG)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter(@"Ma_KH", OKHACH_HANG.Ma_KH);
            pr[1] = new SqlParameter(@"Ten_Khach_Hang", OKHACH_HANG.Ten_Khach_Hang);
            pr[2] = new SqlParameter(@"So_CMND", OKHACH_HANG.So_CMND);
            pr[3] = new SqlParameter(@"So_Dien_Thoai", OKHACH_HANG.So_Dien_Thoai);
            pr[4] = new SqlParameter(@"Dia_Chi", OKHACH_HANG.Dia_Chi);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "KHACH_HANG_Insert", pr);
        }
        //-----------------------------------------------------------//
        public static void Update(EKHACH_HANG OKHACH_HANG)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter(@"Ma_KH", OKHACH_HANG.Ma_KH);
            pr[1] = new SqlParameter(@"Ten_Khach_Hang", OKHACH_HANG.Ten_Khach_Hang);
            pr[2] = new SqlParameter(@"So_CMND", OKHACH_HANG.So_CMND);
            pr[3] = new SqlParameter(@"So_Dien_Thoai", OKHACH_HANG.So_Dien_Thoai);
            pr[4] = new SqlParameter(@"Dia_Chi", OKHACH_HANG.Dia_Chi);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "KHACH_HANG_Update", pr);
        }
        //-----------------------------------------------------------//
        public static void Delete(string Ma_KH)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Ma_KH", Ma_KH);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "KHACH_HANG_Delete", pr);
        }
        //-----------------------------------------------------------//
        public static EKHACH_HANG SelectByID(string Ma_KH)
        {
            string A = Ma_KH;
            EKHACH_HANG OKHACH_HANG = new EKHACH_HANG();
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Ma_KH", Ma_KH);
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "KHACH_HANG_SelectByID", pr);
            if (idr.Read())
                OKHACH_HANG = GetOneKHACH_HANG(idr);
            idr.Close();
            idr.Dispose();
            return OKHACH_HANG;
        }
        //-----------------------------------------------------------//
        private static EKHACH_HANG GetOneKHACH_HANG(IDataReader idr)
        {
            EKHACH_HANG OKHACH_HANG = new EKHACH_HANG();
            if (idr["Ma_KH"] != DBNull.Value)
                OKHACH_HANG.Ma_KH = (string)idr["Ma_KH"];
            if (idr["Ten_Khach_Hang"] != DBNull.Value)
                OKHACH_HANG.Ten_Khach_Hang = (string)idr["Ten_Khach_Hang"];
            if (idr["So_CMND"] != DBNull.Value)
                OKHACH_HANG.So_CMND = (string)idr["So_CMND"];
            if (idr["So_Dien_Thoai"] != DBNull.Value)
                OKHACH_HANG.So_Dien_Thoai = (string)idr["So_Dien_Thoai"];
            if (idr["Dia_Chi"] != DBNull.Value)
                OKHACH_HANG.Dia_Chi = (string)idr["Dia_Chi"];
            return OKHACH_HANG;
        }
        //-----------------------------------------------------------//
        public static bool TestByID(string Ma_KH)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter(@"Ma_KH", Ma_KH);
            pr[1] = new SqlParameter(@"TestID", SqlDbType.Bit);
            pr[1].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "KHACH_HANG_TestByID", pr);
            return Convert.ToBoolean(pr[1].Value);
        }
        //-----------------------------------------------------------//
        public static List<EKHACH_HANG> ListAll()
        {
            List<EKHACH_HANG> list = new List<EKHACH_HANG>();
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "KHACH_HANG_SelectAll", null);
            while (idr.Read())
                list.Add(GetOneKHACH_HANG(idr));
            if (idr.IsClosed == false)
            {
                idr.Close();
                idr.Dispose();
            }
            return list;
        }

        public static List<EKHACH_HANG> ListTop(int Top)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Top", Top);
            List<EKHACH_HANG> list = new List<EKHACH_HANG>();
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "KHACH_HANG_SelectAll", pr);
            while (idr.Read())
                list.Add(GetOneKHACH_HANG(idr));
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
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "KHACH_HANG_LastID", pr);
            return all;
        }
        public static String NextID()
        {
            
            return TIETKIEM.Utilities.NextID(SelectBottom(1).Rows[0]["Ma_KH"].ToString(), "MKH");
        }


    }
 
}