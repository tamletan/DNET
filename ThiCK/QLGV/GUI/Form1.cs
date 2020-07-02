using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV
{
    public partial class Form1 : Form
    {
        public static BLL.GVBLL BUS;

        public Form1()
        {
            InitializeComponent();
            BUS = new BLL.GVBLL();

            CSbox.ValueMember = "Id";
            CSbox.DisplayMember = "TenCoSo";
            var CS = BUS.GetCSs();
            CS.Insert(0, new Models.CoSo());
            CSbox.DataSource = CS;
        }
        
        private void RefreshView()
        {
            if ((int)CSbox.SelectedValue == 0)
                MessageBox.Show("Moi ban chon Co So !");
            else if((int)DVDTbox.SelectedValue == 0)
                MessageBox.Show("Moi ban chon DVDT !");
            else
            {
                DataView.DataSource = BUS.ShowGV((int)DVDTbox.SelectedValue).Select(p => new { p.STT, p.HoTen, p.SDT, p.GhiChu }).ToList();
                DataView.Columns["STT"].HeaderText = "STT";
                DataView.Columns["HoTen"].HeaderText = "Họ tên Giảng viên";
                DataView.Columns["SDT"].HeaderText = "Phone";
                DataView.Columns["GhiChu"].HeaderText = "Ghi Chú";
                LoadSortBox();
            }
        }

        private void LoadSortBox()
        {
            sortbox.Items.Clear();
            for (int i = 1; i < DataView.Columns.Count; i++)
                sortbox.Items.Add(DataView.Columns[i].HeaderText);
        }

        private void CSbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)CSbox.SelectedValue != 0)
            {
                DVDTbox.ValueMember = "Id";
                DVDTbox.DisplayMember = "TenDVDT";
                var DV = BUS.GetDVDTs((int)CSbox.SelectedValue);
                DV.Insert(0, new Models.DVDT());
                DVDTbox.DataSource = DV;
            }
        }

        private void showtbtn_Click(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            f.OKclick += new Form2.UpdateForm(RefreshView);
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (DataView.SelectedRows.Count == 0) MessageBox.Show("Moi ban chon doi tuong!");
            else
            {
                Form2 f = new Form2();
                int stt = (int)DataView.SelectedRows[0].Cells["STT"].Value;                
                f.Sender(BUS.GetGVSTT(stt).Id);
                f.Show();
                f.OKclick += new Form2.UpdateForm(RefreshView);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (DataView.SelectedRows.Count == 0) MessageBox.Show("Moi ban chon doi tuong!");
            else
            {
                List<int> list = new List<int>();
                foreach (DataGridViewRow i in DataView.SelectedRows)
                {
                    int stt = (int)DataView.SelectedRows[0].Cells["STT"].Value;
                    list.Add(BUS.GetGVSTT(stt).Id);
                }
                BUS.RemoveGV(list);
                RefreshView();
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (searchtext.Text == "")
                MessageBox.Show("Moi ban nhap chuoi tim kiem!");
            else
            {
                List<int> cur = new List<int>();
                foreach (DataGridViewRow i in DataView.Rows)
                {
                    int stt = (int)DataView.SelectedRows[0].Cells["STT"].Value;
                    cur.Add(BUS.GetGVSTT(stt).Id);
                }
                DataView.DataSource = BUS.SearchGV(searchtext.Text, cur);
            }
        }

        private void sortbtn_Click(object sender, EventArgs e)
        {
            if ((int)CSbox.SelectedValue == 0)
                MessageBox.Show("Moi ban chon Co So !");
            else if ((int)DVDTbox.SelectedValue == 0)
                MessageBox.Show("Moi ban chon DVDT !");
            else if (sortbox.Text == "")
                MessageBox.Show("Moi ban chon truong sap xep!");
            else
            {
                List<int> cur = new List<int>();
                foreach (DataGridViewRow i in DataView.Rows)
                {
                    int stt = (int)DataView.SelectedRows[0].Cells["STT"].Value;
                    cur.Add(BUS.GetGVSTT(stt).Id);
                }
                DataView.DataSource = BUS.SortGV(sortbox.Text, cur);
            }
        }
    }
}
