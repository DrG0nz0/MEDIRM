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
    public partial class AddFuncionario : Form
    {
        public AddFuncionario()
        {
            InitializeComponent();
        }

        private void AddFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new CriarBD());
        }

        private void criarMaquina_Click(object sender, EventArgs e)
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("INSERT INTO Funcionario (Nome, Segunda1, Segunda2, Segunda3, Terca1, Terca2, Terca3, Quarta1, Quarta2, Quarta3, Quinta1, Quinta2, Quinta3, Sexta1, Sexta2, Sexta3, Sabado1, Sabado2, Sabado3, Domingo1, Domingo2, Domingo3) VALUES (@Nome, @Segunda1, @Segunda2, @Segunda3, @Terca1, @Terca2, @Terca3, @Quarta1, @Quarta2, @Quarta3, @Quinta1, @Quinta2, @Quinta3, @Sexta1, @Sexta2, @Sexta3, @Sabado1, @Sabado2, @Sabado3, @Domingo1, @Domingo2, @Domingo3)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Nome", textBox1.Text);

                DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                String cb = drv["Segunda1"].ToString();
                com.Parameters.AddWithValue("@Segunda1", cb);

                DataRowView drv1 = (DataRowView)comboBox14.SelectedItem;
                String cb1 = drv1["Segunda2"].ToString();
                com.Parameters.AddWithValue("@Segunda2", cb1);

                DataRowView drv2 = (DataRowView)comboBox21.SelectedItem;
                String cb2 = drv2["Segunda3"].ToString();
                com.Parameters.AddWithValue("@Segunda3", cb2);

                DataRowView drv3 = (DataRowView)comboBox3.SelectedItem;
                String cb3 = drv3["Terca1"].ToString();
                com.Parameters.AddWithValue("@Terca1", cb3);

                DataRowView drv4 = (DataRowView)comboBox12.SelectedItem;
                String cb4 = drv4["Terca2"].ToString();
                com.Parameters.AddWithValue("@Terca2", cb4);

                DataRowView drv5 = (DataRowView)comboBox19.SelectedItem;
                String cb5 = drv5["Terca3"].ToString();
                com.Parameters.AddWithValue("@Terca3", cb5);

                DataRowView drv6 = (DataRowView)comboBox2.SelectedItem;
                String cb6 = drv6["Quarta1"].ToString();
                com.Parameters.AddWithValue("@Quarta1", cb6);

                DataRowView drv7 = (DataRowView)comboBox13.SelectedItem;
                String cb7 = drv7["Quarta2"].ToString();
                com.Parameters.AddWithValue("@Quarta2", cb7);

                DataRowView drv8 = (DataRowView)comboBox20.SelectedItem;
                String cb8 = drv8["Quarta3"].ToString();
                com.Parameters.AddWithValue("@Quarta3", cb8);

                DataRowView drv9 = (DataRowView)comboBox4.SelectedItem;
                String cb9 = drv9["Quinta1"].ToString();
                com.Parameters.AddWithValue("@Quinta1", cb9);

                DataRowView drv10 = (DataRowView)comboBox11.SelectedItem;
                String cb10 = drv10["Quinta2"].ToString();
                com.Parameters.AddWithValue("@Quinta2", cb10);

                DataRowView drv11 = (DataRowView)comboBox18.SelectedItem;
                String cb11 = drv11["Quinta3"].ToString();
                com.Parameters.AddWithValue("@Quinta3", cb11);

                DataRowView drv12 = (DataRowView)comboBox7.SelectedItem;
                String cb12 = drv12["Transporte"].ToString();
                com.Parameters.AddWithValue("@Transporte", cb12);

                DataRowView drv13 = (DataRowView)comboBox8.SelectedItem;
                String cb13 = drv13["Transporte"].ToString();
                com.Parameters.AddWithValue("@Transporte", cb13);

                DataRowView drv14 = (DataRowView)comboBox15.SelectedItem;
                String cb14 = drv14["Transporte"].ToString();
                com.Parameters.AddWithValue("@Transporte", cb14);

                DataRowView drv15 = (DataRowView)comboBox6.SelectedItem;
                String cb15 = drv15["Transporte"].ToString();
                com.Parameters.AddWithValue("@Transporte", cb15);

                DataRowView drv16 = (DataRowView)comboBox9.SelectedItem;
                String cb16 = drv16["Transporte"].ToString();
                com.Parameters.AddWithValue("@Transporte", cb16);

                DataRowView drv17 = (DataRowView)comboBox16.SelectedItem;
                String cb17 = drv17["Transporte"].ToString();
                com.Parameters.AddWithValue("@Transporte", cb17);

                DataRowView drv18 = (DataRowView)comboBox5.SelectedItem;
                String cb18 = drv18["Transporte"].ToString();
                com.Parameters.AddWithValue("@Transporte", cb18);

                DataRowView drv19 = (DataRowView)comboBox10.SelectedItem;
                String cb19 = drv19["Transporte"].ToString();
                com.Parameters.AddWithValue("@Transporte", cb19);

                DataRowView drv20 = (DataRowView)comboBox17.SelectedItem;
                String cb20 = drv20["Transporte"].ToString();
                com.Parameters.AddWithValue("@Transporte", cb20);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Funcionário adicionado com sucesso!");

                //Clear the fields
                textBox1.Clear();
                comboBox1.ResetText();
                comboBox2.ResetText();
                comboBox3.ResetText();
                comboBox4.ResetText();
                comboBox5.ResetText();
                comboBox6.ResetText();
                comboBox7.ResetText();
                comboBox8.ResetText();
                comboBox9.ResetText();
                comboBox10.ResetText();
                comboBox11.ResetText();
                comboBox12.ResetText();
                comboBox13.ResetText();
                comboBox14.ResetText();
                comboBox15.ResetText();
                comboBox16.ResetText();
                comboBox17.ResetText();
                comboBox18.ResetText();
                comboBox19.ResetText();
                comboBox20.ResetText();

            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar funcionário. Por favor tente novamente.");
            }
        }
    }
}
