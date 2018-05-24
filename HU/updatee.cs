using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HU
{
    public partial class updatee : Form
    {
        public updatee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
        }



        private void upStatusOK()
        {
            string status = "OK PRODUCTION";
            string status1 = "NOK PRODUCTION";
            string item = report.Text;
            MessageBox.Show(item);
            if (button1.BackColor.Equals(Color.Green))
            {
                try
                {
                    string conn = "server=localhost;uid=root;" +
               "pwd=;database=prueba;SslMode=none";
                    string qry = "update prueba.inicial set status='" + status + "' where item= '" + item + "';";

                    MySqlConnection con = new MySqlConnection(conn);
                    MySqlCommand com = new MySqlCommand(qry, con);
                    MySqlDataReader read;
                    con.Open();
                    read = com.ExecuteReader();
                    MessageBox.Show("Data updated");
                    while (read.Read()) { }
                    con.Close();

                }
                catch (Exception e) { }
            }
            //STATUS NOK
            else if (button1.BackColor.Equals(Color.Red))
            {
                try
                {
                    string conn = "server=localhost;uid=root;" +
              "pwd=;database=prueba;SslMode=none";
                    string qry = "update prueba.inicial set status='" + status1 + "' where item= '" + item + "';";
                    MySqlConnection con = new MySqlConnection(conn);
                    MySqlCommand com = new MySqlCommand(qry, con);
                    MySqlDataReader read;
                    con.Open();
                    read = com.ExecuteReader();
                    MessageBox.Show("Data updated");
                    while (read.Read()) { }
                    con.Close();

                }
                catch (Exception ex) { MessageBox.Show("Error... " + "\n" + ex); }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            upStatusOK();
        }
    }
}
