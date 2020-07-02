using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        QLSV m = new QLSV();
        public Form1()
        {
            InitializeComponent();
            
            Student tmp1 = new Student();
            tmp1.MSSV = 123;
            tmp1.Name = "ABC";
            tmp1.DTB = 8.45;
            tmp1.Faculty = "CNTT";
            tmp1.Birth = DateTime.Now;
            tmp1.Gender = true;
            m.List.Add(tmp1);
            Student tmp2 = new Student();
            tmp2.MSSV = 126;
            tmp2.Name = "DFVE";
            tmp2.DTB = 8.75;
            tmp2.Faculty = "PFIEV";
            tmp2.Birth = DateTime.Now;
            tmp2.Gender = false;
            m.List.Add(tmp2);
            Student tmp3 = new Student();
            tmp3.MSSV = 146;
            tmp3.Name = "KJEER";
            tmp3.DTB = 7.75;
            tmp3.Faculty = "CNTT";
            tmp3.Birth = DateTime.Now;
            tmp3.Gender = false;
            m.List.Add(tmp3);
            Student tmp4 = new Student();
            tmp4.MSSV = 129;
            tmp4.Name = "GHETOAS";
            tmp4.DTB = 8.15;
            tmp4.Faculty = "QLDA";
            tmp4.Birth = DateTime.Now;
            tmp4.Gender = true;
            m.List.Add(tmp4);

            BoxKHOA();
            dataGridView1.DataSource = m.List;
            BoxSort();
        }

        private void BoxKHOA()
        {
            foreach (Student i in m.List)
            {
                if (khoatxt.Items.Contains(i.Faculty) == false)
                {
                    khoatxt.Items.Add(i.Faculty);
                }
            }
        }

        private void BoxSort()
        {
            sorttxt.Items.Clear();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                sorttxt.Items.Add(dataGridView1.Columns[i].HeaderText);
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = m.List;
            //BoxSort();
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            Student sv = GetSV(id);
            Form2 f2 = new Form2();
            f2.Show();
            f2.textc(sv);
        }

        private Student GetSV(int id)
        {
            foreach(Student i in m.List)
            {
                if (id == i.MSSV) return i;
            }
            return null;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            Student sv = GetSV(id);
            mssvtxt.Text = sv.MSSV.ToString();
            nametxt.Text = sv.Name;
            birthtxt.Value = sv.Birth;
            dtbtxt.Text = sv.DTB.ToString();
            khoatxt.SelectedItem = khoatxt.Items[khoatxt.Items.IndexOf(sv.Faculty)];
            if (sv.Gender) malelabel.Checked = true;
            else femalelabel.Checked = true;
        }

        //private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
        //    Student sv = GetSV(id);
        //    Form2 f2 = new Form2();
        //    f2.Show();
        //    f2.textc(sv);
        //}

        private void updatebutton_Click(object sender, EventArgs e)
        {
            foreach(Student i in m.List)
            {
                if (mssvtxt.Text == i.MSSV.ToString())
                {
                    i.Name = nametxt.Text;
                    i.Birth = birthtxt.Value;
                    i.DTB = Convert.ToDouble(dtbtxt.Text);
                    i.Faculty = khoatxt.SelectedItem.ToString();
                    if (malelabel.Checked == true) i.Gender = true;
                    else i.Gender = false;
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = m.List;
            }
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Student sv = new Student();
            sv.MSSV = Convert.ToInt32(mssvtxt.Text);
            sv.Name = nametxt.Text;
            sv.Birth = birthtxt.Value;
            sv.DTB = Convert.ToDouble(dtbtxt.Text);
            sv.Faculty = khoatxt.Text;
            sv.Gender = (malelabel.Checked == true) ? true : false;
            m.List.Add(sv);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = m.List;
            BoxKHOA();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            List<int> tmp = new List<int>();
            foreach(DataGridViewRow i in dataGridView1.SelectedRows)
            {
                tmp.Add(Convert.ToInt32(i.Cells["MSSV"].Value));
            }
            m.Del(tmp);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = m.List;
        }

        private void khoatxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            List<Student> cur = new List<Student>();
            string f = khoatxt.SelectedItem.ToString();
            foreach(Student i in m.List)
            {
                if (i.Faculty == f)
                    cur.Add(i);
            }
            dataGridView1.DataSource = cur;
        }

        //private void searchbutton_Click(object sender, EventArgs e)
        //{
        //    List<Student> cur = new List<Student>();
        //    dataGridView1.SelectAll();
        //    foreach (DataGridViewRow i in dataGridView1.SelectedRows)
        //    {
        //        cur.Add(GetSV(Convert.ToInt32(i.Cells["MSSV"].Value)));
        //    }
        //    dataGridView1.DataSource = null;
        //    dataGridView1.DataSource = m.Search(searchtxt.Text, cur);
        //}

        private void searchbutton_Click(object sender, EventArgs e)
        {
            SearchForm f3 = new SearchForm();
            f3.Show();
            f3.GetData(m.List);
        }
        
        private void sortbutton_Click(object sender, EventArgs e)
        {
            List<Student> cur = new List<Student>();
            dataGridView1.SelectAll();
            foreach (DataGridViewRow i in dataGridView1.SelectedRows)
            {
                cur.Add(GetSV(Convert.ToInt32(i.Cells["MSSV"].Value)));
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = m.Sort(sorttxt.Text, cur);            
        }
    }
}
