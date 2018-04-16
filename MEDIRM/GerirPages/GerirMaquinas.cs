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
    public partial class GerirMaquinas : Form
    {
        public GerirMaquinas()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirBD());
        }

        private void GerirMaquinas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Molde'. Você pode movê-la ou removê-la conforme necessário.
            this.moldeTableAdapter.Fill(this.medirmDBDataSet.Molde);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Papel'. Você pode movê-la ou removê-la conforme necessário.
            this.papelTableAdapter.Fill(this.medirmDBDataSet.Papel);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Filme'. Você pode movê-la ou removê-la conforme necessário.
            this.filmeTableAdapter.Fill(this.medirmDBDataSet.Filme);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.TipoMaquina'. Você pode movê-la ou removê-la conforme necessário.
            this.tipoMaquinaTableAdapter.Fill(this.medirmDBDataSet.TipoMaquina);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Maquina'. Você pode movê-la ou removê-la conforme necessário.
            this.maquinaTableAdapter.Fill(this.medirmDBDataSet.Maquina);

            //Clear the fields
            minFrente.Clear();
            maxFrente.Clear();
            minAtras.Clear();
            maxTras.Clear();
            textBox2.Clear();
            textBox1.Clear();
            comboBox7.ResetText();
            comboBox1.ResetText();
            comboBox6.ResetText();
            comboBox5.ResetText();
            comboBox2.ResetText();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void criarMaquina_Click(object sender, EventArgs e)     // alterar
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("UPDATE Maquina SET Filme=@Filme, Papel=@Papel, Molde=@Molde, Tipo=@Tipo, MinPessFrente=@MinPessFrente, MaxPessFrente=@MaxPessFrente, MinPessTras=@MinPessTras, MaxPessTras=@MaxPessTras, Velocidade1=@Velocidade1, Velocidade2=@Velocidade2 WHERE Nome=@Nome", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@MinPessFrente", minFrente.Text);
                com.Parameters.AddWithValue("@MaxPessFrente", maxFrente.Text);
                com.Parameters.AddWithValue("@MinPessTras", minAtras.Text);
                com.Parameters.AddWithValue("@MaxPessTras", maxTras.Text);
                com.Parameters.AddWithValue("@Velocidade1", textBox2.Text);
                com.Parameters.AddWithValue("@Velocidade2", textBox1.Text);
                com.Parameters.AddWithValue("@Tipo", comboBox1.SelectedValue.ToString());
                com.Parameters.AddWithValue("@Filme", comboBox7.SelectedValue.ToString());
                com.Parameters.AddWithValue("@Papel", comboBox6.SelectedValue.ToString());
                com.Parameters.AddWithValue("@Molde", comboBox5.SelectedValue.ToString());
                com.Parameters.AddWithValue("@Nome", comboBox2.SelectedValue.ToString());

            con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Maquina alterada com sucesso!");

                //Clear the fields
                minFrente.Clear();
                maxFrente.Clear();
                minAtras.Clear();
                maxTras.Clear();
                textBox2.Clear();
                textBox1.Clear();
                comboBox7.ResetText();
                comboBox1.ResetText();
                comboBox6.ResetText();
                comboBox5.ResetText();
                comboBox2.ResetText();
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao alterar maquina. Por favor tente novamente.");
            }
        }

        private void button1_Click(object sender, EventArgs e)      // eliminar
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);


                SqlCommand com = new SqlCommand("DELETE FROM Maquina WHERE Nome=@Nome", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Nome", comboBox2.SelectedValue.ToString());

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Maquina eliminada com sucesso!");

                //Clear the fields
                minFrente.Clear();
                maxFrente.Clear();
                minAtras.Clear();
                maxTras.Clear();
                textBox2.Clear();
                textBox1.Clear();
                comboBox7.ResetText();
                comboBox1.ResetText();
                comboBox6.ResetText();
                comboBox5.ResetText();
                comboBox2.ResetText();

                GerirMaquinas_Load(sender, e);
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao eliminar máquina. Por favor tente novamente.");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)     // preencher
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
            SqlConnection con2 = new SqlConnection(connectionString);
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("Select * from Maquina where Nome='" + comboBox2.Text.Trim() + "'", con2);

            try
            {
                DataRowView drv = (DataRowView)comboBox2.SelectedItem;
                String cb1 = drv["Nome"].ToString();
            }
            catch { MessageBox.Show("Erro ao exibir nome da maquina. Por favor tente novamente."); }


            SqlDataReader reader = cmd2.ExecuteReader();
            if (reader.Read())
            {
                minFrente.Text = reader["MinPessFrente"].ToString();
                maxFrente.Text = reader["MaxPessFrente"].ToString();
                minAtras.Text = reader["MinPessTras"].ToString();
                maxTras.Text = reader["MaxPessTras"].ToString();
                textBox2.Text = reader["Velocidade1"].ToString();
                textBox1.Text = reader["Velocidade2"].ToString();

                comboBox7.DisplayMember = reader["Filme"].ToString();
                comboBox7.SelectedText = reader["Filme"].ToString();

                comboBox6.DisplayMember = reader["Papel"].ToString();
                comboBox6.SelectedText = reader["Papel"].ToString();

                comboBox5.DisplayMember = reader["Molde"].ToString();
                comboBox5.SelectedText = reader["Molde"].ToString();

                comboBox1.DisplayMember = reader["Tipo"].ToString();
                comboBox1.SelectedText = reader["Tipo"].ToString();

                reader.Close();
                con2.Close();

            }
            else
            {
                MessageBox.Show("Erro ao exibir maquina. Por favor tente novamente.");
            }
        }
    }
}
