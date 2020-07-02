using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLISACH
{
    public partial class Form2 : Form
    {
        public bll bll { get; set; }
        public Form2()
        {
            InitializeComponent();
            bll = new bll();

            cmb_ms.DisplayMember = "MaSach";
            cmb_ms.ValueMember = "TenSach";
            cmb_ms.DataSource = bll.loadListComboSach();

            cmb_dg.DisplayMember = "MaDG";
            cmb_dg.ValueMember = "HoTenDG";
            cmb_dg.DataSource = bll.loadListComboDOcGia();

            cmb_nv.DisplayMember = "MaNV";
            cmb_nv.ValueMember = "HoTenNV";
            cmb_nv.DataSource = bll.loadListComboNhanVien();

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            MuonTra a = new MuonTra()
            {
                MaSach = txtms.Text,
                MaDG = txtdg.Text,
                MaNV = txtnv.Text,
                NgayMuon = dtpNgayMuon.Value,
                NgayTra = dtpNgayTra.Value,
                NgayHenTra = dtpNgayHenTra.Value,
            };
            bll.AddData(a);
        }

        private void cmb_ms_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtms.Text = cmb_ms.SelectedValue.ToString();
        }

        private void cmb_nv_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtnv.Text = cmb_nv.SelectedValue.ToString();
        }

        private void txtdg_TextChanged(object sender, EventArgs e)
        {
            txtdg.Text = cmb_dg.SelectedValue.ToString();
        }
    }
}
