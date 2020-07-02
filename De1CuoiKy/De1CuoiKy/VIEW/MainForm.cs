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
    public partial class MainForm : Form
    {
        //Add or Update?
        public delegate void AddUpdateClickHandler(bool e, string id);
        public static event AddUpdateClickHandler AddOrUpdate;

        public BLLThuVien bll { get; set; }
        public MainForm()
        {
            InitializeComponent();
            bll = new BLLThuVien();
            combo_Show.Items.Add("MUONTRA");
            combo_Show.Items.Add("SACH");
            combo_Show.Items.Add("LOAISACH");
            combo_Show.Items.Add("DOCGIA");
            combo_Show.Items.Add("NHANVIEN");
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            ShowDataGridView();
        }

        private void ShowDataGridView()
        {
            String s;
            if (combo_Show.SelectedIndex >= 0)
                s = combo_Show.SelectedItem.ToString();
            else s = "";
            switch (s)
            {
                case "MUONTRA":
                    dataView1.DataSource = bll.GetListMuonTra_BLL();break;
                case "SACH":
                    dataView1.DataSource = bll.GetListSach_BLL();   break;
                case "LOAISACH":
                    dataView1.DataSource = bll.GetListNhanVien_BLL(); break;
                case "DOCGIA":
                    dataView1.DataSource = bll.GetListDocGia_BLL(); break;
                case "NHANVIEN":
                    dataView1.DataSource = bll.GetListNhanVien_BLL(); break;
                default:
                    dataView1.DataSource = bll.GetListMuonTra_BLL(); break;
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddForm fadd = new AddForm();
            if (AddOrUpdate != null)
                AddOrUpdate.Invoke(true, "");
            fadd.Show();
            fadd.OKClick += new AddForm.OKClickHandler(ShowDataGridView);
        }

    }
}
