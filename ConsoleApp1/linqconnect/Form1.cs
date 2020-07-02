using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linqconnect
{
    public partial class Form1 : Form
    {
        LINQobjDataContext db;
        public Form1()
        {
            InitializeComponent();
            db = new LINQobjDataContext();
            BoxKHOA();
        }

        private void showbutton_Click(object sender, EventArgs e)
        {            
            var l = db.Students.Select(p => p);
            //var l = from p in db.Students select new { p.MSSV, p.Sname };
            //var l = db.Students.Select(p => new { p.MSSV, p.Sname, p.Faculty.Fname });

            //var l = db.Students.Where(p => p.Sname.Contains("n"));
            //var l = db.Students.Where(p => p.Sname.Contains("n")).Select(p => new { p.MSSV, p.Sname, p.Faculty.Fname });
            //var l = from p in db.Students where p.Sname.Contains("n") select new { p.MSSV, p.Sname } ;
            Data.DataSource = l;
        }

        private void BoxKHOA()
        {
            var k = db.Faculties.Select(p => new { p.FID, p.Fname });
            khoatxt.Items.Clear();     
            khoatxt.DisplayMember = "Fname";
            khoatxt.ValueMember = "FID";
            khoatxt.DataSource = k;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Student sv = new Student();
            sv.Sname = nametxt.Text;
            sv.Sbirth = birthtxt.Value;
            sv.Gender = malelabel.Checked;
            //sv.FID = Convert.ToInt32(khoatxt.SelectedValue);
            //sv.Faculty.Fname = khoatxt.SelectedItem.ToString();
            var k = db.Faculties.Where(p => p.FID == Convert.ToInt32(khoatxt.SelectedValue)).FirstOrDefault();
            sv.Faculty = k;
            sv.FID = k.FID;
            sv.DTB = Convert.ToDouble(dtbtxt.Text);
            db.Students.InsertOnSubmit(sv);
            db.SubmitChanges();
            Data.DataSource = db.Students.Select(p => p);
        }

        private void Data_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ms = Data.SelectedRows[0].Cells["MSSV"].Value.ToString();
            var k = db.Students.Where(p => p.MSSV == Convert.ToInt32(ms)).FirstOrDefault();
            mssvtxt.Text = k.MSSV.ToString();
            nametxt.Text = k.Sname;
            birthtxt.Value = Convert.ToDateTime(k.Sbirth);
            if (k.Gender == true) malelabel.Checked = true;
            else femalelabel.Checked = true;
            dtbtxt.Text = k.DTB.ToString();
            khoatxt.SelectedValue = k.FID;
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            var sv = db.Students.Where(p => p.MSSV.ToString() == mssvtxt.Text).FirstOrDefault();
            sv.Sname = nametxt.Text;
            sv.Sbirth = birthtxt.Value;
            sv.Gender = malelabel.Checked;
            var k = db.Faculties.Where(p => p.FID == Convert.ToInt32(khoatxt.SelectedValue)).FirstOrDefault();
            sv.Faculty = k;
            sv.FID = k.FID;
            sv.DTB = Convert.ToDouble(dtbtxt.Text);
            db.SubmitChanges();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow i in Data.SelectedRows)
            {
                string mssv = i.Cells["MSSV"].Value.ToString();
                var sv = db.Students.Where(p => p.MSSV.ToString() == mssv).FirstOrDefault();
                db.Students.DeleteOnSubmit(sv);
            }
            db.SubmitChanges();
            Data.DataSource = db.Students.Select(p => p);
        }

        private Student getSV(int id)
        {
            var sv = db.Students.Where(p => p.MSSV == id).FirstOrDefault();
            return sv;
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            string key = searchtxt.Text;
            List<Student> list = new List<Student>();
            Data.SelectAll();
            //list = db.Students.ToList<Student>();
            foreach (DataGridViewRow i in Data.SelectedRows)
            { 
                Student sv = getSV(Convert.ToInt32(i.Cells["MSSV"].Value));
                list.Add(sv);
            }
            Data.DataSource = Search(list, key);
        }

        public List<Student> Search(List<Student> list, string key)
        {
            List<Student> result = new List<Student>();
            for (int i=0;i< list.Count;i++)
            {
                if (list[i].Sname.Contains(key))
                    result.Add(list[i]);
            }
            return result;
        }

        private void sortbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
