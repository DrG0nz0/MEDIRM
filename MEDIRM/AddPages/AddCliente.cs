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

namespace MEDIRM.AddPages
{
    public partial class AddCliente : Form
    {
        public AddCliente()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new CriarBD());
        }

        private void AddCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Transporte'. Você pode movê-la ou removê-la conforme necessário.
            this.transporteTableAdapter.Fill(this.medirmDBDataSet.Transporte);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Esterilizacao'. Você pode movê-la ou removê-la conforme necessário.
            this.esterilizacaoTableAdapter.Fill(this.medirmDBDataSet.Esterilizacao);

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label5.Visible = true;
                comboBox2.Visible = true;
                button11.Visible = true;
            }
            else
            {
                label5.Visible = false;
                comboBox2.Visible = false;
                button11.Visible = false;
            }
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                label7.Visible = true;
                comboBox1.Visible = true;
                button2.Visible = true;
            }
            else
            {
                label7.Visible = false;
                comboBox1.Visible = false;
                button2.Visible = false;
            }
        }
    }
}
