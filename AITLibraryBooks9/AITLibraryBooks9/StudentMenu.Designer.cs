
namespace AITLibraryBooks9
{
    partial class StudentMenu
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
            this.btnBrowseSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrowseSearch
            // 
            this.btnBrowseSearch.Location = new System.Drawing.Point(78, 120);
            this.btnBrowseSearch.Name = "btnBrowseSearch";
            this.btnBrowseSearch.Size = new System.Drawing.Size(240, 40);
            this.btnBrowseSearch.TabIndex = 0;
            this.btnBrowseSearch.Text = "Browse and Search";
            this.btnBrowseSearch.UseVisualStyleBackColor = true;
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBrowseSearch);
            this.Name = "StudentMenu";
            this.Text = "StudentMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseSearch;
    }
}