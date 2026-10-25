namespace FitFlexAutomation
{
    partial class FormCheckIn
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
            this.txtQRCodeCheck = new System.Windows.Forms.TextBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtQRCodeCheck
            // 
            this.txtQRCodeCheck.Location = new System.Drawing.Point(47, 29);
            this.txtQRCodeCheck.Name = "txtQRCodeCheck";
            this.txtQRCodeCheck.Size = new System.Drawing.Size(132, 22);
            this.txtQRCodeCheck.TabIndex = 0;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(57, 74);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(134, 36);
            this.btnCheckIn.TabIndex = 1;
            this.btnCheckIn.Text = "Geçiş Yap";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(24, 132);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 2;
            // 
            // FormCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 173);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.txtQRCodeCheck);
            this.Name = "FormCheckIn";
            this.Text = "FormCheckIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQRCodeCheck;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label lblResult;
    }
}