using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    class SV
    {
        public string MSSV { get; set; }
        public string NameSV { get; set; }
        public bool Gender { get; set; }
        public DateTime NS { get; set; }
        public int ID_LopSH { get; set; }
        public static bool Compare_MSSV_tang(SV s1, SV s2)
        {
            if (string.Compare(s1.MSSV, s2.MSSV) > 0)
                return true;
            else
                return false;
        }
        public static bool Compare_MSSV_giam(SV s1, SV s2)
        {
            return (!Compare_MSSV_tang(s1, s2));
        }
        public static bool Compare_Name_tang(SV s1, SV s2)
        {
            string HoTenSV1 = " " + s1.NameSV;
            string HoTenSV2 = " " + s2.NameSV;

            //Chuyển Tên lên trước, rồi dùng hàm để so sánh
            string str1 = "";
            string str2 = "";
            int x = HoTenSV1.LastIndexOf(" "); //vị trí bắt đầu tên của SV1
            int y = HoTenSV2.LastIndexOf(" ");
            str1 = HoTenSV1.Substring(x, HoTenSV1.Length - x);
            str2 = HoTenSV2.Substring(y, HoTenSV2.Length - y);
            str1 += HoTenSV1.Substring(0, x);
            str2 += HoTenSV2.Substring(0, y);
            if (string.Compare(str1, str2) > 0)
                return true;
            else
                return false;
        }
        public static bool Compare_Name_giam(SV s1, SV s2)
        {
            return (!Compare_Name_tang(s1, s2));
        }
        public static bool Compare_NS_tang(SV s1, SV s2)
        {
            if (s1.NS > s2.NS)
                return true;
            else
                return false;
        }
        public static bool Compare_NS_giam(SV s1, SV s2)
        {
            return (!Compare_NS_tang(s1, s2));
        }
    }
}
