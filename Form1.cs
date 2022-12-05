using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Victorina_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ReadToFile()
        {
            richTextBox1.LoadFile("Otveti.rtf");
        }

        private void buttonAnswers_Click(object sender, EventArgs e)
        {
            ReadToFile();
        }
    }
}
