﻿namespace MEDIRM
{
    partial class AddArtigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddArtigo));
            this.componentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medirmDBDataSet = new MEDIRM.MedirmDBDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maquinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.maquinaTableAdapter = new MEDIRM.MedirmDBDataSetTableAdapters.MaquinaTableAdapter();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.cartaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.cartolinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartaoTableAdapter = new MEDIRM.MedirmDBDataSetTableAdapters.CartaoTableAdapter();
            this.cartolinaTableAdapter = new MEDIRM.MedirmDBDataSetTableAdapters.CartolinaTableAdapter();
            this.componentesTableAdapter = new MEDIRM.MedirmDBDataSetTableAdapters.ComponentesTableAdapter();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.componentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medirmDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartolinaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // componentesBindingSource
            // 
            this.componentesBindingSource.DataMember = "Componentes";
            this.componentesBindingSource.DataSource = this.medirmDBDataSet;
            // 
            // medirmDBDataSet
            // 
            this.medirmDBDataSet.DataSetName = "MedirmDBDataSet";
            this.medirmDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(627, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 59);
            this.button1.TabIndex = 20;
            this.button1.Text = "Terminar artigo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(335, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(483, 26);
            this.textBox1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome do artigo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(975, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 26);
            this.textBox2.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(827, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Numero do artigo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maquinaBindingSource
            // 
            this.maquinaBindingSource.DataMember = "Maquina";
            this.maquinaBindingSource.DataSource = this.medirmDBDataSet;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(307, 137);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(137, 26);
            this.textBox5.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(189, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Unidade base:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(307, 201);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(137, 26);
            this.textBox6.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(129, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Quantidade por cartão:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(307, 233);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(137, 26);
            this.textBox7.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Quantidade cartoes  por palete:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(77, 330);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 20);
            this.label16.TabIndex = 53;
            this.label16.Text = "Cartão:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(61, 361);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 20);
            this.label17.TabIndex = 55;
            this.label17.Text = "Cartolina:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(307, 169);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(137, 26);
            this.textBox8.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(114, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 20);
            this.label9.TabIndex = 74;
            this.label9.Text = "Quantidade por cartolina:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button12
            // 
            this.button12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button12.BackgroundImage = global::MEDIRM.Properties.Resources.cartaoaoo;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(487, 355);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(42, 35);
            this.button12.TabIndex = 73;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button11.BackgroundImage = global::MEDIRM.Properties.Resources.cartaoo;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(487, 322);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(33, 36);
            this.button11.TabIndex = 72;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackgroundImage = global::MEDIRM.Properties.Resources.catalog1;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(1131, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 69);
            this.button4.TabIndex = 65;
            this.button4.UseVisualStyleBackColor = true;
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
            this.back.TabIndex = 16;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // maquinaTableAdapter
            // 
            this.maquinaTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox7
            // 
            this.comboBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox7.DataSource = this.cartaoBindingSource;
            this.comboBox7.DisplayMember = "Designacao";
            this.comboBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(144, 324);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(337, 28);
            this.comboBox7.TabIndex = 76;
            this.comboBox7.ValueMember = "Designacao";
            // 
            // cartaoBindingSource
            // 
            this.cartaoBindingSource.DataMember = "Cartao";
            this.cartaoBindingSource.DataSource = this.medirmDBDataSet;
            // 
            // comboBox8
            // 
            this.comboBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox8.DataSource = this.cartolinaBindingSource;
            this.comboBox8.DisplayMember = "Designacao";
            this.comboBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(143, 358);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(337, 28);
            this.comboBox8.TabIndex = 77;
            this.comboBox8.ValueMember = "Designacao";
            // 
            // cartolinaBindingSource
            // 
            this.cartolinaBindingSource.DataMember = "Cartolina";
            this.cartolinaBindingSource.DataSource = this.medirmDBDataSet;
            // 
            // cartaoTableAdapter
            // 
            this.cartaoTableAdapter.ClearBeforeFill = true;
            // 
            // cartolinaTableAdapter
            // 
            this.cartolinaTableAdapter.ClearBeforeFill = true;
            // 
            // componentesTableAdapter
            // 
            this.componentesTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox5
            // 
            this.checkBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(656, 359);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(106, 24);
            this.checkBox5.TabIndex = 128;
            this.checkBox5.Text = "Máquina 5:";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(656, 307);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(106, 24);
            this.checkBox4.TabIndex = 127;
            this.checkBox4.Text = "Máquina 4:";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(656, 257);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(106, 24);
            this.checkBox3.TabIndex = 126;
            this.checkBox3.Text = "Máquina 3:";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(656, 200);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(106, 24);
            this.checkBox2.TabIndex = 125;
            this.checkBox2.Text = "Máquina 2:";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(656, 155);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 24);
            this.checkBox1.TabIndex = 124;
            this.checkBox1.Text = "Máquina 1:";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.BackgroundImage = global::MEDIRM.Properties.Resources.maquina;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(1346, 251);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(33, 41);
            this.button9.TabIndex = 122;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.BackgroundImage = global::MEDIRM.Properties.Resources.maquina;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(1346, 298);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(33, 41);
            this.button8.TabIndex = 121;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.BackgroundImage = global::MEDIRM.Properties.Resources.maquina;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(1346, 348);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(33, 41);
            this.button7.TabIndex = 120;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackgroundImage = global::MEDIRM.Properties.Resources.maquina;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1346, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 41);
            this.button2.TabIndex = 119;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.BackgroundImage = global::MEDIRM.Properties.Resources.maquina;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(1346, 145);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(33, 41);
            this.button6.TabIndex = 118;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            // 
            // comboBox6
            // 
            this.comboBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox6.DisplayMember = "Nome";
            this.comboBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(764, 359);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(576, 28);
            this.comboBox6.TabIndex = 117;
            this.comboBox6.ValueMember = "Nome";
            this.comboBox6.Visible = false;
            // 
            // comboBox5
            // 
            this.comboBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox5.DataSource = this.maquinaBindingSource;
            this.comboBox5.DisplayMember = "Nome";
            this.comboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(764, 305);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(576, 28);
            this.comboBox5.TabIndex = 116;
            this.comboBox5.ValueMember = "Nome";
            this.comboBox5.Visible = false;
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox4.DataSource = this.maquinaBindingSource;
            this.comboBox4.DisplayMember = "Nome";
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(764, 255);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(576, 28);
            this.comboBox4.TabIndex = 115;
            this.comboBox4.ValueMember = "Nome";
            this.comboBox4.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DataSource = this.maquinaBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(764, 198);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(576, 28);
            this.comboBox1.TabIndex = 114;
            this.comboBox1.ValueMember = "Nome";
            this.comboBox1.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(764, 151);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(576, 28);
            this.comboBox2.TabIndex = 113;
            this.comboBox2.ValueMember = "Nome";
            this.comboBox2.Visible = false;
            // 
            // AddArtigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddArtigo";
            this.Text = "AddArtigo";
            this.Load += new System.EventHandler(this.AddArtigo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.componentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medirmDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartolinaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private MedirmDBDataSet medirmDBDataSet;
        private System.Windows.Forms.BindingSource maquinaBindingSource;
        private MedirmDBDataSetTableAdapters.MaquinaTableAdapter maquinaTableAdapter;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.BindingSource cartaoBindingSource;
        private MedirmDBDataSetTableAdapters.CartaoTableAdapter cartaoTableAdapter;
        private System.Windows.Forms.BindingSource cartolinaBindingSource;
        private MedirmDBDataSetTableAdapters.CartolinaTableAdapter cartolinaTableAdapter;
        private System.Windows.Forms.BindingSource componentesBindingSource;
        private MedirmDBDataSetTableAdapters.ComponentesTableAdapter componentesTableAdapter;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}