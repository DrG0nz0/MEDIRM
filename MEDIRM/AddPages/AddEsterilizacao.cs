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
    public partial class AddEsterilizacao : Form
    {
        public AddEsterilizacao()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new CriarBD());
        }

        private void AddEsterilizacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Moeda'. Você pode movê-la ou removê-la conforme necessário.
            this.moedaTableAdapter.Fill(this.medirmDBDataSet.Moeda);


        }

        private void criarMaquina_Click(object sender, EventArgs e)
        {
            //try
            //{
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("INSERT INTO Esterilizacao (Designacao, Preco, Moeda) VALUES (@Designacao, @Preco, @Moeda)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Designacao", textBox2.Text);
                com.Parameters.AddWithValue("@Preco", textBox3.Text);

                //decimal d = Convert.ToDecimal(textBox3.Text);
                //com.Parameters.AddWithValue("@Preco", d);
            
                DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                String cb1 = drv["Moeda"].ToString();
                com.Parameters.AddWithValue("@Moeda", cb1);


                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Esterilização adicionada com sucesso!");

                //Clear the fields
                textBox3.Clear();
                textBox2.Clear();
                comboBox1.ResetText();

           /* }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar esterilização. Por favor tente novamente.");
            }*/
        }
    }
}
