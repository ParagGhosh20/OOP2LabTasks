using System;
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
    public partial class regestartion : Form
    {
        public regestartion()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void regestartion_Load(object sender, EventArgs e)
        {

        }

        private void BtnClicked(object sender, EventArgs e)
        {
            string name = textUaerName.Text;
            string lastAddress = textLastAdd.Text;
            string email = textUaerName.Text;
            string reTypeEmail = textLastAdd.Text;
            string password = textPassword.Text;
            string reTypePassword = textRtPassword.Text;
            string securityAnswe = textAnswer.Text;
            string address = textAddress.Text;
            string city = textCity.Text;
            string mobile = textMobileNo.Text;
            string phone = textPhoneNo.Text;
            string mobile2 = textMobile2.Text;
            string gender = comboBoxGender.SelectedItem.ToString();
            string selectedQuestion = comboxSq.SelectedItem.ToString();
            string zipCode = comBoxZip.SelectedItem.ToString();


            

            string output = string.Format("Name:{0} " +
                "\n LastAddress:{1} " +
                "\n Email:{2} " +
                "\n reTypeEmail:{3} " +
                "\n password:{4}" +
                "\n reTypePassword:{5}" +
                "\n securityAnswe:{6}" +
                "\n address:{7}" +
                " \n city:{8}" +
                " \n mobile:{9}" +
                " \n mobile:{10}" +
                " \n phone:{11} " +
                "\n mobile2:{12} " +
                " \n gender : {13} " +
                "\n selectedQuestion : {14} " +
                "\n zipCode : {15}", name ,lastAddress ,email ,reTypeEmail ,password, reTypePassword, securityAnswe ,address , city, mobile ,phone ,mobile2, gender, selectedQuestion, zipCode);
            

           rTOutput.Text = output;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
