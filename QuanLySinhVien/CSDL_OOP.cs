using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class CSDL_OOP
    {
        private static CSDL_OOP _Instance;
        public static CSDL_OOP Instance
        {
            get
            {
                if (_Instance == null) _Instance = new CSDL_OOP();
                return _Instance;
            }
            private set { }
        }
        public delegate bool Compare(SV s1, SV s2);
        public static void Sort(List<SV> arr, Compare cmp)
        {
            for (int i = 0; i < arr.Count - 1; i++)
            {
                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (cmp(arr[i], arr[j]))
                    {
                        SV temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        private CSDL_OOP()
        {

        }
        public List<SV> GetAllSV()
        {
            List<SV> data = new List<SV>();
            foreach (DataRow item in CSDL.Instance.DTSV.Rows)
            {
                data.Add(GetSV(item));
            }
            return data;
        }
        public SV GetSV(DataRow i)
        {
            return new SV
            {
                MSSV = i["MSSV"].ToString(),
                NameSV = i["NameSV"].ToString(),
                Gender = Convert.ToBoolean(i["Gender"].ToString()),
                NS = (Convert.ToDateTime(i["NS"].ToString())),
                ID_LopSH = Convert.ToInt32(i["ID_Lop"].ToString())
            };
        }
        public List<LSH> GetAllLSH()
        {
            List<LSH> data = new List<LSH>();
            foreach (DataRow item in CSDL.Instance.DTLSH.Rows)
            {
                data.Add(GetLSH(item));
            }
            return data;
        }
        public LSH GetLSH(DataRow i)
        {
            return new LSH
            {
                NameLop = i["NameLop"].ToString(),
                ID_Lop = Convert.ToInt32(i["ID_Lop"].ToString())
            };
        }
        public List<SV> GetListSV(int ID_Lop, string Name, string typeSort)
        {
            List<SV> data = new List<SV>();
            foreach (SV item in GetAllSV())
            {
                SV s = new SV
                {
                    NameSV = item.NameSV,
                    MSSV = item.MSSV,
                    Gender = item.Gender,
                    NS = item.NS,
                    ID_LopSH = item.ID_LopSH
                };
                if (ID_Lop == 0 && Name == "")
                {
                    data.Add(s);
                }    
                else if (item.ID_LopSH == ID_Lop && item.NameSV.Contains(Name))
                {
                    data.Add(s);
                }
                //SapXep
                SapXep(data, typeSort);
            }
            return data;
        }
        public void ExecuteDB(SV s)
        {
            bool check = false;
            foreach (SV item in GetAllSV())
            {
                if (item.MSSV == s.MSSV)
                {
                    check = true;
                    break;
                }
            }
            if (check)
            {
                CSDL.Instance.EditDataRowSV(s);
            }
            else
            {
                CSDL.Instance.AddDataRowSV(s);
            }
        }
        public SV GetSVByMSSV(string MSSV)
        {
            foreach (SV item in GetAllSV())
            {
                if (item.MSSV == MSSV)
                {
                    return item;
                }
            }
            return null;
        }
        public void DeleteSV(string MSSV)
        {
            CSDL.Instance.DeleteDataRowSV(MSSV);
        }
        public void SapXep(List<SV> data, string typeSort)
        {
            switch (typeSort)
            {
                case "MSSV tăng dần":
                    Sort(data, SV.Compare_MSSV_tang);
                    break;
                case "MSSV giảm dần":
                    Sort(data, SV.Compare_MSSV_giam);
                    break;
                case "Tên từ A->Z":
                    Sort(data, SV.Compare_Name_tang);
                    break;
                case "Tên từ Z->A":
                    Sort(data, SV.Compare_Name_giam);
                    break;
                case "Ngày sinh tăng dần":
                    Sort(data, SV.Compare_NS_tang);
                    break;
                case "Ngày sinh giảm dần":
                    Sort(data, SV.Compare_NS_giam);
                    break;
            }
        }
    }
}
