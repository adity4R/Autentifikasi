namespace NSchoolApp
{
    partial class FormRegister
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
            txtPassword = new TextBox();
            txtFullName = new TextBox();
            txtUsername = new TextBox();
            btnSubmitRegister = new Button();
            btnNavToLogin = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            txtPassword.Location = new Point(101, 218);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password...";
            txtPassword.Size = new Size(228, 34);
            txtPassword.TabIndex = 0;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            txtFullName.Location = new Point(104, 92);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Full Name...";
            txtFullName.Size = new Size(225, 34);
            txtFullName.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            txtUsername.Location = new Point(101, 155);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username...";
            txtUsername.Size = new Size(228, 34);
            txtUsername.TabIndex = 2;
            // 
            // btnSubmitRegister
            // 
            btnSubmitRegister.BackColor = Color.MediumSeaGreen;
            btnSubmitRegister.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnSubmitRegister.Location = new Point(101, 283);
            btnSubmitRegister.Name = "btnSubmitRegister";
            btnSubmitRegister.Size = new Size(228, 51);
            btnSubmitRegister.TabIndex = 3;
            btnSubmitRegister.Text = "Register";
            btnSubmitRegister.UseVisualStyleBackColor = false;
            // 
            // btnNavToLogin
            // 
            btnNavToLogin.BackColor = Color.ForestGreen;
            btnNavToLogin.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnNavToLogin.Location = new Point(101, 362);
            btnNavToLogin.Name = "btnNavToLogin";
            btnNavToLogin.Size = new Size(228, 49);
            btnNavToLogin.TabIndex = 4;
            btnNavToLogin.Text = "To Login";
            btnNavToLogin.UseVisualStyleBackColor = false;
            btnNavToLogin.Click += btnNavToLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(113, 22);
            label1.Name = "label1";
            label1.Size = new Size(213, 38);
            label1.TabIndex = 5;
            label1.Text = "Form Register";
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(451, 450);
            Controls.Add(label1);
            Controls.Add(btnNavToLogin);
            Controls.Add(btnSubmitRegister);
            Controls.Add(txtUsername);
            Controls.Add(txtFullName);
            Controls.Add(txtPassword);
            Name = "FormRegister";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtFullName;
        private TextBox txtUsername;
        private Button btnSubmitRegister;
        private Button btnNavToLogin;
        private Label label1;
    }
}