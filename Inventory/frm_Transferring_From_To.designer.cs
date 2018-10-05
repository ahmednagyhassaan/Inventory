namespace Inventory
{
    partial class frm_Transferring_From_To
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Transfer_No = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_Created_By = new System.Windows.Forms.ComboBox();
            this.cbo_Sto_Type_From = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_Sto_Type_To = new System.Windows.Forms.ComboBox();
            this.gbo_Transfer = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_Sto_Name_To = new System.Windows.Forms.ComboBox();
            this.cbo_Sto_Name_From = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_Created_At = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Load_items = new System.Windows.Forms.Button();
            this.gbo_Add_Itm = new System.Windows.Forms.GroupBox();
            this.lbl_Small_Unit = new System.Windows.Forms.Label();
            this.lbl_Big_Unit = new System.Windows.Forms.Label();
            this.txt_Qty_Small_Unit = new System.Windows.Forms.TextBox();
            this.btn_Del_Itm = new System.Windows.Forms.Button();
            this.btn_Add_Itm = new System.Windows.Forms.Button();
            this.txt_Qty_Big_Unit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbo_Itm_Name = new System.Windows.Forms.ComboBox();
            this.dgv_Itm_Transfered = new System.Windows.Forms.DataGridView();
            this.gbo_Transfer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbo_Add_Itm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Itm_Transfered)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order No:";
            // 
            // txt_Transfer_No
            // 
            this.txt_Transfer_No.Enabled = false;
            this.txt_Transfer_No.Location = new System.Drawing.Point(105, 25);
            this.txt_Transfer_No.Name = "txt_Transfer_No";
            this.txt_Transfer_No.Size = new System.Drawing.Size(152, 23);
            this.txt_Transfer_No.TabIndex = 1;
            this.txt_Transfer_No.TextChanged += new System.EventHandler(this.txt_Transfer_No_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Created By:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "From:";
            // 
            // cbo_Created_By
            // 
            this.cbo_Created_By.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Created_By.FormattingEnabled = true;
            this.cbo_Created_By.Location = new System.Drawing.Point(105, 54);
            this.cbo_Created_By.Name = "cbo_Created_By";
            this.cbo_Created_By.Size = new System.Drawing.Size(152, 24);
            this.cbo_Created_By.TabIndex = 8;
            // 
            // cbo_Sto_Type_From
            // 
            this.cbo_Sto_Type_From.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Sto_Type_From.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Sto_Type_From.FormattingEnabled = true;
            this.cbo_Sto_Type_From.Location = new System.Drawing.Point(102, 16);
            this.cbo_Sto_Type_From.Name = "cbo_Sto_Type_From";
            this.cbo_Sto_Type_From.Size = new System.Drawing.Size(152, 24);
            this.cbo_Sto_Type_From.TabIndex = 9;
            this.cbo_Sto_Type_From.SelectedIndexChanged += new System.EventHandler(this.cbo_Sto_Type_From_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "To:";
            // 
            // cbo_Sto_Type_To
            // 
            this.cbo_Sto_Type_To.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Sto_Type_To.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Sto_Type_To.FormattingEnabled = true;
            this.cbo_Sto_Type_To.Location = new System.Drawing.Point(102, 46);
            this.cbo_Sto_Type_To.Name = "cbo_Sto_Type_To";
            this.cbo_Sto_Type_To.Size = new System.Drawing.Size(152, 24);
            this.cbo_Sto_Type_To.TabIndex = 10;
            this.cbo_Sto_Type_To.SelectedIndexChanged += new System.EventHandler(this.cbo_Sto_Type_To_SelectedIndexChanged);
            // 
            // gbo_Transfer
            // 
            this.gbo_Transfer.Controls.Add(this.groupBox1);
            this.gbo_Transfer.Controls.Add(this.txt_Notes);
            this.gbo_Transfer.Controls.Add(this.label5);
            this.gbo_Transfer.Controls.Add(this.dtp_Created_At);
            this.gbo_Transfer.Controls.Add(this.label7);
            this.gbo_Transfer.Controls.Add(this.txt_Transfer_No);
            this.gbo_Transfer.Controls.Add(this.label1);
            this.gbo_Transfer.Controls.Add(this.label2);
            this.gbo_Transfer.Controls.Add(this.cbo_Created_By);
            this.gbo_Transfer.Location = new System.Drawing.Point(28, 12);
            this.gbo_Transfer.Name = "gbo_Transfer";
            this.gbo_Transfer.Size = new System.Drawing.Size(754, 163);
            this.gbo_Transfer.TabIndex = 53;
            this.gbo_Transfer.TabStop = false;
            this.gbo_Transfer.Text = "Transfer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbo_Sto_Name_To);
            this.groupBox1.Controls.Add(this.cbo_Sto_Type_To);
            this.groupBox1.Controls.Add(this.cbo_Sto_Type_From);
            this.groupBox1.Controls.Add(this.cbo_Sto_Name_From);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(11, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 82);
            this.groupBox1.TabIndex = 133;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stores:";
            // 
            // cbo_Sto_Name_To
            // 
            this.cbo_Sto_Name_To.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Sto_Name_To.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Sto_Name_To.FormattingEnabled = true;
            this.cbo_Sto_Name_To.Location = new System.Drawing.Point(348, 43);
            this.cbo_Sto_Name_To.Name = "cbo_Sto_Name_To";
            this.cbo_Sto_Name_To.Size = new System.Drawing.Size(124, 24);
            this.cbo_Sto_Name_To.TabIndex = 14;
            this.cbo_Sto_Name_To.SelectedIndexChanged += new System.EventHandler(this.cbo_Sto_Name_To_SelectedIndexChanged);
            // 
            // cbo_Sto_Name_From
            // 
            this.cbo_Sto_Name_From.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Sto_Name_From.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Sto_Name_From.FormattingEnabled = true;
            this.cbo_Sto_Name_From.Location = new System.Drawing.Point(348, 13);
            this.cbo_Sto_Name_From.Name = "cbo_Sto_Name_From";
            this.cbo_Sto_Name_From.Size = new System.Drawing.Size(124, 24);
            this.cbo_Sto_Name_From.TabIndex = 13;
            this.cbo_Sto_Name_From.SelectedIndexChanged += new System.EventHandler(this.cbo_Sto_Name_From_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Store Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(262, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Store Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Type:";
            // 
            // txt_Notes
            // 
            this.txt_Notes.Location = new System.Drawing.Point(586, 58);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(158, 69);
            this.txt_Notes.TabIndex = 136;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 135;
            this.label5.Text = "Notes:";
            // 
            // dtp_Created_At
            // 
            this.dtp_Created_At.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Created_At.Location = new System.Drawing.Point(586, 21);
            this.dtp_Created_At.Name = "dtp_Created_At";
            this.dtp_Created_At.Size = new System.Drawing.Size(158, 23);
            this.dtp_Created_At.TabIndex = 134;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(493, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 133;
            this.label7.Text = "Created At:";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel.Location = new System.Drawing.Point(693, 597);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(89, 29);
            this.btn_Cancel.TabIndex = 57;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Location = new System.Drawing.Point(597, 597);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(89, 29);
            this.btn_Save.TabIndex = 56;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Load_items
            // 
            this.btn_Load_items.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Load_items.Location = new System.Drawing.Point(126, 181);
            this.btn_Load_items.Name = "btn_Load_items";
            this.btn_Load_items.Size = new System.Drawing.Size(152, 29);
            this.btn_Load_items.TabIndex = 131;
            this.btn_Load_items.Text = "Load items";
            this.btn_Load_items.UseVisualStyleBackColor = true;
            this.btn_Load_items.Click += new System.EventHandler(this.btn_Load_items_Click);
            // 
            // gbo_Add_Itm
            // 
            this.gbo_Add_Itm.Controls.Add(this.lbl_Small_Unit);
            this.gbo_Add_Itm.Controls.Add(this.lbl_Big_Unit);
            this.gbo_Add_Itm.Controls.Add(this.txt_Qty_Small_Unit);
            this.gbo_Add_Itm.Controls.Add(this.btn_Del_Itm);
            this.gbo_Add_Itm.Controls.Add(this.btn_Add_Itm);
            this.gbo_Add_Itm.Controls.Add(this.txt_Qty_Big_Unit);
            this.gbo_Add_Itm.Controls.Add(this.label11);
            this.gbo_Add_Itm.Controls.Add(this.label12);
            this.gbo_Add_Itm.Controls.Add(this.cbo_Itm_Name);
            this.gbo_Add_Itm.Enabled = false;
            this.gbo_Add_Itm.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_Add_Itm.Location = new System.Drawing.Point(28, 232);
            this.gbo_Add_Itm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbo_Add_Itm.Name = "gbo_Add_Itm";
            this.gbo_Add_Itm.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbo_Add_Itm.Size = new System.Drawing.Size(376, 131);
            this.gbo_Add_Itm.TabIndex = 130;
            this.gbo_Add_Itm.TabStop = false;
            this.gbo_Add_Itm.Text = "Add Item";
            // 
            // lbl_Small_Unit
            // 
            this.lbl_Small_Unit.AutoSize = true;
            this.lbl_Small_Unit.Location = new System.Drawing.Point(179, 62);
            this.lbl_Small_Unit.Name = "lbl_Small_Unit";
            this.lbl_Small_Unit.Size = new System.Drawing.Size(83, 16);
            this.lbl_Small_Unit.TabIndex = 60;
            this.lbl_Small_Unit.Text = "Smallest Unit";
            // 
            // lbl_Big_Unit
            // 
            this.lbl_Big_Unit.AutoSize = true;
            this.lbl_Big_Unit.Location = new System.Drawing.Point(82, 62);
            this.lbl_Big_Unit.Name = "lbl_Big_Unit";
            this.lbl_Big_Unit.Size = new System.Drawing.Size(75, 16);
            this.lbl_Big_Unit.TabIndex = 59;
            this.lbl_Big_Unit.Text = "Biggest Unit";
            // 
            // txt_Qty_Small_Unit
            // 
            this.txt_Qty_Small_Unit.Location = new System.Drawing.Point(179, 81);
            this.txt_Qty_Small_Unit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Qty_Small_Unit.Multiline = true;
            this.txt_Qty_Small_Unit.Name = "txt_Qty_Small_Unit";
            this.txt_Qty_Small_Unit.Size = new System.Drawing.Size(83, 23);
            this.txt_Qty_Small_Unit.TabIndex = 58;
            this.txt_Qty_Small_Unit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Qty_Small_Unit_KeyPress);
            // 
            // btn_Del_Itm
            // 
            this.btn_Del_Itm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Del_Itm.Location = new System.Drawing.Point(283, 54);
            this.btn_Del_Itm.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Del_Itm.Name = "btn_Del_Itm";
            this.btn_Del_Itm.Size = new System.Drawing.Size(66, 24);
            this.btn_Del_Itm.TabIndex = 57;
            this.btn_Del_Itm.Text = "Delete";
            this.btn_Del_Itm.UseVisualStyleBackColor = true;
            this.btn_Del_Itm.Click += new System.EventHandler(this.btn_Del_Itm_Click);
            // 
            // btn_Add_Itm
            // 
            this.btn_Add_Itm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add_Itm.Location = new System.Drawing.Point(283, 22);
            this.btn_Add_Itm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Add_Itm.Name = "btn_Add_Itm";
            this.btn_Add_Itm.Size = new System.Drawing.Size(66, 24);
            this.btn_Add_Itm.TabIndex = 56;
            this.btn_Add_Itm.Text = "Add";
            this.btn_Add_Itm.UseVisualStyleBackColor = true;
            this.btn_Add_Itm.Click += new System.EventHandler(this.btn_Add_Itm_Click);
            // 
            // txt_Qty_Big_Unit
            // 
            this.txt_Qty_Big_Unit.Location = new System.Drawing.Point(79, 81);
            this.txt_Qty_Big_Unit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Qty_Big_Unit.Multiline = true;
            this.txt_Qty_Big_Unit.Name = "txt_Qty_Big_Unit";
            this.txt_Qty_Big_Unit.Size = new System.Drawing.Size(83, 23);
            this.txt_Qty_Big_Unit.TabIndex = 51;
            this.txt_Qty_Big_Unit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Qty_Big_Unit_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 44;
            this.label11.Text = "Item Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 62);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 50;
            this.label12.Text = "Quantity:";
            // 
            // cbo_Itm_Name
            // 
            this.cbo_Itm_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Itm_Name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Itm_Name.FormattingEnabled = true;
            this.cbo_Itm_Name.Location = new System.Drawing.Point(102, 27);
            this.cbo_Itm_Name.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_Itm_Name.Name = "cbo_Itm_Name";
            this.cbo_Itm_Name.Size = new System.Drawing.Size(152, 24);
            this.cbo_Itm_Name.TabIndex = 45;
            this.cbo_Itm_Name.SelectedIndexChanged += new System.EventHandler(this.cbo_Itm_Name_SelectedIndexChanged);
            // 
            // dgv_Itm_Transfered
            // 
            this.dgv_Itm_Transfered.AllowUserToDeleteRows = false;
            this.dgv_Itm_Transfered.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Itm_Transfered.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Itm_Transfered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Itm_Transfered.Location = new System.Drawing.Point(28, 369);
            this.dgv_Itm_Transfered.Name = "dgv_Itm_Transfered";
            this.dgv_Itm_Transfered.ReadOnly = true;
            this.dgv_Itm_Transfered.Size = new System.Drawing.Size(754, 222);
            this.dgv_Itm_Transfered.TabIndex = 132;
            // 
            // frm_Transferring_From_To
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(803, 638);
            this.Controls.Add(this.dgv_Itm_Transfered);
            this.Controls.Add(this.btn_Load_items);
            this.Controls.Add(this.gbo_Add_Itm);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gbo_Transfer);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frm_Transferring_From_To";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferring Between Stores";
            this.Load += new System.EventHandler(this.frm_Transferring_From_To_Load);
            this.gbo_Transfer.ResumeLayout(false);
            this.gbo_Transfer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbo_Add_Itm.ResumeLayout(false);
            this.gbo_Add_Itm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Itm_Transfered)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Transfer_No;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_Created_By;
        private System.Windows.Forms.ComboBox cbo_Sto_Type_From;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_Sto_Type_To;
        private System.Windows.Forms.GroupBox gbo_Transfer;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cbo_Sto_Name_To;
        private System.Windows.Forms.ComboBox cbo_Sto_Name_From;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Load_items;
        private System.Windows.Forms.GroupBox gbo_Add_Itm;
        private System.Windows.Forms.Label lbl_Small_Unit;
        private System.Windows.Forms.Label lbl_Big_Unit;
        private System.Windows.Forms.TextBox txt_Qty_Small_Unit;
        private System.Windows.Forms.Button btn_Del_Itm;
        private System.Windows.Forms.Button btn_Add_Itm;
        private System.Windows.Forms.TextBox txt_Qty_Big_Unit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbo_Itm_Name;
        private System.Windows.Forms.DataGridView dgv_Itm_Transfered;
        private System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_Created_At;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}