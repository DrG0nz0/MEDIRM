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

namespace MEDIRM
{
    public partial class AddArtigo : Form
    {
        public AddArtigo()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new CriarBD());
        }

        private void AddArtigo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Componentes'. Você pode movê-la ou removê-la conforme necessário.
            this.componentesTableAdapter.Fill(this.medirmDBDataSet.Componentes);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Cartolina'. Você pode movê-la ou removê-la conforme necessário.
            this.cartolinaTableAdapter.Fill(this.medirmDBDataSet.Cartolina);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Cartao'. Você pode movê-la ou removê-la conforme necessário.
            this.cartaoTableAdapter.Fill(this.medirmDBDataSet.Cartao);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Maquina'. Você pode movê-la ou removê-la conforme necessário.
            this.maquinaTableAdapter.Fill(this.medirmDBDataSet.Maquina);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("INSERT INTO Artigo (Nome, ID, UnBase, QtdCartao, QtdCartolina, QtdCartoesPalete, Cartao, Cartolina) VALUES (@Nome, @ID, @UnBase, @QtdCartao, @QtdCartolina, @QtdCartoesPalete, @Cartao, @Cartolina)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Nome", textBox1.Text);
                com.Parameters.AddWithValue("@ID", textBox2.Text);
                com.Parameters.AddWithValue("@UnBase", textBox5.Text);
                com.Parameters.AddWithValue("@QtdCartao", textBox6.Text);
                com.Parameters.AddWithValue("@QtdCartolina", textBox8.Text);
                com.Parameters.AddWithValue("@QtdCartoesPalete", textBox7.Text);


                string ed = comboBox7.Items[comboBox7.SelectedIndex].ToString();
                com.Parameters.AddWithValue("@Cartao", ed);

                string ed2 = comboBox8.Items[comboBox8.SelectedIndex].ToString();
                com.Parameters.AddWithValue("@Cartolina", ed2);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Artigo adicionado com sucesso!");

                //Clear the fields
                textBox1.Clear();
                textBox2.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                comboBox7.ResetText();
                comboBox8.ResetText();

            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar artigo. Por favor tente novamente.");
            }
        }
    }
}
