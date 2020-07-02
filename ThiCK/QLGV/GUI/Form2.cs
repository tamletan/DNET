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
    public partial class Form2 : Form
    {
        bool add = false;
        int idgv = 0;

        public Form2()
        {
            InitializeComponent();
            CSbox.Enabled = false;
            Sender = new SendInfo(Show);

            DVDTbox.ValueMember = "Id";
            DVDTbox.DisplayMember = "TenDVDT";
            var DV = Form1.BUS.GetDVDTs();
            DV.Insert(0, new Models.DVDT());
            DVDTbox.DataSource = DV;
            
            CSbox.ValueMember = "Id";
            CSbox.DisplayMember = "TenCoSo";
            var CS = Form1.BUS.GetCSs();
            CS.Insert(0, new Models.CoSo());
            CSbox.DataSource = CS;
        }
        
        public delegate void SendInfo(int id);
        public SendInfo Sender;

        public delegate void UpdateForm();
        public UpdateForm OKclick;

        public void Show(int id)
        {
            Models.GV gv = Form1.BUS.db.GVs.Where(p => p.Id == id).FirstOrDefault();
            nametext.Text = gv.HoTen;
            birthpicker.Value = gv.NgaySinh;
            SDTtext.Text = gv.SDT.ToString();
            GCtext.Text = gv.GhiChu;
            if (gv.GioiTinh == true) maleradio.Checked = true;
            else femaleradio.Checked = true;
            DVDTbox.SelectedValue = gv.MaDVDT;
            add = true;
            idgv = id;
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            if (nametext.Text == "" || SDTtext.Text == "" || SDTtext.Text.Length > 9) MessageBox.Show("Moi nhap lai");
            else
            {
                Models.GV obj = new Models.GV();
                obj.HoTen = nametext.Text;
                if (maleradio.Checked == true) obj.GioiTinh = true;
                else obj.GioiTinh = false;
                obj.NgaySinh = birthpicker.Value;
                obj.GhiChu = GCtext.Text;
                obj.SDT = Convert.ToInt32(SDTtext.Text);
                int iddv = (int)DVDTbox.SelectedValue;

                if (add)
                    Form1.BUS.AddGV(obj, iddv);
                else
                {
                    obj.Id = Form1.BUS.GetGVSTT(idgv).Id;
                    Form1.BUS.EditGV(obj, iddv);
                }
                if (OKclick != null)
                    OKclick.Invoke();
                this.Close();
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DVDTbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)DVDTbox.SelectedValue != 0)
                CSbox.SelectedValue = Form1.BUS.GetCSs((int)DVDTbox.SelectedValue);
        }
    }
}
