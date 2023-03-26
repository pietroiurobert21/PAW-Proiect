using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAW_Proiect
{
    public partial class DetaliiProdusAdmin : Form
    {
        Produs produs = new Produs();
        public DetaliiProdusAdmin(Produs produs)
        {
            InitializeComponent();
            this.produs = produs;
        }

        private void DetaliiProdus_Load(object sender, EventArgs e)
        {
            textBox1.Text = produs.DenumireProdus;
            textBox2.Text = produs.Pret.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
