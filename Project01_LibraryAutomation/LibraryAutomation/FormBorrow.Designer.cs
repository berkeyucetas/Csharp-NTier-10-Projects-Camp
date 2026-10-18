namespace LibraryAutomation
{
    partial class FormBorrow
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
            this.dataGridViewActiveBorrows = new System.Windows.Forms.DataGridView();
            this.cmbMembers = new System.Windows.Forms.ComboBox();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGiveBorrow = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiveBorrows)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewActiveBorrows
            // 
            this.dataGridViewActiveBorrows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActiveBorrows.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewActiveBorrows.Location = new System.Drawing.Point(463, 0);
            this.dataGridViewActiveBorrows.Name = "dataGridViewActiveBorrows";
            this.dataGridViewActiveBorrows.RowHeadersWidth = 51;
            this.dataGridViewActiveBorrows.RowTemplate.Height = 24;
            this.dataGridViewActiveBorrows.Size = new System.Drawing.Size(532, 582);
            this.dataGridViewActiveBorrows.TabIndex = 0;
            // 
            // cmbMembers
            // 
            this.cmbMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMembers.FormattingEnabled = true;
            this.cmbMembers.Location = new System.Drawing.Point(231, 39);
            this.cmbMembers.Name = "cmbMembers";
            this.cmbMembers.Size = new System.Drawing.Size(212, 37);
            this.cmbMembers.TabIndex = 1;
            // 
            // cmbBooks
            // 
            this.cmbBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(231, 82);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(212, 37);
            this.cmbBooks.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Üye Seçiniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kitap Seçiniz:";
            // 
            // btnGiveBorrow
            // 
            this.btnGiveBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiveBorrow.Location = new System.Drawing.Point(81, 163);
            this.btnGiveBorrow.Name = "btnGiveBorrow";
            this.btnGiveBorrow.Size = new System.Drawing.Size(283, 53);
            this.btnGiveBorrow.TabIndex = 5;
            this.btnGiveBorrow.Text = "Emanet Ver";
            this.btnGiveBorrow.UseVisualStyleBackColor = true;
            this.btnGiveBorrow.Click += new System.EventHandler(this.btnGiveBorrow_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReturnBook.Location = new System.Drawing.Point(12, 250);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(431, 53);
            this.btnReturnBook.TabIndex = 6;
            this.btnReturnBook.Text = "Seçili Kitabı Teslim Al";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // FormBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 582);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.btnGiveBorrow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBooks);
            this.Controls.Add(this.cmbMembers);
            this.Controls.Add(this.dataGridViewActiveBorrows);
            this.Name = "FormBorrow";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormBorrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiveBorrows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewActiveBorrows;
        private System.Windows.Forms.ComboBox cmbMembers;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGiveBorrow;
        private System.Windows.Forms.Button btnReturnBook;
    }
}