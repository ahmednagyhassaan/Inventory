namespace Inventory
{
    partial class frm_new_unit
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
            this.Pnl_Add_Unit = new System.Windows.Forms.Panel();
            this.btn_unit_Delete = new System.Windows.Forms.Button();
            this.txt_Small = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_Unit_Name = new System.Windows.Forms.ComboBox();
            this.txt_Qty = new System.Windows.Forms.TextBox();
            this.btn_Unit_update = new System.Windows.Forms.Button();
            this.btn_Unit_Add = new System.Windows.Forms.Button();
            this.lbl_Cat_Name = new System.Windows.Forms.Label();
            this.lbl_Qty = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.Pnl_Add_Unit.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Add_Unit
            // 
            this.Pnl_Add_Unit.Controls.Add(this.btn_unit_Delete);
            this.Pnl_Add_Unit.Controls.Add(this.txt_Small);
            this.Pnl_Add_Unit.Controls.Add(this.label1);
            this.Pnl_Add_Unit.Controls.Add(this.cbo_Unit_Name);
            this.Pnl_Add_Unit.Controls.Add(this.txt_Qty);
            this.Pnl_Add_Unit.Controls.Add(this.btn_Unit_update);
            this.Pnl_Add_Unit.Controls.Add(this.btn_Unit_Add);
            this.Pnl_Add_Unit.Controls.Add(this.lbl_Cat_Name);
            this.Pnl_Add_Unit.Controls.Add(this.lbl_Qty);
            this.Pnl_Add_Unit.Controls.Add(this.lbl_desc);
            this.Pnl_Add_Unit.Location = new System.Drawing.Point(11, 12);
            this.Pnl_Add_Unit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Pnl_Add_Unit.Name = "Pnl_Add_Unit";
            this.Pnl_Add_Unit.Size = new System.Drawing.Size(267, 162);
            this.Pnl_Add_Unit.TabIndex = 19;
            // 
            // btn_unit_Delete
            // 
            this.btn_unit_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_unit_Delete.Location = new System.Drawing.Point(195, 122);
            this.btn_unit_Delete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_unit_Delete.Name = "btn_unit_Delete";
            this.btn_unit_Delete.Size = new System.Drawing.Size(59, 30);
            this.btn_unit_Delete.TabIndex = 10;
            this.btn_unit_Delete.Text = "Delete";
            this.btn_unit_Delete.UseVisualStyleBackColor = true;
            this.btn_unit_Delete.Click += new System.EventHandler(this.btn_unit_Delete_Click);
            // 
            // txt_Small
            // 
            this.txt_Small.Location = new System.Drawing.Point(88, 53);
            this.txt_Small.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Small.Name = "txt_Small";
            this.txt_Small.Size = new System.Drawing.Size(166, 23);
            this.txt_Small.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Small unit :";
            // 
            // cbo_Unit_Name
            // 
            this.cbo_Unit_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_Unit_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cbo_Unit_Name.FormattingEnabled = true;
            this.cbo_Unit_Name.Location = new System.Drawing.Point(88, 23);
            this.cbo_Unit_Name.Name = "cbo_Unit_Name";
            this.cbo_Unit_Name.Size = new System.Drawing.Size(166, 24);
            this.cbo_Unit_Name.TabIndex = 7;
            this.cbo_Unit_Name.SelectedIndexChanged += new System.EventHandler(this.cbo_Unit_Name_SelectedIndexChanged);
            this.cbo_Unit_Name.TextChanged += new System.EventHandler(this.cbo_Unit_Name_TextChanged);
            // 
            // txt_Qty
            // 
            this.txt_Qty.Location = new System.Drawing.Point(88, 84);
            this.txt_Qty.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(166, 23);
            this.txt_Qty.TabIndex = 6;
            // 
            // btn_Unit_update
            // 
            this.btn_Unit_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Unit_update.Location = new System.Drawing.Point(138, 122);
            this.btn_Unit_update.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Unit_update.Name = "btn_Unit_update";
            this.btn_Unit_update.Size = new System.Drawing.Size(53, 30);
            this.btn_Unit_update.TabIndex = 4;
            this.btn_Unit_update.Text = "Edit";
            this.btn_Unit_update.UseVisualStyleBackColor = true;
            this.btn_Unit_update.Click += new System.EventHandler(this.btn_Unit_update_Click);
            // 
            // btn_Unit_Add
            // 
            this.btn_Unit_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Unit_Add.Location = new System.Drawing.Point(87, 122);
            this.btn_Unit_Add.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Unit_Add.Name = "btn_Unit_Add";
            this.btn_Unit_Add.Size = new System.Drawing.Size(47, 30);
            this.btn_Unit_Add.TabIndex = 3;
            this.btn_Unit_Add.Text = "Add";
            this.btn_Unit_Add.UseVisualStyleBackColor = true;
            this.btn_Unit_Add.Click += new System.EventHandler(this.btn_Unit_Add_Click);
            // 
            // lbl_Cat_Name
            // 
            this.lbl_Cat_Name.AutoSize = true;
            this.lbl_Cat_Name.Location = new System.Drawing.Point(13, 26);
            this.lbl_Cat_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Cat_Name.Name = "lbl_Cat_Name";
            this.lbl_Cat_Name.Size = new System.Drawing.Size(54, 16);
            this.lbl_Cat_Name.TabIndex = 2;
            this.lbl_Cat_Name.Text = "Name  :";
            // 
            // lbl_Qty
            // 
            this.lbl_Qty.AutoSize = true;
            this.lbl_Qty.Location = new System.Drawing.Point(13, 84);
            this.lbl_Qty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Qty.Name = "lbl_Qty";
            this.lbl_Qty.Size = new System.Drawing.Size(36, 16);
            this.lbl_Qty.TabIndex = 1;
            this.lbl_Qty.Text = "Qty :";
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Location = new System.Drawing.Point(2, 0);
            this.lbl_desc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(65, 16);
            this.lbl_desc.TabIndex = 0;
            this.lbl_desc.Text = "Add Unit :";
            // 
            // frm_new_unit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(287, 181);
            this.Controls.Add(this.Pnl_Add_Unit);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_new_unit";
            this.Text = "new unit";
            this.Load += new System.EventHandler(this.frm_new_unit_Load);
            this.Pnl_Add_Unit.ResumeLayout(false);
            this.Pnl_Add_Unit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Add_Unit;
        private System.Windows.Forms.TextBox txt_Small;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_Unit_Name;
        private System.Windows.Forms.TextBox txt_Qty;
        private System.Windows.Forms.Button btn_Unit_update;
        private System.Windows.Forms.Button btn_Unit_Add;
        private System.Windows.Forms.Label lbl_Cat_Name;
        private System.Windows.Forms.Label lbl_Qty;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Button btn_unit_Delete;
    }
}