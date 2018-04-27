namespace Hospital_Management_System
{
    partial class RoomModule
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
            this.lstView = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btEdit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.cmbRoomTID = new System.Windows.Forms.ComboBox();
            this.cmbBuiding = new System.Windows.Forms.ComboBox();
            this.cmbRType = new System.Windows.Forms.ComboBox();
            this.txtAvaliable = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtFloor = new System.Windows.Forms.TextBox();
            this.txtTotalBed = new System.Windows.Forms.TextBox();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCheck = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstView
            // 
            this.lstView.FormattingEnabled = true;
            this.lstView.Location = new System.Drawing.Point(14, 49);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(169, 212);
            this.lstView.TabIndex = 107;
            this.lstView.SelectedIndexChanged += new System.EventHandler(this.lstView_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(14, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 20);
            this.txtSearch.TabIndex = 106;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(625, 107);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(99, 32);
            this.btEdit.TabIndex = 105;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 104;
            this.label7.Text = "Room Type ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(538, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 100;
            this.label11.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 99;
            this.label6.Text = "Avaliable Bed:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 98;
            this.label5.Text = "Building:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 97;
            this.label4.Text = "Floor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 96;
            this.label3.Text = "Total Bed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "Room Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Room No:";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(726, 107);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(99, 32);
            this.btSave.TabIndex = 93;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(523, 106);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(99, 32);
            this.btNew.TabIndex = 92;
            this.btNew.Text = "New";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // cmbRoomTID
            // 
            this.cmbRoomTID.FormattingEnabled = true;
            this.cmbRoomTID.Location = new System.Drawing.Point(330, 106);
            this.cmbRoomTID.Name = "cmbRoomTID";
            this.cmbRoomTID.Size = new System.Drawing.Size(178, 21);
            this.cmbRoomTID.TabIndex = 91;
            // 
            // cmbBuiding
            // 
            this.cmbBuiding.FormattingEnabled = true;
            this.cmbBuiding.Location = new System.Drawing.Point(328, 191);
            this.cmbBuiding.Name = "cmbBuiding";
            this.cmbBuiding.Size = new System.Drawing.Size(178, 21);
            this.cmbBuiding.TabIndex = 90;
            // 
            // cmbRType
            // 
            this.cmbRType.FormattingEnabled = true;
            this.cmbRType.Location = new System.Drawing.Point(330, 64);
            this.cmbRType.Name = "cmbRType";
            this.cmbRType.Size = new System.Drawing.Size(178, 21);
            this.cmbRType.TabIndex = 89;
            this.cmbRType.SelectedIndexChanged += new System.EventHandler(this.cmbRType_SelectedIndexChanged);
            this.cmbRType.MouseEnter += new System.EventHandler(this.cmbRType_MouseEnter);
            this.cmbRType.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cmbRType_MouseUp);
            // 
            // txtAvaliable
            // 
            this.txtAvaliable.Location = new System.Drawing.Point(625, 15);
            this.txtAvaliable.Name = "txtAvaliable";
            this.txtAvaliable.Size = new System.Drawing.Size(177, 20);
            this.txtAvaliable.TabIndex = 88;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(625, 57);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(177, 20);
            this.txtprice.TabIndex = 84;
            // 
            // txtFloor
            // 
            this.txtFloor.Location = new System.Drawing.Point(330, 152);
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(177, 20);
            this.txtFloor.TabIndex = 83;
            // 
            // txtTotalBed
            // 
            this.txtTotalBed.Location = new System.Drawing.Point(330, 235);
            this.txtTotalBed.Name = "txtTotalBed";
            this.txtTotalBed.Size = new System.Drawing.Size(177, 20);
            this.txtTotalBed.TabIndex = 82;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(332, 19);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(177, 20);
            this.txtRoomNo.TabIndex = 81;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCheck);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(526, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 103);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check Room ";
            // 
            // tbCheck
            // 
            this.tbCheck.Location = new System.Drawing.Point(161, 37);
            this.tbCheck.Name = "tbCheck";
            this.tbCheck.Size = new System.Drawing.Size(99, 32);
            this.tbCheck.TabIndex = 109;
            this.tbCheck.Text = "Check";
            this.tbCheck.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(10, 68);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(67, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "All Room";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(99, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Avaliable Room";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Busy Room";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // RoomModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstView);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.cmbRoomTID);
            this.Controls.Add(this.cmbBuiding);
            this.Controls.Add(this.cmbRType);
            this.Controls.Add(this.txtAvaliable);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtFloor);
            this.Controls.Add(this.txtTotalBed);
            this.Controls.Add(this.txtRoomNo);
            this.Name = "RoomModule";
            this.Size = new System.Drawing.Size(834, 554);
            this.Load += new System.EventHandler(this.RoomModule_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstView;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.ComboBox cmbRoomTID;
        private System.Windows.Forms.ComboBox cmbBuiding;
        private System.Windows.Forms.ComboBox cmbRType;
        private System.Windows.Forms.TextBox txtAvaliable;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtFloor;
        private System.Windows.Forms.TextBox txtTotalBed;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button tbCheck;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}
