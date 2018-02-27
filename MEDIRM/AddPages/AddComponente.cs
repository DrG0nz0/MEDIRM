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
    public partial class AddComponente : Form
    {
        public AddComponente()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new CriarBD());
        }

        private void AddComponente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Moeda'. Você pode movê-la ou removê-la conforme necessário.
            this.moedaTableAdapter.Fill(this.medirmDBDataSet.Moeda);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Transporte'. Você pode movê-la ou removê-la conforme necessário.
            this.transporteTableAdapter.Fill(this.medirmDBDataSet.Transporte);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("INSERT INTO Componentes (Nome, ID, Transporte, PrecoCompra, Moeda, PrecoCusto, CustoAlfandega, QtdCartao, VolCartao, UnBase, PrecoCustoFinal) VALUES (@Nome, @ID, @Transporte, @PrecoCompra, @Moeda, @PrecoCusto, @CustoAlfandega, @QtdCartao, @VolCartao, @UnBase, @PrecoCustoFinal)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Nome", textBox1.Text);
                com.Parameters.AddWithValue("@ID", textBox2.Text);
                com.Parameters.AddWithValue("@PrecoCompra", textBox3.Text);
                com.Parameters.AddWithValue("@PrecoCusto", textBox4.Text);
                com.Parameters.AddWithValue("@QtdCartao", textBox6.Text);
                com.Parameters.AddWithValue("@VolCartao", textBox7.Text);
                com.Parameters.AddWithValue("@UnBase", textBox8.Text);
                com.Parameters.AddWithValue("@CustoAlfandega", textBox5.Text);
                com.Parameters.AddWithValue("@PrecoCustoFinal", 0);

                com.Parameters.AddWithValue("@Transporte", comboBox1.SelectedValue.ToString());

                DataRowView drv = (DataRowView)comboBox2.SelectedItem;
                String cb = drv["Moeda"].ToString();
                com.Parameters.AddWithValue("@Moeda", cb);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Componente adicionado com sucesso!");

                //Clear the fields
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox8.Clear();
                textBox7.Clear();
                textBox9.Clear();
                comboBox2.ResetText();
                comboBox1.ResetText();
            
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar componente. Por favor tente novamente.");
            }
        }
    }
}
