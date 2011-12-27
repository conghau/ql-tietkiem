 

 using System;
 using System.Text; 
 
 namespace TIETKIEM.Data.Entities 
{
   public class EGIAO_DICH
   {
	 public EGIAO_DICH()
	 {
	 }
	 private string _Ma_So_GD ;
	 private string _Ma_Loai_GD ;
	 private string _Ma_TK ;
	 private DateTime _Ngay_GD ;
	 private double _So_Tien_GD ;
 

	 public string Ma_So_GD
	 {
	    get { return _Ma_So_GD ; }
	    set { _Ma_So_GD = value ; }
	 }
	 public string Ma_Loai_GD
	 {
	    get { return _Ma_Loai_GD ; }
	    set { _Ma_Loai_GD = value ; }
	 }
	 public string Ma_TK
	 {
	    get { return _Ma_TK ; }
	    set { _Ma_TK = value ; }
	 }
	 public DateTime Ngay_GD
	 {
	    get { return _Ngay_GD ; }
	    set { _Ngay_GD = value ; }
	 }
	 public double So_Tien_GD
	 {
	    get { return _So_Tien_GD ; }
	    set { _So_Tien_GD = value ; }
	 }
   }
 }