
 using System;
 using System.Text; 
 
 namespace TIETKIEM.Data.Entities 
{
     public class ETHAM_SO
     {
         public ETHAM_SO()
         {
         }
         private string _Ten_Tham_So;
         private double _Gia_Tri;


         public string Ten_Tham_So
         {
             get { return _Ten_Tham_So; }
             set { _Ten_Tham_So = value; }
         }
         public double Gia_Tri
         {
             get { return _Gia_Tri; }
             set { _Gia_Tri = value; }
         }
     }
 }