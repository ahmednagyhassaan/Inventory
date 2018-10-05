namespace Inventory
{
    partial class frm_Item_Type
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
            this.Pnl_Add_Item_Type = new System.Windows.Forms.Panel();
            this.cbo_Name = new System.Windows.Forms.ComboBox();
            this.txt_Type_Desc = new System.Windows.Forms.TextBox();
            this.lbl_Type_Desc = new System.Windows.Forms.Label();
            this.btn_Cat_update = new System.Windows.Forms.Button();
            this.btn_Cat_Add = new System.Windows.Forms.Button();
            this.lbl_Cat_Name = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.btn_Cat_Delete = new System.Windows.Forms.Button();
            this.Pnl_Add_Item_Type.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Add_Item_Type
            // 
            this.Pnl_Add_Item_Type.Controls.Add(this.btn_Cat_Delete);
            this.Pnl_Add_Item_Type.Controls.Add(this.cbo_Name);
            this.Pnl_Add_Item_Type.Controls.Add(this.txt_Type_Desc);
            this.Pnl_Add_Item_Type.Controls.Add(this.lbl_Type_Desc);
            this.Pnl_Add_Item_Type.Controls.Add(this.btn_Cat_update);
            this.Pnl_Add_Item_Type.Controls.Add(this.btn_Cat_Add);
            this.Pnl_Add_Item_Type.Controls.Add(this.lbl_Cat_Name);
            this.Pnl_Add_Item_Type.Controls.Add(this.lbl_desc);
            this.Pnl_Add_Item_Type.Location = new System.Drawing.Point(11, 12);
            this.Pnl_Add_Item_Type.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Pnl_Add_Item_Type.Name = "Pnl_Add_Item_Type";
            this.Pnl_Add_Item_Type.Size = new System.Drawing.Size(254, 187);
            this.Pnl_Add_Item_Type.TabIndex = 16;
            // 
            // cbo_Name
            // 
            this.cbo_Name.FormattingEnabled = true;
            this.cbo_Name.Location = new System.Drawing.Point(69, 40);
            this.cbo_Name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbo_Name.Name = "cbo_Name";
            this.cbo_Name.Size = new System.Drawing.Size(172, 24);
            this.cbo_Name.TabIndex = 10;
            this.cbo_Name.SelectedIndexChanged += new System.EventHandler(this.cbo_Name_SelectedIndexChanged);
            this.cbo_Name.TextChanged += new System.EventHandler(this.cbo_Name_TextChanged);
            // 
            // txt_Type_Desc
            // 
            this.txt_Type_Desc.Location = new System.Drawing.Point(69, 71);
            this.txt_Type_Desc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Type_Desc.Multiline = true;
            this.txt_Type_Desc.Name = "txt_Type_Desc";
            this.txt_Type_Desc.Size = new System.Drawing.Size(172, 71);
            this.txt_Type_Desc.TabIndex = 9;
            // 
            // lbl_Type_Desc
            // 
            this.lbl_Type_Desc.AutoSize = true;
            this.lbl_Type_Desc.Location = new System.Drawing.Point(19, 73);
            this.lbl_Type_Desc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Type_Desc.Name = "lbl_Type_Desc";
            this.lbl_Type_Desc.Size = new System.Drawing.Size(35, 16);
            this.lbl_Type_Desc.TabIndex = 8;
            this.lbl_Type_Desc.Text = "Desc";
            // 
            // btn_Cat_update
            // 
            this.btn_Cat_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cat_update.Location = new System.Drawing.Point(123, 148);
            this.btn_Cat_update.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Cat_update.Name = "btn_Cat_update";
            this.btn_Cat_update.Size = new System.Drawing.Size(57, 30);
            this.btn_Cat_update.TabIndex = 4;
            this.btn_Cat_update.Text = "Update";
            this.btn_Cat_update.UseVisualStyleBackColor = true;
            this.btn_Cat_update.Click += new System.EventHandler(this.btn_Cat_update_Click);
            // 
            // btn_Cat_Add
            // 
            this.btn_Cat_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cat_Add.Location = new System.Drawing.Point(62, 148);
            this.btn_Cat_Add.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Cat_Add.Name = "btn_Cat_Add";
            this.btn_Cat_Add.Size = new System.Drawing.Size(57, 30);
            this.btn_Cat_Add.TabIndex = 3;
            this.btn_Cat_Add.Text = "Add";
            this.btn_Cat_Add.UseVisualStyleBackColor = true;
            this.btn_Cat_Add.Click += new System.EventHandler(this.btn_Cat_Add_Click);
            // 
            // lbl_Cat_Name
            // 
            this.lbl_Cat_Name.AutoSize = true;
            this.lbl_Cat_Name.Location = new System.Drawing.Point(13, 40);
            this.lbl_Cat_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Cat_Name.Name = "lbl_Cat_Name";
            this.lbl_Cat_Name.Size = new System.Drawing.Size(41, 16);
            this.lbl_Cat_Name.TabIndex = 2;
            this.lbl_Cat_Name.Text = "Name";
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Location = new System.Drawing.Point(2, 11);
            this.lbl_desc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(151, 16);
            this.lbl_desc.TabIndex = 0;
            this.lbl_desc.Text = "Add Raw material Type :";
            // 
            // btn_Cat_Delete
            // 
            this.btn_Cat_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cat_Delete.Location = new System.Drawing.Point(184, 148);
            this.btn_Cat_Delete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Cat_Delete.Name = "btn_Cat_Delete";
            this.btn_Cat_Delete.Size = new System.Drawing.Size(57, 30);
            this.btn_Cat_Delete.TabIndex = 11;
            this.btn_Cat_Delete.Text = "Delete";
            this.btn_Cat_Delete.UseVisualStyleBackColor = true;
            this.btn_Cat_Delete.Click += new System.EventHandler(this.btn_Cat_Delete_Click);
            // 
            // frm_Item_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(270, 207);
            this.Controls.Add(this.Pnl_Add_Item_Type);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Item_Type";
            this.Text = "Item Type";
            this.Load += new System.EventHandler(this.frm_Item_Type_Load);
            this.Pnl_Add_Item_Type.ResumeLayout(false);
            this.Pnl_Add_Item_Type.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Add_Item_Type;
        private System.Windows.Forms.ComboBox cbo_Name;
        private System.Windows.Forms.TextBox txt_Type_Desc;
        private System.Windows.Forms.Label lbl_Type_Desc;
        private System.Windows.Forms.Button btn_Cat_update;
        private System.Windows.Forms.Button btn_Cat_Add;
        private System.Windows.Forms.Label lbl_Cat_Name;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Button btn_Cat_Delete;
    }
}