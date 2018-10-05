namespace Inventory
{
    partial class frm_Purchase_Invoice
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
            this.projectDataSet7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbo_Supp_Name = new System.Windows.Forms.ComboBox();
            this.dtp_Inv_Date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Inv_No = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_Pay_Method = new System.Windows.Forms.ComboBox();
            this.txt_Total_Cost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_Created_By = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Paid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Total_Cost_Disc = new System.Windows.Forms.TextBox();
            this.lbl_finalcost = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gbo_Add_Itm = new System.Windows.Forms.GroupBox();
            this.gbo_ItemQty = new System.Windows.Forms.GroupBox();
            this.txt_BigQty = new System.Windows.Forms.TextBox();
            this.lbl_bigunit = new System.Windows.Forms.Label();
            this.lbl_SmallUnit = new System.Windows.Forms.Label();
            this.txt_Smallunit = new System.Windows.Forms.TextBox();
            this.lbl_DiscoundPrice = new System.Windows.Forms.Label();
            this.txt_DisPrice = new System.Windows.Forms.TextBox();
            this.lbl_ItemDiscount = new System.Windows.Forms.Label();
            this.lbl_temPrice = new System.Windows.Forms.Label();
            this.txt_ItemDiscount = new System.Windows.Forms.TextBox();
            this.txt_ItemPrice = new System.Windows.Forms.TextBox();
            this.btn_Add_New_Itm = new System.Windows.Forms.Button();
            this.btn_Del_Itm = new System.Windows.Forms.Button();
            this.btn_Add_Itm = new System.Windows.Forms.Button();
            this.txt_Itm_No = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbo_Itm_Name = new System.Windows.Forms.ComboBox();
            this.cbo_Itm_Cat = new System.Windows.Forms.ComboBox();
            this.btn_Print = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbo_storename = new System.Windows.Forms.ComboBox();
            this.btn_Execute = new System.Windows.Forms.Button();
            this.btn_exefinalprice = new System.Windows.Forms.Button();
            this.dgv_Pur_Inv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet7BindingSource)).BeginInit();
            this.gbo_Add_Itm.SuspendLayout();
            this.gbo_ItemQty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pur_Inv)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_Supp_Name
            // 
            this.cbo_Supp_Name.FormattingEnabled = true;
            this.cbo_Supp_Name.Location = new System.Drawing.Point(141, 21);
            this.cbo_Supp_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_Supp_Name.Name = "cbo_Supp_Name";
            this.cbo_Supp_Name.Size = new System.Drawing.Size(180, 25);
            this.cbo_Supp_Name.TabIndex = 83;
            this.cbo_Supp_Name.UseWaitCursor = true;
            // 
            // dtp_Inv_Date
            // 
            this.dtp_Inv_Date.Location = new System.Drawing.Point(141, 90);
            this.dtp_Inv_Date.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.dtp_Inv_Date.Name = "dtp_Inv_Date";
            this.dtp_Inv_Date.Size = new System.Drawing.Size(180, 24);
            this.dtp_Inv_Date.TabIndex = 82;
            this.dtp_Inv_Date.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 81;
            this.label4.Text = "Invoice Date:";
            this.label4.UseWaitCursor = true;
            // 
            // txt_Inv_No
            // 
            this.txt_Inv_No.Location = new System.Drawing.Point(141, 56);
            this.txt_Inv_No.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txt_Inv_No.Name = "txt_Inv_No";
            this.txt_Inv_No.Size = new System.Drawing.Size(180, 24);
            this.txt_Inv_No.TabIndex = 80;
            this.txt_Inv_No.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 79;
            this.label3.Text = "Invoice No:";
            this.label3.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 78;
            this.label1.Text = "Supplier Name:";
            this.label1.UseWaitCursor = true;
            // 
            // txt_Notes
            // 
            this.txt_Notes.Location = new System.Drawing.Point(565, 20);
            this.txt_Notes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(202, 106);
            this.txt_Notes.TabIndex = 86;
            this.txt_Notes.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(489, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 85;
            this.label7.Text = "Notes:";
            this.label7.UseWaitCursor = true;
            // 
            // cbo_Pay_Method
            // 
            this.cbo_Pay_Method.FormattingEnabled = true;
            this.cbo_Pay_Method.Location = new System.Drawing.Point(646, 544);
            this.cbo_Pay_Method.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.cbo_Pay_Method.Name = "cbo_Pay_Method";
            this.cbo_Pay_Method.Size = new System.Drawing.Size(194, 25);
            this.cbo_Pay_Method.TabIndex = 98;
            this.cbo_Pay_Method.UseWaitCursor = true;
            // 
            // txt_Total_Cost
            // 
            this.txt_Total_Cost.Location = new System.Drawing.Point(112, 547);
            this.txt_Total_Cost.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txt_Total_Cost.Name = "txt_Total_Cost";
            this.txt_Total_Cost.Size = new System.Drawing.Size(196, 24);
            this.txt_Total_Cost.TabIndex = 97;
            this.txt_Total_Cost.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 547);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 96;
            this.label2.Text = "Total Cost:";
            this.label2.UseWaitCursor = true;
            // 
            // txt_Discount
            // 
            this.txt_Discount.Location = new System.Drawing.Point(112, 581);
            this.txt_Discount.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.Size = new System.Drawing.Size(196, 24);
            this.txt_Discount.TabIndex = 95;
            this.txt_Discount.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 579);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 94;
            this.label5.Text = "Discount:";
            this.label5.UseWaitCursor = true;
            // 
            // cbo_Created_By
            // 
            this.cbo_Created_By.FormattingEnabled = true;
            this.cbo_Created_By.Location = new System.Drawing.Point(646, 579);
            this.cbo_Created_By.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.cbo_Created_By.Name = "cbo_Created_By";
            this.cbo_Created_By.Size = new System.Drawing.Size(194, 25);
            this.cbo_Created_By.TabIndex = 93;
            this.cbo_Created_By.UseWaitCursor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(507, 579);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 17);
            this.label12.TabIndex = 92;
            this.label12.Text = "Created By:";
            this.label12.UseWaitCursor = true;
            // 
            // txt_Paid
            // 
            this.txt_Paid.Location = new System.Drawing.Point(112, 649);
            this.txt_Paid.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txt_Paid.Name = "txt_Paid";
            this.txt_Paid.Size = new System.Drawing.Size(196, 24);
            this.txt_Paid.TabIndex = 91;
            this.txt_Paid.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 653);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 90;
            this.label6.Text = "Paid:";
            this.label6.UseWaitCursor = true;
            // 
            // txt_Total_Cost_Disc
            // 
            this.txt_Total_Cost_Disc.Location = new System.Drawing.Point(112, 615);
            this.txt_Total_Cost_Disc.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.txt_Total_Cost_Disc.Name = "txt_Total_Cost_Disc";
            this.txt_Total_Cost_Disc.Size = new System.Drawing.Size(196, 24);
            this.txt_Total_Cost_Disc.TabIndex = 89;
            this.txt_Total_Cost_Disc.UseWaitCursor = true;
            // 
            // lbl_finalcost
            // 
            this.lbl_finalcost.AutoSize = true;
            this.lbl_finalcost.Location = new System.Drawing.Point(12, 619);
            this.lbl_finalcost.Name = "lbl_finalcost";
            this.lbl_finalcost.Size = new System.Drawing.Size(84, 17);
            this.lbl_finalcost.TabIndex = 88;
            this.lbl_finalcost.Text = "Final Cost :";
            this.lbl_finalcost.UseWaitCursor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(506, 547);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 17);
            this.label14.TabIndex = 87;
            this.label14.Text = "Payment Method:";
            this.label14.UseWaitCursor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel.Location = new System.Drawing.Point(733, 664);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(107, 25);
            this.btn_Cancel.TabIndex = 100;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.UseWaitCursor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Location = new System.Drawing.Point(620, 664);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(107, 25);
            this.btn_Save.TabIndex = 99;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.UseWaitCursor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // gbo_Add_Itm
            // 
            this.gbo_Add_Itm.Controls.Add(this.gbo_ItemQty);
            this.gbo_Add_Itm.Controls.Add(this.lbl_DiscoundPrice);
            this.gbo_Add_Itm.Controls.Add(this.txt_DisPrice);
            this.gbo_Add_Itm.Controls.Add(this.lbl_ItemDiscount);
            this.gbo_Add_Itm.Controls.Add(this.lbl_temPrice);
            this.gbo_Add_Itm.Controls.Add(this.txt_ItemDiscount);
            this.gbo_Add_Itm.Controls.Add(this.txt_ItemPrice);
            this.gbo_Add_Itm.Controls.Add(this.btn_Add_New_Itm);
            this.gbo_Add_Itm.Controls.Add(this.btn_Del_Itm);
            this.gbo_Add_Itm.Controls.Add(this.btn_Add_Itm);
            this.gbo_Add_Itm.Controls.Add(this.txt_Itm_No);
            this.gbo_Add_Itm.Controls.Add(this.label8);
            this.gbo_Add_Itm.Controls.Add(this.label15);
            this.gbo_Add_Itm.Controls.Add(this.label9);
            this.gbo_Add_Itm.Controls.Add(this.cbo_Itm_Name);
            this.gbo_Add_Itm.Controls.Add(this.cbo_Itm_Cat);
            this.gbo_Add_Itm.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_Add_Itm.Location = new System.Drawing.Point(21, 136);
            this.gbo_Add_Itm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbo_Add_Itm.Name = "gbo_Add_Itm";
            this.gbo_Add_Itm.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbo_Add_Itm.Size = new System.Drawing.Size(819, 208);
            this.gbo_Add_Itm.TabIndex = 101;
            this.gbo_Add_Itm.TabStop = false;
            this.gbo_Add_Itm.Text = "Add Item";
            this.gbo_Add_Itm.UseCompatibleTextRendering = true;
            // 
            // gbo_ItemQty
            // 
            this.gbo_ItemQty.Controls.Add(this.txt_BigQty);
            this.gbo_ItemQty.Controls.Add(this.lbl_bigunit);
            this.gbo_ItemQty.Controls.Add(this.lbl_SmallUnit);
            this.gbo_ItemQty.Controls.Add(this.txt_Smallunit);
            this.gbo_ItemQty.Location = new System.Drawing.Point(471, 53);
            this.gbo_ItemQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbo_ItemQty.Name = "gbo_ItemQty";
            this.gbo_ItemQty.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbo_ItemQty.Size = new System.Drawing.Size(275, 110);
            this.gbo_ItemQty.TabIndex = 66;
            this.gbo_ItemQty.TabStop = false;
            this.gbo_ItemQty.Text = "ItemQty";
            this.gbo_ItemQty.UseWaitCursor = true;
            // 
            // txt_BigQty
            // 
            this.txt_BigQty.Location = new System.Drawing.Point(18, 70);
            this.txt_BigQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_BigQty.Name = "txt_BigQty";
            this.txt_BigQty.Size = new System.Drawing.Size(100, 23);
            this.txt_BigQty.TabIndex = 51;
            this.txt_BigQty.UseWaitCursor = true;
            // 
            // lbl_bigunit
            // 
            this.lbl_bigunit.AutoSize = true;
            this.lbl_bigunit.Location = new System.Drawing.Point(14, 32);
            this.lbl_bigunit.Name = "lbl_bigunit";
            this.lbl_bigunit.Size = new System.Drawing.Size(56, 16);
            this.lbl_bigunit.TabIndex = 63;
            this.lbl_bigunit.Text = "BigUnit :";
            this.lbl_bigunit.UseWaitCursor = true;
            // 
            // lbl_SmallUnit
            // 
            this.lbl_SmallUnit.AutoSize = true;
            this.lbl_SmallUnit.Location = new System.Drawing.Point(151, 32);
            this.lbl_SmallUnit.Name = "lbl_SmallUnit";
            this.lbl_SmallUnit.Size = new System.Drawing.Size(71, 16);
            this.lbl_SmallUnit.TabIndex = 64;
            this.lbl_SmallUnit.Text = "SmallUnit :";
            this.lbl_SmallUnit.UseWaitCursor = true;
            // 
            // txt_Smallunit
            // 
            this.txt_Smallunit.Location = new System.Drawing.Point(157, 70);
            this.txt_Smallunit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Smallunit.Name = "txt_Smallunit";
            this.txt_Smallunit.Size = new System.Drawing.Size(100, 23);
            this.txt_Smallunit.TabIndex = 65;
            this.txt_Smallunit.UseWaitCursor = true;
            // 
            // lbl_DiscoundPrice
            // 
            this.lbl_DiscoundPrice.AutoSize = true;
            this.lbl_DiscoundPrice.Location = new System.Drawing.Point(-1, 176);
            this.lbl_DiscoundPrice.Name = "lbl_DiscoundPrice";
            this.lbl_DiscoundPrice.Size = new System.Drawing.Size(91, 16);
            this.lbl_DiscoundPrice.TabIndex = 62;
            this.lbl_DiscoundPrice.Tag = "";
            this.lbl_DiscoundPrice.Text = "Discound Price";
            this.lbl_DiscoundPrice.UseWaitCursor = true;
            // 
            // txt_DisPrice
            // 
            this.txt_DisPrice.Location = new System.Drawing.Point(120, 173);
            this.txt_DisPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DisPrice.Name = "txt_DisPrice";
            this.txt_DisPrice.Size = new System.Drawing.Size(180, 23);
            this.txt_DisPrice.TabIndex = 61;
            this.txt_DisPrice.UseWaitCursor = true;
            // 
            // lbl_ItemDiscount
            // 
            this.lbl_ItemDiscount.AutoSize = true;
            this.lbl_ItemDiscount.Location = new System.Drawing.Point(-1, 146);
            this.lbl_ItemDiscount.Name = "lbl_ItemDiscount";
            this.lbl_ItemDiscount.Size = new System.Drawing.Size(86, 16);
            this.lbl_ItemDiscount.TabIndex = 60;
            this.lbl_ItemDiscount.Text = "Item Discount";
            this.lbl_ItemDiscount.UseWaitCursor = true;
            // 
            // lbl_temPrice
            // 
            this.lbl_temPrice.AutoSize = true;
            this.lbl_temPrice.Location = new System.Drawing.Point(-1, 115);
            this.lbl_temPrice.Name = "lbl_temPrice";
            this.lbl_temPrice.Size = new System.Drawing.Size(66, 16);
            this.lbl_temPrice.TabIndex = 59;
            this.lbl_temPrice.Text = "Item Price";
            this.lbl_temPrice.UseWaitCursor = true;
            // 
            // txt_ItemDiscount
            // 
            this.txt_ItemDiscount.Location = new System.Drawing.Point(120, 143);
            this.txt_ItemDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ItemDiscount.Name = "txt_ItemDiscount";
            this.txt_ItemDiscount.Size = new System.Drawing.Size(180, 23);
            this.txt_ItemDiscount.TabIndex = 58;
            this.txt_ItemDiscount.UseWaitCursor = true;
            // 
            // txt_ItemPrice
            // 
            this.txt_ItemPrice.Location = new System.Drawing.Point(120, 113);
            this.txt_ItemPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ItemPrice.Name = "txt_ItemPrice";
            this.txt_ItemPrice.Size = new System.Drawing.Size(180, 23);
            this.txt_ItemPrice.TabIndex = 57;
            this.txt_ItemPrice.UseWaitCursor = true;
            // 
            // btn_Add_New_Itm
            // 
            this.btn_Add_New_Itm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add_New_Itm.Location = new System.Drawing.Point(519, 13);
            this.btn_Add_New_Itm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add_New_Itm.Name = "btn_Add_New_Itm";
            this.btn_Add_New_Itm.Size = new System.Drawing.Size(148, 32);
            this.btn_Add_New_Itm.TabIndex = 56;
            this.btn_Add_New_Itm.Text = "Add New Item";
            this.btn_Add_New_Itm.UseVisualStyleBackColor = true;
            this.btn_Add_New_Itm.UseWaitCursor = true;
            // 
            // btn_Del_Itm
            // 
            this.btn_Del_Itm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Del_Itm.Location = new System.Drawing.Point(644, 167);
            this.btn_Del_Itm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Del_Itm.Name = "btn_Del_Itm";
            this.btn_Del_Itm.Size = new System.Drawing.Size(102, 34);
            this.btn_Del_Itm.TabIndex = 55;
            this.btn_Del_Itm.Text = "Delete";
            this.btn_Del_Itm.UseVisualStyleBackColor = true;
            this.btn_Del_Itm.Click += new System.EventHandler(this.btn_Del_Itm_Click);
            // 
            // btn_Add_Itm
            // 
            this.btn_Add_Itm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add_Itm.Location = new System.Drawing.Point(471, 167);
            this.btn_Add_Itm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add_Itm.Name = "btn_Add_Itm";
            this.btn_Add_Itm.Size = new System.Drawing.Size(102, 34);
            this.btn_Add_Itm.TabIndex = 54;
            this.btn_Add_Itm.Text = "Add";
            this.btn_Add_Itm.UseVisualStyleBackColor = true;
            this.btn_Add_Itm.UseWaitCursor = true;
            this.btn_Add_Itm.Click += new System.EventHandler(this.btn_Add_Itm_Click);
            // 
            // txt_Itm_No
            // 
            this.txt_Itm_No.Location = new System.Drawing.Point(120, 21);
            this.txt_Itm_No.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Itm_No.Name = "txt_Itm_No";
            this.txt_Itm_No.Size = new System.Drawing.Size(180, 23);
            this.txt_Itm_No.TabIndex = 53;
            this.txt_Itm_No.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 52;
            this.label8.Text = "Item No:";
            this.label8.UseWaitCursor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(-1, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 16);
            this.label15.TabIndex = 47;
            this.label15.Text = "Item Category:";
            this.label15.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-1, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 44;
            this.label9.Text = "Item Name:";
            this.label9.UseWaitCursor = true;
            // 
            // cbo_Itm_Name
            // 
            this.cbo_Itm_Name.FormattingEnabled = true;
            this.cbo_Itm_Name.Location = new System.Drawing.Point(120, 82);
            this.cbo_Itm_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_Itm_Name.Name = "cbo_Itm_Name";
            this.cbo_Itm_Name.Size = new System.Drawing.Size(180, 24);
            this.cbo_Itm_Name.TabIndex = 45;
            this.cbo_Itm_Name.UseWaitCursor = true;
            this.cbo_Itm_Name.SelectedIndexChanged += new System.EventHandler(this.cbo_Itm_Name_SelectedIndexChanged);
            // 
            // cbo_Itm_Cat
            // 
            this.cbo_Itm_Cat.FormattingEnabled = true;
            this.cbo_Itm_Cat.Location = new System.Drawing.Point(120, 51);
            this.cbo_Itm_Cat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_Itm_Cat.Name = "cbo_Itm_Cat";
            this.cbo_Itm_Cat.Size = new System.Drawing.Size(180, 24);
            this.cbo_Itm_Cat.TabIndex = 48;
            this.cbo_Itm_Cat.UseWaitCursor = true;
            this.cbo_Itm_Cat.SelectedIndexChanged += new System.EventHandler(this.cbo_Itm_Cat_SelectedIndexChanged);
            // 
            // btn_Print
            // 
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Print.Location = new System.Drawing.Point(509, 664);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(107, 25);
            this.btn_Print.TabIndex = 117;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(506, 619);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 67;
            this.label10.Text = "Store Name";
            this.label10.UseWaitCursor = true;
            // 
            // cbo_storename
            // 
            this.cbo_storename.FormattingEnabled = true;
            this.cbo_storename.Location = new System.Drawing.Point(646, 614);
            this.cbo_storename.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.cbo_storename.Name = "cbo_storename";
            this.cbo_storename.Size = new System.Drawing.Size(194, 25);
            this.cbo_storename.TabIndex = 118;
            this.cbo_storename.UseWaitCursor = true;
            // 
            // btn_Execute
            // 
            this.btn_Execute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Execute.Location = new System.Drawing.Point(314, 547);
            this.btn_Execute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Size = new System.Drawing.Size(92, 22);
            this.btn_Execute.TabIndex = 119;
            this.btn_Execute.Text = "Execute";
            this.btn_Execute.UseVisualStyleBackColor = true;
            this.btn_Execute.UseWaitCursor = true;
            this.btn_Execute.Click += new System.EventHandler(this.btn_Execute_Click);
            // 
            // btn_exefinalprice
            // 
            this.btn_exefinalprice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exefinalprice.Location = new System.Drawing.Point(314, 615);
            this.btn_exefinalprice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_exefinalprice.Name = "btn_exefinalprice";
            this.btn_exefinalprice.Size = new System.Drawing.Size(92, 24);
            this.btn_exefinalprice.TabIndex = 120;
            this.btn_exefinalprice.Text = "Execute";
            this.btn_exefinalprice.UseVisualStyleBackColor = true;
            this.btn_exefinalprice.UseWaitCursor = true;
            this.btn_exefinalprice.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_Pur_Inv
            // 
            this.dgv_Pur_Inv.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Pur_Inv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pur_Inv.Location = new System.Drawing.Point(11, 352);
            this.dgv_Pur_Inv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_Pur_Inv.Name = "dgv_Pur_Inv";
            this.dgv_Pur_Inv.RowTemplate.Height = 26;
            this.dgv_Pur_Inv.Size = new System.Drawing.Size(829, 176);
            this.dgv_Pur_Inv.TabIndex = 121;
            // 
            // frm_Purchase_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(848, 699);
            this.Controls.Add(this.dgv_Pur_Inv);
            this.Controls.Add(this.btn_exefinalprice);
            this.Controls.Add(this.btn_Execute);
            this.Controls.Add(this.cbo_storename);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.gbo_Add_Itm);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cbo_Pay_Method);
            this.Controls.Add(this.txt_Total_Cost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Discount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbo_Created_By);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_Paid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Total_Cost_Disc);
            this.Controls.Add(this.lbl_finalcost);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_Notes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbo_Supp_Name);
            this.Controls.Add(this.dtp_Inv_Date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Inv_No);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frm_Purchase_Invoice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Invoice";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet7BindingSource)).EndInit();
            this.gbo_Add_Itm.ResumeLayout(false);
            this.gbo_Add_Itm.PerformLayout();
            this.gbo_ItemQty.ResumeLayout(false);
            this.gbo_ItemQty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pur_Inv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_Supp_Name;
        private System.Windows.Forms.DateTimePicker dtp_Inv_Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Inv_No;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_Pay_Method;
        private System.Windows.Forms.TextBox txt_Total_Cost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Discount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_Created_By;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Paid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Total_Cost_Disc;
        private System.Windows.Forms.Label lbl_finalcost;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox gbo_Add_Itm;
        private System.Windows.Forms.Button btn_Add_New_Itm;
        private System.Windows.Forms.Button btn_Del_Itm;
        private System.Windows.Forms.Button btn_Add_Itm;
        private System.Windows.Forms.TextBox txt_Itm_No;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_BigQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbo_Itm_Name;
        private System.Windows.Forms.ComboBox cbo_Itm_Cat;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.BindingSource projectDataSet7BindingSource;
     
        private System.Windows.Forms.Label lbl_ItemDiscount;
        private System.Windows.Forms.Label lbl_temPrice;
        private System.Windows.Forms.TextBox txt_ItemDiscount;
        private System.Windows.Forms.TextBox txt_ItemPrice;
        private System.Windows.Forms.Label lbl_DiscoundPrice;
        private System.Windows.Forms.TextBox txt_DisPrice;
        private System.Windows.Forms.TextBox txt_Smallunit;
        private System.Windows.Forms.Label lbl_SmallUnit;
        private System.Windows.Forms.Label lbl_bigunit;
        private System.Windows.Forms.GroupBox gbo_ItemQty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbo_storename;
        private System.Windows.Forms.Button btn_Execute;
        private System.Windows.Forms.Button btn_exefinalprice;
        private System.Windows.Forms.DataGridView dgv_Pur_Inv;
    }
}

