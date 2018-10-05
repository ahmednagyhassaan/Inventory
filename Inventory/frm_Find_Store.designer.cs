namespace Inventory
{
    partial class frm_Find_Store
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
            this.cbo_Store_Search = new System.Windows.Forms.ComboBox();
            this.dgv_Store_Search = new System.Windows.Forms.DataGridView();
            this.gbx_Search = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_Type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Store_Search)).BeginInit();
            this.gbx_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo_Store_Search
            // 
            this.cbo_Store_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Store_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Store_Search.FormattingEnabled = true;
            this.cbo_Store_Search.Items.AddRange(new object[] {
            "All",
            "Search By"});
            this.cbo_Store_Search.Location = new System.Drawing.Point(26, 54);
            this.cbo_Store_Search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbo_Store_Search.Name = "cbo_Store_Search";
            this.cbo_Store_Search.Size = new System.Drawing.Size(146, 24);
            this.cbo_Store_Search.TabIndex = 0;
            this.cbo_Store_Search.SelectedIndexChanged += new System.EventHandler(this.cbo_Store_Search_SelectedIndexChanged);
            this.cbo_Store_Search.SelectedValueChanged += new System.EventHandler(this.cbo_Store_Search_SelectedValueChanged);
            // 
            // dgv_Store_Search
            // 
            this.dgv_Store_Search.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Store_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Store_Search.Location = new System.Drawing.Point(21, 261);
            this.dgv_Store_Search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgv_Store_Search.Name = "dgv_Store_Search";
            this.dgv_Store_Search.Size = new System.Drawing.Size(551, 240);
            this.dgv_Store_Search.TabIndex = 1;
            // 
            // gbx_Search
            // 
            this.gbx_Search.Controls.Add(this.btn_Search);
            this.gbx_Search.Controls.Add(this.txt_Phone);
            this.gbx_Search.Controls.Add(this.label4);
            this.gbx_Search.Controls.Add(this.cbo_Type);
            this.gbx_Search.Controls.Add(this.label3);
            this.gbx_Search.Controls.Add(this.txt_Address);
            this.gbx_Search.Controls.Add(this.lbl_Address);
            this.gbx_Search.Controls.Add(this.txt_Name);
            this.gbx_Search.Controls.Add(this.label2);
            this.gbx_Search.Location = new System.Drawing.Point(21, 107);
            this.gbx_Search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbx_Search.Name = "gbx_Search";
            this.gbx_Search.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbx_Search.Size = new System.Drawing.Size(387, 137);
            this.gbx_Search.TabIndex = 2;
            this.gbx_Search.TabStop = false;
            this.gbx_Search.Text = "Search by:";
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Search.Location = new System.Drawing.Point(310, 100);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(64, 25);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(252, 71);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(122, 23);
            this.txt_Phone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone";
            // 
            // cbo_Type
            // 
            this.cbo_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Type.FormattingEnabled = true;
            this.cbo_Type.Location = new System.Drawing.Point(252, 29);
            this.cbo_Type.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbo_Type.Name = "cbo_Type";
            this.cbo_Type.Size = new System.Drawing.Size(122, 24);
            this.cbo_Type.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(73, 71);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(116, 23);
            this.txt_Address.TabIndex = 3;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(15, 71);
            this.lbl_Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(54, 16);
            this.lbl_Address.TabIndex = 2;
            this.lbl_Address.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose The Way Of View:";
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Location = new System.Drawing.Point(295, 507);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(84, 29);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Add New";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Edit.Location = new System.Drawing.Point(393, 507);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(84, 29);
            this.btn_Edit.TabIndex = 5;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Location = new System.Drawing.Point(488, 507);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(84, 29);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(73, 29);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(116, 23);
            this.txt_Name.TabIndex = 1;
            // 
            // frm_Store_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(583, 545);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbx_Search);
            this.Controls.Add(this.dgv_Store_Search);
            this.Controls.Add(this.cbo_Store_Search);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frm_Store_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Search";
            this.Load += new System.EventHandler(this.frm_Store_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Store_Search)).EndInit();
            this.gbx_Search.ResumeLayout(false);
            this.gbx_Search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_Store_Search;
        private System.Windows.Forms.DataGridView dgv_Store_Search;
        private System.Windows.Forms.GroupBox gbx_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_Type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox txt_Name;
    }
}