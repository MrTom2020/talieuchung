using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlynhatro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string chon;
            chon = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(chon);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
