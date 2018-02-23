namespace MEDIRM.AddPages
{
    partial class AddComponentesArtigos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddComponentesArtigos));
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.artigoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medirmDBDataSet = new MEDIRM.MedirmDBDataSet();
            this.button12 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.maquinaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.maquinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.maquinaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.componentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labeltipo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.componentesTableAdapter = new MEDIRM.MedirmDBDataSetTableAdapters.ComponentesTableAdapter();
            this.maquinaTableAdapter = new MEDIRM.MedirmDBDataSetTableAdapters.MaquinaTableAdapter();
            this.artigoTableAdapter = new MEDIRM.MedirmDBDataSetTableAdapters.ArtigoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.artigoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medirmDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox3.DataSource = this.artigoBindingSource;
            this.comboBox3.DisplayMember = "Nome";
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(462, 45);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(503, 28);
            this.comboBox3.TabIndex = 78;
            this.comboBox3.ValueMember = "ID";
            // 
            // artigoBindingSource
            // 
            this.artigoBindingSource.DataMember = "Artigo";
            this.artigoBindingSource.DataSource = this.medirmDBDataSet;
            // 
            // medirmDBDataSet
            // 
            this.medirmDBDataSet.DataSetName = "MedirmDBDataSet";
            this.medirmDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button12
            // 
            this.button12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button12.BackgroundImage = global::MEDIRM.Properties.Resources.catalog;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(971, 38);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(45, 42);
            this.button12.TabIndex = 77;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "Artigo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.back.TabIndex = 81;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button10.BackgroundImage = global::MEDIRM.Properties.Resources.componentes;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(736, 115);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(48, 38);
            this.button10.TabIndex = 102;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.BackgroundImage = global::MEDIRM.Properties.Resources.maquina;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(1124, 293);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(33, 41);
            this.button9.TabIndex = 101;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.BackgroundImage = global::MEDIRM.Properties.Resources.maquina;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(1124, 340);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(33, 41);
            this.button8.TabIndex = 100;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.BackgroundImage = global::MEDIRM.Properties.Resources.maquina;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(1124, 390);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(33, 41);
            this.button7.TabIndex = 99;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackgroundImage = global::MEDIRM.Properties.Resources.maquina;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1124, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 41);
            this.button1.TabIndex = 98;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.BackgroundImage = global::MEDIRM.Properties.Resources.maquina;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(1124, 187);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(33, 41);
            this.button6.TabIndex = 97;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // comboBox6
            // 
            this.comboBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox6.DataSource = this.maquinaBindingSource2;
            this.comboBox6.DisplayMember = "Nome";
            this.comboBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(405, 403);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(713, 28);
            this.comboBox6.TabIndex = 96;
            this.comboBox6.ValueMember = "Nome";
            // 
            // maquinaBindingSource2
            // 
            this.maquinaBindingSource2.DataMember = "Maquina";
            this.maquinaBindingSource2.DataSource = this.medirmDBDataSet;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(311, 406);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 20);
            this.label15.TabIndex = 95;
            this.label15.Text = "Máquina 5:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox5
            // 
            this.comboBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox5.DataSource = this.maquinaBindingSource;
            this.comboBox5.DisplayMember = "Nome";
            this.comboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(405, 349);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(713, 28);
            this.comboBox5.TabIndex = 94;
            this.comboBox5.ValueMember = "Nome";
            // 
            // maquinaBindingSource
            // 
            this.maquinaBindingSource.DataMember = "Maquina";
            this.maquinaBindingSource.DataSource = this.medirmDBDataSet;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(311, 352);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 20);
            this.label14.TabIndex = 93;
            this.label14.Text = "Máquina 4:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox4.DataSource = this.maquinaBindingSource;
            this.comboBox4.DisplayMember = "Nome";
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(405, 299);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(713, 28);
            this.comboBox4.TabIndex = 92;
            this.comboBox4.ValueMember = "Nome";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(311, 302);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 20);
            this.label13.TabIndex = 91;
            this.label13.Text = "Máquina 3:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DataSource = this.maquinaBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(405, 242);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(713, 28);
            this.comboBox1.TabIndex = 90;
            this.comboBox1.ValueMember = "Nome";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(311, 245);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 20);
            this.label12.TabIndex = 89;
            this.label12.Text = "Máquina 2:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox7
            // 
            this.comboBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox7.DataSource = this.maquinaBindingSource1;
            this.comboBox7.DisplayMember = "Nome";
            this.comboBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(405, 195);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(713, 28);
            this.comboBox7.TabIndex = 88;
            this.comboBox7.ValueMember = "Nome";
            // 
            // maquinaBindingSource1
            // 
            this.maquinaBindingSource1.DataMember = "Maquina";
            this.maquinaBindingSource1.DataSource = this.medirmDBDataSet;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 87;
            this.label4.Text = "Máquina 1:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(405, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 26);
            this.textBox1.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(303, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 85;
            this.label5.Text = "Quantidade:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(1241, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 59);
            this.button2.TabIndex = 84;
            this.button2.Text = "Adicionar componente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox8
            // 
            this.comboBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox8.DataSource = this.componentesBindingSource;
            this.comboBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(405, 117);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(312, 28);
            this.comboBox8.TabIndex = 83;
            // 
            // componentesBindingSource
            // 
            this.componentesBindingSource.DataMember = "Componentes";
            this.componentesBindingSource.DataSource = this.medirmDBDataSet;
            // 
            // labeltipo
            // 
            this.labeltipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeltipo.AutoSize = true;
            this.labeltipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltipo.Location = new System.Drawing.Point(293, 120);
            this.labeltipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltipo.Name = "labeltipo";
            this.labeltipo.Size = new System.Drawing.Size(105, 20);
            this.labeltipo.TabIndex = 82;
            this.labeltipo.Text = "Componente:";
            this.labeltipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(297, 469);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(860, 177);
            this.dataGridView1.TabIndex = 103;
            // 
            // componentesTableAdapter
            // 
            this.componentesTableAdapter.ClearBeforeFill = true;
            // 
            // maquinaTableAdapter
            // 
            this.maquinaTableAdapter.ClearBeforeFill = true;
            // 
            // artigoTableAdapter
            // 
            this.artigoTableAdapter.ClearBeforeFill = true;
            // 
            // AddComponentesArtigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 691);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.labeltipo);
            this.Controls.Add(this.back);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddComponentesArtigos";
            this.Text = "Adcicionar componentes aos artigos";
            this.Load += new System.EventHandler(this.AddComponentesArtigos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.artigoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medirmDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label labeltipo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MedirmDBDataSet medirmDBDataSet;
        private System.Windows.Forms.BindingSource componentesBindingSource;
        private MedirmDBDataSetTableAdapters.ComponentesTableAdapter componentesTableAdapter;
        private System.Windows.Forms.BindingSource maquinaBindingSource;
        private MedirmDBDataSetTableAdapters.MaquinaTableAdapter maquinaTableAdapter;
        private System.Windows.Forms.BindingSource artigoBindingSource;
        private MedirmDBDataSetTableAdapters.ArtigoTableAdapter artigoTableAdapter;
        private System.Windows.Forms.BindingSource maquinaBindingSource2;
        private System.Windows.Forms.BindingSource maquinaBindingSource1;
    }
}