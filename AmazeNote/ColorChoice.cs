using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazeNote
{
    public partial class ColorChoice : UserControl
    {
        int selectedColor;
        public ColorChoice()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            label2.Text = ("Title: "+ NoteTitleText.Text.ToString() + " Color: " +  panel1.BackColor.Name.ToString());
            selectedColor = panel1.BackColor.ToArgb();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            label2.Text = ("Title: "+ NoteTitleText.Text.ToString() + " Color: " + panel2.BackColor.Name.ToString());
            selectedColor = panel2.BackColor.ToArgb();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            label2.Text = ("Title: "+ NoteTitleText.Text.ToString() + " Color: " + panel3.BackColor.Name.ToString());
            selectedColor = panel3.BackColor.ToArgb();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            label2.Text = ("Title: "+ NoteTitleText.Text.ToString() + " Color: " + panel4.BackColor.Name.ToString());
            selectedColor = panel4.BackColor.ToArgb();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            label2.Text = ("Title: "+ NoteTitleText.Text.ToString() + " Color: " + panel5.BackColor.Name.ToString());
            selectedColor = panel5.BackColor.ToArgb();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            label2.Text = ("Title: "+ NoteTitleText.Text.ToString() + " Color: " + panel6.BackColor.Name.ToString());
            selectedColor = panel6.BackColor.ToArgb();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OkBtn_Click(object sender, EventArgs e)
        {

            if (NoteTitleText.Text != "")
            {
                Note note = new Note(selectedColor, NoteTitleText.Text);
                Form1.ActiveForm.Controls.Add(note);
            }
        }


    }
}
