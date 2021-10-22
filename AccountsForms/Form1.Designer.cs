namespace AccountsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._btnLogin = new System.Windows.Forms.Button();
            this._txtUsername = new System.Windows.Forms.TextBox();
            this._txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._lblRegister = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnLogin
            // 
            this._btnLogin.Location = new System.Drawing.Point(315, 207);
            this._btnLogin.Name = "_btnLogin";
            this._btnLogin.Size = new System.Drawing.Size(94, 29);
            this._btnLogin.TabIndex = 0;
            this._btnLogin.Text = "Login";
            this._btnLogin.UseVisualStyleBackColor = true;
            this._btnLogin.Click += new System.EventHandler(this._btnLogin_Click);
            // 
            // _txtUsername
            // 
            this._txtUsername.Location = new System.Drawing.Point(12, 28);
            this._txtUsername.Name = "_txtUsername";
            this._txtUsername.Size = new System.Drawing.Size(288, 27);
            this._txtUsername.TabIndex = 1;
            // 
            // _txtPassword
            // 
            this._txtPassword.Location = new System.Drawing.Point(12, 106);
            this._txtPassword.Name = "_txtPassword";
            this._txtPassword.Size = new System.Drawing.Size(288, 27);
            this._txtPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // _lblRegister
            // 
            this._lblRegister.AutoSize = true;
            this._lblRegister.Location = new System.Drawing.Point(12, 211);
            this._lblRegister.Name = "_lblRegister";
            this._lblRegister.Size = new System.Drawing.Size(87, 20);
            this._lblRegister.TabIndex = 5;
            this._lblRegister.Text = "Založit účet";
            this._lblRegister.Click += new System.EventHandler(this._lblRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 262);
            this.Controls.Add(this._lblRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtPassword);
            this.Controls.Add(this._txtUsername);
            this.Controls.Add(this._btnLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button _btnLogin;
        private TextBox _txtUsername;
        private TextBox _txtPassword;
        private Label label1;
        private Label label2;
        private Label _lblRegister;
    }
}