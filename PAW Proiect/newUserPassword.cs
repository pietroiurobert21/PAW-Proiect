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
    public partial class newUserPassword : Form
    {
        newUser obj;
        Client client;
        List<Client> lista;
        public newUserPassword(newUser obj, Client client, List<Client> lista)
        {
            InitializeComponent();
            this.obj = obj;
            this.client = new Client();
            this.client = client;
            this.lista = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.client.Password = tbParola.Text;
            lista = new List<Client>();
            FileStream fisier = new FileStream("clienti.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            lista = (List<Client>)formatter.Deserialize(fisier);
            fisier.Close();

            fisier = new FileStream("clienti.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();

            lista.Add(client);
            bf.Serialize(fisier, lista);
            fisier.Close();

            this.Close();
            obj.Close();
        }

        private void newUserPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
