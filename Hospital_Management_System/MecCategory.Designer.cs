namespace Hospital_Management_System
{
    partial class MecCategory
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
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtUsage = new System.Windows.Forms.TextBox();
            this.txtcategoryID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstView
            // 
            this.lstView.FormattingEnabled = true;
            this.lstView.Location = new System.Drawing.Point(17, 50);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(169, 225);
            this.lstView.TabIndex = 122;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(17, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 20);
            this.txtSearch.TabIndex = 121;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(316, 243);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(99, 32);
            this.btEdit.TabIndex = 120;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 119;
            this.label7.Text = "Usage:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 118;
            this.label4.Text = "Category Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 116;
            this.label2.Text = "Made In:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 115;
            this.label1.Text = "Category ID:";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(421, 243);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(99, 32);
            this.btSave.TabIndex = 114;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(211, 243);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(99, 32);
            this.btNew.TabIndex = 113;
            this.btNew.Text = "New";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(345, 104);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(178, 21);
            this.cmbCountry.TabIndex = 111;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(345, 61);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(177, 20);
            this.txtCategoryName.TabIndex = 110;
            // 
            // txtUsage
            // 
            this.txtUsage.Location = new System.Drawing.Point(343, 146);
            this.txtUsage.Multiline = true;
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.Size = new System.Drawing.Size(180, 81);
            this.txtUsage.TabIndex = 109;
            // 
            // txtcategoryID
            // 
            this.txtcategoryID.Location = new System.Drawing.Point(345, 20);
            this.txtcategoryID.Name = "txtcategoryID";
            this.txtcategoryID.Size = new System.Drawing.Size(177, 20);
            this.txtcategoryID.TabIndex = 108;
            // 
            // MecCategory
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
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.txtUsage);
            this.Controls.Add(this.txtcategoryID);
            this.Name = "MecCategory";
            this.Size = new System.Drawing.Size(834, 554);
            this.Load += new System.EventHandler(this.MecCategory_Load);
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
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtUsage;
        private System.Windows.Forms.TextBox txtcategoryID;
    }
}
