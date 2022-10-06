
namespace vets_app
{
    partial class stockManagerForm
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
            this.lowStockLabel = new System.Windows.Forms.Label();
            this.dataLowStockList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataLowStockList)).BeginInit();
            this.SuspendLayout();
            // 
            // lowStockLabel
            // 
            this.lowStockLabel.AutoSize = true;
            this.lowStockLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lowStockLabel.ForeColor = System.Drawing.Color.Red;
            this.lowStockLabel.Location = new System.Drawing.Point(27, 39);
            this.lowStockLabel.Name = "lowStockLabel";
            this.lowStockLabel.Size = new System.Drawing.Size(122, 21);
            this.lowStockLabel.TabIndex = 1;
            this.lowStockLabel.Text = "Low Stock Items";
            // 
            // dataLowStockList
            // 
            this.dataLowStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLowStockList.Location = new System.Drawing.Point(27, 80);
            this.dataLowStockList.Name = "dataLowStockList";
            this.dataLowStockList.RowHeadersVisible = false;
            this.dataLowStockList.RowTemplate.Height = 25;
            this.dataLowStockList.Size = new System.Drawing.Size(321, 172);
            this.dataLowStockList.TabIndex = 2;
            this.dataLowStockList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLowStockList_CellContentDoubleClick);
            // 
            // stockManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataLowStockList);
            this.Controls.Add(this.lowStockLabel);
            this.Name = "stockManagerForm";
            this.Text = "Stock Control Manager | Home";
            this.Load += new System.EventHandler(this.stockManagerFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataLowStockList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lowStockLabel;
        private System.Windows.Forms.DataGridView dataLowStockList;
    }
}