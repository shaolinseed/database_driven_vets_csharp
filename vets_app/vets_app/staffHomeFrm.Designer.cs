
namespace vets_app
{
    partial class staffHomeFrm
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
            this.practitionerButton = new System.Windows.Forms.Button();
            this.stockControlButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // practitionerButton
            // 
            this.practitionerButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.practitionerButton.Location = new System.Drawing.Point(64, 109);
            this.practitionerButton.Name = "practitionerButton";
            this.practitionerButton.Size = new System.Drawing.Size(125, 72);
            this.practitionerButton.TabIndex = 0;
            this.practitionerButton.Text = "Practitioner";
            this.practitionerButton.UseVisualStyleBackColor = true;
            this.practitionerButton.Click += new System.EventHandler(this.practitionerButton_Click);
            // 
            // stockControlButton
            // 
            this.stockControlButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stockControlButton.Location = new System.Drawing.Point(88, 270);
            this.stockControlButton.Name = "stockControlButton";
            this.stockControlButton.Size = new System.Drawing.Size(125, 72);
            this.stockControlButton.TabIndex = 1;
            this.stockControlButton.Text = "Stock Control";
            this.stockControlButton.UseVisualStyleBackColor = true;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(64, 46);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(110, 30);
            this.welcomeLabel.TabIndex = 3;
            this.welcomeLabel.Text = "Welcome ";
            // 
            // staffHomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.stockControlButton);
            this.Controls.Add(this.practitionerButton);
            this.Name = "staffHomeFrm";
            this.Text = "Staff | Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button practitionerButton;
        private System.Windows.Forms.Button stockControlButton;
        private System.Windows.Forms.Label welcomeLabel;
    }
}