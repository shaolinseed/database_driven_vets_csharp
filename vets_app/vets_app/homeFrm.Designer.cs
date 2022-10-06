
namespace vets_app
{
    partial class homeFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.executeQueryButton = new System.Windows.Forms.Button();
            this.staff = new System.Windows.Forms.Button();
            this.connectDbButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(27, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(523, 377);
            this.textBox1.TabIndex = 0;
            // 
            // executeQueryButton
            // 
            this.executeQueryButton.Location = new System.Drawing.Point(569, 33);
            this.executeQueryButton.Name = "executeQueryButton";
            this.executeQueryButton.Size = new System.Drawing.Size(198, 90);
            this.executeQueryButton.TabIndex = 1;
            this.executeQueryButton.Text = "Execute Query";
            this.executeQueryButton.UseVisualStyleBackColor = true;
            this.executeQueryButton.Click += new System.EventHandler(this.executeQueryButtonClick);
            // 
            // staff
            // 
            this.staff.Location = new System.Drawing.Point(569, 176);
            this.staff.Name = "staff";
            this.staff.Size = new System.Drawing.Size(198, 90);
            this.staff.TabIndex = 2;
            this.staff.Text = "Staff";
            this.staff.UseVisualStyleBackColor = true;
            this.staff.Click += new System.EventHandler(this.staff_Click);
            // 
            // connectDbButton
            // 
            this.connectDbButton.Location = new System.Drawing.Point(569, 320);
            this.connectDbButton.Name = "connectDbButton";
            this.connectDbButton.Size = new System.Drawing.Size(198, 90);
            this.connectDbButton.TabIndex = 3;
            this.connectDbButton.Text = "DB connect test";
            this.connectDbButton.UseVisualStyleBackColor = true;
            this.connectDbButton.Click += new System.EventHandler(this.connectDbButton_Click);
            // 
            // homeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.connectDbButton);
            this.Controls.Add(this.staff);
            this.Controls.Add(this.executeQueryButton);
            this.Controls.Add(this.textBox1);
            this.Name = "homeFrm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button executeQueryButton;
        private System.Windows.Forms.Button staff;
        private System.Windows.Forms.Button connectDbButton;
    }
}

