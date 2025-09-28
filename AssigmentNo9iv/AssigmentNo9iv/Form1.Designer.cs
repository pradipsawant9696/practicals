namespace AssigmentNo9iv
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
            this.lblTo = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.rtbBody = new System.Windows.Forms.RichTextBox();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.lblLimit = new System.Windows.Forms.Label();
            this.nudCharLimit = new System.Windows.Forms.NumericUpDown();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(26, 23);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(35, 16);
            this.lblTo.TabIndex = 0;
            this.lblTo.Text = "TO : ";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(26, 63);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(61, 16);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "Subject : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Body : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(192, 16);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(307, 22);
            this.txtTo.TabIndex = 3;
            this.txtTo.TextChanged += new System.EventHandler(this.txtTo_TextChanged);
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(192, 60);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(307, 22);
            this.txtSubject.TabIndex = 4;
            this.txtSubject.TextChanged += new System.EventHandler(this.txtSubject_TextChanged);
            // 
            // rtbBody
            // 
            this.rtbBody.Location = new System.Drawing.Point(29, 140);
            this.rtbBody.MaxLength = 256;
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.Size = new System.Drawing.Size(470, 185);
            this.rtbBody.TabIndex = 5;
            this.rtbBody.Text = "";
            this.rtbBody.TextChanged += new System.EventHandler(this.rtbBody_TextChanged);
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Location = new System.Drawing.Point(26, 342);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(130, 16);
            this.lblRemaining.TabIndex = 6;
            this.lblRemaining.Text = "Remaining: 256 / 256";
            this.lblRemaining.Click += new System.EventHandler(this.lblRemaining_Click);
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(328, 342);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(66, 16);
            this.lblLimit.TabIndex = 7;
            this.lblLimit.Text = "Set Limit : ";
            // 
            // nudCharLimit
            // 
            this.nudCharLimit.Location = new System.Drawing.Point(400, 340);
            this.nudCharLimit.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCharLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCharLimit.Name = "nudCharLimit";
            this.nudCharLimit.Size = new System.Drawing.Size(98, 22);
            this.nudCharLimit.TabIndex = 8;
            this.nudCharLimit.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nudCharLimit.ValueChanged += new System.EventHandler(this.nudCharLimit_ValueChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(29, 386);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(167, 38);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send Email";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(332, 386);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(167, 38);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 530);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.nudCharLimit);
            this.Controls.Add(this.lblLimit);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.rtbBody);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblTo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudCharLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.RichTextBox rtbBody;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.NumericUpDown nudCharLimit;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;
    }
}

