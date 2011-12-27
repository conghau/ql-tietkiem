using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using TIETKIEM.Data.Entities;
using TIETKIEM.Data.DataAccess;

namespace TIETKIEM.Data.Business
{
        public class BTHAM_SO
        {
            //-----------------------------------------------------------//
            public static DataTable SelectAll()
            {
                DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "THAM_SO_SelectAll", null);
                return all;
            }
                    
           
            //-----------------------------------------------------------//
            public static void Update(ETHAM_SO OTHAM_SO)
            {
                SqlParameter[] pr = new SqlParameter[2];
                pr[0] = new SqlParameter(@"Ten_Tham_So", OTHAM_SO.Ten_Tham_So);
                pr[1] = new SqlParameter(@"Gia_Tri", OTHAM_SO.Gia_Tri);
                SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "THAM_SO_Update", pr);
            }         
            //-----------------------------------------------------------//
            public static ETHAM_SO SelectByID(string Ten_Tham_So)
            {
                ETHAM_SO OTHAM_SO = new ETHAM_SO();
                SqlParameter[] pr = new SqlParameter[1];
                pr[0] = new SqlParameter(@"Ten_Tham_So", Ten_Tham_So);
                IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "THAM_SO_SelectByID", pr);
                if (idr.Read())
                    OTHAM_SO = GetOneTHAM_SO(idr);
                idr.Close();
                idr.Dispose();
                return OTHAM_SO;
            }
            //-----------------------------------------------------------//
            private static ETHAM_SO GetOneTHAM_SO(IDataReader idr)
            {
                ETHAM_SO OTHAM_SO = new ETHAM_SO();
                if (idr["Ten_Tham_So"] != DBNull.Value)
                    OTHAM_SO.Ten_Tham_So = (string)idr["Ten_Tham_So"];
                if (idr["Gia_Tri"] != DBNull.Value)
                    OTHAM_SO.Gia_Tri = (double)idr["Gia_Tri"];
                return OTHAM_SO;
            }    
            //-----------------------------------------------------------//
            public static List<ETHAM_SO> ListAll()
            {
                List<ETHAM_SO> list = new List<ETHAM_SO>();
                IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "THAM_SO_SelectAll", null);
                while (idr.Read())
                    list.Add(GetOneTHAM_SO(idr));
                if (idr.IsClosed == false)
                {
                    idr.Close();
                    idr.Dispose();
                }
                return list;
            }
           
            public static double check_Tiengui()
            {

                string a = Data.Business.BTHAM_SO.SelectByID("So_tien_gui_toi_thieu").Gia_Tri.ToString();
                return double.Parse(a);
            }
            public static double Kiem_tra_tien_gui_them()
            {
                string a = BTHAM_SO.SelectByID("So_tien_gui_them_toi_thieu").Gia_Tri.ToString();
                return double.Parse(a); 
            }
     
          
        
       
    }
}