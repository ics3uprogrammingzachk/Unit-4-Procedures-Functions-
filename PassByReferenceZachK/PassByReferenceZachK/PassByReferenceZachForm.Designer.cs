namespace PassByReferenceZachK
{
    partial class PassByReferenceZachForm
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.nudDecimal = new System.Windows.Forms.NumericUpDown();
            this.btnRound = new System.Windows.Forms.Button();
            this.lblRoundedNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(156, 47);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 0;
            // 
            // nudDecimal
            // 
            this.nudDecimal.Location = new System.Drawing.Point(156, 121);
            this.nudDecimal.Name = "nudDecimal";
            this.nudDecimal.Size = new System.Drawing.Size(120, 20);
            this.nudDecimal.TabIndex = 1;
            // 
            // btnRound
            // 
            this.btnRound.Location = new System.Drawing.Point(32, 86);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(75, 23);
            this.btnRound.TabIndex = 2;
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // lblRoundedNumber
            // 
            this.lblRoundedNumber.AutoSize = true;
            this.lblRoundedNumber.Location = new System.Drawing.Point(169, 183);
            this.lblRoundedNumber.Name = "lblRoundedNumber";
            this.lblRoundedNumber.Size = new System.Drawing.Size(35, 13);
            this.lblRoundedNumber.TabIndex = 3;
            this.lblRoundedNumber.Text = "label1";
            // 
            // PassByReferenceZachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblRoundedNumber);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.nudDecimal);
            this.Controls.Add(this.txtNumber);
            this.Name = "PassByReferenceZachForm";
            this.Text = "Pass by Reference Zach K";
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.NumericUpDown nudDecimal;
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.Label lblRoundedNumber;
    }
}

