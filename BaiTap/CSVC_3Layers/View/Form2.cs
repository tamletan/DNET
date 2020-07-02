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
    public partial class Form2 : Form
    {
        BLL_F blf { get; set; }
        BLL_R blr { get; set; }

        public Form2()
        {
            InitializeComponent();
            string s = @"Data Source=DESKTOP-BT9TDDG;Initial Catalog=CSVC;Integrated Security=True";
            blf = new BLL_F(s);
            blr = new BLL_R(s);
            maptext.Enabled = false;
            Sender = new SendInfo(Show);
            BoxTang();
            BoxLoaiP();
        }

        private void BoxTang()
        {
            tangbox.Items.Add("--select--");
            tangbox.Items.Add("1");
            tangbox.Items.Add("2");
            tangbox.Items.Add("3");
            tangbox.SelectedIndex = 0;
        }

        private void BoxLoaiP()
        {
            DataTable lp = blr.GetR();
            DataRow row = lp.NewRow();
            row["MaLoaiPhong"] = 0;
            row["LoaiPhong"] = "--select--";
            lp.Rows.InsertAt(row, 0);
            loaipbox.DataSource = lp;
            loaipbox.DisplayMember = "LoaiPhong";
            loaipbox.ValueMember = "MaLoaiPhong";
        }

        public delegate void SendInfo(int info);
        public SendInfo Sender;

        public delegate void UpdateForm(CSVC_DTO info);
        public UpdateForm OKclick;
        

        public void Show(int id)
        {
            CSVC_DTO room = blf.GetF_BLL(id);
            maptext.Text = room.MaPhong.ToString();
            tenptext.Text = room.TenPhong.ToString();
            tangbox.SelectedItem = tangbox.Items[tangbox.Items.IndexOf(room.Tang.ToString())];
            loaipbox.SelectedValue = room.MaLoaiPhong;
            if (room.TrangThai == true) radio1.Checked = true;
            else radio2.Checked = true;
            ngaypicker.Value = room.NgaySuDung;
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            CSVC_DTO obj = new CSVC_DTO();
            if(maptext.Text!="")
                obj.MaPhong = Convert.ToInt32(maptext.Text);
            obj.TenPhong = tenptext.Text;
            obj.Tang = Convert.ToInt32(tangbox.SelectedItem);
            obj.MaLoaiPhong = Convert.ToInt32(loaipbox.SelectedValue);
            if (radio1.Checked == true) obj.TrangThai = true;
            else obj.TrangThai = false;
            obj.NgaySuDung = ngaypicker.Value;

            if (OKclick != null)
                OKclick.Invoke(obj);
            this.Close();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
