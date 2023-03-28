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
    public partial class ConturiClienti : Form
    {
        List<Client> listaClienti = new List<Client>();
        public ConturiClienti()
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

        private void ConturiClienti_Load(object sender, EventArgs e)
        {

        }
    }
}
