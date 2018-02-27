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
    public partial class GerirCartao : Form
    {
        public GerirCartao()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirBD());
        }

        private void GerirCartao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Cartao'. Você pode movê-la ou removê-la conforme necessário.
            this.cartaoTableAdapter.Fill(this.medirmDBDataSet.Cartao);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Moeda'. Você pode movê-la ou removê-la conforme necessário.
            this.moedaTableAdapter.Fill(this.medirmDBDataSet.Moeda);

            textBox3.Clear();
            textBox1.Clear();
            comboBox2.ResetText();
            comboBox1.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)  //apagar entrada da BD
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);


                SqlCommand com = new SqlCommand("DELETE FROM Cartao WHERE Designacao=@Designacao", con);
                com.CommandType = CommandType.Text;
                
                DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                String cb1 = drv["Designacao"].ToString();
                com.Parameters.AddWithValue("@Designacao", cb1);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Cartao eliminado com sucesso!");

                // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Cartao'. Você pode movê-la ou removê-la conforme necessário.
                this.cartaoTableAdapter.Fill(this.medirmDBDataSet.Cartao);
                // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Moeda'. Você pode movê-la ou removê-la conforme necessário.
                this.moedaTableAdapter.Fill(this.medirmDBDataSet.Moeda);

                //Clear the fields
                comboBox2.ResetText();


            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao eliminar cartao. Por favor tente novamente.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //preencher as text boxes
        {
            comboBox2.ResetText();

            string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
            SqlConnection con2 = new SqlConnection(connectionString);
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("Select * from Cartao where Designacao='" + comboBox1.Text.Trim() + "'", con2);

            try
            {
                DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                String cb1 = drv["Designacao"].ToString();
            }
            catch { }
            

            SqlDataReader reader = cmd2.ExecuteReader();
            if (reader.Read())
            {
                textBox3.Text = reader["PrecoCartolina"].ToString();
                textBox1.Text = reader["Volume"].ToString();
                comboBox2.DisplayMember = reader["Moeda"].ToString();
                comboBox2.SelectedText = reader["Moeda"].ToString();
                comboBox2.SelectedItem = reader["Moeda"].ToString();

                reader.Close();
                con2.Close();
            }
            else
            {
                MessageBox.Show("Erro ao exibir cartao. Por favor tente novamente.");
            }
        }

        private void criarMaquina_Click(object sender, EventArgs e) //modificar o conteudo da BD
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("UPDATE Cartao SET PrecoCartolina=@PrecoCartolina, Volume=@Volume, Moeda=@Moeda WHERE Designacao=@Designacao", con);
                com.CommandType = CommandType.Text;
                com.Parameters.AddWithValue("@PrecoCartolina", textBox3.Text);
                com.Parameters.AddWithValue("@Volume", textBox1.Text);
                com.Parameters.AddWithValue("@Moeda", comboBox2.SelectedValue.ToString());
                com.Parameters.AddWithValue("@Designacao", comboBox1.SelectedValue.ToString());

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Cartao alterado com sucesso!");

                //Clear the fields
                textBox3.Clear();
                textBox1.Clear();
                comboBox2.ResetText();
                comboBox1.ResetText();
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao alterar cartao. Por favor tente novamente.");
            }


        }
    }
}
