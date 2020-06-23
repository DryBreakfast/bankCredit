namespace Cursach
{
    partial class EditAddAgreement
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
            System.Windows.Forms.Label aDateFromLabel;
            System.Windows.Forms.Label aDateToLabel;
            System.Windows.Forms.Label aTypeLabel;
            System.Windows.Forms.Label aSummLabel;
            System.Windows.Forms.Label aPenyaLabel;
            System.Windows.Forms.Label id_clientLabel;
            System.Windows.Forms.Label id_employeeLabel;
            System.Windows.Forms.Label id_creditLabel;
            this.bankDataSet = new Cursach.BankDataSet();
            this.agreementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agreementTableAdapter = new Cursach.BankDataSetTableAdapters.AgreementTableAdapter();
            this.tableAdapterManager = new Cursach.BankDataSetTableAdapters.TableAdapterManager();
            this.clientTableAdapter = new Cursach.BankDataSetTableAdapters.ClientTableAdapter();
            this.creditTableAdapter = new Cursach.BankDataSetTableAdapters.CreditTableAdapter();
            this.employeeTableAdapter = new Cursach.BankDataSetTableAdapters.EmployeeTableAdapter();
            this.aDateFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.aDateToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.aSummTextBox = new System.Windows.Forms.TextBox();
            this.aPenyaTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.creditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            aDateFromLabel = new System.Windows.Forms.Label();
            aDateToLabel = new System.Windows.Forms.Label();
            aTypeLabel = new System.Windows.Forms.Label();
            aSummLabel = new System.Windows.Forms.Label();
            aPenyaLabel = new System.Windows.Forms.Label();
            id_clientLabel = new System.Windows.Forms.Label();
            id_employeeLabel = new System.Windows.Forms.Label();
            id_creditLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aDateFromLabel
            // 
            aDateFromLabel.AutoSize = true;
            aDateFromLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            aDateFromLabel.Location = new System.Drawing.Point(93, 44);
            aDateFromLabel.Name = "aDateFromLabel";
            aDateFromLabel.Size = new System.Drawing.Size(76, 23);
            aDateFromLabel.TabIndex = 3;
            aDateFromLabel.Text = "Дата (з):";
            // 
            // aDateToLabel
            // 
            aDateToLabel.AutoSize = true;
            aDateToLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            aDateToLabel.Location = new System.Drawing.Point(81, 80);
            aDateToLabel.Name = "aDateToLabel";
            aDateToLabel.Size = new System.Drawing.Size(88, 23);
            aDateToLabel.TabIndex = 5;
            aDateToLabel.Text = "Дата (по):";
            // 
            // aTypeLabel
            // 
            aTypeLabel.AutoSize = true;
            aTypeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            aTypeLabel.Location = new System.Drawing.Point(46, 113);
            aTypeLabel.Name = "aTypeLabel";
            aTypeLabel.Size = new System.Drawing.Size(123, 23);
            aTypeLabel.TabIndex = 7;
            aTypeLabel.Text = "Тип договору:";
            // 
            // aSummLabel
            // 
            aSummLabel.AutoSize = true;
            aSummLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            aSummLabel.Location = new System.Drawing.Point(31, 149);
            aSummLabel.Name = "aSummLabel";
            aSummLabel.Size = new System.Drawing.Size(138, 23);
            aSummLabel.TabIndex = 9;
            aSummLabel.Text = "Сумма кредиту:";
            // 
            // aPenyaLabel
            // 
            aPenyaLabel.AutoSize = true;
            aPenyaLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            aPenyaLabel.Location = new System.Drawing.Point(114, 185);
            aPenyaLabel.Name = "aPenyaLabel";
            aPenyaLabel.Size = new System.Drawing.Size(55, 23);
            aPenyaLabel.TabIndex = 11;
            aPenyaLabel.Text = "Пеня:";
            // 
            // id_clientLabel
            // 
            id_clientLabel.AutoSize = true;
            id_clientLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_clientLabel.Location = new System.Drawing.Point(105, 222);
            id_clientLabel.Name = "id_clientLabel";
            id_clientLabel.Size = new System.Drawing.Size(64, 23);
            id_clientLabel.TabIndex = 13;
            id_clientLabel.Text = "Клієнт:";
            // 
            // id_employeeLabel
            // 
            id_employeeLabel.AutoSize = true;
            id_employeeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_employeeLabel.Location = new System.Drawing.Point(71, 258);
            id_employeeLabel.Name = "id_employeeLabel";
            id_employeeLabel.Size = new System.Drawing.Size(98, 23);
            id_employeeLabel.TabIndex = 15;
            id_employeeLabel.Text = "Працівник:";
            // 
            // id_creditLabel
            // 
            id_creditLabel.AutoSize = true;
            id_creditLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_creditLabel.Location = new System.Drawing.Point(97, 294);
            id_creditLabel.Name = "id_creditLabel";
            id_creditLabel.Size = new System.Drawing.Size(72, 23);
            id_creditLabel.TabIndex = 17;
            id_creditLabel.Text = "Кредит:";
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agreementBindingSource
            // 
            this.agreementBindingSource.DataMember = "Agreement";
            this.agreementBindingSource.DataSource = this.bankDataSet;
            // 
            // agreementTableAdapter
            // 
            this.agreementTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgreementTableAdapter = this.agreementTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.CreditTableAdapter = this.creditTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.InsuranceTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cursach.BankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // creditTableAdapter
            // 
            this.creditTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // aDateFromDateTimePicker
            // 
            this.aDateFromDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.agreementBindingSource, "ADateFrom", true));
            this.aDateFromDateTimePicker.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aDateFromDateTimePicker.Location = new System.Drawing.Point(175, 38);
            this.aDateFromDateTimePicker.Name = "aDateFromDateTimePicker";
            this.aDateFromDateTimePicker.Size = new System.Drawing.Size(266, 31);
            this.aDateFromDateTimePicker.TabIndex = 4;
            // 
            // aDateToDateTimePicker
            // 
            this.aDateToDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.agreementBindingSource, "ADateTo", true));
            this.aDateToDateTimePicker.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aDateToDateTimePicker.Location = new System.Drawing.Point(175, 74);
            this.aDateToDateTimePicker.Name = "aDateToDateTimePicker";
            this.aDateToDateTimePicker.Size = new System.Drawing.Size(266, 31);
            this.aDateToDateTimePicker.TabIndex = 6;
            // 
            // aSummTextBox
            // 
            this.aSummTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agreementBindingSource, "ASumm", true));
            this.aSummTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aSummTextBox.Location = new System.Drawing.Point(175, 146);
            this.aSummTextBox.Name = "aSummTextBox";
            this.aSummTextBox.Size = new System.Drawing.Size(266, 31);
            this.aSummTextBox.TabIndex = 10;
            // 
            // aPenyaTextBox
            // 
            this.aPenyaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agreementBindingSource, "APenya", true));
            this.aPenyaTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aPenyaTextBox.Location = new System.Drawing.Point(175, 182);
            this.aPenyaTextBox.Name = "aPenyaTextBox";
            this.aPenyaTextBox.Size = new System.Drawing.Size(266, 31);
            this.aPenyaTextBox.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Готівкою",
            "На кредитну карту"});
            this.comboBox1.Location = new System.Drawing.Point(175, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(266, 31);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.Text = "Готівкою";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.clientBindingSource;
            this.comboBox2.DisplayMember = "Id_client";
            this.comboBox2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(175, 219);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(266, 31);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.ValueMember = "Id_client";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.bankDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.employeeBindingSource;
            this.comboBox3.DisplayMember = "Id_employee";
            this.comboBox3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(175, 255);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(266, 31);
            this.comboBox3.TabIndex = 21;
            this.comboBox3.ValueMember = "Id_employee";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.bankDataSet;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.creditBindingSource;
            this.comboBox4.DisplayMember = "Id_credit";
            this.comboBox4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(175, 291);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(266, 31);
            this.comboBox4.TabIndex = 22;
            this.comboBox4.ValueMember = "Id_credit";
            // 
            // creditBindingSource
            // 
            this.creditBindingSource.DataMember = "Credit";
            this.creditBindingSource.DataSource = this.bankDataSet;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(281, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 44);
            this.button2.TabIndex = 34;
            this.button2.Text = "Відмінити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(110, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 44);
            this.button1.TabIndex = 33;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditAddAgreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(aDateFromLabel);
            this.Controls.Add(this.aDateFromDateTimePicker);
            this.Controls.Add(aDateToLabel);
            this.Controls.Add(this.aDateToDateTimePicker);
            this.Controls.Add(aTypeLabel);
            this.Controls.Add(aSummLabel);
            this.Controls.Add(this.aSummTextBox);
            this.Controls.Add(aPenyaLabel);
            this.Controls.Add(this.aPenyaTextBox);
            this.Controls.Add(id_clientLabel);
            this.Controls.Add(id_employeeLabel);
            this.Controls.Add(id_creditLabel);
            this.Name = "EditAddAgreement";
            this.Text = "EditAddAgreement";
            this.Load += new System.EventHandler(this.EditAddAgreement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource agreementBindingSource;
        private BankDataSetTableAdapters.AgreementTableAdapter agreementTableAdapter;
        private BankDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker aDateFromDateTimePicker;
        private System.Windows.Forms.DateTimePicker aDateToDateTimePicker;
        private System.Windows.Forms.TextBox aSummTextBox;
        private System.Windows.Forms.TextBox aPenyaTextBox;
        private BankDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private BankDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private BankDataSetTableAdapters.CreditTableAdapter creditTableAdapter;
        private System.Windows.Forms.BindingSource creditBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}