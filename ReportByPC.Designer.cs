
namespace Software_accounting
{
    partial class ReportByPC
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SoftwareAndComputerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SoftareAccountingDataSet = new Software_accounting.SoftareAccountingDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SoftwareAndComputerTableAdapter = new Software_accounting.SoftareAccountingDataSetTableAdapters.SoftwareAndComputerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SoftwareAndComputerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoftareAccountingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SoftwareAndComputerBindingSource
            // 
            this.SoftwareAndComputerBindingSource.DataMember = "SoftwareAndComputer";
            this.SoftwareAndComputerBindingSource.DataSource = this.SoftareAccountingDataSet;
            // 
            // SoftareAccountingDataSet
            // 
            this.SoftareAccountingDataSet.DataSetName = "SoftareAccountingDataSet";
            this.SoftareAccountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SoftwareAndComputerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Software_accounting.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // SoftwareAndComputerTableAdapter
            // 
            this.SoftwareAndComputerTableAdapter.ClearBeforeFill = true;
            // 
            // ReportByPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportByPC";
            this.Text = "Отчет по компьютерам";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportByPC_FormClosing);
            this.Load += new System.EventHandler(this.ReportByPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoftwareAndComputerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoftareAccountingDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SoftwareAndComputerBindingSource;
        private SoftareAccountingDataSet SoftareAccountingDataSet;
        private SoftareAccountingDataSetTableAdapters.SoftwareAndComputerTableAdapter SoftwareAndComputerTableAdapter;
    }
}