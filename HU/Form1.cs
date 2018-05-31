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
        string val7 = "";
        string val8 = "";
        string val9 = "";
        string usarItem;
        string usarQty;
        string usarLot;

        public Form1(string Item, string qty, string lot)
        {
            InitializeComponent();
            usarItem = Item;
            usarQty = qty;
            usarLot = lot;

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

        private void item(string arch)
        {
            string val = "";
            StreamReader archivo = File.OpenText(@"C:\Users\Jesy\Desktop\origen\" + arch);//save text file
            string line = null;
            int i = 1;
            while ((!archivo.EndOfStream))
            {
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
                if (i == 7)
                {
                    val7 = line;
                }
                if (i == 8)
                {
                    val9 = line;
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
            info.Text += string.Concat("Item: " + val1 + val3, "\n", "Quantity: " + val2, "\n", "Color: " + val3, "\n", "HU: " + val5, "Type: " + val7, "\n", "-----------------------------------------------------", "\n");

            // info.Text = val2 + val1 + val3 + val4 + val5;
            //  MessageBox.Show("Item: " + val1 + "\nQty: " + val2 + "\nlot: " + val4 + "\nColor: " + val3);
            insertbd(val1 + val3, val2, val4, val5, val6, val7 + "" + val9);
            item(arc);
            save(arc);

        }

        //insert specific data on DB
        private void insertbd(string var1, string var2, string var4, string var5, string var6, string var7)
        {
            string MyConnection2 = "server=localhost;uid=root;" +
           "pwd=;database=prueba;SslMode=none";

            //ya se inserta, pero son los numeros
            string Query = "insert into prueba.inicial(item,qty,lot,hu,status) values('" + var1 + "'," + "'" + var2 + "'," + "'" + var4 + "'," + "'" + var5 + "'," + "'" + var6 + "'," + "'" + var7 + "');";

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
        private void txt()
        {
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
        private void upStatusOK()
        {
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
                    while (read.Read()) { }//ciclo para validar los iems? 
                    con.Close();

                }
                catch (Exception e) { }
            }
            //STATUS NOK
            else if ((primary.BackColor.Equals(Color.Red)) || (marking.BackColor.Equals(Color.Red)) || (retraction.BackColor.Equals(Color.Red)) || (insulator.BackColor.Equals(Color.Red)) || (secondary.BackColor.Equals(Color.Red)))
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
                    while (read.Read()) { }//poner condicional para repetir el proceso dependiendo del item?
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
            xml();
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



        private void button3_Click(object sender, EventArgs e)
        {
            upStatusOK();
        }

        private void xml()
        {
            Form2 ff2 = new Form2();
            XmlDocument doc = new XmlDocument();//creacion de nuevo xml

            //abertura general de todo el proyecto
            string direc = "SyncMESInterface";
            XmlElement general = doc.CreateElement(direc);
            general.SetAttribute("xmlns", "http://schema.infor.com/InforOAGIS/2");
            general.SetAttribute("releasedID", "9.2");
            general.SetAttribute("versionID", "2.12.x");
            doc.AppendChild(general);

            //comentarios
            /* XmlElement autor = doc.CreateElement(("comentario"));
              autor.AppendChild(doc.CreateTextNode("@author: CMES COF:LEON @date: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")));
              autor.ToString();
              general.CreateComment(autor.ToString());*/


            //nodo principal ApplicationArea
            XmlElement AppA = doc.CreateElement("AplicationArea");
            general.AppendChild(AppA);

            //contenido nodo ApplicationArea
            XmlElement sender = doc.CreateElement("Sender");
            AppA.AppendChild(sender);

            //contenido nodo Sender
            XmlElement logical = doc.CreateElement("LogicalID");
            logical.AppendChild(doc.CreateTextNode("lid://infor.file.bod_in"));
            sender.AppendChild(logical);

            XmlElement component = doc.CreateElement("ComponentID");
            component.AppendChild(doc.CreateTextNode("file"));
            sender.AppendChild(component);

            XmlElement confirmation = doc.CreateElement("ConfirmationCode");
            confirmation.AppendChild(doc.CreateTextNode("OnError"));
            sender.AppendChild(confirmation);

            //contenido al nivel de sender
            XmlElement creation = doc.CreateElement("CreationDateTime");
            creation.AppendChild(doc.CreateTextNode(DateTime.Now.ToString("yyyy-MM-ddThh:mm:ssZ")));
            AppA.AppendChild(creation);

            XmlElement bodid = doc.CreateElement("BODID");
            bodid.AppendChild(doc.CreateTextNode("infor-nid:infor:640:S_640:A99000001:?MESInterface&verb=Sync"));
            AppA.AppendChild(bodid);


            /* XmlElement otro = doc.CreateElement("otro");
             otro.AppendChild(doc.CreateTextNode("parentesis"));
             inf.AppendChild(otro);*/

            //nodo principal DataArea
            XmlElement DaA = doc.CreateElement("DataArea");
            general.AppendChild(DaA);

            //contenido nodo DataArea
            XmlElement sync = doc.CreateElement("Sync");
            DaA.AppendChild(sync);

            //contenido nodo sync
            XmlElement tenantid = doc.CreateElement("TenantID");
            tenantid.AppendChild(doc.CreateTextNode("infor"));
            sync.AppendChild(tenantid);

            XmlElement accounting = doc.CreateElement("AccountingEntityID");
            accounting.AppendChild(doc.CreateTextNode("640"));
            sync.AppendChild(accounting);

            XmlElement location = doc.CreateElement("LocationID");
            location.AppendChild(doc.CreateTextNode("S_640"));
            sync.AppendChild(location);

            //nodo interino de sync
            XmlElement action = doc.CreateElement("ActionCriteria");
            sync.AppendChild(action);

            string express = "ActionExpression";
            XmlElement expression = doc.CreateElement(express);
            expression.SetAttribute("actionCode", "Add");
            action.AppendChild(expression);

            //contenido nodo DataArea
            XmlElement mesinterface = doc.CreateElement("MESInterface");
            DaA.AppendChild(mesinterface);

            //contenido nodo Mesinterface
            XmlElement mesheader = doc.CreateElement("MESHeader");
            mesinterface.AppendChild(mesheader);

            //contenido nodo mesheader
            //------------------------------DYNAMIC INFORMATION FROM MACHINES--------------------------------
            XmlElement mesorder = doc.CreateElement("MESOrderNo");
            mesorder.AppendChild(doc.CreateTextNode("DVR01" + DateTime.Now.ToString("yyMMddhhmmssfff")));
            mesheader.AppendChild(mesorder);

            XmlElement item = doc.CreateElement("Item");
            item.AppendChild(doc.CreateTextNode(usarItem.ToString()));
            mesheader.AppendChild(item);

            //contenido de nodo dentro de mesheader
            XmlElement mescompletion = doc.CreateElement("MESCompletion");
            mesheader.AppendChild(mescompletion);

            //contenido del nodo mescompletion
            XmlElement spool = doc.CreateElement("Spool");
            spool.AppendChild(doc.CreateTextNode(ff2.ver1()));
            mescompletion.AppendChild(spool);

            XmlElement date = doc.CreateElement("Date");
            date.AppendChild(doc.CreateTextNode(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")));
            mescompletion.AppendChild(date);

            XmlElement lotnumber = doc.CreateElement("LotNumber");
            lotnumber.AppendChild(doc.CreateTextNode(usarLot.ToString()));
            mescompletion.AppendChild(lotnumber);

            XmlElement whs = doc.CreateElement("Warehouse");
            whs.AppendChild(doc.CreateTextNode("LHBFG1"));
            mescompletion.AppendChild(whs);

            XmlElement qty = doc.CreateElement("Quantity");
            qty.AppendChild(doc.CreateTextNode(usarQty.ToString()));
            mescompletion.AppendChild(qty);

            //save the document
            doc.Save(@"C:\\Users\\Jesy\\Desktop\\" + (("DVR01" + DateTime.Now.ToString("yyyyMMddhhmmss")) + ".xml"));

            //revisar el DV01 cuando este en funcionamiento en lineas y detectar qué máquina es la que se va a usar para cambiarla
        }
    }
}