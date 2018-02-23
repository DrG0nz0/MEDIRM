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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("INSERT INTO ComponentesDosArtigos (Artigo, Componente, Quantidade, Maquina1, Maquina2, Maquina3, Maquina4, Maquina5) VALUES (@Artigo, @Componente, @Quantidade, @Maquina1, @Maquina2, @Maquina3, @Maquina4, @Maquina5)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Quantidade", textBox1.Text);

                DataRowView drv = (DataRowView)comboBox3.SelectedItem;
                String cb1 = drv["Artigo"].ToString();
                com.Parameters.AddWithValue("@Artigo", cb1);

                DataRowView drv1 = (DataRowView)comboBox8.SelectedItem;
                String cb2 = drv1["Componente"].ToString();
                com.Parameters.AddWithValue("@Componente", cb2);

                DataRowView drv2 = (DataRowView)comboBox7.SelectedItem;
                String cb4 = drv2["Maquina1"].ToString();
                com.Parameters.AddWithValue("@Maquina1", cb4);

                DataRowView drv3 = (DataRowView)comboBox1.SelectedItem;
                String cb3 = drv3["Maquina2"].ToString();
                com.Parameters.AddWithValue("@Maquina2", cb3);

                DataRowView drv4 = (DataRowView)comboBox4.SelectedItem;
                String cb5 = drv4["Maquina3"].ToString();
                com.Parameters.AddWithValue("@Maquina3", cb5);

                DataRowView drv5 = (DataRowView)comboBox5.SelectedItem;
                String cb6 = drv5["Maquina4"].ToString();
                com.Parameters.AddWithValue("@Maquina4", cb6);

                DataRowView drv6 = (DataRowView)comboBox6.SelectedItem;
                String cb7 = drv6["Maquina5"].ToString();
                com.Parameters.AddWithValue("@Maquina5", cb7);

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
