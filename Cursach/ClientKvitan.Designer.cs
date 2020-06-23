namespace Cursach
{
    partial class ClientKvitan
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
            this.bankDataSet = new Cursach.BankDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idagreementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new Cursach.BankDataSetTableAdapters.PaymentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idagreementDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paymentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(530, 339);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // idagreementDataGridViewTextBoxColumn
            // 
            this.idagreementDataGridViewTextBoxColumn.DataPropertyName = "Id_agreement";
            this.idagreementDataGridViewTextBoxColumn.HeaderText = "Id_agreement";
            this.idagreementDataGridViewTextBoxColumn.Name = "idagreementDataGridViewTextBoxColumn";
            this.idagreementDataGridViewTextBoxColumn.ReadOnly = true;
            this.idagreementDataGridViewTextBoxColumn.Width = 97;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.bankDataSet;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // ClientKvitan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClientKvitan";
            this.Text = "ClientKvitan";
            this.Load += new System.EventHandler(this.ClientKvitan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BankDataSet bankDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private BankDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idagreementDataGridViewTextBoxColumn;
    }
}