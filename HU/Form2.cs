﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HU
{
    public partial class Form2 : Form
    {
        string val1 = "";
        string val2 = "";
        string val3 = "";
        string val4 = "";
        string val5 = "";
        public string Item = "";
        public string qty = "";
      //  Form1 ff1 = new Form1("");
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.primary.BackColor == Color.Green)
                this.primary.BackColor = Color.Red;
            else
                this.primary.BackColor = Color.Green;
        }

        private void marking_Click(object sender, EventArgs e)
        {
            if (this.marking.BackColor == Color.Green)
                this.marking.BackColor = Color.Red;
            else
                this.marking.BackColor = Color.Green;
        }

        private void retraction_Click(object sender, EventArgs e)
        {
            if (this.retraction.BackColor == Color.Green)
                this.retraction.BackColor = Color.Red;
            else
                this.retraction.BackColor = Color.Green;
        }

        private void insulator_Click(object sender, EventArgs e)
        {
            if (this.insulator.BackColor == Color.Green)
                this.insulator.BackColor = Color.Red;
            else
                this.insulator.BackColor = Color.Green;
        }

        private void secondary_Click(object sender, EventArgs e)
        {
            if (this.secondary.BackColor == Color.Green)
                this.secondary.BackColor = Color.Red;
            else
                this.secondary.BackColor = Color.Green;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //al seleccionar algún elemento de la lista es necesario que se despliegue la información en la parte de info y esa información
            //pasarla al otro form al info al igual que el item a la lista para la evaluación final del manager; 
            ListView.SelectedListViewItemCollection items = this.listView1.SelectedItems;
            foreach (ListViewItem iitem in items) {
                string j;
                j = iitem.ToString();
                MessageBox.Show("Seleccionaste el item: "+ j);
                string status = "OK PRODUCTION";
                string status1 = "NOK PRODUCTION";
                string item = "";
                item = report.Text;
                if ((primary.BackColor.Equals(Color.Green))&&(marking.BackColor.Equals(Color.Green))&& (retraction.BackColor.Equals(Color.Green)) && (insulator.BackColor.Equals(Color.Green)) && (secondary.BackColor.Equals(Color.Green))&&(spinning.BackColor.Equals(Color.Green))) {
                    try {
                        string conn = "server=localhost;uid=root;" +
                            "pwd=;database=prueba;SslMode=none";
                        string qry = "update prueba.inicial set status='" + status + "' where item= '" + item + "';";

                        MySqlConnection con = new MySqlConnection(conn);
                        MySqlCommand com = new MySqlCommand(qry,con);
                        MySqlDataReader read;
                        con.Open();
                        read = com.ExecuteReader();
                        MessageBox.Show("Data updated");
                        while (read.Read()) { }
                        con.Close();
                    }
                    catch (Exception ex) { MessageBox.Show("Error en..." + ex); }
                }
            }
        }

        private void spinning_Click(object sender, EventArgs e)
        {
            if (this.spinning.BackColor == Color.Green)
                this.spinning.BackColor = Color.Red;
            else
                this.spinning.BackColor = Color.Green;
        }
        private void upStatusOK() {
            string status = "OK PRODUCTION";
            string status1 = "NOK PRODUCTION";
            string item = report.Text;
            if ((primary.BackColor.Equals(Color.Green)) && (marking.BackColor.Equals(Color.Green)) && (retraction.BackColor.Equals(Color.Green)) && (insulator.BackColor.Equals(Color.Green)) && (secondary.BackColor.Equals(Color.Green)) && (spinning.BackColor.Equals(Color.Green))) {
                try {
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
                catch (Exception e) { MessageBox.Show("Error en... " + e); }
            }
            //STATUS NOK
            else if ((primary.BackColor.Equals(Color.Red)) || (marking.BackColor.Equals(Color.Red)) || (retraction.BackColor.Equals(Color.Red)) || (insulator.BackColor.Equals(Color.Red)) || (secondary.BackColor.Equals(Color.Red)) || (spinning.BackColor.Equals(Color.Red))) {
                try {
                    string conn = "server=localhost;uid=root;" +
                        "pwd=;database=prueba;SslMode=none";
                    string qry = "update prueba.inicial set status='" + status1 + "' where item= '" + item + "';";
                    MySqlConnection con = new MySqlConnection(conn);
                    MySqlCommand com = new MySqlCommand(qry,con);
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
        public void item(string arch) {
            string val = "";
            string item;
            StreamReader archivo = File.OpenText(@"C:\Users\Jesy\Desktop\origen\" + arch);
            string line = null;
            int i = 1;
            while ((!archivo.EndOfStream)) {
                line = archivo.ReadLine();
                if (i==11) { val1 = line; }
                if (i==15) { val3 = line; }
                i++;
            }
            archivo.Close();
            report.Text += string.Concat(val1+val3);

            //ADD ITEMS AT LIST
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            string[] items = new string[1];
            ListViewItem lv;
            items[0] = val1 + val3;
            lv = new ListViewItem(items);
            listView1.Items.Add(lv);
        }

        public void line(string arc) {
            StreamReader archivo = File.OpenText(@"C:\Users\Jesy\Desktop\origen\" + arc);
            string line = null;
            int i = 1;

            string val6 = "WAITING";
            string tmpex = "";
            string tmpul = "";
            int numv = 0;
            while ((!archivo.EndOfStream)) {
                line = archivo.ReadLine();
                if (i==1) { val2 = line; }
                if (i==11) { val1 = line; }
                if (i==15) { val3 = line; }
                if (i==3) { val4 = line; }
                i++;
            }
            tmpex = ver();
            if (int.Parse(tmpex) == 0) { val5 = "118000000"; }
            else {
                tmpul = ver1();
                numv = int.Parse(tmpul)+1;
                val5 = numv.ToString();
            }
            Item = val1 + val3;
            qty = val2;
            archivo.Close();
            info.Text +=string.Concat("Item: "+Item, "\n","Quantity: "+val2, "\n","Color: " +val3,"\n", "HU: "+val5,"\n", "-----------------------------------------------------","\n");
            insertbd(val1+val3,val2,val4,val5,val6);
            item(arc);
            save(arc);
            
        }
        //insert db
        private void insertbd(string var1, string var2, string var4, string var5, string var6) {
            string MyConnection2 = "server=localhost;uid=root;" +
                "pwd=;database=prueba;SslMode=none";
            string Query = "insert into prueba.inicial(item,qty,lot,hu,status) values ('" + var1 + "',"+ "'"+ var2 + "', " + "'"+ var4 + "', "+ "'"+var5+"',"+"'"+var6+"');";

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            MessageBox.Show("Save Data");
            while (MyReader2.Read()) { }
            MyConn2.Close();
            
        }
        private string ver() {
            string exis = "";
            string MyConnection2 = "server=localhost;uid=root;" +
                "pwd=;database=prueba;SslMode=none";
            string Query = "select * from prueba.existente";

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query,MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            while (MyReader2.Read()) {
                exis = MyReader2["exis"].ToString();
            }
            MyConn2.Close();
            return exis;
        }
        public string ver1() {
            string exis1 = "";
            string MyConnection2 = "server=localhost;uid=root;" +
                "pwd=;database=prueba;SslMode=none";
            string Query = "select * from prueba.ultimo";

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query,MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            while (MyReader2.Read()) {
                exis1 = MyReader2["ulval"].ToString();
            }
            MyConn2.Close();
            return exis1;
        }

        //Move file to other folder
        private void save(string archivo) {
            string sourceFile = @"C:\Users\Jesy\Desktop\origen\" + archivo;
            string destinationFile = @"C:\Users\Jesy\Desktop\archive\R" + archivo;

            //To ove a file or folder to a new location
            System.IO.File.Move(sourceFile,destinationFile);
            MessageBox.Show("Moved file");
        }
        public void TEXT() {
            //para buscar los txt en la carpeta origen y almacenarlos en una variable
            string[] dirs = Directory.GetFiles(@"C:\Users\Jesy\Desktop\origen\", "*.txt");
            int cantidad = dirs.Length;
            string arch = "";

            if (cantidad !=0) {
                for (int h=0;h<dirs.Length;h++) {
                    arch = dirs[h];
                    arch = arch.Replace(@"C:\Users\Jesy\Desktop\origen\", "");
                    //está con la condicion de for, checar si es posible meter un while para que se vayan creando los archivos
                    //ff1.conXML(arch);
                    line(arch);
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tiempo.Enabled = true;
            tiempo.Start();

        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            TEXT();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tiempo.Stop();
            Form1 man = new Form1(Item, qty);
           
            //se puede poner con un .text?
           // man.listView1 = listView1.Items;
            man.info.Text = info.Text;
            man.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            upStatusOK();
        }
    }
}
