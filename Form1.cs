using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_103022300048
{
    public partial class Form1 : Form
    {
        int angka = 0, summ = 0;
        bool duaDigit = false;
        string clickTambah = "";
        string result = "";
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)

        {
            summ += angka;
            clickTambah += angka;
            labelOutput.Text = clickTambah;
            angka = 0;
            duaDigit = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            summ += angka;
            clickTambah += angka;
            labelOutput.Text = clickTambah;
            result += "" + summ;
            labelOutput.Text = result;
            summ = 0;
            angka = 0;
            duaDigit = false;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (!duaDigit)
            {
                angka = 0;
                duaDigit = true;
            }
            else
            {
                angka = (angka * 10);
            }
        }

        private void btnSamaDengan_Click(object sender, EventArgs e)
        {
            
           
            {

            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (!duaDigit)
            {
                angka = 1;
                duaDigit = true;
            } else
            {
                angka = (angka * 10) + 1;   
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (!duaDigit)
            {
                angka = 2;
                duaDigit = true;
            }
            else
            {
                angka = (angka * 10) + 2;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (!duaDigit)
            {
                angka = 3;
                duaDigit = true;
            }
            else
            {
                angka = (angka * 10) + 3;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (!duaDigit)
            {
                angka = 4;
                duaDigit = true;
            }
            else
            {
                angka = (angka * 10) + 4;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (!duaDigit)
            {
                angka = 5;
                duaDigit = true;
            }
            else
            {
                angka = (angka * 10) + 5;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (!duaDigit)
            {
                angka = 6;
                duaDigit = true;
            }
            else
            {
                angka = (angka * 10) + 6;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (!duaDigit)
            {
                angka = 7;
                duaDigit = true;
            }
            else
            {
                angka = (angka * 10) + 7;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (!duaDigit)
            {
                angka = 8;
                duaDigit = true;
            }
            else
            {
                angka = (angka * 10) + 8;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (!duaDigit)
            {
                angka = 9;
                duaDigit = true;
            }
            else
            {
                angka = (angka * 10) + 9;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
