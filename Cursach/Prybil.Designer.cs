namespace Cursach
{
    partial class Prybil
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
            this.AgreementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BankDataSet = new Cursach.BankDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AgreementTableAdapter = new Cursach.BankDataSetTableAdapters.AgreementTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AgreementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankDataSet)).BeginInit();
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cursach.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(722, 451);
            this.reportViewer1.TabIndex = 0;
            // 
            // AgreementTableAdapter
            // 
            this.AgreementTableAdapter.ClearBeforeFill = true;
            // 
            // Prybil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 451);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Prybil";
            this.Text = "Credit";
            this.Load += new System.EventHandler(this.Credit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AgreementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AgreementBindingSource;
        private BankDataSet BankDataSet;
        private BankDataSetTableAdapters.AgreementTableAdapter AgreementTableAdapter;
    }
}