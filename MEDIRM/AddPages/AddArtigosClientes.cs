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

namespace MEDIRM.AddPages
{
    public partial class AddArtigosClientes : Form
    {
        public AddArtigosClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)      // addicionar artigo ao cliente
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("INSERT INTO ArtigosClientes (Cliente, Artigo, Preco) VALUES (@Cliente, @Artigo, @Preco)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Preco", textBox3.Text);

                com.Parameters.AddWithValue("@Cliente", comboBox2.SelectedValue.ToString());
                com.Parameters.AddWithValue("@Artigo", comboBox3.SelectedValue.ToString());

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Artigo adicionado ao cliente com sucesso!");

                //Clear the fields

                textBox3.Clear();
                comboBox2.ResetText();
                comboBox3.ResetText();

            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar artigo ao cliente. Por favor tente novamente.");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirBD());
        }

        private void AddArtigosClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Artigo'. Você pode movê-la ou removê-la conforme necessário.
            this.artigoTableAdapter.Fill(this.medirmDBDataSet.Artigo);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.medirmDBDataSet.Cliente);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);


                SqlCommand com = new SqlCommand("DELETE FROM ArtigosClientes WHERE Cliente=@Cliente AND Artigo=@Artigo", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Cliente", comboBox2.SelectedValue.ToString());
                com.Parameters.AddWithValue("@Artigo", comboBox3.SelectedValue.ToString());

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Artigo eliminado com sucesso!");

                // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Artigo'. Você pode movê-la ou removê-la conforme necessário.
                this.artigoTableAdapter.Fill(this.medirmDBDataSet.Artigo);
                // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
                this.clienteTableAdapter.Fill(this.medirmDBDataSet.Cliente);

                //Clear the fields
                comboBox2.ResetText();
                comboBox3.ResetText();

            
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao eliminar artigo. Por favor tente novamente.");
            }
        }
    }
}
