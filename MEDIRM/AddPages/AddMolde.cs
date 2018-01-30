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

namespace MEDIRM
{
    public partial class AddMolde : Form
    {
        public AddMolde()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new CriarBD());
        }

        private void AddMolde_Load(object sender, EventArgs e)
        {

        }

        private void criarMaquina_Click(object sender, EventArgs e)
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("INSERT INTO Molde (Designacao, Cortantes, PecasPorAvanco, MetrosPorAvanco, Profundidade) VALUES (@Designacao, @Cortantes, @PecasPorAvanco, @MetrosPorAvanco, @Profundidade)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Designacao", minFrente.Text);
                com.Parameters.AddWithValue("@Cortantes", textBox1.Text);
                com.Parameters.AddWithValue("@PecasPorAvanco", textBox2.Text);
                com.Parameters.AddWithValue("@MetrosPorAvanco", textBox3.Text);
                com.Parameters.AddWithValue("@Profundidade", textBox4.Text);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Molde adicionado com sucesso!");

                //Clear the fields
                textBox3.Clear();
                textBox2.Clear();
                textBox1.Clear();
                textBox4.Clear();
                minFrente.Clear();

            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar molde. Por favor tente novamente.");
            }
        }
    }
}
