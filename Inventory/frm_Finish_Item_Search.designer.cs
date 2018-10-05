namespace Inventory
{
    partial class frm_Finish_Item_Search
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbx_Search = new System.Windows.Forms.GroupBox();
            this.lbl_Min_At_Store = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_mini = new System.Windows.Forms.TextBox();
            this.cbo_Type = new System.Windows.Forms.ComboBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.dgv_Store_Search = new System.Windows.Forms.DataGridView();
            this.cbo_FTtem_Search = new System.Windows.Forms.ComboBox();
            this.tn_FItem_Details = new System.Windows.Forms.Button();
            this.gbx_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Store_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Location = new System.Drawing.Point(585, 489);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(89, 35);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Visible = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Update.Location = new System.Drawing.Point(399, 489);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(89, 35);
            this.btn_Update.TabIndex = 12;
            this.btn_Update.Text = "Edit";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Visible = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Location = new System.Drawing.Point(306, 489);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(89, 35);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Choose The Way Of View :::";
            // 
            // gbx_Search
            // 
            this.gbx_Search.Controls.Add(this.lbl_Min_At_Store);
            this.gbx_Search.Controls.Add(this.lbl_ID);
            this.gbx_Search.Controls.Add(this.lbl_Name);
            this.gbx_Search.Controls.Add(this.lbl_type);
            this.gbx_Search.Controls.Add(this.btn_Search);
            this.gbx_Search.Controls.Add(this.txt_mini);
            this.gbx_Search.Controls.Add(this.cbo_Type);
            this.gbx_Search.Controls.Add(this.txt_Name);
            this.gbx_Search.Controls.Add(this.txt_ID);
            this.gbx_Search.Location = new System.Drawing.Point(204, 22);
            this.gbx_Search.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbx_Search.Name = "gbx_Search";
            this.gbx_Search.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbx_Search.Size = new System.Drawing.Size(464, 150);
            this.gbx_Search.TabIndex = 9;
            this.gbx_Search.TabStop = false;
            this.gbx_Search.Text = "Search by :::";
            // 
            // lbl_Min_At_Store
            // 
            this.lbl_Min_At_Store.AutoSize = true;
            this.lbl_Min_At_Store.Location = new System.Drawing.Point(204, 74);
            this.lbl_Min_At_Store.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Min_At_Store.Name = "lbl_Min_At_Store";
            this.lbl_Min_At_Store.Size = new System.Drawing.Size(102, 16);
            this.lbl_Min_At_Store.TabIndex = 24;
            this.lbl_Min_At_Store.Text = "Min. at store >=";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(11, 38);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(20, 16);
            this.lbl_ID.TabIndex = 21;
            this.lbl_ID.Text = "ID";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(11, 70);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(41, 16);
            this.lbl_Name.TabIndex = 22;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(204, 38);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(36, 16);
            this.lbl_type.TabIndex = 23;
            this.lbl_type.Text = "Type";
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Search.Location = new System.Drawing.Point(343, 101);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 31);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_mini
            // 
            this.txt_mini.Location = new System.Drawing.Point(309, 70);
            this.txt_mini.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txt_mini.Name = "txt_mini";
            this.txt_mini.Size = new System.Drawing.Size(130, 23);
            this.txt_mini.TabIndex = 7;
            // 
            // cbo_Type
            // 
            this.cbo_Type.FormattingEnabled = true;
            this.cbo_Type.Location = new System.Drawing.Point(306, 34);
            this.cbo_Type.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cbo_Type.Name = "cbo_Type";
            this.cbo_Type.Size = new System.Drawing.Size(133, 24);
            this.cbo_Type.TabIndex = 5;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(57, 67);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(133, 23);
            this.txt_Name.TabIndex = 3;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(57, 35);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(133, 23);
            this.txt_ID.TabIndex = 1;
            // 
            // dgv_Store_Search
            // 
            this.dgv_Store_Search.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Store_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Store_Search.Location = new System.Drawing.Point(12, 180);
            this.dgv_Store_Search.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dgv_Store_Search.Name = "dgv_Store_Search";
            this.dgv_Store_Search.Size = new System.Drawing.Size(656, 301);
            this.dgv_Store_Search.TabIndex = 8;
            // 
            // cbo_FTtem_Search
            // 
            this.cbo_FTtem_Search.FormattingEnabled = true;
            this.cbo_FTtem_Search.Items.AddRange(new object[] {
            "All",
            "Search by",
            "items At Stores",
            "items Almost finished"});
            this.cbo_FTtem_Search.Location = new System.Drawing.Point(17, 81);
            this.cbo_FTtem_Search.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cbo_FTtem_Search.Name = "cbo_FTtem_Search";
            this.cbo_FTtem_Search.Size = new System.Drawing.Size(170, 24);
            this.cbo_FTtem_Search.TabIndex = 7;
            this.cbo_FTtem_Search.SelectedIndexChanged += new System.EventHandler(this.cbo_FTtem_Search_SelectedIndexChanged);
            this.cbo_FTtem_Search.SelectedValueChanged += new System.EventHandler(this.cbo_Store_Search_SelectedValueChanged);
            // 
            // tn_FItem_Details
            // 
            this.tn_FItem_Details.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tn_FItem_Details.Location = new System.Drawing.Point(492, 489);
            this.tn_FItem_Details.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tn_FItem_Details.Name = "tn_FItem_Details";
            this.tn_FItem_Details.Size = new System.Drawing.Size(89, 35);
            this.tn_FItem_Details.TabIndex = 14;
            this.tn_FItem_Details.Text = "Details";
            this.tn_FItem_Details.UseVisualStyleBackColor = true;
            this.tn_FItem_Details.Click += new System.EventHandler(this.tn_FItem_Details_Click);
            // 
            // frm_Finish_Item_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(688, 537);
            this.Controls.Add(this.tn_FItem_Details);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbx_Search);
            this.Controls.Add(this.dgv_Store_Search);
            this.Controls.Add(this.cbo_FTtem_Search);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Finish_Item_Search";
            this.Text = "frm_Finish_Item_Search";
            this.Load += new System.EventHandler(this.frm_Finish_Item_Search_Load);
            this.gbx_Search.ResumeLayout(false);
            this.gbx_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Store_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbx_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_mini;
        private System.Windows.Forms.ComboBox cbo_Type;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.DataGridView dgv_Store_Search;
        private System.Windows.Forms.ComboBox cbo_FTtem_Search;
        private System.Windows.Forms.Label lbl_Min_At_Store;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Button tn_FItem_Details;
    }
}