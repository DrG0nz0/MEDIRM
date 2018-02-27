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
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Artigo'. Você pode movê-la ou removê-la conforme necessário.
            this.artigoTableAdapter.Fill(this.medirmDBDataSet.Artigo);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.medirmDBDataSet.Cliente);

        }

        private void back_Click(object sender, EventArgs e)     // apagar a BD
        {
            try
            {
                //Insert in the database
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
            String coefe = me.ComponentesDosArtigos.ToString();
            MessageBox.Show(coefe);











            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("INSERT INTO VerPrecos (Cliente, Artigo, Quantidade, Preco, MargemLucro, CustosFixos) VALUES (@Cliente, @Artigo, @Quantidade, @Preco, @MargemLucro, @CustosFixos)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Cliente", comboBox1.SelectedItem.ToString());
                com.Parameters.AddWithValue("@Artigo", comboBox2.SelectedItem.ToString());
                com.Parameters.AddWithValue("@Designacao", textBox3.Text);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Clear the fields
                textBox3.Clear();
                comboBox2.ResetText();

            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar artigo ao cliente. Por favor tente novamente.");
            }
        }
    }
}
