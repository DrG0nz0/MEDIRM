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
using System.Data.SqlClient;
using System.Configuration;

namespace MEDIRM.GerirPages
{
    public partial class GerirTransportes : Form
    {
        public GerirTransportes()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirBD());
        }

        private void GerirTransportes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Transporte'. Você pode movê-la ou removê-la conforme necessário.
            this.transporteTableAdapter.Fill(this.medirmDBDataSet.Transporte);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Moeda'. Você pode movê-la ou removê-la conforme necessário.
            this.moedaTableAdapter.Fill(this.medirmDBDataSet.Moeda);

        }

        private void button1_Click(object sender, EventArgs e)      // apagar
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);


                SqlCommand com = new SqlCommand("DELETE FROM Transporte WHERE Designacao=@Designacao", con);
                com.CommandType = CommandType.Text;

                DataRowView drv = (DataRowView)comboBox3.SelectedItem;
                String cb1 = drv["Designacao"].ToString();
                com.Parameters.AddWithValue("@Designacao", cb1);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Transporte eliminado com sucesso!");

                // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Transporte'. Você pode movê-la ou removê-la conforme necessário.
                this.transporteTableAdapter.Fill(this.medirmDBDataSet.Transporte);

                //Clear the fields
                comboBox2.ResetText();


            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao eliminar transporte. Por favor tente novamente.");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)     // preencher
        {
            comboBox2.ResetText();

            string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
            SqlConnection con2 = new SqlConnection(connectionString);
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("Select * from Transporte where Designacao='" + comboBox3.Text.Trim() + "'", con2);

            try
            {
                DataRowView drv = (DataRowView)comboBox3.SelectedItem;
                String cb1 = drv["Designacao"].ToString();
            }
            catch { }


            SqlDataReader reader = cmd2.ExecuteReader();        
            if (reader.Read())
            {
                minAtras.Text = reader["Transportadora"].ToString();
                textBox1.Text = reader["Preço"].ToString();
                maxTras.Text = reader["De"].ToString();
                textBox2.Text = reader["Para"].ToString();
                richTextBox1.Text = reader["Info"].ToString();
             
                comboBox2.DisplayMember = reader["Moeda"].ToString();
                comboBox2.SelectedText = reader["Moeda"].ToString();
                comboBox2.SelectedItem = reader["Moeda"].ToString();

                reader.Close();
                con2.Close();
            }
            else
            {
                MessageBox.Show("Erro ao exibir transporte. Por favor tente novamente.");
            }
        }

        private void criarMaquina_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                String user="";     //definir como o user que esta logado

                SqlCommand com = new SqlCommand("UPDATE Transporte SET Transportadora=@Transportadora, Preço=@Preço, De=@De, Para=@Para, Info=@Info, Utilizador=@Utilizador WHERE Designacao=@Designacao", con);
                com.CommandType = CommandType.Text;
                com.Parameters.AddWithValue("@Transportadora", minAtras.ToString());
                com.Parameters.AddWithValue("@Preço", textBox1.ToString());
                com.Parameters.AddWithValue("@De", maxTras.ToString());
                com.Parameters.AddWithValue("@Para", textBox2.ToString());
                com.Parameters.AddWithValue("@Info", richTextBox1.ToString());
                com.Parameters.AddWithValue("@Utilizador", user);

                DataRowView drv = (DataRowView)comboBox2.SelectedItem;
                String cb1 = drv["Moeda"].ToString();
                com.Parameters.AddWithValue("@Moeda", cb1);

                DataRowView drv2 = (DataRowView)comboBox3.SelectedItem;
                String cb2 = drv2["Designacao"].ToString();
                com.Parameters.AddWithValue("@Designacao", cb2);

                


                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Transporte alterado com sucesso!");

                //Clear the fields
                minAtras.Clear();
                textBox1.Clear();
                comboBox2.ResetText();
                maxTras.ResetText();
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao alterar transporte. Por favor tente novamente.");
            }
        }
    }
}
