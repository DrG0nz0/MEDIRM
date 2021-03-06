﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEDIRM.Navegacao;
using MEDIRM.OtherPages;
using Scheduling;

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
            MainFormView.ShowForm(new SimulacaoPrecos());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GeneticForm());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new VerTurnosFuncionarios());
        }
    }
}
