namespace auto
{
    partial class SaleEvent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
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
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleEvent));
            this.autoDataSet = new auto.autoDataSet();
            this.sALEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sALETableAdapter = new auto.autoDataSetTableAdapters.SALETableAdapter();
            this.tableAdapterManager = new auto.autoDataSetTableAdapters.TableAdapterManager();
            this.aUTOTableAdapter = new auto.autoDataSetTableAdapters.AUTOTableAdapter();
            this.eMPLOYEETableAdapter = new auto.autoDataSetTableAdapters.EMPLOYEETableAdapter();
            this.pAYTableAdapter = new auto.autoDataSetTableAdapters.PAYTableAdapter();
            this.pERSONTableAdapter = new auto.autoDataSetTableAdapters.PERSONTableAdapter();
            this.sALEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sALEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.sALEDataGridView = new DataGridWithFilter.DataGridWithFilter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERSON = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pERSONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AUTO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.aUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EMPLOYEE = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PAY = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pAYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALEBindingNavigator)).BeginInit();
            this.sALEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sALEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // autoDataSet
            // 
            this.autoDataSet.DataSetName = "autoDataSet";
            this.autoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sALEBindingSource
            // 
            this.sALEBindingSource.DataMember = "SALE";
            this.sALEBindingSource.DataSource = this.autoDataSet;
            // 
            // sALETableAdapter
            // 
            this.sALETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AUTOTableAdapter = this.aUTOTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTTableAdapter = null;
            this.tableAdapterManager.DELIVERYTableAdapter = null;
            this.tableAdapterManager.EMPLOYEETableAdapter = this.eMPLOYEETableAdapter;
            this.tableAdapterManager.ENGINETableAdapter = null;
            this.tableAdapterManager.MARKTableAdapter = null;
            this.tableAdapterManager.MODELTableAdapter = null;
            this.tableAdapterManager.MODIFICATIONTableAdapter = null;
            this.tableAdapterManager.PAYTableAdapter = this.pAYTableAdapter;
            this.tableAdapterManager.PERSON_INFOTableAdapter = null;
            this.tableAdapterManager.PERSONTableAdapter = this.pERSONTableAdapter;
            this.tableAdapterManager.POSTTableAdapter = null;
            this.tableAdapterManager.PROVIDERTableAdapter = null;
            this.tableAdapterManager.SALETableAdapter = this.sALETableAdapter;
            this.tableAdapterManager.STATUSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = auto.autoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aUTOTableAdapter
            // 
            this.aUTOTableAdapter.ClearBeforeFill = true;
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // pAYTableAdapter
            // 
            this.pAYTableAdapter.ClearBeforeFill = true;
            // 
            // pERSONTableAdapter
            // 
            this.pERSONTableAdapter.ClearBeforeFill = true;
            // 
            // sALEBindingNavigator
            // 
            this.sALEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sALEBindingNavigator.BindingSource = this.sALEBindingSource;
            this.sALEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sALEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sALEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sALEBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.sALEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sALEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sALEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sALEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sALEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sALEBindingNavigator.Name = "sALEBindingNavigator";
            this.sALEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sALEBindingNavigator.Size = new System.Drawing.Size(1148, 25);
            this.sALEBindingNavigator.TabIndex = 0;
            this.sALEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // sALEBindingNavigatorSaveItem
            // 
            this.sALEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sALEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sALEBindingNavigatorSaveItem.Image")));
            this.sALEBindingNavigatorSaveItem.Name = "sALEBindingNavigatorSaveItem";
            this.sALEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sALEBindingNavigatorSaveItem.Text = "Save Data";
            this.sALEBindingNavigatorSaveItem.Click += new System.EventHandler(this.sALEBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(65, 22);
            this.toolStripButton1.Text = "Обновить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // sALEDataGridView
            // 
            this.sALEDataGridView.AutoGenerateColumns = false;
            this.sALEDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.sALEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sALEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.PERSON,
            this.AUTO,
            this.EMPLOYEE,
            this.PAY,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6});
            this.sALEDataGridView.DataSource = this.sALEBindingSource;
            this.sALEDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sALEDataGridView.Location = new System.Drawing.Point(0, 25);
            this.sALEDataGridView.Name = "sALEDataGridView";
            this.sALEDataGridView.Size = new System.Drawing.Size(1148, 519);
            this.sALEDataGridView.TabIndex = 1;
            this.sALEDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.sALEDataGridView_CellEndEdit);
            this.sALEDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.sALEDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SALE_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PERSON_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AUTO_ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EMPLOYEE_ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PAY_ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // PERSON
            // 
            this.PERSON.DataPropertyName = "PERSON_ID";
            this.PERSON.DataSource = this.pERSONBindingSource;
            this.PERSON.DisplayMember = "PERSON_FULL";
            this.PERSON.Name = "PERSON";
            this.PERSON.ValueMember = "PERSON_ID";
            this.PERSON.Width = 250;
            // 
            // pERSONBindingSource
            // 
            this.pERSONBindingSource.DataMember = "PERSON";
            this.pERSONBindingSource.DataSource = this.autoDataSet;
            // 
            // AUTO
            // 
            this.AUTO.DataPropertyName = "AUTO_ID";
            this.AUTO.DataSource = this.aUTOBindingSource;
            this.AUTO.DisplayMember = "AUTO_FULL";
            this.AUTO.Name = "AUTO";
            this.AUTO.ValueMember = "AUTO_ID";
            this.AUTO.Width = 300;
            // 
            // aUTOBindingSource
            // 
            this.aUTOBindingSource.DataMember = "AUTO";
            this.aUTOBindingSource.DataSource = this.autoDataSet;
            // 
            // EMPLOYEE
            // 
            this.EMPLOYEE.DataPropertyName = "EMPLOYEE_ID";
            this.EMPLOYEE.DataSource = this.eMPLOYEEBindingSource;
            this.EMPLOYEE.DisplayMember = "EMPLOYEE_FULL";
            this.EMPLOYEE.Name = "EMPLOYEE";
            this.EMPLOYEE.ValueMember = "EMPLOYEE_ID";
            this.EMPLOYEE.Width = 250;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.autoDataSet;
            // 
            // PAY
            // 
            this.PAY.DataPropertyName = "PAY_ID";
            this.PAY.DataSource = this.pAYBindingSource;
            this.PAY.DisplayMember = "PAY_NAME";
            this.PAY.Name = "PAY";
            this.PAY.ValueMember = "PAY_ID";
            // 
            // pAYBindingSource
            // 
            this.pAYBindingSource.DataMember = "PAY";
            this.pAYBindingSource.DataSource = this.autoDataSet;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SALE_DATE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SALE_PRICE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // SaleEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 544);
            this.Controls.Add(this.sALEDataGridView);
            this.Controls.Add(this.sALEBindingNavigator);
            this.Name = "SaleEvent";
            this.Text = "Продажи автомобилей";
            this.Load += new System.EventHandler(this.SaleEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALEBindingNavigator)).EndInit();
            this.sALEBindingNavigator.ResumeLayout(false);
            this.sALEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sALEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private autoDataSet autoDataSet;
        private System.Windows.Forms.BindingSource sALEBindingSource;
        private autoDataSetTableAdapters.SALETableAdapter sALETableAdapter;
        private autoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sALEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sALEBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private autoDataSetTableAdapters.PERSONTableAdapter pERSONTableAdapter;
        private System.Windows.Forms.BindingSource pERSONBindingSource;
        private autoDataSetTableAdapters.AUTOTableAdapter aUTOTableAdapter;
        private System.Windows.Forms.BindingSource aUTOBindingSource;
        private autoDataSetTableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private autoDataSetTableAdapters.PAYTableAdapter pAYTableAdapter;
        private System.Windows.Forms.BindingSource pAYBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn PERSON;
        private System.Windows.Forms.DataGridViewComboBoxColumn AUTO;
        private System.Windows.Forms.DataGridViewComboBoxColumn EMPLOYEE;
        private System.Windows.Forms.DataGridViewComboBoxColumn PAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridWithFilter.DataGridWithFilter sALEDataGridView;
    }
}