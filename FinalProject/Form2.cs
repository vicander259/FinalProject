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

        public static int wordCount = 0;
        int incorrectCount = 0;
        int correctCount = 0;
        int word1Length = Form1.word1.Length;
        string letterGuess;
        string word1 = Form1.word1.ToUpper();
        //make a list to add generated labels to so they can be found and accessed later
        List<Label> labels = new List<Label>();
       
        
        private void button2_Click(object sender, EventArgs e)
        {
            checkLetters();
            if (correctCount == word1Length)
            {
                label5.Text = "You Win!";
                button2.Enabled = false;
                textBox1.Enabled = false;
                wordCount++;
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
            //take the letters of a word and put them in an array, specifically the "Character" array
            char[] letters = word1.ToCharArray();
            
            //the formula for location of where the new labels appear
            int space = 200/letters.Length - 1;

            //for loop to create the same amount of labels as there are letters in the word
            for (int i = 0; i < letters.Length; i++)
            {
                //create the labels and add them to the list
                labels.Add(new Label());
                //location of the labels
                labels[i].Location = new Point((i * space) + 10, 109);
                //grouping of labels to make them show up together
                labels[i].Parent = groupBox1;
                //have the text of the labels show underscores to represent amount of letters
                labels[i].Text = "_";
                //bring the labels to the front of the groupBox
                labels[i].BringToFront();
                //create a control for each label so you can edit them in code
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
                //for loop to run through each label and check if it contains the letter that was guessed
                for (int j = 0; j < word1Length; j++)
                {
                    //checks to see if the letter guessed is anywhere in the word
                    if (word1[j].ToString() == letterGuess)
                    {
                        //changes the label containing the underscore to the letter that is in the word at that index
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
