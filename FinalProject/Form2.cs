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
             
        private void button1_Click(object sender, EventArgs e)
        {
            string word1 = Form1.word1;
            int word1Length = word1.Length;
            label3.Text = word1Length.ToString();
        }
    }
}
