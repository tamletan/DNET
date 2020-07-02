using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoWinform
{
    public partial class F1 : Form
    {
        public F1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs a)
        {
            //MessageBox.Show(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            f.textc += new Form2.TS(this.ShowText);
        }
        public void ShowText(string t)
        {
            textBox1.Text = t;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
