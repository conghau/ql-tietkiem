 

 using System;
 using System.Text; 
 
 namespace TIETKIEM.Data.Entities 
{
   public class ECT_BC_MO_DONG_SO_THANG
   {
	 public ECT_BC_MO_DONG_SO_THANG()
	 {
	 }
	 private string _Ma_BC_Mo_Dong_So ;
	 private DateTime _Ngay ;
	 private int _So_So_Mo ;
	 private int _So_So_Dong ;
	 private int _Chenh_Lech ;
 

	 public string Ma_BC_Mo_Dong_So
	 {
	    get { return _Ma_BC_Mo_Dong_So ; }
	    set { _Ma_BC_Mo_Dong_So = value ; }
	 }
	 public DateTime Ngay
	 {
	    get { return _Ngay ; }
	    set { _Ngay = value ; }
	 }
	 public int So_So_Mo
	 {
	    get { return _So_So_Mo ; }
	    set { _So_So_Mo = value ; }
	 }
	 public int So_So_Dong
	 {
	    get { return _So_So_Dong ; }
	    set { _So_So_Dong = value ; }
	 }
	 public int Chenh_Lech
	 {
	    get { return _Chenh_Lech ; }
	    set { _Chenh_Lech = value ; }
	 }
   }
 }