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
    public partial class SearchForm : Form
    {
        QLSV S = new QLSV();
        public SearchForm()
        {
            InitializeComponent();
        }

        public void GetData(List<Student> L)
        {
            S.List = L;
            BoxKHOA();
            dataGridView2.DataSource = S.List;
        }

        private void BoxKHOA()
        {
            foreach (Student i in S.List)
            {
                if (khoatxt.Items.Contains(i.Faculty) == false)
                {
                    khoatxt.Items.Add(i.Faculty);
                }
            }
        }

        private Student GetSV(int id)
        {
            foreach (Student i in S.List)
            {
                if (id == i.MSSV) return i;
            }
            return null;
        }

        private List<Student> SearchAlter(List<Student> list)
        {
            List<Student> result = new List<Student>();
            string mssv = mssvtxt.Text.ToUpper();
            string name = nametxt.Text.ToUpper();
            //DateTime birth = birthtxt.Value;
            string faculty = khoatxt.Text.ToUpper();
            string dtb = dtbtxt.Text.ToUpper();
            bool check = false;
            if (malelabel.Checked == true || femalelabel.Checked == true) check = true;
            foreach (Student i in list)
            {
                if(i.MSSV.ToString().ToUpper().Contains(mssv) && i.Name.ToUpper().Contains(name) && i.Faculty.ToUpper().Contains(faculty) && i.DTB.ToString().ToUpper().Contains(dtb))
                    result.Add(i);
                //if (mssv != null && i.MSSV.ToString().ToUpper().Contains(mssv) && result.Contains(i) == false)
                //    result.Add(i);
                //if (name != null && i.Name.ToUpper().Contains(name) && result.Contains(i) == false)
                //    result.Add(i);
                //if (faculty != null && i.Faculty.ToUpper().Contains(faculty) && result.Contains(i) == false)
                //    result.Add(i);
                //if (dtb != null && i.DTB.ToString().ToUpper().Contains(dtb) && result.Contains(i) == false)
                //    result.Add(i);
            }
            return result;
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            List<Student> cur = new List<Student>();
            dataGridView2.SelectAll();
            foreach (DataGridViewRow i in dataGridView2.SelectedRows)
            {
                cur.Add(GetSV(Convert.ToInt32(i.Cells["MSSV"].Value)));
            }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = SearchAlter(cur);
        }
    }
}
