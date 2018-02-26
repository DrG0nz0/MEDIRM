using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEDIRM.AddPages;

namespace MEDIRM.Navegacao
{
    public partial class CriarBD : Form
    {
        public CriarBD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new AddCartolina());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new AddCartao());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new AddPapel());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new AddEsterilizacao());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new AddTransportes());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new AddFilme());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new AddFuncionario());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new AddMolde());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new AddCliente());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new AddMaquina());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new AddArtigo());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new AddComponente());
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new BD());
        }
    }
}
