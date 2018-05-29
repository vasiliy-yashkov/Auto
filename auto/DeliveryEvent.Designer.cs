namespace auto
{
    partial class DeliveryEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryEvent));
            this.autoDataSet = new auto.autoDataSet();
            this.dELIVERYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dELIVERYTableAdapter = new auto.autoDataSetTableAdapters.DELIVERYTableAdapter();
            this.tableAdapterManager = new auto.autoDataSetTableAdapters.TableAdapterManager();
            this.aUTOTableAdapter = new auto.autoDataSetTableAdapters.AUTOTableAdapter();
            this.pROVIDERTableAdapter = new auto.autoDataSetTableAdapters.PROVIDERTableAdapter();
            this.dELIVERYBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dELIVERYBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dELIVERYDataGridView = new DataGridWithFilter.DataGridWithFilter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVIDER = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pROVIDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AUTO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.aUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dELIVERYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dELIVERYBindingNavigator)).BeginInit();
            this.dELIVERYBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dELIVERYDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVIDERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // autoDataSet
            // 
            this.autoDataSet.DataSetName = "autoDataSet";
            this.autoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dELIVERYBindingSource
            // 
            this.dELIVERYBindingSource.DataMember = "DELIVERY";
            this.dELIVERYBindingSource.DataSource = this.autoDataSet;
            // 
            // dELIVERYTableAdapter
            // 
            this.dELIVERYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AUTOTableAdapter = this.aUTOTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTTableAdapter = null;
            this.tableAdapterManager.DELIVERYTableAdapter = this.dELIVERYTableAdapter;
            this.tableAdapterManager.EMPLOYEETableAdapter = null;
            this.tableAdapterManager.ENGINETableAdapter = null;
            this.tableAdapterManager.MARKTableAdapter = null;
            this.tableAdapterManager.MODELTableAdapter = null;
            this.tableAdapterManager.MODIFICATIONTableAdapter = null;
            this.tableAdapterManager.PAYTableAdapter = null;
            this.tableAdapterManager.PERSON_INFOTableAdapter = null;
            this.tableAdapterManager.PERSONTableAdapter = null;
            this.tableAdapterManager.POSTTableAdapter = null;
            this.tableAdapterManager.PROVIDERTableAdapter = this.pROVIDERTableAdapter;
            this.tableAdapterManager.SALETableAdapter = null;
            this.tableAdapterManager.STATUSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = auto.autoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aUTOTableAdapter
            // 
            this.aUTOTableAdapter.ClearBeforeFill = true;
            // 
            // pROVIDERTableAdapter
            // 
            this.pROVIDERTableAdapter.ClearBeforeFill = true;
            // 
            // dELIVERYBindingNavigator
            // 
            this.dELIVERYBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dELIVERYBindingNavigator.BindingSource = this.dELIVERYBindingSource;
            this.dELIVERYBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dELIVERYBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dELIVERYBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dELIVERYBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.dELIVERYBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dELIVERYBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dELIVERYBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dELIVERYBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dELIVERYBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dELIVERYBindingNavigator.Name = "dELIVERYBindingNavigator";
            this.dELIVERYBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dELIVERYBindingNavigator.Size = new System.Drawing.Size(1113, 25);
            this.dELIVERYBindingNavigator.TabIndex = 0;
            this.dELIVERYBindingNavigator.Text = "bindingNavigator1";
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
            // dELIVERYBindingNavigatorSaveItem
            // 
            this.dELIVERYBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dELIVERYBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dELIVERYBindingNavigatorSaveItem.Image")));
            this.dELIVERYBindingNavigatorSaveItem.Name = "dELIVERYBindingNavigatorSaveItem";
            this.dELIVERYBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dELIVERYBindingNavigatorSaveItem.Text = "Save Data";
            this.dELIVERYBindingNavigatorSaveItem.Click += new System.EventHandler(this.dELIVERYBindingNavigatorSaveItem_Click);
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
            // dELIVERYDataGridView
            // 
            this.dELIVERYDataGridView.AutoGenerateColumns = false;
            this.dELIVERYDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dELIVERYDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dELIVERYDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.PROVIDER,
            this.AUTO,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dELIVERYDataGridView.DataSource = this.dELIVERYBindingSource;
            this.dELIVERYDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dELIVERYDataGridView.Location = new System.Drawing.Point(0, 25);
            this.dELIVERYDataGridView.Name = "dELIVERYDataGridView";
            this.dELIVERYDataGridView.Size = new System.Drawing.Size(1113, 489);
            this.dELIVERYDataGridView.TabIndex = 1;
            this.dELIVERYDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dELIVERYDataGridView_CellEndEdit);
            this.dELIVERYDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dELIVERYDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DELIVERY_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PROVIDER_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AUTO_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // PROVIDER
            // 
            this.PROVIDER.DataPropertyName = "PROVIDER_ID";
            this.PROVIDER.DataSource = this.pROVIDERBindingSource;
            this.PROVIDER.DisplayMember = "PROVIDER_NAME";
            this.PROVIDER.Name = "PROVIDER";
            this.PROVIDER.ValueMember = "PROVIDER_ID";
            this.PROVIDER.Width = 250;
            this.PROVIDER.HeaderText = "Поставщик";
            // 
            // pROVIDERBindingSource
            // 
            this.pROVIDERBindingSource.DataMember = "PROVIDER";
            this.pROVIDERBindingSource.DataSource = this.autoDataSet;
            // 
            // AUTO
            // 
            this.AUTO.DataPropertyName = "AUTO_ID";
            this.AUTO.DataSource = this.aUTOBindingSource;
            this.AUTO.DisplayMember = "AUTO_FULL";
            this.AUTO.Name = "AUTO";
            this.AUTO.ValueMember = "AUTO_ID";
            this.AUTO.Width = 500;
            this.AUTO.HeaderText = "Автомобиль";
            // 
            // aUTOBindingSource
            // 
            this.aUTOBindingSource.DataMember = "AUTO";
            this.aUTOBindingSource.DataSource = this.autoDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DELIVERY_DATE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата поставки";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DELIVERY_PRICE";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.HeaderText = "Закупочная цена";
            // 
            // DeliveryEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 514);
            this.Controls.Add(this.dELIVERYDataGridView);
            this.Controls.Add(this.dELIVERYBindingNavigator);
            this.Name = "DeliveryEvent";
            this.Text = "Поставка автомобилей";
            this.Load += new System.EventHandler(this.DeliveryEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dELIVERYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dELIVERYBindingNavigator)).EndInit();
            this.dELIVERYBindingNavigator.ResumeLayout(false);
            this.dELIVERYBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dELIVERYDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVIDERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private autoDataSet autoDataSet;
        private System.Windows.Forms.BindingSource dELIVERYBindingSource;
        private autoDataSetTableAdapters.DELIVERYTableAdapter dELIVERYTableAdapter;
        private autoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dELIVERYBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dELIVERYBindingNavigatorSaveItem;
        private autoDataSetTableAdapters.PROVIDERTableAdapter pROVIDERTableAdapter;
        private System.Windows.Forms.BindingSource pROVIDERBindingSource;
        private autoDataSetTableAdapters.AUTOTableAdapter aUTOTableAdapter;
        private System.Windows.Forms.BindingSource aUTOBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn PROVIDER;
        private System.Windows.Forms.DataGridViewComboBoxColumn AUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridWithFilter.DataGridWithFilter dELIVERYDataGridView;
    }
}