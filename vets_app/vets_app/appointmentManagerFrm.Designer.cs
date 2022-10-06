
namespace vets_app
{
    partial class appointmentManagerFrm
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
            this.dataPetWeightsList = new System.Windows.Forms.DataGridView();
            this.addPetWeightTextBox = new System.Windows.Forms.TextBox();
            this.addPetWeightButton = new System.Windows.Forms.Button();
            this.medicationNameComboBox = new System.Windows.Forms.ComboBox();
            this.selectPescriptionLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.repeatPescriptionCheckBox = new System.Windows.Forms.CheckBox();
            this.medicationSizeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataPetWeightsList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataPetWeightsList
            // 
            this.dataPetWeightsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPetWeightsList.Location = new System.Drawing.Point(549, 58);
            this.dataPetWeightsList.Name = "dataPetWeightsList";
            this.dataPetWeightsList.RowHeadersVisible = false;
            this.dataPetWeightsList.RowTemplate.Height = 25;
            this.dataPetWeightsList.Size = new System.Drawing.Size(216, 196);
            this.dataPetWeightsList.TabIndex = 0;
            // 
            // addPetWeightTextBox
            // 
            this.addPetWeightTextBox.Location = new System.Drawing.Point(549, 260);
            this.addPetWeightTextBox.Name = "addPetWeightTextBox";
            this.addPetWeightTextBox.PlaceholderText = "Pet Weight (Kg)";
            this.addPetWeightTextBox.Size = new System.Drawing.Size(114, 23);
            this.addPetWeightTextBox.TabIndex = 1;
            // 
            // addPetWeightButton
            // 
            this.addPetWeightButton.Location = new System.Drawing.Point(669, 260);
            this.addPetWeightButton.Name = "addPetWeightButton";
            this.addPetWeightButton.Size = new System.Drawing.Size(96, 23);
            this.addPetWeightButton.TabIndex = 2;
            this.addPetWeightButton.Text = "Add Weight";
            this.addPetWeightButton.UseVisualStyleBackColor = true;
            this.addPetWeightButton.Click += new System.EventHandler(this.addPetWeightButton_Click);
            // 
            // medicationNameComboBox
            // 
            this.medicationNameComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.medicationNameComboBox.FormattingEnabled = true;
            this.medicationNameComboBox.Location = new System.Drawing.Point(6, 43);
            this.medicationNameComboBox.Name = "medicationNameComboBox";
            this.medicationNameComboBox.Size = new System.Drawing.Size(263, 23);
            this.medicationNameComboBox.TabIndex = 4;
            this.medicationNameComboBox.SelectedValueChanged += new System.EventHandler(this.medicationNameComboBox_SelectedValueChanged);
            // 
            // selectPescriptionLabel
            // 
            this.selectPescriptionLabel.AutoSize = true;
            this.selectPescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectPescriptionLabel.Location = new System.Drawing.Point(6, 25);
            this.selectPescriptionLabel.Name = "selectPescriptionLabel";
            this.selectPescriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.selectPescriptionLabel.TabIndex = 5;
            this.selectPescriptionLabel.Text = "Medication";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.repeatPescriptionCheckBox);
            this.groupBox1.Controls.Add(this.medicationSizeComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.medicationNameComboBox);
            this.groupBox1.Controls.Add(this.selectPescriptionLabel);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(39, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 323);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Pescription";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(76, 202);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 256);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 9;
            // 
            // repeatPescriptionCheckBox
            // 
            this.repeatPescriptionCheckBox.AutoSize = true;
            this.repeatPescriptionCheckBox.Location = new System.Drawing.Point(15, 125);
            this.repeatPescriptionCheckBox.Name = "repeatPescriptionCheckBox";
            this.repeatPescriptionCheckBox.Size = new System.Drawing.Size(77, 25);
            this.repeatPescriptionCheckBox.TabIndex = 8;
            this.repeatPescriptionCheckBox.Text = "Repeat";
            this.repeatPescriptionCheckBox.UseVisualStyleBackColor = true;
            // 
            // medicationSizeComboBox
            // 
            this.medicationSizeComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.medicationSizeComboBox.FormattingEnabled = true;
            this.medicationSizeComboBox.Location = new System.Drawing.Point(6, 96);
            this.medicationSizeComboBox.Name = "medicationSizeComboBox";
            this.medicationSizeComboBox.Size = new System.Drawing.Size(263, 23);
            this.medicationSizeComboBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Size";
            // 
            // appointmentManagerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addPetWeightButton);
            this.Controls.Add(this.addPetWeightTextBox);
            this.Controls.Add(this.dataPetWeightsList);
            this.Name = "appointmentManagerFrm";
            this.Text = "Appointment Manager";
            this.Load += new System.EventHandler(this.appointmentManagerFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPetWeightsList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataPetWeightsList;
        private System.Windows.Forms.TextBox addPetWeightTextBox;
        private System.Windows.Forms.Button addPetWeightButton;
        private System.Windows.Forms.ComboBox medicationNameComboBox;
        private System.Windows.Forms.Label selectPescriptionLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox medicationSizeComboBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox repeatPescriptionCheckBox;
    }
}