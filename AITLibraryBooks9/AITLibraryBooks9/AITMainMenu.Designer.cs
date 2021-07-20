
namespace AITLibraryBooks9
{
    partial class AITMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AITMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonCancel = new FontAwesome.Sharp.IconButton();
            this.iconReport = new FontAwesome.Sharp.IconButton();
            this.buttonMedia = new FontAwesome.Sharp.IconButton();
            this.iconMyProfile = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelBar = new System.Windows.Forms.Label();
            this.iconMenuBar = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMenuBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMenu.Controls.Add(this.buttonCancel);
            this.panelMenu.Controls.Add(this.iconReport);
            this.panelMenu.Controls.Add(this.buttonMedia);
            this.panelMenu.Controls.Add(this.iconMyProfile);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 444);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCancel.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.buttonCancel.IconColor = System.Drawing.Color.White;
            this.buttonCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonCancel.IconSize = 32;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(0, 384);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonCancel.Size = new System.Drawing.Size(200, 60);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // iconReport
            // 
            this.iconReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconReport.FlatAppearance.BorderSize = 0;
            this.iconReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconReport.ForeColor = System.Drawing.Color.White;
            this.iconReport.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.iconReport.IconColor = System.Drawing.Color.White;
            this.iconReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconReport.IconSize = 32;
            this.iconReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconReport.Location = new System.Drawing.Point(0, 270);
            this.iconReport.Name = "iconReport";
            this.iconReport.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconReport.Size = new System.Drawing.Size(200, 60);
            this.iconReport.TabIndex = 3;
            this.iconReport.Text = "Report";
            this.iconReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconReport.UseVisualStyleBackColor = true;
            this.iconReport.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // buttonMedia
            // 
            this.buttonMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMedia.FlatAppearance.BorderSize = 0;
            this.buttonMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMedia.ForeColor = System.Drawing.Color.White;
            this.buttonMedia.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.buttonMedia.IconColor = System.Drawing.Color.White;
            this.buttonMedia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonMedia.IconSize = 32;
            this.buttonMedia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMedia.Location = new System.Drawing.Point(0, 210);
            this.buttonMedia.Name = "buttonMedia";
            this.buttonMedia.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonMedia.Size = new System.Drawing.Size(200, 60);
            this.buttonMedia.TabIndex = 2;
            this.buttonMedia.Text = "Media";
            this.buttonMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMedia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMedia.UseVisualStyleBackColor = true;
            this.buttonMedia.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconMyProfile
            // 
            this.iconMyProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconMyProfile.FlatAppearance.BorderSize = 0;
            this.iconMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconMyProfile.ForeColor = System.Drawing.Color.White;
            this.iconMyProfile.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconMyProfile.IconColor = System.Drawing.Color.White;
            this.iconMyProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMyProfile.IconSize = 32;
            this.iconMyProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconMyProfile.Location = new System.Drawing.Point(0, 150);
            this.iconMyProfile.Name = "iconMyProfile";
            this.iconMyProfile.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconMyProfile.Size = new System.Drawing.Size(200, 60);
            this.iconMyProfile.TabIndex = 1;
            this.iconMyProfile.Text = "My Profile";
            this.iconMyProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconMyProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconMyProfile.UseVisualStyleBackColor = true;
            this.iconMyProfile.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.SteelBlue;
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelLogo.Size = new System.Drawing.Size(200, 150);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(29, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "AIT Library ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitleBar.Controls.Add(this.labelBar);
            this.panelTitleBar.Controls.Add(this.iconMenuBar);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(600, 60);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            // 
            // labelBar
            // 
            this.labelBar.AutoSize = true;
            this.labelBar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBar.ForeColor = System.Drawing.Color.MintCream;
            this.labelBar.Location = new System.Drawing.Point(44, 24);
            this.labelBar.Name = "labelBar";
            this.labelBar.Size = new System.Drawing.Size(74, 20);
            this.labelBar.TabIndex = 1;
            this.labelBar.Text = "User Menu";
            this.labelBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBar.Click += new System.EventHandler(this.labelBar_Click);
            // 
            // iconMenuBar
            // 
            this.iconMenuBar.BackColor = System.Drawing.Color.SteelBlue;
            this.iconMenuBar.ForeColor = System.Drawing.Color.MintCream;
            this.iconMenuBar.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.iconMenuBar.IconColor = System.Drawing.Color.MintCream;
            this.iconMenuBar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuBar.Location = new System.Drawing.Point(6, 12);
            this.iconMenuBar.Name = "iconMenuBar";
            this.iconMenuBar.Size = new System.Drawing.Size(32, 32);
            this.iconMenuBar.TabIndex = 0;
            this.iconMenuBar.TabStop = false;
            this.iconMenuBar.Click += new System.EventHandler(this.iconMenuBar_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 60);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(600, 384);
            this.panelDesktop.TabIndex = 2;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // AITMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "AITMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMenuBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconReport;
        private FontAwesome.Sharp.IconButton buttonMedia;
        private FontAwesome.Sharp.IconButton iconMyProfile;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelBar;
        private FontAwesome.Sharp.IconPictureBox iconMenuBar;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton buttonCancel;
    }
}