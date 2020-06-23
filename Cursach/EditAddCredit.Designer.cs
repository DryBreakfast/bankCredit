namespace Cursach
{
    partial class EditAddCredit
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
            System.Windows.Forms.Label crNameLabel;
            System.Windows.Forms.Label crTypeLabel;
            System.Windows.Forms.Label crRersentLabel;
            System.Windows.Forms.Label crCauseLabel;
            this.bankDataSet = new Cursach.BankDataSet();
            this.creditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creditTableAdapter = new Cursach.BankDataSetTableAdapters.CreditTableAdapter();
            this.tableAdapterManager = new Cursach.BankDataSetTableAdapters.TableAdapterManager();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.crNameTextBox = new System.Windows.Forms.TextBox();
            this.crRersentTextBox = new System.Windows.Forms.TextBox();
            this.crCauseTextBox = new System.Windows.Forms.TextBox();
            crNameLabel = new System.Windows.Forms.Label();
            crTypeLabel = new System.Windows.Forms.Label();
            crRersentLabel = new System.Windows.Forms.Label();
            crCauseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // crNameLabel
            // 
            crNameLabel.AutoSize = true;
            crNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            crNameLabel.Location = new System.Drawing.Point(94, 71);
            crNameLabel.Name = "crNameLabel";
            crNameLabel.Size = new System.Drawing.Size(131, 23);
            crNameLabel.TabIndex = 23;
            crNameLabel.Text = "Назва кредиту:";
            // 
            // crTypeLabel
            // 
            crTypeLabel.AutoSize = true;
            crTypeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            crTypeLabel.Location = new System.Drawing.Point(113, 111);
            crTypeLabel.Name = "crTypeLabel";
            crTypeLabel.Size = new System.Drawing.Size(112, 23);
            crTypeLabel.TabIndex = 25;
            crTypeLabel.Text = "Тип кредиту:";
            // 
            // crRersentLabel
            // 
            crRersentLabel.AutoSize = true;
            crRersentLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            crRersentLabel.Location = new System.Drawing.Point(68, 151);
            crRersentLabel.Name = "crRersentLabel";
            crRersentLabel.Size = new System.Drawing.Size(157, 23);
            crRersentLabel.TabIndex = 26;
            crRersentLabel.Text = "Відсоткова ставка:";
            // 
            // crCauseLabel
            // 
            crCauseLabel.AutoSize = true;
            crCauseLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            crCauseLabel.Location = new System.Drawing.Point(75, 187);
            crCauseLabel.Name = "crCauseLabel";
            crCauseLabel.Size = new System.Drawing.Size(150, 23);
            crCauseLabel.TabIndex = 28;
            crCauseLabel.Text = "Додаткові умови:";
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // creditBindingSource
            // 
            this.creditBindingSource.DataMember = "Credit";
            this.creditBindingSource.DataSource = this.bankDataSet;
            // 
            // creditTableAdapter
            // 
            this.creditTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgreementTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.CreditTableAdapter = this.creditTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.InsuranceTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cursach.BankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(350, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 44);
            this.button2.TabIndex = 32;
            this.button2.Text = "Відмінити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(179, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 44);
            this.button1.TabIndex = 31;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Онкольний",
            "Овернайт",
            "Надстроковий",
            "Короткостроковий",
            "Середньостроковий",
            "Довгостроковий"});
            this.comboBox1.Location = new System.Drawing.Point(231, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(401, 31);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.Text = "Середньостроковий";
            // 
            // crNameTextBox
            // 
            this.crNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditBindingSource, "CrName", true));
            this.crNameTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.crNameTextBox.Location = new System.Drawing.Point(231, 68);
            this.crNameTextBox.Name = "crNameTextBox";
            this.crNameTextBox.Size = new System.Drawing.Size(401, 31);
            this.crNameTextBox.TabIndex = 24;
            // 
            // crRersentTextBox
            // 
            this.crRersentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditBindingSource, "CrRersent", true));
            this.crRersentTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.crRersentTextBox.Location = new System.Drawing.Point(231, 148);
            this.crRersentTextBox.Name = "crRersentTextBox";
            this.crRersentTextBox.Size = new System.Drawing.Size(401, 31);
            this.crRersentTextBox.TabIndex = 27;
            // 
            // crCauseTextBox
            // 
            this.crCauseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditBindingSource, "CrCause", true));
            this.crCauseTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.crCauseTextBox.Location = new System.Drawing.Point(231, 187);
            this.crCauseTextBox.Multiline = true;
            this.crCauseTextBox.Name = "crCauseTextBox";
            this.crCauseTextBox.Size = new System.Drawing.Size(401, 105);
            this.crCauseTextBox.TabIndex = 29;
            // 
            // EditAddCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(crNameLabel);
            this.Controls.Add(crTypeLabel);
            this.Controls.Add(crRersentLabel);
            this.Controls.Add(crCauseLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.crNameTextBox);
            this.Controls.Add(this.crRersentTextBox);
            this.Controls.Add(this.crCauseTextBox);
            this.Name = "EditAddCredit";
            this.Text = "EditAddCredit";
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource creditBindingSource;
        private BankDataSetTableAdapters.CreditTableAdapter creditTableAdapter;
        private BankDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox crNameTextBox;
        private System.Windows.Forms.TextBox crRersentTextBox;
        private System.Windows.Forms.TextBox crCauseTextBox;
    }
}