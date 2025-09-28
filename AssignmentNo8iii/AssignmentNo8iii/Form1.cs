using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentNo8iii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog(); 
            if (fontDlg.ShowDialog() == DialogResult.OK) 
            { 
                richTextBox1.SelectionFont = fontDlg.Font;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog(); 
            openDlg.Filter = "Text Files|*.txt|Rich Text Files|*.rtf|All Files|*.*"; 
            if (openDlg.ShowDialog() == DialogResult.OK) 
            { 
                if (Path.GetExtension(openDlg.FileName).ToLower() == ".rtf") richTextBox1.LoadFile(openDlg.FileName, RichTextBoxStreamType.RichText); 
                else richTextBox1.LoadFile(openDlg.FileName, RichTextBoxStreamType.PlainText); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog(); 
            saveDlg.Filter = "Text Files|*.txt|Rich Text Files|*.rtf"; 
            if (saveDlg.ShowDialog() == DialogResult.OK) 
            { 
                if (Path.GetExtension(saveDlg.FileName).ToLower() == ".rtf") richTextBox1.SaveFile(saveDlg.FileName, RichTextBoxStreamType.RichText); 
                else richTextBox1.SaveFile(saveDlg.FileName, RichTextBoxStreamType.PlainText); 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog(); 
            if (colorDlg.ShowDialog() == DialogResult.OK) 
            { 
                richTextBox1.SelectionColor = colorDlg.Color; 
            }
        }
    }
}
