namespace MEDIRM.AddPages
{
    partial class AddPessoasMaquinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPessoasMaquinas));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medirmDBDataSet = new MEDIRM.MedirmDBDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.funcionarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maquinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.funcionarioTableAdapter = new MEDIRM.MedirmDBDataSetTableAdapters.FuncionarioTableAdapter();
            this.maquinaTableAdapter = new MEDIRM.MedirmDBDataSetTableAdapters.MaquinaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medirmDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(1040, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 39);
            this.button2.TabIndex = 42;
            this.button2.Text = "Adicionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(274, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 41;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(124, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(408, 301);
            this.dataGridView1.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Posição: frente";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1036, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Posição: atrás";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox3.DataSource = this.funcionarioBindingSource;
            this.comboBox3.DisplayMember = "Nome";
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(124, 171);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(408, 26);
            this.comboBox3.TabIndex = 36;
            this.comboBox3.ValueMember = "ID";
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.medirmDBDataSet;
            // 
            // medirmDBDataSet
            // 
            this.medirmDBDataSet.DataSetName = "MedirmDBDataSet";
            this.medirmDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.DataSource = this.funcionarioBindingSource1;
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(876, 171);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(408, 26);
            this.comboBox2.TabIndex = 35;
            this.comboBox2.ValueMember = "ID";
            // 
            // funcionarioBindingSource1
            // 
            this.funcionarioBindingSource1.DataMember = "Funcionario";
            this.funcionarioBindingSource1.DataSource = this.medirmDBDataSet;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nome da máquina:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DataSource = this.maquinaBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(464, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(584, 26);
            this.comboBox1.TabIndex = 44;
            this.comboBox1.ValueMember = "Nome";
            // 
            // maquinaBindingSource
            // 
            this.maquinaBindingSource.DataMember = "Maquina";
            this.maquinaBindingSource.DataSource = this.medirmDBDataSet;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(618, 589);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 56);
            this.button3.TabIndex = 49;
            this.button3.Text = "Concluir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(876, 286);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(408, 301);
            this.dataGridView2.TabIndex = 50;
            // 
            // back
            // 
            this.back.BackgroundImage = global::MEDIRM.Properties.Resources.back;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(89, 50);
            this.back.TabIndex = 48;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.BackgroundImage = global::MEDIRM.Properties.Resources.maquina;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(1054, 58);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 28);
            this.button6.TabIndex = 47;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // maquinaTableAdapter
            // 
            this.maquinaTableAdapter.ClearBeforeFill = true;
            // 
            // AddPessoasMaquinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 691);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPessoasMaquinas";
            this.Text = "Adicionar pessoas as maquinas";
            this.Load += new System.EventHandler(this.AddPessoasMaquinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medirmDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MedirmDBDataSet medirmDBDataSet;
        private MedirmDBDataSetTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private System.Windows.Forms.BindingSource funcionarioBindingSource1;
        private System.Windows.Forms.BindingSource maquinaBindingSource;
        private MedirmDBDataSetTableAdapters.MaquinaTableAdapter maquinaTableAdapter;
    }
}