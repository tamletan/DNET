using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code1st
{
    public partial class Form1 : Form
    {
        //SinhVienCode1st db;
        public delegate void SignalTransfer(int IDSV, bool signal);
        public static event SignalTransfer ST;
        public static BLL BLLSV;
        public Form1()
        {
            InitializeComponent();
            //db = new SinhVienCode1st();
            //dataGridView1.DataSource = db.SinhViens.Select(p=>  new {p.ID,p.TenSV,p.Ngaysinh,Gioitinh = (p.Gioitinh == true)? "Nam":"Nu",p.Khoa.TenKhoa,p.Diem }).ToList();
            BLLSV = new BLL();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            //dataGridView1.DataSource = db.SinhViens.Select(p => new { p.ID, p.TenSV, p.Ngaysinh, Gioitinh = (p.Gioitinh == true) ? "Nam" : "Nu", p.Khoa.TenKhoa, p.Diem }).ToList();
            dataGridView1.DataSource = BLLSV.GetClassView();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Add_Update F2 = new Add_Update();
            F2.Show();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Add_Update F2 = new Add_Update();
            F2.Show();
            int IDSV = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            ST.Invoke(IDSV, true);
            dataGridView1.DataSource = null;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int IDSV = 0;
            DialogResult DR = new DialogResult();
            DR = MessageBox.Show("Ban that su muon xoa ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            { foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    IDSV = Convert.ToInt32(i.Cells["ID"].Value);
                    BLLSV.Delete(IDSV);
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = BLLSV.GetClassView();
        }
        private void LoadCBBox()
        {
            List<Khoa> temp = BLLSV.loadfalce();
            comboBox1.SelectedValue = "ID";
            comboBox1.DisplayMember = "TenKhoa";
            comboBox1.DataSource = temp;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {           
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = BLLSV.SearchWithFalculty(comboBox1.DisplayMember.ToString());
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = BLLSV.Search(SearchTxtBox.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = BLLSV.SearchWithGender(comboBox2.SelectedItem.ToString());
        }
    }
}
