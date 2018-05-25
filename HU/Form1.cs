using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Xml;
using System.Xml.Linq;

namespace HU
{
    public partial class Form1 : Form
    {

        string val1 = "";
        string val2 = "";
        string val3 = "";
        string val4 = "";
        string val5 = "";
        string usarItem;
        string usarQty;
    
        public Form1(string Item, string qty)
        {
            InitializeComponent();
            usarItem = Item;
            usarQty = qty;

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.primary.BackColor == Color.Green)

                this.primary.BackColor = Color.Red;
            else
                this.primary.BackColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.marking.BackColor == Color.Green)
                this.marking.BackColor = Color.Red;
            else
                this.marking.BackColor = Color.Green;
        }

        private void item(string arch) {
            string val = "";
            StreamReader archivo = File.OpenText(@"C:\Users\Jesy\Desktop\origen\" + arch);//save text file
            string line = null;
            int i = 1;
            while ((!archivo.EndOfStream)) {
                line = archivo.ReadLine();
                if (i == 11)
                {
                    val1 = line;

                }
                if (i == 15)
                {
                    val3 = line;
                }
                i++;
               
            }
            archivo.Close();
            report.Text += string.Concat(val1 + val3);

            //ADD ITEMS AT LIST
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            string[] items = new string[1];
            ListViewItem lv;
            items[0] = val1 + val3;
            lv = new ListViewItem(items);
            listView1.Items.Add(lv);
            // listView1.Focus();
            //revisar el evento para que pueda cambiar el status y las propiedades
            /*  for (int s = listView1.SelectedItems.Count - 1; s >= 0; s += -1) {
                  MessageBox.Show("Se selecciono un item");
              }*/



        }

        private void line(string arc)
        {

            StreamReader archivo = File.OpenText(@"C:\Users\Jesy\Desktop\origen\" + arc);//save text file

            string line = null;
            int i = 1;
            
            string val6 = "WAITING";

            string tmpex = "";
            string tmpul = "";
            int numv = 0;

            while ((!archivo.EndOfStream))
            {

                line = archivo.ReadLine();

                if (i == 1)
                {

                    val2 = line;
                    
                }

                if (i == 11)
                {
                    val1 = line;
                   
                }
                if (i == 15)
                {
                    val3 = line;
                }
                if (i == 3)
                {
                    val4 = line;
                }
                
                i++;
                
            }
            

            tmpex = ver();
            if (int.Parse(tmpex) == 0)
            {
                val5 = "118000000";
            }
            else
            {
                tmpul = ver1();
                numv = int.Parse(tmpul) + 1;
                val5 = numv.ToString();
            }
            archivo.Close();

            // info.Text = info.Text+string.Format("Information qty: {0} item: {1} ",val2,val1,Environment.NewLine);//colocar una nueva linea para mostrar la info
            info.Text += string.Concat("Item: " + val1 + val3, "\n", "Quantity: " + val2, "\n", "Color: " + val3, "\n", "HU: " + val5,"\n", "-----------------------------------------------------", "\n");
           
            // info.Text = val2 + val1 + val3 + val4 + val5;
            //  MessageBox.Show("Item: " + val1 + "\nQty: " + val2 + "\nlot: " + val4 + "\nColor: " + val3);
            insertbd(val1 + val3, val2, val4, val5,val6);
            item(arc);
            save(arc);
           
        }

        //insert specific data on DB
        private void insertbd(string var1, string var2, string var4, string var5, string var6)
        {
            string MyConnection2 = "server=localhost;uid=root;" +
           "pwd=;database=prueba;SslMode=none";

            //ya se inserta, pero son los numeros
            string Query = "insert into prueba.inicial(item,qty,lot,hu,status) values('" + var1 + "'," + "'" + var2 + "'," + "'" + var4 + "'," + "'" + var5 + "'," + "'" + var6 + "');";

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            MessageBox.Show("Save Data");
            while (MyReader2.Read())
            {
            }
            MyConn2.Close();
        }


        private string ver()
        {
            string exis = "";
            string MyConnection2 = "server=localhost;uid=root;" +
         "pwd=;database=prueba;SslMode=none";

            //ya se inserta, pero son los numeros
            string Query = "select * from prueba.existente";

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            while (MyReader2.Read())
            {
                exis = MyReader2["exis"].ToString();
            }
            MyConn2.Close();

            //MessageBox.Show(exis);

            return exis;

        }
        private string ver1()
        {
            string exis1 = "";
            string MyConnection2 = "server=localhost;uid=root;" +
         "pwd=;database=prueba;SslMode=none";

            //ya se inserta, pero son los numeros
            string Query = "select * from prueba.ultimo";

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            while (MyReader2.Read())
            {
                exis1 = MyReader2["ulval"].ToString();
            }
            MyConn2.Close();

            //MessageBox.Show(exis);

            return exis1;

        }

        //move file to other folder
        private void save(string archivo)
        {

            string sourceFile = @"C:\Users\Jesy\Desktop\origen\" + archivo;
            string destinationFile = @"C:\Users\Jesy\Desktop\archive\R" + archivo;

            // To move a file or folder to a new location:
            System.IO.File.Move(sourceFile, destinationFile);
            MessageBox.Show("Moved file");
           // upStatus();
        }

        //all the files are taken from the origin folder and send to different folder
        private void txt() { 
            string[] dirs = Directory.GetFiles(@"C:\Users\Jesy\Desktop\origen\", "*.txt");
            int cantidad = dirs.Length;
            string arch = "";

            if (cantidad != 0)
            {
                for (int h = 0; h < dirs.Length; h++)
                {
                    arch = dirs[h];
                    arch = arch.Replace(@"C:\Users\Jesy\Desktop\origen\", "");
                  //  info.Text = arch +"\n" + "File moved";
                    line(arch);
                    //MessageBox.Show(arch);
                }
            }

            
        }
    
        private void button2_Click_1(object sender, EventArgs e)
        {

            //line();        
            //  save();
            //information();
            //cantidadtxt();
            tiempo.Enabled = true;
            tiempo.Start();
           
            // info.Text += string.Concat("Item: " + val1 + val3, "\n", "Quantity: " + val2, "\n", "Color: " + val3, "\n", "HU: " + val5, "\n", "File name: ", info.Text, "\n", "-----------------------------------------------------", "\n", info.Text, "\n");
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            txt();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tiempo.Stop();
        }

        //status are updating by this method
        private void upStatusOK() {
            string status = "OK PRODUCTION";
            string status1 = "NOK PRODUCTION";
            string item = "";
            item = report.Text;
            // MessageBox.Show(item);
            if ((primary.BackColor.Equals(Color.Green)) && (marking.BackColor.Equals(Color.Green)) && (retraction.BackColor.Equals(Color.Green)) && (insulator.BackColor.Equals(Color.Green)) && (secondary.BackColor.Equals(Color.Green))) {
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
            else if((primary.BackColor.Equals(Color.Red)) || (marking.BackColor.Equals(Color.Red)) || (retraction.BackColor.Equals(Color.Red)) || (insulator.BackColor.Equals(Color.Red)) || (secondary.BackColor.Equals(Color.Red))) {
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
      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           /* if (this.primary.BackColor == Color.Green)

                this.primary.BackColor = Color.Red;
            else*/
                primary.BackColor = Color.Green;
        }

        private void retraction_Click(object sender, EventArgs e)
        {
           if (this.retraction.BackColor == Color.Green)

                this.retraction.BackColor = Color.Red;
            else
                retraction.BackColor = Color.Green;
        }

        private void insulator_DragOver(object sender, DragEventArgs e)
        {
          /*  if (this.insulator.BackColor == Color.Green)

                this.insulator.BackColor = Color.Red;
            else*/
                insulator.BackColor = Color.Green;
        }

        private void secondary_Click(object sender, EventArgs e)
        {
           if (this.secondary.BackColor == Color.Green)

                this.secondary.BackColor = Color.Red;
            else
                secondary.BackColor = Color.Green;
        }

        private void marking_Click(object sender, EventArgs e)
        {
            if (this.marking.BackColor == Color.Green)

                this.marking.BackColor = Color.Red;
            else
                marking.BackColor = Color.Green;
        }

        private void insulator_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            
        }

        private void insulator_Click(object sender, EventArgs e)
        {
           if (this.insulator.BackColor == Color.Green)

                this.insulator.BackColor = Color.Red;
            else
                insulator.BackColor = Color.Green;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            upStatusOK();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            /*updatee u = new updatee();
            u.Show();*/
             WriteXML();
          //  conXML();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
                ListView.SelectedListViewItemCollection items = this.listView1.SelectedItems;
                foreach (ListViewItem iitem in items)
                {
                   

                string j;
                j = iitem.ToString();
                MessageBox.Show("Seleccionaste el item: " + j);

                string status = "OK PRODUCTION";
                string status1 = "NOK PRODUCTION";
                string item = "";
                item = report.Text;
                // MessageBox.Show(item);
                if ((primary.BackColor.Equals(Color.Green)) && (marking.BackColor.Equals(Color.Green)) && (retraction.BackColor.Equals(Color.Green)) && (insulator.BackColor.Equals(Color.Green)) && (secondary.BackColor.Equals(Color.Green)))
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
                    catch (Exception ex) { MessageBox.Show("Error en..." + ex); }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void spinning_Click(object sender, EventArgs e)
        {
            if (this.spinning.BackColor == Color.Green)
                this.spinning.BackColor = Color.Red;
            else
                this.spinning.BackColor = Color.Green;
        }
        public class Book {
            public String title;
            public String body;
            public String Label;
            public String ApplicationArea;
            public String Sender;
            public String LogicalID;
            public String ComponentID;
            public String ConfirmationCode;
            public String CreationDateTime;
            public String BODID;
            public String DataArea;
            public String Sync;
            public String TenantID;
            public String AccountingEntityID;
            public String LocationID;
            public String ActionCriteria;
            public String ActionExpression_actionCode;
            public String MESInterface;
            public String MESHeader;
            public String MESOrderNo;
            public String Item;
            public String MESCompletion;
            public String Spool;
            public String Date;
            public String LotNumber;
            public String Warehouse;
            public String Quantity;


          }
          public  void WriteXML() {     
           // Form1 ff = new Form1("");
            Form2 ff2 = new Form2();
            Book overview = new Book();
              overview.title = "XML prueba";
            overview.ApplicationArea="";
            overview.Sender = "";
            overview.LogicalID = "lid://infor.file.bod_in";
            overview.ComponentID = "file";
            overview.ConfirmationCode = "OnError";
            overview.CreationDateTime = DateTime.Now.ToString("yyyy-MM-ddThh:mm:ssZ"); //si se requiere mas la la z al final poner u,s
            overview.BODID = "infor-nid:infor:640:S_640:A99000001:?MESInterface&verb=Sync";
            overview.DataArea = "";
            overview.Sync = "";
            overview.TenantID = "infor";
            overview.AccountingEntityID = "640";//Leon indicators
            overview.LocationID = "S_640";//Leon indicators
            overview.ActionCriteria = "";
            overview.ActionExpression_actionCode = "Add";
            overview.MESInterface = "";
            overview.MESHeader = "\n"+"\n";
            //------------------------------DYNAMIC INFORMATION FROM MACHINES--------------------------------
            overview.MESOrderNo = "DVR01"+ DateTime.Now.ToString("yyMMddhhmmssfff");//cambiar dependiendo si el txt tiene la informacion referente a la maquina DVR01, DVR02...
            overview.Item = usarItem.ToString(); //valores del constructor de la clase Form2
            overview.MESCompletion = "";
            overview.Spool = ff2.ver1();//ultimo numero almacenado en db 
            overview.Date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"); ;//cambiar por valor de linea
            overview.LotNumber = ff2.ver1();//cambiar por valor del txt que viene de la maquina
            overview.Warehouse = "LHBFG1";
            overview.Quantity = usarQty.ToString();   //modificar con la cantidad del txt
            //------------------------------------------------------------------------------------------------
              System.Xml.Serialization.XmlSerializer writer =
                  new System.Xml.Serialization.XmlSerializer(typeof(Book));

              var path = @"C:\Users\Jesy\Desktop\" + "XMLPrueba.xml";
              System.IO.FileStream file = System.IO.File.Create(path);
              writer.Serialize(file, overview);
            MessageBox.Show("XML SUCCESFUL");
          file.Close();
            //return exis;
        }
        public void conXML(string archivo)
        {
            var txt = string.Empty;           
                //Metodo tiene que aplicarse antes de que se mueva el archivo de carpeta para poder convertirlo en XML

                //agregar el archivo que se está leyendo en forma dinamica
                using (var stream = File.OpenText(@"C:\Users\Jesy\Desktop\origen\" + archivo))
                {
                    txt = stream.ReadToEnd();
                }

                var xml = new XDocument(
      new XElement("Data",
          new XElement("Info", txt)));
                //falta agregar el nombre dinámico para el archivo
                xml.Save(Path.ChangeExtension(@"C:\Users\Jesy\Desktop\archive\", "PRUEBAXML.xml"));
                MessageBox.Show("Se generó el archivo con éxito");
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            upStatusOK();
        }
    }
}
