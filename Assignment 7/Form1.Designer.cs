namespace Assignment_7
{
    partial class Form1
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
            this.btnThrow = new System.Windows.Forms.Button();
            this.lbldice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThrow
            // 
            this.btnThrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThrow.Location = new System.Drawing.Point(150, 187);
            this.btnThrow.Name = "btnThrow";
            this.btnThrow.Size = new System.Drawing.Size(107, 34);
            this.btnThrow.TabIndex = 0;
            this.btnThrow.Text = "&Throw";
            this.btnThrow.UseVisualStyleBackColor = true;
            this.btnThrow.Click += new System.EventHandler(this.btnThrow_Click);
            // 
            // lbldice
            // 
            this.lbldice.AutoSize = true;
            this.lbldice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldice.Location = new System.Drawing.Point(39, 11);
            this.lbldice.Name = "lbldice";
            this.lbldice.Size = new System.Drawing.Size(0, 20);
            this.lbldice.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 233);
            this.Controls.Add(this.lbldice);
            this.Controls.Add(this.btnThrow);
            this.Name = "Form1";
            this.Text = "Assignment 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThrow;
        private System.Windows.Forms.Label lbldice;
    }
}

