namespace Inventory
{
    partial class frm_Sales_Invoice
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Inv_No = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_Inv_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_Add_Item = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Total_Cost_Disc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Paid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbo_Created_By = new System.Windows.Forms.ComboBox();
            this.cbo_Cust_Name = new System.Windows.Forms.ComboBox();
            this.dgv_Cust_Inv = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Total_Cost = new System.Windows.Forms.TextBox();
            this.cbo_Pay_Method = new System.Windows.Forms.ComboBox();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbo_Add_Itm = new System.Windows.Forms.GroupBox();
            this.lbl_DiscoundPrice = new System.Windows.Forms.Label();
            this.txt_DisPrice = new System.Windows.Forms.TextBox();
            this.lbl_ItemDiscount = new System.Windows.Forms.Label();
            this.lbl_temPrice = new System.Windows.Forms.Label();
            this.txt_ItemDiscount = new System.Windows.Forms.TextBox();
            this.txt_ItemPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbo_ItemQty = new System.Windows.Forms.GroupBox();
            this.txt_BigQty = new System.Windows.Forms.TextBox();
            this.lbl_bigunit = new System.Windows.Forms.Label();
            this.lbl_SmallUnit = new System.Windows.Forms.Label();
            this.txt_Smallunit = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_Itm_No = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbo_Itm_Name = new System.Windows.Forms.ComboBox();
            this.cbo_Itm_Cat = new System.Windows.Forms.ComboBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.cbo_storename = new System.Windows.Forms.ComboBox();
            this.lbl_storename = new System.Windows.Forms.Label();
            this.btn_exefinalprice = new System.Windows.Forms.Button();
            this.btn_Execute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cust_Inv)).BeginInit();
            this.gbo_Add_Itm.SuspendLayout();
            this.gbo_ItemQty.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Invoice No:";
            // 
            // txt_Inv_No
            // 
            this.txt_Inv_No.Location = new System.Drawing.Point(157, 58);
            this.txt_Inv_No.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Inv_No.Name = "txt_Inv_No";
            this.txt_Inv_No.Size = new System.Drawing.Size(152, 23);
            this.txt_Inv_No.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Invoice Date:";
            // 
            // dtp_Inv_Date
            // 
            this.dtp_Inv_Date.Location = new System.Drawing.Point(157, 92);
            this.dtp_Inv_Date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_Inv_Date.Name = "dtp_Inv_Date";
            this.dtp_Inv_Date.Size = new System.Drawing.Size(152, 23);
            this.dtp_Inv_Date.TabIndex = 7;
            // 
            // btn_Add_Item
            // 
            this.btn_Add_Item.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add_Item.Location = new System.Drawing.Point(424, 18);
            this.btn_Add_Item.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add_Item.Name = "btn_Add_Item";
            this.btn_Add_Item.Size = new System.Drawing.Size(139, 26);
            this.btn_Add_Item.TabIndex = 14;
            this.btn_Add_Item.Text = "Add New Item";
            this.btn_Add_Item.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 575);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Total Cost After Discount:";
            // 
            // txt_Total_Cost_Disc
            // 
            this.txt_Total_Cost_Disc.Location = new System.Drawing.Point(170, 575);
            this.txt_Total_Cost_Disc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Total_Cost_Disc.Name = "txt_Total_Cost_Disc";
            this.txt_Total_Cost_Disc.Size = new System.Drawing.Size(153, 23);
            this.txt_Total_Cost_Disc.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 606);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Paid:";
            // 
            // txt_Paid
            // 
            this.txt_Paid.Location = new System.Drawing.Point(170, 606);
            this.txt_Paid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Paid.Name = "txt_Paid";
            this.txt_Paid.Size = new System.Drawing.Size(153, 23);
            this.txt_Paid.TabIndex = 26;
            this.txt_Paid.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(433, 553);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Created By:";
            // 
            // cbo_Created_By
            // 
            this.cbo_Created_By.FormattingEnabled = true;
            this.cbo_Created_By.Location = new System.Drawing.Point(555, 553);
            this.cbo_Created_By.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_Created_By.Name = "cbo_Created_By";
            this.cbo_Created_By.Size = new System.Drawing.Size(153, 24);
            this.cbo_Created_By.TabIndex = 31;
            // 
            // cbo_Cust_Name
            // 
            this.cbo_Cust_Name.FormattingEnabled = true;
            this.cbo_Cust_Name.Location = new System.Drawing.Point(157, 24);
            this.cbo_Cust_Name.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_Cust_Name.Name = "cbo_Cust_Name";
            this.cbo_Cust_Name.Size = new System.Drawing.Size(152, 24);
            this.cbo_Cust_Name.TabIndex = 35;
            // 
            // dgv_Cust_Inv
            // 
            this.dgv_Cust_Inv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Cust_Inv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cust_Inv.Location = new System.Drawing.Point(8, 343);
            this.dgv_Cust_Inv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_Cust_Inv.Name = "dgv_Cust_Inv";
            this.dgv_Cust_Inv.Size = new System.Drawing.Size(696, 155);
            this.dgv_Cust_Inv.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 513);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Payment Method:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 547);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Discount:";
            // 
            // txt_Discount
            // 
            this.txt_Discount.Location = new System.Drawing.Point(170, 547);
            this.txt_Discount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.Size = new System.Drawing.Size(153, 23);
            this.txt_Discount.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 522);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 44;
            this.label9.Text = "Total Cost:";
            // 
            // txt_Total_Cost
            // 
            this.txt_Total_Cost.Location = new System.Drawing.Point(170, 519);
            this.txt_Total_Cost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Total_Cost.Name = "txt_Total_Cost";
            this.txt_Total_Cost.Size = new System.Drawing.Size(153, 23);
            this.txt_Total_Cost.TabIndex = 45;
            // 
            // cbo_Pay_Method
            // 
            this.cbo_Pay_Method.FormattingEnabled = true;
            this.cbo_Pay_Method.Location = new System.Drawing.Point(555, 513);
            this.cbo_Pay_Method.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_Pay_Method.Name = "cbo_Pay_Method";
            this.cbo_Pay_Method.Size = new System.Drawing.Size(153, 24);
            this.cbo_Pay_Method.TabIndex = 46;
            // 
            // txt_Notes
            // 
            this.txt_Notes.Location = new System.Drawing.Point(509, 12);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(171, 95);
            this.txt_Notes.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 65;
            this.label7.Text = "Notes:";
            // 
            // gbo_Add_Itm
            // 
            this.gbo_Add_Itm.Controls.Add(this.lbl_DiscoundPrice);
            this.gbo_Add_Itm.Controls.Add(this.txt_DisPrice);
            this.gbo_Add_Itm.Controls.Add(this.lbl_ItemDiscount);
            this.gbo_Add_Itm.Controls.Add(this.lbl_temPrice);
            this.gbo_Add_Itm.Controls.Add(this.txt_ItemDiscount);
            this.gbo_Add_Itm.Controls.Add(this.txt_ItemPrice);
            this.gbo_Add_Itm.Controls.Add(this.button1);
            this.gbo_Add_Itm.Controls.Add(this.gbo_ItemQty);
            this.gbo_Add_Itm.Controls.Add(this.btn_add);
            this.gbo_Add_Itm.Controls.Add(this.txt_Itm_No);
            this.gbo_Add_Itm.Controls.Add(this.btn_Add_Item);
            this.gbo_Add_Itm.Controls.Add(this.label6);
            this.gbo_Add_Itm.Controls.Add(this.label15);
            this.gbo_Add_Itm.Controls.Add(this.label14);
            this.gbo_Add_Itm.Controls.Add(this.cbo_Itm_Name);
            this.gbo_Add_Itm.Controls.Add(this.cbo_Itm_Cat);
            this.gbo_Add_Itm.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_Add_Itm.Location = new System.Drawing.Point(13, 119);
            this.gbo_Add_Itm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbo_Add_Itm.Name = "gbo_Add_Itm";
            this.gbo_Add_Itm.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbo_Add_Itm.Size = new System.Drawing.Size(691, 220);
            this.gbo_Add_Itm.TabIndex = 76;
            this.gbo_Add_Itm.TabStop = false;
            this.gbo_Add_Itm.Text = "Add Item";
            this.gbo_Add_Itm.Enter += new System.EventHandler(this.gbo_Add_Itm_Enter);
            // 
            // lbl_DiscoundPrice
            // 
            this.lbl_DiscoundPrice.AutoSize = true;
            this.lbl_DiscoundPrice.Location = new System.Drawing.Point(4, 183);
            this.lbl_DiscoundPrice.Name = "lbl_DiscoundPrice";
            this.lbl_DiscoundPrice.Size = new System.Drawing.Size(91, 16);
            this.lbl_DiscoundPrice.TabIndex = 127;
            this.lbl_DiscoundPrice.Tag = "";
            this.lbl_DiscoundPrice.Text = "Discound Price";
            this.lbl_DiscoundPrice.UseWaitCursor = true;
            // 
            // txt_DisPrice
            // 
            this.txt_DisPrice.Location = new System.Drawing.Point(144, 178);
            this.txt_DisPrice.Name = "txt_DisPrice";
            this.txt_DisPrice.Size = new System.Drawing.Size(152, 23);
            this.txt_DisPrice.TabIndex = 126;
            this.txt_DisPrice.UseWaitCursor = true;
            // 
            // lbl_ItemDiscount
            // 
            this.lbl_ItemDiscount.AutoSize = true;
            this.lbl_ItemDiscount.Location = new System.Drawing.Point(3, 149);
            this.lbl_ItemDiscount.Name = "lbl_ItemDiscount";
            this.lbl_ItemDiscount.Size = new System.Drawing.Size(86, 16);
            this.lbl_ItemDiscount.TabIndex = 125;
            this.lbl_ItemDiscount.Text = "Item Discount";
            this.lbl_ItemDiscount.UseWaitCursor = true;
            // 
            // lbl_temPrice
            // 
            this.lbl_temPrice.AutoSize = true;
            this.lbl_temPrice.Location = new System.Drawing.Point(3, 119);
            this.lbl_temPrice.Name = "lbl_temPrice";
            this.lbl_temPrice.Size = new System.Drawing.Size(66, 16);
            this.lbl_temPrice.TabIndex = 124;
            this.lbl_temPrice.Text = "Item Price";
            this.lbl_temPrice.UseWaitCursor = true;
            // 
            // txt_ItemDiscount
            // 
            this.txt_ItemDiscount.Location = new System.Drawing.Point(144, 147);
            this.txt_ItemDiscount.Name = "txt_ItemDiscount";
            this.txt_ItemDiscount.Size = new System.Drawing.Size(152, 23);
            this.txt_ItemDiscount.TabIndex = 123;
            this.txt_ItemDiscount.UseWaitCursor = true;
            // 
            // txt_ItemPrice
            // 
            this.txt_ItemPrice.Location = new System.Drawing.Point(144, 116);
            this.txt_ItemPrice.Name = "txt_ItemPrice";
            this.txt_ItemPrice.Size = new System.Drawing.Size(152, 23);
            this.txt_ItemPrice.TabIndex = 122;
            this.txt_ItemPrice.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(547, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 26);
            this.button1.TabIndex = 120;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gbo_ItemQty
            // 
            this.gbo_ItemQty.Controls.Add(this.txt_BigQty);
            this.gbo_ItemQty.Controls.Add(this.lbl_bigunit);
            this.gbo_ItemQty.Controls.Add(this.lbl_SmallUnit);
            this.gbo_ItemQty.Controls.Add(this.txt_Smallunit);
            this.gbo_ItemQty.Location = new System.Drawing.Point(389, 51);
            this.gbo_ItemQty.Name = "gbo_ItemQty";
            this.gbo_ItemQty.Size = new System.Drawing.Size(250, 100);
            this.gbo_ItemQty.TabIndex = 121;
            this.gbo_ItemQty.TabStop = false;
            this.gbo_ItemQty.Text = "ItemQty";
            this.gbo_ItemQty.UseWaitCursor = true;
            // 
            // txt_BigQty
            // 
            this.txt_BigQty.Location = new System.Drawing.Point(16, 63);
            this.txt_BigQty.Name = "txt_BigQty";
            this.txt_BigQty.Size = new System.Drawing.Size(92, 23);
            this.txt_BigQty.TabIndex = 51;
            this.txt_BigQty.UseWaitCursor = true;
            // 
            // lbl_bigunit
            // 
            this.lbl_bigunit.AutoSize = true;
            this.lbl_bigunit.Location = new System.Drawing.Point(12, 28);
            this.lbl_bigunit.Name = "lbl_bigunit";
            this.lbl_bigunit.Size = new System.Drawing.Size(56, 16);
            this.lbl_bigunit.TabIndex = 63;
            this.lbl_bigunit.Text = "BigUnit :";
            this.lbl_bigunit.UseWaitCursor = true;
            // 
            // lbl_SmallUnit
            // 
            this.lbl_SmallUnit.AutoSize = true;
            this.lbl_SmallUnit.Location = new System.Drawing.Point(138, 28);
            this.lbl_SmallUnit.Name = "lbl_SmallUnit";
            this.lbl_SmallUnit.Size = new System.Drawing.Size(71, 16);
            this.lbl_SmallUnit.TabIndex = 64;
            this.lbl_SmallUnit.Text = "SmallUnit :";
            this.lbl_SmallUnit.UseWaitCursor = true;
            // 
            // txt_Smallunit
            // 
            this.txt_Smallunit.Location = new System.Drawing.Point(142, 63);
            this.txt_Smallunit.Name = "txt_Smallunit";
            this.txt_Smallunit.Size = new System.Drawing.Size(92, 23);
            this.txt_Smallunit.TabIndex = 65;
            this.txt_Smallunit.UseWaitCursor = true;
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Location = new System.Drawing.Point(389, 169);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(92, 26);
            this.btn_add.TabIndex = 119;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.UseWaitCursor = true;
            this.btn_add.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_Itm_No
            // 
            this.txt_Itm_No.Location = new System.Drawing.Point(144, 21);
            this.txt_Itm_No.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Itm_No.Name = "txt_Itm_No";
            this.txt_Itm_No.Size = new System.Drawing.Size(152, 23);
            this.txt_Itm_No.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 52;
            this.label6.Text = "Item No:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 51);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 16);
            this.label15.TabIndex = 47;
            this.label15.Text = "Item Category:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 83);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 16);
            this.label14.TabIndex = 44;
            this.label14.Text = "Item Name:";
            // 
            // cbo_Itm_Name
            // 
            this.cbo_Itm_Name.FormattingEnabled = true;
            this.cbo_Itm_Name.Location = new System.Drawing.Point(144, 84);
            this.cbo_Itm_Name.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_Itm_Name.Name = "cbo_Itm_Name";
            this.cbo_Itm_Name.Size = new System.Drawing.Size(152, 24);
            this.cbo_Itm_Name.TabIndex = 45;
            this.cbo_Itm_Name.SelectedIndexChanged += new System.EventHandler(this.cbo_Itm_Name_SelectedIndexChanged);
            // 
            // cbo_Itm_Cat
            // 
            this.cbo_Itm_Cat.FormattingEnabled = true;
            this.cbo_Itm_Cat.Location = new System.Drawing.Point(144, 52);
            this.cbo_Itm_Cat.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_Itm_Cat.Name = "cbo_Itm_Cat";
            this.cbo_Itm_Cat.Size = new System.Drawing.Size(152, 24);
            this.cbo_Itm_Cat.TabIndex = 48;
            this.cbo_Itm_Cat.SelectedIndexChanged += new System.EventHandler(this.cbo_Itm_Cat_SelectedIndexChanged);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel.Location = new System.Drawing.Point(614, 638);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(89, 29);
            this.btn_Cancel.TabIndex = 78;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Location = new System.Drawing.Point(521, 638);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(89, 29);
            this.btn_Save.TabIndex = 77;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Print.Location = new System.Drawing.Point(432, 638);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(89, 29);
            this.btn_Print.TabIndex = 118;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // cbo_storename
            // 
            this.cbo_storename.FormattingEnabled = true;
            this.cbo_storename.Location = new System.Drawing.Point(555, 593);
            this.cbo_storename.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cbo_storename.Name = "cbo_storename";
            this.cbo_storename.Size = new System.Drawing.Size(153, 24);
            this.cbo_storename.TabIndex = 120;
            this.cbo_storename.UseWaitCursor = true;
            // 
            // lbl_storename
            // 
            this.lbl_storename.AutoSize = true;
            this.lbl_storename.Location = new System.Drawing.Point(433, 593);
            this.lbl_storename.Name = "lbl_storename";
            this.lbl_storename.Size = new System.Drawing.Size(85, 16);
            this.lbl_storename.TabIndex = 119;
            this.lbl_storename.Text = "Store Name :";
            this.lbl_storename.UseWaitCursor = true;
            // 
            // btn_exefinalprice
            // 
            this.btn_exefinalprice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exefinalprice.Location = new System.Drawing.Point(329, 575);
            this.btn_exefinalprice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_exefinalprice.Name = "btn_exefinalprice";
            this.btn_exefinalprice.Size = new System.Drawing.Size(73, 28);
            this.btn_exefinalprice.TabIndex = 122;
            this.btn_exefinalprice.Text = "Execute";
            this.btn_exefinalprice.UseVisualStyleBackColor = true;
            this.btn_exefinalprice.UseWaitCursor = true;
            this.btn_exefinalprice.Click += new System.EventHandler(this.btn_exefinalprice_Click);
            // 
            // btn_Execute
            // 
            this.btn_Execute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Execute.Location = new System.Drawing.Point(329, 513);
            this.btn_Execute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Size = new System.Drawing.Size(73, 28);
            this.btn_Execute.TabIndex = 121;
            this.btn_Execute.Text = "Execute";
            this.btn_Execute.UseVisualStyleBackColor = true;
            this.btn_Execute.UseWaitCursor = true;
            this.btn_Execute.Click += new System.EventHandler(this.btn_Execute_Click);
            // 
            // frm_Sales_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(764, 676);
            this.Controls.Add(this.btn_exefinalprice);
            this.Controls.Add(this.btn_Execute);
            this.Controls.Add(this.cbo_storename);
            this.Controls.Add(this.lbl_storename);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gbo_Add_Itm);
            this.Controls.Add(this.txt_Notes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbo_Pay_Method);
            this.Controls.Add(this.txt_Total_Cost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Discount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbo_Cust_Name);
            this.Controls.Add(this.cbo_Created_By);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_Paid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_Total_Cost_Disc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgv_Cust_Inv);
            this.Controls.Add(this.dtp_Inv_Date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Inv_No);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frm_Sales_Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Invoice";
            this.Load += new System.EventHandler(this.frm_Sales_Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cust_Inv)).EndInit();
            this.gbo_Add_Itm.ResumeLayout(false);
            this.gbo_Add_Itm.PerformLayout();
            this.gbo_ItemQty.ResumeLayout(false);
            this.gbo_ItemQty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Inv_No;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_Inv_Date;
        private System.Windows.Forms.Button btn_Add_Item;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Total_Cost_Disc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Paid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbo_Created_By;
        private System.Windows.Forms.ComboBox cbo_Cust_Name;
        private System.Windows.Forms.DataGridView dgv_Cust_Inv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Discount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Total_Cost;
        private System.Windows.Forms.ComboBox cbo_Pay_Method;
        private System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbo_Add_Itm;
        private System.Windows.Forms.TextBox txt_Itm_No;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbo_Itm_Name;
        private System.Windows.Forms.ComboBox cbo_Itm_Cat;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.GroupBox gbo_ItemQty;
        private System.Windows.Forms.TextBox txt_BigQty;
        private System.Windows.Forms.Label lbl_bigunit;
        private System.Windows.Forms.Label lbl_SmallUnit;
        private System.Windows.Forms.TextBox txt_Smallunit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_DiscoundPrice;
        private System.Windows.Forms.TextBox txt_DisPrice;
        private System.Windows.Forms.Label lbl_ItemDiscount;
        private System.Windows.Forms.Label lbl_temPrice;
        private System.Windows.Forms.TextBox txt_ItemDiscount;
        private System.Windows.Forms.TextBox txt_ItemPrice;
        private System.Windows.Forms.ComboBox cbo_storename;
        private System.Windows.Forms.Label lbl_storename;
        private System.Windows.Forms.Button btn_exefinalprice;
        private System.Windows.Forms.Button btn_Execute;
    }
}

