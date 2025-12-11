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
            label1 = new Label();
            label2 = new Label();
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
            signin.Location = new Point(1482, 900);
            signin.Margin = new Padding(3, 4, 3, 4);
            signin.Name = "signin";
            signin.Size = new Size(315, 81);
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
            username.Location = new Point(1402, 583);
            username.Margin = new Padding(3, 4, 3, 4);
            username.Name = "username";
            username.Size = new Size(480, 35);
            username.TabIndex = 1;
            // 
            // password
            // 
            password.BackColor = Color.White;
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(1402, 735);
            password.Margin = new Padding(3, 4, 3, 4);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(480, 35);
            password.TabIndex = 2;
            // 
            // showPass
            // 
            showPass.AutoSize = true;
            showPass.BackColor = Color.Transparent;
            showPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            showPass.ForeColor = Color.White;
            showPass.Location = new Point(1397, 808);
            showPass.Margin = new Padding(3, 4, 3, 4);
            showPass.Name = "showPass";
            showPass.Size = new Size(170, 32);
            showPass.TabIndex = 3;
            showPass.Text = "Show password";
            showPass.UseVisualStyleBackColor = false;
            showPass.CheckedChanged += showPass_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(1529, 992);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 4;
            label1.Text = "Don't have an account?";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(1679, 992);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 5;
            label2.Text = "Create one";
            label2.Click += label2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(2176, 1325);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(showPass);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(signin);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label1;
        private Label label2;
    }
}