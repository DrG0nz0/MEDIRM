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
using System.Configuration;
using System.Data.SqlClient;

namespace MEDIRM.GerirPages
{
    public partial class GerirEsterilizacao : Form
    {
        public GerirEsterilizacao()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirBD());
        }

        private void GerirEsterilizacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Esterilizacao'. Você pode movê-la ou removê-la conforme necessário.
            this.esterilizacaoTableAdapter.Fill(this.medirmDBDataSet.Esterilizacao);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Moeda'. Você pode movê-la ou removê-la conforme necessário.
            this.moedaTableAdapter.Fill(this.medirmDBDataSet.Moeda);

        }

        private void button1_Click(object sender, EventArgs e)      // eliminar
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);


                SqlCommand com = new SqlCommand("DELETE FROM Esterilizacao WHERE Designacao=@Designacao", con);
                com.CommandType = CommandType.Text;

                DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                String cb1 = drv["Designacao"].ToString();
                com.Parameters.AddWithValue("@Designacao", cb1);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Esterilizacao eliminada com sucesso!");

                // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Esterilizacao'. Você pode movê-la ou removê-la conforme necessário.
                this.esterilizacaoTableAdapter.Fill(this.medirmDBDataSet.Esterilizacao);

                //Clear the fields
                comboBox2.ResetText();
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao eliminar esterilizacao. Por favor tente novamente.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)     // preencher
        {
            comboBox2.ResetText();

            string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
            SqlConnection con2 = new SqlConnection(connectionString);
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("Select * from Esterilizacao where Designacao='" + comboBox1.Text.Trim() + "'", con2);

            try
            {
                DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                String cb1 = drv["Designacao"].ToString();
            }
            catch { }


            SqlDataReader reader = cmd2.ExecuteReader();
            if (reader.Read())
            {
                textBox3.Text = reader["Preco"].ToString();
                comboBox2.DisplayMember = reader["Moeda"].ToString();
                comboBox2.SelectedText = reader["Moeda"].ToString();
                comboBox2.SelectedItem = reader["Moeda"].ToString();

                reader.Close();
                con2.Close();
            }
            else
            {
                MessageBox.Show("Erro ao exibir esterilizacao. Por favor tente novamente.");
            }
        }

        private void criarMaquina_Click(object sender, EventArgs e)     // alterar
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("UPDATE Esterilizacao SET Preco=@Precoa, Moeda=@Moeda WHERE Designacao=@Designacao", con);
                com.CommandType = CommandType.Text;
                com.Parameters.AddWithValue("@Preco", textBox3.ToString());

                DataRowView drv = (DataRowView)comboBox2.SelectedItem;
                String cb1 = drv["Moeda"].ToString();
                com.Parameters.AddWithValue("@Moeda", cb1);

                DataRowView drv2 = (DataRowView)comboBox1.SelectedItem;
                String cb2 = drv2["Designacao"].ToString();
                com.Parameters.AddWithValue("@Designacao", cb2);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Esterilizacao alterada com sucesso!");

                //Clear the fields
                textBox3.Clear();
                comboBox2.ResetText();
                comboBox1.ResetText();
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao alterar esterilizacao. Por favor tente novamente.");
            }
        }
    }
}
