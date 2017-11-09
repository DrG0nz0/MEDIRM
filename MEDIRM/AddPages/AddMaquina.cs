using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDIRM
{
    public partial class AddMaquina : Form
    {
        public AddMaquina()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new Menu());
        }

        private void AddMaquina_Load(object sender, EventArgs e)
        {


        }
    }
}
