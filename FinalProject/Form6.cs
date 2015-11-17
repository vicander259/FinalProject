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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        public static int wordCount;

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            wordCount = Form5.wordCount;
            if (wordCount == 0)
            {
                pictureBox1.Image = Properties.Resources.tooBad;
                label1.Text = "Too bad, you got 0 words right.";
                
            }

            else if (wordCount == 1)
            {
                pictureBox1.Image = Properties.Resources.niceWork;
                label1.Text = "Nice work, you got 1 word right!";
            }

            else if (wordCount == 2)
            {
                pictureBox1.Image = Properties.Resources.goodJob;
                label1.Text = "Good job, you got 2 words right!";
            }

            else if (wordCount == 3)
            {
                pictureBox1.Image = Properties.Resources.closeWork;
                label1.Text = "Almost perfect! You got 3 words right!";
            }

            else if (wordCount == 4)
            {
                pictureBox1.Image = Properties.Resources.awesomeJob;
                label1.Text = "You are a master guesser, you got all 4 words right!";
            }
        }
    }
}
