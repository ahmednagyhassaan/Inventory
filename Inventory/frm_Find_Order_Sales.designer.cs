namespace Inventory
{
    partial class frm_Find_Order_Sales
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
            this.dgv_search = new System.Windows.Forms.DataGridView();
            this.btn_New_ord = new System.Windows.Forms.Button();
            this.btn_View_Edit_ord = new System.Windows.Forms.Button();
            this.btn_Delete_ord = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gbo_Search_By = new System.Windows.Forms.GroupBox();
            this.cbo_employee = new System.Windows.Forms.ComboBox();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Item_Category = new System.Windows.Forms.Label();
            this.lbl_Item_No = new System.Windows.Forms.Label();
            this.lbl_To = new System.Windows.Forms.Label();
            this.lbl_From = new System.Windows.Forms.Label();
            this.dtp_Inv_Date_To = new System.Windows.Forms.DateTimePicker();
            this.cbo_CUST_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Invoice_Date = new System.Windows.Forms.Label();
            this.txt_ord_No = new System.Windows.Forms.TextBox();
            this.lbl_Supplier_Name = new System.Windows.Forms.Label();
            this.lbl_Invoice_No = new System.Windows.Forms.Label();
            this.dtp_Inv_Date_From = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_Way_Of_Search = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).BeginInit();
            this.gbo_Search_By.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_search
            // 
            this.dgv_search.BackgroundColor = System.Drawing.Color.White;
            this.dgv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_search.Location = new System.Drawing.Point(20, 291);
            this.dgv_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_search.Name = "dgv_search";
            this.dgv_search.RowTemplate.Height = 26;
            this.dgv_search.Size = new System.Drawing.Size(637, 246);
            this.dgv_search.TabIndex = 4;
            // 
            // btn_New_ord
            // 
            this.btn_New_ord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_New_ord.Location = new System.Drawing.Point(198, 547);
            this.btn_New_ord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_New_ord.Name = "btn_New_ord";
            this.btn_New_ord.Size = new System.Drawing.Size(119, 38);
            this.btn_New_ord.TabIndex = 6;
            this.btn_New_ord.Text = "New Order";
            this.btn_New_ord.UseVisualStyleBackColor = true;
            this.btn_New_ord.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_View_Edit_ord
            // 
            this.btn_View_Edit_ord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_View_Edit_ord.Location = new System.Drawing.Point(323, 547);
            this.btn_View_Edit_ord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_View_Edit_ord.Name = "btn_View_Edit_ord";
            this.btn_View_Edit_ord.Size = new System.Drawing.Size(119, 38);
            this.btn_View_Edit_ord.TabIndex = 7;
            this.btn_View_Edit_ord.Text = "View/EditOrder";
            this.btn_View_Edit_ord.UseVisualStyleBackColor = true;
            this.btn_View_Edit_ord.Click += new System.EventHandler(this.btn_View_Edit_ord_Click);
            // 
            // btn_Delete_ord
            // 
            this.btn_Delete_ord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete_ord.Location = new System.Drawing.Point(448, 547);
            this.btn_Delete_ord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete_ord.Name = "btn_Delete_ord";
            this.btn_Delete_ord.Size = new System.Drawing.Size(119, 38);
            this.btn_Delete_ord.TabIndex = 8;
            this.btn_Delete_ord.Text = "Delete Order";
            this.btn_Delete_ord.UseVisualStyleBackColor = true;
            this.btn_Delete_ord.Visible = false;
            this.btn_Delete_ord.Click += new System.EventHandler(this.btn_Delete_ord_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 13;
            // 
            // gbo_Search_By
            // 
            this.gbo_Search_By.Controls.Add(this.cbo_employee);
            this.gbo_Search_By.Controls.Add(this.txt_note);
            this.gbo_Search_By.Controls.Add(this.btn_Search);
            this.gbo_Search_By.Controls.Add(this.lbl_Item_Category);
            this.gbo_Search_By.Controls.Add(this.lbl_Item_No);
            this.gbo_Search_By.Controls.Add(this.lbl_To);
            this.gbo_Search_By.Controls.Add(this.lbl_From);
            this.gbo_Search_By.Controls.Add(this.dtp_Inv_Date_To);
            this.gbo_Search_By.Controls.Add(this.cbo_CUST_Name);
            this.gbo_Search_By.Controls.Add(this.lbl_Invoice_Date);
            this.gbo_Search_By.Controls.Add(this.txt_ord_No);
            this.gbo_Search_By.Controls.Add(this.lbl_Supplier_Name);
            this.gbo_Search_By.Controls.Add(this.lbl_Invoice_No);
            this.gbo_Search_By.Controls.Add(this.dtp_Inv_Date_From);
            this.gbo_Search_By.Enabled = false;
            this.gbo_Search_By.Location = new System.Drawing.Point(17, 64);
            this.gbo_Search_By.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbo_Search_By.Name = "gbo_Search_By";
            this.gbo_Search_By.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbo_Search_By.Size = new System.Drawing.Size(637, 221);
            this.gbo_Search_By.TabIndex = 14;
            this.gbo_Search_By.TabStop = false;
            this.gbo_Search_By.Text = "Search By";
            this.gbo_Search_By.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbo_employee
            // 
            this.cbo_employee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_employee.FormattingEnabled = true;
            this.cbo_employee.Location = new System.Drawing.Point(128, 72);
            this.cbo_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_employee.Name = "cbo_employee";
            this.cbo_employee.Size = new System.Drawing.Size(157, 24);
            this.cbo_employee.TabIndex = 69;
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(128, 106);
            this.txt_note.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_note.Multiline = true;
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(157, 96);
            this.txt_note.TabIndex = 68;
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Search.Location = new System.Drawing.Point(502, 174);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(87, 28);
            this.btn_Search.TabIndex = 67;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_Item_Category
            // 
            this.lbl_Item_Category.AutoSize = true;
            this.lbl_Item_Category.Location = new System.Drawing.Point(16, 106);
            this.lbl_Item_Category.Name = "lbl_Item_Category";
            this.lbl_Item_Category.Size = new System.Drawing.Size(40, 16);
            this.lbl_Item_Category.TabIndex = 66;
            this.lbl_Item_Category.Text = "Notes";
            // 
            // lbl_Item_No
            // 
            this.lbl_Item_No.AutoSize = true;
            this.lbl_Item_No.Location = new System.Drawing.Point(16, 70);
            this.lbl_Item_No.Name = "lbl_Item_No";
            this.lbl_Item_No.Size = new System.Drawing.Size(105, 16);
            this.lbl_Item_No.TabIndex = 61;
            this.lbl_Item_No.Text = "Employee Name:";
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Location = new System.Drawing.Point(395, 72);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(32, 16);
            this.lbl_To.TabIndex = 60;
            this.lbl_To.Text = "To :";
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Location = new System.Drawing.Point(395, 36);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(47, 16);
            this.lbl_From.TabIndex = 59;
            this.lbl_From.Text = "From :";
            // 
            // dtp_Inv_Date_To
            // 
            this.dtp_Inv_Date_To.Location = new System.Drawing.Point(454, 67);
            this.dtp_Inv_Date_To.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_Inv_Date_To.Name = "dtp_Inv_Date_To";
            this.dtp_Inv_Date_To.Size = new System.Drawing.Size(154, 23);
            this.dtp_Inv_Date_To.TabIndex = 58;
            // 
            // cbo_CUST_Name
            // 
            this.cbo_CUST_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_CUST_Name.FormattingEnabled = true;
            this.cbo_CUST_Name.Location = new System.Drawing.Point(128, 33);
            this.cbo_CUST_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_CUST_Name.Name = "cbo_CUST_Name";
            this.cbo_CUST_Name.Size = new System.Drawing.Size(157, 24);
            this.cbo_CUST_Name.TabIndex = 54;
            // 
            // lbl_Invoice_Date
            // 
            this.lbl_Invoice_Date.AutoSize = true;
            this.lbl_Invoice_Date.Location = new System.Drawing.Point(305, 36);
            this.lbl_Invoice_Date.Name = "lbl_Invoice_Date";
            this.lbl_Invoice_Date.Size = new System.Drawing.Size(76, 16);
            this.lbl_Invoice_Date.TabIndex = 44;
            this.lbl_Invoice_Date.Text = "Order Date:";
            // 
            // txt_ord_No
            // 
            this.txt_ord_No.Location = new System.Drawing.Point(454, 103);
            this.txt_ord_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ord_No.Name = "txt_ord_No";
            this.txt_ord_No.Size = new System.Drawing.Size(154, 23);
            this.txt_ord_No.TabIndex = 50;
            // 
            // lbl_Supplier_Name
            // 
            this.lbl_Supplier_Name.AutoSize = true;
            this.lbl_Supplier_Name.Location = new System.Drawing.Point(16, 36);
            this.lbl_Supplier_Name.Name = "lbl_Supplier_Name";
            this.lbl_Supplier_Name.Size = new System.Drawing.Size(105, 16);
            this.lbl_Supplier_Name.TabIndex = 47;
            this.lbl_Supplier_Name.Text = "Customer Name:";
            // 
            // lbl_Invoice_No
            // 
            this.lbl_Invoice_No.AutoSize = true;
            this.lbl_Invoice_No.Location = new System.Drawing.Point(305, 106);
            this.lbl_Invoice_No.Name = "lbl_Invoice_No";
            this.lbl_Invoice_No.Size = new System.Drawing.Size(65, 16);
            this.lbl_Invoice_No.TabIndex = 46;
            this.lbl_Invoice_No.Text = "Order No:";
            // 
            // dtp_Inv_Date_From
            // 
            this.dtp_Inv_Date_From.Location = new System.Drawing.Point(454, 31);
            this.dtp_Inv_Date_From.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_Inv_Date_From.Name = "dtp_Inv_Date_From";
            this.dtp_Inv_Date_From.Size = new System.Drawing.Size(154, 23);
            this.dtp_Inv_Date_From.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "The Way Of Search:";
            // 
            // cbo_Way_Of_Search
            // 
            this.cbo_Way_Of_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Way_Of_Search.Items.AddRange(new object[] {
            "All",
            "Search By"});
            this.cbo_Way_Of_Search.Location = new System.Drawing.Point(145, 21);
            this.cbo_Way_Of_Search.Name = "cbo_Way_Of_Search";
            this.cbo_Way_Of_Search.Size = new System.Drawing.Size(157, 24);
            this.cbo_Way_Of_Search.TabIndex = 17;
            this.cbo_Way_Of_Search.SelectedIndexChanged += new System.EventHandler(this.cbo_Way_Of_Search_SelectedIndexChanged);
            this.cbo_Way_Of_Search.SelectedValueChanged += new System.EventHandler(this.cbo_Way_Of_Search_SelectedValueChanged);
            // 
            // frm_Find_Order_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(669, 596);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_Way_Of_Search);
            this.Controls.Add(this.gbo_Search_By);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Delete_ord);
            this.Controls.Add(this.btn_View_Edit_ord);
            this.Controls.Add(this.btn_New_ord);
            this.Controls.Add(this.dgv_search);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Find_Order_Sales";
            this.Text = "frm_Find_Order_Sales";
            this.Load += new System.EventHandler(this.Frm_Find_Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).EndInit();
            this.gbo_Search_By.ResumeLayout(false);
            this.gbo_Search_By.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_search;
        private System.Windows.Forms.Button btn_New_ord;
        private System.Windows.Forms.Button btn_View_Edit_ord;
        private System.Windows.Forms.Button btn_Delete_ord;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbo_Search_By;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.DateTimePicker dtp_Inv_Date_To;
        private System.Windows.Forms.ComboBox cbo_CUST_Name;
        private System.Windows.Forms.Label lbl_Invoice_Date;
        private System.Windows.Forms.TextBox txt_ord_No;
        private System.Windows.Forms.Label lbl_Supplier_Name;
        private System.Windows.Forms.Label lbl_Invoice_No;
        private System.Windows.Forms.DateTimePicker dtp_Inv_Date_From;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_Way_Of_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Item_Category;
        private System.Windows.Forms.Label lbl_Item_No;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.ComboBox cbo_employee;
    }
}