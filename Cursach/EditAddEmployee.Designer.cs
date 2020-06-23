namespace Cursach
{
    partial class EditAddEmployee
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
            System.Windows.Forms.Label emLastNameLabel;
            System.Windows.Forms.Label emNameLabel;
            System.Windows.Forms.Label emPatronymicLabel;
            System.Windows.Forms.Label emPositionLabel;
            System.Windows.Forms.Label emPhoneLabel;
            System.Windows.Forms.Label emAdressLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.emLastNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet = new Cursach.BankDataSet();
            this.emNameTextBox = new System.Windows.Forms.TextBox();
            this.emPatronymicTextBox = new System.Windows.Forms.TextBox();
            this.emPositionTextBox = new System.Windows.Forms.TextBox();
            this.emPhoneTextBox = new System.Windows.Forms.TextBox();
            this.emAdressTextBox = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new Cursach.BankDataSetTableAdapters.TableAdapterManager();
            this.employeeTableAdapter = new Cursach.BankDataSetTableAdapters.EmployeeTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            emLastNameLabel = new System.Windows.Forms.Label();
            emNameLabel = new System.Windows.Forms.Label();
            emPatronymicLabel = new System.Windows.Forms.Label();
            emPositionLabel = new System.Windows.Forms.Label();
            emPhoneLabel = new System.Windows.Forms.Label();
            emAdressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // emLastNameLabel
            // 
            emLastNameLabel.AutoSize = true;
            emLastNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            emLastNameLabel.Location = new System.Drawing.Point(107, 55);
            emLastNameLabel.Name = "emLastNameLabel";
            emLastNameLabel.Size = new System.Drawing.Size(91, 23);
            emLastNameLabel.TabIndex = 23;
            emLastNameLabel.Text = "Прізвище:";
            // 
            // emNameLabel
            // 
            emNameLabel.AutoSize = true;
            emNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            emNameLabel.Location = new System.Drawing.Point(151, 90);
            emNameLabel.Name = "emNameLabel";
            emNameLabel.Size = new System.Drawing.Size(47, 23);
            emNameLabel.TabIndex = 25;
            emNameLabel.Text = "Ім\'я:";
            // 
            // emPatronymicLabel
            // 
            emPatronymicLabel.AutoSize = true;
            emPatronymicLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            emPatronymicLabel.Location = new System.Drawing.Point(88, 126);
            emPatronymicLabel.Name = "emPatronymicLabel";
            emPatronymicLabel.Size = new System.Drawing.Size(108, 23);
            emPatronymicLabel.TabIndex = 27;
            emPatronymicLabel.Text = "По батькові:";
            // 
            // emPositionLabel
            // 
            emPositionLabel.AutoSize = true;
            emPositionLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            emPositionLabel.Location = new System.Drawing.Point(124, 162);
            emPositionLabel.Name = "emPositionLabel";
            emPositionLabel.Size = new System.Drawing.Size(74, 23);
            emPositionLabel.TabIndex = 29;
            emPositionLabel.Text = "Посада:";
            // 
            // emPhoneLabel
            // 
            emPhoneLabel.AutoSize = true;
            emPhoneLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            emPhoneLabel.Location = new System.Drawing.Point(49, 198);
            emPhoneLabel.Name = "emPhoneLabel";
            emPhoneLabel.Size = new System.Drawing.Size(149, 23);
            emPhoneLabel.TabIndex = 31;
            emPhoneLabel.Text = "Номер телефону:";
            // 
            // emAdressLabel
            // 
            emAdressLabel.AutoSize = true;
            emAdressLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            emAdressLabel.Location = new System.Drawing.Point(46, 234);
            emAdressLabel.Name = "emAdressLabel";
            emAdressLabel.Size = new System.Drawing.Size(152, 23);
            emAdressLabel.TabIndex = 33;
            emAdressLabel.Text = "Домашня адреса:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(103, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 44);
            this.button1.TabIndex = 35;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // emLastNameTextBox
            // 
            this.emLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmLastName", true));
            this.emLastNameTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emLastNameTextBox.Location = new System.Drawing.Point(204, 52);
            this.emLastNameTextBox.Name = "emLastNameTextBox";
            this.emLastNameTextBox.Size = new System.Drawing.Size(231, 31);
            this.emLastNameTextBox.TabIndex = 24;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.bankDataSet;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emNameTextBox
            // 
            this.emNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmName", true));
            this.emNameTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emNameTextBox.Location = new System.Drawing.Point(204, 87);
            this.emNameTextBox.Name = "emNameTextBox";
            this.emNameTextBox.Size = new System.Drawing.Size(231, 31);
            this.emNameTextBox.TabIndex = 26;
            // 
            // emPatronymicTextBox
            // 
            this.emPatronymicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmPatronymic", true));
            this.emPatronymicTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emPatronymicTextBox.Location = new System.Drawing.Point(204, 123);
            this.emPatronymicTextBox.Name = "emPatronymicTextBox";
            this.emPatronymicTextBox.Size = new System.Drawing.Size(231, 31);
            this.emPatronymicTextBox.TabIndex = 28;
            // 
            // emPositionTextBox
            // 
            this.emPositionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmPosition", true));
            this.emPositionTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emPositionTextBox.Location = new System.Drawing.Point(204, 159);
            this.emPositionTextBox.Name = "emPositionTextBox";
            this.emPositionTextBox.Size = new System.Drawing.Size(231, 31);
            this.emPositionTextBox.TabIndex = 30;
            // 
            // emPhoneTextBox
            // 
            this.emPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmPhone", true));
            this.emPhoneTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emPhoneTextBox.Location = new System.Drawing.Point(204, 195);
            this.emPhoneTextBox.Name = "emPhoneTextBox";
            this.emPhoneTextBox.Size = new System.Drawing.Size(231, 31);
            this.emPhoneTextBox.TabIndex = 32;
            // 
            // emAdressTextBox
            // 
            this.emAdressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmAdress", true));
            this.emAdressTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emAdressTextBox.Location = new System.Drawing.Point(204, 231);
            this.emAdressTextBox.Name = "emAdressTextBox";
            this.emAdressTextBox.Size = new System.Drawing.Size(231, 31);
            this.emAdressTextBox.TabIndex = 34;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgreementTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.CreditTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.InsuranceTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cursach.BankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(274, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 44);
            this.button2.TabIndex = 36;
            this.button2.Text = "Відмінити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.emLastNameTextBox);
            this.Controls.Add(this.emNameTextBox);
            this.Controls.Add(this.emPatronymicTextBox);
            this.Controls.Add(this.emPositionTextBox);
            this.Controls.Add(this.emPhoneTextBox);
            this.Controls.Add(this.emAdressTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(emLastNameLabel);
            this.Controls.Add(emNameLabel);
            this.Controls.Add(emPatronymicLabel);
            this.Controls.Add(emPositionLabel);
            this.Controls.Add(emPhoneLabel);
            this.Controls.Add(emAdressLabel);
            this.Name = "EditAddEmployee";
            this.Text = "EditAddEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox emLastNameTextBox;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.TextBox emNameTextBox;
        private System.Windows.Forms.TextBox emPatronymicTextBox;
        private System.Windows.Forms.TextBox emPositionTextBox;
        private System.Windows.Forms.TextBox emPhoneTextBox;
        private System.Windows.Forms.TextBox emAdressTextBox;
        private BankDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BankDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Button button2;
    }
}