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
    public partial class NoteItem : UserControl
    {
        public NoteItem(string text)
        {
            InitializeComponent();
            label1.Text = text;
        }

        private void NoteItem_Load(object sender, EventArgs e)
        {

        }
    }
}
