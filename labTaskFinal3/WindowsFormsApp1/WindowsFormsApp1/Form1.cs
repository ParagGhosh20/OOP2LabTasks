﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        /*public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void AppearReg(object sender, EventArgs e)
        {
            new Registration().Show();
        }*/

        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Authinticate(object sender, EventArgs e)
        {
            string name = " ";
            string password = " ";
            string errMsg = " ";
            bool hasError = false;
            if(textBoxUsername.Text.Equals (" "))
            {
                errMsg += "User nme required \n";
                hasError = true;
            }
            else
            {
                name = textBoxUsername.Text;
            }
            if (textboxPassword.Text.Equals(" "))
            {
                errMsg += "Password required \n";
                hasError = true;
            }
            else
            {
                password = textboxPassword.Text;
            }
            if (!hasError)
            {

            }
        }
    }
}
