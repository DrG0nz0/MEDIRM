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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;



namespace MEDIRM.OtherPages
{
    public partial class VerTurnosFuncionarios : Form
    {
        public VerTurnosFuncionarios()
        {
            InitializeComponent();
        }

        private void turnosFuncionariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.turnosFuncionariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medirmDBDataSet);

        }

        private void turnosFuncionariosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.turnosFuncionariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medirmDBDataSet);

        }

        private void VerTurnosFuncionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.medirmDBDataSet.Funcionario);
            // TODO: esta linha de código carrega dados na tabela 'medirmDBDataSet.TurnosFuncionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.turnosFuncionariosTableAdapter.Fill(this.medirmDBDataSet.TurnosFuncionarios);
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new Menu());
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            turnosFuncionariosDataGridView.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)      // criar pdf
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(turnosFuncionariosDataGridView.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 50;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in turnosFuncionariosDataGridView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            try
            {
                //Adding DataRow
                foreach (DataGridViewRow row in turnosFuncionariosDataGridView.Rows)
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
            

            //Exporting to PDF
            string folderPath = "C:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "HorarioSemanalFuncionariosMedirm.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }

            MessageBox.Show("PDF criado. Encontra-se no seu disco C: dentro da pasta PDF's");
        }
    }
}
