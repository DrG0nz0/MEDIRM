namespace MEDIRM
{
    partial class AddTransportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTransportes));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.criarMaquina = new System.Windows.Forms.Button();
            this.LabelMaxtras = new System.Windows.Forms.Label();
            this.LabelminAtras = new System.Windows.Forms.Label();
            this.minFrente = new System.Windows.Forms.TextBox();
            this.Labelminfrente = new System.Windows.Forms.Label();
            this.labeltipo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.moedaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medirmDBDataSet = new MEDIRM.MedirmDBDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.moedaTableAdapter = new MEDIRM.MedirmDBDataSetTableAdapters.MoedaTableAdapter();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.moedaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medirmDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(523, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(544, 26);
            this.textBox1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nome/designação:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // criarMaquina
            // 
            this.criarMaquina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.criarMaquina.Location = new System.Drawing.Point(630, 564);
            this.criarMaquina.Name = "criarMaquina";
            this.criarMaquina.Size = new System.Drawing.Size(191, 59);
            this.criarMaquina.TabIndex = 23;
            this.criarMaquina.Text = "Criar";
            this.criarMaquina.UseVisualStyleBackColor = true;
            this.criarMaquina.Click += new System.EventHandler(this.criarMaquina_Click);
            // 
            // LabelMaxtras
            // 
            this.LabelMaxtras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelMaxtras.AutoSize = true;
            this.LabelMaxtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMaxtras.Location = new System.Drawing.Point(623, 459);
            this.LabelMaxtras.Name = "LabelMaxtras";
            this.LabelMaxtras.Size = new System.Drawing.Size(34, 20);
            this.LabelMaxtras.TabIndex = 21;
            this.LabelMaxtras.Text = "De:";
            this.LabelMaxtras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelminAtras
            // 
            this.LabelminAtras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelminAtras.AutoSize = true;
            this.LabelminAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelminAtras.Location = new System.Drawing.Point(535, 424);
            this.LabelminAtras.Name = "LabelminAtras";
            this.LabelminAtras.Size = new System.Drawing.Size(122, 20);
            this.LabelminAtras.TabIndex = 19;
            this.LabelminAtras.Text = "Transportadora:";
            this.LabelminAtras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minFrente
            // 
            this.minFrente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minFrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minFrente.Location = new System.Drawing.Point(663, 335);
            this.minFrente.Name = "minFrente";
            this.minFrente.Size = new System.Drawing.Size(100, 26);
            this.minFrente.TabIndex = 16;
            this.minFrente.Text = "auto";
            // 
            // Labelminfrente
            // 
            this.Labelminfrente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Labelminfrente.AutoSize = true;
            this.Labelminfrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelminfrente.Location = new System.Drawing.Point(509, 338);
            this.Labelminfrente.Name = "Labelminfrente";
            this.Labelminfrente.Size = new System.Drawing.Size(148, 20);
            this.Labelminfrente.TabIndex = 15;
            this.Labelminfrente.Text = "Utilizador que criou:";
            this.Labelminfrente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labeltipo
            // 
            this.labeltipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeltipo.AutoSize = true;
            this.labeltipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltipo.Location = new System.Drawing.Point(566, 288);
            this.labeltipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltipo.Name = "labeltipo";
            this.labeltipo.Size = new System.Drawing.Size(90, 20);
            this.labeltipo.TabIndex = 14;
            this.labeltipo.Text = "Preço (m3):";
            this.labeltipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(611, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Para:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.back.TabIndex = 29;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button11.BackgroundImage = global::MEDIRM.Properties.Resources.transp;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(663, 82);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 100);
            this.button11.TabIndex = 30;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(591, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(405, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "(transportadora - cidade saida - cidade destino - volume)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(890, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Info:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox1.Location = new System.Drawing.Point(937, 334);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(429, 255);
            this.richTextBox1.TabIndex = 51;
            this.richTextBox1.Text = "";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackgroundImage = global::MEDIRM.Properties.Resources.noeda;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(823, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 26);
            this.button3.TabIndex = 84;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.DataSource = this.moedaBindingSource;
            this.comboBox2.DisplayMember = "Moeda";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(663, 378);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 28);
            this.comboBox2.TabIndex = 83;
            this.comboBox2.ValueMember = "Moeda";
            // 
            // moedaBindingSource
            // 
            this.moedaBindingSource.DataMember = "Moeda";
            this.moedaBindingSource.DataSource = this.medirmDBDataSet;
            // 
            // medirmDBDataSet
            // 
            this.medirmDBDataSet.DataSetName = "MedirmDBDataSet";
            this.medirmDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(595, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 82;
            this.label7.Text = "Moeda:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moedaTableAdapter
            // 
            this.moedaTableAdapter.ClearBeforeFill = true;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(663, 288);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(154, 26);
            this.textBox3.TabIndex = 85;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "tls"});
            this.comboBox1.Location = new System.Drawing.Point(663, 421);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 28);
            this.comboBox1.TabIndex = 86;
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "lisboa"});
            this.comboBox3.Location = new System.Drawing.Point(663, 459);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(154, 28);
            this.comboBox3.TabIndex = 87;
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "porto"});
            this.comboBox4.Location = new System.Drawing.Point(663, 499);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(154, 28);
            this.comboBox4.TabIndex = 88;
            // 
            // AddTransportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 691);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.criarMaquina);
            this.Controls.Add(this.LabelMaxtras);
            this.Controls.Add(this.LabelminAtras);
            this.Controls.Add(this.minFrente);
            this.Controls.Add(this.Labelminfrente);
            this.Controls.Add(this.labeltipo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTransportes";
            this.Text = "AddTransportes";
            this.Load += new System.EventHandler(this.AddTransportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moedaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medirmDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button criarMaquina;
        private System.Windows.Forms.Label LabelMaxtras;
        private System.Windows.Forms.Label LabelminAtras;
        private System.Windows.Forms.TextBox minFrente;
        private System.Windows.Forms.Label Labelminfrente;
        private System.Windows.Forms.Label labeltipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private MedirmDBDataSet medirmDBDataSet;
        private System.Windows.Forms.BindingSource moedaBindingSource;
        private MedirmDBDataSetTableAdapters.MoedaTableAdapter moedaTableAdapter;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}