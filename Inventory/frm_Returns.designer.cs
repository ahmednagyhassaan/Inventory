namespace Inventory
{
    partial class frm_Returns
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
            this.dgv_Itm_Returned = new System.Windows.Forms.DataGridView();
            this.cbo_Created_By = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Inv_No = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_Created_At = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Return_no = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_Store = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Customer = new System.Windows.Forms.TextBox();
            this.cbo_Itm_Name = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Qty_Big_Unit = new System.Windows.Forms.TextBox();
            this.btn_Add_Itm = new System.Windows.Forms.Button();
            this.btn_Del_Itm = new System.Windows.Forms.Button();
            this.gbo_Add_Itm = new System.Windows.Forms.GroupBox();
            this.lbl_Small_Unit = new System.Windows.Forms.Label();
            this.lbl_Big_Unit = new System.Windows.Forms.Label();
            this.txt_Qty_Small_Unit = new System.Windows.Forms.TextBox();
            this.lbl_Exist_Invoice = new System.Windows.Forms.Label();
            this.btn_Load_items = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Itm_Returned)).BeginInit();
            this.gbo_Add_Itm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Itm_Returned
            // 
            this.dgv_Itm_Returned.AllowUserToAddRows = false;
            this.dgv_Itm_Returned.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Itm_Returned.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Itm_Returned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Itm_Returned.Location = new System.Drawing.Point(21, 301);
            this.dgv_Itm_Returned.Name = "dgv_Itm_Returned";
            this.dgv_Itm_Returned.ReadOnly = true;
            this.dgv_Itm_Returned.Size = new System.Drawing.Size(654, 273);
            this.dgv_Itm_Returned.TabIndex = 32;
            this.dgv_Itm_Returned.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Itm_Returned_CellContentClick);
            // 
            // cbo_Created_By
            // 
            this.cbo_Created_By.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Created_By.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Created_By.FormattingEnabled = true;
            this.cbo_Created_By.Location = new System.Drawing.Point(512, 117);
            this.cbo_Created_By.Name = "cbo_Created_By";
            this.cbo_Created_By.Size = new System.Drawing.Size(158, 24);
            this.cbo_Created_By.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Created At:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Created By:";
            // 
            // txt_Inv_No
            // 
            this.txt_Inv_No.Location = new System.Drawing.Point(119, 73);
            this.txt_Inv_No.Multiline = true;
            this.txt_Inv_No.Name = "txt_Inv_No";
            this.txt_Inv_No.Size = new System.Drawing.Size(152, 23);
            this.txt_Inv_No.TabIndex = 21;
            this.txt_Inv_No.TextChanged += new System.EventHandler(this.txt_Inv_No_TextChanged);
            this.txt_Inv_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Inv_No_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Invoice No:";
            // 
            // dtp_Created_At
            // 
            this.dtp_Created_At.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Created_At.Location = new System.Drawing.Point(512, 154);
            this.dtp_Created_At.Name = "dtp_Created_At";
            this.dtp_Created_At.Size = new System.Drawing.Size(158, 23);
            this.dtp_Created_At.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Notes:";
            // 
            // txt_Notes
            // 
            this.txt_Notes.Location = new System.Drawing.Point(512, 190);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(158, 69);
            this.txt_Notes.TabIndex = 39;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel.Location = new System.Drawing.Point(586, 580);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(89, 29);
            this.btn_Cancel.TabIndex = 55;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Location = new System.Drawing.Point(480, 580);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(89, 29);
            this.btn_Save.TabIndex = 54;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 122;
            this.label6.Text = "Return num :";
            // 
            // txt_Return_no
            // 
            this.txt_Return_no.Location = new System.Drawing.Point(119, 42);
            this.txt_Return_no.Name = "txt_Return_no";
            this.txt_Return_no.Size = new System.Drawing.Size(152, 23);
            this.txt_Return_no.TabIndex = 123;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 124;
            this.label8.Text = "Returns Store:";
            // 
            // cbo_Store
            // 
            this.cbo_Store.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Store.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Store.FormattingEnabled = true;
            this.cbo_Store.Location = new System.Drawing.Point(512, 80);
            this.cbo_Store.Name = "cbo_Store";
            this.cbo_Store.Size = new System.Drawing.Size(158, 24);
            this.cbo_Store.TabIndex = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(419, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 126;
            this.label9.Text = "Customer:";
            // 
            // txt_Customer
            // 
            this.txt_Customer.Enabled = false;
            this.txt_Customer.Location = new System.Drawing.Point(512, 44);
            this.txt_Customer.Name = "txt_Customer";
            this.txt_Customer.Size = new System.Drawing.Size(158, 23);
            this.txt_Customer.TabIndex = 127;
            this.txt_Customer.TextChanged += new System.EventHandler(this.txt_Customer_TextChanged);
            // 
            // cbo_Itm_Name
            // 
            this.cbo_Itm_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Itm_Name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Itm_Name.FormattingEnabled = true;
            this.cbo_Itm_Name.Location = new System.Drawing.Point(102, 27);
            this.cbo_Itm_Name.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_Itm_Name.Name = "cbo_Itm_Name";
            this.cbo_Itm_Name.Size = new System.Drawing.Size(152, 24);
            this.cbo_Itm_Name.TabIndex = 45;
            this.cbo_Itm_Name.SelectedIndexChanged += new System.EventHandler(this.cbo_Itm_Name_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Quantity:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 30);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 16);
            this.label14.TabIndex = 44;
            this.label14.Text = "Item Name:";
            // 
            // txt_Qty_Big_Unit
            // 
            this.txt_Qty_Big_Unit.Enabled = false;
            this.txt_Qty_Big_Unit.Location = new System.Drawing.Point(79, 81);
            this.txt_Qty_Big_Unit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Qty_Big_Unit.Multiline = true;
            this.txt_Qty_Big_Unit.Name = "txt_Qty_Big_Unit";
            this.txt_Qty_Big_Unit.Size = new System.Drawing.Size(83, 23);
            this.txt_Qty_Big_Unit.TabIndex = 51;
            this.txt_Qty_Big_Unit.TextChanged += new System.EventHandler(this.txt_Qty_TextChanged);
            this.txt_Qty_Big_Unit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Qty_Big_Unit_KeyPress);
            // 
            // btn_Add_Itm
            // 
            this.btn_Add_Itm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add_Itm.Location = new System.Drawing.Point(283, 22);
            this.btn_Add_Itm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Add_Itm.Name = "btn_Add_Itm";
            this.btn_Add_Itm.Size = new System.Drawing.Size(66, 24);
            this.btn_Add_Itm.TabIndex = 56;
            this.btn_Add_Itm.Text = "Add";
            this.btn_Add_Itm.UseVisualStyleBackColor = true;
            this.btn_Add_Itm.Click += new System.EventHandler(this.btn_Add_Itm_Click);
            // 
            // btn_Del_Itm
            // 
            this.btn_Del_Itm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Del_Itm.Location = new System.Drawing.Point(283, 54);
            this.btn_Del_Itm.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Del_Itm.Name = "btn_Del_Itm";
            this.btn_Del_Itm.Size = new System.Drawing.Size(66, 24);
            this.btn_Del_Itm.TabIndex = 57;
            this.btn_Del_Itm.Text = "Delete";
            this.btn_Del_Itm.UseVisualStyleBackColor = true;
            this.btn_Del_Itm.Click += new System.EventHandler(this.btn_Del_Itm_Click);
            // 
            // gbo_Add_Itm
            // 
            this.gbo_Add_Itm.Controls.Add(this.lbl_Small_Unit);
            this.gbo_Add_Itm.Controls.Add(this.lbl_Big_Unit);
            this.gbo_Add_Itm.Controls.Add(this.txt_Qty_Small_Unit);
            this.gbo_Add_Itm.Controls.Add(this.btn_Del_Itm);
            this.gbo_Add_Itm.Controls.Add(this.btn_Add_Itm);
            this.gbo_Add_Itm.Controls.Add(this.txt_Qty_Big_Unit);
            this.gbo_Add_Itm.Controls.Add(this.label14);
            this.gbo_Add_Itm.Controls.Add(this.label5);
            this.gbo_Add_Itm.Controls.Add(this.cbo_Itm_Name);
            this.gbo_Add_Itm.Enabled = false;
            this.gbo_Add_Itm.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_Add_Itm.Location = new System.Drawing.Point(21, 164);
            this.gbo_Add_Itm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbo_Add_Itm.Name = "gbo_Add_Itm";
            this.gbo_Add_Itm.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbo_Add_Itm.Size = new System.Drawing.Size(376, 131);
            this.gbo_Add_Itm.TabIndex = 53;
            this.gbo_Add_Itm.TabStop = false;
            this.gbo_Add_Itm.Text = "Add Item";
            // 
            // lbl_Small_Unit
            // 
            this.lbl_Small_Unit.AutoSize = true;
            this.lbl_Small_Unit.Location = new System.Drawing.Point(179, 62);
            this.lbl_Small_Unit.Name = "lbl_Small_Unit";
            this.lbl_Small_Unit.Size = new System.Drawing.Size(83, 16);
            this.lbl_Small_Unit.TabIndex = 60;
            this.lbl_Small_Unit.Text = "Smallest Unit";
            // 
            // lbl_Big_Unit
            // 
            this.lbl_Big_Unit.AutoSize = true;
            this.lbl_Big_Unit.Location = new System.Drawing.Point(82, 62);
            this.lbl_Big_Unit.Name = "lbl_Big_Unit";
            this.lbl_Big_Unit.Size = new System.Drawing.Size(75, 16);
            this.lbl_Big_Unit.TabIndex = 59;
            this.lbl_Big_Unit.Text = "Biggest Unit";
            // 
            // txt_Qty_Small_Unit
            // 
            this.txt_Qty_Small_Unit.Enabled = false;
            this.txt_Qty_Small_Unit.Location = new System.Drawing.Point(179, 81);
            this.txt_Qty_Small_Unit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Qty_Small_Unit.Multiline = true;
            this.txt_Qty_Small_Unit.Name = "txt_Qty_Small_Unit";
            this.txt_Qty_Small_Unit.Size = new System.Drawing.Size(83, 23);
            this.txt_Qty_Small_Unit.TabIndex = 58;
            this.txt_Qty_Small_Unit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Qty_Small_Unit_KeyPress);
            // 
            // lbl_Exist_Invoice
            // 
            this.lbl_Exist_Invoice.AutoSize = true;
            this.lbl_Exist_Invoice.Location = new System.Drawing.Point(277, 76);
            this.lbl_Exist_Invoice.Name = "lbl_Exist_Invoice";
            this.lbl_Exist_Invoice.Size = new System.Drawing.Size(0, 16);
            this.lbl_Exist_Invoice.TabIndex = 128;
            // 
            // btn_Load_items
            // 
            this.btn_Load_items.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Load_items.Location = new System.Drawing.Point(119, 113);
            this.btn_Load_items.Name = "btn_Load_items";
            this.btn_Load_items.Size = new System.Drawing.Size(152, 29);
            this.btn_Load_items.TabIndex = 129;
            this.btn_Load_items.Text = "Load items";
            this.btn_Load_items.UseVisualStyleBackColor = true;
            this.btn_Load_items.Click += new System.EventHandler(this.btn_Load_items_Click);
            // 
            // frm_Returns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(694, 638);
            this.Controls.Add(this.btn_Load_items);
            this.Controls.Add(this.lbl_Exist_Invoice);
            this.Controls.Add(this.txt_Customer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbo_Store);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Return_no);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gbo_Add_Itm);
            this.Controls.Add(this.txt_Notes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_Created_At);
            this.Controls.Add(this.dgv_Itm_Returned);
            this.Controls.Add(this.cbo_Created_By);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Inv_No);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frm_Returns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Returns";
            this.Load += new System.EventHandler(this.frm_Returns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Itm_Returned)).EndInit();
            this.gbo_Add_Itm.ResumeLayout(false);
            this.gbo_Add_Itm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Itm_Returned;
        private System.Windows.Forms.ComboBox cbo_Created_By;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Inv_No;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_Created_At;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Return_no;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_Store;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Customer;
        private System.Windows.Forms.ComboBox cbo_Itm_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Qty_Big_Unit;
        private System.Windows.Forms.Button btn_Add_Itm;
        private System.Windows.Forms.Button btn_Del_Itm;
        private System.Windows.Forms.GroupBox gbo_Add_Itm;
        private System.Windows.Forms.Label lbl_Exist_Invoice;
        private System.Windows.Forms.Button btn_Load_items;
        private System.Windows.Forms.Label lbl_Small_Unit;
        private System.Windows.Forms.Label lbl_Big_Unit;
        private System.Windows.Forms.TextBox txt_Qty_Small_Unit;
    }
}