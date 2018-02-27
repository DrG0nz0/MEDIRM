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
    public partial class GerirCartolina : Form
    {
        public GerirCartolina()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirBD());
        }

        private void GerirCartolina_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Cartolina'. Você pode movê-la ou removê-la conforme necessário.
            this.cartolinaTableAdapter.Fill(this.medirmDBDataSet.Cartolina);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Moeda'. Você pode movê-la ou removê-la conforme necessário.
            this.moedaTableAdapter.Fill(this.medirmDBDataSet.Moeda);

            textBox3.Clear();
            comboBox2.ResetText();
            comboBox1.ResetText();

        }

        private void button1_Click(object sender, EventArgs e)      // eliminar cartolina
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);


                SqlCommand com = new SqlCommand("DELETE FROM Cartolina WHERE Designacao=@Designacao", con);
                com.CommandType = CommandType.Text;

                DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                String cb1 = drv["Designacao"].ToString();
                com.Parameters.AddWithValue("@Designacao", cb1);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Cartolina eliminada com sucesso!");

                // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Cartolina'. Você pode movê-la ou removê-la conforme necessário.
                this.cartolinaTableAdapter.Fill(this.medirmDBDataSet.Cartolina);

                //Clear the fields
                comboBox1.ResetText();


            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao eliminar cartolina. Por favor tente novamente.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)     // preencher campos quando muda index
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
            SqlConnection con2 = new SqlConnection(connectionString);
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("Select * from Cartolina where Designacao='" + comboBox1.Text.Trim() + "'", con2);

            try
            {
                DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                String cb1 = drv["Designacao"].ToString();
            }
            catch { }


            SqlDataReader reader = cmd2.ExecuteReader();
            if (reader.Read())
            {
                textBox3.Text = reader["PrecoMetro"].ToString();
                comboBox2.DisplayMember = reader["Moeda"].ToString();
                comboBox2.SelectedText = reader["Moeda"].ToString();


                reader.Close();
                con2.Close();
            }
            else
            {
                MessageBox.Show("Erro ao exibir cartao. Por favor tente novamente.");
            }
        }

        private void criarMaquina_Click(object sender, EventArgs e)     // alterar cartolina na BD
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("UPDATE Cartolina SET PrecoMetro=@PrecoMetro, Moeda=@Moeda WHERE Designacao=@Designacao", con);
                com.CommandType = CommandType.Text;
                com.Parameters.AddWithValue("@PrecoMetro", textBox3.Text);

                com.Parameters.AddWithValue("@Moeda", comboBox2.SelectedValue.ToString());
                com.Parameters.AddWithValue("@Designacao", comboBox1.SelectedValue.ToString());

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Cartolina alterada com sucesso!");

                //Clear the fields
                textBox3.Clear();
                comboBox2.ResetText();
                comboBox1.ResetText(); 
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao alterar cartolina. Por favor tente novamente.");
            }
        }
    }
}
