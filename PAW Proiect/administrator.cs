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
    public partial class administrator : Form
    {
        List<Produs> produs;
        Form1 form1 = new Form1();
        public administrator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.ShowDialog();
            form1.labelAdd.Text = "";
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            IstoricTranzactii it = new IstoricTranzactii();
            it.ShowDialog();
        }
    }
}
