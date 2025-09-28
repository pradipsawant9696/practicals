using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentNo9iii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null) listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null) 
            { 
                listBox2.Items.Add(listBox1.SelectedItem); 
                listBox1.Items.Remove(listBox1.SelectedItem); 
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox2.Items)
                listBox1.Items.Add(item); 
            listBox2.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null) listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text)) 
            { 
                listBox1.Items.Add(textBox1.Text.Trim()); 
                textBox1.Clear(); 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text)) 
            { 
                listBox2.Items.Add(textBox1.Text.Trim()); 
                textBox1.Clear(); 
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null) 
            { 
                listBox1.Items.Add(listBox2.SelectedItem); 
                listBox2.Items.Remove(listBox2.SelectedItem); 
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items) 
                listBox2.Items.Add(item); 
            listBox1.Items.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var union = listBox1.Items.Cast<string>().Union(listBox2.Items.Cast<string>()); 
            listBox3.Items.Clear(); 
            foreach (var item in union) 
                listBox3.Items.Add(item);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var intersection = listBox1.Items.Cast<string>().Intersect(listBox2.Items.Cast<string>()); 
            listBox3.Items.Clear();
            foreach (var item in intersection) 
                listBox3.Items.Add(item);
        }
    }
}
