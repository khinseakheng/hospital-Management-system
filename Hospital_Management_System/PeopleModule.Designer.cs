namespace Hospital_Management_System
{
    partial class PeopleModule
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btPateint = new System.Windows.Forms.Button();
            this.btDoctor = new System.Windows.Forms.Button();
            this.btStaff = new System.Windows.Forms.Button();
            this.btSupplier = new System.Windows.Forms.Button();
            this.btUser = new System.Windows.Forms.Button();
            this.patientModule1 = new Hospital_Management_System.PatientModule();
            this.doctorModule1 = new Hospital_Management_System.DoctorModule();
            this.staffModule1 = new Hospital_Management_System.StaffModule();
            this.userModule1 = new Hospital_Management_System.UserModule();
            this.supplierModule1 = new Hospital_Management_System.SupplierModule();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.btUser);
            this.panel1.Controls.Add(this.btSupplier);
            this.panel1.Controls.Add(this.btStaff);
            this.panel1.Controls.Add(this.btDoctor);
            this.panel1.Controls.Add(this.btPateint);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 519);
            this.panel1.TabIndex = 0;
            // 
            // btPateint
            // 
            this.btPateint.Location = new System.Drawing.Point(0, 3);
            this.btPateint.Name = "btPateint";
            this.btPateint.Size = new System.Drawing.Size(161, 41);
            this.btPateint.TabIndex = 0;
            this.btPateint.Text = "Patient";
            this.btPateint.UseVisualStyleBackColor = true;
            this.btPateint.Click += new System.EventHandler(this.btPateint_Click);
            // 
            // btDoctor
            // 
            this.btDoctor.Location = new System.Drawing.Point(0, 43);
            this.btDoctor.Name = "btDoctor";
            this.btDoctor.Size = new System.Drawing.Size(161, 41);
            this.btDoctor.TabIndex = 1;
            this.btDoctor.Text = "Doctor";
            this.btDoctor.UseVisualStyleBackColor = true;
            this.btDoctor.Click += new System.EventHandler(this.btDoctor_Click);
            // 
            // btStaff
            // 
            this.btStaff.Location = new System.Drawing.Point(0, 84);
            this.btStaff.Name = "btStaff";
            this.btStaff.Size = new System.Drawing.Size(161, 41);
            this.btStaff.TabIndex = 2;
            this.btStaff.Text = "Staff";
            this.btStaff.UseVisualStyleBackColor = true;
            this.btStaff.Click += new System.EventHandler(this.btStaff_Click);
            // 
            // btSupplier
            // 
            this.btSupplier.Location = new System.Drawing.Point(0, 125);
            this.btSupplier.Name = "btSupplier";
            this.btSupplier.Size = new System.Drawing.Size(161, 41);
            this.btSupplier.TabIndex = 3;
            this.btSupplier.Text = "Supplier";
            this.btSupplier.UseVisualStyleBackColor = true;
            this.btSupplier.Click += new System.EventHandler(this.btSupplier_Click);
            // 
            // btUser
            // 
            this.btUser.Location = new System.Drawing.Point(0, 166);
            this.btUser.Name = "btUser";
            this.btUser.Size = new System.Drawing.Size(161, 41);
            this.btUser.TabIndex = 4;
            this.btUser.Text = "User";
            this.btUser.UseVisualStyleBackColor = true;
            this.btUser.Click += new System.EventHandler(this.btUser_Click);
            // 
            // patientModule1
            // 
            this.patientModule1.Location = new System.Drawing.Point(167, 0);
            this.patientModule1.Name = "patientModule1";
            this.patientModule1.Size = new System.Drawing.Size(834, 554);
            this.patientModule1.TabIndex = 1;
            // 
            // doctorModule1
            // 
            this.doctorModule1.Location = new System.Drawing.Point(167, 1);
            this.doctorModule1.Name = "doctorModule1";
            this.doctorModule1.Size = new System.Drawing.Size(834, 554);
            this.doctorModule1.TabIndex = 2;
            // 
            // staffModule1
            // 
            this.staffModule1.Location = new System.Drawing.Point(165, 3);
            this.staffModule1.Name = "staffModule1";
            this.staffModule1.Size = new System.Drawing.Size(834, 554);
            this.staffModule1.TabIndex = 3;
            // 
            // userModule1
            // 
            this.userModule1.Location = new System.Drawing.Point(165, 4);
            this.userModule1.Name = "userModule1";
            this.userModule1.Size = new System.Drawing.Size(834, 554);
            this.userModule1.TabIndex = 4;
            // 
            // supplierModule1
            // 
            this.supplierModule1.Location = new System.Drawing.Point(165, 1);
            this.supplierModule1.Name = "supplierModule1";
            this.supplierModule1.Size = new System.Drawing.Size(834, 554);
            this.supplierModule1.TabIndex = 5;
            // 
            // PeopleModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.supplierModule1);
            this.Controls.Add(this.userModule1);
            this.Controls.Add(this.staffModule1);
            this.Controls.Add(this.doctorModule1);
            this.Controls.Add(this.patientModule1);
            this.Controls.Add(this.panel1);
            this.Name = "PeopleModule";
            this.Size = new System.Drawing.Size(1004, 520);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btUser;
        private System.Windows.Forms.Button btSupplier;
        private System.Windows.Forms.Button btStaff;
        private System.Windows.Forms.Button btDoctor;
        private System.Windows.Forms.Button btPateint;
        private PatientModule patientModule1;
        private DoctorModule doctorModule1;
        private StaffModule staffModule1;
        private UserModule userModule1;
        private SupplierModule supplierModule1;
    }
}
