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
    public partial class GerirClientes : Form
    {
        public GerirClientes()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirBD());
        }

        private void GerirClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.medirmDBDataSet.Cliente);

            //Clear the fields
            textBox3.Clear();
            textBox8.Clear();
            textBox4.Clear();
            comboBox3.ResetText();
            comboBox2.ResetText();
            comboBox1.ResetText();

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label5.Visible = true;
                comboBox2.Visible = true;
                button11.Visible = true;
            }
            else
            {
                label5.Visible = false;
                comboBox2.Visible = false;
                button11.Visible = false;
            }
        }       // mostrar entrega

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                label7.Visible = true;
                comboBox3.Visible = true;
                button2.Visible = true;
            }
            else
            {
                label7.Visible = false;
                comboBox3.Visible = false;
                button2.Visible = false;
            }
        }       // mostrar esterilizacao

        private void button1_Click(object sender, EventArgs e)      // eliminar
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);


                SqlCommand com = new SqlCommand("DELETE FROM Cliente WHERE Designacao=@Designacao", con);
                com.CommandType = CommandType.Text;

                DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                String cb1 = drv["Designacao"].ToString();
                com.Parameters.AddWithValue("@Designacao", cb1);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Cliente eliminado com sucesso!");

                // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
                this.clienteTableAdapter.Fill(this.medirmDBDataSet.Cliente);

                //Clear the fields
                comboBox2.ResetText();


            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao eliminar cliente. Por favor tente novamente.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)     // preencher
        {
            comboBox2.ResetText();

            string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
            SqlConnection con2 = new SqlConnection(connectionString);
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("Select * from Cliente where Nome='" + comboBox1.Text.Trim() + "'", con2);

            try
            {
                DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                String cb1 = drv["Nome"].ToString();
            }
            catch { }


            SqlDataReader reader = cmd2.ExecuteReader();
            if (reader.Read())
            {
                if (checkBox1.Checked && checkBox2.Checked)     // transporte e esterilizacao
                {
                    textBox4.Text = reader["Localidade"].ToString();
                    textBox3.Text = reader["MargemLucro"].ToString();
                    textBox8.Text = reader["ID"].ToString();

                    comboBox2.DisplayMember = reader["Transporte"].ToString();
                    comboBox2.SelectedText = reader["Transporte"].ToString();
                    comboBox2.SelectedItem = reader["Transporte"].ToString();

                    comboBox3.DisplayMember = reader["TipoEsterilizacao"].ToString();
                    comboBox3.SelectedText = reader["TipoEsterilizacao"].ToString();
                    comboBox3.SelectedItem = reader["TipoEsterilizacao"].ToString();

                    reader.Close();
                    con2.Close();
                }

                if (!checkBox1.Checked && checkBox2.Checked)     // so esterilizacao
                {
                    textBox4.Text = reader["Localidade"].ToString();
                    textBox3.Text = reader["MargemLucro"].ToString();
                    textBox8.Text = reader["ID"].ToString();

                    comboBox3.DisplayMember = reader["TipoEsterilizacao"].ToString();
                    comboBox3.SelectedText = reader["TipoEsterilizacao"].ToString();
                    comboBox3.SelectedItem = reader["TipoEsterilizacao"].ToString();

                    reader.Close();
                    con2.Close();
                }

                if (checkBox1.Checked && !checkBox2.Checked)     // so transporte
                {
                    textBox4.Text = reader["Localidade"].ToString();
                    textBox3.Text = reader["MargemLucro"].ToString();
                    textBox8.Text = reader["ID"].ToString();

                    comboBox2.DisplayMember = reader["Transporte"].ToString();
                    comboBox2.SelectedText = reader["Transporte"].ToString();
                    comboBox2.SelectedItem = reader["Transporte"].ToString();

                    reader.Close();
                    con2.Close();
                }

                if (!checkBox1.Checked && !checkBox2.Checked)     // nem transport nem esterilizacao
                {
                    textBox4.Text = reader["Localidade"].ToString();
                    textBox3.Text = reader["MargemLucro"].ToString();
                    textBox8.Text = reader["ID"].ToString();

                    reader.Close();
                    con2.Close();
                }


            }
            else
            {
                MessageBox.Show("Erro ao exibir cliente. Por favor tente novamente.");
            }
        }

        private void criarMaquina_Click(object sender, EventArgs e)     // alterar cliente
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                if (checkBox1.Checked && checkBox2.Checked)     // transporte e esterilizacao
                {
                    SqlCommand com = new SqlCommand("UPDATE Cliente SET ID=@ID, Localidade=@Localidade, MargemLucro=@MargemLucro, Transporte=@Transporte, TipoEsterilizacao=@TipoEsterilizacao WHERE Nome=@Nome", con);
                    com.CommandType = CommandType.Text;
                    com.Parameters.AddWithValue("@Localidade", textBox4.Text);
                    com.Parameters.AddWithValue("@MargemLucro", textBox3.Text);
                    com.Parameters.AddWithValue("@ID", textBox8.Text);
                    com.Parameters.AddWithValue("@Transporte", comboBox2.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@TipoEsterilizacao", comboBox3.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@Nome", comboBox1.SelectedValue.ToString());

                    con.Open();
                    int i = com.ExecuteNonQuery();
                    con.Close();

                    //Confirmation Message 
                    MessageBox.Show("Cliente alterado com sucesso!");

                    //Clear the fields
                    textBox3.Clear();
                    textBox8.Clear();
                    textBox4.Clear();
                    comboBox3.ResetText();
                    comboBox2.ResetText();
                    comboBox1.ResetText();
                }

                if (!checkBox1.Checked && !checkBox2.Checked)     // nem transporte nem esterilizacao
                {
                    SqlCommand com = new SqlCommand("UPDATE Cliente SET ID=@ID, Localidade=@Localidade, MargemLucro=@MargemLucro WHERE Nome=@Nome", con);
                    com.CommandType = CommandType.Text;
                    com.Parameters.AddWithValue("@Localidade", textBox4.Text);
                    com.Parameters.AddWithValue("@MargemLucro", textBox3.Text);
                    com.Parameters.AddWithValue("@ID", textBox8.Text);
                    com.Parameters.AddWithValue("@Nome", comboBox1.SelectedValue.ToString());

                    con.Open();
                    int i = com.ExecuteNonQuery();
                    con.Close();

                    //Confirmation Message 
                    MessageBox.Show("Cliente alterado com sucesso!");

                    //Clear the fields
                    textBox3.Clear();
                    textBox8.Clear();
                    textBox4.Clear();
                    comboBox3.ResetText();
                    comboBox2.ResetText();
                    comboBox1.ResetText();
                }

                if (!checkBox1.Checked && checkBox2.Checked)     // so esterilizacao
                {
                    SqlCommand com = new SqlCommand("UPDATE Cliente SET ID=@ID, Localidade=@Localidade, MargemLucro=@MargemLucro, TipoEsterilizacao=@TipoEsterilizacao WHERE Nome=@Nome", con);
                    com.CommandType = CommandType.Text;
                    com.Parameters.AddWithValue("@Localidade", textBox4.Text);
                    com.Parameters.AddWithValue("@MargemLucro", textBox3.Text);
                    com.Parameters.AddWithValue("@ID", textBox8.Text);
                    com.Parameters.AddWithValue("@TipoEsterilizacao", comboBox3.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@Nome", comboBox1.SelectedValue.ToString());

                    con.Open();
                    int i = com.ExecuteNonQuery();
                    con.Close();



                    //Confirmation Message 
                    MessageBox.Show("Cliente alterado com sucesso!");

                    //Clear the fields
                    textBox3.Clear();
                    textBox8.Clear();
                    textBox4.Clear();
                    comboBox3.ResetText();
                    comboBox2.ResetText();
                    comboBox1.ResetText();
                }

                if (checkBox1.Checked && !checkBox2.Checked)     // so transporte 
                {
                    SqlCommand com = new SqlCommand("UPDATE Cliente SET ID=@ID, Localidade=@Localidade, MargemLucro=@MargemLucro, Transporte=@Transporte WHERE Nome=@Nome", con);
                    com.CommandType = CommandType.Text;
                    com.Parameters.AddWithValue("@Localidade", textBox4.Text);
                    com.Parameters.AddWithValue("@MargemLucro", textBox3.Text);
                    com.Parameters.AddWithValue("@ID", textBox8.Text);
                    com.Parameters.AddWithValue("@Transporte", comboBox2.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@Nome", comboBox1.SelectedValue.ToString());

                    con.Open();
                    int i = com.ExecuteNonQuery();
                    con.Close();

                    //Confirmation Message 
                    MessageBox.Show("Cliente alterado com sucesso!");

                    //Clear the fields
                    textBox3.Clear();
                    textBox8.Clear();
                    textBox4.Clear();
                    comboBox3.ResetText();
                    comboBox2.ResetText();
                    comboBox1.ResetText();
                }


            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao alterar cliente. Por favor tente novamente.");
            }
        }
    }
}
