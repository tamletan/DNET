using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De1CuoiKy
{
    public partial class AddForm : Form
    {
        private bool AddTrue;
        //Delegate for reload DataGridView
        public delegate void OKClickHandler();
        public event OKClickHandler OKClick;
        public BLLThuVien bll_add { get; set; }
            
        public AddForm()
        {
            InitializeComponent();
            txt_ID.Enabled = false;
            text_Masach.Enabled = false;
            text_MaDG.Enabled = false;
            text_MaNV.Enabled = false;
            bll_add = new BLLThuVien();

            combo_Masach.ValueMember = "Masach";
            combo_Masach.DisplayMember = "Ten"; 
            combo_Masach.DataSource = bll_add.getComboSach_BLL();

            combo_MaDG.ValueMember = "Madg"; 
            combo_MaDG.DisplayMember = "Ten";
            combo_MaDG.DataSource = bll_add.getComboDocgia_BLL();

            combo_Manv.ValueMember = "Manv";
            combo_Manv.DisplayMember = "Ten"; 
            combo_Manv.DataSource = bll_add.getComboNhanVien_BLL();
            MainForm.AddOrUpdate += new MainForm.AddUpdateClickHandler(AddFormTrue);
        }

        private void AddFormTrue(bool e, string id)
        {
            if (e == true)
            {
                AddTrue = true;
            }
            else
            {
                AddTrue = false;
                this.Text = "Chỉnh Sửa Thông Tin Mượn Trả Sách";
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show(combo_MaDG.SelectedValue.ToString());
            if(AddTrue == true)
            {
                if (DateTime.Compare(date_Muon.Value, DateTime.Now) > 0)
                    MessageBox.Show("Mượn trước hôm nay!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bll_add.AddMuonTra_BLL(new MUONTRA()
                {
                    Madg = combo_MaDG.SelectedValue.ToString(),
                    Manv = combo_Manv.SelectedValue.ToString(),
                    Masach = combo_Masach.SelectedValue.ToString(),
                    Ngaymuon = date_Muon.Value,
                    Ngaytra = date_Tra.Value,
                    Ngayhentra = date_Hentra.Value
                });
            }
            if (OKClick != null)
            {
                OKClick.Invoke();
            }
        }

        private void combo_Manv_SelectedIndexChanged(object sender, EventArgs e)
        {
            text_MaNV.Text = combo_Manv.SelectedValue.ToString();
        }

        private void combo_MaDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            text_MaDG.Text = combo_MaDG.SelectedValue.ToString();
        }

        private void combo_Masach_SelectedIndexChanged(object sender, EventArgs e)
        {
            text_Masach.Text = combo_Masach.SelectedValue.ToString();
        }
    }
}
