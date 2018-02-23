using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEDIRM.Navegacao;

namespace MEDIRM
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new BD());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new CriarEncomenda());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new VerPreços());
        }
    }
}
