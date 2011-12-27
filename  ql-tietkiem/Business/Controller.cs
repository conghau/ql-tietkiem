using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using TIETKIEM.Data.Entities;
using TIETKIEM.Data.DataAccess;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace TIETKIEM.Data.Business
{
    public class CONTROLLER
    {

       

        public static void Auto_Update_TienLai() // khi đến ngày đáo hạn
        {
            Data.Entities.ESO_TIET_KIEM Insert_SoTietKiem = new TIETKIEM.Data.Entities.ESO_TIET_KIEM();
            DataTable SelectAll = new DataTable();
            SelectAll = Data.Business.BSO_TIET_KIEM.SelectAll();
            for (int i = 0; i < Data.Business.BSO_TIET_KIEM.ListAll().Count; i++)
            if(SelectAll.Rows[i]["Ngay_Dong_So"].ToString() == "")
                if(DateTime.Today == Convert.ToDateTime(SelectAll.Rows[i]["Ngay_Dao_Han_Ke_Tiep"]))
                {
                    
                    double Tong_So_Tien_Gui = double.Parse(SelectAll.Rows[i]["Tong_So_Tien_Goi"].ToString());
                    double So_du_hien_co = double.Parse(SelectAll.Rows[i]["So_Du_Hien_Co"].ToString());
                    double lai_suat = double.Parse(Data.Business.BLOAI_TIET_KIEM.SelectByID(SelectAll.Rows[i]["Ma_Loai_TK"].ToString()).Lai_Suat.ToString());
                    int Kihan = Data.Business.BLOAI_TIET_KIEM.SelectByID(SelectAll.Rows[i]["Ma_Loai_TK"].ToString()).Ky_Han;
                    DateTime Ngay_Dao_Han_Ke_Tiep = DateTime.Parse(SelectAll.Rows[i]["Ngay_Dao_Han_Ke_Tiep"].ToString());
                    DateTime Ngay_Tinh_Lai_Gan_Nhat = Convert.ToDateTime(SelectAll.Rows[i]["Ngay_Tinh_Lai_Gan_Nhat"]);
                    double TienLai =0;

                    if (SelectAll.Rows[i]["Ma_Loai_TK"].ToString() == "MLTK01") // neu sổ này là không kì hạn thì thực hiện kiểm tra 
                    {
                        if (Ngay_Tinh_Lai_Gan_Nhat.AddDays(Kihan * 30) == Ngay_Dao_Han_Ke_Tiep)
                        {
                            TienLai = (So_du_hien_co * lai_suat * Kihan / 100);
                            TienLai = Math.Round(TienLai,0);
                        }
                        else
                        {
                            int songay = Convert.ToInt32(Ngay_Dao_Han_Ke_Tiep - Ngay_Tinh_Lai_Gan_Nhat);
                            TienLai = (So_du_hien_co * lai_suat * songay / 30 / 100);
                            TienLai = Math.Round(TienLai, 0);
                        }
                    }
                    else
                    {
                        TienLai = (So_du_hien_co * lai_suat * Kihan / 100); // tinh tien lãi cho so có kì 
                        TienLai = Math.Round(TienLai,0);

                    }
                    double TienRut = double.Parse(SelectAll.Rows[i]["Tong_So_Tien_Rut"].ToString());                    
                    So_du_hien_co = (So_du_hien_co + TienLai - TienRut);
                    

                    Insert_SoTietKiem.Ma_TK = SelectAll.Rows[i]["Ma_TK"].ToString();
                    Insert_SoTietKiem.Ma_KH = SelectAll.Rows[i]["Ma_KH"].ToString();
                    Insert_SoTietKiem.Tong_So_Tien_Goi = Tong_So_Tien_Gui;
                    Insert_SoTietKiem.Ngay_Mo_So = DateTime.Parse(SelectAll.Rows[i]["Ngay_Mo_So"].ToString());
                    Insert_SoTietKiem.Ma_Loai_TK = SelectAll.Rows[i]["Ma_Loai_TK"].ToString();
                    Insert_SoTietKiem.So_Du_Hien_Co = So_du_hien_co;
                    Insert_SoTietKiem.Tien_Lai_Phat_Sinh = double.Parse(SelectAll.Rows[i]["Tien_Lai_Phat_Sinh"].ToString()) + TienLai;
                    Insert_SoTietKiem.Tong_So_Tien_Rut = double.Parse(SelectAll.Rows[i]["Tong_So_Tien_Rut"].ToString());
                    Insert_SoTietKiem.Ngay_Tinh_Lai_Gan_Nhat = Ngay_Dao_Han_Ke_Tiep;
                    Insert_SoTietKiem.Ngay_Dao_Han_Ke_Tiep = Ngay_Dao_Han_Ke_Tiep.AddDays(Kihan * 30);
                    Insert_SoTietKiem.Ngay_Dong_So = SelectAll.Rows[i]["Ngay_Dong_So"].ToString();
                    Insert_SoTietKiem.Trang_Thai_So = false;

                    Data.Business.BSO_TIET_KIEM.Update(Insert_SoTietKiem);
            }
            


        }        
        public static double Tinh_Tien_Lai(string Ma_TK) // khi chưa đến ngày đáo hạn
        {
            DateTime Ngay_Rut = DateTime.Today;
            DateTime Ngay_dao_han_ke_tiep = Data.Business.BSO_TIET_KIEM.SelectByID(Ma_TK).Ngay_Dao_Han_Ke_Tiep;
            DateTime Ngay_Tinh_Lai_Gan_Nhat = Data.Business.BSO_TIET_KIEM.SelectByID(Ma_TK).Ngay_Tinh_Lai_Gan_Nhat;
            int So_ngay;
            double Tien_Lai;         
            string Ma_Loai_TK = Data.Business.BSO_TIET_KIEM.SelectByID(Ma_TK).Ma_Loai_TK;
            double So_du_hien_co = Data.Business.BSO_TIET_KIEM.SelectByID(Ma_TK).So_Du_Hien_Co;
            double Lai_suat = double.Parse(Data.Business.BLOAI_TIET_KIEM.SelectByID("MLTK01").Lai_Suat.ToString());// neu so co ki han ma rut truoc thi tinh theo laisuat cua KHONG KI HAN         

            if (Ngay_Rut == Ngay_Tinh_Lai_Gan_Nhat)
                return Tien_Lai = 0;
            if (Ngay_Rut < Ngay_dao_han_ke_tiep) 
            {
                So_ngay = Convert.ToInt32((Ngay_Rut - Ngay_Tinh_Lai_Gan_Nhat).TotalDays);
                //MessageBox.Show("Ban gui duoc : " + So_ngay.ToString());
                Tien_Lai = So_du_hien_co * Lai_suat * So_ngay / 30/100;
                return Tien_Lai = Math.Round(Tien_Lai, 0);
            }
            else
                return Tien_Lai = 0;// so ngay khong the lon hon ngay dao han ke tiep duoc vi da co ham Auto_Update_tinh_lai()
        }
        public static double[] xac_nhan_tien_lai(string Ma_TK) // để đưa gia trị vào form, sau đó mới cập nhập
        {
            double TienLai_hien_co = BSO_TIET_KIEM.SelectByID(Ma_TK).Tien_Lai_Phat_Sinh;
            double so_du_hien_co = BSO_TIET_KIEM.SelectByID(Ma_TK).So_Du_Hien_Co;

            double tien_lai_tinh_theo_lai_suat_Khong_ki_han = Tinh_Tien_Lai(Ma_TK);
            double[] a = new double[2];// tao array luu gia tri

            a[0] = TienLai_hien_co = TienLai_hien_co+ tien_lai_tinh_theo_lai_suat_Khong_ki_han;
            a[1] = so_du_hien_co = so_du_hien_co + tien_lai_tinh_theo_lai_suat_Khong_ki_han;
            
            //MessageBox.Show(" Tiền lãi hiện có : " + TienLai_hien_co.ToString() +"\n Số dư hiện có :"+ so_du_hien_co.ToString());
            return a;
        }

        public static bool Kiem_tra_Quy_dinh_ngay_rut_toi_thieu(string Ma_TK)
        {
            DateTime Ngay_Rut = DateTime.Today;
            DateTime Ngay_gui = BSO_TIET_KIEM.SelectByID(Ma_TK).Ngay_Mo_So;
            int So_ngay_da_gui = Convert.ToInt32((Ngay_Rut - Ngay_gui).TotalDays);

            string Ma_Loai_TK = BSO_TIET_KIEM.SelectByID(Ma_TK).Ma_Loai_TK.ToString();
            int so_ngay_toi_thieu = BLOAI_TIET_KIEM.SelectByID(Ma_Loai_TK).So_Ngay_Goi_Toi_Thieu;
            if (So_ngay_da_gui >= so_ngay_toi_thieu)
                return true; // rút được
            else
                return false; // chưa rút được

        }
        public static bool Kiem_tra_so_tien_duoc_rut(string Ma_TK,string MLTK,string Value,double So_du_hien_co)
        {
            string Pheptoan = Data.Business.BLOAI_TIET_KIEM.SelectByID(MLTK).QD_So_Tien_Duoc_Rut;// lấy chuỗi quy định 
            //double  So_du_hien_co = Data.Business.BSO_TIET_KIEM.SelectByID(Ma_TK).So_Du_Hien_Co;

            switch (Pheptoan)
            {
                case "<=":
                    {
                        if (double.Parse(Value) >  So_du_hien_co)
                            return false;  // rút nhiều hơn số dư hiện có
                        else
                            return true;
                        
                    }

                case "=":
                    {
                        if (double.Parse(Value) !=  So_du_hien_co)
                            return false; // phải rút hết
                        else
                            return true;
                        
                    }
                default: return true;

            }            
        }

        public static bool KiemTra_GuiThemTien(string Ma_TK)
        {
            string MLTK =  BSO_TIET_KIEM.SelectByID(Ma_TK).Ma_Loai_TK.ToString();
            int kyhan = BLOAI_TIET_KIEM.SelectByID(MLTK).Ky_Han;
            DateTime ngaytinhlai_gannhat = BSO_TIET_KIEM.SelectByID(Ma_TK).Ngay_Tinh_Lai_Gan_Nhat;
            DateTime ngaydaohan_ketiep = BSO_TIET_KIEM.SelectByID(Ma_TK).Ngay_Dao_Han_Ke_Tiep;
            DateTime Ngaymoso = BSO_TIET_KIEM.SelectByID(Ma_TK).Ngay_Mo_So;
            DateTime A = Convert.ToDateTime(ngaydaohan_ketiep.AddDays(-kyhan*30));
            //if(DateTime.Today < ngaytinhlai_gannhat.Add(kyhan*30))  // chua đến ngày đáo hạn
            //    return false;
           // if(ngaytinhlai_gannhat == Ngaymoso || A == Ngaymoso) // chua đến ngày đáo hạn
            //    return false;

            if (A == DateTime.Today && A != Ngaymoso)
                return true;
            else
                return false;

        }
        public static string MaHoaMD5(string text)
        {
            MD5CryptoServiceProvider _md5Hasher = new MD5CryptoServiceProvider();
            byte[] bs = Encoding.UTF8.GetBytes(text);
            bs = _md5Hasher.ComputeHash(bs);
            StringBuilder s = new StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2"));
            }
            return s.ToString();
        }  
       
        #region In chu 
        public class Num2Str
        {
            public Num2Str()
            {
                //
                // TODO: Add constructor logic here
                //
            }
            // Hàm này có thực hiện cắt các số 0
            // ví dụ 005 sẽ đọc là không trăm linh năm
            private string Group32StrX(string num)
            {
                string[] No = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
                string kq, tram, chuc, donvi;
                // Trăm
                if (num.Substring(0, 1) == "0")
                { tram = ""; }
                else
                { tram = No[Convert.ToByte(num.Substring(0, 1))] + " trăm "; }
                // Chục
                switch (num.Substring(1, 1))
                {
                    case "0": if (num.Substring(2, 1) != "0" && num.Substring(0, 1) != "0")
                        {
                            chuc = "linh ";
                        }
                        else { chuc = ""; }; break;
                    case "1": chuc = "mười "; break;
                    default:
                        chuc = No[Convert.ToByte(num.Substring(1, 1))] + " mươi "; break;
                }
                // Đơn vị
                switch (num.Substring(2, 1))
                {
                    case "0": donvi = ""; break;
                    case "1": if ((num.Substring(1, 1) == "0") || (num.Substring(1, 1) == "1"))
                        {
                            donvi = "một";
                        }
                        else
                        {
                            donvi = "mốt";
                        }; break;
                    case "5":
                        if (num.Substring(1, 1) != "0")
                        {
                            donvi = "lăm";
                        }
                        else
                        {
                            donvi = "năm";
                        }; break;
                    default:
                        donvi = No[Convert.ToByte(num.Substring(2, 1))]; break;
                }
                kq = tram + chuc + donvi;
                return kq;
            }

            private string IntNum2Str(string num)
            {
                string[] Cap = { "", " nghìn ", " triệu ", " tỷ ", " nghìn tỷ ", " triệu tỷ ", " tỷ tỷ ", " nghìn tỷ tỷ " };
                string kq = "", str = num, g3, kqtg;
                int caps = 0;
                while (str.Length > 3)
                {
                    g3 = str.Substring(str.Length - 3, 3);
                    str = str.Substring(0, str.Length - 3);
                    if (g3 != "000")
                    { kqtg = Group32StrX(g3) + Cap[Convert.ToByte(caps)]; }
                    else { kqtg = ""; }
                    kq = kqtg + kq;
                    caps++;
                }
                //Chuẩn bị trước khi sử dụng hàm Group32Str1
                while (str.Length < 3)
                { str = "0" + str; }

                if ((str == "000") && (num.Length <= 3))
                { kqtg = "không"; }
                else
                { kqtg = Group32StrX(str) + Cap[Convert.ToByte(caps)]; }
                kq = kqtg + kq;
                return kq;
            }

            private string FracNum2Str(string num)
            {
                string[] No = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
                string kq = "";
                for (int i = 0; i < num.Length; i++)
                {
                    kq += No[Convert.ToByte(num.Substring(i, 1))] + " ";
                }
                return kq;
            }

            private string No2Str(string num)
            {
                string intstr, fracstr, am;
                // Xử lý khi là số âm
                if (num.Substring(0, 1) == "-")
                {
                    am = "âm ";
                    num = num.Replace("-", "");
                }
                else { am = ""; }

                string[] str = num.Split('.');
                // Số quá lớn nhiều hơn 27 chữ số
                if (str[0].Length > 28)
                    throw new Exception("Số lớn quá không hiển thị được! ");

                string s;
                // Xử lý phần số, nếu là có số thập phân hoặc không
                if (str.Length == 2)
                {
                    intstr = IntNum2Str(str[0]);
                    if (str[1].Length <= 2)
                    {
                        if (str[1].Substring(0, 1) == "0")
                        {
                            fracstr = FracNum2Str(str[1]);
                        }
                        else
                        {
                            fracstr = IntNum2Str(str[1]);
                        }
                    }
                    else
                    {
                        fracstr = FracNum2Str(str[1]);
                    }
                    s = (intstr + " phảy " + fracstr);
                }
                else
                {
                    intstr = IntNum2Str(str[0]);
                    s = intstr;
                }
                s = am + s;
                string chuhoa = s.Substring(0, 1).ToUpper();
                s = s.Substring(1, s.Length - 1);
                return (chuhoa + s);
            }

            public string NumNormalize(string num)
            {
                char ThousandSpace = ',';
                char PointScape = '.';
                string[] s = num.Split('.');
                string g3, str = "";
                while (s[0].Length > 3)
                {
                    g3 = s[0].Substring(s[0].Length - 3, 3);
                    s[0] = s[0].Substring(0, s[0].Length - 3);
                    str = ThousandSpace + g3 + str;
                }
                str = s[0] + str;
                if (s.Length == 2)
                {
                    str = (str + PointScape + s[1]);
                }
                return str.Replace("-,", "-");
            }

            public string NumberToString(string no)
            {
                // xử lý trường hợp dáu phảy thay cho dấu chấm
                if (no.IndexOf(",", 0, 1) != 0) { no = no.Replace(",", "."); }
                // Xoá các ký tự trắng ở đầu và cuối
                no = no.Trim();
                // Xử lý khi nó là chữ chứ không phải là số
                if (no == "0") return "không";
                if (no == "") return "không";
                double val;
                try
                {
                    val = Convert.ToDouble(no);
                }
                catch
                {
                    throw new Exception("Đây không phải là số");
                }
                // tiêu diệt các số không
                while (no.Substring(0, 1) == "0")
                {
                    no = no.Substring(1, no.Length - 1);
                }

                if (no.IndexOf(".", 0, 1) != -1)
                {
                    while (no.Substring(no.Length - 1, 1) == "0")
                    {
                        no = no.Substring(0, no.Length - 1);
                    }
                }
                no = No2Str(no);

                return no;
            }
        #endregion
        
        }
    }

}
