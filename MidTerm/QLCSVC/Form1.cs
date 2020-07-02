using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCSVC
{
    public partial class Form1 : Form
    {
        QuanLy M = new QuanLy();
        bool sortcheck = false;
        public Form1()
        {
            InitializeComponent();

            CSVC smp1 = new CSVC();
            smp1.MaPhong = 12321;
            smp1.TenPhong = "Phong 1";
            smp1.Tang = 1;
            smp1.LoaiPhong = "Phong Hoc";
            smp1.TrangThai = true;
            smp1.NgaySuDung = DateTime.Today;
            M.list.Add(smp1);

            CSVC smp2 = new CSVC();
            smp2.MaPhong = 21912;
            smp2.TenPhong = "Phong 2";
            smp2.Tang = 1;
            smp2.LoaiPhong = "Phong Thuc Hanh";
            smp2.TrangThai = false;
            smp2.NgaySuDung = DateTime.Today;
            M.list.Add(smp2);

            CSVC smp3 = new CSVC();
            smp3.MaPhong = 45657;
            smp3.TenPhong = "Phong 3";
            smp3.Tang = 2;
            smp3.LoaiPhong = "Phong Hoc";
            smp3.TrangThai = false;
            smp3.NgaySuDung = DateTime.Today;
            M.list.Add(smp3);

            CSVC smp4 = new CSVC();
            smp4.MaPhong = 42697;
            smp4.TenPhong = "Phong 4";
            smp4.Tang = 3;
            smp4.LoaiPhong = "Phong Lam Viec";
            smp4.TrangThai = true;
            smp4.NgaySuDung = DateTime.Today;
            M.list.Add(smp4);

            CSVC smp5 = new CSVC();
            smp5.MaPhong = 23498;
            smp5.TenPhong = "Phong 5";
            smp5.Tang = 3;
            smp5.LoaiPhong = "Phong Hoc";
            smp5.TrangThai = true;
            smp5.NgaySuDung = DateTime.Today;
            M.list.Add(smp5);

            CSVC smp6 = new CSVC();
            smp6.MaPhong = 45762;
            smp6.TenPhong = "Phong 6";
            smp6.Tang = 3;
            smp6.LoaiPhong = "Phong Thuc Hanh";
            smp6.TrangThai = true;
            smp6.NgaySuDung = DateTime.Today;
            M.list.Add(smp6);

            CSVC smp7 = new CSVC();
            smp7.MaPhong = 89463;
            smp7.TenPhong = "Phong 7";
            smp7.Tang = 3;
            smp7.LoaiPhong = "Phong Thuc Hanh";
            smp7.TrangThai = true;
            smp7.NgaySuDung = DateTime.Today;
            M.list.Add(smp7);
        }

        private CSVC GetP(int id)
        {
            foreach (CSVC i in M.list)
            {
                if (id == i.MaPhong) return i;
            }
            return null;
        }

        private void BoxSort()
        {
            sortbox.Items.Clear();
            for (int i = 0; i < Data.Columns.Count; i++)
                sortbox.Items.Add(Data.Columns[i].HeaderText);
        }

        private void BoxTang()
        {
            tangbox.Items.Clear();
            tangbox.Items.Add("1");
            tangbox.Items.Add("2");
            tangbox.Items.Add("3");
        }

        private void BoxLoaiP()
        {
            loaipbox.Items.Clear();
            loaipbox.Items.Add("Phong Hoc");
            loaipbox.Items.Add("Phong Thuc Hanh");
            loaipbox.Items.Add("Phong Lam Viec");
        }

        private void ResetData(List<CSVC> Z)
        {
            Data.DataSource = null;
            Data.DataSource = Z;
        }
        
        private void Data_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Form2 f = new Form2();
            int id = (int)Data.SelectedRows[0].Cells[0].Value;
            CSVC room = GetP(id);
            f.Sender(room, false);
            f.Show();
            f.OKclick += new Form2.UpdateForm(this.UpdateCSVC);
        }

        private void UpdateCSVC(CSVC obj)
        {
            foreach(CSVC i in M.list)
            {
                if(i.MaPhong == obj.MaPhong)
                {
                    i.Tang = obj.Tang;
                    i.TenPhong = obj.TenPhong;
                    i.TrangThai = obj.TrangThai;
                    i.NgaySuDung = obj.NgaySuDung;
                    i.LoaiPhong = obj.LoaiPhong;
                }
            }
            ResetData(M.list);
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            ResetData(M.list);
            BoxSort();
            BoxTang();
            BoxLoaiP();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            f.OKclick += new Form2.UpdateForm(this.AddCSVC);
        }

        private void AddCSVC(CSVC obj)
        {
            CSVC i = new CSVC();
            i.MaPhong = obj.MaPhong;
            i.Tang = obj.Tang;
            i.TenPhong = obj.TenPhong;
            i.TrangThai = obj.TrangThai;
            i.NgaySuDung = obj.NgaySuDung;
            i.LoaiPhong = obj.LoaiPhong;
            M.list.Add(i);
            ResetData(M.list);
        }

        private void delbutton_Click(object sender, EventArgs e)
        {
            List<int> tmp = new List<int>();
            foreach (DataGridViewRow i in Data.SelectedRows)
            {
                tmp.Add(Convert.ToInt32(i.Cells["MaPhong"].Value));
            }
            M.Del(tmp);
            ResetData(M.list);
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            List<CSVC> cur = new List<CSVC>();
            Data.SelectAll();
            foreach (DataGridViewRow i in Data.SelectedRows)
            {
                cur.Add(GetP(Convert.ToInt32(i.Cells["MaPhong"].Value)));
            }
            ResetData(M.Search(searchtext.Text,cur));
        }
        
        private void sortbutton_Click(object sender, EventArgs e)
        {
            List<CSVC> cur = new List<CSVC>();
            Data.SelectAll();
            foreach (DataGridViewRow i in Data.SelectedRows)
            {
                cur.Add(GetP(Convert.ToInt32(i.Cells["MaPhong"].Value)));
            }
            Data.DataSource = null;
            Data.DataSource = M.Sort(sortbox.Text, cur, sortcheck);
            sortcheck = !sortcheck;
        }

        private void tangbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<CSVC> cur = new List<CSVC>();
            Data.SelectAll();
            foreach (DataGridViewRow i in Data.SelectedRows)
            {
                cur.Add(GetP(Convert.ToInt32(i.Cells["MaPhong"].Value)));
            }
            for(int i=cur.Count-1;i>=0;i--)
            {
                if (cur[i].Tang.ToString() != tangbox.Text)
                    cur.RemoveAt(i);
            }
            ResetData(cur);
        }

        private void loaipbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<CSVC> cur = new List<CSVC>();
            Data.SelectAll();
            foreach (DataGridViewRow i in Data.SelectedRows)
            {
                cur.Add(GetP(Convert.ToInt32(i.Cells["MaPhong"].Value)));
            }
            for (int i = cur.Count-1; i >= 0; i--)
            {
                if (cur[i].LoaiPhong != loaipbox.Text)
                    cur.RemoveAt(i);
            }
            ResetData(cur);
        }
    }
}
