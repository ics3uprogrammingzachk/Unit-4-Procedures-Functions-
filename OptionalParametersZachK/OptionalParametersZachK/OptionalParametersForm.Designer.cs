namespace OptionalParametersZachK
{
    partial class OptionalParametersForm
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
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtAptNumber = new System.Windows.Forms.TextBox();
            this.lblEnter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(246, 80);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(100, 20);
            this.txtStreetAddress.TabIndex = 1;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(246, 116);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 2;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(246, 151);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(100, 20);
            this.txtProvince.TabIndex = 3;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(246, 186);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCode.TabIndex = 4;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(246, 226);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(100, 23);
            this.btnDone.TabIndex = 5;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtAptNumber
            // 
            this.txtAptNumber.Location = new System.Drawing.Point(246, 45);
            this.txtAptNumber.Name = "txtAptNumber";
            this.txtAptNumber.Size = new System.Drawing.Size(100, 20);
            this.txtAptNumber.TabIndex = 6;
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.Location = new System.Drawing.Point(12, 44);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(232, 162);
            this.lblEnter.TabIndex = 7;
            this.lblEnter.Text = "Enter your Apt. Number (optional):\r\n\r\nEnter your Street Address:\r\n\r\nEnter your Ci" +
    "ty:\r\n\r\nEnter your Province:\r\n\r\nEnter your Postal Code:";
            // 
            // OptionalParametersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 261);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.txtAptNumber);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtStreetAddress);
            this.Name = "OptionalParametersForm";
            this.Text = "Optional Parameters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtAptNumber;
        private System.Windows.Forms.Label lblEnter;
    }
}

