
namespace AITLibraryBooks9
{
    partial class AdminMenu
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
            this.btnUserMaintenance = new System.Windows.Forms.Button();
            this.btnBookMaintenance = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCategoryMaintenance = new System.Windows.Forms.Button();
            this.btnLanguageMaintenance = new System.Windows.Forms.Button();
            this.btnAuthorMaintenance = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "AIT Library System - Admin Menu";
            // 
            // btnUserMaintenance
            // 
            this.btnUserMaintenance.Location = new System.Drawing.Point(102, 103);
            this.btnUserMaintenance.Name = "btnUserMaintenance";
            this.btnUserMaintenance.Size = new System.Drawing.Size(240, 40);
            this.btnUserMaintenance.TabIndex = 1;
            this.btnUserMaintenance.Text = "User Maintenance";
            this.btnUserMaintenance.UseVisualStyleBackColor = true;
            this.btnUserMaintenance.Click += new System.EventHandler(this.btnUserMaintenance_Click);
            // 
            // btnBookMaintenance
            // 
            this.btnBookMaintenance.Location = new System.Drawing.Point(102, 149);
            this.btnBookMaintenance.Name = "btnBookMaintenance";
            this.btnBookMaintenance.Size = new System.Drawing.Size(240, 40);
            this.btnBookMaintenance.TabIndex = 2;
            this.btnBookMaintenance.Text = "Book Maintenance";
            this.btnBookMaintenance.UseVisualStyleBackColor = true;
            this.btnBookMaintenance.Click += new System.EventHandler(this.btnBookMaintenance_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(534, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCategoryMaintenance
            // 
            this.btnCategoryMaintenance.Location = new System.Drawing.Point(102, 195);
            this.btnCategoryMaintenance.Name = "btnCategoryMaintenance";
            this.btnCategoryMaintenance.Size = new System.Drawing.Size(240, 40);
            this.btnCategoryMaintenance.TabIndex = 4;
            this.btnCategoryMaintenance.Text = "Category Maintenance";
            this.btnCategoryMaintenance.UseVisualStyleBackColor = true;
            this.btnCategoryMaintenance.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLanguageMaintenance
            // 
            this.btnLanguageMaintenance.Location = new System.Drawing.Point(102, 242);
            this.btnLanguageMaintenance.Name = "btnLanguageMaintenance";
            this.btnLanguageMaintenance.Size = new System.Drawing.Size(240, 40);
            this.btnLanguageMaintenance.TabIndex = 5;
            this.btnLanguageMaintenance.Text = "Language Maintenance";
            this.btnLanguageMaintenance.UseVisualStyleBackColor = true;
            // 
            // btnAuthorMaintenance
            // 
            this.btnAuthorMaintenance.Location = new System.Drawing.Point(102, 289);
            this.btnAuthorMaintenance.Name = "btnAuthorMaintenance";
            this.btnAuthorMaintenance.Size = new System.Drawing.Size(240, 40);
            this.btnAuthorMaintenance.TabIndex = 6;
            this.btnAuthorMaintenance.Text = "Author Maintenance";
            this.btnAuthorMaintenance.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(102, 336);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(240, 40);
            this.btnReports.TabIndex = 7;
            this.btnReports.Text = "Reports Menu";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnAuthorMaintenance);
            this.Controls.Add(this.btnLanguageMaintenance);
            this.Controls.Add(this.btnCategoryMaintenance);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBookMaintenance);
            this.Controls.Add(this.btnUserMaintenance);
            this.Controls.Add(this.label1);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUserMaintenance;
        private System.Windows.Forms.Button btnBookMaintenance;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCategoryMaintenance;
        private System.Windows.Forms.Button btnLanguageMaintenance;
        private System.Windows.Forms.Button btnAuthorMaintenance;
        private System.Windows.Forms.Button btnReports;
    }
}