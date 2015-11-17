﻿using System;
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

        int incorrectCount = 0;
        int correctCount = 0;
        int word1Length = Form1.word1.Length;
       //string blankLetters;
        string letterGuess;
        string word1 = Form1.word1.ToUpper();
        List<Label> labels = new List<Label>();
       
        
        private void button2_Click(object sender, EventArgs e)
        {
            checkLetters();
            if (correctCount == word1Length)
            {
                label5.Text = "You Win!";
                button2.Enabled = false;
                textBox1.Enabled = false;
            }
        }
           
               
        private void Form2_Load(object sender, EventArgs e)
        {
            makeLabels();
            label4.Text = word1Length.ToString();
        }
                      
        public void makeLabels()
        {
            
            word1 = word1.ToUpper();
            word1.Replace(" ", "");

            char[] letters = word1.ToCharArray();
            int space = 200/ letters.Length - 1;

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

            if (word1.Contains(letterGuess))
            {
                for (int j = 0; j < word1Length; j++)
                {
                    if (word1[j].ToString() == letterGuess)
                    {
                        labels[j].Text = word1[j].ToString();
                        correctCount += 1;
                    }
                }
                                         
            }
              else if (word1.Contains(letterGuess) == false)
            {
                incorrectCount++;
                MessageBox.Show("That letter is not in the word");                               
            }

            if (incorrectCount == 1)
            {
                pictureBox2.Visible = true;
            }
            else if (incorrectCount == 2)
            {
                pictureBox3.Visible = true;
            }
            else if (incorrectCount == 3)
            {
                pictureBox4.Visible = true;
            }
            else if (incorrectCount == 4)
            {
                pictureBox5.Visible = true;
            }
            else if (incorrectCount == 5)
            {
                pictureBox6.Visible = true;
            }
            else if (incorrectCount == 6)
            {
                pictureBox7.Visible = true;
                MessageBox.Show("You lose");
                button2.Enabled = false;
                textBox1.Enabled = false;
                label5.Text = word1;
            } 
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 myForm = new Form3();
            myForm.Show();
            this.Close();
        }
    }
}
