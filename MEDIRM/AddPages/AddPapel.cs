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
using System.Configuration;
using System.Data.SqlClient;

namespace MEDIRM
{
    public partial class AddPapel : Form
    {
        public AddPapel()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new CriarBD());
        }

        private void AddPapel_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Moeda'. Você pode movê-la ou removê-la conforme necessário.
            this.moedaTableAdapter.Fill(this.medirmDBDataSet.Moeda);

        }

        private void criarMaquina_Click(object sender, EventArgs e)
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("INSERT INTO Papel (Designacao, PrecoMetro, MetodoCalculo, Moeda) VALUES (@Designacao, @PrecoMetro, @MetodoCalculo, @Moeda)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Designacao", textBox2.Text);
                com.Parameters.AddWithValue("@PrecoMetro", textBox3.Text);
                com.Parameters.AddWithValue("@MetodoCalculo", textBox1.Text);

                DataRowView drv = (DataRowView)comboBox2.SelectedItem;
                String cb1 = drv["Moeda"].ToString();
                com.Parameters.AddWithValue("@Moeda", cb1);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Papel adicionado com sucesso!");

                //Clear the fields
                textBox3.Clear();
                textBox2.Clear();
                textBox1.Clear();
                comboBox2.ResetText();

            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar papel. Por favor tente novamente.");
            }
        }
    }
}
