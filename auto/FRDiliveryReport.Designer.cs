﻿namespace auto
{
    partial class FRDiliveryReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRDiliveryReport));
            this.autoDataSet1 = new auto.autoDataSet();
            this.report1 = new FastReport.Report();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).BeginInit();
            this.SuspendLayout();
            // 
            // autoDataSet1
            // 
            this.autoDataSet1.DataSetName = "autoDataSet";
            this.autoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // report1
            // 
            this.report1.NeedRefresh = false;
            this.report1.ReportResourceString = resources.GetString("report1.ReportResourceString");
            this.report1.RegisterData(this.autoDataSet1, "autoDataSet1");
            // 
            // FRDiliveryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 636);
            this.Name = "FRDiliveryReport";
            this.Text = "Отчет о поставках";
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private autoDataSet autoDataSet1;
        private FastReport.Report report1;
    }
}