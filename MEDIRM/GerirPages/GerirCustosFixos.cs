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
    public partial class GerirCustosFixos : Form
    {
        public GerirCustosFixos()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirBD());
        }

        private void custosFixosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.custosFixosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medirmDBDataSet);

        }

        private void GerirCustosFixos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.CustosFixos'. Você pode movê-la ou removê-la conforme necessário.
            this.custosFixosTableAdapter.Fill(this.medirmDBDataSet.CustosFixos);

        }
    }
}
