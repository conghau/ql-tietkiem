 

 using System;
 using System.Text; 
 
 namespace TIETKIEM.Data.Entities 
{
   public class ELOAI_TIET_KIEM
   {
	 public ELOAI_TIET_KIEM()
	 {
	 }
	 private string _Ma_Loai_TK ;
	 private string _Ten_Loai_TK ;
	 private int _Ky_Han ;
	 private double _Lai_Suat ;
	 private int _So_Ngay_Goi_Toi_Thieu ;
	 private string _QD_So_Tien_Duoc_Rut ;
 

	 public string Ma_Loai_TK
	 {
	    get { return _Ma_Loai_TK ; }
	    set { _Ma_Loai_TK = value ; }
	 }
	 public string Ten_Loai_TK
	 {
	    get { return _Ten_Loai_TK ; }
	    set { _Ten_Loai_TK = value ; }
	 }
	 public int Ky_Han
	 {
	    get { return _Ky_Han ; }
	    set { _Ky_Han = value ; }
	 }
	 public double Lai_Suat
	 {
	    get { return _Lai_Suat ; }
	    set { _Lai_Suat = value ; }
	 }
	 public int So_Ngay_Goi_Toi_Thieu
	 {
	    get { return _So_Ngay_Goi_Toi_Thieu ; }
	    set { _So_Ngay_Goi_Toi_Thieu = value ; }
	 }
	 public string QD_So_Tien_Duoc_Rut
	 {
	    get { return _QD_So_Tien_Duoc_Rut ; }
	    set { _QD_So_Tien_Duoc_Rut = value ; }
	 }
   }
 }