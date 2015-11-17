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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public static int wordCount;
        int correctCount = 0;
        int count = 0;
        int word4Length = Form1.word4.Length;
        string letterGuess;
        string word4 = Form1.word4.ToUpper();
        List<Label> labels = new List<Label>();

        private void button2_Click(object sender, EventArgs e)
        {
            checkLetters();
            if (correctCount == word4Length)
            {
                label5.Text = "You Win!";
                button2.Enabled = false;
                textBox1.Enabled = false;
                wordCount++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            makeLabels();
            label4.Text = word4Length.ToString();
            wordCount = Form4.wordCount;
        }

        public void makeLabels()
        {

            word4 = word4.ToUpper();
            word4.Replace(" ", "");

            char[] letters = word4.ToCharArray();
            int space = 200 / letters.Length - 1;

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

        public void checkLetters()
        {
            letterGuess = textBox1.Text.ToUpper();


            if (listBox1.Items.Contains(letterGuess) == true)
            {
                MessageBox.Show("you already picked that letter");
            }
            else
            {
                listBox1.Items.Add(letterGuess);
            }

            if (word4.Contains(letterGuess))
            {
                for (int j = 0; j < word4Length; j++)
                {
                    if (word4[j].ToString() == letterGuess)
                    {
                        labels[j].Text = word4[j].ToString();
                        correctCount += 1; 
                    }
                }

            }
            else if (word4.Contains(letterGuess) == false)
            {
                count++;
                MessageBox.Show("That letter is not in the word");
            }

            if (count == 1)
            {
                pictureBox2.Visible = true;
            }
            else if (count == 2)
            {
                pictureBox3.Visible = true;
            }
            else if (count == 3)
            {
                pictureBox4.Visible = true;
            }
            else if (count == 4)
            {
                pictureBox5.Visible = true;
            }
            else if (count == 5)
            {
                pictureBox6.Visible = true;
            }
            else if (count == 6)
            {
                pictureBox7.Visible = true;
                MessageBox.Show("You lose");
                button2.Enabled = false;
                textBox1.Enabled = false;
                label5.Text = word4;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 myForm = new Form6();
            myForm.Show();
            this.Close();
        }
    }
}
