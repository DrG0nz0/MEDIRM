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
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Papel'. Você pode movê-la ou removê-la conforme necessário.
            this.papelTableAdapter.Fill(this.medirmDBDataSet.Papel);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Molde'. Você pode movê-la ou removê-la conforme necessário.
            this.moldeTableAdapter.Fill(this.medirmDBDataSet.Molde);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Filme'. Você pode movê-la ou removê-la conforme necessário.
            this.filmeTableAdapter.Fill(this.medirmDBDataSet.Filme);


        }

        private void criarMaquina_Click(object sender, EventArgs e)     // criar maquina
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("INSERT INTO Maquina (Nome, Tipo, MinPessFrente, MaxPessFrente, Filme, Papel, Molde, Velocidade1) VALUES (@Nome, @Tipo, @MinPessFrente, @MaxPessFrente, @Filme, @Papel, @Molde, @Velocidade1)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Nome", textBox1.Text);

                com.Parameters.AddWithValue("@MinPessFrente", minFrente.Text);
                com.Parameters.AddWithValue("@MaxPessFrente", maxFrente.Text);
                com.Parameters.AddWithValue("@Velocidade1", textBox3.Text);

                DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                String cb = drv["Tipo"].ToString();
                com.Parameters.AddWithValue("@Tipo", cb);


                com.Parameters.AddWithValue("@Filme", comboBox4.SelectedValue.ToString());
                com.Parameters.AddWithValue("@Papel", comboBox5.SelectedValue.ToString());
                com.Parameters.AddWithValue("@Molde", comboBox6.SelectedValue.ToString());  

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Maquina adicionada com sucesso!");

                //Clear the fields
                minFrente.Clear();
                maxFrente.Clear();
                comboBox1.ResetText();
                comboBox4.ResetText();
                comboBox5.ResetText();
                comboBox6.ResetText();
            
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar máquina. Por favor tente novamente.");
            }
        }
    }
}
