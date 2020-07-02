using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ColumnHeader c1 = new ColumnHeader();
            ColumnHeader c2 = new ColumnHeader();
            c1.Text = ("A");
            c2.Text = ("B");
            listView1.Columns.Add(c1);
            listView1.Columns.Add(c2);
            ListViewItem i1 = new ListViewItem();
            i1.Text = "1";
            ListViewItem.ListViewSubItem sub1 = new ListViewItem.ListViewSubItem();
            sub1.Text = "2";
            i1.SubItems.Add(sub1);
            listView1.Items.Add(i1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            //if (listBox1.Items.IndexOf(s) >= 0)
            //{
            //    listBox1.SelectedItem = s;
            //    //listBox1.SelectedIndex = listBox1.Items.IndexOf(s);
            //}
            //else
            //    if(textBox1.Text.Length > 0)
            //        listBox1.Items.Add(textBox1.Text);
                    
            if (comboBox1.FindStringExact(s) >= 0)
            {
                //comboBox1.SelectedIndex = comboBox1.FindStringExact(s);
                comboBox1.SelectedItem = s;
            }
            else
                if (textBox1.Text.Length > 0)
                comboBox1.Items.Add(s);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            MessageBox.Show(s);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = listView1.SelectedItems[0].SubItems[1].Text;
            MessageBox.Show(s);
        }
    }
}
