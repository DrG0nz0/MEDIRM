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
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Componentes'. Você pode movê-la ou removê-la conforme necessário.
            this.componentesTableAdapter.Fill(this.medirmDBDataSet.Componentes);

            textBox1.Clear();
            comboBox3.ResetText();
            comboBox8.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)      // adicionar componente
        {
                try
                {
                    //Insert in the database
                    string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                    SqlConnection con = new SqlConnection(connectionString);

                    SqlCommand com = new SqlCommand("INSERT INTO ComponentesDosArtigo (Artigo, Componente, Quantidade) VALUES (@Artigo, @Componente, @Quantidade)", con);
                    com.CommandType = CommandType.Text;

                    com.Parameters.AddWithValue("@Quantidade", textBox1.Text);

                    com.Parameters.AddWithValue("@Artigo", comboBox3.SelectedValue.ToString());
                    com.Parameters.AddWithValue("@Componente", comboBox8.SelectedValue.ToString());

                    con.Open();
                    int i = com.ExecuteNonQuery();
                    con.Close();

                    //Confirmation Message 
                    MessageBox.Show("Componente adicionado ao artigo com sucesso!");

                    //Clear the fields
                    textBox1.Clear();
                    comboBox3.ResetText();
                    comboBox8.ResetText();

                }
                catch (Exception x)
                {
                    //Error Message 
                    MessageBox.Show("Erro ao adicionar componente ao artigo. Por favor tente novamente.");
                }


        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirBD());
        }
    }
}
