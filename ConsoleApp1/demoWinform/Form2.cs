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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public delegate void TS(string obj);
        public TS textc;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textc != null)
                textc.Invoke(textBox2.Text);
        }
    }
}
