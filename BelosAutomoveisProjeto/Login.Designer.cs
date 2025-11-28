namespace BelosAutomoveisProjeto
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            signin = new Button();
            username = new TextBox();
            password = new TextBox();
            showPass = new CheckBox();
            SuspendLayout();
            // 
            // signin
            // 
            signin.BackColor = Color.Transparent;
            signin.FlatAppearance.BorderSize = 0;
            signin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            signin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            signin.FlatStyle = FlatStyle.Flat;
            signin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            signin.ForeColor = SystemColors.Control;
            signin.Location = new Point(1297, 675);
            signin.Name = "signin";
            signin.Size = new Size(276, 61);
            signin.TabIndex = 0;
            signin.Text = "SIGN IN";
            signin.UseVisualStyleBackColor = false;
            signin.Click += button1_Click;
            // 
            // username
            // 
            username.BackColor = Color.White;
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(1227, 437);
            username.Name = "username";
            username.Size = new Size(420, 28);
            username.TabIndex = 1;
            // 
            // password
            // 
            password.BackColor = Color.White;
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(1227, 551);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(420, 28);
            password.TabIndex = 2;
            // 
            // showPass
            // 
            showPass.AutoSize = true;
            showPass.BackColor = Color.Transparent;
            showPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            showPass.ForeColor = Color.White;
            showPass.Location = new Point(1222, 606);
            showPass.Name = "showPass";
            showPass.Size = new Size(139, 25);
            showPass.TabIndex = 3;
            showPass.Text = "Show password";
            showPass.UseVisualStyleBackColor = false;
            showPass.CheckedChanged += showPass_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(showPass);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(signin);
            Name = "Login";
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signin;
        private TextBox username;
        private TextBox password;
        private CheckBox showPass;
    }
}