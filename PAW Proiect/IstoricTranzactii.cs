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
        List<Tranzactie> tranzactieList = new List<Tranzactie>();
        public IstoricTranzactii()
        {
            InitializeComponent();

            FileStream fisier = new FileStream("tranzactii.dat", FileMode.Open, FileAccess.Read);
            listBox1.Items.Clear();
            if (fisier != null && fisier.Length > 0)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                tranzactieList = (List<Tranzactie>)formatter.Deserialize(fisier);
            }
            foreach (Tranzactie tranzactie in tranzactieList)
            {
                string item = (tranzactie.IdTranzactie) + " || VALOARE: " + tranzactie.Valoare.ToString();
                if (!listBox1.Items.Contains(item))
                {
                    listBox1.Items.Add(item);
                }
            }
            fisier.Close();

        }

        private void IstorictTranzactii_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int index = listBox1.SelectedIndex;
            //Tranzactie tranzactie = new Tranzactie();
            //try
            //{
             //   tranzactie = tranzactieList.ElementAt(listBox1.SelectedIndex);
           // }
            //catch (Exception ex)
            //{
             //   MessageBox.Show(ex.Message);
            //}
            //selectedProduct = ltProdus.SelectedItem as Produs;
            //detaliiTranzactii obj = new detaliiTranzactii(index, tranzactie, tranzactieList);
            //obj.ShowDialog();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fisier = new FileStream("tranzactii.dat", FileMode.Open, FileAccess.Read);
            listBox1.Items.Clear();
            if (fisier != null && fisier.Length > 0)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                tranzactieList = (List<Tranzactie>)formatter.Deserialize(fisier);
            }
            foreach (Tranzactie tranzactie in tranzactieList)
            {
                string item = (tranzactie.IdTranzactie) + " || VALOARE: " + tranzactie.Valoare.ToString();
                if (!listBox1.Items.Contains(item))
                {
                    listBox1.Items.Add(item);
                }
            }
            fisier.Close();
        }
    }
}