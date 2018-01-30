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
    public partial class AddMaquina : Form
    {
        public AddMaquina()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new CriarBD());
        }

        private void AddMaquina_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.TipoMaquina'. Você pode movê-la ou removê-la conforme necessário.
            this.tipoMaquinaTableAdapter.Fill(this.medirmDBDataSet.TipoMaquina);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.medirmDBDataSet.Funcionario);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Papel'. Você pode movê-la ou removê-la conforme necessário.
            this.papelTableAdapter.Fill(this.medirmDBDataSet.Papel);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Molde'. Você pode movê-la ou removê-la conforme necessário.
            this.moldeTableAdapter.Fill(this.medirmDBDataSet.Molde);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Filme'. Você pode movê-la ou removê-la conforme necessário.
            this.filmeTableAdapter.Fill(this.medirmDBDataSet.Filme);


        }

        private void criarMaquina_Click(object sender, EventArgs e)
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("INSERT INTO Maquina (Tipo, MinPessFrente, MaxPessFrente, MinPessTras, MaxPessTras, Filme, Papel, Molde) VALUES (@Tipo, @MinPessFrente, @MaxPessFrente, @MinPessTras, @MaxPessTras, @Filme, @Papel, @Molde)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@MinPessFrente", minFrente.Text);
                com.Parameters.AddWithValue("@MaxPessFrente", maxFrente.Text);
                com.Parameters.AddWithValue("@MinPessTras", minAtras.Text);
                com.Parameters.AddWithValue("@MaxPessTras", maxTras.Text);

                DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                String cb = drv["Tipo"].ToString();
                com.Parameters.AddWithValue("@Tipo", cb);

                DataRowView drv1 = (DataRowView)comboBox4.SelectedItem;
                String cb1 = drv1["Filme"].ToString();
                com.Parameters.AddWithValue("@Filme", cb1);

                DataRowView drv2 = (DataRowView)comboBox5.SelectedItem;
                String cb2 = drv2["Papel"].ToString();
                com.Parameters.AddWithValue("@Papel", cb2);

                DataRowView drv3 = (DataRowView)comboBox6.SelectedItem;
                String cb3 = drv3["Molde"].ToString();
                com.Parameters.AddWithValue("@Molde", cb3);

                // falta ainda adicionar os funcionarios para tras e para a frente

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Filme adicionado com sucesso!");

                //Clear the fields
                minFrente.Clear();
                maxFrente.Clear();
                minAtras.Clear();
                maxTras.Clear();
                comboBox1.ResetText();
                comboBox4.ResetText();
                comboBox5.ResetText();
                comboBox6.ResetText();

            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar filme. Por favor tente novamente.");
            }
        }
    }
}
