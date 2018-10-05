namespace Inventory
{
    partial class frm_Find_Cust
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
            this.btn_View_Details = new System.Windows.Forms.Button();
            this.btn_View_Inv = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_Way_Of_Search = new System.Windows.Forms.ComboBox();
            this.grb_Search = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Country = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dgv_Cust_Find = new System.Windows.Forms.DataGridView();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Contact = new System.Windows.Forms.Button();
            this.grb_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cust_Find)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_View_Details
            // 
            this.btn_View_Details.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_View_Details.Location = new System.Drawing.Point(774, 474);
            this.btn_View_Details.Name = "btn_View_Details";
            this.btn_View_Details.Size = new System.Drawing.Size(107, 28);
            this.btn_View_Details.TabIndex = 24;
            this.btn_View_Details.Text = "View Details";
            this.btn_View_Details.UseVisualStyleBackColor = true;
            this.btn_View_Details.Click += new System.EventHandler(this.btn_View_Details_Click);
            // 
            // btn_View_Inv
            // 
            this.btn_View_Inv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_View_Inv.Location = new System.Drawing.Point(268, 475);
            this.btn_View_Inv.Name = "btn_View_Inv";
            this.btn_View_Inv.Size = new System.Drawing.Size(107, 28);
            this.btn_View_Inv.TabIndex = 23;
            this.btn_View_Inv.Text = "View Invoices";
            this.btn_View_Inv.UseVisualStyleBackColor = true;
            this.btn_View_Inv.Visible = false;
            this.btn_View_Inv.Click += new System.EventHandler(this.btn_View_Inv_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "The Way Of Search:";
            // 
            // cbo_Way_Of_Search
            // 
            this.cbo_Way_Of_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Way_Of_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Way_Of_Search.FormattingEnabled = true;
            this.cbo_Way_Of_Search.Items.AddRange(new object[] {
            "All",
            "Search By"});
            this.cbo_Way_Of_Search.Location = new System.Drawing.Point(153, 16);
            this.cbo_Way_Of_Search.Name = "cbo_Way_Of_Search";
            this.cbo_Way_Of_Search.Size = new System.Drawing.Size(157, 24);
            this.cbo_Way_Of_Search.TabIndex = 21;
            this.cbo_Way_Of_Search.SelectedValueChanged += new System.EventHandler(this.cbo_Way_Of_Search_SelectedValueChanged);
            // 
            // grb_Search
            // 
            this.grb_Search.Controls.Add(this.label5);
            this.grb_Search.Controls.Add(this.txt_City);
            this.grb_Search.Controls.Add(this.txt_ID);
            this.grb_Search.Controls.Add(this.label1);
            this.grb_Search.Controls.Add(this.btn_Search);
            this.grb_Search.Controls.Add(this.label3);
            this.grb_Search.Controls.Add(this.label2);
            this.grb_Search.Controls.Add(this.txt_Name);
            this.grb_Search.Controls.Add(this.txt_Country);
            this.grb_Search.Enabled = false;
            this.grb_Search.Location = new System.Drawing.Point(19, 46);
            this.grb_Search.Name = "grb_Search";
            this.grb_Search.Size = new System.Drawing.Size(400, 173);
            this.grb_Search.TabIndex = 20;
            this.grb_Search.TabStop = false;
            this.grb_Search.Text = "Search By";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "City:";
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(134, 109);
            this.txt_City.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(157, 23);
            this.txt_City.TabIndex = 12;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(134, 18);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(157, 23);
            this.txt_ID.TabIndex = 11;
            this.txt_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID:";
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Search.Location = new System.Drawing.Point(307, 138);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(87, 28);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Country:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(134, 47);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(157, 23);
            this.txt_Name.TabIndex = 1;
            // 
            // txt_Country
            // 
            this.txt_Country.Location = new System.Drawing.Point(134, 78);
            this.txt_Country.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(157, 23);
            this.txt_Country.TabIndex = 2;
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Location = new System.Drawing.Point(646, 475);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(119, 28);
            this.btn_Delete.TabIndex = 18;
            this.btn_Delete.Text = "Delete Customer";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Edit.Location = new System.Drawing.Point(530, 475);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(107, 28);
            this.btn_Edit.TabIndex = 17;
            this.btn_Edit.Text = "Edit Customer";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Location = new System.Drawing.Point(384, 475);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(137, 28);
            this.btn_Add.TabIndex = 16;
            this.btn_Add.Text = "Add New Customer";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dgv_Cust_Find
            // 
            this.dgv_Cust_Find.AllowUserToAddRows = false;
            this.dgv_Cust_Find.AllowUserToDeleteRows = false;
            this.dgv_Cust_Find.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Cust_Find.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cust_Find.Location = new System.Drawing.Point(19, 225);
            this.dgv_Cust_Find.Name = "dgv_Cust_Find";
            this.dgv_Cust_Find.ReadOnly = true;
            this.dgv_Cust_Find.Size = new System.Drawing.Size(862, 243);
            this.dgv_Cust_Find.TabIndex = 25;
            // 
            // btn_Contact
            // 
            this.btn_Contact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Contact.Location = new System.Drawing.Point(774, 190);
            this.btn_Contact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Contact.Name = "btn_Contact";
            this.btn_Contact.Size = new System.Drawing.Size(107, 28);
            this.btn_Contact.TabIndex = 27;
            this.btn_Contact.Text = "contact person";
            this.btn_Contact.UseVisualStyleBackColor = true;
            this.btn_Contact.Click += new System.EventHandler(this.btn_Contact_Click);
            // 
            // frm_Find_Cust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(893, 515);
            this.Controls.Add(this.btn_Contact);
            this.Controls.Add(this.dgv_Cust_Find);
            this.Controls.Add(this.btn_View_Details);
            this.Controls.Add(this.btn_View_Inv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_Way_Of_Search);
            this.Controls.Add(this.grb_Search);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frm_Find_Cust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Search";
            this.Load += new System.EventHandler(this.frm_Find_Cust_Load);
            this.grb_Search.ResumeLayout(false);
            this.grb_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cust_Find)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_View_Details;
        private System.Windows.Forms.Button btn_View_Inv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_Way_Of_Search;
        private System.Windows.Forms.GroupBox grb_Search;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Country;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
    
        private System.Windows.Forms.BindingSource customerBindingSource;

        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.DataGridView dgv_Cust_Find;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.Button btn_Contact;

    }
}