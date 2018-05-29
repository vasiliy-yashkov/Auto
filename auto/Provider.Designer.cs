namespace auto
{
    partial class Provider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Provider));
            this.autoDataSet = new auto.autoDataSet();
            this.pROVIDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROVIDERTableAdapter = new auto.autoDataSetTableAdapters.PROVIDERTableAdapter();
            this.tableAdapterManager = new auto.autoDataSetTableAdapters.TableAdapterManager();
            this.pROVIDERBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pROVIDERBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pROVIDERDataGridView = new DataGridWithFilter.DataGridWithFilter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVIDERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVIDERBindingNavigator)).BeginInit();
            this.pROVIDERBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROVIDERDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // autoDataSet
            // 
            this.autoDataSet.DataSetName = "autoDataSet";
            this.autoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROVIDERBindingSource
            // 
            this.pROVIDERBindingSource.DataMember = "PROVIDER";
            this.pROVIDERBindingSource.DataSource = this.autoDataSet;
            // 
            // pROVIDERTableAdapter
            // 
            this.pROVIDERTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AUTOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTTableAdapter = null;
            this.tableAdapterManager.DELIVERYTableAdapter = null;
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
            // pROVIDERBindingNavigator
            // 
            this.pROVIDERBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pROVIDERBindingNavigator.BindingSource = this.pROVIDERBindingSource;
            this.pROVIDERBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pROVIDERBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pROVIDERBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pROVIDERBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.pROVIDERBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pROVIDERBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pROVIDERBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pROVIDERBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pROVIDERBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pROVIDERBindingNavigator.Name = "pROVIDERBindingNavigator";
            this.pROVIDERBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pROVIDERBindingNavigator.Size = new System.Drawing.Size(833, 25);
            this.pROVIDERBindingNavigator.TabIndex = 0;
            this.pROVIDERBindingNavigator.Text = "bindingNavigator1";
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
            // pROVIDERBindingNavigatorSaveItem
            // 
            this.pROVIDERBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pROVIDERBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pROVIDERBindingNavigatorSaveItem.Image")));
            this.pROVIDERBindingNavigatorSaveItem.Name = "pROVIDERBindingNavigatorSaveItem";
            this.pROVIDERBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pROVIDERBindingNavigatorSaveItem.Text = "Save Data";
            this.pROVIDERBindingNavigatorSaveItem.Click += new System.EventHandler(this.pROVIDERBindingNavigatorSaveItem_Click);
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
            // pROVIDERDataGridView
            // 
            this.pROVIDERDataGridView.AutoGenerateColumns = false;
            this.pROVIDERDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.pROVIDERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pROVIDERDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.pROVIDERDataGridView.DataSource = this.pROVIDERBindingSource;
            this.pROVIDERDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pROVIDERDataGridView.Location = new System.Drawing.Point(0, 25);
            this.pROVIDERDataGridView.Name = "pROVIDERDataGridView";
            this.pROVIDERDataGridView.Size = new System.Drawing.Size(833, 506);
            this.pROVIDERDataGridView.TabIndex = 1;
            this.pROVIDERDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.pROVIDERDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PROVIDER_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PROVIDER_NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            this.dataGridViewTextBoxColumn2.HeaderText = "Поставщик";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PROVIDER_INFO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.HeaderText = "Информация";
            this.dataGridViewTextBoxColumn3.Width = 400;
            // 
            // Provider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 531);
            this.Controls.Add(this.pROVIDERDataGridView);
            this.Controls.Add(this.pROVIDERBindingNavigator);
            this.Name = "Provider";
            this.Text = " Поставщики";
            this.Load += new System.EventHandler(this.Provider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVIDERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVIDERBindingNavigator)).EndInit();
            this.pROVIDERBindingNavigator.ResumeLayout(false);
            this.pROVIDERBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROVIDERDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private autoDataSet autoDataSet;
        private System.Windows.Forms.BindingSource pROVIDERBindingSource;
        private autoDataSetTableAdapters.PROVIDERTableAdapter pROVIDERTableAdapter;
        private autoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pROVIDERBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pROVIDERBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DataGridWithFilter.DataGridWithFilter pROVIDERDataGridView;
    }
}