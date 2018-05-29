namespace auto
{
    partial class AddAuto
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
            this.cmbMark = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.autoDataSet = new auto.autoDataSet();
            this.mARKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mARKTableAdapter = new auto.autoDataSetTableAdapters.MARKTableAdapter();
            this.mODELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mODELTableAdapter = new auto.autoDataSetTableAdapters.MODELTableAdapter();
            this.cmbMod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mODIFICATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mODIFICATIONTableAdapter = new auto.autoDataSetTableAdapters.MODIFICATIONTableAdapter();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEngine = new System.Windows.Forms.ComboBox();
            this.eNGINEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eNGINETableAdapter = new auto.autoDataSetTableAdapters.ENGINETableAdapter();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.sTATUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTATUSTableAdapter = new auto.autoDataSetTableAdapters.STATUSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mODELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mODIFICATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNGINEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTATUSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Марка:";
            // 
            // cmbMark
            // 
            this.cmbMark.DataSource = this.mARKBindingSource;
            this.cmbMark.DisplayMember = "MARK_NAME";
            this.cmbMark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMark.FormattingEnabled = true;
            this.cmbMark.Location = new System.Drawing.Point(61, 8);
            this.cmbMark.Name = "cmbMark";
            this.cmbMark.Size = new System.Drawing.Size(289, 21);
            this.cmbMark.TabIndex = 1;
            this.cmbMark.ValueMember = "MARK_ID";
            this.cmbMark.SelectedIndexChanged += new System.EventHandler(this.cmbMark_SelectedIndexChanged);
            this.cmbMark.SelectedValueChanged += new System.EventHandler(this.cmbMark_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Модель:";
            // 
            // cmbModel
            // 
            this.cmbModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbModel.DataSource = this.mODELBindingSource;
            this.cmbModel.DisplayMember = "MODEL_NAME";
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(411, 8);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(312, 21);
            this.cmbModel.TabIndex = 3;
            this.cmbModel.ValueMember = "MODEL_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цвет:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(61, 40);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(289, 20);
            this.txtColor.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(648, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(567, 251);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // autoDataSet
            // 
            this.autoDataSet.DataSetName = "autoDataSet";
            this.autoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mARKBindingSource
            // 
            this.mARKBindingSource.DataMember = "MARK";
            this.mARKBindingSource.DataSource = this.autoDataSet;
            // 
            // mARKTableAdapter
            // 
            this.mARKTableAdapter.ClearBeforeFill = true;
            // 
            // mODELBindingSource
            // 
            this.mODELBindingSource.DataMember = "MODEL";
            this.mODELBindingSource.DataSource = this.autoDataSet;
            // 
            // mODELTableAdapter
            // 
            this.mODELTableAdapter.ClearBeforeFill = true;
            // 
            // cmbMod
            // 
            this.cmbMod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMod.DataSource = this.mODIFICATIONBindingSource;
            this.cmbMod.DisplayMember = "FULL";
            this.cmbMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMod.FormattingEnabled = true;
            this.cmbMod.Location = new System.Drawing.Point(99, 91);
            this.cmbMod.Name = "cmbMod";
            this.cmbMod.Size = new System.Drawing.Size(624, 21);
            this.cmbMod.TabIndex = 8;
            this.cmbMod.ValueMember = "MODIFICATION_ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Модификация:";
            // 
            // mODIFICATIONBindingSource
            // 
            this.mODIFICATIONBindingSource.DataMember = "MODIFICATION";
            this.mODIFICATIONBindingSource.DataSource = this.autoDataSet;
            // 
            // mODIFICATIONTableAdapter
            // 
            this.mODIFICATIONTableAdapter.ClearBeforeFill = true;
            // 
            // txtVIN
            // 
            this.txtVIN.Location = new System.Drawing.Point(46, 207);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(304, 20);
            this.txtVIN.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "VIN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Двигатель:";
            // 
            // cmbEngine
            // 
            this.cmbEngine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEngine.DataSource = this.eNGINEBindingSource;
            this.cmbEngine.DisplayMember = "ENGINE_FULL";
            this.cmbEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEngine.FormattingEnabled = true;
            this.cmbEngine.Location = new System.Drawing.Point(99, 129);
            this.cmbEngine.Name = "cmbEngine";
            this.cmbEngine.Size = new System.Drawing.Size(624, 21);
            this.cmbEngine.TabIndex = 13;
            this.cmbEngine.ValueMember = "ENGINE_ID";
            // 
            // eNGINEBindingSource
            // 
            this.eNGINEBindingSource.DataMember = "ENGINE";
            this.eNGINEBindingSource.DataSource = this.autoDataSet;
            // 
            // eNGINETableAdapter
            // 
            this.eNGINETableAdapter.ClearBeforeFill = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.Location = new System.Drawing.Point(411, 207);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(312, 20);
            this.txtPrice.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Цена:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Статус:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStatus.DataSource = this.sTATUSBindingSource;
            this.cmbStatus.DisplayMember = "STATUS_NAME";
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(62, 174);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(661, 21);
            this.cmbStatus.TabIndex = 17;
            this.cmbStatus.ValueMember = "STATUS_ID";
            // 
            // sTATUSBindingSource
            // 
            this.sTATUSBindingSource.DataMember = "STATUS";
            this.sTATUSBindingSource.DataSource = this.autoDataSet;
            // 
            // sTATUSTableAdapter
            // 
            this.sTATUSTableAdapter.ClearBeforeFill = true;
            // 
            // AddAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 286);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbEngine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVIN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMod);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMark);
            this.Controls.Add(this.label1);
            this.Name = "AddAuto";
            this.Text = "Добавить автомобиль";
            this.Load += new System.EventHandler(this.AddAuto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mODELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mODIFICATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNGINEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTATUSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private autoDataSet autoDataSet;
        private System.Windows.Forms.BindingSource mARKBindingSource;
        private autoDataSetTableAdapters.MARKTableAdapter mARKTableAdapter;
        private System.Windows.Forms.BindingSource mODELBindingSource;
        private autoDataSetTableAdapters.MODELTableAdapter mODELTableAdapter;
        private System.Windows.Forms.ComboBox cmbMod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource mODIFICATIONBindingSource;
        private autoDataSetTableAdapters.MODIFICATIONTableAdapter mODIFICATIONTableAdapter;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEngine;
        private System.Windows.Forms.BindingSource eNGINEBindingSource;
        private autoDataSetTableAdapters.ENGINETableAdapter eNGINETableAdapter;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.BindingSource sTATUSBindingSource;
        private autoDataSetTableAdapters.STATUSTableAdapter sTATUSTableAdapter;
    }
}