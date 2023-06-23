namespace Server
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
            this.Nick = new System.Windows.Forms.Label();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtMessageHistory = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nick
            // 
            this.Nick.AutoSize = true;
            this.Nick.Location = new System.Drawing.Point(10, 9);
            this.Nick.Name = "Nick";
            this.Nick.Size = new System.Drawing.Size(34, 16);
            this.Nick.TabIndex = 0;
            this.Nick.Text = "Nick";
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(59, 9);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(295, 22);
            this.txtNick.TabIndex = 1;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(8, 569);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(346, 22);
            this.txtMessage.TabIndex = 2;
            // 
            // txtMessageHistory
            // 
            this.txtMessageHistory.Location = new System.Drawing.Point(13, 40);
            this.txtMessageHistory.Multiline = true;
            this.txtMessageHistory.Name = "txtMessageHistory";
            this.txtMessageHistory.Size = new System.Drawing.Size(345, 500);
            this.txtMessageHistory.TabIndex = 3;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(360, 6);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(77, 28);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(370, 569);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(66, 21);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 603);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtMessageHistory);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.Nick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.FormClosing += new
                System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);

        }

        #endregion

        private System.Windows.Forms.Label Nick;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtMessageHistory;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnSend;
    }
}