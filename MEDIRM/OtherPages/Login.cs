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

namespace MEDIRM.OtherPages
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);


            string Nome = textBox3.Text;
            string password = textBox1.Text;

            SqlCommand cmd = new SqlCommand("Select * from Users where Nome=@Nome and Password=@Password", con);
            cmd.Parameters.AddWithValue("@Nome", textBox3.Text);
            cmd.Parameters.AddWithValue("@Password", textBox1.Text);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();
            int count = ds.Tables[0].Rows.Count;

            //If count is equal to 1, then show Menu
            if (count == 1)
            {
                MessageBox.Show("Bem vindo!");
                MainFormView.ShowForm(new Menu());
            }
            else
            {
                MessageBox.Show("Por favor verifique o seu Username e Password!");
            }
        }
    }
}
