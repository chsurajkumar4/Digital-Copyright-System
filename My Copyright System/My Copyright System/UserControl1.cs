using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace My_Copyright_System
{
    public partial class UserControl1 : UserControl
    {   SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Copyright Database.mdf;Integrated Security=True;Connect Timeout=30");
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [Applicant and Product details Table] (appNumber,Applicantcategory,ApplicantName,ApplicantAddress,Nationality,Pincode,NatureofApplicantsinterestincopyrightofwork,ClassofWork,DescriptionofWork,TitleofWork,LanguageofWork) values('"+textBox11.Text+"','"+ textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
        }
    }
}
