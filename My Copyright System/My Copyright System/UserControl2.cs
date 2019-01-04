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
    public partial class UserControl2 : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Copyright Database.mdf;Integrated Security=True;Connect Timeout=30");
        public UserControl2()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [Author Table] (Name,FullAddress,Nationality,DateOfDecease,Pincode,PublishedUnpublished,ApplicationNumber) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','"+textBox12.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [Publisher Table] (Name,FullAddress,Nationality,country,Pincode,YearOfPublish,ApplicationNumber) values('" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox13.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            
        }
    }
}
