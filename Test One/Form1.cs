﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_One
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

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(textBox1.Text);
            int number2 = int.Parse(textBox2.Text);
            string operation = textBox3.Text;
            double answer;

            switch (operation)
            {
                case "+":
                    {
                        answer = number1 + number2;
                        textBox4.Text = answer.ToString();
                        break;       
                    }

                case "-":
                    {
                        answer = number1 - number2;
                        textBox4.Text = answer.ToString();
                        break;
                    }

                case "*":
                    {
                        answer = number1 * number2;
                        textBox4.Text = answer.ToString();
                        break;
                    }

                case "/":
                    {
                        answer = number1 / number2;
                        textBox4.Text = answer.ToString();
                        break;
                    }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
