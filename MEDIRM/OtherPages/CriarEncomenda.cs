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
    public partial class CriarEncomenda : Form
    {
        public CriarEncomenda()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new Menu());
        }

        private void criarMaquina_Click(object sender, EventArgs e)     // adicionar encomenda
        {

        }

        private void CriarEncomenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.ArtigosClientes'. Você pode movê-la ou removê-la conforme necessário.
            this.artigosClientesTableAdapter.Fill(this.medirmDBDataSet.ArtigosClientes);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.medirmDBDataSet.Cliente);

        }
    }
}
