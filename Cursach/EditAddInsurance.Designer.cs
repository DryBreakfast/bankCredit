namespace Cursach
{
    partial class EditAddInsurance
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
            System.Windows.Forms.Label iFirmLabel;
            System.Windows.Forms.Label iSummaLabel;
            System.Windows.Forms.Label iFormLabel;
            this.bankDataSet = new Cursach.BankDataSet();
            this.insuranceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insuranceTableAdapter = new Cursach.BankDataSetTableAdapters.InsuranceTableAdapter();
            this.tableAdapterManager = new Cursach.BankDataSetTableAdapters.TableAdapterManager();
            this.agreementTableAdapter = new Cursach.BankDataSetTableAdapters.AgreementTableAdapter();
            this.iFirmTextBox = new System.Windows.Forms.TextBox();
            this.iSummaTextBox = new System.Windows.Forms.TextBox();
            this.iFormTextBox = new System.Windows.Forms.TextBox();
            this.agreementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            iFirmLabel = new System.Windows.Forms.Label();
            iSummaLabel = new System.Windows.Forms.Label();
            iFormLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iFirmLabel
            // 
            iFirmLabel.AutoSize = true;
            iFirmLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iFirmLabel.Location = new System.Drawing.Point(132, 96);
            iFirmLabel.Name = "iFirmLabel";
            iFirmLabel.Size = new System.Drawing.Size(64, 23);
            iFirmLabel.TabIndex = 1;
            iFirmLabel.Text = "Фірма:";
            // 
            // iSummaLabel
            // 
            iSummaLabel.AutoSize = true;
            iSummaLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iSummaLabel.Location = new System.Drawing.Point(140, 132);
            iSummaLabel.Name = "iSummaLabel";
            iSummaLabel.Size = new System.Drawing.Size(56, 23);
            iSummaLabel.TabIndex = 3;
            iSummaLabel.Text = "Сума:";
            // 
            // iFormLabel
            // 
            iFormLabel.AutoSize = true;
            iFormLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iFormLabel.Location = new System.Drawing.Point(24, 168);
            iFormLabel.Name = "iFormLabel";
            iFormLabel.Size = new System.Drawing.Size(172, 23);
            iFormLabel.TabIndex = 5;
            iFormLabel.Text = "Форма страхування:";
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // insuranceBindingSource
            // 
            this.insuranceBindingSource.DataMember = "Insurance";
            this.insuranceBindingSource.DataSource = this.bankDataSet;
            // 
            // insuranceTableAdapter
            // 
            this.insuranceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgreementTableAdapter = this.agreementTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.CreditTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.InsuranceTableAdapter = this.insuranceTableAdapter;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cursach.BankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // agreementTableAdapter
            // 
            this.agreementTableAdapter.ClearBeforeFill = true;
            // 
            // iFirmTextBox
            // 
            this.iFirmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.insuranceBindingSource, "IFirm", true));
            this.iFirmTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iFirmTextBox.Location = new System.Drawing.Point(202, 93);
            this.iFirmTextBox.Name = "iFirmTextBox";
            this.iFirmTextBox.Size = new System.Drawing.Size(233, 31);
            this.iFirmTextBox.TabIndex = 2;
            // 
            // iSummaTextBox
            // 
            this.iSummaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.insuranceBindingSource, "ISumma", true));
            this.iSummaTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iSummaTextBox.Location = new System.Drawing.Point(202, 129);
            this.iSummaTextBox.Name = "iSummaTextBox";
            this.iSummaTextBox.Size = new System.Drawing.Size(233, 31);
            this.iSummaTextBox.TabIndex = 4;
            // 
            // iFormTextBox
            // 
            this.iFormTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.insuranceBindingSource, "IForm", true));
            this.iFormTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iFormTextBox.Location = new System.Drawing.Point(202, 165);
            this.iFormTextBox.Name = "iFormTextBox";
            this.iFormTextBox.Size = new System.Drawing.Size(233, 31);
            this.iFormTextBox.TabIndex = 6;
            // 
            // agreementBindingSource
            // 
            this.agreementBindingSource.DataMember = "Agreement";
            this.agreementBindingSource.DataSource = this.bankDataSet;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(257, 259);
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
            this.button1.Location = new System.Drawing.Point(86, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 44);
            this.button1.TabIndex = 39;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.agreementBindingSource;
            this.comboBox1.DisplayMember = "Id_agreement";
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(202, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 31);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "Id_agreement";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "Номер договору:";
            // 
            // EditAddInsurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(iFirmLabel);
            this.Controls.Add(this.iFirmTextBox);
            this.Controls.Add(iSummaLabel);
            this.Controls.Add(this.iSummaTextBox);
            this.Controls.Add(iFormLabel);
            this.Controls.Add(this.iFormTextBox);
            this.Name = "EditAddInsurance";
            this.Text = "EditAddInsurance";
            this.Load += new System.EventHandler(this.EditAddInsurance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource insuranceBindingSource;
        private BankDataSetTableAdapters.InsuranceTableAdapter insuranceTableAdapter;
        private BankDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iFirmTextBox;
        private System.Windows.Forms.TextBox iSummaTextBox;
        private System.Windows.Forms.TextBox iFormTextBox;
        private BankDataSetTableAdapters.AgreementTableAdapter agreementTableAdapter;
        private System.Windows.Forms.BindingSource agreementBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}