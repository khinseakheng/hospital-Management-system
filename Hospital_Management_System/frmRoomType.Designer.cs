namespace Hospital_Management_System
{
    partial class frmRoomType
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
            this.lstRoomType = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstRoomType
            // 
            this.lstRoomType.FormattingEnabled = true;
            this.lstRoomType.Location = new System.Drawing.Point(12, 41);
            this.lstRoomType.Name = "lstRoomType";
            this.lstRoomType.Size = new System.Drawing.Size(168, 212);
            this.lstRoomType.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(168, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(12, 259);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(167, 30);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "Select Type";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // frmRoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 301);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstRoomType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmRoomType";
            this.Text = "Room Tpye";
            this.Load += new System.EventHandler(this.frmRoomType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRoomType;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btOk;
    }
}