namespace AccountsForms
{
    partial class RegisterFrom
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
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtUsername = new System.Windows.Forms.TextBox();
            this._txtSurname = new System.Windows.Forms.TextBox();
            this._txtCheckPassword = new System.Windows.Forms.TextBox();
            this._txtPassword = new System.Windows.Forms.TextBox();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(12, 59);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(320, 27);
            this._txtName.TabIndex = 0;
            // 
            // _txtUsername
            // 
            this._txtUsername.Location = new System.Drawing.Point(12, 178);
            this._txtUsername.Name = "_txtUsername";
            this._txtUsername.Size = new System.Drawing.Size(320, 27);
            this._txtUsername.TabIndex = 1;
            // 
            // _txtSurname
            // 
            this._txtSurname.Location = new System.Drawing.Point(12, 121);
            this._txtSurname.Name = "_txtSurname";
            this._txtSurname.Size = new System.Drawing.Size(320, 27);
            this._txtSurname.TabIndex = 2;
            // 
            // _txtCheckPassword
            // 
            this._txtCheckPassword.Location = new System.Drawing.Point(398, 121);
            this._txtCheckPassword.Name = "_txtCheckPassword";
            this._txtCheckPassword.PasswordChar = '*';
            this._txtCheckPassword.Size = new System.Drawing.Size(320, 27);
            this._txtCheckPassword.TabIndex = 3;
            // 
            // _txtPassword
            // 
            this._txtPassword.Location = new System.Drawing.Point(398, 59);
            this._txtPassword.Name = "_txtPassword";
            this._txtPassword.PasswordChar = '*';
            this._txtPassword.Size = new System.Drawing.Size(320, 27);
            this._txtPassword.TabIndex = 4;
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(398, 176);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(94, 29);
            this._btnCancel.TabIndex = 5;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _btnRegister
            // 
            this._btnRegister.Location = new System.Drawing.Point(624, 176);
            this._btnRegister.Name = "_btnRegister";
            this._btnRegister.Size = new System.Drawing.Size(94, 29);
            this._btnRegister.TabIndex = 6;
            this._btnRegister.Text = "Register";
            this._btnRegister.UseVisualStyleBackColor = true;
            this._btnRegister.Click += new System.EventHandler(this._btnRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Confirm Password";
            // 
            // RegisterFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 274);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnRegister);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._txtPassword);
            this.Controls.Add(this._txtCheckPassword);
            this.Controls.Add(this._txtSurname);
            this.Controls.Add(this._txtUsername);
            this.Controls.Add(this._txtName);
            this.Name = "RegisterFrom";
            this.Text = "RegisterFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox _txtName;
        private TextBox _txtUsername;
        private TextBox _txtSurname;
        private TextBox _txtCheckPassword;
        private TextBox _txtPassword;
        private Button _btnCancel;
        private Button _btnRegister;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}