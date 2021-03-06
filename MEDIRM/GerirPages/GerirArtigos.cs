﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEDIRM.Navegacao;

namespace MEDIRM.GerirPages
{
    public partial class GerirArtigos : Form
    {
        public GerirArtigos()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirBD());
        }

        private void GerirArtigos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Esterilizacao'. Você pode movê-la ou removê-la conforme necessário.
            this.esterilizacaoTableAdapter.Fill(this.medirmDBDataSet.Esterilizacao);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Cartolina'. Você pode movê-la ou removê-la conforme necessário.
            this.cartolinaTableAdapter.Fill(this.medirmDBDataSet.Cartolina);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Artigo'. Você pode movê-la ou removê-la conforme necessário.
            this.artigoTableAdapter.Fill(this.medirmDBDataSet.Artigo);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Cartao'. Você pode movê-la ou removê-la conforme necessário.
            this.cartaoTableAdapter.Fill(this.medirmDBDataSet.Cartao);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Maquina'. Você pode movê-la ou removê-la conforme necessário.
            this.maquinaTableAdapter.Fill(this.medirmDBDataSet.Maquina);

            //Clear the fields
            textBox2.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            comboBox7.ResetText();
            comboBox8.ResetText();
            comboBox9.ResetText();
            comboBox9.ResetText();
            comboBox1.ResetText();
            comboBox4.ResetText();
            comboBox5.ResetText();
            comboBox6.ResetText();
            comboBox7.ResetText();
            comboBox8.ResetText();
            comboBox3.ResetText();
            comboBox2.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)      // guardar
        {
         
            try
            {
                if (checkBox5.Checked && checkBox4.Checked && checkBox3.Checked && checkBox2.Checked && checkBox1.Checked)
                {
                    try
                    {
                        //Insert in the database
                        string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                        SqlConnection con = new SqlConnection(connectionString);

                        SqlCommand com = new SqlCommand("UPDATE Artigo SET ID=@ID, UnBase=@UnBase, QtdCartao=@QtdCartao, QtdCartolina=@QtdCartolina, QtdCartoesPalete=@QtdCartoesPalete, Cartao=@Cartao, Cartolina=@Cartolina, Esterilizacao=@Esterilizacao, Maquina1=@Maquina1, Maquina2=@Maquina2, Maquina3=@Maquina3, Maquina4=@Maquina4, Maquina5=@Maquina5 WHERE Nome=@Nome", con);
                        com.CommandType = CommandType.Text;

                        com.Parameters.AddWithValue("@Nome", comboBox9.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@ID", textBox2.Text);
                        com.Parameters.AddWithValue("@UnBase", textBox5.Text);
                        com.Parameters.AddWithValue("@QtdCartao", textBox6.Text);
                        com.Parameters.AddWithValue("@QtdCartolina", textBox8.Text);
                        com.Parameters.AddWithValue("@QtdCartoesPalete", textBox7.Text);
                        com.Parameters.AddWithValue("@Esterilizacao", comboBox3.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina1", comboBox7.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina2", comboBox1.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina3", comboBox4.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina4", comboBox5.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina5", comboBox6.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Cartao", comboBox7.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Cartolina", comboBox8.SelectedValue.ToString());

                        con.Open();
                        int i = com.ExecuteNonQuery();
                        con.Close();

                        //Confirmation Message 
                        MessageBox.Show("Artigo adicionado com sucesso!");

                        //Clear the fields
                        comboBox9.ResetText();
                        comboBox1.ResetText();
                        comboBox4.ResetText();
                        comboBox5.ResetText();
                        comboBox6.ResetText();
                        comboBox7.ResetText();
                        comboBox8.ResetText();
                        comboBox3.ResetText();
                        comboBox2.ResetText();

                    }
                    catch (Exception x)
                    {
                        //Error Message 
                        MessageBox.Show("Erro ao adicionar componente ao artigo. Por favor tente novamente.");
                    }
                }

                if (!checkBox5.Checked && checkBox4.Checked && checkBox3.Checked && checkBox2.Checked && checkBox1.Checked)
                {
                    try
                    {
                        //Insert in the database
                        string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                        SqlConnection con = new SqlConnection(connectionString);

                        SqlCommand com = new SqlCommand("UPDATE Artigo SET ID=@ID, UnBase=@UnBase, QtdCartao=@QtdCartao, Esterilizacao=@Esterilizacao, QtdCartolina=@QtdCartolina, QtdCartoesPalete=@QtdCartoesPalete, Cartao=@Cartao, Cartolina=@Cartolina, Maquina1=@Maquina1, Maquina2=@Maquina2, Maquina3=@Maquina3, Maquina4=@Maquina4 WHERE Nome=@Nome", con);
                        com.CommandType = CommandType.Text;

                        com.Parameters.AddWithValue("@Nome", comboBox9.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@ID", textBox2.Text);
                        com.Parameters.AddWithValue("@UnBase", textBox5.Text);
                        com.Parameters.AddWithValue("@QtdCartao", textBox6.Text);
                        com.Parameters.AddWithValue("@QtdCartolina", textBox8.Text);
                        com.Parameters.AddWithValue("@QtdCartoesPalete", textBox7.Text);
                        com.Parameters.AddWithValue("@Esterilizacao", comboBox3.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina1", comboBox7.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina2", comboBox1.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina3", comboBox4.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina4", comboBox5.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Cartao", comboBox7.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Cartolina", comboBox8.SelectedValue.ToString());

                        con.Open();
                        int i = com.ExecuteNonQuery();
                        con.Close();

                        //Confirmation Message 
                        MessageBox.Show("Artigo adicionado com sucesso!");

                        //Clear the fields
                        comboBox9.ResetText();
                        comboBox1.ResetText();
                        comboBox4.ResetText();
                        comboBox5.ResetText();
                        comboBox6.ResetText();
                        comboBox7.ResetText();
                        comboBox8.ResetText();
                        comboBox3.ResetText();
                        comboBox2.ResetText();

                    }
                    catch (Exception x)
                    {
                        //Error Message 
                        MessageBox.Show("Erro ao adicionar componente ao artigo. Por favor tente novamente.");
                    }
                }

                if (!checkBox5.Checked && !checkBox4.Checked && checkBox3.Checked && checkBox2.Checked && checkBox1.Checked)
                {
                    try
                    {
                        //Insert in the database
                        string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                        SqlConnection con = new SqlConnection(connectionString);

                        SqlCommand com = new SqlCommand("UPDATE Artigo SET ID=@ID, UnBase=@UnBase, QtdCartao=@QtdCartao, Esterilizacao=@Esterilizacao, QtdCartolina=@QtdCartolina, QtdCartoesPalete=@QtdCartoesPalete, Cartao=@Cartao, Cartolina=@Cartolina, Maquina1=@Maquina1, Maquina2=@Maquina2, Maquina3=@Maquina3 WHERE Nome=@Nome", con);
                        com.CommandType = CommandType.Text;

                        com.Parameters.AddWithValue("@Nome", comboBox9.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@ID", textBox2.Text);
                        com.Parameters.AddWithValue("@UnBase", textBox5.Text);
                        com.Parameters.AddWithValue("@QtdCartao", textBox6.Text);
                        com.Parameters.AddWithValue("@QtdCartolina", textBox8.Text);
                        com.Parameters.AddWithValue("@QtdCartoesPalete", textBox7.Text);
                        com.Parameters.AddWithValue("@Esterilizacao", comboBox3.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina1", comboBox7.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina2", comboBox1.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina3", comboBox4.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Cartao", comboBox7.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Cartolina", comboBox8.SelectedValue.ToString());

                        con.Open();
                        int i = com.ExecuteNonQuery();
                        con.Close();

                        //Confirmation Message 
                        MessageBox.Show("Artigo adicionado com sucesso!");

                        //Clear the fields
                        comboBox9.ResetText();
                        comboBox1.ResetText();
                        comboBox4.ResetText();
                        comboBox5.ResetText();
                        comboBox6.ResetText();
                        comboBox7.ResetText();
                        comboBox8.ResetText();
                        comboBox3.ResetText();
                        comboBox2.ResetText();

                    }
                    catch (Exception x)
                    {
                        //Error Message 
                        MessageBox.Show("Erro ao adicionar componente ao artigo. Por favor tente novamente.");
                    }
                }

                if (!checkBox5.Checked && !checkBox4.Checked && !checkBox3.Checked && checkBox2.Checked && checkBox1.Checked)
                {
                    try
                    {
                        //Insert in the database
                        string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                        SqlConnection con = new SqlConnection(connectionString);

                        SqlCommand com = new SqlCommand("UPDATE Artigo SET ID=@ID, UnBase=@UnBase, QtdCartao=@QtdCartao, Esterilizacao=@Esterilizacao, QtdCartolina=@QtdCartolina, QtdCartoesPalete=@QtdCartoesPalete, Cartao=@Cartao, Cartolina=@Cartolina, Maquina1=@Maquina1, Maquina2=@Maquina2 WHERE Nome=@Nome", con);
                        com.CommandType = CommandType.Text;

                        com.Parameters.AddWithValue("@Nome", comboBox9.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@ID", textBox2.Text);
                        com.Parameters.AddWithValue("@UnBase", textBox5.Text);
                        com.Parameters.AddWithValue("@QtdCartao", textBox6.Text);
                        com.Parameters.AddWithValue("@QtdCartolina", textBox8.Text);
                        com.Parameters.AddWithValue("@QtdCartoesPalete", textBox7.Text);
                        com.Parameters.AddWithValue("@Esterilizacao", comboBox3.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina1", comboBox7.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina2", comboBox1.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Cartao", comboBox7.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Cartolina", comboBox8.SelectedValue.ToString());

                        con.Open();
                        int i = com.ExecuteNonQuery();
                        con.Close();

                        //Confirmation Message 
                        MessageBox.Show("Artigo adicionado com sucesso!");

                        //Clear the fields
                        comboBox9.ResetText();
                        comboBox1.ResetText();
                        comboBox4.ResetText();
                        comboBox5.ResetText();
                        comboBox6.ResetText();
                        comboBox7.ResetText();
                        comboBox8.ResetText();
                        comboBox3.ResetText();
                        comboBox2.ResetText();

                    }
                    catch (Exception x)
                    {
                        //Error Message 
                        MessageBox.Show("Erro ao adicionar componente ao artigo. Por favor tente novamente.");
                    }
                }

                if (!checkBox5.Checked && !checkBox4.Checked && !checkBox3.Checked && !checkBox2.Checked && checkBox1.Checked)
                {
                    try
                    {
                        //Insert in the database
                        string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                        SqlConnection con = new SqlConnection(connectionString);

                        SqlCommand com = new SqlCommand("UPDATE Artigo SET ID=@ID, UnBase=@UnBase, QtdCartao=@QtdCartao, Esterilizacao=@Esterilizacao, QtdCartolina=@QtdCartolina, QtdCartoesPalete=@QtdCartoesPalete, Cartao=@Cartao, Cartolina=@Cartolina, Maquina1=@Maquina1 WHERE Nome=@Nome", con);
                        com.CommandType = CommandType.Text;

                        com.Parameters.AddWithValue("@Nome", comboBox9.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@ID", textBox2.Text);
                        com.Parameters.AddWithValue("@UnBase", textBox5.Text);
                        com.Parameters.AddWithValue("@QtdCartao", textBox6.Text);
                        com.Parameters.AddWithValue("@QtdCartolina", textBox8.Text);
                        com.Parameters.AddWithValue("@QtdCartoesPalete", textBox7.Text);
                        com.Parameters.AddWithValue("@Esterilizacao", comboBox3.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina1", comboBox7.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Cartao", comboBox7.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Cartolina", comboBox8.SelectedValue.ToString());

                        con.Open();
                        int i = com.ExecuteNonQuery();
                        con.Close();

                        //Confirmation Message 
                        MessageBox.Show("Artigo adicionado com sucesso!");

                        //Clear the fields
                        comboBox9.ResetText();
                        comboBox1.ResetText();
                        comboBox4.ResetText();
                        comboBox5.ResetText();
                        comboBox6.ResetText();
                        comboBox7.ResetText();
                        comboBox8.ResetText();
                        comboBox3.ResetText();
                        comboBox2.ResetText();

                    }
                    catch (Exception x)
                    {
                        //Error Message 
                        MessageBox.Show("Erro ao adicionar componente ao artigo. Por favor tente novamente.");
                    }
                }

                else
                {
                    MessageBox.Show("Erro ao adicionar maquina ao artigo. Por favor coloque as máquinas por ordem e tente novamente.");
                }

                //Confirmation Message 
                MessageBox.Show("Artigo adicionado com sucesso!");

                //Clear the fields
                textBox2.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                comboBox7.ResetText();
                comboBox8.ResetText();
                comboBox1.ResetText();
                comboBox4.ResetText();
                comboBox5.ResetText();
                comboBox6.ResetText();
                comboBox7.ResetText();
                comboBox3.ResetText();
                comboBox2.ResetText();

            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar artigo. Por favor tente novamente.");
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)     // preencher
        {
            //Clear the fields
            textBox2.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            comboBox7.ResetText();
            comboBox8.ResetText();
            comboBox3.ResetText();
            comboBox2.ResetText();

            string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
            SqlConnection con2 = new SqlConnection(connectionString);
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("Select * from Artigo where Nome='" + comboBox9.Text.Trim() + "'", con2);

            try
            {
                DataRowView drv = (DataRowView)comboBox9.SelectedItem;
                String cb1 = drv["Nome"].ToString();
            }
            catch { }


            SqlDataReader reader = cmd2.ExecuteReader();
            if (reader.Read())
            {
                textBox2.Text = reader["ID"].ToString();
                textBox5.Text = reader["UnBase"].ToString();
                textBox6.Text = reader["QtdCartao"].ToString();
                textBox8.Text = reader["QtdCartolina"].ToString();
                textBox7.Text = reader["QtdCartoesPalete"].ToString();
                comboBox7.DisplayMember = reader["Cartao"].ToString();
                comboBox7.SelectedText = reader["Cartao"].ToString();
                comboBox8.DisplayMember = reader["Cartolina"].ToString();
                comboBox8.SelectedText = reader["Cartolina"].ToString();
                comboBox2.DisplayMember = reader["Maquina1"].ToString();
                comboBox2.SelectedText = reader["Maquina1"].ToString();
                comboBox3.DisplayMember = reader["Esterilizacao"].ToString();
                comboBox3.SelectedText = reader["Esterilizacao"].ToString();

                reader.Close();
                con2.Close();
            }
            else
            {
                MessageBox.Show("Erro ao exibir artigo. Por favor tente novamente.");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
