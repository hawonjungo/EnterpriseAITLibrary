
namespace AITLibraryBooks9
{
    partial class BookBrowseSearch
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListAllBooks = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPublishYear = new System.Windows.Forms.TextBox();
            this.btnPublishYearSearch = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.btnSearchAuthorName = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.btnReserveThis = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReserveCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "AIT Library Browse/Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User name goes here";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(889, 250);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnListAllBooks
            // 
            this.btnListAllBooks.Location = new System.Drawing.Point(351, 308);
            this.btnListAllBooks.Name = "btnListAllBooks";
            this.btnListAllBooks.Size = new System.Drawing.Size(100, 23);
            this.btnListAllBooks.TabIndex = 3;
            this.btnListAllBooks.Text = "List all books";
            this.btnListAllBooks.UseVisualStyleBackColor = true;
            this.btnListAllBooks.Click += new System.EventHandler(this.btnListAllBooks_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Publish year:";
            // 
            // txtPublishYear
            // 
            this.txtPublishYear.Location = new System.Drawing.Point(124, 388);
            this.txtPublishYear.Name = "txtPublishYear";
            this.txtPublishYear.Size = new System.Drawing.Size(100, 20);
            this.txtPublishYear.TabIndex = 5;
            // 
            // btnPublishYearSearch
            // 
            this.btnPublishYearSearch.Location = new System.Drawing.Point(230, 386);
            this.btnPublishYearSearch.Name = "btnPublishYearSearch";
            this.btnPublishYearSearch.Size = new System.Drawing.Size(75, 23);
            this.btnPublishYearSearch.TabIndex = 6;
            this.btnPublishYearSearch.Text = "Search";
            this.btnPublishYearSearch.UseVisualStyleBackColor = true;
            this.btnPublishYearSearch.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(830, 453);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Category Name:";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(124, 421);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(100, 20);
            this.txtCategoryName.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(230, 419);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Author Name:";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(124, 455);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(100, 20);
            this.txtAuthorName.TabIndex = 12;
            // 
            // btnSearchAuthorName
            // 
            this.btnSearchAuthorName.Location = new System.Drawing.Point(231, 455);
            this.btnSearchAuthorName.Name = "btnSearchAuthorName";
            this.btnSearchAuthorName.Size = new System.Drawing.Size(75, 23);
            this.btnSearchAuthorName.TabIndex = 13;
            this.btnSearchAuthorName.Text = "Search";
            this.btnSearchAuthorName.UseVisualStyleBackColor = true;
            this.btnSearchAuthorName.Click += new System.EventHandler(this.btnSearchAuthorName_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "(uses SQL SELECT ... LIKE ... )";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(660, 313);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(111, 13);
            this.lblBookName.TabIndex = 15;
            this.lblBookName.Text = "Name of book clicked";
            // 
            // btnReserveThis
            // 
            this.btnReserveThis.Location = new System.Drawing.Point(577, 329);
            this.btnReserveThis.Name = "btnReserveThis";
            this.btnReserveThis.Size = new System.Drawing.Size(115, 23);
            this.btnReserveThis.TabIndex = 16;
            this.btnReserveThis.Text = "Reserve this book";
            this.btnReserveThis.UseVisualStyleBackColor = true;
            this.btnReserveThis.Click += new System.EventHandler(this.btnReserveThis_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(574, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Book Selected:";
            // 
            // btnReserveCancel
            // 
            this.btnReserveCancel.Location = new System.Drawing.Point(577, 359);
            this.btnReserveCancel.Name = "btnReserveCancel";
            this.btnReserveCancel.Size = new System.Drawing.Size(115, 23);
            this.btnReserveCancel.TabIndex = 18;
            this.btnReserveCancel.Text = "Cancel Reservation";
            this.btnReserveCancel.UseVisualStyleBackColor = true;
            // 
            // BookBrowseSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(951, 494);
            this.Controls.Add(this.btnReserveCancel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnReserveThis);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSearchAuthorName);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnPublishYearSearch);
            this.Controls.Add(this.txtPublishYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnListAllBooks);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookBrowseSearch";
            this.Text = "BookBrowseSearch";
            this.Load += new System.EventHandler(this.BookBrowseSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListAllBooks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPublishYear;
        private System.Windows.Forms.Button btnPublishYearSearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Button btnSearchAuthorName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Button btnReserveThis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReserveCancel;
    }
}