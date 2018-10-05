namespace Inventory
{
    partial class frmEmpAddEdit
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.cbo_Dept_Name = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.gbo_Emp_Info = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_Date_Bith = new System.Windows.Forms.DateTimePicker();
            this.dtp_Hire_Date = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Certification = new System.Windows.Forms.TextBox();
            this.txt_Salary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbo_Emp_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Department Name:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(127, 57);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(155, 23);
            this.txt_Name.TabIndex = 7;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(127, 148);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(155, 23);
            this.txt_Address.TabIndex = 9;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(127, 26);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ID.Multiline = true;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(155, 23);
            this.txt_ID.TabIndex = 12;
            // 
            // cbo_Dept_Name
            // 
            this.cbo_Dept_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Dept_Name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Dept_Name.FormattingEnabled = true;
            this.cbo_Dept_Name.Location = new System.Drawing.Point(127, 232);
            this.cbo_Dept_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_Dept_Name.Name = "cbo_Dept_Name";
            this.cbo_Dept_Name.Size = new System.Drawing.Size(155, 24);
            this.cbo_Dept_Name.TabIndex = 13;
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Location = new System.Drawing.Point(121, 329);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(89, 29);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Close.Location = new System.Drawing.Point(216, 329);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(89, 29);
            this.btn_Close.TabIndex = 15;
            this.btn_Close.Text = "Cancel";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // gbo_Emp_Info
            // 
            this.gbo_Emp_Info.Controls.Add(this.label10);
            this.gbo_Emp_Info.Controls.Add(this.txt_Phone);
            this.gbo_Emp_Info.Controls.Add(this.label7);
            this.gbo_Emp_Info.Controls.Add(this.dtp_Date_Bith);
            this.gbo_Emp_Info.Controls.Add(this.dtp_Hire_Date);
            this.gbo_Emp_Info.Controls.Add(this.label9);
            this.gbo_Emp_Info.Controls.Add(this.txt_Certification);
            this.gbo_Emp_Info.Controls.Add(this.txt_Salary);
            this.gbo_Emp_Info.Controls.Add(this.label8);
            this.gbo_Emp_Info.Controls.Add(this.label6);
            this.gbo_Emp_Info.Controls.Add(this.txt_Address);
            this.gbo_Emp_Info.Controls.Add(this.label1);
            this.gbo_Emp_Info.Controls.Add(this.label2);
            this.gbo_Emp_Info.Controls.Add(this.cbo_Dept_Name);
            this.gbo_Emp_Info.Controls.Add(this.txt_ID);
            this.gbo_Emp_Info.Controls.Add(this.label4);
            this.gbo_Emp_Info.Controls.Add(this.label5);
            this.gbo_Emp_Info.Controls.Add(this.txt_Name);
            this.gbo_Emp_Info.Location = new System.Drawing.Point(12, 12);
            this.gbo_Emp_Info.Name = "gbo_Emp_Info";
            this.gbo_Emp_Info.Size = new System.Drawing.Size(291, 310);
            this.gbo_Emp_Info.TabIndex = 16;
            this.gbo_Emp_Info.TabStop = false;
            this.gbo_Emp_Info.Text = "Employee Information";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Phone";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(127, 272);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(155, 23);
            this.txt_Phone.TabIndex = 21;
            this.txt_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Salary_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Date of Bith :";
            // 
            // dtp_Date_Bith
            // 
            this.dtp_Date_Bith.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date_Bith.Location = new System.Drawing.Point(127, 88);
            this.dtp_Date_Bith.Name = "dtp_Date_Bith";
            this.dtp_Date_Bith.Size = new System.Drawing.Size(155, 23);
            this.dtp_Date_Bith.TabIndex = 20;
            // 
            // dtp_Hire_Date
            // 
            this.dtp_Hire_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Hire_Date.Location = new System.Drawing.Point(127, 202);
            this.dtp_Hire_Date.Name = "dtp_Hire_Date";
            this.dtp_Hire_Date.Size = new System.Drawing.Size(155, 23);
            this.dtp_Hire_Date.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Hire Date:";
            // 
            // txt_Certification
            // 
            this.txt_Certification.Location = new System.Drawing.Point(127, 118);
            this.txt_Certification.Name = "txt_Certification";
            this.txt_Certification.Size = new System.Drawing.Size(155, 23);
            this.txt_Certification.TabIndex = 17;
            // 
            // txt_Salary
            // 
            this.txt_Salary.Location = new System.Drawing.Point(127, 174);
            this.txt_Salary.Name = "txt_Salary";
            this.txt_Salary.Size = new System.Drawing.Size(155, 23);
            this.txt_Salary.TabIndex = 16;
            this.txt_Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Salary_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Salary:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Certification:";
            // 
            // frm_Add_Emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(317, 370);
            this.Controls.Add(this.gbo_Emp_Info);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Add_Emp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.frm_Add_Emp_Load);
            this.gbo_Emp_Info.ResumeLayout(false);
            this.gbo_Emp_Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.ComboBox cbo_Dept_Name;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.GroupBox gbo_Emp_Info;
        private System.Windows.Forms.TextBox txt_Certification;
        private System.Windows.Forms.TextBox txt_Salary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_Hire_Date;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_Date_Bith;
    }
}