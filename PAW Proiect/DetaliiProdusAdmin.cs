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
    public partial class DetaliiProdusAdmin : Form
    {
        Produs produs = new Produs();
        int index;
        List<Produs> listaProduse = new List<Produs>();
        public DetaliiProdusAdmin(Produs produs,List<Produs> listaProduse, int index)
        {
            InitializeComponent();
            this.produs = produs;
            this.listaProduse = listaProduse;
            this.index = index;
        }

        private void DetaliiProdus_Load(object sender, EventArgs e)
        {
            textBox1.Text = produs.DenumireProdus;
            textBox2.Text = produs.Pret.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Produs produsNou = new Produs();
            if (textBox1.Text == "")
            {
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Introduceti o denumire!");
            }
            else if (textBox2.Text == "")
            {
                textBox2.Focus();
                errorProvider1.SetError(textBox2, "Introduceti un pret!");
            }
            else
            {
                produsNou.DenumireProdus = textBox1.Text;

                try
                {
                    produsNou.Pret = Convert.ToInt32(textBox2.Text);
                    if (produsNou.Pret < 0)
                    {
                        MessageBox.Show("Pretul nu poate fi negativ!");
                        textBox2.Text = "";
                    }
                    else
                        listaProduse[index] = produsNou;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                FileStream fisier = new FileStream("produse.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fisier, listaProduse);
                fisier.Close();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaProduse.RemoveAt(index);
            FileStream fisier = new FileStream("produse.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fisier, listaProduse);
            fisier.Close();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
