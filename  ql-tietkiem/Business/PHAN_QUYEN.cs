using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TIETKIEM.Data.DataAccess;
using TIETKIEM.Data.Entities;

namespace TIETKIEM.Data.Business
{
    public class BPHAN_QUYEN
    {
        //-----------------------------------------------------------//
        public static DataTable SelectAll()
        {
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "PHAN_QUYEN_SelectAll", null);
            return all;
        }
      
        //-----------------------------------------------------------//
     
        //-----------------------------------------------------------//
        
        //-----------------------------------------------------------//
        public static EPHAN_QUYEN SelectByID(string Ma_Quyen)
        {
            EPHAN_QUYEN OPHAN_QUYEN = new EPHAN_QUYEN();
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Ma_Quyen", Ma_Quyen);
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "PHAN_QUYEN_SelectByID", pr);
            if (idr.Read())
                OPHAN_QUYEN = GetOnePHAN_QUYEN(idr);
            idr.Close();
            idr.Dispose();
            return OPHAN_QUYEN;
        }
        //-----------------------------------------------------------//
        private static EPHAN_QUYEN GetOnePHAN_QUYEN(IDataReader idr)
        {
            EPHAN_QUYEN OPHAN_QUYEN = new EPHAN_QUYEN();
            if (idr["Ma_Quyen"] != DBNull.Value)
                OPHAN_QUYEN.Ma_Quyen = (string)idr["Ma_Quyen"];
            if (idr["Ten_Quyen"] != DBNull.Value)
                OPHAN_QUYEN.Ten_Quyen = (string)idr["Ten_Quyen"];
            return OPHAN_QUYEN;
        }
        //-------------------------------------------------------------//
        public static bool TestByID(string Ma_Quyen)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter(@"Ma_Quyen", Ma_Quyen);
            pr[1] = new SqlParameter(@"TestID", SqlDbType.Bit);
            pr[1].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "PHAN_QUYEN_TestByID", pr);
            return Convert.ToBoolean(pr[1].Value);
        }
        //-----------------------------------------------------------//
        public static List<EPHAN_QUYEN> ListAll()
        {
            List<EPHAN_QUYEN> list = new List<EPHAN_QUYEN>();
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "PHAN_QUYEN_SelectAll", null);
            while (idr.Read())
                list.Add(GetOnePHAN_QUYEN(idr));
            if (idr.IsClosed == false)
            {
                idr.Close();
                idr.Dispose();
            }
            return list;
        }

        
    }
}
