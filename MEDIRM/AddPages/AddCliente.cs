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

        private void criarMaquina_Click(object sender, EventArgs e)     // add cliente
        {
            if (checkBox1.Checked && checkBox2.Checked)     // transporte e esterilizacao
            {
                try
                {
                    //Insert in the database
                    string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                    SqlConnection con = new SqlConnection(connectionString);

                    SqlCommand com = new SqlCommand("INSERT INTO Cliente (ID, Nome, Localidade, MargemLucro, Transporte, TipoEsterilizacao) VALUES (@ID, @Nome, @Localidade, @MargemLucro, @Transporte, @TipoEsterilizacao)", con);
                    com.CommandType = CommandType.Text;

                    com.Parameters.AddWithValue("@Nome", textBox2.Text);
                    com.Parameters.AddWithValue("@ID", textBox8.Text);
                    com.Parameters.AddWithValue("@Localidade", textBox4.Text);
                    com.Parameters.AddWithValue("@MargemLucro", textBox3.Text);

                    com.Parameters.AddWithValue("@Transporte", comboBox2.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@TipoEsterilizacao", comboBox1.SelectedValue.ToString());

                    con.Open();
                    int i = com.ExecuteNonQuery();
                    con.Close();

                    //Confirmation Message 
                    MessageBox.Show("Cliente adicionado com sucesso!");

                    //Clear the fields
                    textBox4.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox8.Clear();
                    comboBox2.ResetText();
                    comboBox1.ResetText();
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    comboBox1.Visible = false;
                    comboBox2.Visible = false;
                    button11.Visible = false;
                    button2.Visible = false;
                }
                catch (Exception x)
                {
                    //Error Message 
                    MessageBox.Show("Erro ao adicionar cliente. Por favor tente novamente.");
                }
            }

            if (checkBox1.Checked && !checkBox2.Checked)     // so transporte
            {
                try
                {
                    //Insert in the database
                    string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                    SqlConnection con = new SqlConnection(connectionString);

                    SqlCommand com = new SqlCommand("INSERT INTO Cliente (ID, Nome, Localidade, MargemLucro, Transporte) VALUES (@ID, @Nome, @Localidade, @MargemLucro, @Transporte)", con);
                    com.CommandType = CommandType.Text;

                    com.Parameters.AddWithValue("@Nome", textBox2.Text);
                    com.Parameters.AddWithValue("@ID", textBox8.Text);
                    com.Parameters.AddWithValue("@Localidade", textBox4.Text);
                    com.Parameters.AddWithValue("@MargemLucro", textBox3.Text);

                    com.Parameters.AddWithValue("@Transporte", comboBox2.SelectedValue.ToString());

                    con.Open();
                    int i = com.ExecuteNonQuery();
                    con.Close();

                    //Confirmation Message 
                    MessageBox.Show("Cliente adicionado com sucesso!");

                    //Clear the fields
                    textBox4.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox8.Clear();
                    comboBox2.ResetText();
                    comboBox1.ResetText();
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    comboBox1.Visible = false;
                    comboBox2.Visible = false;
                    button11.Visible = false;
                    button2.Visible = false;
                }
                catch (Exception x)
                {
                    //Error Message 
                    MessageBox.Show("Erro ao adicionar cliente. Por favor tente novamente.");
                }

            }

            if (!checkBox1.Checked && checkBox2.Checked)     // so esterilizacao
            {
                try
                {
                    //Insert in the database
                    string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                    SqlConnection con = new SqlConnection(connectionString);

                    SqlCommand com = new SqlCommand("INSERT INTO Cliente (ID, Nome, Localidade, MargemLucro, TipoEsterilizacao) VALUES (@ID, @Nome, @Localidade, @MargemLucro, @TipoEsterilizacao)", con);
                    com.CommandType = CommandType.Text;

                    com.Parameters.AddWithValue("@Nome", textBox2.Text);
                    com.Parameters.AddWithValue("@ID", textBox8.Text);
                    com.Parameters.AddWithValue("@Localidade", textBox4.Text);
                    com.Parameters.AddWithValue("@MargemLucro", textBox3.Text);

                    com.Parameters.AddWithValue("@TipoEsterilizacao", comboBox1.SelectedValue.ToString());

                    con.Open();
                    int i = com.ExecuteNonQuery();
                    con.Close();

                    //Confirmation Message 
                    MessageBox.Show("Cliente adicionado com sucesso!");

                    //Clear the fields
                    textBox4.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox8.Clear();
                    comboBox2.ResetText();
                    comboBox1.ResetText();
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    comboBox1.Visible = false;
                    comboBox2.Visible = false;
                    button11.Visible = false;
                    button2.Visible = false;
                }
                catch (Exception x)
                {
                    //Error Message 
                    MessageBox.Show("Erro ao adicionar cliente. Por favor tente novamente.");
                }
            }

            if (!checkBox1.Checked && !checkBox2.Checked)     // nem transporte nem esterilizacao
            {
                try
                {
                    //Insert in the database
                    string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                    SqlConnection con = new SqlConnection(connectionString);

                    SqlCommand com = new SqlCommand("INSERT INTO Cliente (ID, Nome, Localidade, MargemLucro) VALUES (@ID, @Nome, @Localidade, @MargemLucro)", con);
                    com.CommandType = CommandType.Text;

                    com.Parameters.AddWithValue("@Nome", textBox2.Text);
                    com.Parameters.AddWithValue("@ID", textBox8.Text);
                    com.Parameters.AddWithValue("@Localidade", textBox4.Text);
                    com.Parameters.AddWithValue("@MargemLucro", textBox3.Text);

                    con.Open();
                    int i = com.ExecuteNonQuery();
                    con.Close();

                    //Confirmation Message 
                    MessageBox.Show("Cliente adicionado com sucesso!");

                    //Clear the fields
                    textBox4.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox8.Clear();
                    comboBox2.ResetText();
                    comboBox1.ResetText();
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    comboBox1.Visible = false;
                    comboBox2.Visible = false;
                    button11.Visible = false;
                    button2.Visible = false;
                }
                catch (Exception x)
                {
                    //Error Message 
                    MessageBox.Show("Erro ao adicionar cliente. Por favor tente novamente.");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)      // add artigo ao cliente
        {
            
        }
    }
}
