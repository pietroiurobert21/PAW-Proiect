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
    public partial class MENU : Form
    {
        administrator formA = new administrator();
        customer formC = new customer();

        UserType userTypeA = new UserType();
        public MENU()
        {
            InitializeComponent();
        }

        private void bChoice_Click(object sender, EventArgs e)
        {
            if (cbChoice.SelectedIndex == 0)
               formA.ShowDialog();
            else if (cbChoice.SelectedIndex == 1)
               userTypeA.ShowDialog();
        }
    }
}
