namespace Hospital_Management_System
{
    partial class ServiceModule
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstView
            // 
            this.lstView.FormattingEnabled = true;
            this.lstView.Location = new System.Drawing.Point(16, 46);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(169, 212);
            this.lstView.TabIndex = 123;
            this.lstView.SelectedIndexChanged += new System.EventHandler(this.lstView_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(16, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 20);
            this.txtSearch.TabIndex = 122;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(361, 226);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(99, 32);
            this.btEdit.TabIndex = 121;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 120;
            this.label7.Text = "Cost:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 118;
            this.label4.Text = "Infamation:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 116;
            this.label2.Text = "Service Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 115;
            this.label1.Text = "Service ID:";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(466, 226);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(99, 32);
            this.btSave.TabIndex = 114;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(256, 226);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(99, 32);
            this.btNew.TabIndex = 113;
            this.btNew.Text = "New";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click_1);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(390, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 20);
            this.txtName.TabIndex = 112;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(388, 115);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(177, 20);
            this.txtCost.TabIndex = 111;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(388, 160);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(177, 20);
            this.txtInfo.TabIndex = 110;
            // 
            // txtServiceID
            // 
            this.txtServiceID.Location = new System.Drawing.Point(390, 27);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.Size = new System.Drawing.Size(177, 20);
            this.txtServiceID.TabIndex = 108;
            // 
            // ServiceModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstView);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtServiceID);
            this.Name = "ServiceModule";
            this.Size = new System.Drawing.Size(834, 554);
            this.Load += new System.EventHandler(this.ServiceModule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstView;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtServiceID;
    }
}
