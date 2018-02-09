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
    public partial class GerirMoldes : Form
    {
        public GerirMoldes()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirBD());
        }

        private void GerirMoldes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Molde'. Você pode movê-la ou removê-la conforme necessário.
            this.moldeTableAdapter.Fill(this.medirmDBDataSet.Molde);

        }

        private void criarMaquina_Click(object sender, EventArgs e)     // guardar
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("UPDATE Molde SET Cortantes=@Cortantes, PecasPorAvanco=@PecasPorAvanco, MetrosPorAvanco=@MetrosPorAvanco, Profundidade=@Profundidade WHERE Designacao=@Designacao", con);
                com.CommandType = CommandType.Text;
                com.Parameters.AddWithValue("@Cortantes", textBox1.ToString());
                com.Parameters.AddWithValue("@PecasPorAvanco", textBox2.ToString());
                com.Parameters.AddWithValue("@MetrosPorAvanco", textBox3.ToString());
                com.Parameters.AddWithValue("@Profundidade", textBox4.ToString());

                DataRowView drv2 = (DataRowView)comboBox1.SelectedItem;
                String cb2 = drv2["Designacao"].ToString();
                com.Parameters.AddWithValue("@Designacao", cb2);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Molde alterado com sucesso!");

                //Clear the fields
                textBox2.Clear();
                textBox1.Clear();
                textBox3.Clear();
                textBox4.Clear();
                comboBox1.ResetText();
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao alterar molde. Por favor tente novamente.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)     // preencher boxes
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
            SqlConnection con2 = new SqlConnection(connectionString);
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("Select * from Molde where Designacao='" + comboBox1.Text.Trim() + "'", con2);

            try
            {
                DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                String cb1 = drv["Designacao"].ToString();
            }
            catch { }


            SqlDataReader reader = cmd2.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = reader["Cortantes"].ToString();
                textBox2.Text = reader["PecasPorAvanco"].ToString();
                textBox3.Text = reader["MetrosPorAvanco"].ToString();
                textBox4.Text = reader["Profundidade"].ToString();
                
                reader.Close();
                con2.Close();
            }
            else
            {
                MessageBox.Show("Erro ao exibir molde. Por favor tente novamente.");
            }
        }

        private void button1_Click(object sender, EventArgs e)      // apagar
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);


                SqlCommand com = new SqlCommand("DELETE FROM Molde WHERE Designacao=@Designacao", con);
                com.CommandType = CommandType.Text;

                DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                String cb1 = drv["Designacao"].ToString();
                com.Parameters.AddWithValue("@Designacao", cb1);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Molde eliminado com sucesso!");

                
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao eliminar molde. Por favor tente novamente.");
            }

            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Molde'. Você pode movê-la ou removê-la conforme necessário.
            this.moldeTableAdapter.Fill(this.medirmDBDataSet.Molde);
        }
    }
}
