 

 using System;
 using System.Text; 
 
 namespace TIETKIEM.Data.Entities 
{
     public class EACCOUNT
     {
         public EACCOUNT()
         {
         }
         private string _Account;
         private string _Pass;
         private string _Ma_Quyen;


         public string Account
         {
             get { return _Account; }
             set { _Account = value; }
         }
         public string Pass
         {
             get { return _Pass; }
             set { _Pass = value; }
         }
         public string Ma_Quyen
         {
             get { return _Ma_Quyen;  }
             set { _Ma_Quyen = value; }

         }
     }
 }