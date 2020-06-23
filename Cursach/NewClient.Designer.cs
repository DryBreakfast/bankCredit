namespace Cursach
{
    partial class NewClient
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
            System.Windows.Forms.Label cId_passportLabel;
            System.Windows.Forms.Label cLastNameLabel;
            System.Windows.Forms.Label cNameLabel;
            System.Windows.Forms.Label cPatronymicLabel;
            System.Windows.Forms.Label cAdressLabel;
            System.Windows.Forms.Label cPhoneLabel;
            System.Windows.Forms.Label cWorkLabel;
            System.Windows.Forms.Label cSalaryLabel;
            this.bankDataSet = new Cursach.BankDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Cursach.BankDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new Cursach.BankDataSetTableAdapters.TableAdapterManager();
            this.cId_passportTextBox = new System.Windows.Forms.TextBox();
            this.cLastNameTextBox = new System.Windows.Forms.TextBox();
            this.cNameTextBox = new System.Windows.Forms.TextBox();
            this.cPatronymicTextBox = new System.Windows.Forms.TextBox();
            this.cAdressTextBox = new System.Windows.Forms.TextBox();
            this.cPhoneTextBox = new System.Windows.Forms.TextBox();
            this.cWorkTextBox = new System.Windows.Forms.TextBox();
            this.cSalaryTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            cId_passportLabel = new System.Windows.Forms.Label();
            cLastNameLabel = new System.Windows.Forms.Label();
            cNameLabel = new System.Windows.Forms.Label();
            cPatronymicLabel = new System.Windows.Forms.Label();
            cAdressLabel = new System.Windows.Forms.Label();
            cPhoneLabel = new System.Windows.Forms.Label();
            cWorkLabel = new System.Windows.Forms.Label();
            cSalaryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cId_passportLabel
            // 
            cId_passportLabel.AutoSize = true;
            cId_passportLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cId_passportLabel.Location = new System.Drawing.Point(75, 42);
            cId_passportLabel.Name = "cId_passportLabel";
            cId_passportLabel.Size = new System.Drawing.Size(146, 23);
            cId_passportLabel.TabIndex = 3;
            cId_passportLabel.Text = "Номер паспорту:";
            // 
            // cLastNameLabel
            // 
            cLastNameLabel.AutoSize = true;
            cLastNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cLastNameLabel.Location = new System.Drawing.Point(75, 78);
            cLastNameLabel.Name = "cLastNameLabel";
            cLastNameLabel.Size = new System.Drawing.Size(95, 23);
            cLastNameLabel.TabIndex = 5;
            cLastNameLabel.Text = "Прізвище: ";
            // 
            // cNameLabel
            // 
            cNameLabel.AutoSize = true;
            cNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cNameLabel.Location = new System.Drawing.Point(75, 114);
            cNameLabel.Name = "cNameLabel";
            cNameLabel.Size = new System.Drawing.Size(47, 23);
            cNameLabel.TabIndex = 7;
            cNameLabel.Text = "Ім\'я:";
            // 
            // cPatronymicLabel
            // 
            cPatronymicLabel.AutoSize = true;
            cPatronymicLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cPatronymicLabel.Location = new System.Drawing.Point(75, 150);
            cPatronymicLabel.Name = "cPatronymicLabel";
            cPatronymicLabel.Size = new System.Drawing.Size(108, 23);
            cPatronymicLabel.TabIndex = 9;
            cPatronymicLabel.Text = "По батькові:";
            // 
            // cAdressLabel
            // 
            cAdressLabel.AutoSize = true;
            cAdressLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cAdressLabel.Location = new System.Drawing.Point(75, 186);
            cAdressLabel.Name = "cAdressLabel";
            cAdressLabel.Size = new System.Drawing.Size(152, 23);
            cAdressLabel.TabIndex = 11;
            cAdressLabel.Text = "Домашня адреса:";
            // 
            // cPhoneLabel
            // 
            cPhoneLabel.AutoSize = true;
            cPhoneLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cPhoneLabel.Location = new System.Drawing.Point(75, 222);
            cPhoneLabel.Name = "cPhoneLabel";
            cPhoneLabel.Size = new System.Drawing.Size(149, 23);
            cPhoneLabel.TabIndex = 13;
            cPhoneLabel.Text = "Номер телефону:";
            // 
            // cWorkLabel
            // 
            cWorkLabel.AutoSize = true;
            cWorkLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cWorkLabel.Location = new System.Drawing.Point(75, 258);
            cWorkLabel.Name = "cWorkLabel";
            cWorkLabel.Size = new System.Drawing.Size(123, 23);
            cWorkLabel.TabIndex = 15;
            cWorkLabel.Text = "Місце роботи:";
            // 
            // cSalaryLabel
            // 
            cSalaryLabel.AutoSize = true;
            cSalaryLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cSalaryLabel.Location = new System.Drawing.Point(75, 294);
            cSalaryLabel.Name = "cSalaryLabel";
            cSalaryLabel.Size = new System.Drawing.Size(142, 23);
            cSalaryLabel.TabIndex = 17;
            cSalaryLabel.Text = "Заробітна плата:";
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.bankDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgreementTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.CreditTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.InsuranceTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cursach.BankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cId_passportTextBox
            // 
            this.cId_passportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CId_passport", true));
            this.cId_passportTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cId_passportTextBox.Location = new System.Drawing.Point(237, 39);
            this.cId_passportTextBox.Name = "cId_passportTextBox";
            this.cId_passportTextBox.Size = new System.Drawing.Size(251, 31);
            this.cId_passportTextBox.TabIndex = 4;
            // 
            // cLastNameTextBox
            // 
            this.cLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CLastName", true));
            this.cLastNameTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cLastNameTextBox.Location = new System.Drawing.Point(237, 75);
            this.cLastNameTextBox.Name = "cLastNameTextBox";
            this.cLastNameTextBox.Size = new System.Drawing.Size(251, 31);
            this.cLastNameTextBox.TabIndex = 6;
            // 
            // cNameTextBox
            // 
            this.cNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CName", true));
            this.cNameTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cNameTextBox.Location = new System.Drawing.Point(237, 111);
            this.cNameTextBox.Name = "cNameTextBox";
            this.cNameTextBox.Size = new System.Drawing.Size(251, 31);
            this.cNameTextBox.TabIndex = 8;
            // 
            // cPatronymicTextBox
            // 
            this.cPatronymicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CPatronymic", true));
            this.cPatronymicTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cPatronymicTextBox.Location = new System.Drawing.Point(237, 147);
            this.cPatronymicTextBox.Name = "cPatronymicTextBox";
            this.cPatronymicTextBox.Size = new System.Drawing.Size(251, 31);
            this.cPatronymicTextBox.TabIndex = 10;
            // 
            // cAdressTextBox
            // 
            this.cAdressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CAdress", true));
            this.cAdressTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cAdressTextBox.Location = new System.Drawing.Point(237, 183);
            this.cAdressTextBox.Name = "cAdressTextBox";
            this.cAdressTextBox.Size = new System.Drawing.Size(251, 31);
            this.cAdressTextBox.TabIndex = 12;
            // 
            // cPhoneTextBox
            // 
            this.cPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CPhone", true));
            this.cPhoneTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cPhoneTextBox.Location = new System.Drawing.Point(237, 219);
            this.cPhoneTextBox.Name = "cPhoneTextBox";
            this.cPhoneTextBox.Size = new System.Drawing.Size(251, 31);
            this.cPhoneTextBox.TabIndex = 14;
            // 
            // cWorkTextBox
            // 
            this.cWorkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CWork", true));
            this.cWorkTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cWorkTextBox.Location = new System.Drawing.Point(237, 255);
            this.cWorkTextBox.Name = "cWorkTextBox";
            this.cWorkTextBox.Size = new System.Drawing.Size(251, 31);
            this.cWorkTextBox.TabIndex = 16;
            // 
            // cSalaryTextBox
            // 
            this.cSalaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CSalary", true));
            this.cSalaryTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cSalaryTextBox.Location = new System.Drawing.Point(237, 291);
            this.cSalaryTextBox.Name = "cSalaryTextBox";
            this.cSalaryTextBox.Size = new System.Drawing.Size(251, 31);
            this.cSalaryTextBox.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(288, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 44);
            this.button2.TabIndex = 40;
            this.button2.Text = "Відмінити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(117, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 44);
            this.button1.TabIndex = 39;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(cId_passportLabel);
            this.Controls.Add(this.cId_passportTextBox);
            this.Controls.Add(cLastNameLabel);
            this.Controls.Add(this.cLastNameTextBox);
            this.Controls.Add(cNameLabel);
            this.Controls.Add(this.cNameTextBox);
            this.Controls.Add(cPatronymicLabel);
            this.Controls.Add(this.cPatronymicTextBox);
            this.Controls.Add(cAdressLabel);
            this.Controls.Add(this.cAdressTextBox);
            this.Controls.Add(cPhoneLabel);
            this.Controls.Add(this.cPhoneTextBox);
            this.Controls.Add(cWorkLabel);
            this.Controls.Add(this.cWorkTextBox);
            this.Controls.Add(cSalaryLabel);
            this.Controls.Add(this.cSalaryTextBox);
            this.Name = "NewClient";
            this.Text = "NewClient";
            this.Load += new System.EventHandler(this.NewClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private BankDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private BankDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cId_passportTextBox;
        private System.Windows.Forms.TextBox cLastNameTextBox;
        private System.Windows.Forms.TextBox cNameTextBox;
        private System.Windows.Forms.TextBox cPatronymicTextBox;
        private System.Windows.Forms.TextBox cAdressTextBox;
        private System.Windows.Forms.TextBox cPhoneTextBox;
        private System.Windows.Forms.TextBox cWorkTextBox;
        private System.Windows.Forms.TextBox cSalaryTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}