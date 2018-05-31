namespace auto
{
    partial class AddDelivery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProvider = new System.Windows.Forms.ComboBox();
            this.pROVIDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoDataSet = new auto.autoDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAuto = new System.Windows.Forms.ComboBox();
            this.aUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbCancel = new System.Windows.Forms.Button();
            this.cmbOk = new System.Windows.Forms.Button();
            this.pROVIDERTableAdapter = new auto.autoDataSetTableAdapters.PROVIDERTableAdapter();
            this.aUTOTableAdapter = new auto.autoDataSetTableAdapters.AUTOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pROVIDERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поставщик";
            // 
            // cmbProvider
            // 
            this.cmbProvider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProvider.DataSource = this.pROVIDERBindingSource;
            this.cmbProvider.DisplayMember = "PROVIDER_NAME";
            this.cmbProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvider.FormattingEnabled = true;
            this.cmbProvider.Location = new System.Drawing.Point(87, 12);
            this.cmbProvider.Name = "cmbProvider";
            this.cmbProvider.Size = new System.Drawing.Size(507, 21);
            this.cmbProvider.TabIndex = 1;
            this.cmbProvider.ValueMember = "PROVIDER_ID";
            this.cmbProvider.SelectedIndexChanged += new System.EventHandler(this.cmbProvider_SelectedIndexChanged);
            this.cmbProvider.SelectedValueChanged += new System.EventHandler(this.cmbProvider_SelectedValueChanged);
            // 
            // pROVIDERBindingSource
            // 
            this.pROVIDERBindingSource.DataMember = "PROVIDER";
            this.pROVIDERBindingSource.DataSource = this.autoDataSet;
            // 
            // autoDataSet
            // 
            this.autoDataSet.DataSetName = "autoDataSet";
            this.autoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Автомобиль";
            // 
            // cmbAuto
            // 
            this.cmbAuto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAuto.DataSource = this.aUTOBindingSource;
            this.cmbAuto.DisplayMember = "AUTO_FULL";
            this.cmbAuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAuto.FormattingEnabled = true;
            this.cmbAuto.Location = new System.Drawing.Point(87, 39);
            this.cmbAuto.Name = "cmbAuto";
            this.cmbAuto.Size = new System.Drawing.Size(507, 21);
            this.cmbAuto.TabIndex = 3;
            this.cmbAuto.ValueMember = "AUTO_ID";
            // 
            // aUTOBindingSource
            // 
            this.aUTOBindingSource.DataMember = "AUTO";
            this.aUTOBindingSource.DataSource = this.autoDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цена";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(87, 72);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(212, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дата поставки";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(394, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // cmbCancel
            // 
            this.cmbCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmbCancel.Location = new System.Drawing.Point(519, 102);
            this.cmbCancel.Name = "cmbCancel";
            this.cmbCancel.Size = new System.Drawing.Size(75, 23);
            this.cmbCancel.TabIndex = 10;
            this.cmbCancel.Text = "Отмена";
            this.cmbCancel.UseVisualStyleBackColor = true;
            this.cmbCancel.Click += new System.EventHandler(this.cmbCancel_Click);
            // 
            // cmbOk
            // 
            this.cmbOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmbOk.Location = new System.Drawing.Point(438, 102);
            this.cmbOk.Name = "cmbOk";
            this.cmbOk.Size = new System.Drawing.Size(75, 23);
            this.cmbOk.TabIndex = 11;
            this.cmbOk.Text = "ОК";
            this.cmbOk.UseVisualStyleBackColor = true;
            this.cmbOk.Click += new System.EventHandler(this.cmbOk_Click);
            // 
            // pROVIDERTableAdapter
            // 
            this.pROVIDERTableAdapter.ClearBeforeFill = true;
            // 
            // aUTOTableAdapter
            // 
            this.aUTOTableAdapter.ClearBeforeFill = true;
            // 
            // AddDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 137);
            this.Controls.Add(this.cmbOk);
            this.Controls.Add(this.cmbCancel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbAuto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProvider);
            this.Controls.Add(this.label1);
            this.Name = "AddDelivery";
            this.Text = "Поставка автомобиля";
            this.Load += new System.EventHandler(this.AddDelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pROVIDERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAuto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button cmbCancel;
        private System.Windows.Forms.Button cmbOk;
        private autoDataSet autoDataSet;
        private System.Windows.Forms.BindingSource pROVIDERBindingSource;
        private autoDataSetTableAdapters.PROVIDERTableAdapter pROVIDERTableAdapter;
        private System.Windows.Forms.BindingSource aUTOBindingSource;
        private autoDataSetTableAdapters.AUTOTableAdapter aUTOTableAdapter;
    }
}