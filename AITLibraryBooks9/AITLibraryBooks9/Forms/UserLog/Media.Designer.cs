
namespace AITLibraryBooks9.Forms
{
    partial class Media
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Media));
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelMediaChild = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelMediaBar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonCancel = new FontAwesome.Sharp.IconButton();
            this.buttonBorrow = new FontAwesome.Sharp.IconButton();
            this.buttonReserve = new FontAwesome.Sharp.IconButton();
            this.buttonSearch = new FontAwesome.Sharp.IconButton();
            this.buttonBrowse = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPublishYear = new System.Windows.Forms.TextBox();
            this.btnSearchYear = new System.Windows.Forms.Button();
            this.btnSearchAuthor = new System.Windows.Forms.Button();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.btnSearchCategory = new System.Windows.Forms.Button();
            this.lblBookName = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.panelDesktop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelMediaChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelMediaBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelDesktop.Controls.Add(this.panel3);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(846, 548);
            this.panelDesktop.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.panelMediaChild);
            this.panel3.Controls.Add(this.panelMediaBar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(846, 548);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panelMediaChild
            // 
            this.panelMediaChild.Controls.Add(this.panel1);
            this.panelMediaChild.Controls.Add(this.dataGridView1);
            this.panelMediaChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMediaChild.Location = new System.Drawing.Point(0, 60);
            this.panelMediaChild.Name = "panelMediaChild";
            this.panelMediaChild.Size = new System.Drawing.Size(846, 488);
            this.panelMediaChild.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 298);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panelMediaBar
            // 
            this.panelMediaBar.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMediaBar.Controls.Add(this.label2);
            this.panelMediaBar.Controls.Add(this.labelUser);
            this.panelMediaBar.Controls.Add(this.iconPictureBox1);
            this.panelMediaBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMediaBar.Location = new System.Drawing.Point(0, 0);
            this.panelMediaBar.Name = "panelMediaBar";
            this.panelMediaBar.Size = new System.Drawing.Size(846, 60);
            this.panelMediaBar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(55, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Media";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.MintCream;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Atlas;
            this.iconPictureBox1.IconColor = System.Drawing.Color.MintCream;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(17, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMenu.Controls.Add(this.buttonCancel);
            this.panelMenu.Controls.Add(this.buttonBorrow);
            this.panelMenu.Controls.Add(this.buttonReserve);
            this.panelMenu.Controls.Add(this.buttonSearch);
            this.panelMenu.Controls.Add(this.buttonBrowse);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 548);
            this.panelMenu.TabIndex = 3;
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
            this.buttonCancel.Location = new System.Drawing.Point(0, 488);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonCancel.Size = new System.Drawing.Size(200, 60);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBorrow.FlatAppearance.BorderSize = 0;
            this.buttonBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrow.ForeColor = System.Drawing.Color.White;
            this.buttonBorrow.IconChar = FontAwesome.Sharp.IconChar.HandHolding;
            this.buttonBorrow.IconColor = System.Drawing.Color.White;
            this.buttonBorrow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonBorrow.IconSize = 32;
            this.buttonBorrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBorrow.Location = new System.Drawing.Point(0, 330);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonBorrow.Size = new System.Drawing.Size(200, 60);
            this.buttonBorrow.TabIndex = 4;
            this.buttonBorrow.Text = "Borrow";
            this.buttonBorrow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBorrow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBorrow.UseVisualStyleBackColor = true;
            // 
            // buttonReserve
            // 
            this.buttonReserve.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReserve.FlatAppearance.BorderSize = 0;
            this.buttonReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReserve.ForeColor = System.Drawing.Color.White;
            this.buttonReserve.IconChar = FontAwesome.Sharp.IconChar.BusinessTime;
            this.buttonReserve.IconColor = System.Drawing.Color.White;
            this.buttonReserve.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonReserve.IconSize = 32;
            this.buttonReserve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReserve.Location = new System.Drawing.Point(0, 270);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonReserve.Size = new System.Drawing.Size(200, 60);
            this.buttonReserve.TabIndex = 3;
            this.buttonReserve.Text = "Reserve";
            this.buttonReserve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReserve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReserve.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.buttonSearch.IconColor = System.Drawing.Color.White;
            this.buttonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSearch.IconSize = 32;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(0, 210);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonSearch.Size = new System.Drawing.Size(200, 60);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBrowse.FlatAppearance.BorderSize = 0;
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowse.ForeColor = System.Drawing.Color.White;
            this.buttonBrowse.IconChar = FontAwesome.Sharp.IconChar.Swatchbook;
            this.buttonBrowse.IconColor = System.Drawing.Color.White;
            this.buttonBrowse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonBrowse.IconSize = 32;
            this.buttonBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBrowse.Location = new System.Drawing.Point(0, 150);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonBrowse.Size = new System.Drawing.Size(200, 60);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.iconButton1_Click);
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblBookName);
            this.panel1.Controls.Add(this.txtPublishYear);
            this.panel1.Controls.Add(this.btnSearchYear);
            this.panel1.Controls.Add(this.btnSearchAuthor);
            this.panel1.Controls.Add(this.txtAuthorName);
            this.panel1.Controls.Add(this.txtCategoryName);
            this.panel1.Controls.Add(this.btnSearchCategory);
            this.panel1.Location = new System.Drawing.Point(110, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 192);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtPublishYear
            // 
            this.txtPublishYear.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPublishYear.Location = new System.Drawing.Point(26, 53);
            this.txtPublishYear.Name = "txtPublishYear";
            this.txtPublishYear.Size = new System.Drawing.Size(100, 20);
            this.txtPublishYear.TabIndex = 5;
            this.txtPublishYear.Text = "Public year";
            this.txtPublishYear.TextChanged += new System.EventHandler(this.txtPublishYear_TextChanged);
            this.txtPublishYear.Enter += new System.EventHandler(this.txtPublishYear_TextChanged);
            // 
            // btnSearchYear
            // 
            this.btnSearchYear.Location = new System.Drawing.Point(132, 51);
            this.btnSearchYear.Name = "btnSearchYear";
            this.btnSearchYear.Size = new System.Drawing.Size(94, 23);
            this.btnSearchYear.TabIndex = 6;
            this.btnSearchYear.Text = "Search Year";
            this.btnSearchYear.UseVisualStyleBackColor = true;
            this.btnSearchYear.Click += new System.EventHandler(this.btnSearchYear_Click);
            // 
            // btnSearchAuthor
            // 
            this.btnSearchAuthor.Location = new System.Drawing.Point(133, 120);
            this.btnSearchAuthor.Name = "btnSearchAuthor";
            this.btnSearchAuthor.Size = new System.Drawing.Size(93, 23);
            this.btnSearchAuthor.TabIndex = 13;
            this.btnSearchAuthor.Text = "Search Author";
            this.btnSearchAuthor.UseVisualStyleBackColor = true;
            this.btnSearchAuthor.Click += new System.EventHandler(this.btnSearchAuthor_Click);
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAuthorName.Location = new System.Drawing.Point(26, 120);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(100, 20);
            this.txtAuthorName.TabIndex = 12;
            this.txtAuthorName.Text = "Author Name";
            this.txtAuthorName.Click += new System.EventHandler(this.txtAuthorName_TextChanged);
            this.txtAuthorName.TextChanged += new System.EventHandler(this.txtAuthorName_TextChanged);
            this.txtAuthorName.Enter += new System.EventHandler(this.txtAuthorName_TextChanged);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCategoryName.Location = new System.Drawing.Point(26, 86);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(100, 20);
            this.txtCategoryName.TabIndex = 9;
            this.txtCategoryName.Text = "Category Name";
            this.txtCategoryName.Click += new System.EventHandler(this.txtCategoryName_TextChanged);
            this.txtCategoryName.TextChanged += new System.EventHandler(this.txtCategoryName_TextChanged);
            this.txtCategoryName.Enter += new System.EventHandler(this.txtCategoryName_TextChanged);
            // 
            // btnSearchCategory
            // 
            this.btnSearchCategory.Location = new System.Drawing.Point(132, 84);
            this.btnSearchCategory.Name = "btnSearchCategory";
            this.btnSearchCategory.Size = new System.Drawing.Size(94, 23);
            this.btnSearchCategory.TabIndex = 10;
            this.btnSearchCategory.Text = "Search Category";
            this.btnSearchCategory.UseVisualStyleBackColor = true;
            this.btnSearchCategory.Click += new System.EventHandler(this.btnSearchCategory_Click);
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.BackColor = System.Drawing.Color.SteelBlue;
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.ForeColor = System.Drawing.Color.Snow;
            this.lblBookName.Location = new System.Drawing.Point(342, 82);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(143, 25);
            this.lblBookName.TabIndex = 17;
            this.lblBookName.Text = "Choice book";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.SteelBlue;
            this.labelUser.ForeColor = System.Drawing.Color.Snow;
            this.labelUser.Location = new System.Drawing.Point(592, 31);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(58, 13);
            this.labelUser.TabIndex = 16;
            this.labelUser.Text = "User Level";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelUser.TextChanged += new System.EventHandler(this.Media_Load);
            this.labelUser.Click += new System.EventHandler(this.labelUser_Click);
            // 
            // Media
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 548);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Name = "Media";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media";
            this.panelDesktop.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelMediaChild.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelMediaBar.ResumeLayout(false);
            this.panelMediaBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton buttonReserve;
        private FontAwesome.Sharp.IconButton buttonSearch;
        private FontAwesome.Sharp.IconButton buttonBrowse;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton buttonBorrow;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelMediaChild;
        private System.Windows.Forms.Panel panelMediaBar;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton buttonCancel;

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPublishYear;
        private System.Windows.Forms.Button btnSearchYear;
        private System.Windows.Forms.Button btnSearchAuthor;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button btnSearchCategory;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label labelUser;
    }
}