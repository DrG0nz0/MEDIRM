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
    public partial class AddFuncionario : Form
    {
        public AddFuncionario()
        {
            InitializeComponent();
        }

        private void AddFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new CriarBD());
        }

        private void criarMaquina_Click(object sender, EventArgs e)
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("INSERT INTO Funcionario (Nome, ID, Sigla, Frente, Tras, Manual) VALUES (@Nome, @ID, @Sigla, @Frente, @Tras, @Manual)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Nome", textBox1.Text);
                com.Parameters.AddWithValue("@ID", textBox2.Text);
                com.Parameters.AddWithValue("@Sigla", textBox3.Text);

                if (checkBox1.Checked)
                {
                    com.Parameters.AddWithValue("@Frente", 1);
                }
                else
                {
                    com.Parameters.AddWithValue("@Frente", 0);
                }

                if (checkBox2.Checked)
                {
                    com.Parameters.AddWithValue("@Tras", 1);
                }
                else
                {
                    com.Parameters.AddWithValue("@Tras", 0);
                }

                if (checkBox3.Checked)
                {
                    com.Parameters.AddWithValue("@Manual", 1);
                }
                else
                {
                    com.Parameters.AddWithValue("@Manual", 0);
                }

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Funcionário adicionado com sucesso!");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar funcionário. Por favor tente novamente.");
            }

            /*

            try         // segunda feira
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("INSERT INTO TurnosFuncionarios (Funcionario, DiaDaSemana, Turno1, Turno2, Turno3, Turno4) VALUES (@Funcionario, @DiaDaSemana, @Turno1, @Turno2, @Turno3, @Turno4)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Funcionario", textBox1.Text);
                com.Parameters.AddWithValue("@DiaDaSemana", "Segunda-feira");
                com.Parameters.AddWithValue("@Turno1", "Nenhum");
                com.Parameters.AddWithValue("@Turno2", "Nenhum");
                com.Parameters.AddWithValue("@Turno3", "Nenhum");
                com.Parameters.AddWithValue("@Turno4", "Nenhum");
     

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar funcionário. Por favor tente novamente.");
            }

            try         // terca feira
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("INSERT INTO TurnosFuncionarios (Funcionario, DiaDaSemana, Turno1, Turno2, Turno3, Turno4) VALUES (@Funcionario, @DiaDaSemana, @Turno1, @Turno2, @Turno3, @Turno4)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Funcionario", textBox1.Text);
                com.Parameters.AddWithValue("@DiaDaSemana", "Terca-feira");
                com.Parameters.AddWithValue("@Turno1", "Nenhum");
                com.Parameters.AddWithValue("@Turno2", "Nenhum");
                com.Parameters.AddWithValue("@Turno3", "Nenhum");
                com.Parameters.AddWithValue("@Turno4", "Nenhum");


                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar funcionário. Por favor tente novamente.");
            }

            try         // quarta feira
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("INSERT INTO TurnosFuncionarios (Funcionario, DiaDaSemana, Turno1, Turno2, Turno3, Turno4) VALUES (@Funcionario, @DiaDaSemana, @Turno1, @Turno2, @Turno3, @Turno4)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Funcionario", textBox1.Text);
                com.Parameters.AddWithValue("@DiaDaSemana", "Quarta-feira");
                com.Parameters.AddWithValue("@Turno1", "Nenhum");
                com.Parameters.AddWithValue("@Turno2", "Nenhum");
                com.Parameters.AddWithValue("@Turno3", "Nenhum");
                com.Parameters.AddWithValue("@Turno4", "Nenhum");


                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar funcionário. Por favor tente novamente.");
            }

            try         // quinta feira
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("INSERT INTO TurnosFuncionarios (Funcionario, DiaDaSemana, Turno1, Turno2, Turno3, Turno4) VALUES (@Funcionario, @DiaDaSemana, @Turno1, @Turno2, @Turno3, @Turno4)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Funcionario", textBox1.Text);
                com.Parameters.AddWithValue("@DiaDaSemana", "Quinta-feira");
                com.Parameters.AddWithValue("@Turno1", "Nenhum");
                com.Parameters.AddWithValue("@Turno2", "Nenhum");
                com.Parameters.AddWithValue("@Turno3", "Nenhum");
                com.Parameters.AddWithValue("@Turno4", "Nenhum");


                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar funcionário. Por favor tente novamente.");
            }

            try         // sexta feira
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("INSERT INTO TurnosFuncionarios (Funcionario, DiaDaSemana, Turno1, Turno2, Turno3, Turno4) VALUES (@Funcionario, @DiaDaSemana, @Turno1, @Turno2, @Turno3, @Turno4)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Funcionario", textBox1.Text);
                com.Parameters.AddWithValue("@DiaDaSemana", "Sexta-feira");
                com.Parameters.AddWithValue("@Turno1", "Nenhum");
                com.Parameters.AddWithValue("@Turno2", "Nenhum");
                com.Parameters.AddWithValue("@Turno3", "Nenhum");
                com.Parameters.AddWithValue("@Turno4", "Nenhum");


                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar funcionário. Por favor tente novamente.");
            }

            try         // sabado
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("INSERT INTO TurnosFuncionarios (Funcionario, DiaDaSemana, Turno1, Turno2, Turno3, Turno4) VALUES (@Funcionario, @DiaDaSemana, @Turno1, @Turno2, @Turno3, @Turno4)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Funcionario", textBox1.Text);
                com.Parameters.AddWithValue("@DiaDaSemana", "Sabado");
                com.Parameters.AddWithValue("@Turno1", "Nenhum");
                com.Parameters.AddWithValue("@Turno2", "Nenhum");
                com.Parameters.AddWithValue("@Turno3", "Nenhum");
                com.Parameters.AddWithValue("@Turno4", "Nenhum");


                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Clear the fields
                textBox1.Clear();
                textBox2.Clear();

            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar funcionário. Por favor tente novamente.");
            } */
        }
    }
}
