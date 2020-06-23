namespace Cursach
{
    partial class AddAgreement
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
            System.Windows.Forms.Label aDateFromLabel;
            System.Windows.Forms.Label aDateToLabel;
            System.Windows.Forms.Label aTypeLabel;
            System.Windows.Forms.Label aSummLabel;
            System.Windows.Forms.Label aPenyaLabel;
            System.Windows.Forms.Label id_creditLabel;
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.aDateFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.aDateToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.aSummTextBox = new System.Windows.Forms.TextBox();
            this.aPenyaTextBox = new System.Windows.Forms.TextBox();
            this.bankDataSet = new Cursach.BankDataSet();
            aDateFromLabel = new System.Windows.Forms.Label();
            aDateToLabel = new System.Windows.Forms.Label();
            aTypeLabel = new System.Windows.Forms.Label();
            aSummLabel = new System.Windows.Forms.Label();
            aPenyaLabel = new System.Windows.Forms.Label();
            id_creditLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // aDateFromLabel
            // 
            aDateFromLabel.AutoSize = true;
            aDateFromLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            aDateFromLabel.Location = new System.Drawing.Point(103, 43);
            aDateFromLabel.Name = "aDateFromLabel";
            aDateFromLabel.Size = new System.Drawing.Size(76, 23);
            aDateFromLabel.TabIndex = 35;
            aDateFromLabel.Text = "Дата (з):";
            // 
            // aDateToLabel
            // 
            aDateToLabel.AutoSize = true;
            aDateToLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            aDateToLabel.Location = new System.Drawing.Point(91, 79);
            aDateToLabel.Name = "aDateToLabel";
            aDateToLabel.Size = new System.Drawing.Size(88, 23);
            aDateToLabel.TabIndex = 37;
            aDateToLabel.Text = "Дата (по):";
            // 
            // aTypeLabel
            // 
            aTypeLabel.AutoSize = true;
            aTypeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            aTypeLabel.Location = new System.Drawing.Point(56, 112);
            aTypeLabel.Name = "aTypeLabel";
            aTypeLabel.Size = new System.Drawing.Size(123, 23);
            aTypeLabel.TabIndex = 39;
            aTypeLabel.Text = "Тип договору:";
            // 
            // aSummLabel
            // 
            aSummLabel.AutoSize = true;
            aSummLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            aSummLabel.Location = new System.Drawing.Point(41, 148);
            aSummLabel.Name = "aSummLabel";
            aSummLabel.Size = new System.Drawing.Size(138, 23);
            aSummLabel.TabIndex = 40;
            aSummLabel.Text = "Сумма кредиту:";
            // 
            // aPenyaLabel
            // 
            aPenyaLabel.AutoSize = true;
            aPenyaLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            aPenyaLabel.Location = new System.Drawing.Point(124, 184);
            aPenyaLabel.Name = "aPenyaLabel";
            aPenyaLabel.Size = new System.Drawing.Size(55, 23);
            aPenyaLabel.TabIndex = 42;
            aPenyaLabel.Text = "Пеня:";
            // 
            // id_creditLabel
            // 
            id_creditLabel.AutoSize = true;
            id_creditLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_creditLabel.Location = new System.Drawing.Point(107, 220);
            id_creditLabel.Name = "id_creditLabel";
            id_creditLabel.Size = new System.Drawing.Size(72, 23);
            id_creditLabel.TabIndex = 46;
            id_creditLabel.Text = "Кредит:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(291, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 44);
            this.button2.TabIndex = 52;
            this.button2.Text = "Відмінити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(120, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 44);
            this.button1.TabIndex = 51;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.DisplayMember = "Id_credit";
            this.comboBox4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(185, 217);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(266, 31);
            this.comboBox4.TabIndex = 50;
            this.comboBox4.ValueMember = "Id_credit";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Готівкою",
            "На кредитну карту"});
            this.comboBox1.Location = new System.Drawing.Point(185, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(266, 31);
            this.comboBox1.TabIndex = 47;
            this.comboBox1.Text = "Готівкою";
            // 
            // aDateFromDateTimePicker
            // 
            this.aDateFromDateTimePicker.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aDateFromDateTimePicker.Location = new System.Drawing.Point(185, 37);
            this.aDateFromDateTimePicker.Name = "aDateFromDateTimePicker";
            this.aDateFromDateTimePicker.Size = new System.Drawing.Size(266, 31);
            this.aDateFromDateTimePicker.TabIndex = 36;
            // 
            // aDateToDateTimePicker
            // 
            this.aDateToDateTimePicker.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aDateToDateTimePicker.Location = new System.Drawing.Point(185, 73);
            this.aDateToDateTimePicker.Name = "aDateToDateTimePicker";
            this.aDateToDateTimePicker.Size = new System.Drawing.Size(266, 31);
            this.aDateToDateTimePicker.TabIndex = 38;
            // 
            // aSummTextBox
            // 
            this.aSummTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aSummTextBox.Location = new System.Drawing.Point(185, 145);
            this.aSummTextBox.Name = "aSummTextBox";
            this.aSummTextBox.Size = new System.Drawing.Size(266, 31);
            this.aSummTextBox.TabIndex = 41;
            // 
            // aPenyaTextBox
            // 
            this.aPenyaTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aPenyaTextBox.Location = new System.Drawing.Point(185, 181);
            this.aPenyaTextBox.Name = "aPenyaTextBox";
            this.aPenyaTextBox.Size = new System.Drawing.Size(266, 31);
            this.aPenyaTextBox.TabIndex = 43;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddAgreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 384);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox4);
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
            this.Controls.Add(id_creditLabel);
            this.Name = "AddAgreement";
            this.Text = "AddAgreement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddAgreement_FormClosing);
            this.Load += new System.EventHandler(this.AddAgreement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker aDateFromDateTimePicker;
        private System.Windows.Forms.DateTimePicker aDateToDateTimePicker;
        private System.Windows.Forms.TextBox aSummTextBox;
        private System.Windows.Forms.TextBox aPenyaTextBox;
        private BankDataSet bankDataSet;
    }
}