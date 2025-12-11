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
            showPass.Location = new Point(1397, 808);
            showPass.Margin = new Padding(3, 4, 3, 4);
            showPass.Name = "showPass";
            showPass.Size = new Size(170, 32);
            showPass.TabIndex = 7;
            showPass.Text = "Show password";
            showPass.UseVisualStyleBackColor = false;
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
            password.TabIndex = 6;
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
            register.Location = new Point(1482, 900);
            register.Margin = new Padding(3, 4, 3, 4);
            register.Name = "register";
            register.Size = new Size(315, 81);
            register.TabIndex = 4;
            register.Text = "SIGN UP";
            register.UseVisualStyleBackColor = false;
            register.Click += register_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(1698, 991);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 9;
            label2.Text = "Log in";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(1537, 991);
            label1.Name = "label1";
            label1.Size = new Size(178, 20);
            label1.TabIndex = 8;
            label1.Text = "Already have an account?";
            // 
            // Signup
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
            Controls.Add(register);
            Margin = new Padding(3, 4, 3, 4);
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