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
    public partial class IstoricTranzactii : Form
    {
        public IstoricTranzactii()
        {
            InitializeComponent();

            List<Tranzactie> tranzactieList = new List<Tranzactie>();

            FileStream fisier = new FileStream("tranzactii.dat", FileMode.Open, FileAccess.Read);
            listBox1.Items.Clear();
            if (fisier != null && fisier.Length > 0)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                tranzactieList = (List<Tranzactie>)formatter.Deserialize(fisier);
                foreach (Tranzactie tranzactie in tranzactieList)
                {
                    string item = (tranzactie.IdTranzactie) + " || VALOARE: " + tranzactie.Valoare.ToString();
                    if (!listBox1.Items.Contains(item))
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
            fisier.Close();

        }

        private void IstorictTranzactii_Load(object sender, EventArgs e)
        {

        }
    }
}