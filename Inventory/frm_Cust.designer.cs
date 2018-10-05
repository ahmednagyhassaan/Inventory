namespace Inventory
{
    partial class frm_Cust
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
            this.gbo_Phone = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Phone3 = new System.Windows.Forms.TextBox();
            this.txt_Phone1 = new System.Windows.Forms.TextBox();
            this.txt_Phone2 = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.gbo_Cust_Info = new System.Windows.Forms.GroupBox();
            this.txt_Post_Code = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.txt_Bank_Account = new System.Windows.Forms.TextBox();
            this.txt_Fax = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Country = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lebal30 = new System.Windows.Forms.Label();
            this.llbl = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.gbo_Phone.SuspendLayout();
            this.gbo_Cust_Info.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbo_Phone
            // 
            this.gbo_Phone.Controls.Add(this.label10);
            this.gbo_Phone.Controls.Add(this.label9);
            this.gbo_Phone.Controls.Add(this.label4);
            this.gbo_Phone.Controls.Add(this.txt_Phone3);
            this.gbo_Phone.Controls.Add(this.txt_Phone1);
            this.gbo_Phone.Controls.Add(this.txt_Phone2);
            this.gbo_Phone.Location = new System.Drawing.Point(300, 176);
            this.gbo_Phone.Name = "gbo_Phone";
            this.gbo_Phone.Size = new System.Drawing.Size(266, 122);
            this.gbo_Phone.TabIndex = 41;
            this.gbo_Phone.TabStop = false;
            this.gbo_Phone.Text = "Phone";
            this.gbo_Phone.Enter += new System.EventHandler(this.gbo_Phone_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "phone 3:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "phone 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "phone 1:";
            // 
            // txt_Phone3
            // 
            this.txt_Phone3.Location = new System.Drawing.Point(110, 89);
            this.txt_Phone3.Name = "txt_Phone3";
            this.txt_Phone3.Size = new System.Drawing.Size(150, 23);
            this.txt_Phone3.TabIndex = 21;
            this.txt_Phone3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Phone1_KeyPress);
            // 
            // txt_Phone1
            // 
            this.txt_Phone1.Location = new System.Drawing.Point(110, 23);
            this.txt_Phone1.Name = "txt_Phone1";
            this.txt_Phone1.Size = new System.Drawing.Size(150, 23);
            this.txt_Phone1.TabIndex = 19;
            this.txt_Phone1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Phone1_KeyPress);
            // 
            // txt_Phone2
            // 
            this.txt_Phone2.Location = new System.Drawing.Point(110, 56);
            this.txt_Phone2.Name = "txt_Phone2";
            this.txt_Phone2.Size = new System.Drawing.Size(150, 23);
            this.txt_Phone2.TabIndex = 20;
            this.txt_Phone2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Phone1_KeyPress);
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Location = new System.Drawing.Point(479, 329);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(87, 28);
            this.btn_cancel.TabIndex = 40;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Location = new System.Drawing.Point(386, 329);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(87, 28);
            this.btn_save.TabIndex = 39;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // gbo_Cust_Info
            // 
            this.gbo_Cust_Info.Controls.Add(this.txt_Post_Code);
            this.gbo_Cust_Info.Controls.Add(this.label11);
            this.gbo_Cust_Info.Controls.Add(this.txt_Notes);
            this.gbo_Cust_Info.Controls.Add(this.txt_Bank_Account);
            this.gbo_Cust_Info.Controls.Add(this.txt_Fax);
            this.gbo_Cust_Info.Controls.Add(this.txt_Email);
            this.gbo_Cust_Info.Controls.Add(this.label5);
            this.gbo_Cust_Info.Controls.Add(this.label6);
            this.gbo_Cust_Info.Controls.Add(this.label7);
            this.gbo_Cust_Info.Controls.Add(this.label8);
            this.gbo_Cust_Info.Controls.Add(this.txt_Name);
            this.gbo_Cust_Info.Controls.Add(this.txt_ID);
            this.gbo_Cust_Info.Controls.Add(this.label2);
            this.gbo_Cust_Info.Controls.Add(this.label1);
            this.gbo_Cust_Info.Location = new System.Drawing.Point(13, 13);
            this.gbo_Cust_Info.Name = "gbo_Cust_Info";
            this.gbo_Cust_Info.Size = new System.Drawing.Size(273, 344);
            this.gbo_Cust_Info.TabIndex = 42;
            this.gbo_Cust_Info.TabStop = false;
            this.gbo_Cust_Info.Text = "Customer Information";
            this.gbo_Cust_Info.Enter += new System.EventHandler(this.gbo_Cust_Info_Enter);
            // 
            // txt_Post_Code
            // 
            this.txt_Post_Code.Location = new System.Drawing.Point(109, 197);
            this.txt_Post_Code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Post_Code.Name = "txt_Post_Code";
            this.txt_Post_Code.Size = new System.Drawing.Size(153, 23);
            this.txt_Post_Code.TabIndex = 56;
            this.txt_Post_Code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Phone1_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 55;
            this.label11.Text = "Post_Code:";
            // 
            // txt_Notes
            // 
            this.txt_Notes.Location = new System.Drawing.Point(109, 232);
            this.txt_Notes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(153, 105);
            this.txt_Notes.TabIndex = 54;
            // 
            // txt_Bank_Account
            // 
            this.txt_Bank_Account.Location = new System.Drawing.Point(109, 163);
            this.txt_Bank_Account.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Bank_Account.Name = "txt_Bank_Account";
            this.txt_Bank_Account.Size = new System.Drawing.Size(153, 23);
            this.txt_Bank_Account.TabIndex = 53;
            this.txt_Bank_Account.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Phone1_KeyPress);
            // 
            // txt_Fax
            // 
            this.txt_Fax.Location = new System.Drawing.Point(109, 126);
            this.txt_Fax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Fax.Name = "txt_Fax";
            this.txt_Fax.Size = new System.Drawing.Size(153, 23);
            this.txt_Fax.TabIndex = 52;
            this.txt_Fax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Phone1_KeyPress);
            this.txt_Fax.MouseHover += new System.EventHandler(this.txt_Fax_MouseHover);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(109, 89);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(153, 23);
            this.txt_Email.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Notes:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Bank Account:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Fax:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "Email:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(109, 53);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(153, 23);
            this.txt_Name.TabIndex = 44;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(109, 20);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(153, 23);
            this.txt_ID.TabIndex = 43;
            this.txt_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Phone1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "ID:";
            // 
            // txt_Country
            // 
            this.txt_Country.Location = new System.Drawing.Point(110, 34);
            this.txt_Country.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Country.Multiline = true;
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(150, 23);
            this.txt_Country.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Country:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lebal30);
            this.groupBox1.Controls.Add(this.llbl);
            this.groupBox1.Controls.Add(this.txt_Address);
            this.groupBox1.Controls.Add(this.txt_City);
            this.groupBox1.Controls.Add(this.txt_Country);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(300, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 146);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lebal30
            // 
            this.lebal30.AutoSize = true;
            this.lebal30.Location = new System.Drawing.Point(16, 99);
            this.lebal30.Name = "lebal30";
            this.lebal30.Size = new System.Drawing.Size(66, 16);
            this.lebal30.TabIndex = 49;
            this.lebal30.Text = "address  :";
            // 
            // llbl
            // 
            this.llbl.AutoSize = true;
            this.llbl.Location = new System.Drawing.Point(16, 68);
            this.llbl.Name = "llbl";
            this.llbl.Size = new System.Drawing.Size(38, 16);
            this.llbl.TabIndex = 48;
            this.llbl.Text = "City :";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(110, 96);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(150, 23);
            this.txt_Address.TabIndex = 47;
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(110, 65);
            this.txt_City.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_City.Multiline = true;
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(150, 23);
            this.txt_City.TabIndex = 46;
            // 
            // frm_Add_Cust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(588, 380);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbo_Cust_Info);
            this.Controls.Add(this.gbo_Phone);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frm_Add_Cust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.frm_Add_Cust_Load);
            this.gbo_Phone.ResumeLayout(false);
            this.gbo_Phone.PerformLayout();
            this.gbo_Cust_Info.ResumeLayout(false);
            this.gbo_Cust_Info.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Phone3;
        private System.Windows.Forms.TextBox txt_Phone1;
        private System.Windows.Forms.TextBox txt_Phone2;
        public System.Windows.Forms.GroupBox gbo_Phone;
        public System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.GroupBox gbo_Cust_Info;
        public System.Windows.Forms.TextBox txt_Notes;
        public System.Windows.Forms.TextBox txt_Bank_Account;
        public System.Windows.Forms.TextBox txt_Fax;
        public System.Windows.Forms.TextBox txt_Email;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt_Country;
        public System.Windows.Forms.TextBox txt_Name;
        public System.Windows.Forms.TextBox txt_ID;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label llbl;
        public System.Windows.Forms.TextBox txt_Address;
        public System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.Label lebal30;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_Post_Code;
        public System.Windows.Forms.Label label11;

    }
}

