namespace Hospital_Management_System
{
    partial class MasterEntry
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
            this.btSchedule = new System.Windows.Forms.Button();
            this.btService = new System.Windows.Forms.Button();
            this.btMeCategory = new System.Windows.Forms.Button();
            this.btMedecine = new System.Windows.Forms.Button();
            this.btRoomType = new System.Windows.Forms.Button();
            this.btRoom = new System.Windows.Forms.Button();
            this.roomType1 = new Hospital_Management_System.RoomType();
            this.roomModule1 = new Hospital_Management_System.RoomModule();
            this.serviceModule1 = new Hospital_Management_System.ServiceModule();
            this.medicineModule1 = new Hospital_Management_System.MedicineModule();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.btSchedule);
            this.panel1.Controls.Add(this.btService);
            this.panel1.Controls.Add(this.btMeCategory);
            this.panel1.Controls.Add(this.btMedecine);
            this.panel1.Controls.Add(this.btRoomType);
            this.panel1.Controls.Add(this.btRoom);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 519);
            this.panel1.TabIndex = 1;
            // 
            // btSchedule
            // 
            this.btSchedule.Location = new System.Drawing.Point(1, 208);
            this.btSchedule.Name = "btSchedule";
            this.btSchedule.Size = new System.Drawing.Size(161, 41);
            this.btSchedule.TabIndex = 5;
            this.btSchedule.Text = "Doctor Schedule";
            this.btSchedule.UseVisualStyleBackColor = true;
            // 
            // btService
            // 
            this.btService.Location = new System.Drawing.Point(0, 166);
            this.btService.Name = "btService";
            this.btService.Size = new System.Drawing.Size(161, 41);
            this.btService.TabIndex = 4;
            this.btService.Text = "Service";
            this.btService.UseVisualStyleBackColor = true;
            this.btService.Click += new System.EventHandler(this.btService_Click);
            // 
            // btMeCategory
            // 
            this.btMeCategory.Location = new System.Drawing.Point(0, 125);
            this.btMeCategory.Name = "btMeCategory";
            this.btMeCategory.Size = new System.Drawing.Size(161, 41);
            this.btMeCategory.TabIndex = 3;
            this.btMeCategory.Text = "Medecine Category";
            this.btMeCategory.UseVisualStyleBackColor = true;
            // 
            // btMedecine
            // 
            this.btMedecine.Location = new System.Drawing.Point(0, 84);
            this.btMedecine.Name = "btMedecine";
            this.btMedecine.Size = new System.Drawing.Size(161, 41);
            this.btMedecine.TabIndex = 2;
            this.btMedecine.Text = "Medecine";
            this.btMedecine.UseVisualStyleBackColor = true;
            this.btMedecine.Click += new System.EventHandler(this.btMedecine_Click);
            // 
            // btRoomType
            // 
            this.btRoomType.Location = new System.Drawing.Point(0, 43);
            this.btRoomType.Name = "btRoomType";
            this.btRoomType.Size = new System.Drawing.Size(161, 41);
            this.btRoomType.TabIndex = 1;
            this.btRoomType.Text = "RoomType";
            this.btRoomType.UseVisualStyleBackColor = true;
            this.btRoomType.Click += new System.EventHandler(this.btRoomType_Click);
            // 
            // btRoom
            // 
            this.btRoom.Location = new System.Drawing.Point(0, 3);
            this.btRoom.Name = "btRoom";
            this.btRoom.Size = new System.Drawing.Size(161, 41);
            this.btRoom.TabIndex = 0;
            this.btRoom.Text = "Room";
            this.btRoom.UseVisualStyleBackColor = true;
            this.btRoom.Click += new System.EventHandler(this.btRoom_Click);
            // 
            // roomType1
            // 
            this.roomType1.Location = new System.Drawing.Point(163, 2);
            this.roomType1.Name = "roomType1";
            this.roomType1.Size = new System.Drawing.Size(834, 515);
            this.roomType1.TabIndex = 2;
            // 
            // roomModule1
            // 
            this.roomModule1.Location = new System.Drawing.Point(163, 1);
            this.roomModule1.Name = "roomModule1";
            this.roomModule1.Size = new System.Drawing.Size(834, 554);
            this.roomModule1.TabIndex = 3;
            // 
            // serviceModule1
            // 
            this.serviceModule1.Location = new System.Drawing.Point(163, 2);
            this.serviceModule1.Name = "serviceModule1";
            this.serviceModule1.Size = new System.Drawing.Size(834, 554);
            this.serviceModule1.TabIndex = 4;
            // 
            // medicineModule1
            // 
            this.medicineModule1.Location = new System.Drawing.Point(163, 2);
            this.medicineModule1.Name = "medicineModule1";
            this.medicineModule1.Size = new System.Drawing.Size(834, 518);
            this.medicineModule1.TabIndex = 5;
            // 
            // MasterEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.medicineModule1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roomModule1);
            this.Controls.Add(this.roomType1);
            this.Controls.Add(this.serviceModule1);
            this.Name = "MasterEntry";
            this.Size = new System.Drawing.Size(1004, 520);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btService;
        private System.Windows.Forms.Button btMeCategory;
        private System.Windows.Forms.Button btMedecine;
        private System.Windows.Forms.Button btRoomType;
        private System.Windows.Forms.Button btRoom;
        private System.Windows.Forms.Button btSchedule;
        private RoomType roomType1;
        private RoomModule roomModule1;
        private ServiceModule serviceModule1;
        private MedicineModule medicineModule1;
    }
}
