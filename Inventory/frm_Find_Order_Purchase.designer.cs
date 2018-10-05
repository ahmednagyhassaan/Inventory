namespace Inventory
{
    partial class frm_Find_Order_Purchase
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_Way_Of_Search = new System.Windows.Forms.ComboBox();
            this.gbo_Search_By = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_To = new System.Windows.Forms.Label();
            this.lbl_From = new System.Windows.Forms.Label();
            this.dtp_Inv_Date_To = new System.Windows.Forms.DateTimePicker();
            this.cbo_Supp_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Invoice_Date = new System.Windows.Forms.Label();
            this.txt_Inv_No = new System.Windows.Forms.TextBox();
            this.lbl_Supplier_Name = new System.Windows.Forms.Label();
            this.lbl_Invoice_No = new System.Windows.Forms.Label();
            this.dtp_Inv_Date_From = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Delete_Inv = new System.Windows.Forms.Button();
            this.btn_View_Edit_inv = new System.Windows.Forms.Button();
            this.btn_New_Invoice = new System.Windows.Forms.Button();
            this.dgv_search = new System.Windows.Forms.DataGridView();
            this.gbo_Search_By.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "The Way Of Search:";
            // 
            // cbo_Way_Of_Search
            // 
            this.cbo_Way_Of_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Way_Of_Search.Items.AddRange(new object[] {
            "All",
            "Search By"});
            this.cbo_Way_Of_Search.Location = new System.Drawing.Point(194, 30);
            this.cbo_Way_Of_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_Way_Of_Search.Name = "cbo_Way_Of_Search";
            this.cbo_Way_Of_Search.Size = new System.Drawing.Size(130, 24);
            this.cbo_Way_Of_Search.TabIndex = 26;
            this.cbo_Way_Of_Search.SelectedValueChanged += new System.EventHandler(this.cbo_Way_Of_Search_SelectedValueChanged);
            // 
            // gbo_Search_By
            // 
            this.gbo_Search_By.Controls.Add(this.comboBox1);
            this.gbo_Search_By.Controls.Add(this.textBox1);
            this.gbo_Search_By.Controls.Add(this.label2);
            this.gbo_Search_By.Controls.Add(this.label1);
            this.gbo_Search_By.Controls.Add(this.btn_Search);
            this.gbo_Search_By.Controls.Add(this.lbl_To);
            this.gbo_Search_By.Controls.Add(this.lbl_From);
            this.gbo_Search_By.Controls.Add(this.dtp_Inv_Date_To);
            this.gbo_Search_By.Controls.Add(this.cbo_Supp_Name);
            this.gbo_Search_By.Controls.Add(this.lbl_Invoice_Date);
            this.gbo_Search_By.Controls.Add(this.txt_Inv_No);
            this.gbo_Search_By.Controls.Add(this.lbl_Supplier_Name);
            this.gbo_Search_By.Controls.Add(this.lbl_Invoice_No);
            this.gbo_Search_By.Controls.Add(this.dtp_Inv_Date_From);
            this.gbo_Search_By.Enabled = false;
            this.gbo_Search_By.Location = new System.Drawing.Point(45, 90);
            this.gbo_Search_By.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbo_Search_By.Name = "gbo_Search_By";
            this.gbo_Search_By.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbo_Search_By.Size = new System.Drawing.Size(589, 230);
            this.gbo_Search_By.TabIndex = 25;
            this.gbo_Search_By.TabStop = false;
            this.gbo_Search_By.Text = "Search By";
            this.gbo_Search_By.Enter += new System.EventHandler(this.gbo_Search_By_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 91);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 24);
            this.comboBox1.TabIndex = 71;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 132);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 72);
            this.textBox1.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 69;
            this.label2.Text = "Notes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 68;
            this.label1.Text = "Employee Name:";
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Search.Location = new System.Drawing.Point(404, 170);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(101, 34);
            this.btn_Search.TabIndex = 67;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Location = new System.Drawing.Point(377, 91);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(32, 16);
            this.lbl_To.TabIndex = 60;
            this.lbl_To.Text = "To :";
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Location = new System.Drawing.Point(363, 46);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(47, 16);
            this.lbl_From.TabIndex = 59;
            this.lbl_From.Text = "From :";
            // 
            // dtp_Inv_Date_To
            // 
            this.dtp_Inv_Date_To.Location = new System.Drawing.Point(415, 84);
            this.dtp_Inv_Date_To.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtp_Inv_Date_To.Name = "dtp_Inv_Date_To";
            this.dtp_Inv_Date_To.Size = new System.Drawing.Size(165, 23);
            this.dtp_Inv_Date_To.TabIndex = 58;
            // 
            // cbo_Supp_Name
            // 
            this.cbo_Supp_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Supp_Name.FormattingEnabled = true;
            this.cbo_Supp_Name.Location = new System.Drawing.Point(149, 34);
            this.cbo_Supp_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_Supp_Name.Name = "cbo_Supp_Name";
            this.cbo_Supp_Name.Size = new System.Drawing.Size(130, 24);
            this.cbo_Supp_Name.TabIndex = 54;
            // 
            // lbl_Invoice_Date
            // 
            this.lbl_Invoice_Date.AutoSize = true;
            this.lbl_Invoice_Date.Location = new System.Drawing.Point(291, 44);
            this.lbl_Invoice_Date.Name = "lbl_Invoice_Date";
            this.lbl_Invoice_Date.Size = new System.Drawing.Size(76, 16);
            this.lbl_Invoice_Date.TabIndex = 44;
            this.lbl_Invoice_Date.Text = "Order Date:";
            // 
            // txt_Inv_No
            // 
            this.txt_Inv_No.Location = new System.Drawing.Point(404, 135);
            this.txt_Inv_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Inv_No.Name = "txt_Inv_No";
            this.txt_Inv_No.Size = new System.Drawing.Size(101, 23);
            this.txt_Inv_No.TabIndex = 50;
            // 
            // lbl_Supplier_Name
            // 
            this.lbl_Supplier_Name.AutoSize = true;
            this.lbl_Supplier_Name.Location = new System.Drawing.Point(19, 44);
            this.lbl_Supplier_Name.Name = "lbl_Supplier_Name";
            this.lbl_Supplier_Name.Size = new System.Drawing.Size(97, 16);
            this.lbl_Supplier_Name.TabIndex = 47;
            this.lbl_Supplier_Name.Text = "Supplier Name:";
            // 
            // lbl_Invoice_No
            // 
            this.lbl_Invoice_No.AutoSize = true;
            this.lbl_Invoice_No.Location = new System.Drawing.Point(315, 142);
            this.lbl_Invoice_No.Name = "lbl_Invoice_No";
            this.lbl_Invoice_No.Size = new System.Drawing.Size(65, 16);
            this.lbl_Invoice_No.TabIndex = 46;
            this.lbl_Invoice_No.Text = "Order No:";
            // 
            // dtp_Inv_Date_From
            // 
            this.dtp_Inv_Date_From.Location = new System.Drawing.Point(415, 40);
            this.dtp_Inv_Date_From.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_Inv_Date_From.Name = "dtp_Inv_Date_From";
            this.dtp_Inv_Date_From.Size = new System.Drawing.Size(165, 23);
            this.dtp_Inv_Date_From.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 24;
            // 
            // btn_Delete_Inv
            // 
            this.btn_Delete_Inv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete_Inv.Location = new System.Drawing.Point(472, 538);
            this.btn_Delete_Inv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete_Inv.Name = "btn_Delete_Inv";
            this.btn_Delete_Inv.Size = new System.Drawing.Size(115, 36);
            this.btn_Delete_Inv.TabIndex = 23;
            this.btn_Delete_Inv.Text = "Delete Order";
            this.btn_Delete_Inv.UseVisualStyleBackColor = true;
            this.btn_Delete_Inv.Visible = false;
            this.btn_Delete_Inv.Click += new System.EventHandler(this.btn_Delete_Inv_Click);
            // 
            // btn_View_Edit_inv
            // 
            this.btn_View_Edit_inv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_View_Edit_inv.Location = new System.Drawing.Point(339, 538);
            this.btn_View_Edit_inv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_View_Edit_inv.Name = "btn_View_Edit_inv";
            this.btn_View_Edit_inv.Size = new System.Drawing.Size(115, 36);
            this.btn_View_Edit_inv.TabIndex = 22;
            this.btn_View_Edit_inv.Text = "View/EditOrder";
            this.btn_View_Edit_inv.UseVisualStyleBackColor = true;
            this.btn_View_Edit_inv.Click += new System.EventHandler(this.btn_View_Edit_inv_Click);
            // 
            // btn_New_Invoice
            // 
            this.btn_New_Invoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_New_Invoice.Location = new System.Drawing.Point(214, 539);
            this.btn_New_Invoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_New_Invoice.Name = "btn_New_Invoice";
            this.btn_New_Invoice.Size = new System.Drawing.Size(110, 34);
            this.btn_New_Invoice.TabIndex = 21;
            this.btn_New_Invoice.Text = "New Order";
            this.btn_New_Invoice.UseVisualStyleBackColor = true;
            this.btn_New_Invoice.Click += new System.EventHandler(this.btn_New_Invoice_Click);
            // 
            // dgv_search
            // 
            this.dgv_search.BackgroundColor = System.Drawing.Color.White;
            this.dgv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_search.Location = new System.Drawing.Point(25, 342);
            this.dgv_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_search.Name = "dgv_search";
            this.dgv_search.RowTemplate.Height = 26;
            this.dgv_search.Size = new System.Drawing.Size(600, 170);
            this.dgv_search.TabIndex = 19;
            // 
            // frm_Find_Order_Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(663, 602);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_Way_Of_Search);
            this.Controls.Add(this.gbo_Search_By);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Delete_Inv);
            this.Controls.Add(this.btn_View_Edit_inv);
            this.Controls.Add(this.btn_New_Invoice);
            this.Controls.Add(this.dgv_search);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Find_Order_Purchase";
            this.Text = "frm_Find_Order_Purchase";
            this.Load += new System.EventHandler(this.frm_Find_Order_Purchase_Load);
            this.gbo_Search_By.ResumeLayout(false);
            this.gbo_Search_By.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_Way_Of_Search;
        private System.Windows.Forms.GroupBox gbo_Search_By;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.DateTimePicker dtp_Inv_Date_To;
        private System.Windows.Forms.ComboBox cbo_Supp_Name;
        private System.Windows.Forms.Label lbl_Invoice_Date;
        private System.Windows.Forms.TextBox txt_Inv_No;
        private System.Windows.Forms.Label lbl_Supplier_Name;
        private System.Windows.Forms.Label lbl_Invoice_No;
        private System.Windows.Forms.DateTimePicker dtp_Inv_Date_From;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Delete_Inv;
        private System.Windows.Forms.Button btn_View_Edit_inv;
        private System.Windows.Forms.Button btn_New_Invoice;
        private System.Windows.Forms.DataGridView dgv_search;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}