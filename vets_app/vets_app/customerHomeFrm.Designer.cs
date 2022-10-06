
namespace vets_app
{
    partial class customerHomeFrm
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
            this.registerButton = new System.Windows.Forms.Button();
            this.bookAppointmentButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerButton.Location = new System.Drawing.Point(296, 94);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(191, 60);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // bookAppointmentButton
            // 
            this.bookAppointmentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookAppointmentButton.Location = new System.Drawing.Point(296, 273);
            this.bookAppointmentButton.Name = "bookAppointmentButton";
            this.bookAppointmentButton.Size = new System.Drawing.Size(191, 72);
            this.bookAppointmentButton.TabIndex = 1;
            this.bookAppointmentButton.Text = "Book Appointment";
            this.bookAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginButton.Location = new System.Drawing.Point(296, 184);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(191, 60);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // customerHomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.bookAppointmentButton);
            this.Controls.Add(this.registerButton);
            this.Name = "customerHomeFrm";
            this.Text = "customerHomeFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button bookAppointmentButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button loginButton;
    }
}