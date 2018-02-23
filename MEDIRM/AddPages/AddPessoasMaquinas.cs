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
    public partial class AddPessoasMaquinas : Form
    {
        public AddPessoasMaquinas()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)     // back button
        {
            MainFormView.ShowForm(new GerirBD());
        }

        private void button1_Click(object sender, EventArgs e)      // adicionar pessoas a frente
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("INSERT INTO PessoasMaquinas (Maquina, Funcionario, Posicao) VALUES (@Maquina, @Funcionario, @Posicao)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Posicao", "Frente");

                DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                String cb = drv["Maquina"].ToString();
                com.Parameters.AddWithValue("@Maquina", cb);

                DataRowView drv1 = (DataRowView)comboBox3.SelectedItem;
                String cb1 = drv1["Funcionario"].ToString();
                com.Parameters.AddWithValue("@Funcionario", cb1);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Pessoa adicionada a máquina com sucesso!");

                //Clear the fields
                comboBox1.ResetText();
                comboBox2.ResetText();
                comboBox3.ResetText();

            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar pessoa a máquiuna. Por favor tente novamente.");
            }
        }

        private void button2_Click(object sender, EventArgs e)      // adicionar pessoas a tras
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("INSERT INTO PessoasMaquinas (Maquina, Funcionario, Posicao) VALUES (@Maquina, @Funcionario, @Posicao)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Posicao", "Tras");

                DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                String cb = drv["Maquina"].ToString();
                com.Parameters.AddWithValue("@Maquina", cb);

                DataRowView drv1 = (DataRowView)comboBox2.SelectedItem;
                String cb1 = drv1["Funcionario"].ToString();
                com.Parameters.AddWithValue("@Funcionario", cb1);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Pessoa adicionada a máquina com sucesso!");

                //Clear the fields
                comboBox1.ResetText();
                comboBox2.ResetText();
                comboBox3.ResetText();

            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar pessoa a máquiuna. Por favor tente novamente.");
            }
        }

        private void button3_Click(object sender, EventArgs e)      // concluir
        {
            MessageBox.Show("Alterações guardadas com sucesso!");
            MainFormView.ShowForm(new CriarBD());
        }

        private void AddPessoasMaquinas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Maquina'. Você pode movê-la ou removê-la conforme necessário.
            this.maquinaTableAdapter.Fill(this.medirmDBDataSet.Maquina);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.medirmDBDataSet.Funcionario);

        }
    }
}
