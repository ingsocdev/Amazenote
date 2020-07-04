using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazeNote
{
    public partial class AddNote : Form
    {
        string text;
        public AddNote()
        {
            InitializeComponent();
        }
        public string sendback()
        {
            return text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            text = textBox1.Text.ToString();
            sendback();
            this.Close();
        }

        private void AddNote_Load(object sender, EventArgs e)
        {

        }
    }
}
