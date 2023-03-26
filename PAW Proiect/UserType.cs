using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace PAW_Proiect
{
    public partial class UserType : Form
    {
        
        public UserType()
        {
            InitializeComponent();
            List<Client> listaClienti = new List<Client>();
            Client client1 = new Client();

            FileStream fisier = new FileStream("clienti.dat", FileMode.Append, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();

            List<Client> lista = new List<Client>() { client1 };
            bf.Serialize(fisier, lista);
            fisier.Close();




            fisier = new FileStream("clienti.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            listaClienti = (List<Client>)formatter.Deserialize(fisier);
            //client1 = (Client)formatter.Deserialize(fisier);
            listaClienti.Add(client1);

            foreach (Client client in listaClienti)
            {
                listBox1.Items.Add(client);
            }
            fisier.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            newUser newuser = new newUser();
            newuser.ShowDialog();
        }

        private void tbNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserType_Load(object sender, EventArgs e)
        {

        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Client> listaClienti = new List<Client>();

            
            FileStream fisier = new FileStream("clienti.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            listaClienti = (List<Client>)formatter.Deserialize(fisier);
            foreach (Client client in listaClienti)
            {
                listBox1.Items.Add(client);
            }
            fisier.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customer customer1 = new customer();
            customer1.ShowDialog();
        }
    }
}
