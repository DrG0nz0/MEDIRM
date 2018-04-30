using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace MEDIRM.OtherPages
{
    public partial class SimulacaoPrecos : Form
    {
        public SimulacaoPrecos()
        {
            InitializeComponent();
        }

        private void SimulacaoPrecos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.ComponentesDosArtigos'. Você pode movê-la ou removê-la conforme necessário.
            this.componentesDosArtigosTableAdapter.Fill(this.medirmDBDataSet.ComponentesDosArtigos);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.SimulacaoPrecos'. Você pode movê-la ou removê-la conforme necessário.
            this.simulacaoPrecosTableAdapter.Fill(this.medirmDBDataSet.SimulacaoPrecos);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Artigo'. Você pode movê-la ou removê-la conforme necessário.
            this.artigoTableAdapter.Fill(this.medirmDBDataSet.Artigo);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.medirmDBDataSet.Cliente);

            artigoDataGridView.Rows.Clear();
            artigoDataGridView.Refresh();
            componentesDosArtigosDataGridView.Rows.Clear();
            componentesDosArtigosDataGridView.Refresh();
        }

        private void back_Click(object sender, EventArgs e)
        {
            try
            {
                //delete the database
                string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand("DELETE FROM SimulacaoPrecos", con);
                com.CommandType = CommandType.Text;

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Clear the fields
                comboBox2.ResetText();
                comboBox1.ResetText();

            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro.");
            }

            MainFormView.ShowForm(new Menu());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)         // preencher
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;
            SqlDataReader dr;

            try
            {
                SqlConnection con3 = new SqlConnection(connectionString);
                con3.Open();

                //Check whether the Drop Down has existing items. If YES, empty it.
                if (comboBox2.Items.Count > 0)
                    comboBox2.Items.Clear();

                SqlCommand cmd3 = new SqlCommand("SELECT Artigo FROM ArtigosClientes WHERE Cliente= '" + comboBox1.SelectedValue.ToString() + "'", con3);

                dr = cmd3.ExecuteReader();

                while (dr.Read())
                    comboBox2.Items.Add(dr[0].ToString());

                dr.Close();
                con3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            try         // margem de lucro
            {
                SqlConnection con3 = new SqlConnection(connectionString);
                con3.Open();

                SqlCommand cmd3 = new SqlCommand("SELECT MargemLucro FROM Cliente WHERE Nome= '" + comboBox1.SelectedValue.ToString() + "'", con3);

                dr = cmd3.ExecuteReader();

                while (dr.Read())
                    textBox1.Text = dr.GetValue(0).ToString();

                dr.Close();
                con3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void criarMaquina_Click(object sender, EventArgs e)     // adicionar
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MedirmDB"].ConnectionString;

            String artigo = "", cliente = "", componente = "", nomeMaquina = "";      // check

            int pecasCartolina = 0,     // check
                pecasCartao = 0,     // check
                cartoesPalete = 0,     // check
                unBase = 0;     // check

            decimal cartao = 0,     // check
                cartolina = 0,     // check
                transporte = 0,     // check
                esterilizacao = 0,
                salarios = 0,
                custosFixos = 0,
                subTotal = 0,
                precoVenda = 0,
                margemLucro = 0,
                precoArtigo = 0;     // check

            string maquina1 = "",     // check
                maquina2 = "",     // check
                maquina3 = "",     // check
                maquina4 = "",     // check
                nomeCartao = "",     // check
                nomeCartolina = "",     // check
                nomeEsterilizacao = "";

            artigo = comboBox2.SelectedItem.ToString();
            cliente = comboBox1.SelectedItem.ToString();



            artigoBindingSource.Filter = "Nome ='" + artigo + "'";
            componentesDosArtigosBindingSource.Filter = "Artigo ='" + artigo + "'";

            /*
            DataSet dds = new DataSet();

            DataView dv;
            dv = new DataView(dds.Tables[0], "Nome ='" + artigo + "'", "type Desc", DataViewRowState.CurrentRows);
            artigoDataGridView.DataSource = dv;

            */


            try
            {
                SqlConnection con8 = new SqlConnection(connectionString);
                con8.Open();
                SqlCommand cmd8 = new SqlCommand("Select * from Artigo where Nome='" + artigo + "'", con8);
                cmd8.CommandType = CommandType.Text;
                SqlDataReader reader8 = cmd8.ExecuteReader();
                if (reader8.Read())
                {
                    nomeCartao = reader8["Cartao"].ToString();

                    nomeCartolina = reader8["Cartolina"].ToString();

                    string s = reader8["qtdCartao"].ToString();
                    pecasCartao = Convert.ToInt32(s);

                    string s4 = reader8["qtdCartolina"].ToString();
                    pecasCartolina = Convert.ToInt32(s4);

                    string s3 = reader8["UnBase"].ToString();
                    unBase = Convert.ToInt32(s3);

                    string s5 = reader8["QtdCartoesPalete"].ToString();
                    cartoesPalete = Convert.ToInt32(s5);

                    maquina1 = reader8["Maquina1"].ToString();

                    maquina2 = reader8["Maquina2"].ToString();

                    maquina3 = reader8["Maquina3"].ToString();

                    maquina4 = reader8["Maquina4"].ToString();

                    reader8.Close();
                    con8.Close();
                }
                else
                {
                    con8.Close();
                    MessageBox.Show("Erro ao exibir artigo. Por favor tente novamente.");
                }

                // ir buscar o preço do artigo
                SqlConnection con2 = new SqlConnection(connectionString);
                con2.Open();
                SqlCommand cmd2 =
                    new SqlCommand(
                        "Select * from ArtigosClientes where Cliente='" + comboBox1.Text.Trim() + "' AND Artigo='" +
                        comboBox2.Text.Trim() + "'", con2);
                cmd2.CommandType = CommandType.Text;
                SqlDataReader reader = cmd2.ExecuteReader();
                if (reader.Read())
                {
                    string s = reader["Preco"].ToString();
                    precoArtigo = Convert.ToDecimal(s);
                    reader.Close();
                    con2.Close();
                }
                else
                {
                    con2.Close();
                    MessageBox.Show("Erro ao exibir preço do artigo. Por favor tente novamente.");
                }

                // preço do transporte
                string nomeTransporte = "";
                SqlConnection con5 = new SqlConnection(connectionString);
                con5.Open();
                SqlCommand cmd5 = new SqlCommand("Select * from Cliente where Nome='" + comboBox1.Text.Trim() + "'",
                    con5);
                cmd5.CommandType = CommandType.Text;
                SqlDataReader reader5 = cmd5.ExecuteReader();
                if (reader5.Read())
                {
                    nomeTransporte = reader5["Transporte"].ToString();

                    reader5.Close();
                    con5.Close();
                }
                else
                {
                    con5.Close();
                    MessageBox.Show("Erro ao exibir transporte. Por favor tente novamente.");
                }

                decimal precoTransporte = 0;
                string moeda = "";

                SqlConnection con6 = new SqlConnection(connectionString);
                con6.Open();
                SqlCommand cmd6 =
                    new SqlCommand("Select * from [Transporte] where [Designacao] ='" + nomeTransporte + "'", con6);
                cmd6.CommandType = CommandType.Text;
                SqlDataReader reader6 = cmd6.ExecuteReader();
                if (reader6.Read())
                {
                    string s = reader6["Preco"].ToString();
                    precoTransporte = Convert.ToDecimal(s);
                    moeda = reader6["Moeda"].ToString();
                    reader6.Close();
                    con6.Close();
                }
                else
                {
                    con6.Close();
                    MessageBox.Show("Erro ao exibir transporte. Por favor tente novamente.");
                }

                decimal precoEurosTransporte = 0;
                decimal cambio = 0;

                SqlConnection con7 = new SqlConnection(connectionString);
                con7.Open();
                SqlCommand cmd7 = new SqlCommand("Select * from Moeda where Moeda='" + moeda + "'", con7);
                cmd7.CommandType = CommandType.Text;
                SqlDataReader reader7 = cmd7.ExecuteReader();
                if (reader7.Read())
                {
                    string s = reader7["Cambio"].ToString();
                    cambio = Convert.ToDecimal(s);

                    reader7.Close();
                    con7.Close();
                }
                else
                {
                    con7.Close();
                    MessageBox.Show("Erro ao exibir moeda. Por favor tente novamente.");
                }

                precoEurosTransporte = cambio * precoTransporte;




                // preço dos cartoes e calculo de cartoes por palete etc
                decimal precoCartao = 0, volumeCartao = 0;
                string moedaCartao = "";

                SqlConnection con9 = new SqlConnection(connectionString);
                con9.Open();
                SqlCommand cmd9 = new SqlCommand("Select * from Cartao where Designacao='" + nomeCartao + "'", con9);
                cmd8.CommandType = CommandType.Text;
                SqlDataReader reader9 = cmd9.ExecuteReader();
                if (reader9.Read())
                {
                    moedaCartao = reader9["Moeda"].ToString();

                    string s = reader9["PrecoCartolina"].ToString(); // naoe é erro
                    precoCartao = Convert.ToDecimal(s);

                    string s4 = reader9["Volume"].ToString();
                    volumeCartao = Convert.ToDecimal(s4);

                    reader9.Close();
                    con9.Close();
                }
                else
                {
                    con9.Close();
                    MessageBox.Show("Erro ao exibir artigo. Por favor tente novamente.");
                }


                decimal cartaoEuros = 0;
                decimal cambioCartao = 0;

                SqlConnection con10 = new SqlConnection(connectionString);
                con10.Open();
                SqlCommand cmd10 = new SqlCommand("Select * from Moeda where Moeda='" + moedaCartao + "'", con10);
                cmd10.CommandType = CommandType.Text;
                SqlDataReader reader10 = cmd10.ExecuteReader();
                if (reader10.Read())
                {
                    string s = reader10["Cambio"].ToString();
                    cambioCartao = Convert.ToDecimal(s);

                    reader10.Close();
                    con10.Close();
                }
                else
                {
                    con10.Close();
                    MessageBox.Show("Erro ao exibir moeda1. Por favor tente novamente.");
                }

                cartaoEuros = cambioCartao * precoCartao;

                decimal res3 = 100 / Convert.ToDecimal(pecasCartao);
                int numeroCartoes = 1;
                numeroCartoes = Convert.ToInt32(Math.Ceiling(res3));
                cartao = Convert.ToDecimal(numeroCartoes) * Convert.ToDecimal(cartaoEuros);
                decimal volumeCartoesFinal = numeroCartoes * volumeCartao;
                decimal res = Convert.ToDecimal(cartoesPalete) / Convert.ToDecimal(numeroCartoes);
                int nrPaletes = 1;
                nrPaletes = Convert.ToInt32(Math.Ceiling(res));

                transporte = precoEurosTransporte * nrPaletes; // preco final do transporte


                // fazer a mesma coisa para a cartolina
                decimal precoCartolina = 0;
                string moedaCartolina = "";

                SqlConnection con11 = new SqlConnection(connectionString);
                con11.Open();
                SqlCommand cmd11 =
                    new SqlCommand("Select * from Cartolina where Designacao='" + nomeCartolina + "'", con11);
                cmd11.CommandType = CommandType.Text;
                SqlDataReader reader11 = cmd11.ExecuteReader();
                if (reader11.Read())
                {
                    moedaCartolina = reader11["Moeda"].ToString();

                    string s = reader11["PrecoMetro"].ToString(); // naoe é erro é preco por cartolina
                    precoCartolina = Convert.ToDecimal(s);

                    reader11.Close();
                    con11.Close();
                }
                else
                {
                    con11.Close();
                    MessageBox.Show("Erro ao exibir cartolina. Por favor tente novamente.");
                }

                decimal cartolinaEuros = 0;
                decimal cambioCartolina = 0;

                SqlConnection con12 = new SqlConnection(connectionString);
                con12.Open();
                SqlCommand cmd12 = new SqlCommand("Select * from Moeda where Moeda='" + moedaCartolina + "'", con12);
                cmd12.CommandType = CommandType.Text;
                SqlDataReader reader12 = cmd12.ExecuteReader();
                if (reader12.Read())
                {
                    string s = reader12["Cambio"].ToString();
                    cambioCartolina = Convert.ToDecimal(s);

                    reader12.Close();
                    con12.Close();
                }
                else
                {
                    con12.Close();
                    MessageBox.Show("Erro ao exibir cartolina. Por favor tente novamente.");
                }

                cartolinaEuros = cambioCartolina * precoCartolina;
                decimal qtdCartolinas2 = Convert.ToDecimal(pecasCartolina) / 100;
                decimal qtdCartolinas = Convert.ToInt32(Math.Ceiling(qtdCartolinas2));
                cartolina = cartolinaEuros * qtdCartolinas;



                margemLucro = Convert.ToDecimal(textBox1.Text.ToString());

                // somar os custos fixos
                SqlConnection con4 = new SqlConnection(connectionString);
                con4.Open();
                SqlCommand cmd4 = new SqlCommand("Select SUM (Custo) from CustosFixos", con4);
                cmd4.CommandType = CommandType.Text;

                object result = cmd4.ExecuteScalar();
                string s2 = Convert.ToString(result);
                custosFixos = Convert.ToDecimal(s2);
                con4.Close();

            /*
                // ver componentes dos artigos
                SqlConnection con30 = new SqlConnection(connectionString);
                con30.Open();
                SqlCommand cmd30 = new SqlCommand("Select * from ComponentesDosArtigos where Artigo='" + artigo + "'", con30);
                cmd30.CommandType = CommandType.Text;
                SqlDataReader reader30 = cmd30.ExecuteReader();

                SqlDataAdapter adp = new SqlDataAdapter();
                DataTable dt = new DataTable();
                adp.Fill(dt);

                string compo = "";
                int qtd = 0;

                if (reader30.Read())
                {
                    while (reader.Read())
                    {
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                compo = Convert.ToString(dt.Rows[i]["Componente"]);
                                qtd = Convert.ToInt32(dt.Rows[i]["Quantidade"]);


                                
                            }                         
                        }
                    }




                    reader30.Close();
                    con30.Close();
                }
                else
                {
                    con30.Close();
                    MessageBox.Show("Erro ao exibir cartolina. Por favor tente novamente.");
                }*/



                //custos de producao (numero de horas)

                int pessoasFrente = 0, pessoasTras = 0, velocidade = 0;
                decimal custosFinais = 0, preRes = 0;



                if (maquina1 != "" || maquina1 != "NULL")
                {
                    SqlConnection con15 = new SqlConnection(connectionString);
                    con15.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Maquina where Nome='" + maquina1 + "'", con15);
                    cmd.CommandType = CommandType.Text;

                    SqlDataReader reader21 = cmd.ExecuteReader();
                    if (reader21.Read())
                    {
                        string s = reader21["MinPessFrente"].ToString();
                        pessoasFrente = Convert.ToInt32(s);

                        string s1 = reader21["MaxPessFrente"].ToString();
                        pessoasTras = Convert.ToInt32(s1);

                        string s3 = reader21["Velocidade1"].ToString();
                        velocidade = Convert.ToInt32(s3);

                        reader21.Close();
                        con15.Close();

                        decimal horas = 100 / Convert.ToDecimal(velocidade);
                        int nHoras = Convert.ToInt32(Math.Ceiling(horas));      // numero de horas para esta maquina
                        int nPessoas = pessoasFrente + pessoasTras;             // numero de pessoas na maquina
                        salarios = Convert.ToDecimal(nHoras) * Convert.ToDecimal(nPessoas);
                        decimal ds = 8.28m;     
                        salarios = salarios * ds;
                        

                        preRes = nHoras * custosFixos;
                        custosFinais += preRes + salarios;
                    }
                }

                if (maquina2 != "" || maquina2 != "NULL")
                {
                    SqlConnection con16 = new SqlConnection(connectionString);
                    con16.Open();
                    SqlCommand cmd16 = new SqlCommand("Select * from Maquina where Nome='" + maquina2 + "'", con16);
                    cmd16.CommandType = CommandType.Text;

                    SqlDataReader reader22 = cmd16.ExecuteReader();
                    if (reader22.Read())
                    {
                        string s = reader22["MinPessFrente"].ToString();
                        pessoasFrente = Convert.ToInt32(s);

                        string s1 = reader22["MaxPessFrente"].ToString();
                        pessoasTras = Convert.ToInt32(s1);

                        string s3 = reader22["Velocidade1"].ToString();
                        velocidade = Convert.ToInt32(s3);

                        reader22.Close();
                        con16.Close();

                        decimal horas = 100 / Convert.ToDecimal(velocidade);
                        int nHoras = Convert.ToInt32(Math.Ceiling(horas));      // numero de horas para esta maquina
                        int nPessoas = pessoasFrente + pessoasTras;             // numero de pessoas na maquina
                        salarios = Convert.ToDecimal(nHoras) * Convert.ToDecimal(nPessoas);
                        decimal ds = 8.28m;
                        salarios = salarios * ds;
                        preRes = nHoras * custosFixos;
                        custosFinais += preRes + salarios;
                    }
                }

                if (maquina3 != "" || maquina3 != "NULL")
                {
                    SqlConnection con17 = new SqlConnection(connectionString);
                    con17.Open();
                    SqlCommand cmd17 = new SqlCommand("Select * from Maquina where Nome='" + maquina3 + "'", con17);
                    cmd17.CommandType = CommandType.Text;

                    SqlDataReader reader23 = cmd17.ExecuteReader();
                    if (reader23.Read())
                    {
                        string s = reader23["MinPessFrente"].ToString();
                        pessoasFrente = Convert.ToInt32(s);

                        string s1 = reader23["MaxPessFrente"].ToString();
                        pessoasTras = Convert.ToInt32(s1);

                        string s3 = reader23["Velocidade1"].ToString();
                        velocidade = Convert.ToInt32(s3);

                        reader23.Close();
                        con17.Close();

                        decimal horas = 100 / Convert.ToDecimal(velocidade);
                        int nHoras = Convert.ToInt32(Math.Ceiling(horas));      // numero de horas para esta maquina
                        int nPessoas = pessoasFrente + pessoasTras;             // numero de pessoas na maquina
                        decimal salarioPorHora = 1;
                        salarios = Convert.ToDecimal(nHoras) * Convert.ToDecimal(nPessoas);
                        decimal ds = 8.28m;
                        salarios = salarios * ds;
                        preRes = nHoras * custosFixos;
                        custosFinais += preRes + salarios;
                    }
                }

                if (maquina4 != "" || maquina4 != "NULL")
                {
                    SqlConnection con18 = new SqlConnection(connectionString);
                    con18.Open();
                    SqlCommand cmd18 = new SqlCommand("Select * from Maquina where Nome='" + maquina4 + "'", con18);
                    cmd18.CommandType = CommandType.Text;

                    SqlDataReader reader24 = cmd18.ExecuteReader();
                    if (reader24.Read())
                    {
                        string s = reader24["MinPessFrente"].ToString();
                        pessoasFrente = Convert.ToInt32(s);

                        string s1 = reader24["MaxPessFrente"].ToString();
                        pessoasTras = Convert.ToInt32(s1);

                        string s3 = reader24["Velocidade1"].ToString();
                        velocidade = Convert.ToInt32(s3);

                        reader24.Close();
                        con18.Close();

                        decimal horas = 100 / Convert.ToDecimal(velocidade);
                        int nHoras = Convert.ToInt32(Math.Ceiling(horas));      // numero de horas para esta maquina
                        int nPessoas = pessoasFrente + pessoasTras;             // numero de pessoas na maquina
                        salarios = Convert.ToDecimal(nHoras) * Convert.ToDecimal(nPessoas);
                        decimal ds = 8.28m;
                        salarios = salarios * ds;
                        preRes = nHoras * custosFixos;
                        custosFinais += preRes + salarios;
                    }
                }



                // preço final
                subTotal = cartao + transporte + cartolina + custosFinais + precoArtigo;
                //precoVenda = subTotal * margemLucro;
                decimal xpto = 100 - Convert.ToDecimal(textBox1.Text);
                precoVenda = subTotal * 100 / xpto;


                // finalemnte correr a query que mete tudo na BD
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                //Insert in the database
                SqlCommand com = new SqlCommand("INSERT INTO SimulacaoPrecos (Artigo, Cliente, PecasCartolina, PecasCartao, CartoesPalete, UnBaseArtigo, Cartao, Cartolina, Transporte, Esterilizacao, SubTotal, PrecoVenda, MargemLucro, Salarios, CustosFixos) VALUES (@Artigo, @Cliente, @PecasCartolina, @PecasCartao, @CartoesPalete, @UnBaseArtigo, @Cartao, @Cartolina, @Transporte, @Esterilizacao, @SubTotal, @PrecoVenda, @MargemLucro, @Salarios, @CustosFixos)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Artigo", comboBox2.SelectedItem.ToString());
                com.Parameters.AddWithValue("@Cliente", comboBox1.SelectedValue.ToString());               
                com.Parameters.AddWithValue("@PecasCartolina", pecasCartolina);
                com.Parameters.AddWithValue("@PecasCartao", pecasCartao);
                com.Parameters.AddWithValue("@CartoesPalete", cartoesPalete);
                com.Parameters.AddWithValue("@UnBaseArtigo", unBase);
                com.Parameters.AddWithValue("@Cartao", cartao);
                com.Parameters.AddWithValue("@Cartolina", cartolina);
                com.Parameters.AddWithValue("@Transporte", transporte);
                com.Parameters.AddWithValue("@Esterilizacao", esterilizacao);
                com.Parameters.AddWithValue("@SubTotal", subTotal);
                com.Parameters.AddWithValue("@PrecoVenda", precoVenda);
                com.Parameters.AddWithValue("@MargemLucro", margemLucro);
                com.Parameters.AddWithValue("@Salarios", salarios);
                com.Parameters.AddWithValue("@CustosFixos", preRes);

                int r = com.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Artigo adicionado com sucesso.");

                // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.SimulacaoPrecos'. Você pode movê-la ou removê-la conforme necessário.
                this.simulacaoPrecosTableAdapter.Fill(this.medirmDBDataSet.SimulacaoPrecos);

                simulacaoPrecosDataGridView.Refresh();
                comboBox2.ResetText();

                criarMaquina.Visible = false;
                comboBox2.Visible = false;
                comboBox1.Visible = false;
                textBox1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label4.Visible = false;

            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar artigo ao cliente. Por favor tente novamente.");
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(simulacaoPrecosDataGridView.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in simulacaoPrecosDataGridView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTable.AddCell(cell);
            }

            try
            {
                //Adding DataRow
                foreach (DataGridViewRow row in simulacaoPrecosDataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);

            }

            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable2 = new PdfPTable(artigoDataGridView.ColumnCount);
            pdfTable2.DefaultCell.Padding = 3;
            pdfTable2.WidthPercentage = 100;
            pdfTable2.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable2.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in artigoDataGridView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTable2.AddCell(cell);
            }

            try
            {
                //Adding DataRow
                foreach (DataGridViewRow row in artigoDataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable2.AddCell(cell.Value.ToString());
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);

            }

            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable3 = new PdfPTable(componentesDosArtigosDataGridView.ColumnCount);
            pdfTable3.DefaultCell.Padding = 3;
            pdfTable3.WidthPercentage = 100;
            pdfTable3.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable3.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in componentesDosArtigosDataGridView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTable3.AddCell(cell);
            }

            try
            {
                //Adding DataRow
                foreach (DataGridViewRow row in componentesDosArtigosDataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable3.AddCell(cell.Value.ToString());
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);

            }



            //Exporting to PDF
            string folderPath = "C:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "SimualaçãoPreçosCliente" + comboBox1.Text.Trim().ToString() + "Artigo" + comboBox2.Text.Trim().ToString() + ".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(Chunk.NEWLINE);
                pdfDoc.Add(new Paragraph(""));
                pdfDoc.Add(new Paragraph(""));
                pdfDoc.Add(new Paragraph("MEDIRM"));
                pdfDoc.Add(new Paragraph(""));
                pdfDoc.Add(new Paragraph(""));
                pdfDoc.Add(new Paragraph("Simulação de preços"));
                pdfDoc.Add(new Paragraph(""));
                pdfDoc.Add(new Paragraph(""));
                pdfDoc.Add(Chunk.NEWLINE);
                pdfDoc.Add(pdfTable);
                pdfDoc.Add(Chunk.NEWLINE);
                pdfDoc.Add(new Paragraph(""));
                pdfDoc.Add(new Paragraph(""));
                pdfDoc.Add(pdfTable2);
                pdfDoc.Add(Chunk.NEWLINE);
                pdfDoc.Add(new Paragraph(""));
                pdfDoc.Add(new Paragraph(""));
                pdfDoc.Add(pdfTable3);
                pdfDoc.Close();
                stream.Close();
            }

            MessageBox.Show("PDF criado. Encontra-se no seu disco C: dentro da pasta PDF's");
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
