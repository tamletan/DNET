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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        public void textc(Student sv)
        {
            mssvtxt.Text = sv.MSSV.ToString();
            nametxt.Text = sv.Name;
            birthtxt.Text = sv.Birth.ToString();
            dtbtxt.Text = sv.DTB.ToString();
            khoatxt.Text = sv.Faculty;
            if (sv.Gender) gendertxt.Text = "Male";
            else gendertxt.Text = "Female";
        }
    }
}