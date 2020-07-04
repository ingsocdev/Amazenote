using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AmazeNote
{
    public partial class Note : UserControl
    {
        public Note(int color, string title)
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(color);
            Title.Text = title;
            StreamWriter sw = new StreamWriter(Application.StartupPath.ToString() + "/data.txt",true);
            sw.WriteLine("NT: " + Title.Text.ToString());
            sw.Flush();
            sw.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            button1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            string noteTextBox = "";
            if(textBox1.Text.ToString() == "")
            {
                MessageBox.Show("You need to enter something!");
            }
            else
            {
                noteTextBox = textBox1.Text.ToString();
                NoteItem item = new NoteItem(noteTextBox);
                flowLayoutPanel1.Controls.Add(item);
                textBox1.Visible = false;
                button1.Visible = false;

                StreamWriter sw = new StreamWriter(Application.StartupPath.ToString()  + "/data.txt",true);
                sw.WriteLine("NI: " + textBox1.Text);
                sw.Flush();
                sw.Close();
               
            }
        }
    }
}
