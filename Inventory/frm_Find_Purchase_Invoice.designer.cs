namespace Inventory
{
    partial class frm_Find_Purchase_Invoice
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
            this.btn_Print_Inv = new System.Windows.Forms.Button();
            this.btn_New_Invoice = new System.Windows.Forms.Button();
            this.btn_View_Edit_inv = new System.Windows.Forms.Button();
            this.btn_Delete_Inv = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gbo_Search_By = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Item_Category = new System.Windows.Forms.Label();
            this.cbo_Itm_Cat = new System.Windows.Forms.ComboBox();
            this.cbo_Itm_Name = new System.Windows.Forms.ComboBox();
            this.txt_Itm_No = new System.Windows.Forms.TextBox();
            this.lbl_Item_Name = new System.Windows.Forms.Label();
            this.lbl_Item_No = new System.Windows.Forms.Label();
            this.lbl_To = new System.Windows.Forms.Label();
            this.lbl_From = new System.Windows.Forms.Label();
            this.dtp_Inv_Date_To = new System.Windows.Forms.DateTimePicker();
            this.cbo_Supp_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Invoice_Date = new System.Windows.Forms.Label();
            this.lbl_Inv_TotalPrice = new System.Windows.Forms.Label();
            this.txt_Inv_Total_Price = new System.Windows.Forms.TextBox();
            this.txt_Inv_No = new System.Windows.Forms.TextBox();
            this.lbl_Supplier_Name = new System.Windows.Forms.Label();
            this.lbl_Invoice_No = new System.Windows.Forms.Label();
            this.dtp_Inv_Date_From = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_Way_Of_Search = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).BeginInit();
            this.gbo_Search_By.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_search
            // 
            this.dgv_search.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_search.Location = new System.Drawing.Point(20, 278);
            this.dgv_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_search.Name = "dgv_search";
            this.dgv_search.RowTemplate.Height = 26;
            this.dgv_search.Size = new System.Drawing.Size(660, 246);
            this.dgv_search.TabIndex = 4;
            // 
            // btn_Print_Inv
            // 
            this.btn_Print_Inv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Print_Inv.Location = new System.Drawing.Point(182, 538);
            this.btn_Print_Inv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Print_Inv.Name = "btn_Print_Inv";
            this.btn_Print_Inv.Size = new System.Drawing.Size(119, 38);
            this.btn_Print_Inv.TabIndex = 5;
            this.btn_Print_Inv.Text = "Print Invoice";
            this.btn_Print_Inv.UseVisualStyleBackColor = true;
            // 
            // btn_New_Invoice
            // 
            this.btn_New_Invoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_New_Invoice.Location = new System.Drawing.Point(307, 538);
            this.btn_New_Invoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_New_Invoice.Name = "btn_New_Invoice";
            this.btn_New_Invoice.Size = new System.Drawing.Size(119, 38);
            this.btn_New_Invoice.TabIndex = 6;
            this.btn_New_Invoice.Text = "New Invoice";
            this.btn_New_Invoice.UseVisualStyleBackColor = true;
            this.btn_New_Invoice.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_View_Edit_inv
            // 
            this.btn_View_Edit_inv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_View_Edit_inv.Location = new System.Drawing.Point(432, 538);
            this.btn_View_Edit_inv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_View_Edit_inv.Name = "btn_View_Edit_inv";
            this.btn_View_Edit_inv.Size = new System.Drawing.Size(119, 38);
            this.btn_View_Edit_inv.TabIndex = 7;
            this.btn_View_Edit_inv.Text = "View/Edit Invoice";
            this.btn_View_Edit_inv.UseVisualStyleBackColor = true;
            this.btn_View_Edit_inv.Click += new System.EventHandler(this.btn_View_Edit_inv_Click);
            // 
            // btn_Delete_Inv
            // 
            this.btn_Delete_Inv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete_Inv.Location = new System.Drawing.Point(557, 538);
            this.btn_Delete_Inv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete_Inv.Name = "btn_Delete_Inv";
            this.btn_Delete_Inv.Size = new System.Drawing.Size(119, 38);
            this.btn_Delete_Inv.TabIndex = 8;
            this.btn_Delete_Inv.Text = "Delete Invoice";
            this.btn_Delete_Inv.UseVisualStyleBackColor = true;
            this.btn_Delete_Inv.Click += new System.EventHandler(this.btn_Delete_Inv_Click);
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
            this.gbo_Search_By.BackColor = System.Drawing.Color.AliceBlue;
            this.gbo_Search_By.Controls.Add(this.btn_Search);
            this.gbo_Search_By.Controls.Add(this.lbl_Item_Category);
            this.gbo_Search_By.Controls.Add(this.cbo_Itm_Cat);
            this.gbo_Search_By.Controls.Add(this.cbo_Itm_Name);
            this.gbo_Search_By.Controls.Add(this.txt_Itm_No);
            this.gbo_Search_By.Controls.Add(this.lbl_Item_Name);
            this.gbo_Search_By.Controls.Add(this.lbl_Item_No);
            this.gbo_Search_By.Controls.Add(this.lbl_To);
            this.gbo_Search_By.Controls.Add(this.lbl_From);
            this.gbo_Search_By.Controls.Add(this.dtp_Inv_Date_To);
            this.gbo_Search_By.Controls.Add(this.cbo_Supp_Name);
            this.gbo_Search_By.Controls.Add(this.lbl_Invoice_Date);
            this.gbo_Search_By.Controls.Add(this.lbl_Inv_TotalPrice);
            this.gbo_Search_By.Controls.Add(this.txt_Inv_Total_Price);
            this.gbo_Search_By.Controls.Add(this.txt_Inv_No);
            this.gbo_Search_By.Controls.Add(this.lbl_Supplier_Name);
            this.gbo_Search_By.Controls.Add(this.lbl_Invoice_No);
            this.gbo_Search_By.Controls.Add(this.dtp_Inv_Date_From);
            this.gbo_Search_By.Location = new System.Drawing.Point(17, 64);
            this.gbo_Search_By.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbo_Search_By.Name = "gbo_Search_By";
            this.gbo_Search_By.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbo_Search_By.Size = new System.Drawing.Size(663, 208);
            this.gbo_Search_By.TabIndex = 14;
            this.gbo_Search_By.TabStop = false;
            this.gbo_Search_By.Text = "Search By";
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Search.Location = new System.Drawing.Point(426, 172);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(89, 28);
            this.btn_Search.TabIndex = 67;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_Item_Category
            // 
            this.lbl_Item_Category.AutoSize = true;
            this.lbl_Item_Category.Location = new System.Drawing.Point(31, 105);
            this.lbl_Item_Category.Name = "lbl_Item_Category";
            this.lbl_Item_Category.Size = new System.Drawing.Size(94, 16);
            this.lbl_Item_Category.TabIndex = 66;
            this.lbl_Item_Category.Text = "Item Category:";
            // 
            // cbo_Itm_Cat
            // 
            this.cbo_Itm_Cat.FormattingEnabled = true;
            this.cbo_Itm_Cat.Location = new System.Drawing.Point(161, 103);
            this.cbo_Itm_Cat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_Itm_Cat.Name = "cbo_Itm_Cat";
            this.cbo_Itm_Cat.Size = new System.Drawing.Size(157, 24);
            this.cbo_Itm_Cat.TabIndex = 65;
            this.cbo_Itm_Cat.SelectedIndexChanged += new System.EventHandler(this.cbo_Itm_Cat_SelectedIndexChanged);
            // 
            // cbo_Itm_Name
            // 
            this.cbo_Itm_Name.FormattingEnabled = true;
            this.cbo_Itm_Name.Location = new System.Drawing.Point(161, 138);
            this.cbo_Itm_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_Itm_Name.Name = "cbo_Itm_Name";
            this.cbo_Itm_Name.Size = new System.Drawing.Size(157, 24);
            this.cbo_Itm_Name.TabIndex = 64;
            this.cbo_Itm_Name.SelectedIndexChanged += new System.EventHandler(this.cbo_Itm_Name_SelectedIndexChanged);
            // 
            // txt_Itm_No
            // 
            this.txt_Itm_No.Location = new System.Drawing.Point(161, 68);
            this.txt_Itm_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Itm_No.Name = "txt_Itm_No";
            this.txt_Itm_No.Size = new System.Drawing.Size(157, 23);
            this.txt_Itm_No.TabIndex = 63;
            this.txt_Itm_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Itm_No_KeyPress);
            // 
            // lbl_Item_Name
            // 
            this.lbl_Item_Name.AutoSize = true;
            this.lbl_Item_Name.Location = new System.Drawing.Point(31, 142);
            this.lbl_Item_Name.Name = "lbl_Item_Name";
            this.lbl_Item_Name.Size = new System.Drawing.Size(76, 16);
            this.lbl_Item_Name.TabIndex = 62;
            this.lbl_Item_Name.Text = "Item Name:";
            // 
            // lbl_Item_No
            // 
            this.lbl_Item_No.AutoSize = true;
            this.lbl_Item_No.Location = new System.Drawing.Point(31, 70);
            this.lbl_Item_No.Name = "lbl_Item_No";
            this.lbl_Item_No.Size = new System.Drawing.Size(58, 16);
            this.lbl_Item_No.TabIndex = 61;
            this.lbl_Item_No.Text = "Item No:";
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Location = new System.Drawing.Point(450, 65);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(32, 16);
            this.lbl_To.TabIndex = 60;
            this.lbl_To.Text = "To :";
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Location = new System.Drawing.Point(450, 35);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(47, 16);
            this.lbl_From.TabIndex = 59;
            this.lbl_From.Text = "From :";
            // 
            // dtp_Inv_Date_To
            // 
            this.dtp_Inv_Date_To.Location = new System.Drawing.Point(503, 65);
            this.dtp_Inv_Date_To.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_Inv_Date_To.Name = "dtp_Inv_Date_To";
            this.dtp_Inv_Date_To.Size = new System.Drawing.Size(154, 23);
            this.dtp_Inv_Date_To.TabIndex = 58;
            // 
            // cbo_Supp_Name
            // 
            this.cbo_Supp_Name.FormattingEnabled = true;
            this.cbo_Supp_Name.Location = new System.Drawing.Point(161, 33);
            this.cbo_Supp_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_Supp_Name.Name = "cbo_Supp_Name";
            this.cbo_Supp_Name.Size = new System.Drawing.Size(157, 24);
            this.cbo_Supp_Name.TabIndex = 54;
            // 
            // lbl_Invoice_Date
            // 
            this.lbl_Invoice_Date.AutoSize = true;
            this.lbl_Invoice_Date.Location = new System.Drawing.Point(364, 28);
            this.lbl_Invoice_Date.Name = "lbl_Invoice_Date";
            this.lbl_Invoice_Date.Size = new System.Drawing.Size(83, 16);
            this.lbl_Invoice_Date.TabIndex = 44;
            this.lbl_Invoice_Date.Text = "Invoice Date:";
            // 
            // lbl_Inv_TotalPrice
            // 
            this.lbl_Inv_TotalPrice.AutoSize = true;
            this.lbl_Inv_TotalPrice.Location = new System.Drawing.Point(364, 142);
            this.lbl_Inv_TotalPrice.Name = "lbl_Inv_TotalPrice";
            this.lbl_Inv_TotalPrice.Size = new System.Drawing.Size(118, 16);
            this.lbl_Inv_TotalPrice.TabIndex = 53;
            this.lbl_Inv_TotalPrice.Text = "Invoice Total Price:";
            // 
            // txt_Inv_Total_Price
            // 
            this.txt_Inv_Total_Price.Location = new System.Drawing.Point(503, 139);
            this.txt_Inv_Total_Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Inv_Total_Price.Name = "txt_Inv_Total_Price";
            this.txt_Inv_Total_Price.Size = new System.Drawing.Size(154, 23);
            this.txt_Inv_Total_Price.TabIndex = 52;
            // 
            // txt_Inv_No
            // 
            this.txt_Inv_No.Location = new System.Drawing.Point(503, 102);
            this.txt_Inv_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Inv_No.Name = "txt_Inv_No";
            this.txt_Inv_No.Size = new System.Drawing.Size(154, 23);
            this.txt_Inv_No.TabIndex = 50;
            // 
            // lbl_Supplier_Name
            // 
            this.lbl_Supplier_Name.AutoSize = true;
            this.lbl_Supplier_Name.Location = new System.Drawing.Point(31, 35);
            this.lbl_Supplier_Name.Name = "lbl_Supplier_Name";
            this.lbl_Supplier_Name.Size = new System.Drawing.Size(97, 16);
            this.lbl_Supplier_Name.TabIndex = 47;
            this.lbl_Supplier_Name.Text = "Supplier Name:";
            // 
            // lbl_Invoice_No
            // 
            this.lbl_Invoice_No.AutoSize = true;
            this.lbl_Invoice_No.Location = new System.Drawing.Point(364, 102);
            this.lbl_Invoice_No.Name = "lbl_Invoice_No";
            this.lbl_Invoice_No.Size = new System.Drawing.Size(72, 16);
            this.lbl_Invoice_No.TabIndex = 46;
            this.lbl_Invoice_No.Text = "Invoice No:";
            // 
            // dtp_Inv_Date_From
            // 
            this.dtp_Inv_Date_From.Location = new System.Drawing.Point(503, 28);
            this.dtp_Inv_Date_From.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_Inv_Date_From.Name = "dtp_Inv_Date_From";
            this.dtp_Inv_Date_From.Size = new System.Drawing.Size(154, 23);
            this.dtp_Inv_Date_From.TabIndex = 45;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(443, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 27);
            this.button1.TabIndex = 68;
            this.button1.Text = "details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.cbo_Way_Of_Search.FormattingEnabled = true;
            this.cbo_Way_Of_Search.Items.AddRange(new object[] {
            "All",
            "Search By"});
            this.cbo_Way_Of_Search.Location = new System.Drawing.Point(178, 24);
            this.cbo_Way_Of_Search.Name = "cbo_Way_Of_Search";
            this.cbo_Way_Of_Search.Size = new System.Drawing.Size(157, 24);
            this.cbo_Way_Of_Search.TabIndex = 17;
            this.cbo_Way_Of_Search.SelectedIndexChanged += new System.EventHandler(this.cbo_Way_Of_Search_SelectedIndexChanged);
            // 
            // frm_Find_Purchase_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(711, 588);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_Way_Of_Search);
            this.Controls.Add(this.gbo_Search_By);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Delete_Inv);
            this.Controls.Add(this.btn_View_Edit_inv);
            this.Controls.Add(this.btn_New_Invoice);
            this.Controls.Add(this.btn_Print_Inv);
            this.Controls.Add(this.dgv_search);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frm_Find_Purchase_Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Invoice";
            this.Load += new System.EventHandler(this.Frm_Find_Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).EndInit();
            this.gbo_Search_By.ResumeLayout(false);
            this.gbo_Search_By.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_search;
        private System.Windows.Forms.Button btn_Print_Inv;
        private System.Windows.Forms.Button btn_New_Invoice;
        private System.Windows.Forms.Button btn_View_Edit_inv;
        private System.Windows.Forms.Button btn_Delete_Inv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbo_Search_By;
        private System.Windows.Forms.Label lbl_Item_Category;
        private System.Windows.Forms.ComboBox cbo_Itm_Cat;
        private System.Windows.Forms.ComboBox cbo_Itm_Name;
        private System.Windows.Forms.TextBox txt_Itm_No;
        private System.Windows.Forms.Label lbl_Item_Name;
        private System.Windows.Forms.Label lbl_Item_No;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.DateTimePicker dtp_Inv_Date_To;
        private System.Windows.Forms.ComboBox cbo_Supp_Name;
        private System.Windows.Forms.Label lbl_Invoice_Date;
        private System.Windows.Forms.Label lbl_Inv_TotalPrice;
        private System.Windows.Forms.TextBox txt_Inv_Total_Price;
        private System.Windows.Forms.TextBox txt_Inv_No;
        private System.Windows.Forms.Label lbl_Supplier_Name;
        private System.Windows.Forms.Label lbl_Invoice_No;
        private System.Windows.Forms.DateTimePicker dtp_Inv_Date_From;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_Way_Of_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button button1;
    }
}