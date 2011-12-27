using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using TIETKIEM.Data.Entities;
using TIETKIEM.Data.DataAccess;
using System.Windows.Forms;

namespace TIETKIEM.Data.Business
{
    public class BACCOUNT
    {
        //-----------------------------------------------------------//
        public static DataTable SelectAll()
        {
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "ACCOUNT_SelectAll", null);
            return all;
        }
        public static DataTable SelectTop(int Top)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Top", Top);
            DataTable all = SqlHelper.ExecuteData(CommandType.StoredProcedure, "ACCOUNT_SelectTop", pr);
            return all;
        }
        //-----------------------------------------------------------//
        public static void Insert(EACCOUNT OACCOUNT)
        {
            SqlParameter[] pr = new SqlParameter[3];
            pr[0] = new SqlParameter(@"Account", OACCOUNT.Account);
            pr[1] = new SqlParameter(@"Pass", OACCOUNT.Pass);
            pr[2] = new SqlParameter(@"Ma_Quyen", OACCOUNT.Ma_Quyen);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "ACCOUNT_Insert", pr);
        }
        //-----------------------------------------------------------//
        public static void Update(EACCOUNT OACCOUNT)
        {
            SqlParameter[] pr = new SqlParameter[3];
            pr[0] = new SqlParameter(@"Account", OACCOUNT.Account);
            pr[1] = new SqlParameter(@"Pass", OACCOUNT.Pass);
            pr[2] = new SqlParameter(@"Ma_Quyen", OACCOUNT.Ma_Quyen);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "ACCOUNT_Update", pr);
        }
        //-----------------------------------------------------------//
        public static void Delete(string Account)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Account", Account);
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "ACCOUNT_Delete", pr);
        }
        //-----------------------------------------------------------//
        public static EACCOUNT SelectByID(string Account)
        {
            EACCOUNT OACCOUNT = new EACCOUNT();
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter(@"Account", Account);
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "ACCOUNT_SelectByID", pr);
            if (idr.Read())
                OACCOUNT = GetOneACCOUNT(idr);
            idr.Close();
            idr.Dispose();
            return OACCOUNT;
        }
        //-----------------------------------------------------------//
        private static EACCOUNT GetOneACCOUNT(IDataReader idr)
        {
            EACCOUNT OACCOUNT = new EACCOUNT();
            if (idr["Account"] != DBNull.Value)
                OACCOUNT.Account = (string)idr["Account"];
            if (idr["Pass"] != DBNull.Value)
                OACCOUNT.Pass = (string)idr["Pass"];
            if (idr["Ma_Quyen"] != DBNull.Value)
                OACCOUNT.Ma_Quyen = (string)idr["Ma_Quyen"];
            return OACCOUNT;
        }
        //-----------------------------------------------------------//
        public static bool TestByID(string Account)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter(@"Account", Account);
            pr[1] = new SqlParameter(@"TestID", SqlDbType.Bit);
            pr[1].Direction = ParameterDirection.Output;
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "ACCOUNT_TestByID", pr);
            return Convert.ToBoolean(pr[1].Value);
        }
        //-----------------------------------------------------------//
        public static List<EACCOUNT> ListAll()
        {
            List<EACCOUNT> list = new List<EACCOUNT>();
            IDataReader idr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "ACCOUNT_SelectAll", null);
            while (idr.Read())
                list.Add(GetOneACCOUNT(idr));
            if (idr.IsClosed == false)
            {
                idr.Close();
                idr.Dispose();
            }
            return list;
        }
        public static bool Kiem_tra_dang_nhap(string ID, string pass)
        {
            if (TestByID(ID) == true) // kiem tra ID có tồn tại hay không.
            {
                string p;
                p = SelectByID(ID).Pass;
                
                // ma hoa pass vưa nhap rồi kiểm tra
                if (String.Compare(CONTROLLER.MaHoaMD5(pass.Trim()),p.Trim())== 0) // giong nhau =0
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        public static void Doi_Mat_Khau(string ID,string Pass)
        {
            //MessageBox.Show(CONTROLLER.MaHoaMD5(Pass));
            EACCOUNT update_pass = new EACCOUNT();
            update_pass.Account = ID;
            update_pass.Pass = CONTROLLER.MaHoaMD5(Pass);
            update_pass.Ma_Quyen = SelectByID(ID).Ma_Quyen.ToString();
            BACCOUNT.Update(update_pass);
            MessageBox.Show(" Đã đổi mật khẩu thành công ", " Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DataTable table_ACC_pHANqUYEN()
        {
            DataTable all = SqlHelper.ExecuteData(CommandType.Text, "SELECT ACCOUNT.Account, ACCOUNT.Ma_Quyen, PHAN_QUYEN.Ten_Quyen FROM ACCOUNT INNER JOIN PHAN_QUYEN ON ACCOUNT.Ma_Quyen = PHAN_QUYEN.Ma_Quyen", null);
                return all;
        }
   
    }
}
