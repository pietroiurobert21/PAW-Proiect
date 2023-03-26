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
    public partial class DetaliiProdus : Form
    {
        Produs produs = new Produs();
        public DetaliiProdus(Produs produs)
        {
            InitializeComponent();
            this.produs = produs;
        }

        private void DetaliiProdus_Load(object sender, EventArgs e)
        {
            textBox1.Text = produs.DenumireProdus;
            textBox2.Text = produs.Pret.ToString();
        }
    }
}
