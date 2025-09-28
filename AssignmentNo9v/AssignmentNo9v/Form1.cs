using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentNo9v
{
    public partial class AlarmForm : Form
    {
        private DateTime alarmTime; 
        private bool alarmSet = false;
        public AlarmForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (alarmSet && DateTime.Now.Hour == alarmTime.Hour && DateTime.Now.Minute == alarmTime.Minute && DateTime.Now.Second == alarmTime.Second)
            {
                timer1.Stop(); alarmSet = false; 
                MessageBox.Show("Wake up! Alarm ringing!", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                System.Media.SystemSounds.Beep.Play(); 
                label1.Text = "Alarm Triggered!"; 
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            alarmTime = dateTimePicker1.Value; 
            // user-selected time
            alarmSet = true; 
            label1.Text = "Alarm set for: " + alarmTime.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            alarmSet = false; 
            label1.Text = "Alarm cleared.";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void AlarmForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; 
            // 1 second
            timer1.Tick += timer1_Tick; 
            timer1.Start();
        }
    }
}
