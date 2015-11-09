using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string word1, word2, word3, word4;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            word1 = textBox1.Text;
            word2 = textBox2.Text;
            word3 = textBox3.Text;
            word4 = textBox4.Text;
            Form2 myForm = new Form2();
            myForm.Show();
            this.Hide();
        }
    }
}
