﻿
namespace Software_accounting
{
    partial class ReportBySoftware
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SoftareAccountingDataSet = new Software_accounting.SoftareAccountingDataSet();
            this.SoftwareAndComputerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SoftwareAndComputerTableAdapter = new Software_accounting.SoftareAccountingDataSetTableAdapters.SoftwareAndComputerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SoftareAccountingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoftwareAndComputerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.SoftwareAndComputerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Software_accounting.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // SoftareAccountingDataSet
            // 
            this.SoftareAccountingDataSet.DataSetName = "SoftareAccountingDataSet";
            this.SoftareAccountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SoftwareAndComputerBindingSource
            // 
            this.SoftwareAndComputerBindingSource.DataMember = "SoftwareAndComputer";
            this.SoftwareAndComputerBindingSource.DataSource = this.SoftareAccountingDataSet;
            // 
            // SoftwareAndComputerTableAdapter
            // 
            this.SoftwareAndComputerTableAdapter.ClearBeforeFill = true;
            // 
            // ReportBySoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportBySoftware";
            this.Text = "Отчет по программам";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportBySoftware_FormClosing);
            this.Load += new System.EventHandler(this.ReportBySoftware_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoftareAccountingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoftwareAndComputerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SoftwareAndComputerBindingSource;
        private SoftareAccountingDataSet SoftareAccountingDataSet;
        private SoftareAccountingDataSetTableAdapters.SoftwareAndComputerTableAdapter SoftwareAndComputerTableAdapter;
    }
}