namespace MEDIRM.GerirPages
{
    partial class GerirTurnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirTurnos));
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medirmDBDataSet = new MEDIRM.MedirmDBDataSet();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.funcionarioTableAdapter = new MEDIRM.MedirmDBDataSetTableAdapters.FuncionarioTableAdapter();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medirmDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox8
            // 
            this.comboBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox8.DataSource = this.funcionarioBindingSource;
            this.comboBox8.DisplayMember = "Nome";
            this.comboBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(451, 127);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(675, 28);
            this.comboBox8.TabIndex = 63;
            this.comboBox8.ValueMember = "ID";
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
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.BackgroundImage = global::MEDIRM.Properties.Resources.worker;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(680, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 109);
            this.button8.TabIndex = 62;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Nome do funcionário: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Segunda-feira",
            "Terça-feira",
            "Quarta-feira",
            "Quinta-feira",
            "Sexta-feira",
            "Sabado"});
            this.comboBox1.Location = new System.Drawing.Point(451, 209);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(675, 28);
            this.comboBox1.TabIndex = 65;
            this.comboBox1.ValueMember = "Nome";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 64;
            this.label2.Text = "Dia da semana:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "7h - 8h",
            "8h -12h",
            "Nenhum"});
            this.comboBox2.Location = new System.Drawing.Point(680, 308);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 28);
            this.comboBox2.TabIndex = 67;
            this.comboBox2.ValueMember = "Nome";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(554, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 66;
            this.label3.Text = "Turno 1:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox3.DisplayMember = "Nome";
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "8h -12h",
            "12h -13h",
            "Nenhum"});
            this.comboBox3.Location = new System.Drawing.Point(680, 342);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 28);
            this.comboBox3.TabIndex = 69;
            this.comboBox3.ValueMember = "Nome";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(554, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 68;
            this.label4.Text = "Turno 2:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox4.DisplayMember = "Nome";
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "13h -14h",
            "14h - 17h",
            "Nenhum"});
            this.comboBox4.Location = new System.Drawing.Point(680, 376);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(200, 28);
            this.comboBox4.TabIndex = 71;
            this.comboBox4.ValueMember = "Nome";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(554, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "Turno 3:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox5
            // 
            this.comboBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox5.DisplayMember = "Nome";
            this.comboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "14h - 17h",
            "17h - 18h",
            "Nenhum"});
            this.comboBox5.Location = new System.Drawing.Point(680, 410);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(200, 28);
            this.comboBox5.TabIndex = 73;
            this.comboBox5.ValueMember = "Nome";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(554, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 72;
            this.label6.Text = "Turno 4:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(690, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 74;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // back
            // 
            this.back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back.BackgroundImage = global::MEDIRM.Properties.Resources.back;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(89, 50);
            this.back.TabIndex = 75;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // GerirTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 691);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerirTurnos";
            this.Text = "GerirTurnos";
            this.Load += new System.EventHandler(this.GerirTurnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medirmDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private MedirmDBDataSet medirmDBDataSet;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private MedirmDBDataSetTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.Button back;
    }
}