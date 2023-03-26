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
    public partial class newUser : Form
    {
        List<Client> lista;

        public newUser()
        {
            InitializeComponent();
            //lista = new List<Client>();
            //FileStream fisier = new FileStream("clienti.dat", FileMode.Open, FileAccess.Read);
            //BinaryFormatter formatter = new BinaryFormatter();
            //lista = (List<Client>)formatter.Deserialize(fisier);
            //fisier.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Nume = tbNume.Text;
            client.Email = tbEmail.Text;
            newUserPassword user = new newUserPassword(this, client, lista);
            user.ShowDialog(this);
        }

        private void newUser_Load(object sender, EventArgs e)
        {

        }
    }
}
