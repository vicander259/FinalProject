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

        private void button1_Click(object sender, EventArgs e)
        {
            //string word1 = Form1.word1;
            //int word1Length = word1.Length;
            label3.Text = word1Length.ToString();
            AddLabels();
        }

        public void AddLabels()
        {
            
            for (int i = 0; i < word1Length; i++)
            {
                //Create label
                Label label = new Label();
                label.Text = String.Format("Label {0}", i);
                //Position label on screen
                label.Left = (i + 20) * 20;
                label.Top = 413;
                //Add controls to form
                this.Controls.Add(label);
               
            }

            /* Label label15 = new Label();

             // Initialize the controls and their bounds.
             label15.Text = "Text";
             label15.Location = new Point(520, 350);
             label15.Size = new Size(104, 16);
             label15.Visible = true;

             // Add the Label control to the form's control collection.
             Controls.Add(label15); */
        }
    }
}
