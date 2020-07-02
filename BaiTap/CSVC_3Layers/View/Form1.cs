using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVC_3Layers
{
    public partial class Form1 : Form
    {
        BLL_F blf { get; set; }
        BLL_R blr { get; set; }

        public Form1()
        {
            InitializeComponent();
            string s = @"Data Source=DESKTOP-BT9TDDG;Initial Catalog=CSVC;Integrated Security=True";
            blf = new BLL_F(s);
            blr = new BLL_R(s);
            BoxTang();
            BoxLoaiP();
            BoxSort();
        }

        private void BoxTang()
        {
            tangbox.Items.Clear();
            tangbox.Items.Add("--select--");
            tangbox.Items.Add("1");
            tangbox.Items.Add("2");
            tangbox.Items.Add("3");
            tangbox.SelectedItem = tangbox.Items[0];
        }

        private void BoxLoaiP()
        {
            loaipbox.Items.Clear();
            DataTable lp = blr.GetR();
            DataRow row = lp.NewRow();
            row["MaLoaiPhong"] = 0;
            row["LoaiPhong"] = "--select--";
            lp.Rows.InsertAt(row, 0);
            loaipbox.DataSource = lp;
            loaipbox.DisplayMember = "LoaiPhong";
            loaipbox.ValueMember = "MaLoaiPhong";
        }

        private void BoxSort()
        {
            sortbox.Items.Clear();
            sortbox.Items.Add("--select--");
            for (int i = 0; i < Data.Columns.Count; i++)
                sortbox.Items.Add(Data.Columns[i].HeaderText);
            sortbox.SelectedItem = sortbox.Items[0];
        }
        
        private void ShowData(DataTable Z)
        {
            Data.DataSource = null;
            Data.DataSource = Z;
            BoxSort();
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            ShowData(blf.GetListF_BLL());
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            f.OKclick += new Form2.UpdateForm(this.AddCSVC);
        }

        private void AddCSVC(CSVC_DTO obj)
        {
            //CSVC_DTO i = new CSVC_DTO();
            //i.TenPhong = obj.TenPhong;
            //i.Tang = obj.Tang;
            //i.MaLoaiPhong = obj.MaLoaiPhong;
            //i.TrangThai = obj.TrangThai;
            //i.NgaySuDung = obj.NgaySuDung;
            blf.AddF_BLL(obj);
            ShowData(blf.GetListF_BLL());
        }

        private void delbutton_Click(object sender, EventArgs e)
        {
            List<int> tmp = new List<int>();
            foreach (DataGridViewRow i in Data.SelectedRows)
            {
                tmp.Add(Convert.ToInt32(i.Cells["MaPhong"].Value));
            }
            blf.DeleteF_BLL(tmp);
            ShowData(blf.GetListF_BLL());
        }

        private void searchbutton_Click(object sender, EventArgs e)//search theo MaPhong va Tenphong
        {
            blf.Search_BLL(searchtext.Text);
        }

        private void sortbutton_Click(object sender, EventArgs e)
        {
            List<int> cur = new List<int>();
            Data.SelectAll();
            foreach (DataGridViewRow i in Data.SelectedRows)
            {
                cur.Add(Convert.ToInt32(i.Cells["MaPhong"].Value));
            }
            ShowData(blf.SortF_BLL(sortbox.Text, cur));
        }

        private void Data_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Form2 f = new Form2();
            int id = (int)Data.SelectedRows[0].Cells["MaPhong"].Value;
            f.Sender(id);
            f.Show();
            f.OKclick += new Form2.UpdateForm(this.UpdateCSVC);
        }

        private void UpdateCSVC(CSVC_DTO obj)
        {
            blf.UpdateF_BLL(obj);
            ShowData(blf.GetListF_BLL());
        }

        private void tangbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowData(blf.SelectCB_BLL("Tang", tangbox.SelectedItem.ToString()));
        }

        private void loaipbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowData(blf.SelectCB_BLL("MaLoaiPhong", loaipbox.SelectedValue.ToString()));
        }
    }
}
