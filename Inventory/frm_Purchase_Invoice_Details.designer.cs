namespace Inventory
{
    partial class frm_Purchase_Invoice_Details
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
            this.dgv_AllInvoices = new System.Windows.Forms.DataGridView();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_AllInvoices
            // 
            this.dgv_AllInvoices.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_AllInvoices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv_AllInvoices.Location = new System.Drawing.Point(27, 21);
            this.dgv_AllInvoices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_AllInvoices.Name = "dgv_AllInvoices";
            this.dgv_AllInvoices.RowTemplate.Height = 26;
            this.dgv_AllInvoices.Size = new System.Drawing.Size(611, 168);
            this.dgv_AllInvoices.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(580, 194);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Frm_All_Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(658, 218);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.dgv_AllInvoices);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_All_Invoices";
            this.Text = "All_Invoices";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllInvoices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_AllInvoices;
        private System.Windows.Forms.Button btn_Close;
    }
}