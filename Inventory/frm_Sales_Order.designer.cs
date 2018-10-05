namespace Inventory
{
    partial class frm_Sales_Order
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
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.dgv_sales_Ord = new System.Windows.Forms.DataGridView();
            this.btn_Del_Itm = new System.Windows.Forms.Button();
            this.btn_Add_Itm = new System.Windows.Forms.Button();
            this.txt_Itm_No = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_Qty = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbo_Itm_Name = new System.Windows.Forms.ComboBox();
            this.cbo_Itm_Cat = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gbo_Add_Itm = new System.Windows.Forms.GroupBox();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_Cust_Name = new System.Windows.Forms.ComboBox();
            this.btn_Add_Supp = new System.Windows.Forms.Button();
            this.dtp_Ord_Date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Ord_No = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_Created_By = new System.Windows.Forms.ComboBox();
            this.lbl_Created_By = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales_Ord)).BeginInit();
            this.gbo_Add_Itm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Print
            // 
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Print.Location = new System.Drawing.Point(367, 557);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(89, 29);
            this.btn_Print.TabIndex = 134;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel.Location = new System.Drawing.Point(558, 557);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(89, 29);
            this.btn_Cancel.TabIndex = 133;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // dgv_sales_Ord
            // 
            this.dgv_sales_Ord.BackgroundColor = System.Drawing.Color.White;
            this.dgv_sales_Ord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sales_Ord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_sales_Ord.Location = new System.Drawing.Point(19, 308);
            this.dgv_sales_Ord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_sales_Ord.Name = "dgv_sales_Ord";
            this.dgv_sales_Ord.RowTemplate.Height = 26;
            this.dgv_sales_Ord.Size = new System.Drawing.Size(437, 184);
            this.dgv_sales_Ord.TabIndex = 131;
            // 
            // btn_Del_Itm
            // 
            this.btn_Del_Itm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Del_Itm.Location = new System.Drawing.Point(270, 80);
            this.btn_Del_Itm.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Del_Itm.Name = "btn_Del_Itm";
            this.btn_Del_Itm.Size = new System.Drawing.Size(118, 24);
            this.btn_Del_Itm.TabIndex = 55;
            this.btn_Del_Itm.Text = "Delete";
            this.btn_Del_Itm.UseVisualStyleBackColor = true;
            this.btn_Del_Itm.Click += new System.EventHandler(this.btn_Del_Itm_Click);
            // 
            // btn_Add_Itm
            // 
            this.btn_Add_Itm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add_Itm.Location = new System.Drawing.Point(270, 48);
            this.btn_Add_Itm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Add_Itm.Name = "btn_Add_Itm";
            this.btn_Add_Itm.Size = new System.Drawing.Size(118, 24);
            this.btn_Add_Itm.TabIndex = 54;
            this.btn_Add_Itm.Text = "Add";
            this.btn_Add_Itm.UseVisualStyleBackColor = true;
            this.btn_Add_Itm.Click += new System.EventHandler(this.btn_Add_Itm_Click);
            // 
            // txt_Itm_No
            // 
            this.txt_Itm_No.Location = new System.Drawing.Point(102, 21);
            this.txt_Itm_No.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Itm_No.Name = "txt_Itm_No";
            this.txt_Itm_No.Size = new System.Drawing.Size(152, 23);
            this.txt_Itm_No.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 52;
            this.label6.Text = "Item No:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 51);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 16);
            this.label15.TabIndex = 47;
            this.label15.Text = "Item Category:";
            // 
            // txt_Qty
            // 
            this.txt_Qty.Location = new System.Drawing.Point(102, 113);
            this.txt_Qty.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(153, 23);
            this.txt_Qty.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 83);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 16);
            this.label14.TabIndex = 44;
            this.label14.Text = "Item Name:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 116);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 16);
            this.label16.TabIndex = 50;
            this.label16.Text = "Quantity:";
            // 
            // cbo_Itm_Name
            // 
            this.cbo_Itm_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Itm_Name.FormattingEnabled = true;
            this.cbo_Itm_Name.Location = new System.Drawing.Point(102, 80);
            this.cbo_Itm_Name.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_Itm_Name.Name = "cbo_Itm_Name";
            this.cbo_Itm_Name.Size = new System.Drawing.Size(152, 24);
            this.cbo_Itm_Name.TabIndex = 45;
            this.cbo_Itm_Name.SelectedIndexChanged += new System.EventHandler(this.cbo_Itm_Name_SelectedIndexChanged);
            // 
            // cbo_Itm_Cat
            // 
            this.cbo_Itm_Cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Itm_Cat.FormattingEnabled = true;
            this.cbo_Itm_Cat.Location = new System.Drawing.Point(102, 48);
            this.cbo_Itm_Cat.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_Itm_Cat.Name = "cbo_Itm_Cat";
            this.cbo_Itm_Cat.Size = new System.Drawing.Size(152, 24);
            this.cbo_Itm_Cat.TabIndex = 48;
            this.cbo_Itm_Cat.SelectedIndexChanged += new System.EventHandler(this.cbo_Itm_Cat_SelectedIndexChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Location = new System.Drawing.Point(461, 557);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(89, 29);
            this.btn_Save.TabIndex = 132;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // gbo_Add_Itm
            // 
            this.gbo_Add_Itm.Controls.Add(this.btn_Del_Itm);
            this.gbo_Add_Itm.Controls.Add(this.btn_Add_Itm);
            this.gbo_Add_Itm.Controls.Add(this.txt_Itm_No);
            this.gbo_Add_Itm.Controls.Add(this.label6);
            this.gbo_Add_Itm.Controls.Add(this.label15);
            this.gbo_Add_Itm.Controls.Add(this.txt_Qty);
            this.gbo_Add_Itm.Controls.Add(this.label14);
            this.gbo_Add_Itm.Controls.Add(this.label16);
            this.gbo_Add_Itm.Controls.Add(this.cbo_Itm_Name);
            this.gbo_Add_Itm.Controls.Add(this.cbo_Itm_Cat);
            this.gbo_Add_Itm.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_Add_Itm.Location = new System.Drawing.Point(19, 154);
            this.gbo_Add_Itm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbo_Add_Itm.Name = "gbo_Add_Itm";
            this.gbo_Add_Itm.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbo_Add_Itm.Size = new System.Drawing.Size(394, 149);
            this.gbo_Add_Itm.TabIndex = 130;
            this.gbo_Add_Itm.TabStop = false;
            this.gbo_Add_Itm.Text = "n7";
            // 
            // txt_Notes
            // 
            this.txt_Notes.Location = new System.Drawing.Point(476, 17);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(171, 115);
            this.txt_Notes.TabIndex = 129;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 128;
            this.label1.Text = "Notes:";
            // 
            // cbo_Cust_Name
            // 
            this.cbo_Cust_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Cust_Name.FormattingEnabled = true;
            this.cbo_Cust_Name.Location = new System.Drawing.Point(120, 35);
            this.cbo_Cust_Name.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_Cust_Name.Name = "cbo_Cust_Name";
            this.cbo_Cust_Name.Size = new System.Drawing.Size(153, 24);
            this.cbo_Cust_Name.TabIndex = 127;
            // 
            // btn_Add_Supp
            // 
            this.btn_Add_Supp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add_Supp.Location = new System.Drawing.Point(288, 17);
            this.btn_Add_Supp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add_Supp.Name = "btn_Add_Supp";
            this.btn_Add_Supp.Size = new System.Drawing.Size(134, 24);
            this.btn_Add_Supp.TabIndex = 126;
            this.btn_Add_Supp.Text = "Add New Customer";
            this.btn_Add_Supp.UseVisualStyleBackColor = true;
            // 
            // dtp_Ord_Date
            // 
            this.dtp_Ord_Date.Location = new System.Drawing.Point(120, 76);
            this.dtp_Ord_Date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_Ord_Date.Name = "dtp_Ord_Date";
            this.dtp_Ord_Date.Size = new System.Drawing.Size(152, 23);
            this.dtp_Ord_Date.TabIndex = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 124;
            this.label4.Text = "Order Date:";
            // 
            // txt_Ord_No
            // 
            this.txt_Ord_No.Location = new System.Drawing.Point(120, 6);
            this.txt_Ord_No.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Ord_No.Name = "txt_Ord_No";
            this.txt_Ord_No.Size = new System.Drawing.Size(152, 23);
            this.txt_Ord_No.TabIndex = 123;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 122;
            this.label3.Text = "Order No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 121;
            this.label8.Text = "Customer Name:";
            // 
            // cbo_Created_By
            // 
            this.cbo_Created_By.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Created_By.FormattingEnabled = true;
            this.cbo_Created_By.Location = new System.Drawing.Point(120, 510);
            this.cbo_Created_By.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_Created_By.Name = "cbo_Created_By";
            this.cbo_Created_By.Size = new System.Drawing.Size(151, 24);
            this.cbo_Created_By.TabIndex = 120;
            // 
            // lbl_Created_By
            // 
            this.lbl_Created_By.AutoSize = true;
            this.lbl_Created_By.Location = new System.Drawing.Point(15, 513);
            this.lbl_Created_By.Name = "lbl_Created_By";
            this.lbl_Created_By.Size = new System.Drawing.Size(79, 16);
            this.lbl_Created_By.TabIndex = 119;
            this.lbl_Created_By.Text = "Created By :";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ItemNo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ItemCategory";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ItemName";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            // 
            // frm_Sales_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(663, 602);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.dgv_sales_Ord);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gbo_Add_Itm);
            this.Controls.Add(this.txt_Notes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_Cust_Name);
            this.Controls.Add(this.btn_Add_Supp);
            this.Controls.Add(this.dtp_Ord_Date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Ord_No);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbo_Created_By);
            this.Controls.Add(this.lbl_Created_By);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Sales_Order";
            this.Text = "Sales Order";
            this.Load += new System.EventHandler(this.Orders__Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales_Ord)).EndInit();
            this.gbo_Add_Itm.ResumeLayout(false);
            this.gbo_Add_Itm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.DataGridView dgv_sales_Ord;
        private System.Windows.Forms.Button btn_Del_Itm;
        private System.Windows.Forms.Button btn_Add_Itm;
        private System.Windows.Forms.TextBox txt_Itm_No;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_Qty;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbo_Itm_Name;
        private System.Windows.Forms.ComboBox cbo_Itm_Cat;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox gbo_Add_Itm;
        private System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_Cust_Name;
        private System.Windows.Forms.Button btn_Add_Supp;
        private System.Windows.Forms.DateTimePicker dtp_Ord_Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Ord_No;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_Created_By;
        private System.Windows.Forms.Label lbl_Created_By;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;

    }
}