using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace EntityCodeFirst
{
    public partial class Form1 : Form
    {
        public Model.Model1 db { get; set; }
        public Form1()
        {
            InitializeComponent();
            db = new Model.Model1();
            dataGridView1.DataSource = db.Students.Select(p => new { p.Id, p.Sname, p.Sbirth, p.Faculty.Fname, Gender = (p.Gender) ? "Male" : "Female", p.DTB }).ToList();
        }
    }
}
