namespace Inventory
{
    partial class frm_Add_Store
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Capacity = new System.Windows.Forms.Label();
            this.cbo_Type = new System.Windows.Forms.ComboBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Capacity = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.Pnl_Add_Store = new System.Windows.Forms.Panel();
            this.lbl_desc_Note = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_Area = new System.Windows.Forms.TextBox();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_Area = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Pnl_Add_Store.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(13, 108);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(41, 16);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(13, 40);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(36, 16);
            this.lbl_type.TabIndex = 2;
            this.lbl_type.Text = "Type";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(13, 141);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(54, 16);
            this.lbl_Address.TabIndex = 3;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_Capacity
            // 
            this.lbl_Capacity.AutoSize = true;
            this.lbl_Capacity.Location = new System.Drawing.Point(12, 175);
            this.lbl_Capacity.Name = "lbl_Capacity";
            this.lbl_Capacity.Size = new System.Drawing.Size(56, 16);
            this.lbl_Capacity.TabIndex = 4;
            this.lbl_Capacity.Text = "Capacity";
            // 
            // cbo_Type
            // 
            this.cbo_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Type.FormattingEnabled = true;
            this.cbo_Type.Location = new System.Drawing.Point(70, 40);
            this.cbo_Type.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbo_Type.Name = "cbo_Type";
            this.cbo_Type.Size = new System.Drawing.Size(128, 24);
            this.cbo_Type.TabIndex = 5;
            this.cbo_Type.SelectedIndexChanged += new System.EventHandler(this.Cbo_Type_SelectedIndexChanged);
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(70, 72);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(128, 23);
            this.txt_ID.TabIndex = 6;
            this.txt_ID.TextChanged += new System.EventHandler(this.txt_ID_TextChanged);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(70, 105);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(128, 23);
            this.txt_Name.TabIndex = 7;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(70, 138);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(128, 23);
            this.txt_Address.TabIndex = 8;
            // 
            // txt_Capacity
            // 
            this.txt_Capacity.Location = new System.Drawing.Point(70, 173);
            this.txt_Capacity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Capacity.Name = "txt_Capacity";
            this.txt_Capacity.Size = new System.Drawing.Size(128, 23);
            this.txt_Capacity.TabIndex = 9;
            this.txt_Capacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Capacity_KeyPress);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(13, 72);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(20, 16);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID";
            // 
            // Pnl_Add_Store
            // 
            this.Pnl_Add_Store.Controls.Add(this.lbl_desc_Note);
            this.Pnl_Add_Store.Controls.Add(this.lbl_ID);
            this.Pnl_Add_Store.Controls.Add(this.lbl_Name);
            this.Pnl_Add_Store.Controls.Add(this.lbl_type);
            this.Pnl_Add_Store.Controls.Add(this.txt_Phone);
            this.Pnl_Add_Store.Controls.Add(this.txt_Area);
            this.Pnl_Add_Store.Controls.Add(this.txt_Capacity);
            this.Pnl_Add_Store.Controls.Add(this.lbl_Phone);
            this.Pnl_Add_Store.Controls.Add(this.lbl_Address);
            this.Pnl_Add_Store.Controls.Add(this.lbl_Area);
            this.Pnl_Add_Store.Controls.Add(this.txt_Address);
            this.Pnl_Add_Store.Controls.Add(this.lbl_Capacity);
            this.Pnl_Add_Store.Controls.Add(this.cbo_Type);
            this.Pnl_Add_Store.Controls.Add(this.txt_Name);
            this.Pnl_Add_Store.Controls.Add(this.txt_ID);
            this.Pnl_Add_Store.Location = new System.Drawing.Point(9, 10);
            this.Pnl_Add_Store.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Pnl_Add_Store.Name = "Pnl_Add_Store";
            this.Pnl_Add_Store.Size = new System.Drawing.Size(278, 269);
            this.Pnl_Add_Store.TabIndex = 12;
            // 
            // lbl_desc_Note
            // 
            this.lbl_desc_Note.AutoSize = true;
            this.lbl_desc_Note.Location = new System.Drawing.Point(9, 9);
            this.lbl_desc_Note.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_desc_Note.Name = "lbl_desc_Note";
            this.lbl_desc_Note.Size = new System.Drawing.Size(118, 16);
            this.lbl_desc_Note.TabIndex = 14;
            this.lbl_desc_Note.Text = "To add new store :";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(70, 231);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(128, 23);
            this.txt_Phone.TabIndex = 9;
            this.txt_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Phone_KeyPress);
            // 
            // txt_Area
            // 
            this.txt_Area.Location = new System.Drawing.Point(70, 202);
            this.txt_Area.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Area.Name = "txt_Area";
            this.txt_Area.Size = new System.Drawing.Size(128, 23);
            this.txt_Area.TabIndex = 9;
            this.txt_Area.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Area_KeyPress);
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(12, 233);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(43, 16);
            this.lbl_Phone.TabIndex = 4;
            this.lbl_Phone.Text = "Phone";
            // 
            // lbl_Area
            // 
            this.lbl_Area.AutoSize = true;
            this.lbl_Area.Location = new System.Drawing.Point(12, 204);
            this.lbl_Area.Name = "lbl_Area";
            this.lbl_Area.Size = new System.Drawing.Size(35, 16);
            this.lbl_Area.TabIndex = 4;
            this.lbl_Area.Text = "Area";
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Location = new System.Drawing.Point(134, 288);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 33);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Save";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(212, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Add_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(298, 328);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pnl_Add_Store);
            this.Controls.Add(this.btn_Add);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frm_Add_Store";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Add_Store_FormClosing);
            this.Load += new System.EventHandler(this.frm_Add_Store_Load);
            this.Pnl_Add_Store.ResumeLayout(false);
            this.Pnl_Add_Store.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Capacity;
        private System.Windows.Forms.ComboBox cbo_Type;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_Capacity;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Panel Pnl_Add_Store;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_desc_Note;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_Area;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_Area;
        private System.Windows.Forms.Button button1;
    }
}

