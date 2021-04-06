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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetCBB();
            //if (string.Compare("Ngia", "b") < 0) MessageBox.Show("Sn");
        }
        public void SetCBB()
        {
            cbLopSH.Items.Add(new CBBIteam { Value = 0, Text = "All" });
            foreach (LSH item in CSDL_OOP.Instance.GetAllLSH())
            {
                cbLopSH.Items.Add(new CBBIteam
                {
                    Value = item.ID_Lop,
                    Text = item.NameLop
                });
            }
            cbLopSH.SelectedIndex = 0;
            cbSort.SelectedIndex = 0;
        }
        public void Show(int ID_Lop, string Name, string MSSV)
        {
            if((ID_Lop==0) && Name == "")
            {
                cbLopSH.SelectedIndex = 0;
                txbSearch.Text = "";
            }
            dgvListSV.DataSource = CSDL_OOP.Instance.GetListSV(ID_Lop, Name, cbSort.SelectedItem.ToString());
            //Select vào Row vừa Add hoặc Edit
            if (MSSV != null)
            {
                int i = 0;
                int index = 0;
                foreach (DataGridViewRow item in dgvListSV.Rows)
                {
                    if (item.Cells["MSSV"].Value.ToString() == MSSV)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                dgvListSV.Rows[0].Selected = false;
                dgvListSV.Rows[index].Selected = true;
            }    
            
        }
        private void btShow_Click(object sender, EventArgs e)
        {
            Show(((CBBIteam)cbLopSH.SelectedItem).Value, txbSearch.Text, null);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(null, "add");
            f.d += new Form2.MyDel(Show);
            f.Show();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if(dgvListSV.SelectedRows.Count == 1)
            {
                string MSSV = dgvListSV.SelectedRows[0].Cells["MSSV"].Value.ToString();
                Form2 f = new Form2(MSSV, "edit");
                f.d += new Form2.MyDel(Show);
                f.Show();
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {       
            for (int i = 0; i < dgvListSV.SelectedRows.Count; i++)
            {
                string MSSV = dgvListSV.SelectedRows[i].Cells["MSSV"].Value.ToString();
                CSDL_OOP.Instance.DeleteSV(MSSV);
            }
            Show(((CBBIteam)cbLopSH.SelectedItem).Value, txbSearch.Text, null);
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            Show(((CBBIteam)cbLopSH.SelectedItem).Value, txbSearch.Text, null);
        }
    }
}
