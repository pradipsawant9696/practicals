using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentNo8ii
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Validate Student Name
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Student Name cannot be blank!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus(); return;
            }
            // 2. Validate Mobile Number (only 10 digits allowed)
            if (!Regex.IsMatch(textBox3.Text, @"^[0-9]{10}$"))
            {
                MessageBox.Show("Mobile number must contain exactly 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus(); return;
            }
            // 3. Validate Email (basic format check)
            if (!Regex.IsMatch(textBox4.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid Email format!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus(); return;
            }
            // 4. Validate Age > 18
            int age = DateTime.Today.Year - dateTimePicker1.Value.Year;
            if (dateTimePicker1.Value.Date > DateTime.Today.AddYears(-age)) age--;
            // adjust for birthdate not yet reached
            if (age < 18) { MessageBox.Show("Student age must be greater than 18 years.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            // If all validations pass, show success
            MessageBox.Show($"Registration Successful!\n\nName: {textBox1.Text}\nAddress: {textBox2.Text}\nMobile: {textBox3.Text}\nEmail: {textBox4.Text}\nBirthDate: {dateTimePicker1.Value.ToShortDateString()}\nAge: {age}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
