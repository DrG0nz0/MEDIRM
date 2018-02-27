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
    public partial class AddComponentesArtigos : Form
    {
        public AddComponentesArtigos()
        {
            InitializeComponent();
        }

        private void AddComponentesArtigos_Load(object sender, EventArgs e)
        {

            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Artigo'. Você pode movê-la ou removê-la conforme necessário.
            this.artigoTableAdapter.Fill(this.medirmDBDataSet.Artigo);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Maquina'. Você pode movê-la ou removê-la conforme necessário.
            this.maquinaTableAdapter.Fill(this.medirmDBDataSet.Maquina);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Componentes'. Você pode movê-la ou removê-la conforme necessário.
            this.componentesTableAdapter.Fill(this.medirmDBDataSet.Componentes);

            textBox1.Clear();
            comboBox1.ResetText();
            comboBox3.ResetText();
            comboBox4.ResetText();
            comboBox5.ResetText();
            comboBox6.ResetText();
            comboBox7.ResetText();
            comboBox8.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)      // adicionar componente
        {
            if (checkBox5.Checked && checkBox4.Checked && checkBox3.Checked && checkBox2.Checked && checkBox1.Checked)
            {
                try
                {
                    //Insert in the database
                    string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                    SqlConnection con = new SqlConnection(connectionString);

                    SqlCommand com = new SqlCommand("INSERT INTO ComponentesDosArtigos (Artigo, Componente, Quantidade, Maquina1, Maquina2, Maquina3, Maquina4, Maquina5) VALUES (@Artigo, @Componente, @Quantidade, @Maquina1, @Maquina2, @Maquina3, @Maquina4, @Maquina5)", con);
                    com.CommandType = CommandType.Text;

                    com.Parameters.AddWithValue("@Quantidade", textBox1.Text);

                    com.Parameters.AddWithValue("@Artigo", comboBox3.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@Componente", comboBox8.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@Maquina1", comboBox7.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@Maquina2", comboBox1.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@Maquina3", comboBox4.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@Maquina4", comboBox5.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@Maquina5", comboBox6.SelectedValue.ToString());

                    con.Open();
                    int i = com.ExecuteNonQuery();
                    con.Close();

                    //Confirmation Message 
                    MessageBox.Show("Componente adicionado ao artigo com sucesso!");

                    //Clear the fields
                    textBox1.Clear();
                    comboBox1.ResetText();
                    comboBox3.ResetText();
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

                    SqlCommand com = new SqlCommand("INSERT INTO ComponentesDosArtigos (Artigo, Componente, Quantidade, Maquina1, Maquina2, Maquina3, Maquina4) VALUES (@Artigo, @Componente, @Quantidade, @Maquina1, @Maquina2, @Maquina3, @Maquina4)", con);
                    com.CommandType = CommandType.Text;

                    com.Parameters.AddWithValue("@Quantidade", textBox1.Text);

                    com.Parameters.AddWithValue("@Artigo", comboBox3.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@Componente", comboBox8.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@Maquina1", comboBox7.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@Maquina2", comboBox1.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@Maquina3", comboBox4.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@Maquina4", comboBox5.SelectedValue.ToString());

                    con.Open();
                    int i = com.ExecuteNonQuery();
                    con.Close();

                    //Confirmation Message 
                    MessageBox.Show("Componente adicionado ao artigo com sucesso!");

                    //Clear the fields
                    textBox1.Clear();
                    comboBox1.ResetText();
                    comboBox3.ResetText();
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

                    SqlCommand com = new SqlCommand("INSERT INTO ComponentesDosArtigos (Artigo, Componente, Quantidade, Maquina1, Maquina2, Maquina3) VALUES (@Artigo, @Componente, @Quantidade, @Maquina1, @Maquina2, @Maquina3)", con);
                    com.CommandType = CommandType.Text;

                    com.Parameters.AddWithValue("@Quantidade", textBox1.Text);

                    com.Parameters.AddWithValue("@Artigo", comboBox3.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@Componente", comboBox8.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@Maquina1", comboBox7.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@Maquina2", comboBox1.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@Maquina3", comboBox4.SelectedValue.ToString());

                    con.Open();
                    int i = com.ExecuteNonQuery();
                    con.Close();

                    //Confirmation Message 
                    MessageBox.Show("Componente adicionado ao artigo com sucesso!");

                    //Clear the fields
                    textBox1.Clear();
                    comboBox1.ResetText();
                    comboBox3.ResetText();
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

                    SqlCommand com = new SqlCommand("INSERT INTO ComponentesDosArtigos (Artigo, Componente, Quantidade, Maquina1, Maquina2) VALUES (@Artigo, @Componente, @Quantidade, @Maquina1, @Maquina2)", con);
                    com.CommandType = CommandType.Text;

                    com.Parameters.AddWithValue("@Quantidade", textBox1.Text);

                    com.Parameters.AddWithValue("@Artigo", comboBox3.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@Componente", comboBox8.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@Maquina1", comboBox7.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@Maquina2", comboBox1.SelectedValue.ToString());

                    con.Open();
                    int i = com.ExecuteNonQuery();
                    con.Close();

                    //Confirmation Message 
                    MessageBox.Show("Componente adicionado ao artigo com sucesso!");

                    //Clear the fields
                    textBox1.Clear();
                    comboBox1.ResetText();
                    comboBox3.ResetText();
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

                    SqlCommand com = new SqlCommand("INSERT INTO ComponentesDosArtigos (Artigo, Componente, Quantidade, Maquina1) VALUES (@Artigo, @Componente, @Quantidade, @Maquina1)", con);
                    com.CommandType = CommandType.Text;

                    com.Parameters.AddWithValue("@Quantidade", textBox1.Text);

                    com.Parameters.AddWithValue("@Artigo", comboBox3.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@Componente", comboBox8.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@Maquina1", comboBox7.SelectedValue.ToString());

                    con.Open();
                    int i = com.ExecuteNonQuery();
                    con.Close();

                    //Confirmation Message 
                    MessageBox.Show("Componente adicionado ao artigo com sucesso!");

                    //Clear the fields
                    textBox1.Clear();
                    comboBox1.ResetText();
                    comboBox3.ResetText();
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
                MessageBox.Show("Erro ao adicionar componente ao artigo. Por favor coloque as máquinas por ordem e tente novamente.");
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirBD());
        }

        



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox7.Visible = true;
                button6.Visible = true;
            }
            else
            {
                comboBox7.Visible = false;
                button6.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox1.Visible = true;
                button1.Visible = true;
            }
            else
            {
                comboBox1.Visible = false;
                button1.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox4.Visible = true;
                button9.Visible = true;
            }
            else
            {
                comboBox4.Visible = false;
                button9.Visible = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox5.Visible = true;
                button8.Visible = true;
            }
            else
            {
                comboBox5.Visible = false;
                button8.Visible = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox6.Visible = true;
                button7.Visible = true;
            }
            else
            {
                comboBox6.Visible = false;
                button7.Visible = false;
            }
        }
    }
}
