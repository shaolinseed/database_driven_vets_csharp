
namespace vets_app
{
    partial class homeFrm2
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
            this.customerButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.staffButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerButton
            // 
            this.customerButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerButton.Location = new System.Drawing.Point(294, 156);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(197, 62);
            this.customerButton.TabIndex = 0;
            this.customerButton.Text = "Customer";
            this.customerButton.UseVisualStyleBackColor = true;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(208, 43);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(379, 80);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome to Veterinary Centre Anglia ";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // staffButton
            // 
            this.staffButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.staffButton.Location = new System.Drawing.Point(294, 245);
            this.staffButton.Name = "staffButton";
            this.staffButton.Size = new System.Drawing.Size(197, 62);
            this.staffButton.TabIndex = 2;
            this.staffButton.Text = "Staff";
            this.staffButton.UseVisualStyleBackColor = true;
            this.staffButton.Click += new System.EventHandler(this.staffButton_Click);
            // 
            // homeFrm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.staffButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.customerButton);
            this.Name = "homeFrm2";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button staffButton;
    }
}