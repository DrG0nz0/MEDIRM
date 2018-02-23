namespace MEDIRM.GerirPages
{
    partial class GerirCustosFixos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirCustosFixos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.back = new System.Windows.Forms.Button();
            this.medirmDBDataSet = new MEDIRM.MedirmDBDataSet();
            this.custosFixosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.custosFixosTableAdapter = new MEDIRM.MedirmDBDataSetTableAdapters.CustosFixosTableAdapter();
            this.tableAdapterManager = new MEDIRM.MedirmDBDataSetTableAdapters.TableAdapterManager();
            this.custosFixosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.custosFixosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.custosFixosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.medirmDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custosFixosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custosFixosBindingNavigator)).BeginInit();
            this.custosFixosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custosFixosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back.BackgroundImage = global::MEDIRM.Properties.Resources.back;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Location = new System.Drawing.Point(12, 28);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(89, 50);
            this.back.TabIndex = 30;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // medirmDBDataSet
            // 
            this.medirmDBDataSet.DataSetName = "MedirmDBDataSet";
            this.medirmDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // custosFixosBindingSource
            // 
            this.custosFixosBindingSource.DataMember = "CustosFixos";
            this.custosFixosBindingSource.DataSource = this.medirmDBDataSet;
            // 
            // custosFixosTableAdapter
            // 
            this.custosFixosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtigosClientesTableAdapter = null;
            this.tableAdapterManager.ArtigoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CartaoTableAdapter = null;
            this.tableAdapterManager.CartolinaTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.ComponentesDosArtigosTableAdapter = null;
            this.tableAdapterManager.ComponentesTableAdapter = null;
            this.tableAdapterManager.CustosFixosTableAdapter = this.custosFixosTableAdapter;
            this.tableAdapterManager.EncomendaTableAdapter = null;
            this.tableAdapterManager.EsterilizacaoTableAdapter = null;
            this.tableAdapterManager.FeriasTableAdapter = null;
            this.tableAdapterManager.FilmeTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.MaquinaTableAdapter = null;
            this.tableAdapterManager.MoedaTableAdapter = null;
            this.tableAdapterManager.MoldeTableAdapter = null;
            this.tableAdapterManager.PapelTableAdapter = null;
            this.tableAdapterManager.PessoasMaquinasTableAdapter = null;
            this.tableAdapterManager.TipoMaquinaTableAdapter = null;
            this.tableAdapterManager.TransporteTableAdapter = null;
            this.tableAdapterManager.TurnosFuncionariosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MEDIRM.MedirmDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // custosFixosBindingNavigator
            // 
            this.custosFixosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.custosFixosBindingNavigator.BindingSource = this.custosFixosBindingSource;
            this.custosFixosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.custosFixosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.custosFixosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.custosFixosBindingNavigatorSaveItem});
            this.custosFixosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.custosFixosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.custosFixosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.custosFixosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.custosFixosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.custosFixosBindingNavigator.Name = "custosFixosBindingNavigator";
            this.custosFixosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.custosFixosBindingNavigator.Size = new System.Drawing.Size(1484, 25);
            this.custosFixosBindingNavigator.TabIndex = 31;
            this.custosFixosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover seguinte";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // custosFixosBindingNavigatorSaveItem
            // 
            this.custosFixosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.custosFixosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("custosFixosBindingNavigatorSaveItem.Image")));
            this.custosFixosBindingNavigatorSaveItem.Name = "custosFixosBindingNavigatorSaveItem";
            this.custosFixosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.custosFixosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.custosFixosBindingNavigatorSaveItem.Click += new System.EventHandler(this.custosFixosBindingNavigatorSaveItem_Click);
            // 
            // custosFixosDataGridView
            // 
            this.custosFixosDataGridView.AutoGenerateColumns = false;
            this.custosFixosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.custosFixosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custosFixosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.custosFixosDataGridView.DataSource = this.custosFixosBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.custosFixosDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.custosFixosDataGridView.Location = new System.Drawing.Point(324, 114);
            this.custosFixosDataGridView.Name = "custosFixosDataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.custosFixosDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.custosFixosDataGridView.RowHeadersVisible = false;
            this.custosFixosDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.custosFixosDataGridView.Size = new System.Drawing.Size(877, 495);
            this.custosFixosDataGridView.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Designacao";
            this.dataGridViewTextBoxColumn1.HeaderText = "Designacao";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Custo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Custo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // GerirCustosFixos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 691);
            this.Controls.Add(this.custosFixosDataGridView);
            this.Controls.Add(this.custosFixosBindingNavigator);
            this.Controls.Add(this.back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerirCustosFixos";
            this.Text = "GerirCustosFixos";
            this.Load += new System.EventHandler(this.GerirCustosFixos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medirmDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custosFixosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custosFixosBindingNavigator)).EndInit();
            this.custosFixosBindingNavigator.ResumeLayout(false);
            this.custosFixosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custosFixosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private MedirmDBDataSet medirmDBDataSet;
        private System.Windows.Forms.BindingSource custosFixosBindingSource;
        private MedirmDBDataSetTableAdapters.CustosFixosTableAdapter custosFixosTableAdapter;
        private MedirmDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator custosFixosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton custosFixosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView custosFixosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}