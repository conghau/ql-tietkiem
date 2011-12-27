

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using TIETKIEM.Data.Entities;
using TIETKIEM.Data.DataAccess;
 
namespace TIETKIEM.Data.Business
{
    public class BLOAI_GD
    {
//-----------------------------------------------------------//
        public static DataTable SelectAll()
        {
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "LOAI_GD_SelectAll", null);
            return all;
        }
        public static DataTable SelectTop(int Top)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Top", Top);
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "LOAI_GD_SelectTop", pr);
            return all;
        }
//-----------------------------------------------------------//
        public static void Insert(ELOAI_GD OLOAI_GD)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter(@"Ma_Loai_GD", OLOAI_GD.Ma_Loai_GD);
            pr[1] = new SqlParameter(@"Dien_Giai", OLOAI_GD.Dien_Giai);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"LOAI_GD_Insert", pr);
        }
//-----------------------------------------------------------//
        public static void Update(ELOAI_GD OLOAI_GD)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter(@"Ma_Loai_GD", OLOAI_GD.Ma_Loai_GD);
            pr[1] = new SqlParameter(@"Dien_Giai", OLOAI_GD.Dien_Giai);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"LOAI_GD_Update", pr);
        }
//-----------------------------------------------------------//
        public static void Delete(string Ma_Loai_GD)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Ma_Loai_GD",Ma_Loai_GD);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "LOAI_GD_Delete", pr);
        }
//-----------------------------------------------------------//
        public static ELOAI_GD SelectByID(string Ma_Loai_GD)
        {
            ELOAI_GD OLOAI_GD = new ELOAI_GD();
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Ma_Loai_GD",Ma_Loai_GD);
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure,"LOAI_GD_SelectByID", pr);
            if (idr.Read())
              OLOAI_GD = GetOneLOAI_GD(idr);
            idr.Close();
            idr.Dispose();
            return OLOAI_GD;
        }
//-----------------------------------------------------------//
        private static ELOAI_GD GetOneLOAI_GD(IDataReader idr)
       {
            ELOAI_GD OLOAI_GD = new ELOAI_GD();
                if (idr["Ma_Loai_GD"] != DBNull.Value)
                    OLOAI_GD.Ma_Loai_GD = (string)idr["Ma_Loai_GD"];
                if (idr["Dien_Giai"] != DBNull.Value)
                    OLOAI_GD.Dien_Giai = (string)idr["Dien_Giai"];
            return OLOAI_GD;
       }
//-----------------------------------------------------------//
        public static bool TestByID(string Ma_Loai_GD)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter(@"Ma_Loai_GD",Ma_Loai_GD);
            pr[1] = new SqlParameter(@"TestID",SqlDbType.Bit);
            pr[1].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure,"LOAI_GD_TestByID", pr);
            return Convert.ToBoolean(pr[1].Value);
        }
//-----------------------------------------------------------//
        public static List<ELOAI_GD> ListAll()
        {
            List<ELOAI_GD> list = new List<ELOAI_GD>();
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "LOAI_GD_SelectAll", null);
            while (idr.Read())
              list.Add(GetOneLOAI_GD(idr));
            if (idr.IsClosed == false)
            {
               idr.Close();
               idr.Dispose();
            }
            return list;
        }

        public static List<ELOAI_GD> ListTop(int Top)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Top", Top);
            List<ELOAI_GD> list = new List<ELOAI_GD>();
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "LOAI_GD_SelectAll", pr);
            while (idr.Read())
              list.Add(GetOneLOAI_GD(idr));
            if (idr.IsClosed == false)
            {
               idr.Close();
               idr.Dispose();
            }
            return list;
        }
    }
 
}