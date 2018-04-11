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

            comboBox1.ResetText();
            comboBox4.ResetText();
            comboBox5.ResetText();
            comboBox6.ResetText();
            comboBox7.ResetText();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {            
                if (checkBox5.Checked && checkBox4.Checked && checkBox3.Checked && checkBox2.Checked && checkBox1.Checked)
                {
                    try
                    {
                        //Insert in the database
                        string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                        SqlConnection con = new SqlConnection(connectionString);

                        SqlCommand com = new SqlCommand("INSERT INTO Artigo (Nome, ID, UnBase, QtdCartao, QtdCartolina, QtdCartoesPalete, Cartao, Cartolina, Maquina1, Maquina2, Maquina3, Maquina4, Maquina5) VALUES ((@Nome, @ID, @UnBase, @QtdCartao, @QtdCartolina, @QtdCartoesPalete, @Cartao, @Cartolina, @Maquina1, @Maquina2, @Maquina3, @Maquina4, @Maquina5)", con);
                        com.CommandType = CommandType.Text;

                        com.Parameters.AddWithValue("@Nome", textBox1.Text);
                        com.Parameters.AddWithValue("@ID", textBox2.Text);
                        com.Parameters.AddWithValue("@UnBase", textBox5.Text);
                        com.Parameters.AddWithValue("@QtdCartao", textBox6.Text);
                        com.Parameters.AddWithValue("@QtdCartolina", textBox8.Text);
                        com.Parameters.AddWithValue("@QtdCartoesPalete", textBox7.Text);
                        com.Parameters.AddWithValue("@Componente", comboBox8.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina1", comboBox7.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina2", comboBox1.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina3", comboBox4.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina4", comboBox5.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina5", comboBox6.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Cartao", comboBox7.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Cartolina", comboBox8.SelectedValue.ToString());

                        con.Open();
                        int i = com.ExecuteNonQuery();
                        con.Close();

                        //Confirmation Message 
                        MessageBox.Show("Artigo adicionado com sucesso!");

                        //Clear the fields
                        textBox1.Clear();
                        comboBox1.ResetText();
                        comboBox4.ResetText();
                        comboBox5.ResetText();
                        comboBox6.ResetText();
                        comboBox7.ResetText();
                        comboBox8.ResetText();
                        button1.Visible = false;
                        button9.Visible = false;
                        button8.Visible = false;
                        button7.Visible = false;
                        button6.Visible = false;
                        comboBox1.Visible = false;
                        comboBox4.Visible = false;
                        comboBox6.Visible = false;
                        comboBox7.Visible = false;
                    }
                    catch (Exception x)
                    {
                        //Error Message 
                        MessageBox.Show("Erro ao adicionar componente ao artigo. Por favor tente novamente.");
                    }
                }

                if (!checkBox5.Checked && checkBox4.Checked && checkBox3.Checked && checkBox2.Checked && checkBox1.Checked)
                {
                    try
                    {
                        //Insert in the database
                        string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                        SqlConnection con = new SqlConnection(connectionString);

                        SqlCommand com = new SqlCommand("INSERT INTO Artigo (Nome, ID, UnBase, QtdCartao, QtdCartolina, QtdCartoesPalete, Cartao, Cartolina, Maquina1, Maquina2, Maquina3, Maquina4) VALUES (@Nome, @ID, @UnBase, @QtdCartao, @QtdCartolina, @QtdCartoesPalete, @Cartao, @Cartolina, @Maquina1, @Maquina2, @Maquina3, @Maquina4)", con);
                        com.CommandType = CommandType.Text;

                        com.Parameters.AddWithValue("@Nome", textBox1.Text);
                        com.Parameters.AddWithValue("@ID", textBox2.Text);
                        com.Parameters.AddWithValue("@UnBase", textBox5.Text);
                        com.Parameters.AddWithValue("@QtdCartao", textBox6.Text);
                        com.Parameters.AddWithValue("@QtdCartolina", textBox8.Text);
                        com.Parameters.AddWithValue("@QtdCartoesPalete", textBox7.Text);
                        com.Parameters.AddWithValue("@Componente", comboBox8.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina1", comboBox7.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina2", comboBox1.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina3", comboBox4.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina4", comboBox5.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Cartao", comboBox7.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Cartolina", comboBox8.SelectedValue.ToString());

                        con.Open();
                        int i = com.ExecuteNonQuery();
                        con.Close();

                        //Confirmation Message 
                        MessageBox.Show("Artigo adicionado com sucesso!");

                        //Clear the fields
                        textBox1.Clear();
                        comboBox1.ResetText();
                        comboBox4.ResetText();
                        comboBox5.ResetText();
                        comboBox6.ResetText();
                        comboBox7.ResetText();
                        comboBox8.ResetText();
                        button1.Visible = false;
                        button9.Visible = false;
                        button8.Visible = false;
                        button7.Visible = false;
                        button6.Visible = false;
                        comboBox1.Visible = false;
                        comboBox4.Visible = false;
                        comboBox6.Visible = false;
                        comboBox7.Visible = false;
                    }
                    catch (Exception x)
                    {
                        //Error Message 
                        MessageBox.Show("Erro ao adicionar componente ao artigo. Por favor tente novamente.");
                    }
                }

                if (!checkBox5.Checked && !checkBox4.Checked && checkBox3.Checked && checkBox2.Checked && checkBox1.Checked)
                {
                    try
                    {
                        //Insert in the database
                        string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                        SqlConnection con = new SqlConnection(connectionString);

                        SqlCommand com = new SqlCommand("INSERT INTO Artigo (Nome, ID, UnBase, QtdCartao, QtdCartolina, QtdCartoesPalete, Cartao, Cartolina, Maquina1, Maquina2, Maquina3) VALUES (@Nome, @ID, @UnBase, @QtdCartao, @QtdCartolina, @QtdCartoesPalete, @Cartao, @Cartolina, @Maquina1, @Maquina2, @Maquina3)", con);
                        com.CommandType = CommandType.Text;

                        com.Parameters.AddWithValue("@Nome", textBox1.Text);
                        com.Parameters.AddWithValue("@ID", textBox2.Text);
                        com.Parameters.AddWithValue("@UnBase", textBox5.Text);
                        com.Parameters.AddWithValue("@QtdCartao", textBox6.Text);
                        com.Parameters.AddWithValue("@QtdCartolina", textBox8.Text);
                        com.Parameters.AddWithValue("@QtdCartoesPalete", textBox7.Text);
                        com.Parameters.AddWithValue("@Componente", comboBox8.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina1", comboBox7.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina2", comboBox1.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina3", comboBox4.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Cartao", comboBox7.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Cartolina", comboBox8.SelectedValue.ToString());

                        con.Open();
                        int i = com.ExecuteNonQuery();
                        con.Close();

                        //Confirmation Message 
                        MessageBox.Show("Artigo adicionado com sucesso!");

                        //Clear the fields
                        textBox1.Clear();
                        comboBox1.ResetText();
                        comboBox4.ResetText();
                        comboBox5.ResetText();
                        comboBox6.ResetText();
                        comboBox7.ResetText();
                        comboBox8.ResetText();
                        button1.Visible = false;
                        button9.Visible = false;
                        button8.Visible = false;
                        button7.Visible = false;
                        button6.Visible = false;
                        comboBox1.Visible = false;
                        comboBox4.Visible = false;
                        comboBox6.Visible = false;
                        comboBox7.Visible = false;
                    }
                    catch (Exception x)
                    {
                        //Error Message 
                        MessageBox.Show("Erro ao adicionar componente ao artigo. Por favor tente novamente.");
                    }
                }

                if (!checkBox5.Checked && !checkBox4.Checked && !checkBox3.Checked && checkBox2.Checked && checkBox1.Checked)
                {
                    try
                    {
                        //Insert in the database
                        string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                        SqlConnection con = new SqlConnection(connectionString);

                        SqlCommand com = new SqlCommand("INSERT INTO Artigo (Nome, ID, UnBase, QtdCartao, QtdCartolina, QtdCartoesPalete, Cartao, Cartolina, Maquina1, Maquina2) VALUES (@Nome, @ID, @UnBase, @QtdCartao, @QtdCartolina, @QtdCartoesPalete, @Cartao, @Cartolina, @Maquina1, @Maquina2)", con);
                        com.CommandType = CommandType.Text;

                        com.Parameters.AddWithValue("@Nome", textBox1.Text);
                        com.Parameters.AddWithValue("@ID", textBox2.Text);
                        com.Parameters.AddWithValue("@UnBase", textBox5.Text);
                        com.Parameters.AddWithValue("@QtdCartao", textBox6.Text);
                        com.Parameters.AddWithValue("@QtdCartolina", textBox8.Text);
                        com.Parameters.AddWithValue("@QtdCartoesPalete", textBox7.Text);
                        com.Parameters.AddWithValue("@Componente", comboBox8.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina1", comboBox7.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina2", comboBox1.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Cartao", comboBox7.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Cartolina", comboBox8.SelectedValue.ToString());

                        con.Open();
                        int i = com.ExecuteNonQuery();
                        con.Close();

                        //Confirmation Message 
                        MessageBox.Show("Artigo adicionado com sucesso!");

                        //Clear the fields
                        textBox1.Clear();
                        comboBox1.ResetText();
                        comboBox4.ResetText();
                        comboBox5.ResetText();
                        comboBox6.ResetText();
                        comboBox7.ResetText();
                        comboBox8.ResetText();
                        button1.Visible = false;
                        button9.Visible = false;
                        button8.Visible = false;
                        button7.Visible = false;
                        button6.Visible = false;
                        comboBox1.Visible = false;
                        comboBox4.Visible = false;
                        comboBox6.Visible = false;
                        comboBox7.Visible = false;
                    }
                    catch (Exception x)
                    {
                        //Error Message 
                        MessageBox.Show("Erro ao adicionar componente ao artigo. Por favor tente novamente.");
                    }
                }

                if (!checkBox5.Checked && !checkBox4.Checked && !checkBox3.Checked && !checkBox2.Checked && checkBox1.Checked)
                {
                    try
                    {
                        //Insert in the database
                        string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                        SqlConnection con = new SqlConnection(connectionString);

                        SqlCommand com = new SqlCommand("INSERT INTO Artigo (Nome, ID, UnBase, QtdCartao, QtdCartolina, QtdCartoesPalete, Cartao, Cartolina, Maquina1) VALUES (@Nome, @ID, @UnBase, @QtdCartao, @QtdCartolina, @QtdCartoesPalete, @Cartao, @Cartolina, @Maquina1)", con);
                        com.CommandType = CommandType.Text;

                        com.Parameters.AddWithValue("@Nome", textBox1.Text);
                        com.Parameters.AddWithValue("@ID", textBox2.Text);
                        com.Parameters.AddWithValue("@UnBase", textBox5.Text);
                        com.Parameters.AddWithValue("@QtdCartao", textBox6.Text);
                        com.Parameters.AddWithValue("@QtdCartolina", textBox8.Text);
                        com.Parameters.AddWithValue("@QtdCartoesPalete", textBox7.Text);
                        com.Parameters.AddWithValue("@Componente", comboBox8.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Maquina1", comboBox7.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Cartao", comboBox7.SelectedValue.ToString());
                        com.Parameters.AddWithValue("@Cartolina", comboBox8.SelectedValue.ToString());

                        con.Open();
                        int i = com.ExecuteNonQuery();
                        con.Close();

                        //Confirmation Message 
                        MessageBox.Show("Artigo adicionado com sucesso!");

                        //Clear the fields
                        textBox1.Clear();
                        comboBox1.ResetText();
                        comboBox4.ResetText();
                        comboBox5.ResetText();
                        comboBox6.ResetText();
                        comboBox7.ResetText();
                        comboBox8.ResetText();
                        button1.Visible = false;
                        button9.Visible = false;
                        button8.Visible = false;
                        button7.Visible = false;
                        button6.Visible = false;
                        comboBox1.Visible = false;
                        comboBox4.Visible = false;
                        comboBox6.Visible = false;
                        comboBox7.Visible = false;
                    }
                    catch (Exception x)
                    {
                        //Error Message 
                        MessageBox.Show("Erro ao adicionar componente ao artigo. Por favor tente novamente.");
                    }
                }

                else
                {
                    MessageBox.Show("Erro ao adicionar maquina ao artigo. Por favor coloque as máquinas por ordem e tente novamente.");
                }

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
                comboBox1.ResetText();
                comboBox4.ResetText();
                comboBox5.ResetText();
                comboBox6.ResetText();
                comboBox7.ResetText();

            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar artigo. Por favor tente novamente.");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
