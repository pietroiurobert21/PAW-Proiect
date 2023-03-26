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
    public partial class DetaliiProdusClient : Form
    {
        Dictionary<Produs, int> achizitieNoua = new Dictionary<Produs, int>();
        Produs produs = new Produs();
        public DetaliiProdusClient(Produs produs, Dictionary<Produs, int> achizitie)
        {
            InitializeComponent();
            this.produs = produs;
            this.achizitieNoua = achizitie;
        }

        private void DetaliiProdusClient_Load(object sender, EventArgs e)
        {
            textBox1.Text = produs.DenumireProdus;
            textBox2.Text = produs.Pret.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(comboBox1.Text);
            if (achizitieNoua.ContainsKey(produs)) {
                achizitieNoua[produs] += value;
            }
            else
                achizitieNoua.Add(produs,value);
            this.Close();
        }
    }
}
