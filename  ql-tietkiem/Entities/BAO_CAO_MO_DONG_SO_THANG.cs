 

 using System;
 using System.Text; 
 
 namespace TIETKIEM.Data.Entities 
{
   public class EBAO_CAO_MO_DONG_SO_THANG
   {
	 public EBAO_CAO_MO_DONG_SO_THANG()
	 {
	 }
	 private string _Ma_BC_Mo_Dong_So ;
	 private string _Ma_Loai_TK ;
	 private int _Thang ;
	 private int _Nam ;
 

	 public string Ma_BC_Mo_Dong_So
	 {
	    get { return _Ma_BC_Mo_Dong_So ; }
	    set { _Ma_BC_Mo_Dong_So = value ; }
	 }
	 public string Ma_Loai_TK
	 {
	    get { return _Ma_Loai_TK ; }
	    set { _Ma_Loai_TK = value ; }
	 }
	 public int Thang
	 {
	    get { return _Thang ; }
	    set { _Thang = value ; }
	 }
	 public int Nam
	 {
	    get { return _Nam ; }
	    set { _Nam = value ; }
	 }
   }
 }