using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQEntity
{
    public partial class Form1 : Form
    {
        Model.WinFormDBEntities db;
        public Form1()
        {
            InitializeComponent();
            db = new Model.WinFormDBEntities(); 
        }

        private void Show()
        {
            Data.DataSource = db.Students.Select(p => new { p.MSSV, p.Sname, p.Sbirth, p.Faculty.Fname, Gender = (p.Gender == true) ? "Male" : "Female" }).ToList();
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Model.Student x = new Model.Student {
                Sname = "TuyetArduino",
                Sbirth = Convert.ToDateTime("5/2/1998"),
                FID = 1,
                Gender = true,
                DTB = 9.0
            };
            db.Students.Add(x);
            db.SaveChanges();
            Show();
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            Model.Student del = new Model.Student();
            string mssv = Data.SelectedRows[0].Cells["MSSV"].Value.ToString();
            del = db.Students.Where(p => p.MSSV.ToString() == mssv).SingleOrDefault();
            db.Students.Remove(del);
            db.SaveChanges();
            Show();
        }
    }
}
