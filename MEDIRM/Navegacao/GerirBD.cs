using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEDIRM.GerirPages;

namespace MEDIRM.Navegacao
{
    public partial class GerirBD : Form
    {
        public GerirBD()
        {
            InitializeComponent();
        }

        private void GerirBD_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirCartolina());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirCartao());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirPapel());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirEsterilizacao());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirTransportes());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirFilme());
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirMoldes());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirClientes());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirMaquinas());
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirComponentes());
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new BD());
        }
    }

}
