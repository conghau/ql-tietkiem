

using System;
using System.Data;
using System.Data.SqlClient;
//using System.Configuration;
//using System.Web;
//using System.Web.Security;
 
namespace TIETKIEM.Data.Connection
{
	 public static class ConnectionString
	 {
         private static string strconnection = "Server=.;Initial Catalog=QL_TIETKIEM;Integrated Security=True";// ConfigurationManager.ConnectionStrings["TIETKIEMConnectionString"].ToString();
	    public static string Text
	    {
	      get { return strconnection; }
	      set { strconnection = value; }
	    }
	 }
}