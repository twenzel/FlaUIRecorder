namespace FlaUIRecorder
{
    partial class ExceptionForm
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
            this.txtErrorMessage = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCopyError = new System.Windows.Forms.Button();
            this.chkboxShowDetails = new System.Windows.Forms.CheckBox();
            this.chkboxShowStackTrace = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtErrorMessage
            // 
            this.txtErrorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtErrorMessage.Location = new System.Drawing.Point(12, 12);
            this.txtErrorMessage.Multiline = true;
            this.txtErrorMessage.Name = "txtErrorMessage";
            this.txtErrorMessage.ReadOnly = true;
            this.txtErrorMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtErrorMessage.Size = new System.Drawing.Size(410, 280);
            this.txtErrorMessage.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(347, 340);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCopyError
            // 
            this.btnCopyError.Location = new System.Drawing.Point(347, 298);
            this.btnCopyError.Name = "btnCopyError";
            this.btnCopyError.Size = new System.Drawing.Size(75, 23);
            this.btnCopyError.TabIndex = 3;
            this.btnCopyError.Text = "&Copy Error";
            this.btnCopyError.UseVisualStyleBackColor = true;
            this.btnCopyError.Click += new System.EventHandler(this.BtnCopyError_Click);
            // 
            // chkboxShowDetails
            // 
            this.chkboxShowDetails.AutoSize = true;
            this.chkboxShowDetails.Location = new System.Drawing.Point(12, 298);
            this.chkboxShowDetails.Name = "chkboxShowDetails";
            this.chkboxShowDetails.Size = new System.Drawing.Size(86, 17);
            this.chkboxShowDetails.TabIndex = 1;
            this.chkboxShowDetails.Text = "Show &details";
            this.chkboxShowDetails.UseVisualStyleBackColor = true;
            this.chkboxShowDetails.CheckedChanged += new System.EventHandler(this.ChkboxShowDetails_CheckedChanged);
            // 
            // chkboxShowStackTrace
            // 
            this.chkboxShowStackTrace.AutoSize = true;
            this.chkboxShowStackTrace.Location = new System.Drawing.Point(104, 298);
            this.chkboxShowStackTrace.Name = "chkboxShowStackTrace";
            this.chkboxShowStackTrace.Size = new System.Drawing.Size(112, 17);
            this.chkboxShowStackTrace.TabIndex = 2;
            this.chkboxShowStackTrace.Text = "&Show StackTrace";
            this.chkboxShowStackTrace.UseVisualStyleBackColor = true;
            this.chkboxShowStackTrace.CheckedChanged += new System.EventHandler(this.ChkboxShowStackTrace_CheckedChanged);
            // 
            // ExceptionForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 374);
            this.Controls.Add(this.chkboxShowStackTrace);
            this.Controls.Add(this.chkboxShowDetails);
            this.Controls.Add(this.btnCopyError);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtErrorMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExceptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exception occured";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtErrorMessage;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCopyError;
        private System.Windows.Forms.CheckBox chkboxShowDetails;
        private System.Windows.Forms.CheckBox chkboxShowStackTrace;
    }
}