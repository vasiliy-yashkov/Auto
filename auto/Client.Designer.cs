namespace auto
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.autoDataSet = new auto.autoDataSet();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTTableAdapter = new auto.autoDataSetTableAdapters.CLIENTTableAdapter();
            this.tableAdapterManager = new auto.autoDataSetTableAdapters.TableAdapterManager();
            this.cLIENTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cLIENTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cLIENTDataGridView = new DataGridWithFilter.DataGridWithFilter();
            this.pERSONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERSONTableAdapter = new auto.autoDataSetTableAdapters.PERSONTableAdapter();
            this.aUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aUTOTableAdapter = new auto.autoDataSetTableAdapters.AUTOTableAdapter();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERSON = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AUTO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingNavigator)).BeginInit();
            this.cLIENTBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // autoDataSet
            // 
            this.autoDataSet.DataSetName = "autoDataSet";
            this.autoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTBindingSource
            // 
            this.cLIENTBindingSource.DataMember = "CLIENT";
            this.cLIENTBindingSource.DataSource = this.autoDataSet;
            // 
            // cLIENTTableAdapter
            // 
            this.cLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AUTOTableAdapter = this.aUTOTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTTableAdapter = this.cLIENTTableAdapter;
            this.tableAdapterManager.DELIVERYTableAdapter = null;
            this.tableAdapterManager.EMPLOYEETableAdapter = null;
            this.tableAdapterManager.MODIFICATIONTableAdapter = null;
            this.tableAdapterManager.PAYTableAdapter = null;
            this.tableAdapterManager.PERSON_INFOTableAdapter = null;
            this.tableAdapterManager.PERSONTableAdapter = this.pERSONTableAdapter;
            this.tableAdapterManager.POSTTableAdapter = null;
            this.tableAdapterManager.PROVIDERTableAdapter = null;
            this.tableAdapterManager.SALETableAdapter = null;
            this.tableAdapterManager.STATUSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = auto.autoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cLIENTBindingNavigator
            // 
            this.cLIENTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cLIENTBindingNavigator.BindingSource = this.cLIENTBindingSource;
            this.cLIENTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cLIENTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cLIENTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cLIENTBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.cLIENTBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cLIENTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cLIENTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cLIENTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cLIENTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cLIENTBindingNavigator.Name = "cLIENTBindingNavigator";
            this.cLIENTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cLIENTBindingNavigator.Size = new System.Drawing.Size(957, 25);
            this.cLIENTBindingNavigator.TabIndex = 0;
            this.cLIENTBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // cLIENTBindingNavigatorSaveItem
            // 
            this.cLIENTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cLIENTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cLIENTBindingNavigatorSaveItem.Image")));
            this.cLIENTBindingNavigatorSaveItem.Name = "cLIENTBindingNavigatorSaveItem";
            this.cLIENTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cLIENTBindingNavigatorSaveItem.Text = "Save Data";
            this.cLIENTBindingNavigatorSaveItem.Click += new System.EventHandler(this.cLIENTBindingNavigatorSaveItem_Click);
            // 
            // cLIENTDataGridView
            // 
            this.cLIENTDataGridView.AutoGenerateColumns = false;
            this.cLIENTDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.cLIENTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cLIENTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.PERSON,
            this.AUTO});
            this.cLIENTDataGridView.DataSource = this.cLIENTBindingSource;
            this.cLIENTDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cLIENTDataGridView.Location = new System.Drawing.Point(0, 25);
            this.cLIENTDataGridView.Name = "cLIENTDataGridView";
            this.cLIENTDataGridView.Size = new System.Drawing.Size(957, 475);
            this.cLIENTDataGridView.TabIndex = 1;
            this.cLIENTDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.cLIENTDataGridView_CellEndEdit);
            // 
            // pERSONBindingSource
            // 
            this.pERSONBindingSource.DataMember = "PERSON";
            this.pERSONBindingSource.DataSource = this.autoDataSet;
            // 
            // pERSONTableAdapter
            // 
            this.pERSONTableAdapter.ClearBeforeFill = true;
            // 
            // aUTOBindingSource
            // 
            this.aUTOBindingSource.DataMember = "AUTO";
            this.aUTOBindingSource.DataSource = this.autoDataSet;
            // 
            // aUTOTableAdapter
            // 
            this.aUTOTableAdapter.ClearBeforeFill = true;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CLIENT_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CLIENT_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PERSON_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "PERSON_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AUTO_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "AUTO_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // PERSON
            // 
            this.PERSON.DataPropertyName = "PERSON_ID";
            this.PERSON.DataSource = this.pERSONBindingSource;
            this.PERSON.DisplayMember = "PERSON_FULL";
            this.PERSON.HeaderText = "Клиент";
            this.PERSON.Name = "PERSON";
            this.PERSON.ValueMember = "PERSON_ID";
            this.PERSON.Width = 400;
            // 
            // AUTO
            // 
            this.AUTO.DataPropertyName = "AUTO_ID";
            this.AUTO.DataSource = this.aUTOBindingSource;
            this.AUTO.DisplayMember = "AUTO_FULL";
            this.AUTO.HeaderText = "Автомобиль";
            this.AUTO.Name = "AUTO";
            this.AUTO.ValueMember = "AUTO_ID";
            this.AUTO.Width = 500;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 500);
            this.Controls.Add(this.cLIENTDataGridView);
            this.Controls.Add(this.cLIENTBindingNavigator);
            this.Name = "Client";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingNavigator)).EndInit();
            this.cLIENTBindingNavigator.ResumeLayout(false);
            this.cLIENTBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private autoDataSet autoDataSet;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private autoDataSetTableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
        private autoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cLIENTBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cLIENTBindingNavigatorSaveItem;
        private autoDataSetTableAdapters.PERSONTableAdapter pERSONTableAdapter;
        private System.Windows.Forms.DataGridView cLIENTDataGridView;
        private System.Windows.Forms.BindingSource pERSONBindingSource;
        private autoDataSetTableAdapters.AUTOTableAdapter aUTOTableAdapter;
        private System.Windows.Forms.BindingSource aUTOBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn PERSON;
        private System.Windows.Forms.DataGridViewComboBoxColumn AUTO;
    }
}