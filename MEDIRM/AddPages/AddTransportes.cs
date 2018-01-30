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
                com.Parameters.AddWithValue("@Info", richTextBox1.Text);        // nao sei se funciona assim
                com.Parameters.AddWithValue("@Utilizador", "enas");        // criar func para ir ver o user


                DataRowView drv = (DataRowView)comboBox2.SelectedItem;
                String cb1 = drv["Moeda"].ToString();
                com.Parameters.AddWithValue("@Moeda", cb1);

                DataRowView drv2 = (DataRowView)comboBox2.SelectedItem;
                String cb2 = drv2["Transportadora"].ToString();
                com.Parameters.AddWithValue("@Transportadora", cb2);

                DataRowView drv3 = (DataRowView)comboBox2.SelectedItem;
                String cb3 = drv3["De"].ToString();
                com.Parameters.AddWithValue("@De", cb3);

                DataRowView drv4 = (DataRowView)comboBox2.SelectedItem;
                String cb4 = drv4["Para"].ToString();
                com.Parameters.AddWithValue("@Para", cb4);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Filme adicionado com sucesso!");

                //Clear the fields
                textBox3.Clear();
                richTextBox1.Clear();
                textBox1.Clear();
                comboBox2.ResetText();
                comboBox1.ResetText();
                comboBox3.ResetText();
                comboBox4.ResetText();

            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar filme. Por favor tente novamente.");
            }
        }
    }
}
