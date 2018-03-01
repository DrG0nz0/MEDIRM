using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDIRM.GeneticSolution
{
    public partial class TabelaHorario : Form
    {
        public TabelaHorario(List<Helpers.TaskVisualizer> tasks)
        {
            InitializeComponent();
            var bindingList = new BindingList<Helpers.TaskVisualizer>(tasks);
            var source = new BindingSource(bindingList, null);
            this.dataGridView1.DataSource = source;
        }
    }
}
