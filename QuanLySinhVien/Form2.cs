using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form2 : Form
    {
        public delegate void MyDel(int id, string name, string MSSV);
        public MyDel d { get; set; }
        public string MSSV { get; set; }
        private string chucNang;
        public Form2(string m, string chucNang)
        {
            InitializeComponent();
            this.MSSV = m;
            this.chucNang = chucNang;
            SetCBB();
            SetGUI();

        }
        public void SetCBB()
        {
            foreach (LSH item in CSDL_OOP.Instance.GetAllLSH())
            {
                cbLopSH.Items.Add(new CBBIteam
                {
                    Value = item.ID_Lop,
                    Text = item.NameLop
                });
            }
        }
        public void SetGUI()
        {
            SV s = CSDL_OOP.Instance.GetSVByMSSV(MSSV);
            if (s != null)
            {
                txbMSSV.Text = s.MSSV;
                txbMSSV.ReadOnly = true;
                txbName.Text = s.NameSV;
                foreach (CBBIteam item in cbLopSH.Items)
                {
                    if (item.Value == s.ID_LopSH)
                    {
                        cbLopSH.SelectedItem = item;
                        break;
                    }
                }
                dateTimePicker1.Value = s.NS;
                if (s.Gender) rbtMale.Checked = true; 
                else rbtFemale.Checked = true;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (!CheckData()) MessageBox.Show("Mời nhập đủ thông tin!!");
            else
            {
                SV s = new SV
                {
                    MSSV = txbMSSV.Text.Trim(),
                    NameSV = txbName.Text.Trim(),
                    Gender = (rbtMale.Checked) ? true : false,
                    NS = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day),
                    ID_LopSH = ((CBBIteam)cbLopSH.SelectedItem).Value
                };
                if (chucNang == "add")
                {
                    if (CSDL_OOP.Instance.GetSVByMSSV(s.MSSV) == null)
                    {
                        CSDL_OOP.Instance.ExecuteDB(s);
                        d(0, "", txbMSSV.Text);
                        XoaRong();

                    }
                    else MessageBox.Show("MSSV này đã tồn tại!!");
                }
                //Đang dùng chức năng Edit
                else
                {
                    CSDL_OOP.Instance.ExecuteDB(s);
                    d(0, "", this.MSSV);
                }
            } 
        }
        private void XoaRong()
        {
            txbMSSV.Text = "";
            txbName.Text = "";
            cbLopSH.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }
        private bool CheckData()
        {
            if ((txbMSSV.Text == "") || (txbName.Text == "") || (cbLopSH.Text == "")) return false;
            return true;
        }
    }
}
