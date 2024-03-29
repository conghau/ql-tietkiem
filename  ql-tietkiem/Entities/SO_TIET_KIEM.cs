 

 using System;
 using System.Text; 
 
 namespace TIETKIEM.Data.Entities 
{
     public class ESO_TIET_KIEM
     {

         public ESO_TIET_KIEM()
         {
         }
         private string _Ma_TK;
         private string _Ma_KH;
         private DateTime _Ngay_Mo_So;
         private double _Tong_So_Tien_Goi;
         private string _Ma_Loai_TK;
         private double _So_Du_Hien_Co;
         private double _Tong_So_Tien_Rut;
         private DateTime _Ngay_Tinh_Lai_Gan_Nhat;
         private DateTime _Ngay_Dao_Han_Ke_Tiep;
         private double _Tien_Lai_Phat_Sinh;
         private string _Ngay_Dong_So;
         private bool _Trang_Thai_So;


         public string Ma_TK
         {
             get { return _Ma_TK; }
             set { _Ma_TK = value; }
         }
         public string Ma_KH
         {
             get { return _Ma_KH; }
             set { _Ma_KH = value; }
         }
         public DateTime Ngay_Mo_So
         {
             get { return _Ngay_Mo_So; }
             set { _Ngay_Mo_So = value; }
         }
         public double Tong_So_Tien_Goi
         {
             get { return _Tong_So_Tien_Goi; }
             set { _Tong_So_Tien_Goi = value; }
         }
         public string Ma_Loai_TK
         {
             get { return _Ma_Loai_TK; }
             set { _Ma_Loai_TK = value; }
         }
         public double So_Du_Hien_Co
         {
             get { return _So_Du_Hien_Co; }
             set { _So_Du_Hien_Co = value; }
         }
         public double Tong_So_Tien_Rut
         {
             get { return _Tong_So_Tien_Rut; }
             set { _Tong_So_Tien_Rut = value; }
         }
         public DateTime Ngay_Tinh_Lai_Gan_Nhat
         {
             get { return _Ngay_Tinh_Lai_Gan_Nhat; }
             set { _Ngay_Tinh_Lai_Gan_Nhat = value; }
         }
         public DateTime Ngay_Dao_Han_Ke_Tiep
         {
             get { return _Ngay_Dao_Han_Ke_Tiep; }
             set { _Ngay_Dao_Han_Ke_Tiep = value; }
         }
         public double Tien_Lai_Phat_Sinh
         {
             get { return _Tien_Lai_Phat_Sinh; }
             set { _Tien_Lai_Phat_Sinh = value; }
         }
         public string Ngay_Dong_So
         {
             get { return _Ngay_Dong_So; }
             set { _Ngay_Dong_So = value; }
         }
         public bool Trang_Thai_So
         {
             get { return _Trang_Thai_So; }
             set { _Trang_Thai_So = value; }
         }
     }
 }