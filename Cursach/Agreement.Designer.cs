namespace Cursach
{
    partial class Agreement
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.AgreementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BankDataSet = new Cursach.BankDataSet();
            this.ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CreditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AgreementTableAdapter = new Cursach.BankDataSetTableAdapters.AgreementTableAdapter();
            this.ClientTableAdapter = new Cursach.BankDataSetTableAdapters.ClientTableAdapter();
            this.EmployeeTableAdapter = new Cursach.BankDataSetTableAdapters.EmployeeTableAdapter();
            this.CreditTableAdapter = new Cursach.BankDataSetTableAdapters.CreditTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AgreementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AgreementBindingSource
            // 
            this.AgreementBindingSource.DataMember = "Agreement";
            this.AgreementBindingSource.DataSource = this.BankDataSet;
            // 
            // BankDataSet
            // 
            this.BankDataSet.DataSetName = "BankDataSet";
            this.BankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ClientBindingSource
            // 
            this.ClientBindingSource.DataMember = "Client";
            this.ClientBindingSource.DataSource = this.BankDataSet;
            // 
            // EmployeeBindingSource
            // 
            this.EmployeeBindingSource.DataMember = "Employee";
            this.EmployeeBindingSource.DataSource = this.BankDataSet;
            // 
            // CreditBindingSource
            // 
            this.CreditBindingSource.DataMember = "Credit";
            this.CreditBindingSource.DataSource = this.BankDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AgreementBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ClientBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.EmployeeBindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.CreditBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cursach.CreditAgreement.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(695, 585);
            this.reportViewer1.TabIndex = 0;
            // 
            // AgreementTableAdapter
            // 
            this.AgreementTableAdapter.ClearBeforeFill = true;
            // 
            // ClientTableAdapter
            // 
            this.ClientTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeTableAdapter
            // 
            this.EmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // CreditTableAdapter
            // 
            this.CreditTableAdapter.ClearBeforeFill = true;
            // 
            // Agreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 585);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Agreement";
            this.Text = "Agreement";
            this.Load += new System.EventHandler(this.Agreement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AgreementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BankDataSet BankDataSet;
        private System.Windows.Forms.BindingSource AgreementBindingSource;
        private BankDataSetTableAdapters.AgreementTableAdapter AgreementTableAdapter;
        private System.Windows.Forms.BindingSource ClientBindingSource;
        private System.Windows.Forms.BindingSource EmployeeBindingSource;
        private System.Windows.Forms.BindingSource CreditBindingSource;
        private BankDataSetTableAdapters.ClientTableAdapter ClientTableAdapter;
        private BankDataSetTableAdapters.EmployeeTableAdapter EmployeeTableAdapter;
        private BankDataSetTableAdapters.CreditTableAdapter CreditTableAdapter;
    }
}