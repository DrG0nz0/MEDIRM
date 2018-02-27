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
    public partial class GerirFuncionarios : Form
    {
        public GerirFuncionarios()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirBD());
        }

        private void GerirFuncionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.medirmDBDataSet.Funcionario);

            //Clear the fields
            textBox3.Clear();
            textBox2.Clear();
            comboBox8.ResetText();

        }

        private void criarMaquina_Click(object sender, EventArgs e)     // guardar alteracaoes
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("UPDATE Funcionario SET ID=@ID, Sigla=@Sigla WHERE Nome=@Nome", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@ID", textBox2.Text);
                com.Parameters.AddWithValue("@Sigla", textBox3.Text);
                com.Parameters.AddWithValue("@Nome", comboBox8.SelectedValue.ToString());

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Funcionário alterado com sucesso!");

                //Clear the fields
                textBox3.Clear();
                textBox2.Clear();
                comboBox8.ResetText();
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao alterar funcionário. Por favor tente novamente.");
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)     // preencher os campos
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
            SqlConnection con2 = new SqlConnection(connectionString);
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("Select * from Funcionario where Nome='" + comboBox8.Text.Trim() + "'", con2);

            try
            {
                DataRowView drv = (DataRowView)comboBox8.SelectedItem;
                String cb1 = drv["Nome"].ToString();
            }
            catch { }


            SqlDataReader reader = cmd2.ExecuteReader();
            if (reader.Read())
            {
                textBox2.Text = reader["ID"].ToString();
                textBox3.Text = reader["Sigla"].ToString();

                reader.Close();
                con2.Close();
            }
            else
            {
                MessageBox.Show("Erro ao exibir funcionario. Por favor tente novamente.");
            }
        }

        private void button1_Click(object sender, EventArgs e)      // eliminar
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);


                SqlCommand com = new SqlCommand("DELETE FROM Funcionario WHERE Nome=@Nome", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Nome", comboBox8.SelectedValue.ToString());

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Funcionario eliminado com sucesso!");

                // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Cartolina'. Você pode movê-la ou removê-la conforme necessário.
                this.funcionarioTableAdapter.Fill(this.medirmDBDataSet.Funcionario);

                //Clear the fields
                comboBox8.ResetText();


            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao eliminar cartolina. Por favor tente novamente.");
            }
        }
    }
}
