using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rndmkullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rast= new Random();
            int s1, s2, s3, s4;
            s1= rast.Next(1,10);
            s2= rast.Next(1,10);
            s3= rast.Next(1,10);
            s4= rast.Next(1,10);
            label1.Text = s1.ToString();
            label2.Text = s2.ToString();
            label3.Text = s3.ToString();
            label4.Text = s4.ToString();
            if(textBox1.Text == label1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor= Color.Red;
            }
            //s2 için
            if (textBox2.Text == label2.Text)
            { 
             textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
            //s3 için
            if (textBox3.Text == label3.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }
            //s4 için
            if (textBox4.Text == label4.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
