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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z;
        int word1Length = Form1.word1.Length;
        string blank;

        private void Form2_Load(object sender, EventArgs e)
        {
            string word1 = Form1.word1;
            word1 = word1.ToUpper();
            label3.Text = word1; //word1Length.ToString();
            AddLabels();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            /* string word1 = Form1.word1;
             word1 = word1.ToUpper();
             label3.Text = word1; //word1Length.ToString();
             AddLabels(); */
        }

        public void AddLabels()
        {

            for (int i = 0; i < word1Length; i++)
            {
                blank += " - ";
            }
            label4.Text = blank;
        }

        public void CheckLetters()
        {

        }
    }
}
