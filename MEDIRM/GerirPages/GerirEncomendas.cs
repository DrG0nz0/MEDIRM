using System;
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
    public partial class GerirEncomendas : Form
    {
        public GerirEncomendas()
        {
            InitializeComponent();
        }

        private void GerirEncomendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.ComponentesDosArtigo'. Você pode movê-la ou removê-la conforme necessário.
            this.componentesDosArtigosTableAdapter.Fill(this.medirmDBDataSet.ComponentesDosArtigos);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Encomenda'. Você pode movê-la ou removê-la conforme necessário.
            this.encomendaTableAdapter.Fill(this.medirmDBDataSet.Encomenda);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Encomenda'. Você pode movê-la ou removê-la conforme necessário.
            this.encomendaTableAdapter.Fill(this.medirmDBDataSet.Encomenda);

            //Clear the fields
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox2.ResetText();
            comboBox1.ResetText();

        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirBD());
        }

        private void criarMaquina_Click(object sender, EventArgs e)     // alterar encomenda
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            
            try
            {
                SqlCommand com = new SqlCommand("UPDATE Encomenda SET Estado=@Estado WHERE NumeroEnco=@NumeroEnco", con);
                com.CommandType = CommandType.Text;
                com.Parameters.AddWithValue("@Estado", comboBox2.SelectedText);
                com.Parameters.AddWithValue("@NumeroEnco", comboBox1.SelectedValue.ToString());

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao alterar estado da encomenda. Por favor tente novamente.");
            }
            
            try
            {
                int enc = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                  SqlCommand com2 = new SqlCommand("UPDATE Feitas SET Feitas=@Feitas WHERE Encomenda=@Encomenda AND Artigo=@Artigo AND Componente=@Componente", con);
                com2.CommandType = CommandType.Text;
                com2.Parameters.AddWithValue("@Feitas", Convert.ToInt32(textBox1.Text));
                com2.Parameters.AddWithValue("@Encomenda", enc);
                com2.Parameters.AddWithValue("@Artigo", textBox6.Text);
            
                con.Open();
                int j = com2.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Encomenda alterada com sucesso!");

                //Clear the fields
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                comboBox2.ResetText();
                comboBox1.ResetText();
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao alterar numero de componentes feitos. Por favor tente novamente.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)     // preencher
        {
            comboBox2.ResetText();

            string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
            SqlConnection con2 = new SqlConnection(connectionString);
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("Select * from Encomenda where NumeroEnco='" + comboBox1.Text.Trim() + "'", con2);

            SqlDataReader reader = cmd2.ExecuteReader();
            if (reader.Read())
            {
                textBox3.Text = reader["Cliente"].ToString();
                textBox6.Text = reader["Artigo"].ToString();
                textBox2.Text = reader["Quantidade"].ToString();
                textBox5.Text = reader["DataLimite"].ToString();
                textBox4.Text = reader["DataEntregaPrevista"].ToString();
                textBox1.Text = reader["Feitas"].ToString();
                comboBox2.DisplayMember = reader["Estado"].ToString();
                comboBox2.SelectedText = reader["Estado"].ToString();

                reader.Close();
                con2.Close();
            }
            else
            {
                MessageBox.Show("Erro ao exibir encomenda. Por favor tente novamente.");
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.componentesDosArtigosTableAdapter.Fill(this.medirmDBDataSet.ComponentesDosArtigos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
