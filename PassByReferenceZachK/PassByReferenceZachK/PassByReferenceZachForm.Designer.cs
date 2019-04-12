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
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblDecimal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(240, 51);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 0;
            // 
            // nudDecimal
            // 
            this.nudDecimal.Location = new System.Drawing.Point(240, 91);
            this.nudDecimal.Name = "nudDecimal";
            this.nudDecimal.Size = new System.Drawing.Size(120, 20);
            this.nudDecimal.TabIndex = 1;
            // 
            // btnRound
            // 
            this.btnRound.Location = new System.Drawing.Point(240, 137);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(75, 23);
            this.btnRound.TabIndex = 2;
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Location = new System.Drawing.Point(12, 54);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(179, 13);
            this.lblEnter.TabIndex = 3;
            this.lblEnter.Text = "Enter the number you want to round:";
            // 
            // lblDecimal
            // 
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.Location = new System.Drawing.Point(12, 93);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(222, 13);
            this.lblDecimal.TabIndex = 4;
            this.lblDecimal.Text = "Enter the amount of decimal places you want:";
            // 
            // PassByReferenceZachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 261);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.lblEnter);
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
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblDecimal;
    }
}

