using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3layers
{
    public partial class Form1 : Form
    {
        BLL_S bls { get; set; }
        BLL_F blf { get; set; }

        public Form1()
        {
            InitializeComponent();
            string s = @"Data Source=DESKTOP-BT9TDDG;Initial Catalog=WinFormDB;Integrated Security=True";
            bls = new BLL_S(s);           
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bls.GetListS_BLL();
        }
    }
}
