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
    public partial class AddFuncionario : Form
    {
        public AddFuncionario()
        {
            InitializeComponent();
        }

        private void AddFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new CriarBD());
        }

        private void criarMaquina_Click(object sender, EventArgs e)
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("INSERT INTO Funcionario (Nome, ID, Sigla) VALUES (@Nome, @ID, @Sigla)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Nome", textBox1.Text);
                com.Parameters.AddWithValue("@ID", textBox2.Text);
                com.Parameters.AddWithValue("@Sigla", textBox3.Text);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Funcionário adicionado com sucesso!");

                //Clear the fields
                textBox1.Clear();
                textBox2.Clear();

            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar funcionário. Por favor tente novamente.");
            }
        }
    }
}
