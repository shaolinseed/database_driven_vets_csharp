
namespace vets_app
{
    partial class practitionerHomeFrm
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
            this.dataTodaysAppointmentsList = new System.Windows.Forms.DataGridView();
            this.practitionerAppointmentsLabel = new System.Windows.Forms.Label();
            this.openAppointmentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTodaysAppointmentsList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTodaysAppointmentsList
            // 
            this.dataTodaysAppointmentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTodaysAppointmentsList.Location = new System.Drawing.Point(12, 62);
            this.dataTodaysAppointmentsList.Name = "dataTodaysAppointmentsList";
            this.dataTodaysAppointmentsList.RowTemplate.Height = 25;
            this.dataTodaysAppointmentsList.Size = new System.Drawing.Size(579, 294);
            this.dataTodaysAppointmentsList.TabIndex = 0;
            this.dataTodaysAppointmentsList.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTodaysAppointmentsList_RowValidated);
            // 
            // practitionerAppointmentsLabel
            // 
            this.practitionerAppointmentsLabel.AutoSize = true;
            this.practitionerAppointmentsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.practitionerAppointmentsLabel.Location = new System.Drawing.Point(12, 38);
            this.practitionerAppointmentsLabel.Name = "practitionerAppointmentsLabel";
            this.practitionerAppointmentsLabel.Size = new System.Drawing.Size(159, 21);
            this.practitionerAppointmentsLabel.TabIndex = 1;
            this.practitionerAppointmentsLabel.Text = "Todays Appointments";
            // 
            // openAppointmentButton
            // 
            this.openAppointmentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openAppointmentButton.Location = new System.Drawing.Point(626, 62);
            this.openAppointmentButton.Name = "openAppointmentButton";
            this.openAppointmentButton.Size = new System.Drawing.Size(134, 53);
            this.openAppointmentButton.TabIndex = 2;
            this.openAppointmentButton.Text = "Open Appointment";
            this.openAppointmentButton.UseVisualStyleBackColor = true;
            this.openAppointmentButton.Click += new System.EventHandler(this.openAppointmentButton_Click);
            // 
            // practitionerHomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openAppointmentButton);
            this.Controls.Add(this.practitionerAppointmentsLabel);
            this.Controls.Add(this.dataTodaysAppointmentsList);
            this.Name = "practitionerHomeFrm";
            this.Text = "Practitioner Home";
            this.Load += new System.EventHandler(this.practitionerFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataTodaysAppointmentsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTodaysAppointmentsList;
        private System.Windows.Forms.Label practitionerAppointmentsLabel;
        private System.Windows.Forms.Button openAppointmentButton;
    }
}