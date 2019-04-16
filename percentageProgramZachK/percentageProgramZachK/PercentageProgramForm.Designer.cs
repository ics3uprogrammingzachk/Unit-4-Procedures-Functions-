namespace percentageProgramZachK
{
    partial class PercentageProgramForm
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
            this.txtMark = new System.Windows.Forms.TextBox();
            this.lblMark = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(134, 112);
            this.txtMark.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(64, 20);
            this.txtMark.TabIndex = 0;
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Location = new System.Drawing.Point(26, 112);
            this.lblMark.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(81, 13);
            this.lblMark.TabIndex = 1;
            this.lblMark.Text = "Enter your mark";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(135, 149);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(63, 27);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // PercentageProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 229);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.txtMark);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PercentageProgramForm";
            this.Text = "Percentage Program Zach K";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.Button btnConvert;
    }
}

