namespace Cursach
{
    partial class EmployeeAgree
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idagreementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDateFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDateToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSummDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPenyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcreditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agreementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet = new Cursach.BankDataSet();
            this.agreementTableAdapter = new Cursach.BankDataSetTableAdapters.AgreementTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.idagreementDataGridViewTextBoxColumn,
            this.aDateFromDataGridViewTextBoxColumn,
            this.aDateToDataGridViewTextBoxColumn,
            this.aTypeDataGridViewTextBoxColumn,
            this.aSummDataGridViewTextBoxColumn,
            this.aPenyaDataGridViewTextBoxColumn,
            this.idclientDataGridViewTextBoxColumn,
            this.idemployeeDataGridViewTextBoxColumn,
            this.idcreditDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.agreementBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 286);
            this.dataGridView1.TabIndex = 10;
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
            // aDateFromDataGridViewTextBoxColumn
            // 
            this.aDateFromDataGridViewTextBoxColumn.DataPropertyName = "ADateFrom";
            this.aDateFromDataGridViewTextBoxColumn.HeaderText = "ADateFrom";
            this.aDateFromDataGridViewTextBoxColumn.Name = "aDateFromDataGridViewTextBoxColumn";
            this.aDateFromDataGridViewTextBoxColumn.ReadOnly = true;
            this.aDateFromDataGridViewTextBoxColumn.Width = 85;
            // 
            // aDateToDataGridViewTextBoxColumn
            // 
            this.aDateToDataGridViewTextBoxColumn.DataPropertyName = "ADateTo";
            this.aDateToDataGridViewTextBoxColumn.HeaderText = "ADateTo";
            this.aDateToDataGridViewTextBoxColumn.Name = "aDateToDataGridViewTextBoxColumn";
            this.aDateToDataGridViewTextBoxColumn.ReadOnly = true;
            this.aDateToDataGridViewTextBoxColumn.Width = 75;
            // 
            // aTypeDataGridViewTextBoxColumn
            // 
            this.aTypeDataGridViewTextBoxColumn.DataPropertyName = "AType";
            this.aTypeDataGridViewTextBoxColumn.HeaderText = "AType";
            this.aTypeDataGridViewTextBoxColumn.Name = "aTypeDataGridViewTextBoxColumn";
            this.aTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.aTypeDataGridViewTextBoxColumn.Width = 63;
            // 
            // aSummDataGridViewTextBoxColumn
            // 
            this.aSummDataGridViewTextBoxColumn.DataPropertyName = "ASumm";
            this.aSummDataGridViewTextBoxColumn.HeaderText = "ASumm";
            this.aSummDataGridViewTextBoxColumn.Name = "aSummDataGridViewTextBoxColumn";
            this.aSummDataGridViewTextBoxColumn.ReadOnly = true;
            this.aSummDataGridViewTextBoxColumn.Width = 68;
            // 
            // aPenyaDataGridViewTextBoxColumn
            // 
            this.aPenyaDataGridViewTextBoxColumn.DataPropertyName = "APenya";
            this.aPenyaDataGridViewTextBoxColumn.HeaderText = "APenya";
            this.aPenyaDataGridViewTextBoxColumn.Name = "aPenyaDataGridViewTextBoxColumn";
            this.aPenyaDataGridViewTextBoxColumn.ReadOnly = true;
            this.aPenyaDataGridViewTextBoxColumn.Width = 69;
            // 
            // idclientDataGridViewTextBoxColumn
            // 
            this.idclientDataGridViewTextBoxColumn.DataPropertyName = "Id_client";
            this.idclientDataGridViewTextBoxColumn.HeaderText = "Id_client";
            this.idclientDataGridViewTextBoxColumn.Name = "idclientDataGridViewTextBoxColumn";
            this.idclientDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclientDataGridViewTextBoxColumn.Width = 72;
            // 
            // idemployeeDataGridViewTextBoxColumn
            // 
            this.idemployeeDataGridViewTextBoxColumn.DataPropertyName = "Id_employee";
            this.idemployeeDataGridViewTextBoxColumn.HeaderText = "Id_employee";
            this.idemployeeDataGridViewTextBoxColumn.Name = "idemployeeDataGridViewTextBoxColumn";
            this.idemployeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idemployeeDataGridViewTextBoxColumn.Width = 92;
            // 
            // idcreditDataGridViewTextBoxColumn
            // 
            this.idcreditDataGridViewTextBoxColumn.DataPropertyName = "Id_credit";
            this.idcreditDataGridViewTextBoxColumn.HeaderText = "Id_credit";
            this.idcreditDataGridViewTextBoxColumn.Name = "idcreditDataGridViewTextBoxColumn";
            this.idcreditDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcreditDataGridViewTextBoxColumn.Width = 73;
            // 
            // agreementBindingSource
            // 
            this.agreementBindingSource.DataMember = "Agreement";
            this.agreementBindingSource.DataSource = this.bankDataSet;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agreementTableAdapter
            // 
            this.agreementTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.button1.Location = new System.Drawing.Point(385, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Всі договори";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.button2.Location = new System.Drawing.Point(638, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "Мої договори";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(320, 113);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button4.Size = new System.Drawing.Size(37, 32);
            this.button4.TabIndex = 55;
            this.button4.Text = "▼";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox5
            // 
            this.comboBox5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Номер договору",
            "Дата (з)",
            "Дата (по)",
            "Тип",
            "Сума",
            "Пеня",
            "Клієнт",
            "Працівник",
            "Кредит"});
            this.comboBox5.Location = new System.Drawing.Point(67, 84);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(201, 27);
            this.comboBox5.TabIndex = 54;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(67, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 27);
            this.textBox1.TabIndex = 52;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Cursach.Properties.Resources.icons8_поиск_64;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(277, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 32);
            this.button3.TabIndex = 53;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // EmployeeAgree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 476);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmployeeAgree";
            this.Text = "EmployeeAgree";
            this.Load += new System.EventHandler(this.EmployeeAgree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource agreementBindingSource;
        private BankDataSetTableAdapters.AgreementTableAdapter agreementTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idagreementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDateFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDateToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSummDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPenyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcreditDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
    }
}