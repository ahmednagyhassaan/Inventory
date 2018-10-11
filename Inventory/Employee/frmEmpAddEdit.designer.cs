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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.cbo_Dept_Name = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.gbo_Emp_Info = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_Date_Bith = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Certification = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Salary = new Inventory.CustomControls.NumTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_Hire_Date = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlPic = new System.Windows.Forms.Panel();
            this.PicEmp = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnChangePic = new System.Windows.Forms.Button();
            this.btnRemovePic = new System.Windows.Forms.Button();
            this.pnlMaster = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gbo_Emp_Info.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicEmp)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlMaster.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Department:";
            // 
            // txt_Name
            // 
            this.txt_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Name.Location = new System.Drawing.Point(112, 35);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(315, 23);
            this.txt_Name.TabIndex = 1;
            // 
            // txt_Address
            // 
            this.txt_Address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Address.Location = new System.Drawing.Point(112, 124);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(315, 36);
            this.txt_Address.TabIndex = 4;
            // 
            // txt_ID
            // 
            this.txt_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(112, 4);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(315, 23);
            this.txt_ID.TabIndex = 0;
            // 
            // cbo_Dept_Name
            // 
            this.cbo_Dept_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_Dept_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbo_Dept_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_Dept_Name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Dept_Name.FormattingEnabled = true;
            this.cbo_Dept_Name.Location = new System.Drawing.Point(112, 226);
            this.cbo_Dept_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_Dept_Name.Name = "cbo_Dept_Name";
            this.cbo_Dept_Name.Size = new System.Drawing.Size(315, 24);
            this.cbo_Dept_Name.TabIndex = 7;
            this.cbo_Dept_Name.SelectedValueChanged += new System.EventHandler(this.cbo_Dept_Name_SelectedValueChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Location = new System.Drawing.Point(341, 0);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(89, 43);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Close.Location = new System.Drawing.Point(252, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(89, 43);
            this.btn_Close.TabIndex = 15;
            this.btn_Close.Text = "Cancel";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // gbo_Emp_Info
            // 
            this.gbo_Emp_Info.Controls.Add(this.tableLayoutPanel1);
            this.gbo_Emp_Info.Controls.Add(this.panel1);
            this.gbo_Emp_Info.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbo_Emp_Info.Location = new System.Drawing.Point(179, 0);
            this.gbo_Emp_Info.Name = "gbo_Emp_Info";
            this.gbo_Emp_Info.Size = new System.Drawing.Size(436, 466);
            this.gbo_Emp_Info.TabIndex = 16;
            this.gbo_Emp_Info.TabStop = false;
            this.gbo_Emp_Info.Text = "Information";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.42857F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.57143F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_ID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Name, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtp_Date_Bith, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_Certification, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_Address, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_Salary, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.dtp_Hire_Date, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbo_Dept_Name, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txt_Phone, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 401);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Date of Bith :";
            // 
            // dtp_Date_Bith
            // 
            this.dtp_Date_Bith.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_Date_Bith.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date_Bith.Location = new System.Drawing.Point(112, 65);
            this.dtp_Date_Bith.Name = "dtp_Date_Bith";
            this.dtp_Date_Bith.Size = new System.Drawing.Size(315, 23);
            this.dtp_Date_Bith.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Certification:";
            // 
            // txt_Certification
            // 
            this.txt_Certification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Certification.Location = new System.Drawing.Point(112, 94);
            this.txt_Certification.Name = "txt_Certification";
            this.txt_Certification.Size = new System.Drawing.Size(315, 23);
            this.txt_Certification.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Salary:";
            // 
            // txt_Salary
            // 
            this.txt_Salary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Salary.Location = new System.Drawing.Point(112, 167);
            this.txt_Salary.Name = "txt_Salary";
            this.txt_Salary.Size = new System.Drawing.Size(315, 23);
            this.txt_Salary.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Hire Date:";
            // 
            // dtp_Hire_Date
            // 
            this.dtp_Hire_Date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_Hire_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Hire_Date.Location = new System.Drawing.Point(112, 196);
            this.dtp_Hire_Date.Name = "dtp_Hire_Date";
            this.dtp_Hire_Date.Size = new System.Drawing.Size(315, 23);
            this.dtp_Hire_Date.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Phone";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Phone.Location = new System.Drawing.Point(112, 287);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(315, 23);
            this.txt_Phone.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Manager:";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 257);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(315, 24);
            this.comboBox1.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 43);
            this.panel1.TabIndex = 24;
            // 
            // pnlPic
            // 
            this.pnlPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPic.Controls.Add(this.PicEmp);
            this.pnlPic.Controls.Add(this.panel3);
            this.pnlPic.Location = new System.Drawing.Point(3, 18);
            this.pnlPic.Name = "pnlPic";
            this.pnlPic.Size = new System.Drawing.Size(170, 173);
            this.pnlPic.TabIndex = 18;
            // 
            // PicEmp
            // 
            this.PicEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicEmp.Image = global::Inventory.Properties.Resources.Login;
            this.PicEmp.InitialImage = global::Inventory.Properties.Resources.Login;
            this.PicEmp.Location = new System.Drawing.Point(0, 0);
            this.PicEmp.Name = "PicEmp";
            this.PicEmp.Size = new System.Drawing.Size(168, 143);
            this.PicEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicEmp.TabIndex = 17;
            this.PicEmp.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnChangePic);
            this.panel3.Controls.Add(this.btnRemovePic);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 28);
            this.panel3.TabIndex = 2;
            // 
            // btnChangePic
            // 
            this.btnChangePic.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnChangePic.Location = new System.Drawing.Point(0, 0);
            this.btnChangePic.Name = "btnChangePic";
            this.btnChangePic.Size = new System.Drawing.Size(75, 28);
            this.btnChangePic.TabIndex = 0;
            this.btnChangePic.Text = "Change";
            this.btnChangePic.UseVisualStyleBackColor = true;
            this.btnChangePic.Click += new System.EventHandler(this.btnChangePic_Click);
            // 
            // btnRemovePic
            // 
            this.btnRemovePic.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemovePic.Location = new System.Drawing.Point(93, 0);
            this.btnRemovePic.Name = "btnRemovePic";
            this.btnRemovePic.Size = new System.Drawing.Size(75, 28);
            this.btnRemovePic.TabIndex = 1;
            this.btnRemovePic.Text = "Remove";
            this.btnRemovePic.UseVisualStyleBackColor = true;
            this.btnRemovePic.Click += new System.EventHandler(this.btnRemovePic_Click);
            // 
            // pnlMaster
            // 
            this.pnlMaster.Controls.Add(this.gbo_Emp_Info);
            this.pnlMaster.Controls.Add(this.pnlPic);
            this.pnlMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMaster.Location = new System.Drawing.Point(0, 0);
            this.pnlMaster.Name = "pnlMaster";
            this.pnlMaster.Size = new System.Drawing.Size(615, 466);
            this.pnlMaster.TabIndex = 19;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png";
            // 
            // frmEmpAddEdit
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.btn_Close;
            this.ClientSize = new System.Drawing.Size(615, 466);
            this.Controls.Add(this.pnlMaster);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEmpAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Employee";
            this.gbo_Emp_Info.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicEmp)).EndInit();
            this.panel3.ResumeLayout(false);
            this.pnlMaster.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_Hire_Date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_Date_Bith;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private CustomControls.NumTextBox txt_Salary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlPic;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnChangePic;
        private System.Windows.Forms.Button btnRemovePic;
        private System.Windows.Forms.PictureBox PicEmp;
        private System.Windows.Forms.Panel pnlMaster;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}