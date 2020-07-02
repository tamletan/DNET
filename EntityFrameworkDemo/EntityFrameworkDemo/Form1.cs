using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        SinhVienEntitiesDB1st db = new SinhVienEntitiesDB1st();
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {          
            dataGridView1.DataSource = db.SINHVIENs.Select(p=>  new { p.ID_SV, p.TenSV, p.NgaySinh, p.KHOA.TenKhoa, p.Diem,Gender =(p.GioiTinh== true)? "Gei" :"Les" }).ToList();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            SINHVIEN A = new SINHVIEN
            {
                ID_SV = 102110,
                ID_Khoa = 102,
                Diem = 10,
                NgaySinh = Convert.ToDateTime("9/6/1998"),
                GioiTinh = false,
                TenSV = "TuyetAI"
            };
            db.SINHVIENs.Add(A);
            db.SaveChanges();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            /*SINHVIEN A = new SINHVIEN
            {
                ID_SV = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_SV"].Value),
                ID_Khoa = 102,
                Diem = float.Parse(dataGridView1.SelectedRows[0].Cells["Diem"].Value.ToString()),
                NgayS
            };*/
        }
    }
}
