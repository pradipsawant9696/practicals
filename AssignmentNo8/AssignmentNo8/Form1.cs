using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentNo8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(); 
            sb.AppendLine("Username: " + textBox1.Text); 
            sb.AppendLine("Password: " + textBox2.Text); 
            sb.AppendLine("Email: " + textBox3.Text); 
            sb.AppendLine("Gender: " + (radioButton1.Checked ? "Male" : radioButton2.Checked ? "Female" : "Not Selected")); 
            sb.AppendLine("Language: " + (checkBox2.Checked ? "English " : "") + (checkBox1.Checked ? "Marathi " : "")); 
            sb.AppendLine("Address: " + textBox4.Text); 
            sb.AppendLine("BirthDate: " + dateTimePicker1.Value.ToShortDateString()); 
            sb.AppendLine("Mobile No.: " + textBox5.Text); 
            MessageBox.Show(sb.ToString(), "Registration Details");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); 
            textBox2.Clear(); 
            textBox3.Clear(); 
            textBox4.Clear(); 
            textBox5.Clear(); 
            radioButton1.Checked = false; 
            radioButton2.Checked = false; 
            checkBox2.Checked = false; 
            checkBox1.Checked = false; 
            dateTimePicker1.Value = DateTime.Today;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Location = new Point((this.ClientSize.Width / 2) - (panel1.Size.Width / 2),
                                 (this.ClientSize.Height / 2) - (panel1.Size.Height / 2));
        }
    }
}
