 

 using System;
 using System.Text; 
 
 namespace TIETKIEM.Data.Entities 
{
   public class EBAO_CAO_DSHD_NGAY
   {
	 public EBAO_CAO_DSHD_NGAY()
	 {
	 }
	 private string _Ma_BC_DSHD ;
	 private DateTime _Ngay ;
	 private string _Ma_Loai_TK ;
	 private double _Tong_Thu ;
	 private double _Tong_Chi ;
	 private double _Chenh_Lech ;
 

	 public string Ma_BC_DSHD
	 {
	    get { return _Ma_BC_DSHD ; }
	    set { _Ma_BC_DSHD = value ; }
	 }
	 public DateTime Ngay
	 {
	    get { return _Ngay ; }
	    set { _Ngay = value ; }
	 }
	 public string Ma_Loai_TK
	 {
	    get { return _Ma_Loai_TK ; }
	    set { _Ma_Loai_TK = value ; }
	 }
	 public double Tong_Thu
	 {
	    get { return _Tong_Thu ; }
	    set { _Tong_Thu = value ; }
	 }
	 public double Tong_Chi
	 {
	    get { return _Tong_Chi ; }
	    set { _Tong_Chi = value ; }
	 }
	 public double Chenh_Lech
	 {
	    get { return _Chenh_Lech ; }
	    set { _Chenh_Lech = value ; }
	 }
   }
 }