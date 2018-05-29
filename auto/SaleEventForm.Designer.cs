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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAuto = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pERSONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).BeginInit();
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
            this.cmbPerson.Location = new System.Drawing.Point(98, 12);
            this.cmbPerson.Name = "cmbPerson";
            this.cmbPerson.Size = new System.Drawing.Size(661, 21);
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
            this.cmbAuto.FormattingEnabled = true;
            this.cmbAuto.Location = new System.Drawing.Point(98, 39);
            this.cmbAuto.Name = "cmbAuto";
            this.cmbAuto.Size = new System.Drawing.Size(661, 21);
            this.cmbAuto.TabIndex = 3;
            this.cmbAuto.ValueMember = "AUTO_ID";
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
            this.label3.Location = new System.Drawing.Point(12, 69);
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
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(98, 66);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(661, 21);
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
            this.label4.Location = new System.Drawing.Point(12, 96);
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
            this.cmbPay.FormattingEnabled = true;
            this.cmbPay.Location = new System.Drawing.Point(98, 101);
            this.cmbPay.Name = "cmbPay";
            this.cmbPay.Size = new System.Drawing.Size(661, 21);
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
            this.label5.Location = new System.Drawing.Point(12, 135);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(661, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Цена продажи";
            // 
            // tbPrice
            // 
            this.tbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPrice.Location = new System.Drawing.Point(98, 154);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(661, 20);
            this.tbPrice.TabIndex = 11;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApply.Location = new System.Drawing.Point(17, 268);
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
            this.btnOK.Location = new System.Drawing.Point(684, 268);
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
            // SaleEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 303);
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
            this.Controls.Add(this.cmbAuto);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAuto;
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
    }
}