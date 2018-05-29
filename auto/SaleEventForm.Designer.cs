namespace auto
{
    partial class SaleEventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleEventForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPerson = new System.Windows.Forms.ComboBox();
            this.pERSONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoDataSet = new auto.autoDataSet();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTTableAdapter = new auto.autoDataSetTableAdapters.CLIENTTableAdapter();
            this.pERSONTableAdapter = new auto.autoDataSetTableAdapters.PERSONTableAdapter();
            this.aUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aUTOTableAdapter = new auto.autoDataSetTableAdapters.AUTOTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEETableAdapter = new auto.autoDataSetTableAdapters.EMPLOYEETableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPay = new System.Windows.Forms.ComboBox();
            this.pAYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAYTableAdapter = new auto.autoDataSetTableAdapters.PAYTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.report1 = new FastReport.Report();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCatalogPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbMark = new System.Windows.Forms.ComboBox();
            this.mARKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.mODELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbEngine = new System.Windows.Forms.ComboBox();
            this.eNGINEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMod = new System.Windows.Forms.ComboBox();
            this.mODIFICATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mARKTableAdapter = new auto.autoDataSetTableAdapters.MARKTableAdapter();
            this.mODELTableAdapter = new auto.autoDataSetTableAdapters.MODELTableAdapter();
            this.eNGINETableAdapter = new auto.autoDataSetTableAdapters.ENGINETableAdapter();
            this.mODIFICATIONTableAdapter = new auto.autoDataSetTableAdapters.MODIFICATIONTableAdapter();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mODELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNGINEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mODIFICATIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клиент";
            // 
            // cmbPerson
            // 
            this.cmbPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPerson.DataSource = this.pERSONBindingSource;
            this.cmbPerson.DisplayMember = "PERSON_FULL";
            this.cmbPerson.FormattingEnabled = true;
            this.cmbPerson.Location = new System.Drawing.Point(109, 12);
            this.cmbPerson.Name = "cmbPerson";
            this.cmbPerson.Size = new System.Drawing.Size(650, 21);
            this.cmbPerson.TabIndex = 1;
            this.cmbPerson.ValueMember = "PERSON_ID";
            // 
            // pERSONBindingSource
            // 
            this.pERSONBindingSource.DataMember = "PERSON";
            this.pERSONBindingSource.DataSource = this.autoDataSet;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сотрудник";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEmployee.DataSource = this.eMPLOYEEBindingSource;
            this.cmbEmployee.DisplayMember = "EMPLOYEE_FULL";
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(109, 247);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(650, 21);
            this.cmbEmployee.TabIndex = 5;
            this.cmbEmployee.ValueMember = "EMPLOYEE_ID";
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.autoDataSet;
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Способ\r\nоплаты";
            // 
            // cmbPay
            // 
            this.cmbPay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPay.DataSource = this.pAYBindingSource;
            this.cmbPay.DisplayMember = "PAY_NAME";
            this.cmbPay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPay.FormattingEnabled = true;
            this.cmbPay.Location = new System.Drawing.Point(109, 282);
            this.cmbPay.Name = "cmbPay";
            this.cmbPay.Size = new System.Drawing.Size(650, 21);
            this.cmbPay.TabIndex = 7;
            this.cmbPay.ValueMember = "PAY_ID";
            // 
            // pAYBindingSource
            // 
            this.pAYBindingSource.DataMember = "PAY";
            this.pAYBindingSource.DataSource = this.autoDataSet;
            // 
            // pAYTableAdapter
            // 
            this.pAYTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дата продажи";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 309);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(650, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Цена продажи";
            // 
            // tbPrice
            // 
            this.tbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPrice.Location = new System.Drawing.Point(109, 361);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(650, 20);
            this.tbPrice.TabIndex = 11;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApply.Location = new System.Drawing.Point(17, 399);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 12;
            this.btnApply.Text = "Оформить";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(684, 399);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "Закрыть";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // report1
            // 
            this.report1.NeedRefresh = false;
            this.report1.ReportResourceString = resources.GetString("report1.ReportResourceString");
            this.report1.RegisterData(this.autoDataSet, "autoDataSet");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Цена в каталоге";
            // 
            // txtCatalogPrice
            // 
            this.txtCatalogPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCatalogPrice.Location = new System.Drawing.Point(109, 335);
            this.txtCatalogPrice.Name = "txtCatalogPrice";
            this.txtCatalogPrice.ReadOnly = true;
            this.txtCatalogPrice.Size = new System.Drawing.Size(650, 20);
            this.txtCatalogPrice.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Марка";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Модель";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Двигатель";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Комплектация";
            // 
            // cmbMark
            // 
            this.cmbMark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMark.DataSource = this.mARKBindingSource;
            this.cmbMark.DisplayMember = "MARK_NAME";
            this.cmbMark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMark.FormattingEnabled = true;
            this.cmbMark.Location = new System.Drawing.Point(109, 39);
            this.cmbMark.Name = "cmbMark";
            this.cmbMark.Size = new System.Drawing.Size(650, 21);
            this.cmbMark.TabIndex = 20;
            this.cmbMark.ValueMember = "MARK_ID";
            this.cmbMark.SelectedIndexChanged += new System.EventHandler(this.cmbMark_SelectedIndexChanged);
            this.cmbMark.SelectedValueChanged += new System.EventHandler(this.cmbMark_SelectedValueChanged);
            // 
            // mARKBindingSource
            // 
            this.mARKBindingSource.DataMember = "MARK";
            this.mARKBindingSource.DataSource = this.autoDataSet;
            // 
            // cmbModel
            // 
            this.cmbModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbModel.DataSource = this.mODELBindingSource;
            this.cmbModel.DisplayMember = "MODEL_NAME";
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(109, 66);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(650, 21);
            this.cmbModel.TabIndex = 21;
            this.cmbModel.ValueMember = "MODEL_ID";
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
            this.cmbModel.SelectedValueChanged += new System.EventHandler(this.cmbModel_SelectedValueChanged);
            // 
            // mODELBindingSource
            // 
            this.mODELBindingSource.DataMember = "MODEL";
            this.mODELBindingSource.DataSource = this.autoDataSet;
            // 
            // cmbEngine
            // 
            this.cmbEngine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEngine.DataSource = this.eNGINEBindingSource;
            this.cmbEngine.DisplayMember = "ENGINE_FULL";
            this.cmbEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEngine.FormattingEnabled = true;
            this.cmbEngine.Location = new System.Drawing.Point(109, 93);
            this.cmbEngine.Name = "cmbEngine";
            this.cmbEngine.Size = new System.Drawing.Size(650, 21);
            this.cmbEngine.TabIndex = 22;
            this.cmbEngine.ValueMember = "ENGINE_ID";
            // 
            // eNGINEBindingSource
            // 
            this.eNGINEBindingSource.DataMember = "ENGINE";
            this.eNGINEBindingSource.DataSource = this.autoDataSet;
            // 
            // cmbMod
            // 
            this.cmbMod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMod.DataSource = this.mODIFICATIONBindingSource;
            this.cmbMod.DisplayMember = "FULL";
            this.cmbMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMod.FormattingEnabled = true;
            this.cmbMod.Location = new System.Drawing.Point(109, 120);
            this.cmbMod.Name = "cmbMod";
            this.cmbMod.Size = new System.Drawing.Size(650, 21);
            this.cmbMod.TabIndex = 23;
            this.cmbMod.ValueMember = "MODIFICATION_ID";
            // 
            // mODIFICATIONBindingSource
            // 
            this.mODIFICATIONBindingSource.DataMember = "MODIFICATION";
            this.mODIFICATIONBindingSource.DataSource = this.autoDataSet;
            // 
            // mARKTableAdapter
            // 
            this.mARKTableAdapter.ClearBeforeFill = true;
            // 
            // mODELTableAdapter
            // 
            this.mODELTableAdapter.ClearBeforeFill = true;
            // 
            // eNGINETableAdapter
            // 
            this.eNGINETableAdapter.ClearBeforeFill = true;
            // 
            // mODIFICATIONTableAdapter
            // 
            this.mODIFICATIONTableAdapter.ClearBeforeFill = true;
            // 
            // txtInfo
            // 
            this.txtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfo.Location = new System.Drawing.Point(109, 147);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(650, 68);
            this.txtInfo.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Информация";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Статус";
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.Location = new System.Drawing.Point(109, 221);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(650, 20);
            this.txtStatus.TabIndex = 27;
            // 
            // SaleEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 434);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.cmbMod);
            this.Controls.Add(this.cmbEngine);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.cmbMark);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCatalogPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbPay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPerson);
            this.Controls.Add(this.label1);
            this.Name = "SaleEventForm";
            this.Text = "Оформление продажи автомобиля";
            this.Load += new System.EventHandler(this.SaleEventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pERSONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mODELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNGINEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mODIFICATIONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPerson;
        private autoDataSet autoDataSet;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private autoDataSetTableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
        private System.Windows.Forms.BindingSource pERSONBindingSource;
        private autoDataSetTableAdapters.PERSONTableAdapter pERSONTableAdapter;
        private System.Windows.Forms.BindingSource aUTOBindingSource;
        private autoDataSetTableAdapters.AUTOTableAdapter aUTOTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private autoDataSetTableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPay;
        private System.Windows.Forms.BindingSource pAYBindingSource;
        private autoDataSetTableAdapters.PAYTableAdapter pAYTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnOK;
        private FastReport.Report report1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCatalogPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbMark;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbEngine;
        private System.Windows.Forms.ComboBox cmbMod;
        private System.Windows.Forms.BindingSource mARKBindingSource;
        private autoDataSetTableAdapters.MARKTableAdapter mARKTableAdapter;
        private System.Windows.Forms.BindingSource mODELBindingSource;
        private autoDataSetTableAdapters.MODELTableAdapter mODELTableAdapter;
        private System.Windows.Forms.BindingSource eNGINEBindingSource;
        private autoDataSetTableAdapters.ENGINETableAdapter eNGINETableAdapter;
        private System.Windows.Forms.BindingSource mODIFICATIONBindingSource;
        private autoDataSetTableAdapters.MODIFICATIONTableAdapter mODIFICATIONTableAdapter;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStatus;
    }
}