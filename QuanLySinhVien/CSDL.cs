
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class CSDL
    {
        public DataTable DTSV { get; set; }
        public DataTable DTLSH { get; set; }

        private static CSDL _Instance;

        public static CSDL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new CSDL();
                return _Instance;
            }
            private set { }
        }

        private CSDL()
        {
            //doi tuong sv
            DTSV = new DataTable();
            DTSV.Columns.Add("MSSV", typeof(string));
            DTSV.Columns.Add("NameSV", typeof(string));
            DTSV.Columns.Add("Gender", typeof(bool));
            DTSV.Columns.Add("NS", typeof(DateTime));
            DTSV.Columns.Add("ID_Lop", typeof(int));

            DataRow dr1 = DTSV.NewRow();
            dr1["MSSV"] = "101";
            dr1["NameSV"] = "Trần Minh Anh";
            dr1["Gender"] = true;
            dr1["NS"] = new DateTime(2001, 1, 1);
            dr1["ID_Lop"] = 1;
            DTSV.Rows.Add(dr1);

            DataRow dr2 = DTSV.NewRow();
            dr2["MSSV"] = "102";
            dr2["NameSV"] = "Nguyễn Yến";
            dr2["Gender"] = false;
            dr2["NS"] = new DateTime(2001, 10, 2);
            dr2["ID_Lop"] = 1;
            DTSV.Rows.Add(dr2);

            DataRow dr5 = DTSV.NewRow();
            dr5["MSSV"] = "103";
            dr5["NameSV"] = "Nguyễn Trọng Ngĩa";
            dr5["Gender"] = true;
            dr5["NS"] = new DateTime(2001, 4, 20);
            dr5["ID_Lop"] = 2;
            DTSV.Rows.Add(dr5);

            //doi tuong lop sinh hoat
            DTLSH = new DataTable();
            DTLSH.Columns.Add("ID_Lop", typeof(int));
            DTLSH.Columns.Add("NameLop", typeof(string));

            DataRow dr3 = DTLSH.NewRow();
            dr3["ID_Lop"] = 1;
            dr3["NameLop"] = "LSH1";
            DTLSH.Rows.Add(dr3);

            DataRow dr4 = DTLSH.NewRow();
            dr4["ID_Lop"] = 2;
            dr4["NameLop"] = "LSH2";
            DTLSH.Rows.Add(dr4);

        }
        public void AddDataRowSV(SV s)
        {
            DataRow dr = DTSV.NewRow();
            dr["MSSV"] = s.MSSV;
            dr["NameSV"] = s.NameSV;
            dr["Gender"] = s.Gender;
            dr["NS"] = s.NS;
            dr["ID_Lop"] = s.ID_LopSH;
            DTSV.Rows.Add(dr);
        }
        public void EditDataRowSV(SV s)
        {
            foreach (DataRow item in DTSV.Rows)
            {
                if(item["MSSV"].ToString() == s.MSSV)
                {
                    item["NameSV"] = s.NameSV;
                    item["Gender"] = s.Gender;
                    item["NS"] = s.NS;
                    item["ID_Lop"] = s.ID_LopSH;
                    break;
                }
            }
        }
        public void DeleteDataRowSV(string MSSV)
        {
            foreach (DataRow item in DTSV.Rows)
            {
                if (item["MSSV"].ToString() == MSSV)
                {
                    DTSV.Rows.Remove(item);
                    break;
                }
            }
        }
    }
}
