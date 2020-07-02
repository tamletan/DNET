using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstDB
{
    public partial class Form1 : Form
    {
        public Models.DataContext db;
        public Form1()
        {
            InitializeComponent();
            db = new Models.DataContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.DataSource = db.Students.Select(p => new { p.Id, p.Sname, p.Sbirth, Gender = (p.Gender) ? "Male" : "Female", p.DTB }).ToList();
        }
    }
}
