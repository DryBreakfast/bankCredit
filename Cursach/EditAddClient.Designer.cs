namespace Cursach
{
    partial class EditAddClient
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
            this.tableAdapterManager = new Cursach.BankDataSetTableAdapters.TableAdapterManager();
            this.clientTableAdapter = new Cursach.BankDataSetTableAdapters.ClientTableAdapter();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet = new Cursach.BankDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cId_passportTextBox = new System.Windows.Forms.TextBox();
            this.cLastNameTextBox = new System.Windows.Forms.TextBox();
            this.cNameTextBox = new System.Windows.Forms.TextBox();
            this.cPatronymicTextBox = new System.Windows.Forms.TextBox();
            this.cAdressTextBox = new System.Windows.Forms.TextBox();
            this.cPhoneTextBox = new System.Windows.Forms.TextBox();
            this.cWorkTextBox = new System.Windows.Forms.TextBox();
            this.cSalaryTextBox = new System.Windows.Forms.TextBox();
            cId_passportLabel = new System.Windows.Forms.Label();
            cLastNameLabel = new System.Windows.Forms.Label();
            cNameLabel = new System.Windows.Forms.Label();
            cPatronymicLabel = new System.Windows.Forms.Label();
            cAdressLabel = new System.Windows.Forms.Label();
            cPhoneLabel = new System.Windows.Forms.Label();
            cWorkLabel = new System.Windows.Forms.Label();
            cSalaryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cId_passportLabel
            // 
            cId_passportLabel.AutoSize = true;
            cId_passportLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cId_passportLabel.Location = new System.Drawing.Point(48, 36);
            cId_passportLabel.Name = "cId_passportLabel";
            cId_passportLabel.Size = new System.Drawing.Size(146, 23);
            cId_passportLabel.TabIndex = 21;
            cId_passportLabel.Text = "Номер паспорту:";
            // 
            // cLastNameLabel
            // 
            cLastNameLabel.AutoSize = true;
            cLastNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cLastNameLabel.Location = new System.Drawing.Point(100, 72);
            cLastNameLabel.Name = "cLastNameLabel";
            cLastNameLabel.Size = new System.Drawing.Size(91, 23);
            cLastNameLabel.TabIndex = 23;
            cLastNameLabel.Text = "Прізвище:";
            // 
            // cNameLabel
            // 
            cNameLabel.AutoSize = true;
            cNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cNameLabel.Location = new System.Drawing.Point(144, 108);
            cNameLabel.Name = "cNameLabel";
            cNameLabel.Size = new System.Drawing.Size(47, 23);
            cNameLabel.TabIndex = 25;
            cNameLabel.Text = "Ім\'я:";
            // 
            // cPatronymicLabel
            // 
            cPatronymicLabel.AutoSize = true;
            cPatronymicLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cPatronymicLabel.Location = new System.Drawing.Point(81, 144);
            cPatronymicLabel.Name = "cPatronymicLabel";
            cPatronymicLabel.Size = new System.Drawing.Size(108, 23);
            cPatronymicLabel.TabIndex = 27;
            cPatronymicLabel.Text = "По батькові:";
            // 
            // cAdressLabel
            // 
            cAdressLabel.AutoSize = true;
            cAdressLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cAdressLabel.Location = new System.Drawing.Point(118, 180);
            cAdressLabel.Name = "cAdressLabel";
            cAdressLabel.Size = new System.Drawing.Size(73, 23);
            cAdressLabel.TabIndex = 29;
            cAdressLabel.Text = "Адреса:";
            // 
            // cPhoneLabel
            // 
            cPhoneLabel.AutoSize = true;
            cPhoneLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cPhoneLabel.Location = new System.Drawing.Point(42, 216);
            cPhoneLabel.Name = "cPhoneLabel";
            cPhoneLabel.Size = new System.Drawing.Size(149, 23);
            cPhoneLabel.TabIndex = 31;
            cPhoneLabel.Text = "Номер телефону:";
            // 
            // cWorkLabel
            // 
            cWorkLabel.AutoSize = true;
            cWorkLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cWorkLabel.Location = new System.Drawing.Point(68, 252);
            cWorkLabel.Name = "cWorkLabel";
            cWorkLabel.Size = new System.Drawing.Size(123, 23);
            cWorkLabel.TabIndex = 33;
            cWorkLabel.Text = "Місце роботи:";
            // 
            // cSalaryLabel
            // 
            cSalaryLabel.AutoSize = true;
            cSalaryLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cSalaryLabel.Location = new System.Drawing.Point(49, 288);
            cSalaryLabel.Name = "cSalaryLabel";
            cSalaryLabel.Size = new System.Drawing.Size(142, 23);
            cSalaryLabel.TabIndex = 35;
            cSalaryLabel.Text = "Заробітна плата:";
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
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.bankDataSet;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(273, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 44);
            this.button2.TabIndex = 38;
            this.button2.Text = "Відмінити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(102, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 44);
            this.button1.TabIndex = 37;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cId_passportTextBox
            // 
            this.cId_passportTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cId_passportTextBox.Location = new System.Drawing.Point(200, 33);
            this.cId_passportTextBox.Name = "cId_passportTextBox";
            this.cId_passportTextBox.Size = new System.Drawing.Size(262, 31);
            this.cId_passportTextBox.TabIndex = 22;
            // 
            // cLastNameTextBox
            // 
            this.cLastNameTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cLastNameTextBox.Location = new System.Drawing.Point(200, 69);
            this.cLastNameTextBox.Name = "cLastNameTextBox";
            this.cLastNameTextBox.Size = new System.Drawing.Size(262, 31);
            this.cLastNameTextBox.TabIndex = 24;
            // 
            // cNameTextBox
            // 
            this.cNameTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cNameTextBox.Location = new System.Drawing.Point(200, 105);
            this.cNameTextBox.Name = "cNameTextBox";
            this.cNameTextBox.Size = new System.Drawing.Size(262, 31);
            this.cNameTextBox.TabIndex = 26;
            // 
            // cPatronymicTextBox
            // 
            this.cPatronymicTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cPatronymicTextBox.Location = new System.Drawing.Point(200, 141);
            this.cPatronymicTextBox.Name = "cPatronymicTextBox";
            this.cPatronymicTextBox.Size = new System.Drawing.Size(262, 31);
            this.cPatronymicTextBox.TabIndex = 28;
            // 
            // cAdressTextBox
            // 
            this.cAdressTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cAdressTextBox.Location = new System.Drawing.Point(200, 177);
            this.cAdressTextBox.Name = "cAdressTextBox";
            this.cAdressTextBox.Size = new System.Drawing.Size(262, 31);
            this.cAdressTextBox.TabIndex = 30;
            // 
            // cPhoneTextBox
            // 
            this.cPhoneTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cPhoneTextBox.Location = new System.Drawing.Point(200, 213);
            this.cPhoneTextBox.Name = "cPhoneTextBox";
            this.cPhoneTextBox.Size = new System.Drawing.Size(262, 31);
            this.cPhoneTextBox.TabIndex = 32;
            // 
            // cWorkTextBox
            // 
            this.cWorkTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cWorkTextBox.Location = new System.Drawing.Point(200, 249);
            this.cWorkTextBox.Name = "cWorkTextBox";
            this.cWorkTextBox.Size = new System.Drawing.Size(262, 31);
            this.cWorkTextBox.TabIndex = 34;
            // 
            // cSalaryTextBox
            // 
            this.cSalaryTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cSalaryTextBox.Location = new System.Drawing.Point(200, 285);
            this.cSalaryTextBox.Name = "cSalaryTextBox";
            this.cSalaryTextBox.Size = new System.Drawing.Size(262, 31);
            this.cSalaryTextBox.TabIndex = 36;
            // 
            // EditAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
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
            this.Name = "EditAddClient";
            this.Text = "EditAddClient";
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BankDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BankDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cId_passportTextBox;
        private System.Windows.Forms.TextBox cLastNameTextBox;
        private System.Windows.Forms.TextBox cNameTextBox;
        private System.Windows.Forms.TextBox cPatronymicTextBox;
        private System.Windows.Forms.TextBox cAdressTextBox;
        private System.Windows.Forms.TextBox cPhoneTextBox;
        private System.Windows.Forms.TextBox cWorkTextBox;
        private System.Windows.Forms.TextBox cSalaryTextBox;
    }
}