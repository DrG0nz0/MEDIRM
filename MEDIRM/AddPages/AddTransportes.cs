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
    public partial class AddTransportes : Form
    {
        public AddTransportes()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new CriarBD());
        }

        private void AddTransportes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Moeda'. Você pode movê-la ou removê-la conforme necessário.
            this.moedaTableAdapter.Fill(this.medirmDBDataSet.Moeda);

        }

        private void criarMaquina_Click(object sender, EventArgs e)
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("INSERT INTO Transporte (Designacao, Preco, Moeda, Transportadora, Utilizador, De, Para, Info) VALUES (@Designacao, @Preco, @Moeda, @Transportadora, @Utilizador, @De, @Para, @Info)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Designacao", textBox1.Text);
                com.Parameters.AddWithValue("@Preco", textBox3.Text);
                com.Parameters.AddWithValue("@Info", richTextBox1.Text);     
                com.Parameters.AddWithValue("@Utilizador", "User");        // criar func para ir ver o user

                com.Parameters.AddWithValue("@Transportadora", textBox5.Text);
                com.Parameters.AddWithValue("@De", textBox2.Text);
                com.Parameters.AddWithValue("@Para", textBox4.Text);


                DataRowView drv = (DataRowView)comboBox2.SelectedItem;
                String cb1 = drv["Moeda"].ToString();
                com.Parameters.AddWithValue("@Moeda", cb1);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Transporte adicionado com sucesso!");

                //Clear the fields
                textBox3.Clear();
                richTextBox1.Clear();
                textBox1.Clear();
                comboBox2.ResetText();
                textBox5.Clear();
                textBox2.Clear();
                textBox4.Clear();
            
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar transporte. Por favor tente novamente.");
            }
        }
    }
}
