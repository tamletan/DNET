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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Sender = new SendInfo(Show);
            BoxTang();
            BoxLoaiP();
        }

        public delegate void SendInfo(CSVC info, bool enable);
        public SendInfo Sender;

        public delegate void UpdateForm(CSVC info);
        public UpdateForm OKclick;

        private void BoxTang()
        {
            tangbox.Items.Add("1");
            tangbox.Items.Add("2");
            tangbox.Items.Add("3");
        }

        private void BoxLoaiP()
        {
            loaipbox.Items.Add("Phong Hoc");
            loaipbox.Items.Add("Phong Thuc Hanh");
            loaipbox.Items.Add("Phong Lam Viec");
        }

        public void Show(CSVC obj,bool enable)
        {
            maptext.Text = obj.MaPhong.ToString();
            maptext.Enabled = enable;
            tenptext.Text = obj.TenPhong.ToString();
            tangbox.SelectedItem = tangbox.Items[tangbox.Items.IndexOf(obj.Tang.ToString())];
            loaipbox.SelectedItem = loaipbox.Items[loaipbox.Items.IndexOf(obj.LoaiPhong.ToString())];
            if (obj.TrangThai == true) radio1.Checked = true;
            else radio2.Checked = true;
            ngaypicker.Value = obj.NgaySuDung;
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            CSVC obj = new CSVC();
            obj.MaPhong = Convert.ToInt32(maptext.Text);
            obj.TenPhong = tenptext.Text;
            obj.Tang = Convert.ToInt32(tangbox.SelectedItem);
            obj.LoaiPhong = loaipbox.SelectedItem.ToString();
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
