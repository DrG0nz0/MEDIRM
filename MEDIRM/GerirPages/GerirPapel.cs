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
    public partial class GerirPapel : Form
    {
        public GerirPapel()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirBD());
        }

        private void GerirPapel_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Papel'. Você pode movê-la ou removê-la conforme necessário.
            this.papelTableAdapter.Fill(this.medirmDBDataSet.Papel);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Moeda'. Você pode movê-la ou removê-la conforme necessário.
            this.moedaTableAdapter.Fill(this.medirmDBDataSet.Moeda);

            //Clear the fields
            textBox3.Clear();
            textBox1.Clear();
            comboBox2.ResetText();
            comboBox1.ResetText();

        }

        private void criarMaquina_Click(object sender, EventArgs e)     // guardar
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("UPDATE Papel SET PrecoMetro=@PrecoMetro, MetodoCalculo=@MetodoCalculo, Moeda=@Moeda WHERE Designacao=@Designacao", con);
                com.CommandType = CommandType.Text;
                com.Parameters.AddWithValue("@PrecoMetro", textBox3.Text);
                com.Parameters.AddWithValue("@MetodoCalculo", textBox1.Text);
                com.Parameters.AddWithValue("@Moeda", comboBox2.SelectedValue.ToString());
                com.Parameters.AddWithValue("@Designacao", comboBox1.SelectedValue.ToString());

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Papel alterado com sucesso!");

                //Clear the fields
                textBox3.Clear();
                textBox1.Clear();
                comboBox2.ResetText();
                comboBox1.ResetText();
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao alterar papel. Por favor tente novamente.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)     // preencher
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
            SqlConnection con2 = new SqlConnection(connectionString);
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("Select * from Papel where Designacao='" + comboBox1.Text.Trim() + "'", con2);

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
                textBox1.Text = reader["MetodoCalculo"].ToString();
                comboBox2.DisplayMember = reader["Moeda"].ToString();
                comboBox2.SelectedText = reader["Moeda"].ToString();
                comboBox2.SelectedItem = reader["Moeda"].ToString();

                reader.Close();
                con2.Close();
            }
            else
            {
                MessageBox.Show("Erro ao exibir papel. Por favor tente novamente.");
            }
        }

        private void button1_Click(object sender, EventArgs e)      // apagar
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);


                SqlCommand com = new SqlCommand("DELETE FROM Papel WHERE Designacao=@Designacao", con);
                com.CommandType = CommandType.Text;

                DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                String cb1 = drv["Designacao"].ToString();
                com.Parameters.AddWithValue("@Designacao", cb1);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Papel eliminado com sucesso!");


                //Clear the fields
                comboBox2.ResetText();


            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao eliminar papel. Por favor tente novamente.");
            }
        }
    }
}
