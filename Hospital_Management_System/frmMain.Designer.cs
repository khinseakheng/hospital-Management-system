namespace Hospital_Management_System
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btBilling = new System.Windows.Forms.Button();
            this.btMasrerEntry = new System.Windows.Forms.Button();
            this.btProcces = new System.Windows.Forms.Button();
            this.btPeople = new System.Windows.Forms.Button();
            this.btRegister = new System.Windows.Forms.Button();
            this.masterEntry1 = new Hospital_Management_System.MasterEntry();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNation = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.txtBD = new System.Windows.Forms.TextBox();
            this.txtIllStatus = new System.Windows.Forms.TextBox();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbBtype = new System.Windows.Forms.ComboBox();
            this.btNew = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.peopleModule1 = new Hospital_Management_System.PeopleModule();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.btBilling);
            this.panel1.Controls.Add(this.btMasrerEntry);
            this.panel1.Controls.Add(this.btProcces);
            this.panel1.Controls.Add(this.btPeople);
            this.panel1.Controls.Add(this.btRegister);
            this.panel1.Location = new System.Drawing.Point(163, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 32);
            this.panel1.TabIndex = 1;
            // 
            // btBilling
            // 
            this.btBilling.Location = new System.Drawing.Point(406, 0);
            this.btBilling.Name = "btBilling";
            this.btBilling.Size = new System.Drawing.Size(99, 32);
            this.btBilling.TabIndex = 18;
            this.btBilling.Text = "Billing";
            this.btBilling.UseVisualStyleBackColor = true;
            // 
            // btMasrerEntry
            // 
            this.btMasrerEntry.Location = new System.Drawing.Point(305, 0);
            this.btMasrerEntry.Name = "btMasrerEntry";
            this.btMasrerEntry.Size = new System.Drawing.Size(99, 32);
            this.btMasrerEntry.TabIndex = 17;
            this.btMasrerEntry.Text = "Master Entry";
            this.btMasrerEntry.UseVisualStyleBackColor = true;
            this.btMasrerEntry.Click += new System.EventHandler(this.btMasrerEntry_Click);
            // 
            // btProcces
            // 
            this.btProcces.Location = new System.Drawing.Point(203, 0);
            this.btProcces.Name = "btProcces";
            this.btProcces.Size = new System.Drawing.Size(99, 32);
            this.btProcces.TabIndex = 16;
            this.btProcces.Text = "Procces";
            this.btProcces.UseVisualStyleBackColor = true;
            // 
            // btPeople
            // 
            this.btPeople.Location = new System.Drawing.Point(101, 0);
            this.btPeople.Name = "btPeople";
            this.btPeople.Size = new System.Drawing.Size(99, 32);
            this.btPeople.TabIndex = 15;
            this.btPeople.Text = "People";
            this.btPeople.UseVisualStyleBackColor = true;
            this.btPeople.Click += new System.EventHandler(this.btPeople_Click);
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(-1, 0);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(99, 32);
            this.btRegister.TabIndex = 14;
            this.btRegister.Text = "Registration";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // masterEntry1
            // 
            this.masterEntry1.Location = new System.Drawing.Point(2, 108);
            this.masterEntry1.Name = "masterEntry1";
            this.masterEntry1.Size = new System.Drawing.Size(1004, 520);
            this.masterEntry1.TabIndex = 27;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(341, 208);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(177, 20);
            this.txtID.TabIndex = 2;
            // 
            // txtNation
            // 
            this.txtNation.Location = new System.Drawing.Point(341, 297);
            this.txtNation.Name = "txtNation";
            this.txtNation.Size = new System.Drawing.Size(177, 20);
            this.txtNation.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(341, 253);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(711, 208);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(177, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(711, 253);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(177, 20);
            this.txtPhone.TabIndex = 6;
            // 
            // txtOccupation
            // 
            this.txtOccupation.Location = new System.Drawing.Point(711, 297);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(177, 20);
            this.txtOccupation.TabIndex = 7;
            // 
            // txtBD
            // 
            this.txtBD.Location = new System.Drawing.Point(711, 339);
            this.txtBD.Name = "txtBD";
            this.txtBD.Size = new System.Drawing.Size(177, 20);
            this.txtBD.TabIndex = 8;
            // 
            // txtIllStatus
            // 
            this.txtIllStatus.Location = new System.Drawing.Point(711, 388);
            this.txtIllStatus.Name = "txtIllStatus";
            this.txtIllStatus.Size = new System.Drawing.Size(177, 20);
            this.txtIllStatus.TabIndex = 9;
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Location = new System.Drawing.Point(341, 339);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(178, 21);
            this.cmbSex.TabIndex = 10;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(341, 388);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(178, 21);
            this.cmbType.TabIndex = 11;
            // 
            // cmbBtype
            // 
            this.cmbBtype.FormattingEnabled = true;
            this.cmbBtype.Location = new System.Drawing.Point(341, 429);
            this.cmbBtype.Name = "cmbBtype";
            this.cmbBtype.Size = new System.Drawing.Size(178, 21);
            this.cmbBtype.TabIndex = 12;
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(653, 432);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(99, 32);
            this.btNew.TabIndex = 13;
            this.btNew.Text = "New";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(789, 432);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(99, 32);
            this.btSave.TabIndex = 14;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Patient ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Patient Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nation :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Patient Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Blood Type:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(624, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Address:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(624, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Phone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(624, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Occupation:";
            // 
            // peopleModule1
            // 
            this.peopleModule1.Location = new System.Drawing.Point(2, 108);
            this.peopleModule1.Name = "peopleModule1";
            this.peopleModule1.Size = new System.Drawing.Size(1004, 520);
            this.peopleModule1.TabIndex = 26;
            this.peopleModule1.Load += new System.EventHandler(this.peopleModule1_Load);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(624, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "BirhtDate:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(624, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Ill Status:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1021, 195);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(221, 194);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 629);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.masterEntry1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.cmbBtype);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.txtIllStatus);
            this.Controls.Add(this.txtBD);
            this.Controls.Add(this.txtOccupation);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNation);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.peopleModule1);
            this.Name = "frmMain";
            this.Text = "Hospital Management System ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btBilling;
        private System.Windows.Forms.Button btMasrerEntry;
        private System.Windows.Forms.Button btProcces;
        private System.Windows.Forms.Button btPeople;
        private System.Windows.Forms.Button btRegister;
        private MasterEntry masterEntry1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtOccupation;
        private System.Windows.Forms.TextBox txtBD;
        private System.Windows.Forms.TextBox txtIllStatus;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbBtype;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private PeopleModule peopleModule1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        //private MasterEntry masterEntry1;
    }
}

