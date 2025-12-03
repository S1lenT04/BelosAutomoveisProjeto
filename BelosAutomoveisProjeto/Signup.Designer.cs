namespace BelosAutomoveisProjeto
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            showPass = new CheckBox();
            password = new TextBox();
            username = new TextBox();
            register = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
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
            showPass.TabIndex = 7;
            showPass.Text = "Show password";
            showPass.UseVisualStyleBackColor = false;
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
            password.TabIndex = 6;
            // 
            // username
            // 
            username.BackColor = Color.White;
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(1227, 437);
            username.Name = "username";
            username.Size = new Size(420, 28);
            username.TabIndex = 5;
            // 
            // register
            // 
            register.BackColor = Color.Transparent;
            register.FlatAppearance.BorderSize = 0;
            register.FlatAppearance.MouseDownBackColor = Color.Transparent;
            register.FlatAppearance.MouseOverBackColor = Color.Transparent;
            register.FlatStyle = FlatStyle.Flat;
            register.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            register.ForeColor = SystemColors.Control;
            register.Location = new Point(1297, 675);
            register.Name = "register";
            register.Size = new Size(276, 61);
            register.TabIndex = 4;
            register.Text = "SIGN UP";
            register.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(1486, 743);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 9;
            label2.Text = "Log in";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(1345, 743);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 8;
            label1.Text = "Already have an account?";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(showPass);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(register);
            Name = "Signup";
            Text = "Signup";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox showPass;
        private TextBox password;
        private TextBox username;
        private Button register;
        private Label label2;
        private Label label1;
    }
}