namespace MEDIRM.GeneticSolution
{
    partial class TabelaHorario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabelaHorario));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.turnoVisualizerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskVisualizerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaDaSemana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMaquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moldeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encomendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoVisualizerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskVisualizerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Turno,
            this.DiaDaSemana,
            this.TipoMaquina,
            this.Column1,
            this.Tras,
            this.artigoDataGridViewTextBoxColumn,
            this.moldeDataGridViewTextBoxColumn,
            this.filmeDataGridViewTextBoxColumn,
            this.papelDataGridViewTextBoxColumn,
            this.encomendaDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.DataEntrega});
            this.dataGridView1.DataSource = this.turnoVisualizerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.Size = new System.Drawing.Size(1484, 691);
            this.dataGridView1.TabIndex = 0;
            // 
            // turnoVisualizerBindingSource
            // 
            this.turnoVisualizerBindingSource.DataSource = typeof(MEDIRM.GeneticSolution.Helpers.TurnoVisualizer);
            // 
            // taskVisualizerBindingSource
            // 
            this.taskVisualizerBindingSource.DataSource = typeof(MEDIRM.GeneticSolution.Helpers.TaskVisualizer);
            // 
            // Turno
            // 
            this.Turno.DataPropertyName = "Turno";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Turno.DefaultCellStyle = dataGridViewCellStyle2;
            this.Turno.HeaderText = "Turno";
            this.Turno.Name = "Turno";
            this.Turno.ReadOnly = true;
            // 
            // DiaDaSemana
            // 
            this.DiaDaSemana.DataPropertyName = "DiaDaSemana";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DiaDaSemana.DefaultCellStyle = dataGridViewCellStyle3;
            this.DiaDaSemana.HeaderText = "DiaDaSemana";
            this.DiaDaSemana.Name = "DiaDaSemana";
            this.DiaDaSemana.ReadOnly = true;
            // 
            // TipoMaquina
            // 
            this.TipoMaquina.DataPropertyName = "TipoMaquina";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TipoMaquina.DefaultCellStyle = dataGridViewCellStyle4;
            this.TipoMaquina.HeaderText = "TipoMaquina";
            this.TipoMaquina.Name = "TipoMaquina";
            this.TipoMaquina.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Frente";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column1.HeaderText = "Frente";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Tras
            // 
            this.Tras.DataPropertyName = "Tras";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tras.DefaultCellStyle = dataGridViewCellStyle6;
            this.Tras.HeaderText = "Tras";
            this.Tras.Name = "Tras";
            this.Tras.ReadOnly = true;
            // 
            // artigoDataGridViewTextBoxColumn
            // 
            this.artigoDataGridViewTextBoxColumn.DataPropertyName = "Artigo";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.artigoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.artigoDataGridViewTextBoxColumn.HeaderText = "Artigo";
            this.artigoDataGridViewTextBoxColumn.Name = "artigoDataGridViewTextBoxColumn";
            this.artigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moldeDataGridViewTextBoxColumn
            // 
            this.moldeDataGridViewTextBoxColumn.DataPropertyName = "Molde";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.moldeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.moldeDataGridViewTextBoxColumn.HeaderText = "Molde";
            this.moldeDataGridViewTextBoxColumn.Name = "moldeDataGridViewTextBoxColumn";
            this.moldeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmeDataGridViewTextBoxColumn
            // 
            this.filmeDataGridViewTextBoxColumn.DataPropertyName = "Filme";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.filmeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.filmeDataGridViewTextBoxColumn.HeaderText = "Filme";
            this.filmeDataGridViewTextBoxColumn.Name = "filmeDataGridViewTextBoxColumn";
            this.filmeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // papelDataGridViewTextBoxColumn
            // 
            this.papelDataGridViewTextBoxColumn.DataPropertyName = "Papel";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.papelDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.papelDataGridViewTextBoxColumn.HeaderText = "Papel";
            this.papelDataGridViewTextBoxColumn.Name = "papelDataGridViewTextBoxColumn";
            this.papelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // encomendaDataGridViewTextBoxColumn
            // 
            this.encomendaDataGridViewTextBoxColumn.DataPropertyName = "Encomenda";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.encomendaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.encomendaDataGridViewTextBoxColumn.HeaderText = "Encomenda";
            this.encomendaDataGridViewTextBoxColumn.Name = "encomendaDataGridViewTextBoxColumn";
            this.encomendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clienteDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DataEntrega
            // 
            this.DataEntrega.DataPropertyName = "DataEntrega";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataEntrega.DefaultCellStyle = dataGridViewCellStyle13;
            this.DataEntrega.HeaderText = "DataEntrega";
            this.DataEntrega.Name = "DataEntrega";
            this.DataEntrega.ReadOnly = true;
            // 
            // TabelaHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 691);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TabelaHorario";
            this.Text = "TabelaHorario";
            this.Load += new System.EventHandler(this.TabelaHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoVisualizerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskVisualizerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource taskVisualizerBindingSource;
        private System.Windows.Forms.BindingSource turnoVisualizerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maquinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDaSemana;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMaquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tras;
        private System.Windows.Forms.DataGridViewTextBoxColumn artigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moldeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn papelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn encomendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEntrega;
    }
}