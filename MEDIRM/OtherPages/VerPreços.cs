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

namespace MEDIRM
{
    public partial class VerPreços : Form
    {
        public VerPreços()
        {
            InitializeComponent();
        }

        MedirmDBEntities me = new MedirmDBEntities();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VerPreços_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.VerPrecos'. Você pode movê-la ou removê-la conforme necessário.
            this.verPrecosTableAdapter.Fill(this.medirmDBDataSet.VerPrecos);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Artigo'. Você pode movê-la ou removê-la conforme necessário.
            this.artigoTableAdapter.Fill(this.medirmDBDataSet.Artigo);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.medirmDBDataSet.Cliente);

        }

        private void back_Click(object sender, EventArgs e)     // apagar a BD
        {
            try
            {
                //delete the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("DELETE FROM VerPrecos", con);
                com.CommandType = CommandType.Text;

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Clear the fields
                textBox3.Clear();
                comboBox2.ResetText();
                comboBox1.ResetText();

            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro.");
            }

            MainFormView.ShowForm(new Menu());
        }

        private void criarMaquina_Click(object sender, EventArgs e)     // adicionar um artigo
        {
            decimal preco=0;
            decimal margemLucro = 0;
            decimal custosFixos = 0;
            /*
            try
            {*/
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;

                // ir buscar o preço do artigo
                SqlConnection con2 = new SqlConnection(connectionString);
                con2.Open();
                SqlCommand cmd2 = new SqlCommand("Select * from ArtigosClientes where Cliente='" + comboBox1.Text.Trim() + "' AND Artigo='" + comboBox2.Text.Trim() + "'", con2);
                cmd2.CommandType = CommandType.Text;
                SqlDataReader reader = cmd2.ExecuteReader();
                if (reader.Read())
                {
                    string s = reader["Preco"].ToString();
                    preco = Convert.ToDecimal(s);
                    reader.Close();
                    con2.Close();
                }
                else
                {
                    con2.Close();
                    MessageBox.Show("Erro ao exibir preço. Por favor tente novamente.");
                }

                // ir buscar a margem de lucro
                SqlConnection con3 = new SqlConnection(connectionString);
                con3.Open();
                SqlCommand cmd3 = new SqlCommand("Select * from Cliente where Nome='" + comboBox1.Text.Trim() + "'", con3);
                cmd3.CommandType = CommandType.Text;
                SqlDataReader reader2 = cmd3.ExecuteReader();
                if (reader2.Read())
                {
                    string s = reader2["MargemLucro"].ToString();
                    preco = Convert.ToDecimal(s);
                
                    reader2.Close();
                    con3.Close();
                }
                else
                {
                    con3.Close();
                    MessageBox.Show("Erro ao exibir margem de lucro. Por favor tente novamente.");
                }
                /*
                // somar os custos fixos
                SqlConnection con4 = new SqlConnection(connectionString);
                con4.Open();
                SqlCommand cmd4 = new SqlCommand("Select SUM (Custo) from CustosFixos", con4);
                cmd4.CommandType = CommandType.Text;

                object result = cmd4.ExecuteScalar();
                string s2 = Convert.ToString(result);
                margemLucro = Convert.ToDecimal(s2);
                con4.Close();*/

                // finalemnte correr a query que mete tudo na BD
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                //Insert in the database
                SqlCommand com = new SqlCommand("INSERT INTO VerPrecos (Cliente, Artigo, Quantidade, Preco, MargemLucro, CustosFixos) VALUES (@Cliente, @Artigo, @Quantidade, @Preco, @MargemLucro, @CustosFixos)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Cliente", comboBox1.SelectedItem.ToString());
                com.Parameters.AddWithValue("@Artigo", comboBox2.SelectedItem.ToString());
                com.Parameters.AddWithValue("@Quantidade", textBox3.Text);
                com.Parameters.AddWithValue("@Preco", preco);
                com.Parameters.AddWithValue("@MargemLucro", margemLucro);
                com.Parameters.AddWithValue("@CustosFixos", '5');

                int i = com.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Artigo armazenado com sucesso.");


                //Clear the fields
                // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.VerPrecos'. Você pode movê-la ou removê-la conforme necessário.
                this.verPrecosTableAdapter.Fill(this.medirmDBDataSet.VerPrecos);
                verPrecosDataGridView.Refresh();
                textBox3.Clear();
                comboBox2.ResetText();
            /*
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar artigo ao cliente. Por favor tente novamente.");
            }*/
        }
    }
}
