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
            this.maquinaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.maquinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maquinaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.componentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labeltipo = new System.Windows.Forms.Label();
            this.componentesTableAdapter = new MEDIRM.MedirmDBDataSetTableAdapters.ComponentesTableAdapter();
            this.maquinaTableAdapter = new MEDIRM.MedirmDBDataSetTableAdapters.MaquinaTableAdapter();
            this.artigoTableAdapter = new MEDIRM.MedirmDBDataSetTableAdapters.ArtigoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.artigoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medirmDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentesBindingSource)).BeginInit();
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
            this.comboBox3.ValueMember = "Nome";
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
            this.button10.Location = new System.Drawing.Point(906, 247);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(48, 38);
            this.button10.TabIndex = 102;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // maquinaBindingSource2
            // 
            this.maquinaBindingSource2.DataMember = "Maquina";
            this.maquinaBindingSource2.DataSource = this.medirmDBDataSet;
            // 
            // maquinaBindingSource
            // 
            this.maquinaBindingSource.DataMember = "Maquina";
            this.maquinaBindingSource.DataSource = this.medirmDBDataSet;
            // 
            // maquinaBindingSource1
            // 
            this.maquinaBindingSource1.DataMember = "Maquina";
            this.maquinaBindingSource1.DataSource = this.medirmDBDataSet;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(575, 288);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 26);
            this.textBox1.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(473, 291);
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
            this.comboBox8.DisplayMember = "Nome";
            this.comboBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(575, 249);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(312, 28);
            this.comboBox8.TabIndex = 83;
            this.comboBox8.ValueMember = "Nome";
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
            this.labeltipo.Location = new System.Drawing.Point(463, 252);
            this.labeltipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltipo.Name = "labeltipo";
            this.labeltipo.Size = new System.Drawing.Size(105, 20);
            this.labeltipo.TabIndex = 82;
            this.labeltipo.Text = "Componente:";
            this.labeltipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Controls.Add(this.button10);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label labeltipo;
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