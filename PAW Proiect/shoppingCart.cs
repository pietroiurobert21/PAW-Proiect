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
    public partial class shoppingCart : Form
    {
        Dictionary<Produs, int> achizitieNoua = new Dictionary<Produs, int>();
        double total = 0;
        string tranzactie = "";
        Tranzactie tr = new Tranzactie();
        PictureBox p;
        string username;
        public shoppingCart(Dictionary<Produs, int> achizitie, string username)
        {
            InitializeComponent();
            this.achizitieNoua = achizitie;
            this.username = username;
           
            tranzactie += tr.generateID(5);
            tranzactie += " ";
            foreach (var Produs in achizitieNoua)
            {
                listBox1.Items.Add(Produs);
                total = total + Produs.Value * Produs.Key.Pret;
                tranzactie = tranzactie + Produs.Key.DenumireProdus.ToString() + " x " + Produs.Value.ToString() + " / ";
            }
            textBox1.Text = total.ToString();
            label2.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") { 
                label2.Text = "Produsele au fost achizitionate cu succes!";
                tr.IdTranzactie = tranzactie;
                tr.Valoare = total;
                tr.Username = username;
                List<Tranzactie> tranzactieList = new List<Tranzactie>();

                FileStream fisier = new FileStream("tranzactii.dat", FileMode.Open, FileAccess.Read);
                if (fisier != null && fisier.Length > 0)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    tranzactieList = (List<Tranzactie>)formatter.Deserialize(fisier);
                }
                fisier.Close();

                tranzactieList.Add(tr);

                fisier = new FileStream("tranzactii.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                tranzactieList.Add(tr);
                bf.Serialize(fisier, tranzactieList);
                fisier.Close();
                listBox1.Items.Clear();
                this.achizitieNoua.Clear();
            }
        }

        private void shoppingCart_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}