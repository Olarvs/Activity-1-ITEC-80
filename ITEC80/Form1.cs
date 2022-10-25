using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEC80
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string result = "";

            result = txtFName.Text + " " + txtSec.Text;

            lblResult.Text = result;

            /* txtFili
             * txtMath
             * txtHisto
             * txtSci
             * txtEng
             */

            result = txtFName.Text + " " + txtSec.Text;

            float gpa = float.Parse(txtFili.Text) + float.Parse(txtMath.Text) + float.Parse(txtHisto.Text) + float.Parse(txtSci.Text) + float.Parse(txtEng.Text);

            lblResult.Text = result;
            gpa /= 5;


            lblGPA.Text = "Your GPA is = " + gpa.ToString("0.00");

            MessageBox.Show("Hello" + result + "\n" + "Your GPA is " + gpa);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
    
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }
    }
}
