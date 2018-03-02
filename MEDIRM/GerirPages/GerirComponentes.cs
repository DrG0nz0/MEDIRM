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

namespace MEDIRM.GerirPages
{
    public partial class GerirComponentes : Form
    {
        public GerirComponentes()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirBD());
        }

        private void GerirComponentes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Componentes'. Você pode movê-la ou removê-la conforme necessário.
            this.componentesTableAdapter.Fill(this.medirmDBDataSet.Componentes);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Moeda'. Você pode movê-la ou removê-la conforme necessário.
            this.moedaTableAdapter.Fill(this.medirmDBDataSet.Moeda);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.medirmDBDataSet.Funcionario);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Transporte'. Você pode movê-la ou removê-la conforme necessário.
            this.transporteTableAdapter.Fill(this.medirmDBDataSet.Transporte);

            //Clear the fields
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            comboBox2.ResetText();
            comboBox1.ResetText();
            comboBox3.ResetText();

        }

        private void button1_Click(object sender, EventArgs e)      // modificar componente
        {

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("UPDATE Componentes SET ID=@ID, Transporte=@Transporte, PrecoCompra=@PrecoCompra, Moeda=@Moeda, PrecoCusto=@PrecoCusto, CustoAlfandega=@CustoAlfandega, QtdCartao=@QtdCartao, VolCartao=@VolCartao, UnBase=@UnBase, PrecoCustoFinal=@PrecoCustoFinal WHERE Nome=@Nome", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@ID", textBox2.Text);
                com.Parameters.AddWithValue("@PrecoCompra", textBox3.Text);
                com.Parameters.AddWithValue("@PrecoCusto", textBox4.Text);
                com.Parameters.AddWithValue("@QtdCartao", textBox6.Text);
                com.Parameters.AddWithValue("@VolCartao", textBox7.Text);
                com.Parameters.AddWithValue("@UnBase", textBox8.Text);
                com.Parameters.AddWithValue("@CustoAlfandega", textBox5.Text);
                com.Parameters.AddWithValue("@PrecoCustoFinal", textBox9.Text);
                com.Parameters.AddWithValue("@Transporte", comboBox1.SelectedValue.ToString());
                com.Parameters.AddWithValue("@Moeda", comboBox2.SelectedValue.ToString());
                com.Parameters.AddWithValue("@Nome", comboBox3.SelectedValue.ToString());


                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Componente alterado com sucesso!");

                //Clear the fields
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                comboBox2.ResetText();
                comboBox1.ResetText();
                comboBox3.ResetText();
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao alterar componente. Por favor tente novamente.");
            }
        }

        private void button2_Click(object sender, EventArgs e)      //apagar
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);


                SqlCommand com = new SqlCommand("DELETE FROM Componentes WHERE Nome=@Nome", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Nome", comboBox3.SelectedValue.ToString());

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Componente eliminado com sucesso!");

                // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Cartolina'. Você pode movê-la ou removê-la conforme necessário.
                this.componentesTableAdapter.Fill(this.medirmDBDataSet.Componentes);

                //Clear the fields
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                comboBox2.ResetText();
                comboBox1.ResetText();
                comboBox3.ResetText();


            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao eliminar componente. Por favor tente novamente.");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)     // preencher
        {
            comboBox2.ResetText();
            comboBox1.ResetText();

            string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
            SqlConnection con2 = new SqlConnection(connectionString);
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("Select * from Componentes where Nome='" + comboBox3.Text.Trim() + "'", con2);

            try
            {
                DataRowView drv = (DataRowView)comboBox3.SelectedItem;
                String cb1 = drv["Nome"].ToString();
            }
            catch { }


            SqlDataReader reader = cmd2.ExecuteReader();
            if (reader.Read())
            {
                textBox2.Text = reader["ID"].ToString();
                textBox3.Text = reader["PrecoCompra"].ToString();
                textBox4.Text = reader["PrecoCusto"].ToString();
                textBox6.Text = reader["QtdCartao"].ToString();
                textBox7.Text = reader["VolCartao"].ToString();
                textBox8.Text = reader["UnBase"].ToString();
                textBox5.Text = reader["CustoAlfandega"].ToString();
                textBox9.Text = reader["PrecoCustoFinal"].ToString();
                comboBox2.DisplayMember = reader["Moeda"].ToString();
                comboBox2.SelectedText = reader["Moeda"].ToString();
                comboBox1.DisplayMember = reader["Transporte"].ToString();
                comboBox1.SelectedText = reader["Transporte"].ToString();


               reader.Close();
                con2.Close();
            }
            else
            {
                MessageBox.Show("Erro ao exibir cartao. Por favor tente novamente.");
            }
        }
    }
}
