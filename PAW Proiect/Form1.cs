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
using System.Runtime.Serialization.Formatters.Binary;


namespace PAW_Proiect
{
    public partial class Form1 : Form
    {
        public List<Produs> listaProduse = new List<Produs>();
        public Form1()
        {
            InitializeComponent();
            FileStream fisier = new FileStream("produse.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            if (fisier != null && fisier.Length > 0)
                listaProduse = (List<Produs>)formatter.Deserialize(fisier);
            foreach(Produs produs in listaProduse)
            {
                ltProdus.Items.Add(produs);
            }
            fisier.Close();
        }

        private void bProdus_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Introduceti pretul produsului!");
            labelAdd.Text = "";
            if (tbDenumire.Text == "")
                errorProvider1.SetError(tbDenumire, "Introduceti denumirea produsului!");
            else if (tbPret.Text == "")
                errorProvider1.SetError(tbPret, "Introduceti pretul produsului!");
            else
            {
                errorProvider1.Clear();
                try
                {
                    string denumire = tbDenumire.Text;
                    double pret = Convert.ToDouble(tbPret.Text);
                    if (pret < 0)
                    {
                        MessageBox.Show("Pretul nu poate fi negativ!");
                    }
                    else
                    {
                        Produs produsNou = new Produs(denumire, pret);
                        labelAdd.Text = "Produs adaugat cu succes!";
                        //ltProdus.Items.Add(produsNou.ToString());
                        ltProdus.Items.Add(produsNou.DenumireProdus);

                        listaProduse.Add(produsNou);

                        //List<Produs> listaNoua = new List<Produs>();

                        FileStream fisier = new FileStream("produse.dat", FileMode.Create, FileAccess.Write);
                        BinaryFormatter bf = new BinaryFormatter();
                        bf.Serialize(fisier, listaProduse);
                        fisier.Close();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally // se executa indiferent daca exceptia este aruncata sau nu
                {
                    tbDenumire.Clear();
                    tbPret.Clear();
                    labelAdd.Text = "";
                }
            }
        }

        private void schimbaCuloareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
                this.BackColor = colorDialog.Color;
        }

        private void schimbaFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
               this.Font = fontDialog.Font;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ltProdus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Produs selectedProduct = new Produs();
            selectedProduct = listaProduse.ElementAt( ltProdus.SelectedIndex );
            //selectedProduct = ltProdus.SelectedItem as Produs;
            DetaliiProdusAdmin form = new DetaliiProdusAdmin(selectedProduct, listaProduse, ltProdus.SelectedIndex);
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ltProdus.Items.Clear();
            FileStream fisier = new FileStream("produse.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            if (fisier != null && fisier.Length > 0)
                listaProduse = (List<Produs>)formatter.Deserialize(fisier);
            foreach (Produs produs in listaProduse)
            {
                ltProdus.Items.Add(produs);
            }
            fisier.Close();
        }
    }
}
