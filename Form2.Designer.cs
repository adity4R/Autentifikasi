namespace NSchoolApp
{
    partial class FormLogin
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnSubmitLogin = new Button();
            btnNavToRegister = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(107, 96);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username...";
            txtUsername.Size = new Size(231, 34);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(107, 171);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password....";
            txtPassword.Size = new Size(231, 34);
            txtPassword.TabIndex = 1;
            // 
            // btnSubmitLogin
            // 
            btnSubmitLogin.BackColor = Color.BurlyWood;
            btnSubmitLogin.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitLogin.Location = new Point(107, 235);
            btnSubmitLogin.Name = "btnSubmitLogin";
            btnSubmitLogin.Size = new Size(231, 51);
            btnSubmitLogin.TabIndex = 2;
            btnSubmitLogin.Text = "Login";
            btnSubmitLogin.UseVisualStyleBackColor = false;
            btnSubmitLogin.Click += btnSubmitLogin_Click;
            // 
            // btnNavToRegister
            // 
            btnNavToRegister.BackColor = Color.Peru;
            btnNavToRegister.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavToRegister.Location = new Point(107, 292);
            btnNavToRegister.Name = "btnNavToRegister";
            btnNavToRegister.Size = new Size(231, 55);
            btnNavToRegister.TabIndex = 3;
            btnNavToRegister.Text = "To Register";
            btnNavToRegister.UseVisualStyleBackColor = false;
            btnNavToRegister.Click += btnNavToRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(130, 36);
            label1.Name = "label1";
            label1.Size = new Size(175, 38);
            label1.TabIndex = 4;
            label1.Text = "Form Login";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(455, 450);
            Controls.Add(label1);
            Controls.Add(btnNavToRegister);
            Controls.Add(btnSubmitLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "FormLogin";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnSubmitLogin;
        private Button btnNavToRegister;
        private Label label1;
    }
}