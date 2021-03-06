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
    public partial class AddComponente : Form
    {
        public AddComponente()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new CriarBD());
        }

        private void AddComponente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Moeda'. Você pode movê-la ou removê-la conforme necessário.
            this.moedaTableAdapter.Fill(this.medirmDBDataSet.Moeda);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Transporte'. Você pode movê-la ou removê-la conforme necessário.
            this.transporteTableAdapter.Fill(this.medirmDBDataSet.Transporte);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("INSERT INTO Componentes (Nome, ID, Transporte, PrecoCompra, Moeda, PrecoCusto, CustoAlfandega, QtdCartao, VolCartao, UnBase, PrecoCustoFinal) VALUES (@Nome, @ID, @Transporte, @PrecoCompra, @Moeda, @PrecoCusto, @CustoAlfandega, @QtdCartao, @VolCartao, @UnBase, @PrecoCustoFinal)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Nome", textBox1.Text);
                com.Parameters.AddWithValue("@ID", Convert.ToInt32(textBox2.Text));
                com.Parameters.AddWithValue("@PrecoCompra", Convert.ToDecimal(textBox3.Text));
                com.Parameters.AddWithValue("@PrecoCusto", Convert.ToDecimal(textBox4.Text) );
                com.Parameters.AddWithValue("@QtdCartao", Convert.ToInt32(textBox6.Text));
                com.Parameters.AddWithValue("@VolCartao", Convert.ToDecimal(textBox7.Text));
                com.Parameters.AddWithValue("@UnBase", textBox8.Text);
                com.Parameters.AddWithValue("@CustoAlfandega", Convert.ToDecimal(textBox5.Text));
                com.Parameters.AddWithValue("@PrecoCustoFinal", Convert.ToDecimal(textBox9.Text));
                com.Parameters.AddWithValue("@Transporte", comboBox1.SelectedValue.ToString());

                DataRowView drv = (DataRowView)comboBox2.SelectedItem;
                String cb = drv["Moeda"].ToString();
                com.Parameters.AddWithValue("@Moeda", cb);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Componente adicionado com sucesso!");

                //Clear the fields
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox8.Clear();
                textBox7.Clear();
                textBox9.Clear();
                comboBox2.ResetText();
                comboBox1.ResetText();
            
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar componente. Por favor tente novamente.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double volCartao = Convert.ToDouble(textBox7.Text);


            double qtCartoes = 100 / (Convert.ToDouble(textBox6.Text));
            double nrCartoes = Math.Ceiling(qtCartoes);
            double volCartoes = nrCartoes * (Convert.ToDouble(textBox7.Text));
            double volTotal = Math.Ceiling(volCartoes);
            double precom=1;

            string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
            SqlDataReader dr;
            try
            {
                SqlConnection con3 = new SqlConnection(connectionString);
                con3.Open();

                SqlCommand cmd3 = new SqlCommand("SELECT Preco FROM Transporte WHERE Designacao= '" + comboBox1.SelectedValue.ToString() + "'", con3);

                dr = cmd3.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        precom = dr.GetFloat(0);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                

                dr.Close();
                con3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            double precoCartao = volCartao * precom;    // preco por cartao

            double precoTrans = 100 * precoCartao / Convert.ToDouble(textBox6.Text);
            double precoCusto = (Convert.ToDouble(textBox4.Text));
            double precoFinal = precoTrans + precoCusto;
            
            textBox9.Text = Convert.ToString(precoFinal);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double alfandega = Convert.ToDouble(textBox5.Text);
            double cambio = 1;
            double precoCompra = Convert.ToDouble(textBox3.Text);
            
            string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
            SqlDataReader dr;
            try
            {
                SqlConnection con3 = new SqlConnection(connectionString);
                con3.Open();

                SqlCommand cmd3 = new SqlCommand("SELECT Cambio FROM Moeda WHERE Moeda= '" + comboBox2.SelectedValue.ToString() + "'", con3);

                dr = cmd3.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        string str = dr.GetString(0);
                        cambio = Convert.ToDouble(str);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                dr.Close();
                con3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            double preco100 = precoCompra * cambio + alfandega;

            textBox4.Text = Convert.ToString(preco100);
        }
    }
}
