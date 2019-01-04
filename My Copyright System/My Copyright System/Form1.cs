using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace My_Copyright_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label2.Visible = true;
            label3.Visible = true;
            loginusername.Visible = true;
            loginpassword.Visible = true;
            loginsubmit.Visible = true;
            button1.Visible = false;
            label4.Visible = true;
        }


        private void loginsubmit_Click(object sender, EventArgs e)
        {
            string username = ConfigurationManager.AppSettings.Get("rpcusername");
            string password = ConfigurationManager.AppSettings.Get("rpcpassword");
            string wallet_url = ConfigurationManager.AppSettings.Get("wallet_url");
            string wallet_port = ConfigurationManager.AppSettings.Get("wallet_port");


            if ((loginusername.Text == "") || (loginpassword.Text == ""))
            {
                MessageBox.Show("FILL UP ALL THE CREDENTIALS !!");
            }
            else if ((loginusername.Text == username) && (loginpassword.Text == password))
            {
                Form3 det = new Form3();
                det.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("INVALID USER CREDENTIALS !!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
