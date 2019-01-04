using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FloSDK.Exceptions;
using FloSDK.Methods;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System.Data.SqlClient;


namespace My_Copyright_System
{
    public partial class UserControl5 : UserControl
    {
        public string url = "https://testnet.flocha.in/tx/";
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Copyright Database.mdf;Integrated Security=True;Connect Timeout=30");
        public UserControl5()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [Short Details Table] (ApplicationNumber,Title,CopyrightDate,AuthorName,StatementOfRight) values('" + textBox11.Text + "','" + titlebox.Text + "','" + dateTimePicker1.Text + "','" + namebox.Text + "','" + listBox1.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            string username = ConfigurationManager.AppSettings.Get("rpcusername");
            string password = ConfigurationManager.AppSettings.Get("rpcpassword");
            string wallet_url = ConfigurationManager.AppSettings.Get("wallet_url");
            string wallet_port = ConfigurationManager.AppSettings.Get("wallet_port");
            string flodata = "";
            RpcMethods rpc = new RpcMethods(username, password, wallet_url, wallet_port);

            try
            {
                string title = titlebox.Text;
                string date = dateTimePicker1.Text;
                string name = namebox.Text;
                string right = listBox1.Text;
                string send_to = "oYKg7fpcQs4DCmLSwqJvUFpnnXLdffGGkm";
               


                if ((titlebox.Text == "") || (dateTimePicker1.Text == "") || (namebox.Text == "") || (send_to == ""))
                {
                    MessageBox.Show("FILL UP ALL THE DETAILS");
                }
                else if ((listBox1.SelectedIndex == -1) || (listBox1.Text == "(none)"))
                {
                    MessageBox.Show("Select either one of the statement of rights\n scroll down and  CLICK on the options to select.");
                }
                else
                {


                    flodata = " \t" + title + "\n" + "copyright ©" + date + " " + name + " " + right;

                    JObject jobj = JObject.Parse(rpc.SendToAddress(send_to, 0.01M, "copyright system", "copyright", false, false, 1, "UNSET", flodata));

                    if (string.IsNullOrEmpty(jobj["error"].ToString()))
                    {
                        url += jobj["result"];
                        labelmsg.Text = "Details saved successfully to FLO";
                        labelmsg.Visible = true;
                        labelmsg.ForeColor = Color.White;
                        data.Text = flodata;
                        data.Visible = true;
                        data.ForeColor = Color.White;
                        linkLabel1.Visible = true;

                       
                    }
                    else
                    {
                        labelmsg.Text = "Error!!!" + "could not retrieve any transaction details..plzz check ur address";
                        labelmsg.Visible = true;
                        labelmsg.ForeColor = Color.Red;
                    }
                }

            }
            catch (RpcInternalServerErrorException ex)
            {
                var errCode = 0;
                var errMessage = string.Empty;
                if (ex.RpcErrorCode.GetHashCode() != 0)
                {
                    errCode = ex.RpcErrorCode.GetHashCode();
                    errMessage = ex.RpcErrorCode.ToString();
                }
                Console.WriteLine("Exception :" + errCode + "-" + errMessage);


                labelmsg.Text = "INternal server error!!";
                labelmsg.ForeColor = Color.Red;
                labelmsg.Visible = true;
                labelmsg.Visible = true;



            }
            catch (Exception ex1)
            {
                Console.WriteLine("Exception :" + ex1.ToString());
                labelmsg.Text = "Error connecting to the server!!";
                labelmsg.ForeColor = Color.White;
                labelmsg.Visible = true;
                labelmsg.Visible = true;
                MessageBox.Show(labelmsg.Text);
                MessageBox.Show(flodata);

            }
        }

        private void UserControl5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void titlebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
