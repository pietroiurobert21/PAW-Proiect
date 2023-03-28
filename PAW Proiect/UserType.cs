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
        List<Client> listaClienti = new List<Client>();
        public UserType()
        {
            InitializeComponent();
            listBox1.Items.Clear();

            FileStream fisier = new FileStream("clienti.dat", FileMode.Open, FileAccess.Read);


            if (fisier != null && fisier.Length > 0)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                listaClienti = (List<Client>)formatter.Deserialize(fisier);
            }
            foreach (Client client in listaClienti)
            {
                listBox1.Items.Add(client);
            }
            fisier.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newUser newuser = new newUser();
            newuser.ShowDialog();
            bRefresh_Click(sender, e);
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            FileStream fisier = new FileStream("clienti.dat", FileMode.Open, FileAccess.Read);


            if (fisier != null && fisier.Length > 0)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                listaClienti = (List<Client>)formatter.Deserialize(fisier);
            }
            foreach (Client client in listaClienti)
            {
                listBox1.Items.Add(client);
            }
            fisier.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool identityVerified = false;
            foreach (Client client in listaClienti)
            {
                if (client.Nume == tbNume.Text)
                   if (client.Password == tbParola.Text)
                        identityVerified = true;
            }
            if (identityVerified == true)
            {
                customer customer1 = new customer(tbNume.Text);
                customer1.ShowDialog();
            }
            else MessageBox.Show("Nu ati introdus bine numele sau parola!");
        }

        private void UserType_Load(object sender, EventArgs e)
        {

        }
    }
}