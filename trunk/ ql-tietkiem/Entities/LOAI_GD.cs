 

 using System;
 using System.Text; 
 
 namespace TIETKIEM.Data.Entities 
{
   public class ELOAI_GD
   {
	 public ELOAI_GD()
	 {
	 }
	 private string _Ma_Loai_GD ;
	 private string _Dien_Giai ;
 

	 public string Ma_Loai_GD
	 {
	    get { return _Ma_Loai_GD ; }
	    set { _Ma_Loai_GD = value ; }
	 }
	 public string Dien_Giai
	 {
	    get { return _Dien_Giai ; }
	    set { _Dien_Giai = value ; }
	 }
   }
 }