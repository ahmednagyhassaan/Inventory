namespace Inventory
{
    partial class frm_Find_Transferring_From_To
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
            this.btn_View_Details = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dgv_Transfer_Find = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_Way_Of_Search = new System.Windows.Forms.ComboBox();
            this.grb_Search = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_To = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_Created_By = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Transfer_Find)).BeginInit();
            this.grb_Search.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_View_Details
            // 
            this.btn_View_Details.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_View_Details.Location = new System.Drawing.Point(770, 536);
            this.btn_View_Details.Name = "btn_View_Details";
            this.btn_View_Details.Size = new System.Drawing.Size(107, 28);
            this.btn_View_Details.TabIndex = 39;
            this.btn_View_Details.Text = "View Details";
            this.btn_View_Details.UseVisualStyleBackColor = true;
            this.btn_View_Details.Click += new System.EventHandler(this.btn_View_Details_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Location = new System.Drawing.Point(645, 536);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(119, 28);
            this.btn_Delete.TabIndex = 38;
            this.btn_Delete.Text = "Delete ";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Edit.Location = new System.Drawing.Point(526, 536);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(107, 28);
            this.btn_Edit.TabIndex = 37;
            this.btn_Edit.Text = "Edit ";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Location = new System.Drawing.Point(377, 536);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(137, 28);
            this.btn_Add.TabIndex = 36;
            this.btn_Add.Text = "Add New ";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dgv_Transfer_Find
            // 
            this.dgv_Transfer_Find.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Transfer_Find.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Transfer_Find.Location = new System.Drawing.Point(15, 286);
            this.dgv_Transfer_Find.Name = "dgv_Transfer_Find";
            this.dgv_Transfer_Find.Size = new System.Drawing.Size(862, 243);
            this.dgv_Transfer_Find.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "The Way Of Search:";
            // 
            // cbo_Way_Of_Search
            // 
            this.cbo_Way_Of_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Way_Of_Search.FormattingEnabled = true;
            this.cbo_Way_Of_Search.Items.AddRange(new object[] {
            "All",
            "Search By"});
            this.cbo_Way_Of_Search.Location = new System.Drawing.Point(152, 14);
            this.cbo_Way_Of_Search.Name = "cbo_Way_Of_Search";
            this.cbo_Way_Of_Search.Size = new System.Drawing.Size(157, 24);
            this.cbo_Way_Of_Search.TabIndex = 33;
            this.cbo_Way_Of_Search.SelectedValueChanged += new System.EventHandler(this.cbo_Way_Of_Search_SelectedValueChanged);
            // 
            // grb_Search
            // 
            this.grb_Search.Controls.Add(this.groupBox1);
            this.grb_Search.Controls.Add(this.cbo_Created_By);
            this.grb_Search.Controls.Add(this.label2);
            this.grb_Search.Controls.Add(this.txt_ID);
            this.grb_Search.Controls.Add(this.label1);
            this.grb_Search.Controls.Add(this.btn_Search);
            this.grb_Search.Enabled = false;
            this.grb_Search.Location = new System.Drawing.Point(18, 44);
            this.grb_Search.Name = "grb_Search";
            this.grb_Search.Size = new System.Drawing.Size(410, 206);
            this.grb_Search.TabIndex = 32;
            this.grb_Search.TabStop = false;
            this.grb_Search.Text = "Search By";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_From);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtp_To);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(6, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 100);
            this.groupBox1.TabIndex = 137;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Created between";
            // 
            // dtp_From
            // 
            this.dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_From.Location = new System.Drawing.Point(64, 33);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(158, 23);
            this.dtp_From.TabIndex = 136;
            this.dtp_From.Value = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 133;
            this.label5.Text = "From";
            // 
            // dtp_To
            // 
            this.dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_To.Location = new System.Drawing.Point(64, 62);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.Size = new System.Drawing.Size(158, 23);
            this.dtp_To.TabIndex = 135;
            this.dtp_To.Value = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 134;
            this.label6.Text = "To";
            // 
            // cbo_Created_By
            // 
            this.cbo_Created_By.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Created_By.FormattingEnabled = true;
            this.cbo_Created_By.Location = new System.Drawing.Point(133, 51);
            this.cbo_Created_By.Name = "cbo_Created_By";
            this.cbo_Created_By.Size = new System.Drawing.Size(158, 24);
            this.cbo_Created_By.TabIndex = 131;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 130;
            this.label2.Text = "Created By:";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(134, 18);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(157, 23);
            this.txt_ID.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Transfer No:";
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Search.Location = new System.Drawing.Point(317, 164);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(87, 28);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frm_Find_Transferring_From_To
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(893, 578);
            this.Controls.Add(this.btn_View_Details);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_Transfer_Find);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_Way_Of_Search);
            this.Controls.Add(this.grb_Search);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frm_Find_Transferring_From_To";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferring between Stores Search";
            this.Load += new System.EventHandler(this.frm_Find_Transferring_From_To_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Transfer_Find)).EndInit();
            this.grb_Search.ResumeLayout(false);
            this.grb_Search.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_View_Details;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dgv_Transfer_Find;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_Way_Of_Search;
        private System.Windows.Forms.GroupBox grb_Search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_From;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_To;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_Created_By;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;

    }
}