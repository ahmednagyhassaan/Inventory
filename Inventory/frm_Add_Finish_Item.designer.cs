namespace Inventory
{
    partial class frm_Add_Finish_Item
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.lst_Colors = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_Colors = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_Size = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lst_Sizes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_New_Unit = new System.Windows.Forms.Button();
            this.cbo_Units = new System.Windows.Forms.ComboBox();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.gbx_Add_Pure = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.cbo_consist_item = new System.Windows.Forms.ComboBox();
            this.txt_consist_Qty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_consist_Cat = new System.Windows.Forms.ComboBox();
            this.dgv_Consist = new System.Windows.Forms.DataGridView();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Min_At_Store = new System.Windows.Forms.TextBox();
            this.lbl_Min_At_Store = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Type = new System.Windows.Forms.Button();
            this.lbl_type = new System.Windows.Forms.Label();
            this.Cbo_Type = new System.Windows.Forms.ComboBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbx_Add_Pure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Consist)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.gbx_Add_Pure);
            this.groupBox1.Controls.Add(this.txt_Price);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Min_At_Store);
            this.groupBox1.Controls.Add(this.lbl_Min_At_Store);
            this.groupBox1.Controls.Add(this.lbl_Name);
            this.groupBox1.Controls.Add(this.btn_Type);
            this.groupBox1.Controls.Add(this.lbl_type);
            this.groupBox1.Controls.Add(this.Cbo_Type);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 585);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "To Add New Item";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.lst_Colors);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbo_Colors);
            this.groupBox3.Location = new System.Drawing.Point(8, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 201);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "To Add Item Colors";
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(241, 117);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(53, 30);
            this.button7.TabIndex = 25;
            this.button7.Text = "Delete";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(241, 81);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(53, 30);
            this.button8.TabIndex = 24;
            this.button8.Text = "Add";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // lst_Colors
            // 
            this.lst_Colors.FormattingEnabled = true;
            this.lst_Colors.ItemHeight = 16;
            this.lst_Colors.Location = new System.Drawing.Point(84, 69);
            this.lst_Colors.Name = "lst_Colors";
            this.lst_Colors.Size = new System.Drawing.Size(152, 116);
            this.lst_Colors.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "color";
            // 
            // cbo_Colors
            // 
            this.cbo_Colors.FormattingEnabled = true;
            this.cbo_Colors.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "White",
            "Black",
            "Silver"});
            this.cbo_Colors.Location = new System.Drawing.Point(84, 39);
            this.cbo_Colors.Name = "cbo_Colors";
            this.cbo_Colors.Size = new System.Drawing.Size(152, 24);
            this.cbo_Colors.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(573, 538);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 31);
            this.button2.TabIndex = 48;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(495, 538);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 31);
            this.button4.TabIndex = 46;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_Size);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.lst_Sizes);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(348, 325);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(297, 201);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "To Add Item sizes";
            // 
            // txt_Size
            // 
            this.txt_Size.Location = new System.Drawing.Point(57, 37);
            this.txt_Size.Multiline = true;
            this.txt_Size.Name = "txt_Size";
            this.txt_Size.Size = new System.Drawing.Size(177, 24);
            this.txt_Size.TabIndex = 26;
            this.txt_Size.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_consist_Qty_KeyPress);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(239, 105);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 30);
            this.button5.TabIndex = 25;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(239, 69);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(53, 30);
            this.button6.TabIndex = 24;
            this.button6.Text = "Add";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lst_Sizes
            // 
            this.lst_Sizes.FormattingEnabled = true;
            this.lst_Sizes.ItemHeight = 16;
            this.lst_Sizes.Location = new System.Drawing.Point(57, 67);
            this.lst_Sizes.Name = "lst_Sizes";
            this.lst_Sizes.Size = new System.Drawing.Size(177, 116);
            this.lst_Sizes.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "size";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_New_Unit);
            this.groupBox2.Controls.Add(this.cbo_Units);
            this.groupBox2.Controls.Add(this.lbl_Unit);
            this.groupBox2.Location = new System.Drawing.Point(9, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 74);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To Add Item Unit";
            // 
            // btn_New_Unit
            // 
            this.btn_New_Unit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_New_Unit.Location = new System.Drawing.Point(256, 27);
            this.btn_New_Unit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_New_Unit.Name = "btn_New_Unit";
            this.btn_New_Unit.Size = new System.Drawing.Size(38, 29);
            this.btn_New_Unit.TabIndex = 29;
            this.btn_New_Unit.UseVisualStyleBackColor = true;
            this.btn_New_Unit.Click += new System.EventHandler(this.btn_New_Unit_Click);
            // 
            // cbo_Units
            // 
            this.cbo_Units.FormattingEnabled = true;
            this.cbo_Units.Location = new System.Drawing.Point(84, 30);
            this.cbo_Units.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbo_Units.Name = "cbo_Units";
            this.cbo_Units.Size = new System.Drawing.Size(152, 24);
            this.cbo_Units.TabIndex = 28;
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Location = new System.Drawing.Point(16, 35);
            this.lbl_Unit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(30, 16);
            this.lbl_Unit.TabIndex = 27;
            this.lbl_Unit.Text = "Unit";
            // 
            // gbx_Add_Pure
            // 
            this.gbx_Add_Pure.Controls.Add(this.button1);
            this.gbx_Add_Pure.Controls.Add(this.button10);
            this.gbx_Add_Pure.Controls.Add(this.cbo_consist_item);
            this.gbx_Add_Pure.Controls.Add(this.txt_consist_Qty);
            this.gbx_Add_Pure.Controls.Add(this.label6);
            this.gbx_Add_Pure.Controls.Add(this.label5);
            this.gbx_Add_Pure.Controls.Add(this.label2);
            this.gbx_Add_Pure.Controls.Add(this.cbo_consist_Cat);
            this.gbx_Add_Pure.Controls.Add(this.dgv_Consist);
            this.gbx_Add_Pure.Location = new System.Drawing.Point(348, 22);
            this.gbx_Add_Pure.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbx_Add_Pure.Name = "gbx_Add_Pure";
            this.gbx_Add_Pure.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbx_Add_Pure.Size = new System.Drawing.Size(297, 287);
            this.gbx_Add_Pure.TabIndex = 43;
            this.gbx_Add_Pure.TabStop = false;
            this.gbx_Add_Pure.Text = "consist of :::";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(229, 105);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 30);
            this.button1.TabIndex = 33;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Location = new System.Drawing.Point(172, 105);
            this.button10.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(53, 30);
            this.button10.TabIndex = 32;
            this.button10.Text = "Add";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // cbo_consist_item
            // 
            this.cbo_consist_item.FormattingEnabled = true;
            this.cbo_consist_item.Location = new System.Drawing.Point(117, 49);
            this.cbo_consist_item.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbo_consist_item.Name = "cbo_consist_item";
            this.cbo_consist_item.Size = new System.Drawing.Size(165, 24);
            this.cbo_consist_item.TabIndex = 31;
            // 
            // txt_consist_Qty
            // 
            this.txt_consist_Qty.Location = new System.Drawing.Point(117, 76);
            this.txt_consist_Qty.Name = "txt_consist_Qty";
            this.txt_consist_Qty.Size = new System.Drawing.Size(165, 23);
            this.txt_consist_Qty.TabIndex = 30;
            this.txt_consist_Qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_consist_Qty_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Qty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Raw material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Raw category";
            // 
            // cbo_consist_Cat
            // 
            this.cbo_consist_Cat.FormattingEnabled = true;
            this.cbo_consist_Cat.Location = new System.Drawing.Point(117, 22);
            this.cbo_consist_Cat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbo_consist_Cat.Name = "cbo_consist_Cat";
            this.cbo_consist_Cat.Size = new System.Drawing.Size(165, 24);
            this.cbo_consist_Cat.TabIndex = 22;
            this.cbo_consist_Cat.SelectedIndexChanged += new System.EventHandler(this.cbo_consist_Cat_SelectedIndexChanged);
            // 
            // dgv_Consist
            // 
            this.dgv_Consist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Consist.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Consist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Consist.Location = new System.Drawing.Point(19, 140);
            this.dgv_Consist.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgv_Consist.Name = "dgv_Consist";
            this.dgv_Consist.Size = new System.Drawing.Size(263, 142);
            this.dgv_Consist.TabIndex = 24;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(93, 130);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(155, 23);
            this.txt_Price.TabIndex = 41;
            this.txt_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_consist_Qty_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Price";
            // 
            // txt_Min_At_Store
            // 
            this.txt_Min_At_Store.Location = new System.Drawing.Point(93, 92);
            this.txt_Min_At_Store.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Min_At_Store.Name = "txt_Min_At_Store";
            this.txt_Min_At_Store.Size = new System.Drawing.Size(155, 23);
            this.txt_Min_At_Store.TabIndex = 39;
            this.txt_Min_At_Store.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_consist_Qty_KeyPress);
            // 
            // lbl_Min_At_Store
            // 
            this.lbl_Min_At_Store.AutoSize = true;
            this.lbl_Min_At_Store.Location = new System.Drawing.Point(6, 94);
            this.lbl_Min_At_Store.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Min_At_Store.Name = "lbl_Min_At_Store";
            this.lbl_Min_At_Store.Size = new System.Drawing.Size(80, 16);
            this.lbl_Min_At_Store.TabIndex = 38;
            this.lbl_Min_At_Store.Text = "Min. at store";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(6, 61);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(41, 16);
            this.lbl_Name.TabIndex = 28;
            this.lbl_Name.Text = "Name";
            // 
            // btn_Type
            // 
            this.btn_Type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Type.Location = new System.Drawing.Point(251, 27);
            this.btn_Type.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Type.Name = "btn_Type";
            this.btn_Type.Size = new System.Drawing.Size(38, 24);
            this.btn_Type.TabIndex = 33;
            this.btn_Type.UseVisualStyleBackColor = true;
            this.btn_Type.Click += new System.EventHandler(this.btn_Type_Click_1);
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(5, 32);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(36, 16);
            this.lbl_type.TabIndex = 29;
            this.lbl_type.Text = "Type";
            // 
            // Cbo_Type
            // 
            this.Cbo_Type.FormattingEnabled = true;
            this.Cbo_Type.Location = new System.Drawing.Point(92, 27);
            this.Cbo_Type.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Cbo_Type.Name = "Cbo_Type";
            this.Cbo_Type.Size = new System.Drawing.Size(155, 24);
            this.Cbo_Type.TabIndex = 30;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(93, 61);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(155, 23);
            this.txt_Name.TabIndex = 32;
            // 
            // frm_Add_Finish_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(682, 606);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Add_Finish_Item";
            this.Text = "Add Finish Item";
            this.Load += new System.EventHandler(this.frm_Add_Finish_Item_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbx_Add_Pure.ResumeLayout(false);
            this.gbx_Add_Pure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Consist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbx_Add_Pure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_consist_Cat;
        private System.Windows.Forms.DataGridView dgv_Consist;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Min_At_Store;
        private System.Windows.Forms.Label lbl_Min_At_Store;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_Type;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.ComboBox Cbo_Type;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_Size;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox lst_Sizes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_New_Unit;
        private System.Windows.Forms.ComboBox cbo_Units;
        private System.Windows.Forms.Label lbl_Unit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ListBox lst_Colors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_Colors;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ComboBox cbo_consist_item;
        private System.Windows.Forms.TextBox txt_consist_Qty;
    }
}