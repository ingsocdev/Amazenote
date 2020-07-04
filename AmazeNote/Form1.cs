using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AmazeNote
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void removeCont(Control sender)
        {
            flowLayoutPanel1.Controls.Remove(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorChoice cchoice = new ColorChoice();
            flowLayoutPanel1.Controls.Add(cchoice);
 
        }

        private void Form1_ControlAdded(object sender, ControlEventArgs e)
        {
            flowLayoutPanel1.Controls.Add(e.Control);
            int index = flowLayoutPanel1.Controls.IndexOf(e.Control);
            if (e.Control.ToString() == "AmazeNote.Note")
            {
                flowLayoutPanel1.Controls.RemoveAt(index - 1);
            }
        }
    }
}
