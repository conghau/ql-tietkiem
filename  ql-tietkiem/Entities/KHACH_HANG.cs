 

 using System;
 using System.Text;

 
 namespace TIETKIEM.Data.Entities 
{
   public class EKHACH_HANG
   {
	 public EKHACH_HANG()
	 {
	 }
	 private string _Ma_KH ;
	 private string _Ten_Khach_Hang;
	 private string _So_CMND ;
	 private string _So_Dien_Thoai ;
	 private string _Dia_Chi ;
 

	 public string Ma_KH
	 {
	    get { return _Ma_KH ; }
	    set { _Ma_KH = value ; }
	 }
	 public string Ten_Khach_Hang
	 {
	    get { return _Ten_Khach_Hang ; }
	    set { _Ten_Khach_Hang = value ; }
	 }
	 public string So_CMND
	 {
	    get { return _So_CMND ; }
	    set { _So_CMND = value ; }
	 }
	 public string So_Dien_Thoai
	 {
	    get { return _So_Dien_Thoai ; }
	    set { _So_Dien_Thoai = value ; }
	 }
	 public string Dia_Chi
	 {
	    get { return _Dia_Chi ; }
	    set { _Dia_Chi = value ; }
	 }
   }
 }