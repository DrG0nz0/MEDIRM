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

namespace MEDIRM.GerirPages
{
    public partial class GerirMaquinas : Form
    {
        public GerirMaquinas()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirBD());
        }

        private void GerirMaquinas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Molde'. Você pode movê-la ou removê-la conforme necessário.
            this.moldeTableAdapter.Fill(this.medirmDBDataSet.Molde);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Papel'. Você pode movê-la ou removê-la conforme necessário.
            this.papelTableAdapter.Fill(this.medirmDBDataSet.Papel);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Filme'. Você pode movê-la ou removê-la conforme necessário.
            this.filmeTableAdapter.Fill(this.medirmDBDataSet.Filme);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.TipoMaquina'. Você pode movê-la ou removê-la conforme necessário.
            this.tipoMaquinaTableAdapter.Fill(this.medirmDBDataSet.TipoMaquina);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.medirmDBDataSet.Funcionario);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Maquina'. Você pode movê-la ou removê-la conforme necessário.
            this.maquinaTableAdapter.Fill(this.medirmDBDataSet.Maquina);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
