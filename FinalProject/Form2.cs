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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        int word1Length = Form1.word1.Length;
        string blankLetters;
        string letterGuess;
        List<Label> labels = new List<Label>();

        private void button2_Click(object sender, EventArgs e)
        {
            letterGuess = textBox1.Text;
        }
           
               
        private void Form2_Load(object sender, EventArgs e)
        {
            makeLabels();
            /* string word1 = Form1.word1;
             word1 = word1.ToUpper();
             label3.Text = word1; //word1Length.ToString();
             AddLabels();/
             */
        }
                

        public void AddLabels()
        {
            for (int i = 0; i < word1Length; i++)
            {
                blankLetters += " - ";
            }
            label4.Text = blankLetters;
        }

        private void makeLabels()
        {
            string word1 = Form1.word1;
            word1 = word1.ToUpper();
            word1.Replace(" ", "");

            char[] letters = word1.ToCharArray();
            int space = 110/ letters.Length - 1;

            for (int i = 0; i < letters.Length; i++)
            {
                labels.Add(new Label());
                labels[i].Location = new Point((i * space) + 10, 109);
                labels[i].Parent = groupBox1;
                labels[i].Text = "_";
                labels[i].BringToFront();
                labels[i].CreateControl();
            }            
        }
    }
}
