
namespace vets_app
{
    partial class customerRegisterFrm
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
            this.customerDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.customerErrorLabel = new System.Windows.Forms.Label();
            this.repeatTextBox = new System.Windows.Forms.TextBox();
            this.repeatLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firtNameLabel = new System.Windows.Forms.Label();
            this.petDetailsgroupBox = new System.Windows.Forms.GroupBox();
            this.dobLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.petNameTextBox = new System.Windows.Forms.TextBox();
            this.petNameLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.breedLabel = new System.Windows.Forms.Label();
            this.breedComboBox = new System.Windows.Forms.ComboBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.customerDetailsGroupBox.SuspendLayout();
            this.petDetailsgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerDetailsGroupBox
            // 
            this.customerDetailsGroupBox.Controls.Add(this.customerErrorLabel);
            this.customerDetailsGroupBox.Controls.Add(this.repeatTextBox);
            this.customerDetailsGroupBox.Controls.Add(this.repeatLabel);
            this.customerDetailsGroupBox.Controls.Add(this.passwordTextBox);
            this.customerDetailsGroupBox.Controls.Add(this.passwordLabel);
            this.customerDetailsGroupBox.Controls.Add(this.emailTextBox);
            this.customerDetailsGroupBox.Controls.Add(this.emailLabel);
            this.customerDetailsGroupBox.Controls.Add(this.lastNameTextBox);
            this.customerDetailsGroupBox.Controls.Add(this.lastNameLabel);
            this.customerDetailsGroupBox.Controls.Add(this.firstNameTextBox);
            this.customerDetailsGroupBox.Controls.Add(this.firtNameLabel);
            this.customerDetailsGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerDetailsGroupBox.Location = new System.Drawing.Point(12, 57);
            this.customerDetailsGroupBox.Name = "customerDetailsGroupBox";
            this.customerDetailsGroupBox.Size = new System.Drawing.Size(378, 346);
            this.customerDetailsGroupBox.TabIndex = 0;
            this.customerDetailsGroupBox.TabStop = false;
            this.customerDetailsGroupBox.Text = "Customer Details";
            // 
            // customerErrorLabel
            // 
            this.customerErrorLabel.AutoSize = true;
            this.customerErrorLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.customerErrorLabel.Location = new System.Drawing.Point(24, 305);
            this.customerErrorLabel.Name = "customerErrorLabel";
            this.customerErrorLabel.Size = new System.Drawing.Size(0, 19);
            this.customerErrorLabel.TabIndex = 8;
            // 
            // repeatTextBox
            // 
            this.repeatTextBox.Location = new System.Drawing.Point(105, 243);
            this.repeatTextBox.Name = "repeatTextBox";
            this.repeatTextBox.PasswordChar = '*';
            this.repeatTextBox.Size = new System.Drawing.Size(241, 29);
            this.repeatTextBox.TabIndex = 7;
            this.repeatTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // repeatLabel
            // 
            this.repeatLabel.AutoSize = true;
            this.repeatLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.repeatLabel.Location = new System.Drawing.Point(24, 249);
            this.repeatLabel.Name = "repeatLabel";
            this.repeatLabel.Size = new System.Drawing.Size(51, 19);
            this.repeatLabel.TabIndex = 6;
            this.repeatLabel.Text = "Repeat";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(105, 187);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(241, 29);
            this.passwordTextBox.TabIndex = 7;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(24, 193);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(67, 19);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(105, 134);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(241, 29);
            this.emailTextBox.TabIndex = 5;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(24, 140);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(41, 19);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(105, 84);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(241, 29);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.Location = new System.Drawing.Point(24, 90);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(74, 19);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(105, 40);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(241, 29);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // firtNameLabel
            // 
            this.firtNameLabel.AutoSize = true;
            this.firtNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firtNameLabel.Location = new System.Drawing.Point(24, 46);
            this.firtNameLabel.Name = "firtNameLabel";
            this.firtNameLabel.Size = new System.Drawing.Size(75, 19);
            this.firtNameLabel.TabIndex = 0;
            this.firtNameLabel.Text = "First Name";
            // 
            // petDetailsgroupBox
            // 
            this.petDetailsgroupBox.Controls.Add(this.dobLabel);
            this.petDetailsgroupBox.Controls.Add(this.dateTimePicker1);
            this.petDetailsgroupBox.Controls.Add(this.petNameTextBox);
            this.petDetailsgroupBox.Controls.Add(this.petNameLabel);
            this.petDetailsgroupBox.Controls.Add(this.genderLabel);
            this.petDetailsgroupBox.Controls.Add(this.comboBox1);
            this.petDetailsgroupBox.Controls.Add(this.breedLabel);
            this.petDetailsgroupBox.Controls.Add(this.breedComboBox);
            this.petDetailsgroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.petDetailsgroupBox.Location = new System.Drawing.Point(422, 57);
            this.petDetailsgroupBox.Name = "petDetailsgroupBox";
            this.petDetailsgroupBox.Size = new System.Drawing.Size(238, 346);
            this.petDetailsgroupBox.TabIndex = 1;
            this.petDetailsgroupBox.TabStop = false;
            this.petDetailsgroupBox.Text = "Pet Details";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dobLabel.Location = new System.Drawing.Point(19, 212);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(87, 19);
            this.dobLabel.TabIndex = 12;
            this.dobLabel.Text = "Date of Birth";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 234);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 3, 22, 22, 32, 20, 920);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 25);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2022, 3, 22, 0, 0, 0, 0);
            // 
            // petNameTextBox
            // 
            this.petNameTextBox.Location = new System.Drawing.Point(70, 40);
            this.petNameTextBox.Name = "petNameTextBox";
            this.petNameTextBox.Size = new System.Drawing.Size(147, 29);
            this.petNameTextBox.TabIndex = 9;
            // 
            // petNameLabel
            // 
            this.petNameLabel.AutoSize = true;
            this.petNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.petNameLabel.Location = new System.Drawing.Point(19, 44);
            this.petNameLabel.Name = "petNameLabel";
            this.petNameLabel.Size = new System.Drawing.Size(45, 19);
            this.petNameLabel.TabIndex = 8;
            this.petNameLabel.Text = "Name";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genderLabel.Location = new System.Drawing.Point(18, 141);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(54, 19);
            this.genderLabel.TabIndex = 10;
            this.genderLabel.Text = "Gender";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 163);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 29);
            this.comboBox1.TabIndex = 9;
            // 
            // breedLabel
            // 
            this.breedLabel.AutoSize = true;
            this.breedLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.breedLabel.Location = new System.Drawing.Point(18, 79);
            this.breedLabel.Name = "breedLabel";
            this.breedLabel.Size = new System.Drawing.Size(44, 19);
            this.breedLabel.TabIndex = 8;
            this.breedLabel.Text = "Breed";
            // 
            // breedComboBox
            // 
            this.breedComboBox.FormattingEnabled = true;
            this.breedComboBox.Location = new System.Drawing.Point(18, 101);
            this.breedComboBox.Name = "breedComboBox";
            this.breedComboBox.Size = new System.Drawing.Size(199, 29);
            this.breedComboBox.TabIndex = 0;
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerButton.Location = new System.Drawing.Point(676, 335);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(112, 68);
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(693, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customerRegisterFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.petDetailsgroupBox);
            this.Controls.Add(this.customerDetailsGroupBox);
            this.Name = "customerRegisterFrm";
            this.Text = "customerRegisterFrm";
            this.Load += new System.EventHandler(this.customerRegisterFrm_Load);
            this.customerDetailsGroupBox.ResumeLayout(false);
            this.customerDetailsGroupBox.PerformLayout();
            this.petDetailsgroupBox.ResumeLayout(false);
            this.petDetailsgroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox customerDetailsGroupBox;
        private System.Windows.Forms.Label firtNameLabel;
        private System.Windows.Forms.GroupBox petDetailsgroupBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox repeatTextBox;
        private System.Windows.Forms.Label repeatLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.ComboBox breedComboBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label breedLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label petNameLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label customerErrorLabel;
        private System.Windows.Forms.TextBox petNameTextBox;
        private System.Windows.Forms.Button button1;
    }
}