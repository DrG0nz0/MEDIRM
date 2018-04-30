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
    public partial class GerirTurnos : Form
    {
        public GerirTurnos()
        {
            InitializeComponent();
        }

        private void GerirTurnos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.medirmDBDataSet.Funcionario);

        }

        private void button1_Click(object sender, EventArgs e)      // guardar alteracoes
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("UPDATE TurnosFuncionarios SET Turno1=@Turno1, Turno2=@Turno2, Turno3=@Turno3, Turno4=@Turno4 WHERE Funcionario ='" + comboBox8.Text.Trim() + "' AND DiaDaSemana ='" + comboBox1.Text.Trim() + "'", con);
                com.CommandType = CommandType.Text;

                if (comboBox2.SelectedItem != null)
                {
                    com.Parameters.AddWithValue("@Turno1", comboBox2.SelectedItem.ToString());
                }

                if (comboBox3.SelectedItem != null)
                {
                    com.Parameters.AddWithValue("@Turno2", comboBox3.SelectedItem.ToString());
                }

                if (comboBox4.SelectedItem != null)
                {
                    com.Parameters.AddWithValue("@Turno3", comboBox4.SelectedItem.ToString());
                }

                if (comboBox5.SelectedItem != null)
                {
                    com.Parameters.AddWithValue("@Turno4", comboBox5.SelectedItem.ToString());
                }

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Turnos alterados com sucesso!");

                //Clear the fields
                comboBox2.ResetText();
                comboBox1.ResetText();
                comboBox3.ResetText();
                comboBox4.ResetText();
                comboBox5.ResetText();
                comboBox8.ResetText();

                MainFormView.ShowForm(new GerirBD());
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao alterar turnos. Por favor tente novamente.");
                MainFormView.ShowForm(new GerirBD());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)     // preencher turnos
        {
            comboBox2.ResetText();
            comboBox3.ResetText();
            comboBox4.ResetText();
            comboBox5.ResetText();

            if (comboBox8.SelectedIndex.ToString()==null)
            {
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
            SqlConnection con2 = new SqlConnection(connectionString);
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("Select * from TurnosFuncionarios where Funcionario ='" + comboBox8.Text.Trim() + "' AND DiaDaSemana ='" + comboBox1.Text.Trim() + "'", con2);

            try
            {
                DataRowView drv = (DataRowView)comboBox8.SelectedItem;
                String cb1 = drv["Funcionario"].ToString();
            }
            catch { }


            SqlDataReader reader = cmd2.ExecuteReader();
            if (reader.Read())
            {
                comboBox2.DisplayMember = reader["Turno1"].ToString();
                comboBox2.SelectedText = reader["Turno1"].ToString();

                comboBox3.DisplayMember = reader["Turno2"].ToString();
                comboBox3.SelectedText = reader["Turno2"].ToString();

                comboBox4.DisplayMember = reader["Turno3"].ToString();
                comboBox4.SelectedText = reader["Turno3"].ToString();

                comboBox5.DisplayMember = reader["Turno4"].ToString();
                comboBox5.SelectedText = reader["Turno4"].ToString();

                reader.Close();
                con2.Close();
            }
            else
            {
                MessageBox.Show("Erro ao exibir turnos. Por favor tente novamente.");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirBD());
        }
    }
}
