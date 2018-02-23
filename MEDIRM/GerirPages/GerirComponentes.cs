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

        }

        private void button1_Click(object sender, EventArgs e)      // modificar componente
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("UPDATE Componentes SET ID=@ID, PrecoCompra=@PrecoCompra, Moeda=@Moeda WHERE Nome=@Nome", con);
                com.CommandType = CommandType.Text;
                com.Parameters.AddWithValue("@PrecoCartolina", textBox3.ToString());
                //com.Parameters.AddWithValue("@Volume", textBox1.ToString());

                DataRowView drv = (DataRowView)comboBox2.SelectedItem;
                String cb1 = drv["Moeda"].ToString();
                com.Parameters.AddWithValue("@Moeda", cb1);

                DataRowView drv2 = (DataRowView)comboBox1.SelectedItem;
                String cb2 = drv2["Designacao"].ToString();
                com.Parameters.AddWithValue("@Designacao", cb2);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Componente alterado com sucesso!");

                //Clear the fields
                textBox3.Clear();
                //textBox1.Clear();
                comboBox2.ResetText();
                comboBox1.ResetText();
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao alterar componente. Por favor tente novamente.");
            }
        }
    }
}
