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
    public partial class GerirArtigos : Form
    {
        public GerirArtigos()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirBD());
        }

        private void GerirArtigos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Cartao'. Você pode movê-la ou removê-la conforme necessário.
            this.cartaoTableAdapter.Fill(this.medirmDBDataSet.Cartao);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Maquina'. Você pode movê-la ou removê-la conforme necessário.
            this.maquinaTableAdapter.Fill(this.medirmDBDataSet.Maquina);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("UPDATE Artigo SET ID=@ID, UnBase=@UnBase, QtdCartao=@QtdCartao, QtdCartolina=@QtdCartolina, QtdCartoesPalete=@QtdCartoesPalete WHERE Nome=@Nome", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@ID", textBox2.Text);
                com.Parameters.AddWithValue("@UnBase", textBox5.Text);
                com.Parameters.AddWithValue("@QtdCartao", textBox6.Text);
                com.Parameters.AddWithValue("@QtdCartolina", textBox8.Text);
                com.Parameters.AddWithValue("@QtdCartoesPalete", textBox7.Text);

                DataRowView drv3 = (DataRowView)comboBox9.SelectedItem;
                String cb3 = drv3["Transporte"].ToString();
                com.Parameters.AddWithValue("@Transporte", cb3);

                DataRowView drv = (DataRowView)comboBox7.SelectedItem;
                String cb = drv["Cartao"].ToString();
                com.Parameters.AddWithValue("@Cartao", cb);

                DataRowView drv1 = (DataRowView)comboBox8.SelectedItem;
                String cb1 = drv1["Cartolina"].ToString();
                com.Parameters.AddWithValue("@Cartolina", cb1);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Artigo alterado com sucesso!");

                //Clear the fields
                textBox2.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                comboBox7.ResetText();
                comboBox8.ResetText();
                comboBox9.ResetText();
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao alterar artigo. Por favor tente novamente.");
            }
        }
    }
}
