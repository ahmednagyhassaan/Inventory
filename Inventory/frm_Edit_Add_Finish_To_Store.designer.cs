namespace Inventory
{
    partial class frm_Edit_Add_Finish_To_Store
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
            this.components = new System.ComponentModel.Container();
            this.cbo_Stock_Name = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_Created_At = new System.Windows.Forms.DateTimePicker();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Small_Unit = new System.Windows.Forms.Label();
            this.lbl_Big_Unit = new System.Windows.Forms.Label();
            this.txt_Qty_Small_Unit = new System.Windows.Forms.TextBox();
            this.txt_Qty_Big_Unit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.cbo_Created_By = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Add_No = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Del_Itm = new System.Windows.Forms.Button();
            this.btn_Add_Itm = new System.Windows.Forms.Button();
            this.txt_Itm_No = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbo_Itm_Name = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbo_Add_Itm = new System.Windows.Forms.GroupBox();
            this.dgv_Itm_Returned = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.cbo_Itm_Cat = new System.Windows.Forms.ComboBox();
            this.Btn_AddDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.gbo_Add_Itm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Itm_Returned)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_Stock_Name
            // 
            this.cbo_Stock_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_Stock_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_Stock_Name.FormattingEnabled = true;
            this.cbo_Stock_Name.Location = new System.Drawing.Point(136, 73);
            this.cbo_Stock_Name.Name = "cbo_Stock_Name";
            this.cbo_Stock_Name.Size = new System.Drawing.Size(152, 21);
            this.cbo_Stock_Name.TabIndex = 82;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 504);
            this.splitter1.TabIndex = 80;
            this.splitter1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "Notes:";
            // 
            // dtp_Created_At
            // 
            this.dtp_Created_At.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Created_At.Location = new System.Drawing.Point(136, 104);
            this.dtp_Created_At.Name = "dtp_Created_At";
            this.dtp_Created_At.Size = new System.Drawing.Size(152, 20);
            this.dtp_Created_At.TabIndex = 76;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(302, 99);
            this.txt_Price.Multiline = true;
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(74, 23);
            this.txt_Price.TabIndex = 67;
            this.txt_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Price_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 66;
            this.label6.Text = "Unit Price";
            // 
            // lbl_Small_Unit
            // 
            this.lbl_Small_Unit.AutoSize = true;
            this.lbl_Small_Unit.Location = new System.Drawing.Point(198, 79);
            this.lbl_Small_Unit.Name = "lbl_Small_Unit";
            this.lbl_Small_Unit.Size = new System.Drawing.Size(83, 16);
            this.lbl_Small_Unit.TabIndex = 65;
            this.lbl_Small_Unit.Text = "Smallest Unit";
            // 
            // lbl_Big_Unit
            // 
            this.lbl_Big_Unit.AutoSize = true;
            this.lbl_Big_Unit.Location = new System.Drawing.Point(106, 79);
            this.lbl_Big_Unit.Name = "lbl_Big_Unit";
            this.lbl_Big_Unit.Size = new System.Drawing.Size(75, 16);
            this.lbl_Big_Unit.TabIndex = 64;
            this.lbl_Big_Unit.Text = "Biggest Unit";
            // 
            // txt_Qty_Small_Unit
            // 
            this.txt_Qty_Small_Unit.Location = new System.Drawing.Point(198, 101);
            this.txt_Qty_Small_Unit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Qty_Small_Unit.Multiline = true;
            this.txt_Qty_Small_Unit.Name = "txt_Qty_Small_Unit";
            this.txt_Qty_Small_Unit.Size = new System.Drawing.Size(83, 23);
            this.txt_Qty_Small_Unit.TabIndex = 63;
            this.txt_Qty_Small_Unit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Qty_Small_Unit_KeyPress);
            // 
            // txt_Qty_Big_Unit
            // 
            this.txt_Qty_Big_Unit.Location = new System.Drawing.Point(102, 101);
            this.txt_Qty_Big_Unit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Qty_Big_Unit.Multiline = true;
            this.txt_Qty_Big_Unit.Name = "txt_Qty_Big_Unit";
            this.txt_Qty_Big_Unit.Size = new System.Drawing.Size(83, 23);
            this.txt_Qty_Big_Unit.TabIndex = 62;
            this.txt_Qty_Big_Unit.TextChanged += new System.EventHandler(this.txt_Qty_Big_Unit_TextChanged);
            this.txt_Qty_Big_Unit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Qty_Big_Unit_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 61;
            this.label5.Text = "Quantity:";
            // 
            // txt_Notes
            // 
            this.txt_Notes.Location = new System.Drawing.Point(350, 12);
            this.txt_Notes.MaxLength = 100;
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(171, 95);
            this.txt_Notes.TabIndex = 78;
            // 
            // cbo_Created_By
            // 
            this.cbo_Created_By.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_Created_By.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_Created_By.FormattingEnabled = true;
            this.cbo_Created_By.Location = new System.Drawing.Point(136, 43);
            this.cbo_Created_By.Name = "cbo_Created_By";
            this.cbo_Created_By.Size = new System.Drawing.Size(152, 21);
            this.cbo_Created_By.TabIndex = 75;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Created At:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Created By:";
            // 
            // txt_Add_No
            // 
            this.txt_Add_No.Location = new System.Drawing.Point(136, 13);
            this.txt_Add_No.MaxLength = 100;
            this.txt_Add_No.Name = "txt_Add_No";
            this.txt_Add_No.Size = new System.Drawing.Size(152, 20);
            this.txt_Add_No.TabIndex = 72;
            this.txt_Add_No.TextChanged += new System.EventHandler(this.txt_Add_No_TextChanged);
            this.txt_Add_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Add_No_KeyPress);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel.Location = new System.Drawing.Point(607, 304);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(89, 29);
            this.btn_Cancel.TabIndex = 70;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Location = new System.Drawing.Point(510, 304);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(89, 29);
            this.btn_Save.TabIndex = 69;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Add No:";
            // 
            // btn_Del_Itm
            // 
            this.btn_Del_Itm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Del_Itm.Location = new System.Drawing.Point(507, 101);
            this.btn_Del_Itm.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Del_Itm.Name = "btn_Del_Itm";
            this.btn_Del_Itm.Size = new System.Drawing.Size(118, 24);
            this.btn_Del_Itm.TabIndex = 57;
            this.btn_Del_Itm.Text = "Delete";
            this.btn_Del_Itm.UseVisualStyleBackColor = true;
            this.btn_Del_Itm.Click += new System.EventHandler(this.btn_Del_Itm_Click);
            // 
            // btn_Add_Itm
            // 
            this.btn_Add_Itm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add_Itm.Location = new System.Drawing.Point(507, 71);
            this.btn_Add_Itm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Add_Itm.Name = "btn_Add_Itm";
            this.btn_Add_Itm.Size = new System.Drawing.Size(118, 24);
            this.btn_Add_Itm.TabIndex = 56;
            this.btn_Add_Itm.Text = "Add";
            this.btn_Add_Itm.UseVisualStyleBackColor = true;
            this.btn_Add_Itm.Click += new System.EventHandler(this.btn_Add_Itm_Click);
            // 
            // txt_Itm_No
            // 
            this.txt_Itm_No.Enabled = false;
            this.txt_Itm_No.Location = new System.Drawing.Point(473, 20);
            this.txt_Itm_No.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Itm_No.MaxLength = 90;
            this.txt_Itm_No.Name = "txt_Itm_No";
            this.txt_Itm_No.Size = new System.Drawing.Size(152, 23);
            this.txt_Itm_No.TabIndex = 53;
            this.txt_Itm_No.TextChanged += new System.EventHandler(this.txt_Itm_No_TextChanged);
            this.txt_Itm_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Itm_No_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 52;
            this.label7.Text = "Item No:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 56);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 16);
            this.label14.TabIndex = 44;
            this.label14.Text = "Item Name:";
            // 
            // cbo_Itm_Name
            // 
            this.cbo_Itm_Name.FormattingEnabled = true;
            this.cbo_Itm_Name.Location = new System.Drawing.Point(109, 53);
            this.cbo_Itm_Name.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_Itm_Name.Name = "cbo_Itm_Name";
            this.cbo_Itm_Name.Size = new System.Drawing.Size(152, 24);
            this.cbo_Itm_Name.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 81;
            this.label8.Text = "Stock Name:";
            // 
            // gbo_Add_Itm
            // 
            this.gbo_Add_Itm.Controls.Add(this.dgv_Itm_Returned);
            this.gbo_Add_Itm.Controls.Add(this.btn_Cancel);
            this.gbo_Add_Itm.Controls.Add(this.btn_Save);
            this.gbo_Add_Itm.Controls.Add(this.txt_Price);
            this.gbo_Add_Itm.Controls.Add(this.label6);
            this.gbo_Add_Itm.Controls.Add(this.lbl_Small_Unit);
            this.gbo_Add_Itm.Controls.Add(this.lbl_Big_Unit);
            this.gbo_Add_Itm.Controls.Add(this.txt_Qty_Small_Unit);
            this.gbo_Add_Itm.Controls.Add(this.txt_Qty_Big_Unit);
            this.gbo_Add_Itm.Controls.Add(this.label5);
            this.gbo_Add_Itm.Controls.Add(this.btn_Del_Itm);
            this.gbo_Add_Itm.Controls.Add(this.btn_Add_Itm);
            this.gbo_Add_Itm.Controls.Add(this.txt_Itm_No);
            this.gbo_Add_Itm.Controls.Add(this.label7);
            this.gbo_Add_Itm.Controls.Add(this.label15);
            this.gbo_Add_Itm.Controls.Add(this.label14);
            this.gbo_Add_Itm.Controls.Add(this.cbo_Itm_Name);
            this.gbo_Add_Itm.Controls.Add(this.cbo_Itm_Cat);
            this.gbo_Add_Itm.Enabled = false;
            this.gbo_Add_Itm.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_Add_Itm.Location = new System.Drawing.Point(41, 141);
            this.gbo_Add_Itm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbo_Add_Itm.Name = "gbo_Add_Itm";
            this.gbo_Add_Itm.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbo_Add_Itm.Size = new System.Drawing.Size(700, 351);
            this.gbo_Add_Itm.TabIndex = 79;
            this.gbo_Add_Itm.TabStop = false;
            this.gbo_Add_Itm.Text = "Add Item";
            // 
            // dgv_Itm_Returned
            // 
            this.dgv_Itm_Returned.AllowUserToAddRows = false;
            this.dgv_Itm_Returned.AllowUserToDeleteRows = false;
            this.dgv_Itm_Returned.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Itm_Returned.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Itm_Returned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Itm_Returned.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column7,
            this.Column4});
            this.dgv_Itm_Returned.Location = new System.Drawing.Point(0, 130);
            this.dgv_Itm_Returned.Name = "dgv_Itm_Returned";
            this.dgv_Itm_Returned.ReadOnly = true;
            this.dgv_Itm_Returned.Size = new System.Drawing.Size(702, 168);
            this.dgv_Itm_Returned.TabIndex = 95;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item No.";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Item name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Qty";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Price";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Add Finish ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 19);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 16);
            this.label15.TabIndex = 47;
            this.label15.Text = "Item Category:";
            // 
            // cbo_Itm_Cat
            // 
            this.cbo_Itm_Cat.FormattingEnabled = true;
            this.cbo_Itm_Cat.Location = new System.Drawing.Point(109, 19);
            this.cbo_Itm_Cat.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_Itm_Cat.Name = "cbo_Itm_Cat";
            this.cbo_Itm_Cat.Size = new System.Drawing.Size(152, 24);
            this.cbo_Itm_Cat.TabIndex = 48;
            this.cbo_Itm_Cat.SelectedIndexChanged += new System.EventHandler(this.cbo_Itm_Cat_SelectedIndexChanged);
            // 
            // Btn_AddDetails
            // 
            this.Btn_AddDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_AddDetails.Location = new System.Drawing.Point(350, 113);
            this.Btn_AddDetails.Name = "Btn_AddDetails";
            this.Btn_AddDetails.Size = new System.Drawing.Size(171, 23);
            this.Btn_AddDetails.TabIndex = 92;
            this.Btn_AddDetails.Text = "Details";
            this.Btn_AddDetails.UseVisualStyleBackColor = true;
            this.Btn_AddDetails.Click += new System.EventHandler(this.Btn_AddDetails_Click);
            // 
            // frm_Edit_Add_Finish_To_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(761, 504);
            this.Controls.Add(this.Btn_AddDetails);
            this.Controls.Add(this.cbo_Stock_Name);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_Created_At);
            this.Controls.Add(this.txt_Notes);
            this.Controls.Add(this.cbo_Created_By);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Add_No);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbo_Add_Itm);
            this.MaximizeBox = false;
            this.Name = "frm_Edit_Add_Finish_To_Store";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit_Finish_Product";
            this.Load += new System.EventHandler(this.frm_Edit_Finish_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.gbo_Add_Itm.ResumeLayout(false);
            this.gbo_Add_Itm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Itm_Returned)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_Stock_Name;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_Created_At;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Small_Unit;
        private System.Windows.Forms.Label lbl_Big_Unit;
        private System.Windows.Forms.TextBox txt_Qty_Small_Unit;
        private System.Windows.Forms.TextBox txt_Qty_Big_Unit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.ComboBox cbo_Created_By;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        //private ProjectDataSet projectDataSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Add_No;
        //private ProjectDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Del_Itm;
        private System.Windows.Forms.Button btn_Add_Itm;
        private System.Windows.Forms.TextBox txt_Itm_No;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbo_Itm_Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbo_Add_Itm;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbo_Itm_Cat;
        private System.Windows.Forms.Button Btn_AddDetails;
        private System.Windows.Forms.DataGridView dgv_Itm_Returned;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}