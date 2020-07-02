using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code1st_De2
{
    public partial class SachForm : Form
    {
        bool funcSignal;
        int OID;
        public SachForm()
        {
            InitializeComponent();
            LoadCBBox();
            funcSignal = false;
            Form1.ST += new Form1.SignalTrans(LoadSach);
        }
        private void LoadSach(int ID,bool signal)
        {
            OID = ID;
            funcSignal = signal;
            Sach A = Form1.bll.load1S(ID);
            NameText.Text = A.TenSach;
            AuthorText.Text = A.TacGia;
            NXBText.Text = A.NXB.ToString();
            LoaiCBBox.SelectedValue = A.LoaiSach;
            PageText.Text = A.SoTrang.ToString();
            QuantityText.Text = A.SoLuong.ToString();
        }
        public void LoadCBBox()
        {
            LoaiCBBox.DisplayMember = "TenLoai";
            LoaiCBBox.ValueMember = "ID";
            LoaiCBBox.DataSource = Form1.bll.loadLS();
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void XButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Sach A = new Sach
            {
                TenSach = NameText.Text,
                TacGia = AuthorText.Text,
                NXB = NXBText.Text,
                IDS = Convert.ToInt32(LoaiCBBox.SelectedValue),
                SoTrang = Convert.ToInt32(PageText.Text),
                SoLuong = Convert.ToInt32(QuantityText.Text)
            };
            if (funcSignal == false)
                Form1.bll.Add(A);
            else
                Form1.bll.Update(A,OID);
            Close();
        }
    }
}
