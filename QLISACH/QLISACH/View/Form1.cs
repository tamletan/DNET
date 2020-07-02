using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLISACH
{
    public partial class Form1 : Form
    {
        public static bll bll_qli { get; set; }
        public Form1()
        {
            InitializeComponent();
            bll_qli = new bll();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bll_qli.show_bll();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bll_qli.show_bll();
        }
    }
}
